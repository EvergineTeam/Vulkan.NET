using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VulkanRaytracing.Structs;
using WaveEngine.Bindings.Vulkan;

namespace VulkanRaytracing
{
    public unsafe class VulkanMain
    {
        VkDevice device;
        VkInstance instance;
        VkPhysicalDevice physicalDevice;

        VkQueue queue;
        VkCommandPool commandPool;

        VkPipeline pipeline;
        VkPipelineLayout pipelineLayout;

        VkDescriptorSet descriptorSet;
        VkDescriptorPool descriptorPool;
        VkDescriptorSetLayout descriptorSetLayout;

        VkSurfaceKHR surface;
        VkSwapchainKHR swapchain;

        VkSemaphore* semaphoreImageAvailable;
        VkSemaphore* semaphoreRenderingAvailable = null;

        VkImage offscreenBuffer;
        VkImageView offscreenBufferView;
        VkDeviceMemory offscreenBufferMemory;

        AccelerationMemory shaderBindingTable;
        uint shaderBindingTableSize = 0;
        uint shaderBindingTableGroupCount = 3;

        VkAccelerationStructureKHR bottomLevelAS;
        ulong bottomLevelASHandle = 0;
        VkAccelerationStructureKHR topLevelAS;
        ulong topLevelASHandle = 0;

        uint desiredWindowWidth = 640;
        uint desiredWindowHeight = 480;
        VkFormat desiredSurfaceFormat = VkFormat.VK_FORMAT_B8G8R8A8_UNORM;

        Form window;
        IntPtr windowInstance;

        VkCommandBuffer[] commandBuffers;
        private VkPhysicalDeviceRayTracingPropertiesKHR rayTracingProperties;
        private VkAccelerationStructureGeometryKHR[] accelerationGeometries;

        string appName = "VK_KHR_ray_tracing triangle";

        string[] instanceExtensions = new string[] {
            "VK_KHR_surface",
            "VK_KHR_win32_surface",
            "VK_KHR_get_physical_device_properties2"
        };

        string[] validationLayers = new string[] {
            "VK_LAYER_KHRONOS_validation"
        };

        string[] deviceExtensions = new string[] {
            "VK_KHR_swapchain",
            "VK_KHR_ray_tracing",
            "VK_KHR_pipeline_library",
            "VK_EXT_descriptor_indexing",
            "VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations",
            "VK_KHR_get_memory_requirements2",
        };

        public VkShaderModule CreateShaderModule(byte[] code)
        {
            VkShaderModule shaderModule;
            VkShaderModuleCreateInfo shaderModuleInfo = new VkShaderModuleCreateInfo();

            fixed (byte* sourcePointer = code)
            {
                shaderModuleInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO;
                shaderModuleInfo.pNext = null;
                shaderModuleInfo.codeSize = (UIntPtr)code.Length;
                shaderModuleInfo.pCode = (uint*)sourcePointer;

                var result = VulkanNative.vkCreateShaderModule(device, &shaderModuleInfo, null, &shaderModule);
                Helpers.CheckErrors(result);
            }

            return shaderModule;
        }

        public uint FindMemoryType(uint typeFilter, VkMemoryPropertyFlagBits properties)
        {
            VkPhysicalDeviceMemoryProperties memProperties;
            VulkanNative.vkGetPhysicalDeviceMemoryProperties(physicalDevice, &memProperties);
            for (int ii = 0; ii < memProperties.memoryTypeCount; ii++)
            {
                if (((typeFilter & (1 << ii)) != 0)
                    && (memProperties.GetMemoryType((uint)ii).propertyFlags & properties) == properties)
                {
                    return (uint)ii;
                }
            }
            throw new Exception("failed to find suitable memory type!");
        }

        public ulong GetBufferAddress(VkBuffer buffer)
        {
            VkBufferDeviceAddressInfo bufferAddressInfo = new VkBufferDeviceAddressInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO,
                pNext = null,
                buffer = buffer,
            };

            return VulkanNative.vkGetBufferDeviceAddress(device, &bufferAddressInfo);
        }

        public AccelerationMemory CreateMappedBuffer<T>(T[] srcData, uint byteLength)
            where T : struct
        {
            AccelerationMemory accelerationMemory = new AccelerationMemory();

            VkBufferCreateInfo bufferInfo = new VkBufferCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO,
                pNext = null,
                size = byteLength,
                usage = VkBufferUsageFlagBits.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT,
                sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE,
                queueFamilyIndexCount = 0,
                pQueueFamilyIndices = null,
            };
            var result = VulkanNative.vkCreateBuffer(device, &bufferInfo, null, &accelerationMemory.buffer);
            Helpers.CheckErrors(result);

            VkMemoryRequirements memoryRequirements = new VkMemoryRequirements();
            VulkanNative.vkGetBufferMemoryRequirements(device, accelerationMemory.buffer, &memoryRequirements);

            VkMemoryAllocateFlagsInfo memAllocFlagsInfo = new VkMemoryAllocateFlagsInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO,
                pNext = null,
                flags = VkMemoryAllocateFlagBits.VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT,
                deviceMask = 0,
            };

            VkMemoryAllocateInfo memAllocInfo = new VkMemoryAllocateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO,
                pNext = &memAllocFlagsInfo,
                allocationSize = memoryRequirements.size,
                memoryTypeIndex = FindMemoryType(memoryRequirements.memoryTypeBits, VkMemoryPropertyFlagBits.VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | VkMemoryPropertyFlagBits.VK_MEMORY_PROPERTY_HOST_COHERENT_BIT),
            };

            result = VulkanNative.vkAllocateMemory(device, &memAllocInfo, null, &accelerationMemory.memory);
            Helpers.CheckErrors(result);

            result = VulkanNative.vkBindBufferMemory(device, accelerationMemory.buffer, accelerationMemory.memory, 0);
            Helpers.CheckErrors(result);

            accelerationMemory.memoryAddress = GetBufferAddress(accelerationMemory.buffer);

            void* dstData;
            result = VulkanNative.vkMapMemory(device, accelerationMemory.memory, 0, byteLength, 0, &dstData);
            Helpers.CheckErrors(result);

            GCHandle gcHandle = GCHandle.Alloc(srcData, GCHandleType.Pinned);
            Unsafe.CopyBlock((void*)dstData, (void*)gcHandle.AddrOfPinnedObject(), byteLength);
            gcHandle.Free();

            VulkanNative.vkUnmapMemory(device, accelerationMemory.memory);
            accelerationMemory.mappedPointer = dstData;

            return accelerationMemory;
        }

        public VkMemoryRequirements GetAccelerationStructureMemoryRequirements(VkAccelerationStructureKHR acceleration, VkAccelerationStructureMemoryRequirementsTypeKHR type)
        {
            VkMemoryRequirements2 memoryRequirements2 = new VkMemoryRequirements2()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2,
            };

            VkAccelerationStructureMemoryRequirementsInfoKHR accelerationMemoryRequirements = new VkAccelerationStructureMemoryRequirementsInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_KHR,
                pNext = null,
                type = type,
                buildType = VkAccelerationStructureBuildTypeKHR.VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR,
                accelerationStructure = acceleration,
            };


            VulkanNative.vkGetAccelerationStructureMemoryRequirementsKHR(device, &accelerationMemoryRequirements, &memoryRequirements2);

            return memoryRequirements2.memoryRequirements;
        }

        public void BindAccelerationMemory(VkAccelerationStructureKHR acceleration, VkDeviceMemory memory)
        {
            VkBindAccelerationStructureMemoryInfoKHR accelerationMemoryBindInfo = new VkBindAccelerationStructureMemoryInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_KHR,
                pNext = null,
                accelerationStructure = acceleration,
                memory = memory,
                memoryOffset = 0,
                deviceIndexCount = 0,
                pDeviceIndices = null,
            };

            var result = VulkanNative.vkBindAccelerationStructureMemoryKHR(device, 1, &accelerationMemoryBindInfo);
            Helpers.CheckErrors(result);
        }

        public AccelerationMemory CreateAccelerationScratchBuffer(VkAccelerationStructureKHR acceleration, VkAccelerationStructureMemoryRequirementsTypeKHR type)
        {
            AccelerationMemory accelerationMemory = new AccelerationMemory();

            VkMemoryRequirements asRequirements = this.GetAccelerationStructureMemoryRequirements(acceleration, type);

            VkBufferCreateInfo bufferInfo = new VkBufferCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO,
                pNext = null,
                size = asRequirements.size,
                usage = VkBufferUsageFlagBits.VK_BUFFER_USAGE_RAY_TRACING_BIT_KHR | VkBufferUsageFlagBits.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT,
                sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE,
                queueFamilyIndexCount = 0,
                pQueueFamilyIndices = null,
            };
            var result = VulkanNative.vkCreateBuffer(device, &bufferInfo, null, &accelerationMemory.buffer);
            Helpers.CheckErrors(result);

            VkMemoryRequirements bufRequirements = new VkMemoryRequirements();
            VulkanNative.vkGetBufferMemoryRequirements(device, accelerationMemory.buffer, &bufRequirements);

            // buffer requirements can differ to AS requirements, so we max them
            ulong alloctionSize = asRequirements.size > bufRequirements.size ? asRequirements.size : bufRequirements.size;
            // combine AS and buf mem types
            uint allocationMemoryBits = bufRequirements.memoryTypeBits | asRequirements.memoryTypeBits;

            VkMemoryAllocateFlagsInfo memAllocFlagsInfo = new VkMemoryAllocateFlagsInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO,
                pNext = null,
                flags = VkMemoryAllocateFlagBits.VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT,
                deviceMask = 0,
            };

            VkMemoryAllocateInfo memAllocInfo = new VkMemoryAllocateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO,
                pNext = &memAllocFlagsInfo,
                allocationSize = alloctionSize,
                memoryTypeIndex = FindMemoryType(allocationMemoryBits, VkMemoryPropertyFlagBits.VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT),
            };
            result = VulkanNative.vkAllocateMemory(device, &memAllocInfo, null, &accelerationMemory.memory);
            Helpers.CheckErrors(result);

            result = VulkanNative.vkBindBufferMemory(device, accelerationMemory.buffer, accelerationMemory.memory, 0);
            Helpers.CheckErrors(result);

            accelerationMemory.memoryAddress = GetBufferAddress(accelerationMemory.buffer);

            return accelerationMemory;
        }

        public void InsertCommandImageBarrier(VkCommandBuffer commandBuffer,
                               VkImage image,
                               VkAccessFlagBits srcAccessMask,
                               VkAccessFlagBits dstAccessMask,
                               VkImageLayout oldLayout,
                               VkImageLayout newLayout,
                               VkImageSubresourceRange subresourceRange)
        {
            VkImageMemoryBarrier imageMemoryBarrier = new VkImageMemoryBarrier()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER,
                pNext = null,
                srcAccessMask = srcAccessMask,
                dstAccessMask = dstAccessMask,
                oldLayout = oldLayout,
                newLayout = newLayout,
                srcQueueFamilyIndex = VulkanNative.VK_QUEUE_FAMILY_IGNORED,
                dstQueueFamilyIndex = VulkanNative.VK_QUEUE_FAMILY_IGNORED,
                image = image,
                subresourceRange = subresourceRange,
            };

            VulkanNative.vkCmdPipelineBarrier(commandBuffer, VkPipelineStageFlagBits.VK_PIPELINE_STAGE_ALL_COMMANDS_BIT,
                                 VkPipelineStageFlagBits.VK_PIPELINE_STAGE_ALL_COMMANDS_BIT, 0, 0, null, 0, null, 1,
                                 &imageMemoryBarrier);
        }

        public bool IsValidationLayerAvailable(string layerName)
        {
            uint propertyCount = 0;
            VulkanNative.vkEnumerateInstanceLayerProperties(&propertyCount, null);
            VkLayerProperties* properties = stackalloc VkLayerProperties[(int)propertyCount];
            var result = VulkanNative.vkEnumerateInstanceLayerProperties(&propertyCount, properties);
            Helpers.CheckErrors(result);

            // loop through all toggled layers and check if we can enable each
            for (uint ii = 0; ii < propertyCount; ++ii)
            {
                string pLayerName = Helpers.GetString(properties[ii].layerName);
                if (layerName.Equals(pLayerName))
                    return true;
            }

            return false;
        }

        public int Main()
        {
            window = new Form();
            window.Text = "VK KHR Raytracing Vulkan Triangle";
            window.Size = new System.Drawing.Size(800, 600);
            window.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            window.Show();

            // check which validation layers are available
            List<string> availableValidationLayers = new List<string>();
            for (uint ii = 0; ii < validationLayers.Length; ++ii)
            {
                if (IsValidationLayerAvailable(validationLayers[ii]))
                {
                    availableValidationLayers.Add(validationLayers[ii]);
                }
                else
                {
                    Debug.WriteLine($"Ignoring layer {validationLayers[ii]} as it is unavailable");
                }
            };

            VkApplicationInfo appInfo = new VkApplicationInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_APPLICATION_INFO,
                pNext = null,
                pApplicationName = "Hello Triangle".ToPointer(),
                applicationVersion = Helpers.Version(1, 0, 0),
                pEngineName = "No Engine".ToPointer(),
                engineVersion = Helpers.Version(1, 0, 0),
                apiVersion = Helpers.Version(1, 2, 0),
            };

            int layersCount = availableValidationLayers.Count;
            IntPtr* layersToEnableArray = stackalloc IntPtr[layersCount];
            for (int i = 0; i < layersCount; i++)
            {
                string layer = availableValidationLayers[i];
                layersToEnableArray[i] = Marshal.StringToHGlobalAnsi(layer);
            }

            int extensionsCount = instanceExtensions.Length;
            IntPtr* extensionsToEnableArray = stackalloc IntPtr[extensionsCount];
            for (int i = 0; i < extensionsCount; i++)
            {
                string extension = instanceExtensions[i];
                extensionsToEnableArray[i] = Marshal.StringToHGlobalAnsi(extension);
            }

            VkInstanceCreateInfo createInfo = new VkInstanceCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO,
                pNext = null,
                pApplicationInfo = &appInfo,
                enabledExtensionCount = (uint)instanceExtensions.Length,
                ppEnabledExtensionNames = (byte**)extensionsToEnableArray,
                enabledLayerCount = (uint)availableValidationLayers.Count,
                ppEnabledLayerNames = (byte**)layersToEnableArray,
            };
            VkResult result;
            fixed (VkInstance* instancePtr = &instance)
            {
                result = VulkanNative.vkCreateInstance(&createInfo, null, instancePtr);
                Helpers.CheckErrors(result);
            }

            uint deviceCount = 0;
            result = VulkanNative.vkEnumeratePhysicalDevices(instance, &deviceCount, null);
            Helpers.CheckErrors(result);

            if (deviceCount <= 0)
            {
                Debug.WriteLine("No physical devices available");
                return 1;
            }

            VkPhysicalDevice[] devices = new VkPhysicalDevice[deviceCount];
            fixed (VkPhysicalDevice* devicesPtr = devices)
            {
                result = VulkanNative.vkEnumeratePhysicalDevices(instance, &deviceCount, devicesPtr);
                Helpers.CheckErrors(result);
            }

            // find RT compatible device
            for (uint ii = 0; ii < devices.Length; ++ii)
            {
                // acquire RT features
                VkPhysicalDeviceRayTracingFeaturesKHR rayTracingFeatures = new VkPhysicalDeviceRayTracingFeaturesKHR()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_FEATURES_KHR,
                    pNext = null,
                };

                VkPhysicalDeviceFeatures2 deviceFeatures2 = new VkPhysicalDeviceFeatures2()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2,
                    pNext = &rayTracingFeatures,
                };
                VulkanNative.vkGetPhysicalDeviceFeatures2(devices[ii], &deviceFeatures2);

                if (rayTracingFeatures.rayTracing == true)
                {
                    physicalDevice = devices[ii];
                    break;
                }
            };

            if (physicalDevice == null)
            {
                Debug.WriteLine("No ray tracing compatible GPU found");
            }

            VkPhysicalDeviceProperties deviceProperties = new VkPhysicalDeviceProperties();
            VulkanNative.vkGetPhysicalDeviceProperties(physicalDevice, &deviceProperties);
            Debug.WriteLine($"GPU: {Marshal.PtrToStringAnsi((IntPtr)deviceProperties.deviceName)}");

            float queuePriority = 0.0f;

            VkDeviceQueueCreateInfo deviceQueueInfo = new VkDeviceQueueCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO,
                pNext = null,
                queueFamilyIndex = 0,
                queueCount = 1,
                pQueuePriorities = &queuePriority,
            };

            VkPhysicalDeviceRayTracingFeaturesKHR deviceRayTracingFeatures = new VkPhysicalDeviceRayTracingFeaturesKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_FEATURES_KHR,
                pNext = null,
                rayTracing = true,
            };

            VkPhysicalDeviceVulkan12Features deviceVulkan12Features = new VkPhysicalDeviceVulkan12Features()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES,
                pNext = &deviceRayTracingFeatures,
                bufferDeviceAddress = true,
            };

            int deviceExtensionsCount = deviceExtensions.Length;
            IntPtr* deviceExtensionsArray = stackalloc IntPtr[deviceExtensionsCount];
            for (int i = 0; i < deviceExtensionsCount; i++)
            {
                string extension = deviceExtensions[i];
                deviceExtensionsArray[i] = Marshal.StringToHGlobalAnsi(extension);
            }

            VkDeviceCreateInfo deviceInfo = new VkDeviceCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO,
                pNext = &deviceVulkan12Features,
                queueCreateInfoCount = 1,
                pQueueCreateInfos = &deviceQueueInfo,
                enabledExtensionCount = (uint)deviceExtensions.Length,
                ppEnabledExtensionNames = (byte**)deviceExtensionsArray,
                pEnabledFeatures = null,
            };

            fixed (VkDevice* devicePtr = &device)
            {
                result = VulkanNative.vkCreateDevice(physicalDevice, &deviceInfo, null, devicePtr);
                Helpers.CheckErrors(result);
            }

            fixed (VkQueue* queuePtr = &queue)
            {
                VulkanNative.vkGetDeviceQueue(device, 0, 0, queuePtr);
            }

            VkWin32SurfaceCreateInfoKHR surfaceCreateInfo = new VkWin32SurfaceCreateInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR,
                pNext = null,
                flags = 0,
                hinstance = windowInstance,
                hwnd = window.Handle,
            };

            fixed (VkSurfaceKHR* surfacePtr = &surface)
            {
                result = VulkanNative.vkCreateWin32SurfaceKHR(instance, &surfaceCreateInfo, null, surfacePtr);
                Helpers.CheckErrors(result);
            }

            VkBool32 surfaceSupport = false;
            result = VulkanNative.vkGetPhysicalDeviceSurfaceSupportKHR(physicalDevice, 0, surface, &surfaceSupport);
            Helpers.CheckErrors(result);

            if (!surfaceSupport)
            {
                Debug.WriteLine("No surface rendering support");
                return 1;
            }

            VkCommandPoolCreateInfo cmdPoolInfo = new VkCommandPoolCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO,
                pNext = null,
                flags = 0,
                queueFamilyIndex = 0,
            };

            fixed (VkCommandPool* commandPoolPtr = &commandPool)
            {
                result = VulkanNative.vkCreateCommandPool(device, &cmdPoolInfo, null, commandPoolPtr);
                Helpers.CheckErrors(result);
            }

            // acquire RT properties
            rayTracingProperties = new VkPhysicalDeviceRayTracingPropertiesKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_KHR,
                pNext = null,
            };

            VkPhysicalDeviceProperties2 deviceProperties2;
            fixed (VkPhysicalDeviceRayTracingPropertiesKHR* rayTracingPropertiesPtr = &rayTracingProperties)
            {
                deviceProperties2 = new VkPhysicalDeviceProperties2()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2,
                    pNext = rayTracingPropertiesPtr,
                };
            }

            VulkanNative.vkGetPhysicalDeviceProperties2(physicalDevice, &deviceProperties2);

            // create bottom-level container
            this.CreateBottomLevelContainer();

            // create top-level container
            this.CreateTopLevelContainer();

            // offscreen buffer
            this.OffscreenBuffer();

            // rt descriptor set layout
            this.RTDescriptorSetLayout();

            // rt descriptor set
            this.RTDescriptorSet();

            // rt pipeline layout
            this.RTPipelineLayout();

            // rt pipeline
            this.RTPipeline();

            // shader binding table
            this.ShaderBindingTable();

            Debug.WriteLine("Initializing Swapchain..");

            uint presentModeCount = 0;
            VulkanNative.vkGetPhysicalDeviceSurfacePresentModesKHR(physicalDevice, surface, &presentModeCount, null);

            VkPresentModeKHR[] presentModes = new VkPresentModeKHR[presentModeCount];
            fixed (VkPresentModeKHR* presentModesPtr = &presentModes[0])
            {
                VulkanNative.vkGetPhysicalDeviceSurfacePresentModesKHR(physicalDevice, surface, &presentModeCount, presentModesPtr);
            }

            bool isMailboxModeSupported = presentModes.Any(m => m == VkPresentModeKHR.VK_PRESENT_MODE_MAILBOX_KHR);

            VkSwapchainCreateInfoKHR swapchainInfo = new VkSwapchainCreateInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR,
                pNext = null,
                surface = surface,
                minImageCount = 3,
                imageFormat = desiredSurfaceFormat,
                imageColorSpace = VkColorSpaceKHR.VK_COLOR_SPACE_SRGB_NONLINEAR_KHR,
                imageExtent = new VkExtent2D(desiredWindowWidth, desiredWindowHeight),
                imageArrayLayers = 1,
                imageUsage = VkImageUsageFlagBits.VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT | VkImageUsageFlagBits.VK_IMAGE_USAGE_TRANSFER_DST_BIT,
                imageSharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE,
                queueFamilyIndexCount = 0,
                preTransform = VkSurfaceTransformFlagBitsKHR.VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR,
                compositeAlpha = VkCompositeAlphaFlagBitsKHR.VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR,
                presentMode = isMailboxModeSupported ? VkPresentModeKHR.VK_PRESENT_MODE_MAILBOX_KHR : VkPresentModeKHR.VK_PRESENT_MODE_FIFO_KHR,
                clipped = true,
                oldSwapchain = default,
            };

            fixed (VkSwapchainKHR* swapchainPtr = &swapchain)
            {
                VulkanNative.vkCreateSwapchainKHR(device, &swapchainInfo, null, swapchainPtr);
            }

            uint amountOfImagesInSwapchain = 0;
            VulkanNative.vkGetSwapchainImagesKHR(device, swapchain, &amountOfImagesInSwapchain, null);
            VkImage[] swapchainImages = new VkImage[] { amountOfImagesInSwapchain };

            fixed (VkImage* swapchainImagesPtr = &swapchainImages[0])
            {
                VulkanNative.vkGetSwapchainImagesKHR(device, swapchain, &amountOfImagesInSwapchain, swapchainImagesPtr);
            }

            VkImageView[] imageViews = new VkImageView[] { amountOfImagesInSwapchain };


            for (uint ii = 0; ii < amountOfImagesInSwapchain; ++ii)
            {
                VkImageViewCreateInfo imageViewInfo = new VkImageViewCreateInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO,
                    pNext = null,
                    image = swapchainImages[ii],
                    viewType = VkImageViewType.VK_IMAGE_VIEW_TYPE_2D,
                    format = desiredSurfaceFormat,
                    subresourceRange = new VkImageSubresourceRange()
                    {
                        aspectMask = VkImageAspectFlagBits.VK_IMAGE_ASPECT_COLOR_BIT,
                        baseMipLevel = 0,
                        levelCount = 1,
                        baseArrayLayer = 0,
                        layerCount = 1,
                    },
                };

                fixed (VkImageView* imageViewsPtr = &imageViews[ii])
                {
                    VulkanNative.vkCreateImageView(device, &imageViewInfo, null, imageViewsPtr);
                }
            };

            Debug.WriteLine("Recording frame commands..");

            VkImageCopy copyRegion = new VkImageCopy()
            {
                srcSubresource = new VkImageSubresourceLayers()
                {
                    aspectMask = VkImageAspectFlagBits.VK_IMAGE_ASPECT_COLOR_BIT,
                    mipLevel = 0,
                    baseArrayLayer = 0,
                    layerCount = 1,
                },
                dstSubresource = new VkImageSubresourceLayers()
                {
                    aspectMask = VkImageAspectFlagBits.VK_IMAGE_ASPECT_COLOR_BIT,
                    mipLevel = 0,
                    baseArrayLayer = 0,
                    layerCount = 1,
                },
                extent = new VkExtent3D() { depth = 1, width = desiredWindowWidth, height = desiredWindowHeight },
            };

            VkImageSubresourceRange subresourceRange = new VkImageSubresourceRange()
            {
                aspectMask = VkImageAspectFlagBits.VK_IMAGE_ASPECT_COLOR_BIT,
                baseMipLevel = 0,
                levelCount = 1,
                baseArrayLayer = 0,
                layerCount = 1,
            };

            VkStridedBufferRegionKHR rayGenSBT = new VkStridedBufferRegionKHR()
            {
                buffer = shaderBindingTable.buffer,
                offset = 0,
                stride = 0,
                size = shaderBindingTableSize,
            };

            VkStridedBufferRegionKHR rayMissSBT = new VkStridedBufferRegionKHR()
            {
                buffer = shaderBindingTable.buffer,
                offset = 2 * rayTracingProperties.shaderGroupHandleSize,
                stride = 0,
                size = shaderBindingTableSize,
            };

            VkStridedBufferRegionKHR rayHitSBT = new VkStridedBufferRegionKHR()
            {
                buffer = shaderBindingTable.buffer,
                offset = 1 * rayTracingProperties.shaderGroupHandleSize,
                stride = 0,
                size = shaderBindingTableSize,
            };

            VkStridedBufferRegionKHR rayCallSBT = new VkStridedBufferRegionKHR()
            {
                buffer = default,
                offset = 0,
                stride = 0,
                size = 0,
            };

            VkCommandBufferAllocateInfo commandBufferAllocateInfo = new VkCommandBufferAllocateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO,
                pNext = null,
                commandPool = commandPool,
                level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY,
                commandBufferCount = amountOfImagesInSwapchain,
            };

            commandBuffers = new VkCommandBuffer[amountOfImagesInSwapchain];
            fixed (VkCommandBuffer* commandBuffersPtr = &commandBuffers[0])
            {
                VulkanNative.vkAllocateCommandBuffers(device, &commandBufferAllocateInfo, commandBuffersPtr);
            }

            VkCommandBufferBeginInfo commandBufferBeginInfo = new VkCommandBufferBeginInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO,
                pNext = null,
                flags = 0,
                pInheritanceInfo = null,
            };

            for (uint ii = 0; ii < amountOfImagesInSwapchain; ++ii)
            {
                VkCommandBuffer commandBuffer = commandBuffers[ii];
                VkImage swapchainImage = swapchainImages[ii];

                VulkanNative.vkBeginCommandBuffer(commandBuffer, &commandBufferBeginInfo);

                // transition offscreen buffer into shader writeable state
                InsertCommandImageBarrier(commandBuffer, offscreenBuffer, 0, VkAccessFlagBits.VK_ACCESS_SHADER_WRITE_BIT, VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED, VkImageLayout.VK_IMAGE_LAYOUT_GENERAL, subresourceRange);

                VulkanNative.vkCmdBindPipeline(commandBuffer, VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR, pipeline);
                fixed (VkDescriptorSet* descriptorSetPtr = &descriptorSet)
                {
                    VulkanNative.vkCmdBindDescriptorSets(commandBuffer, VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR, pipelineLayout, 0, 1, descriptorSetPtr, 0, (uint*)0);
                }

                VulkanNative.vkCmdTraceRaysKHR(commandBuffer, &rayGenSBT, &rayMissSBT, &rayHitSBT, &rayCallSBT, desiredWindowWidth, desiredWindowHeight, 1);

                // transition swapchain image into copy destination state
                InsertCommandImageBarrier(commandBuffer, swapchainImage, 0, VkAccessFlagBits.VK_ACCESS_TRANSFER_WRITE_BIT, VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED, VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL, subresourceRange);

                // transition offscreen buffer into copy source state
                InsertCommandImageBarrier(commandBuffer, offscreenBuffer, VkAccessFlagBits.VK_ACCESS_SHADER_WRITE_BIT, VkAccessFlagBits.VK_ACCESS_TRANSFER_READ_BIT, VkImageLayout.VK_IMAGE_LAYOUT_GENERAL, VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL, subresourceRange);

                // copy offscreen buffer into swapchain image
                VulkanNative.vkCmdCopyImage(commandBuffer, offscreenBuffer, VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL, swapchainImage, VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL, 1, &copyRegion);

                // transition swapchain image into presentable state
                InsertCommandImageBarrier(commandBuffer, swapchainImage, 0, VkAccessFlagBits.VK_ACCESS_TRANSFER_WRITE_BIT, VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL, VkImageLayout.VK_IMAGE_LAYOUT_PRESENT_SRC_KHR, subresourceRange);

                VulkanNative.vkEndCommandBuffer(commandBuffer);
            };

            VkSemaphoreCreateInfo semaphoreInfo = new VkSemaphoreCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO,
                pNext = null,
            };

            VulkanNative.vkCreateSemaphore(device, &semaphoreInfo, null, semaphoreImageAvailable);

            VulkanNative.vkCreateSemaphore(device, &semaphoreInfo, null, semaphoreRenderingAvailable);

            Debug.WriteLine("Done!"); ;
            Debug.WriteLine("Drawing..");

            // Draw Frame
            uint imageIndex = 0;
            VulkanNative.vkAcquireNextImageKHR(device, swapchain, ulong.MaxValue, *(semaphoreImageAvailable), default, &imageIndex);

            VkPipelineStageFlagBits* waitStageMasks = stackalloc VkPipelineStageFlagBits[] { VkPipelineStageFlagBits.VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT };

            VkSubmitInfo submitInfo;
            fixed (VkCommandBuffer* commandBuffersPtr = &commandBuffers[imageIndex])
            {
                submitInfo = new VkSubmitInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO,
                    pNext = null,
                    waitSemaphoreCount = 1,
                    pWaitSemaphores = semaphoreImageAvailable,
                    pWaitDstStageMask = waitStageMasks,
                    commandBufferCount = 1,
                    pCommandBuffers = commandBuffersPtr,
                    signalSemaphoreCount = 1,
                    pSignalSemaphores = semaphoreRenderingAvailable,
                };
            }

            VulkanNative.vkQueueSubmit(queue, 1, &submitInfo, default);

            VkSwapchainKHR* swapChains = stackalloc VkSwapchainKHR[] { swapchain };
            VkPresentInfoKHR presentInfo = new VkPresentInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_INFO_KHR,
                pNext = null,
                waitSemaphoreCount = 1,
                pWaitSemaphores = semaphoreRenderingAvailable,
                swapchainCount = 1,
                pSwapchains = swapChains,
                pImageIndices = &imageIndex,
                pResults = null,
            };

            VulkanNative.vkQueuePresentKHR(queue, &presentInfo);
            VulkanNative.vkQueueWaitIdle(queue);


            return 0;
        }
        private void CreateBottomLevelContainer()
        {
            Debug.WriteLine("Creating Bottom-Level Acceleration Structure..");

            VkAccelerationStructureCreateGeometryTypeInfoKHR accelerationCreateGeometryInfo = new VkAccelerationStructureCreateGeometryTypeInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_GEOMETRY_TYPE_INFO_KHR,
                pNext = null,
                geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_TRIANGLES_KHR,
                maxPrimitiveCount = 128,
                indexType = VkIndexType.VK_INDEX_TYPE_UINT32,
                maxVertexCount = 8,
                vertexFormat = VkFormat.VK_FORMAT_R32G32B32_SFLOAT,
                allowsTransforms = false,
            };

            VkAccelerationStructureCreateInfoKHR accelerationInfo = new VkAccelerationStructureCreateInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR,
                pNext = null,
                compactedSize = 0,
                type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR,
                flags = VkBuildAccelerationStructureFlagBitsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR,
                maxGeometryCount = 1,
                pGeometryInfos = &accelerationCreateGeometryInfo,
                deviceAddress = 0, // VkDeviceAddress??
            };

            VkResult result;
            VkAllocationCallbacks callbacks = new VkAllocationCallbacks();

            fixed (VkAccelerationStructureKHR* bottomLevelASPtr = &bottomLevelAS)
            {
                result = VulkanNative.vkCreateAccelerationStructureKHR(device, &accelerationInfo, &callbacks, bottomLevelASPtr);
                Helpers.CheckErrors(result);
            }

            AccelerationMemory objectMemory = CreateAccelerationScratchBuffer(bottomLevelAS, VkAccelerationStructureMemoryRequirementsTypeKHR.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_KHR);

            BindAccelerationMemory(bottomLevelAS, objectMemory.memory);

            AccelerationMemory buildScratchMemory = CreateAccelerationScratchBuffer(bottomLevelAS, VkAccelerationStructureMemoryRequirementsTypeKHR.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_KHR);

            // Get bottom level acceleration structure handle for use in top level instances
            VkAccelerationStructureDeviceAddressInfoKHR devAddrInfo = new VkAccelerationStructureDeviceAddressInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR,
                accelerationStructure = bottomLevelAS,
            };
            bottomLevelASHandle = VulkanNative.vkGetAccelerationStructureDeviceAddressKHR(device, &devAddrInfo);

            float[] vertices = new float[] {
                    +1.0f, +1.0f, +0.0f,
                    -1.0f, +1.0f, +0.0f,
                    +0.0f, -1.0f, +0.0f
                };

            uint[] indices = { 0, 1, 2 };

            AccelerationMemory vertexBuffer = CreateMappedBuffer(vertices, (uint)(sizeof(float) * vertices.Length));

            AccelerationMemory indexBuffer = CreateMappedBuffer(indices, (uint)(sizeof(uint) * indices.Length));

            VkAccelerationStructureGeometryKHR accelerationGeometry = new VkAccelerationStructureGeometryKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR,
                pNext = null,
                flags = VkGeometryFlagBitsKHR.VK_GEOMETRY_OPAQUE_BIT_KHR,
                geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_TRIANGLES_KHR,
                geometry = new VkAccelerationStructureGeometryDataKHR()
                {
                    triangles = new VkAccelerationStructureGeometryTrianglesDataKHR()
                    {
                        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR,
                        pNext = null,
                        vertexFormat = VkFormat.VK_FORMAT_R32G32B32_SFLOAT,
                        vertexData = new VkDeviceOrHostAddressConstKHR() { deviceAddress = vertexBuffer.memoryAddress },
                        vertexStride = 3 * sizeof(float),
                        indexType = VkIndexType.VK_INDEX_TYPE_UINT32,
                        indexData = new VkDeviceOrHostAddressConstKHR() { deviceAddress = indexBuffer.memoryAddress },
                        transformData = default,
                    },
                },
            };

            accelerationGeometries = new VkAccelerationStructureGeometryKHR[] { accelerationGeometry };
            VkAccelerationStructureBuildGeometryInfoKHR accelerationBuildGeometryInfo;
            fixed (VkAccelerationStructureGeometryKHR* ppGeometries = &accelerationGeometries[0])
            {
                accelerationBuildGeometryInfo = new VkAccelerationStructureBuildGeometryInfoKHR()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR,
                    pNext = null,
                    type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR,
                    flags = VkBuildAccelerationStructureFlagBitsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR,
                    update = false,
                    srcAccelerationStructure = default,
                    dstAccelerationStructure = bottomLevelAS,
                    geometryArrayOfPointers = false,
                    geometryCount = 1,
                    ppGeometries = &ppGeometries,
                    scratchData = new VkDeviceOrHostAddressKHR() { deviceAddress = buildScratchMemory.memoryAddress },
                };
            }

            VkAccelerationStructureBuildOffsetInfoKHR accelerationBuildOffsetInfo = new VkAccelerationStructureBuildOffsetInfoKHR()
            {
                primitiveCount = 1,
                primitiveOffset = 0x0,
                firstVertex = 0,
                transformOffset = 0x0,
            };

            VkAccelerationStructureBuildOffsetInfoKHR* accelerationBuildOffsets = stackalloc VkAccelerationStructureBuildOffsetInfoKHR[] { accelerationBuildOffsetInfo };

            VkCommandBuffer commandBuffer = default;

            VkCommandBufferAllocateInfo commandBufferAllocateInfo = new VkCommandBufferAllocateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO,
                pNext = null,
                commandPool = commandPool,
                level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY,
                commandBufferCount = 1,
            };
            result = VulkanNative.vkAllocateCommandBuffers(device, &commandBufferAllocateInfo, &commandBuffer);
            Helpers.CheckErrors(result);

            VkCommandBufferBeginInfo commandBufferBeginInfo = new VkCommandBufferBeginInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO,
                pNext = null,
                flags = VkCommandBufferUsageFlagBits.VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT,
            };
            result = VulkanNative.vkBeginCommandBuffer(commandBuffer, &commandBufferBeginInfo);
            Helpers.CheckErrors(result);

            VulkanNative.vkCmdBuildAccelerationStructureKHR(commandBuffer, 1, &accelerationBuildGeometryInfo, (VkAccelerationStructureBuildOffsetInfoKHR**)&accelerationBuildOffsets);

            result = VulkanNative.vkEndCommandBuffer(commandBuffer);
            Helpers.CheckErrors(result);

            VkSubmitInfo submitInfo = new VkSubmitInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO,
                pNext = null,
                commandBufferCount = 1,
                pCommandBuffers = &commandBuffer,
            };

            VkFence fence = default;
            VkFenceCreateInfo fenceInfo = new VkFenceCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_CREATE_INFO,
                pNext = null,
            };

            result = VulkanNative.vkCreateFence(device, &fenceInfo, null, &fence);
            Helpers.CheckErrors(result);

            result = VulkanNative.vkQueueSubmit(queue, 1, &submitInfo, fence);
            Helpers.CheckErrors(result);

            result = VulkanNative.vkWaitForFences(device, 1, &fence, true, ulong.MaxValue);
            Helpers.CheckErrors(result);

            VulkanNative.vkDestroyFence(device, fence, null);
            VulkanNative.vkFreeCommandBuffers(device, commandPool, 1, &commandBuffer);

            // make sure bottom AS handle is valid
            if (bottomLevelASHandle == 0)
            {
                throw new Exception("Invalid Handle to BLAS");
            }
        }
        private void CreateTopLevelContainer()
        {
            Debug.WriteLine("Creating Top-Level Acceleration Structure..");

            VkAccelerationStructureCreateGeometryTypeInfoKHR accelerationCreateGeometryInfo = new VkAccelerationStructureCreateGeometryTypeInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_GEOMETRY_TYPE_INFO_KHR,
                pNext = null,
                geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_INSTANCES_KHR,
                maxPrimitiveCount = 1,
            };
            VkAccelerationStructureCreateInfoKHR accelerationInfo = new VkAccelerationStructureCreateInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR,
                pNext = null,
                compactedSize = 0,
                type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR,
                flags = VkBuildAccelerationStructureFlagBitsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR,
                maxGeometryCount = 1,
                pGeometryInfos = &accelerationCreateGeometryInfo,
                deviceAddress = 0,
            };

            VkResult result;
            fixed (VkAccelerationStructureKHR* topLevelASPtr = &topLevelAS)
            {
                result = VulkanNative.vkCreateAccelerationStructureKHR(device, &accelerationInfo, null, topLevelASPtr);
                Helpers.CheckErrors(result);
            }

            AccelerationMemory objectMemory = CreateAccelerationScratchBuffer(topLevelAS, VkAccelerationStructureMemoryRequirementsTypeKHR.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_KHR);

            BindAccelerationMemory(topLevelAS, objectMemory.memory);

            AccelerationMemory buildScratchMemory = CreateAccelerationScratchBuffer(topLevelAS, VkAccelerationStructureMemoryRequirementsTypeKHR.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_KHR);

            VkAccelerationStructureInstanceKHR[] instances = new VkAccelerationStructureInstanceKHR[]
            {
                    new VkAccelerationStructureInstanceKHR()
                    {
                        transform = new VkTransformMatrixKHR()
                        {
                            matrix_0 = 1.0f,
                            matrix_1 = 0.0f,
                            matrix_2 = 0.0f,
                            matrix_3 = 0.0f,
                            matrix_4 = 0.0f,
                            matrix_5 = 1.0f,
                            matrix_6 = 0.0f,
                            matrix_7 = 0.0f,
                            matrix_8 = 0.0f,
                            matrix_9 = 0.0f,
                            matrix_10 = 1.0f,
                            matrix_11 = 0.0f,
                        },
                        instanceCustomIndex = 0,
                        mask = 0xff,
                        instanceShaderBindingTableRecordOffset = 0x0,
                        flags = VkGeometryInstanceFlagBitsKHR.VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR,
                        accelerationStructureReference = bottomLevelASHandle,
                    }
            };

            AccelerationMemory instanceBuffer = this.CreateMappedBuffer(instances, (uint)(sizeof(VkAccelerationStructureInstanceKHR) * instances.Length));

            VkAccelerationStructureGeometryKHR accelerationGeometry = new VkAccelerationStructureGeometryKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR,
                pNext = null,
                flags = VkGeometryFlagBitsKHR.VK_GEOMETRY_OPAQUE_BIT_KHR,
                geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_INSTANCES_KHR,
                geometry = new VkAccelerationStructureGeometryDataKHR()
                {
                    instances = new VkAccelerationStructureGeometryInstancesDataKHR()
                    {
                        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR,
                        pNext = null,
                        arrayOfPointers = false,
                        data = new VkDeviceOrHostAddressConstKHR() { deviceAddress = instanceBuffer.memoryAddress },
                    },
                }
            };

            VkAccelerationStructureBuildGeometryInfoKHR accelerationBuildGeometryInfo;
            fixed (VkAccelerationStructureGeometryKHR* ppGeometries = &accelerationGeometries[0])
            {
                accelerationBuildGeometryInfo = new VkAccelerationStructureBuildGeometryInfoKHR()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR,
                    pNext = null,
                    type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR,
                    flags = VkBuildAccelerationStructureFlagBitsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR,
                    update = false,
                    srcAccelerationStructure = default,
                    dstAccelerationStructure = topLevelAS,
                    geometryArrayOfPointers = false,
                    geometryCount = 1,
                    ppGeometries = &ppGeometries,
                    scratchData = new VkDeviceOrHostAddressKHR() { deviceAddress = buildScratchMemory.memoryAddress },
                };
            }

            VkAccelerationStructureBuildOffsetInfoKHR accelerationBuildOffsetInfo = new VkAccelerationStructureBuildOffsetInfoKHR()
            {
                primitiveCount = 1,
                primitiveOffset = 0x0,
                firstVertex = 0,
                transformOffset = 0x0,
            };

            VkAccelerationStructureBuildOffsetInfoKHR* accelerationBuildOffsets = stackalloc VkAccelerationStructureBuildOffsetInfoKHR[] { accelerationBuildOffsetInfo };

            VkCommandBuffer commandBuffer = default;

            VkCommandBufferAllocateInfo commandBufferAllocateInfo = new VkCommandBufferAllocateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO,
                pNext = null,
                commandPool = commandPool,
                level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY,
                commandBufferCount = 1,
            };
            result = VulkanNative.vkAllocateCommandBuffers(device, &commandBufferAllocateInfo, &commandBuffer);
            Helpers.CheckErrors(result);

            VkCommandBufferBeginInfo commandBufferBeginInfo = new VkCommandBufferBeginInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO,
                pNext = null,
                flags = VkCommandBufferUsageFlagBits.VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT,
            };
            result = VulkanNative.vkBeginCommandBuffer(commandBuffer, &commandBufferBeginInfo);
            Helpers.CheckErrors(result);

            VulkanNative.vkCmdBuildAccelerationStructureKHR(commandBuffer, 1, &accelerationBuildGeometryInfo, (VkAccelerationStructureBuildOffsetInfoKHR**)&accelerationBuildOffsets);

            result = VulkanNative.vkEndCommandBuffer(commandBuffer);
            Helpers.CheckErrors(result);

            VkSubmitInfo submitInfo = new VkSubmitInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO,
                pNext = null,
                commandBufferCount = 1,
                pCommandBuffers = &commandBuffer,
            };

            VkFence fence = default;
            VkFenceCreateInfo fenceInfo = new VkFenceCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_CREATE_INFO,
                pNext = null,
            };

            result = VulkanNative.vkCreateFence(device, &fenceInfo, null, &fence);
            Helpers.CheckErrors(result);

            result = VulkanNative.vkQueueSubmit(queue, 1, &submitInfo, fence);
            Helpers.CheckErrors(result);

            result = VulkanNative.vkWaitForFences(device, 1, &fence, true, ulong.MaxValue);
            Helpers.CheckErrors(result);

            VulkanNative.vkDestroyFence(device, fence, null);
            VulkanNative.vkFreeCommandBuffers(device, commandPool, 1, &commandBuffer);
        }
        private void OffscreenBuffer()
        {
            Debug.WriteLine("Creating Offsceen Buffer..");

            VkImageCreateInfo imageInfo = new VkImageCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO,
                pNext = null,
                imageType = VkImageType.VK_IMAGE_TYPE_2D,
                format = desiredSurfaceFormat,
                extent = new VkExtent3D() { width = desiredWindowWidth, height = desiredWindowHeight, depth = 1 },
                mipLevels = 1,
                arrayLayers = 1,
                samples = VkSampleCountFlagBits.VK_SAMPLE_COUNT_1_BIT,
                tiling = VkImageTiling.VK_IMAGE_TILING_OPTIMAL,
                usage = VkImageUsageFlagBits.VK_IMAGE_USAGE_STORAGE_BIT | VkImageUsageFlagBits.VK_IMAGE_USAGE_TRANSFER_SRC_BIT,
                sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE,
                queueFamilyIndexCount = 0,
                pQueueFamilyIndices = null,
                initialLayout = VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED,
            };

            VkResult result;
            fixed (VkImage* offscreenBufferPtr = &offscreenBuffer)
            {
                result = VulkanNative.vkCreateImage(device, &imageInfo, null, offscreenBufferPtr);
                Helpers.CheckErrors(result);
            }

            VkMemoryRequirements memoryRequirements = new VkMemoryRequirements();
            VulkanNative.vkGetImageMemoryRequirements(device, offscreenBuffer, &memoryRequirements);

            VkMemoryAllocateInfo memoryAllocateInfo = new VkMemoryAllocateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO,
                pNext = null,
                allocationSize = memoryRequirements.size,
                memoryTypeIndex = FindMemoryType(memoryRequirements.memoryTypeBits, VkMemoryPropertyFlagBits.VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT),
            };

            fixed (VkDeviceMemory* offscreenBufferMemoryPtr = &offscreenBufferMemory)
            {
                result = VulkanNative.vkAllocateMemory(device, &memoryAllocateInfo, null, offscreenBufferMemoryPtr);
                Helpers.CheckErrors(result);
            }

            result = VulkanNative.vkBindImageMemory(device, offscreenBuffer, offscreenBufferMemory, 0);
            Helpers.CheckErrors(result);

            VkImageViewCreateInfo imageViewInfo = new VkImageViewCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO,
                pNext = null,
                viewType = VkImageViewType.VK_IMAGE_VIEW_TYPE_2D,
                format = desiredSurfaceFormat,
                subresourceRange = new VkImageSubresourceRange()
                {
                    aspectMask = VkImageAspectFlagBits.VK_IMAGE_ASPECT_COLOR_BIT,
                    baseMipLevel = 0,
                    levelCount = 1,
                    baseArrayLayer = 0,
                    layerCount = 1,
                },
                image = offscreenBuffer,
                flags = 0,
                components = new VkComponentMapping()
                {
                    r = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_R,
                    g = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_G,
                    b = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_B,
                    a = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_A,
                }
            };

            fixed (VkImageView* offscreenBufferViewPtr = &offscreenBufferView)
            {
                result = VulkanNative.vkCreateImageView(device, &imageViewInfo, null, offscreenBufferViewPtr);
                Helpers.CheckErrors(result);
            }
        }
        private void RTDescriptorSetLayout()
        {
            Debug.WriteLine("Creating RT Descriptor Set Layout..");

            VkDescriptorSetLayoutBinding accelerationStructureLayoutBinding = new VkDescriptorSetLayoutBinding()
            {
                binding = 0,
                descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR,
                descriptorCount = 1,
                stageFlags = VkShaderStageFlagBits.VK_SHADER_STAGE_RAYGEN_BIT_KHR,
                pImmutableSamplers = null,
            };

            VkDescriptorSetLayoutBinding storageImageLayoutBinding = new VkDescriptorSetLayoutBinding()
            {
                binding = 1,
                descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
                descriptorCount = 1,
                stageFlags = VkShaderStageFlagBits.VK_SHADER_STAGE_RAYGEN_BIT_KHR,
            };

            VkDescriptorSetLayoutBinding* bindings = stackalloc VkDescriptorSetLayoutBinding[] { accelerationStructureLayoutBinding, storageImageLayoutBinding };
            VkDescriptorSetLayoutCreateInfo layoutInfo;
            layoutInfo = new VkDescriptorSetLayoutCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO,
                pNext = null,
                flags = 0,
                bindingCount = (uint)2,
                pBindings = bindings,
            };

            VkResult result;
            VkDescriptorSetLayout newDescriptorSetLayout;
            result = VulkanNative.vkCreateDescriptorSetLayout(device, &layoutInfo, null, &newDescriptorSetLayout);
            Helpers.CheckErrors(result);
            descriptorSetLayout = newDescriptorSetLayout;
        }
        private void RTDescriptorSet()
        {
            Debug.WriteLine("Creating RT Descriptor Set..");

            VkDescriptorPoolSize[] poolSizes = new VkDescriptorPoolSize[] {
                    new VkDescriptorPoolSize()
                    {
                        type = VkDescriptorType.VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR,
                        descriptorCount = 1,
                    },
                    new VkDescriptorPoolSize()
                    {
                        type = VkDescriptorType.VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
                        descriptorCount = 1,
                    }
                };

            VkDescriptorPoolCreateInfo descriptorPoolInfo;
            fixed (VkDescriptorPoolSize* poolSizesPtr = &poolSizes[0])
            {
                descriptorPoolInfo = new VkDescriptorPoolCreateInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO,
                    pNext = null,
                    flags = 0,
                    maxSets = 1,
                    poolSizeCount = (uint)poolSizes.Length,
                    pPoolSizes = poolSizesPtr,
                };
            }

            VkResult result;
            fixed (VkDescriptorPool* descriptorPoolPtr = &descriptorPool)
            {
                result = VulkanNative.vkCreateDescriptorPool(device, &descriptorPoolInfo, null, descriptorPoolPtr);
                Helpers.CheckErrors(result);
            }

            VkDescriptorSetAllocateInfo descriptorSetAllocateInfo;
            fixed (VkDescriptorSetLayout* descriptorSetLayoutPtr = &descriptorSetLayout)
            {
                descriptorSetAllocateInfo = new VkDescriptorSetAllocateInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO,
                    pNext = null,
                    descriptorPool = descriptorPool,
                    descriptorSetCount = 1,
                    pSetLayouts = descriptorSetLayoutPtr,
                };
            }

            fixed (VkDescriptorSet* descriptorSetPtr = &descriptorSet)
            {
                result = VulkanNative.vkAllocateDescriptorSets(device, &descriptorSetAllocateInfo, descriptorSetPtr);
                Helpers.CheckErrors(result);
            }

            VkWriteDescriptorSetAccelerationStructureKHR descriptorAccelerationStructureInfo;
            fixed (VkAccelerationStructureKHR* topLevelASPtr = &topLevelAS)
            {
                descriptorAccelerationStructureInfo = new VkWriteDescriptorSetAccelerationStructureKHR()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR,
                    pNext = null,
                    accelerationStructureCount = 1,
                    pAccelerationStructures = topLevelASPtr,
                };
            }

            VkWriteDescriptorSet accelerationStructureWrite = new VkWriteDescriptorSet()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET,
                pNext = &descriptorAccelerationStructureInfo,
                dstSet = descriptorSet,
                dstBinding = 0,
                descriptorCount = 1,
                descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR,
            };

            VkDescriptorImageInfo storageImageInfo = new VkDescriptorImageInfo()
            {
                sampler = default,
                imageView = offscreenBufferView,
                imageLayout = VkImageLayout.VK_IMAGE_LAYOUT_GENERAL,
            };

            VkWriteDescriptorSet outputImageWrite = new VkWriteDescriptorSet()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET,
                pNext = null,
                dstSet = descriptorSet,
                dstBinding = 1,
                descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
                descriptorCount = 1,
                pImageInfo = &storageImageInfo,
            };

            VkWriteDescriptorSet[] descriptorWrites = new VkWriteDescriptorSet[] { accelerationStructureWrite, outputImageWrite };
            fixed (VkWriteDescriptorSet* descriptorWritesPtr = &descriptorWrites[0])
            {
                VulkanNative.vkUpdateDescriptorSets(device, (uint)descriptorWrites.Length, descriptorWritesPtr, 0, null);
            }
        }
        private void RTPipelineLayout()
        {
            Debug.WriteLine("Creating RT Pipeline Layout..");

            VkPipelineLayoutCreateInfo pipelineLayoutInfo;
            fixed (VkDescriptorSetLayout* descriptorSetLayoutPtr = &descriptorSetLayout)
            {
                pipelineLayoutInfo = new VkPipelineLayoutCreateInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO,
                    pNext = null,
                    flags = 0,
                    setLayoutCount = 1,
                    pSetLayouts = descriptorSetLayoutPtr,
                    pushConstantRangeCount = 0,
                    pPushConstantRanges = null,
                };
            }

            VkResult result;
            VkPipelineLayout newPipelineLayout;
            result = VulkanNative.vkCreatePipelineLayout(device, &pipelineLayoutInfo, null, &newPipelineLayout);
            Helpers.CheckErrors(result);
            pipelineLayout = newPipelineLayout;
        }
        private void RTPipeline()
        {
            Debug.WriteLine("Creating RT Pipeline..");

            byte[] rgenShaderSrc = File.ReadAllBytes("Shaders/ray-generation.spv");
            byte[] rchitShaderSrc = File.ReadAllBytes("Shaders/ray-closest-hit.spv");
            byte[] rmissShaderSrc = File.ReadAllBytes("Shaders/ray-miss.spv");

            VkPipelineShaderStageCreateInfo rayGenShaderStageInfo = new VkPipelineShaderStageCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO,
                pNext = null,
                stage = VkShaderStageFlagBits.VK_SHADER_STAGE_RAYGEN_BIT_KHR,
                module = CreateShaderModule(rgenShaderSrc),
                pName = "main".ToPointer(),
            };

            VkPipelineShaderStageCreateInfo rayChitShaderStageInfo = new VkPipelineShaderStageCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO,
                pNext = null,
                stage = VkShaderStageFlagBits.VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR,
                module = CreateShaderModule(rchitShaderSrc),
                pName = "main".ToPointer(),
            };

            VkPipelineShaderStageCreateInfo rayMissShaderStageInfo = new VkPipelineShaderStageCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO,
                pNext = null,
                stage = VkShaderStageFlagBits.VK_SHADER_STAGE_MISS_BIT_KHR,
                module = CreateShaderModule(rmissShaderSrc),
                pName = "main".ToPointer(),
            };

            VkPipelineShaderStageCreateInfo[] shaderStages = new VkPipelineShaderStageCreateInfo[] { rayGenShaderStageInfo, rayChitShaderStageInfo, rayMissShaderStageInfo };

            VkRayTracingShaderGroupCreateInfoKHR rayGenGroup = new VkRayTracingShaderGroupCreateInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR,
                pNext = null,
                type = VkRayTracingShaderGroupTypeKHR.VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR,
                generalShader = 0,
                closestHitShader = 0,
                anyHitShader = 0,
                intersectionShader = 0,
            };

            VkRayTracingShaderGroupCreateInfoKHR rayHitGroup = new VkRayTracingShaderGroupCreateInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR,
                pNext = null,
                type = VkRayTracingShaderGroupTypeKHR.VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR,
                generalShader = 0,
                closestHitShader = 1,
                anyHitShader = 0,
                intersectionShader = 0,
            };

            VkRayTracingShaderGroupCreateInfoKHR rayMissGroup = new VkRayTracingShaderGroupCreateInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR,
                pNext = null,
                type = VkRayTracingShaderGroupTypeKHR.VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR,
                generalShader = 2,
                closestHitShader = 0,
                anyHitShader = 0,
                intersectionShader = 0,
            };

            VkRayTracingShaderGroupCreateInfoKHR[] shaderGroups = new VkRayTracingShaderGroupCreateInfoKHR[] { rayGenGroup, rayHitGroup, rayMissGroup };

            VkRayTracingPipelineCreateInfoKHR pipelineInfo;
            fixed (VkPipelineShaderStageCreateInfo* shaderStagesPtr = &shaderStages[0])
            fixed (VkRayTracingShaderGroupCreateInfoKHR* shaderGroupsPtr = &shaderGroups[0])
            {
                pipelineInfo = new VkRayTracingPipelineCreateInfoKHR()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR,
                    pNext = null,
                    flags = 0,
                    stageCount = (uint)shaderStages.Length,
                    pStages = shaderStagesPtr,
                    groupCount = (uint)shaderGroups.Length,
                    pGroups = shaderGroupsPtr,
                    maxRecursionDepth = 1,
                    libraries = new VkPipelineLibraryCreateInfoKHR()
                    {
                        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR,
                        pNext = null,
                        libraryCount = 0,
                        pLibraries = null,
                    },
                    pLibraryInterface = null,
                    layout = pipelineLayout,
                    basePipelineHandle = default,
                    basePipelineIndex = 0,
                };
            }

            VkResult result;
            fixed (VkPipeline* pipelinePtr = &pipeline)
            {
                result = VulkanNative.vkCreateRayTracingPipelinesKHR(device, default, 1, &pipelineInfo, null, pipelinePtr);
                Helpers.CheckErrors(result);
            }
        }
        private void ShaderBindingTable()
        {
            Debug.WriteLine("Creating Shader Binding Table..");

            shaderBindingTable = new AccelerationMemory();
            shaderBindingTableSize = shaderBindingTableGroupCount * rayTracingProperties.shaderGroupHandleSize;

            VkBufferCreateInfo bufferInfo = new VkBufferCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO,
                pNext = null,
                size = shaderBindingTableSize,
                usage = VkBufferUsageFlagBits.VK_BUFFER_USAGE_TRANSFER_SRC_BIT,
                sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE,
                queueFamilyIndexCount = 0,
                pQueueFamilyIndices = null,
            };

            VkBuffer newBuffer;
            VkResult result;
            result = VulkanNative.vkCreateBuffer(device, &bufferInfo, null, &newBuffer);
            Helpers.CheckErrors(result);

            shaderBindingTable.buffer = newBuffer;

            VkMemoryRequirements memoryRequirements = new VkMemoryRequirements();
            VulkanNative.vkGetBufferMemoryRequirements(device, shaderBindingTable.buffer, &memoryRequirements);

            VkMemoryAllocateInfo memAllocInfo = new VkMemoryAllocateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO,
                pNext = null,
                allocationSize = memoryRequirements.size,
                memoryTypeIndex = FindMemoryType(memoryRequirements.memoryTypeBits, VkMemoryPropertyFlagBits.VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT),
            };

            VkDeviceMemory newMemory;
            result = VulkanNative.vkAllocateMemory(device, &memAllocInfo, null, &newMemory);
            Helpers.CheckErrors(result);

            shaderBindingTable.memory = newMemory;

            result = VulkanNative.vkBindBufferMemory(device, shaderBindingTable.buffer, shaderBindingTable.memory, 0);
            Helpers.CheckErrors(result);

            void* dstData;
            result = VulkanNative.vkMapMemory(device, shaderBindingTable.memory, 0, shaderBindingTableSize, 0, &dstData);
            Helpers.CheckErrors(result);

            result = VulkanNative.vkGetRayTracingShaderGroupHandlesKHR(device, pipeline, 0, shaderBindingTableGroupCount, (UIntPtr)shaderBindingTableSize, dstData);
            Helpers.CheckErrors(result);

            VulkanNative.vkUnmapMemory(device, shaderBindingTable.memory);
        }
    }
}
