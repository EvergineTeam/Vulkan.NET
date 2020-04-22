using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using WaveEngine.Bindings.Vulkan;

namespace VKDrawTriangle
{
    public unsafe class VulkanRenderer
    {
        private const uint VK_SUBPASS_EXTERNAL = ~0U;
        private int width, height;

        private VkInstance vkInstance;
        private VkSurfaceKHR vkSurface;
        private VkPhysicalDevice vkPhysicalDevice;
        private VkDevice vkDevice;
        private VkQueue vkGraphicsQueue;
        private VkQueue vkPresentQueue;
        private VkSwapchainKHR vkSwapChain;
        private VkImage[] vkSwapChainImages;
        private VkFormat vkSwapChainImageFormat;
        private VkExtent2D vkSwapChainExtent;
        private VkImageView[] vkSwapChainImageViews;
        private VkRenderPass vkRenderPass;
        private VkPipelineLayout vkPipelineLayout;
        private VkPipeline vkGraphicsPipeline;
        private VkFramebuffer[] vkSwapChainFramebuffers;
        private VkCommandPool vkCommandPool;
        private VkCommandBuffer[] vkCommandBuffers;
        private VkSemaphore vkImageAvailableSemaphore;
        private VkSemaphore vkRenderFinishedSemaphore;

        public void InitVulkan(IntPtr windowsHandle, int width, int height)
        {
            this.width = width;
            this.height = height;

            CreateInstance();
            CreateSurface(windowsHandle);
            CreatePhysicalDevice();
            CreateLogicalDevice();
            CreateSwapChain();
            CreateImageViews();
            CreateRenderPass();
            CreateGraphicsPipeline();
            CreateFrameBuffers();
            CreateCommandPool();
            CreateCommandBuffers();
            CreateSemaphores();
        }

        public void DrawFrame()
        {
            var result = VulkanNative.vkQueueWaitIdle(vkPresentQueue);
            Helpers.CheckErrors(result);

            uint imageIndex;
            result = VulkanNative.vkAcquireNextImageKHR(vkDevice, vkSwapChain, ulong.MaxValue, vkImageAvailableSemaphore, 0, &imageIndex);
            Helpers.CheckErrors(result);

            VkSemaphore* waitSemaphores = stackalloc VkSemaphore[] { vkImageAvailableSemaphore };
            VkPipelineStageFlagBits* waitStages = stackalloc VkPipelineStageFlagBits[] { VkPipelineStageFlagBits.VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT };
            VkSemaphore* signalSemaphores = stackalloc VkSemaphore[] { vkRenderFinishedSemaphore };
            VkCommandBuffer* commandBuffers = stackalloc VkCommandBuffer[] { vkCommandBuffers[imageIndex] };
            var submitInfo = new VkSubmitInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO,
                pWaitSemaphores = waitSemaphores,
                waitSemaphoreCount = 1,
                pWaitDstStageMask = waitStages,
                commandBufferCount = 1,
                pCommandBuffers = commandBuffers,
                signalSemaphoreCount = 1,
                pSignalSemaphores = signalSemaphores,
            };

            result = VulkanNative.vkQueueSubmit(vkGraphicsQueue, 1, &submitInfo, 0);
            Helpers.CheckErrors(result);

            VkSwapchainKHR* swapChains = stackalloc VkSwapchainKHR[] { vkSwapChain };
            var presentInfo = new VkPresentInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_INFO_KHR,
                waitSemaphoreCount = 1,
                pWaitSemaphores = signalSemaphores,
                swapchainCount = 1,
                pSwapchains = swapChains,
                pImageIndices = &imageIndex,
            };

            result = VulkanNative.vkQueuePresentKHR(vkPresentQueue, &presentInfo);
            Helpers.CheckErrors(result);
        }

        public void CleanUp()
        {
            VulkanNative.vkDeviceWaitIdle(vkDevice);

            VulkanNative.vkDestroySemaphore(vkDevice, vkImageAvailableSemaphore, null);
            VulkanNative.vkDestroySemaphore(vkDevice, vkRenderFinishedSemaphore, null);

            VulkanNative.vkDestroyCommandPool(vkDevice, vkCommandPool, null);

            foreach (var framebuffer in vkSwapChainFramebuffers)
            {
                VulkanNative.vkDestroyFramebuffer(vkDevice, framebuffer, null);
            }

            VulkanNative.vkDestroyPipeline(vkDevice, vkGraphicsPipeline, null);
            VulkanNative.vkDestroyPipelineLayout(vkDevice, vkPipelineLayout, null);
            VulkanNative.vkDestroyRenderPass(vkDevice, vkRenderPass, null);

            foreach (var imageview in vkSwapChainImageViews)
            {
                VulkanNative.vkDestroyImageView(vkDevice, imageview, null);
            }

            VulkanNative.vkDestroySwapchainKHR(vkDevice, vkSwapChain, null);
            VulkanNative.vkDestroyDevice(vkDevice, null);

            VulkanNative.vkDestroySurfaceKHR(vkInstance, vkSurface, null);

            this.debugCallbackFunc = null;
            IntPtr destroyFuncPtr = VulkanNative.vkGetInstanceProcAddr(this.vkInstance, "vkDestroyDebugReportCallbackEXT".ToPointer());
            vkDestroyDebugReportCallbackEXT_d destroyDel = Marshal.GetDelegateForFunctionPointer<vkDestroyDebugReportCallbackEXT_d>(destroyFuncPtr);
            destroyDel(this.vkInstance, this.debugCallbackHandle, null);

            VulkanNative.vkDestroyInstance(vkInstance, null);
        }

        private void CreateInstance()
        {
            ////var availableExtensions = EnumerateInstanceExtensions();
            ////var availableLayers = EnumerateInstanceLayers();

            VkApplicationInfo appInfo = new VkApplicationInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_APPLICATION_INFO,
                pApplicationName = "Hello Triangle".ToPointer(),
                pEngineName = "WaveEngine".ToPointer(),
                engineVersion = Helpers.Version(3, 0, 0),
            };

            string[] extensions = new string[]
            {
                "VK_KHR_surface",
                "VK_KHR_win32_surface",
                "VK_EXT_debug_report",
            };

            IntPtr* extensionsToEnableArray = stackalloc IntPtr[extensions.Length];
            for (int i = 0; i < extensions.Length; i++)
            {
                string extension = extensions[i];
                extensionsToEnableArray[i] = Marshal.StringToHGlobalAnsi(extension);
            }

            string[] layers = new string[]
            {
                "VK_LAYER_LUNARG_standard_validation"
            };

            IntPtr* layersToEnableArray = stackalloc IntPtr[layers.Length];
            for (int i = 0; i < layers.Length; i++)
            {
                string layer = layers[i];
                layersToEnableArray[i] = Marshal.StringToHGlobalAnsi(layer);
            }

            VkInstanceCreateInfo createInfo = new VkInstanceCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO,
                ppEnabledExtensionNames = (byte**)extensionsToEnableArray,
                enabledExtensionCount = (uint)extensions.Length,
                enabledLayerCount = (uint)layers.Length,
                ppEnabledLayerNames = (byte**)layersToEnableArray,
                pApplicationInfo = &appInfo,
            };

            VkInstance newInstance;
            var result = VulkanNative.vkCreateInstance(&createInfo, null, &newInstance);
            this.vkInstance = newInstance;
            Helpers.CheckErrors(result);

            for (int i = 0; i < extensions.Length; i++)
            {
                Marshal.FreeHGlobal(extensionsToEnableArray[i]);
            }

            for (int i = 0; i < layers.Length; i++)
            {
                Marshal.FreeHGlobal(layersToEnableArray[i]);
            }

            EnableDebugCallback();
        }

        internal delegate VkResult vkCreateDebugReportCallbackEXT_d(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* createInfo, IntPtr allocatorPtr, out VkDebugReportCallbackEXT ret);

        internal delegate void vkDestroyDebugReportCallbackEXT_d(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator);

        internal delegate VkResult vkDebugMarkerSetObjectNameEXT_d(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo);

        private VkDebugReportCallbackEXT debugCallbackHandle;
        private PFN_vkDebugReportCallbackEXT debugCallbackFunc;

        private void EnableDebugCallback(VkDebugReportFlagBitsEXT flags = VkDebugReportFlagBitsEXT.VK_DEBUG_REPORT_ERROR_BIT_EXT | VkDebugReportFlagBitsEXT.VK_DEBUG_REPORT_WARNING_BIT_EXT | VkDebugReportFlagBitsEXT.VK_DEBUG_REPORT_DEBUG_BIT_EXT)
        {
            Debug.WriteLine("Enabling Vulkan Debug callbacks.");

            this.debugCallbackFunc = this.DebugCallback;
            IntPtr debugFunctionPtr = Marshal.GetFunctionPointerForDelegate(this.debugCallbackFunc);

            VkDebugReportCallbackCreateInfoEXT debugCallbackCI = new VkDebugReportCallbackCreateInfoEXT();
            debugCallbackCI.sType = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT;
            debugCallbackCI.flags = flags;
            debugCallbackCI.pfnCallback = debugFunctionPtr;

            var createFnPtr = VulkanNative.vkGetInstanceProcAddr(this.vkInstance, "vkCreateDebugReportCallbackEXT".ToPointer());

            if (createFnPtr == IntPtr.Zero)
            {
                return;
            }

            vkCreateDebugReportCallbackEXT_d createDelegate = Marshal.GetDelegateForFunctionPointer<vkCreateDebugReportCallbackEXT_d>(createFnPtr);
            VkResult result = createDelegate(this.vkInstance, &debugCallbackCI, IntPtr.Zero, out this.debugCallbackHandle);
            Helpers.CheckErrors(result);
        }

        private VkBool32 DebugCallback(uint flags, VkDebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage, void* pUserData)
        {
            string message = Marshal.PtrToStringAnsi((IntPtr)pMessage);
            VkDebugReportFlagBitsEXT debugReportFlags = (VkDebugReportFlagBitsEXT)flags;

            string fullMessage = $"[{debugReportFlags}] ({objectType}) {message}";

            if (debugReportFlags == VkDebugReportFlagBitsEXT.VK_DEBUG_REPORT_ERROR_BIT_EXT)
            {
                throw new InvalidOperationException(fullMessage);
            }

            return false;
        }

        public string[] EnumerateInstanceExtensions()
        {
            uint propCount = 0;
            VkResult result = VulkanNative.vkEnumerateInstanceExtensionProperties((byte*)null, &propCount, null);
            Helpers.CheckErrors(result);

            if (propCount == 0)
            {
                return Array.Empty<string>();
            }

            VkExtensionProperties* props = stackalloc VkExtensionProperties[(int)propCount];
            VulkanNative.vkEnumerateInstanceExtensionProperties((byte*)null, &propCount, props);

            string[] ret = new string[propCount];
            for (int i = 0; i < propCount; i++)
            {
                    ret[i] = Marshal.PtrToStringAnsi((IntPtr)props[i].extensionName);
            }

            return ret;
        }

        public string[] EnumerateInstanceLayers()
        {
            uint propCount = 0;
            VkResult result = VulkanNative.vkEnumerateInstanceLayerProperties(&propCount, null);
            Helpers.CheckErrors(result);

            if (propCount == 0)
            {
                return Array.Empty<string>();
            }

            VkLayerProperties* props = stackalloc VkLayerProperties[(int)propCount];
            result = VulkanNative.vkEnumerateInstanceLayerProperties(&propCount, props);
            Helpers.CheckErrors(result);

            string[] ret = new string[propCount];
            for (int i = 0; i < propCount; i++)
            {
                ret[i] = Marshal.PtrToStringAnsi((IntPtr)props[i].layerName);
            }

            return ret;
        }

        private void CreateSurface(IntPtr windowHandle)
        {
            VkWin32SurfaceCreateInfoKHR windowsSurfaceInfo = new VkWin32SurfaceCreateInfoKHR();
            windowsSurfaceInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR;
            windowsSurfaceInfo.hwnd = windowHandle;
            windowsSurfaceInfo.hinstance = Process.GetCurrentProcess().Handle;

            VkSurfaceKHR newVkSurface;
            var result = VulkanNative.vkCreateWin32SurfaceKHR(this.vkInstance,&windowsSurfaceInfo, null, &newVkSurface);
            this.vkSurface = newVkSurface;
            Helpers.CheckErrors(result);
        }

        private void CreatePhysicalDevice()
        {
            uint deviceCount = 0;
            VulkanNative.vkEnumeratePhysicalDevices(this.vkInstance, &deviceCount, null);
            if (deviceCount == 0)
            {
                throw new InvalidOperationException("No physical devices exist.");
            }

            VkPhysicalDevice* physicalDevicesPtr = stackalloc VkPhysicalDevice[(int)deviceCount];
            VulkanNative.vkEnumeratePhysicalDevices(this.vkInstance, &deviceCount, physicalDevicesPtr);

            this.vkPhysicalDevice = physicalDevicesPtr[0];
        }

        private void CreateLogicalDevice()
        {
            var indices = new QueueFamilyIndices(vkPhysicalDevice, vkSurface);

            float priority = 1f;
            var queueCreateInfos = stackalloc VkDeviceQueueCreateInfo[]
            {
                new VkDeviceQueueCreateInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO,
                    queueFamilyIndex = (uint)indices.GraphicsFamily,
                    queueCount = 1,
                    pQueuePriorities = &priority,
                }
            };

            int extensionsCount = 1;
            IntPtr* extensionsToEnableArray = stackalloc IntPtr[extensionsCount];
            for (int i = 0; i < extensionsCount; i++)
            {
                string extension = "VK_KHR_swapchain";
                extensionsToEnableArray[i] = Marshal.StringToHGlobalAnsi(extension);
            }

            VkPhysicalDeviceFeatures deviceFeatures = new VkPhysicalDeviceFeatures();

            var createInfo = new VkDeviceCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO,
                ppEnabledExtensionNames = (byte**)extensionsToEnableArray,
                enabledExtensionCount = (uint)extensionsCount,
                pQueueCreateInfos = queueCreateInfos,
                queueCreateInfoCount = 1,
                pEnabledFeatures = &deviceFeatures,
            };

            VkDevice newDevice;
            var result = VulkanNative.vkCreateDevice(this.vkPhysicalDevice, &createInfo, null, &newDevice);
            this.vkDevice = newDevice;
            Helpers.CheckErrors(result);

            for (int i = 0; i < extensionsCount; i++)
            {
                Marshal.FreeHGlobal(extensionsToEnableArray[i]);
            }

            VkQueue newGraphicsQueue;
            VulkanNative.vkGetDeviceQueue(vkDevice, (uint)indices.GraphicsFamily, 0, &newGraphicsQueue);
            this.vkGraphicsQueue = newGraphicsQueue;

            VkQueue newPresentQueue;
            VulkanNative.vkGetDeviceQueue(vkDevice, (uint)indices.PresentFamily, 0, &newPresentQueue);
            this.vkPresentQueue = newPresentQueue;
        }

        private void CreateSwapChain()
        {
            var swapChainSupport = new SwapChainSupportDetails(vkPhysicalDevice, vkSurface);

            VkSurfaceFormatKHR surfaceFormat = ChooseSwapSurfaceFormat(swapChainSupport.formats);
            VkPresentModeKHR presentMode = ChooseSwapPresentMode(swapChainSupport.presentModes);
            VkExtent2D extent = ChooseSwapExtent(swapChainSupport.capabilities);

            uint imageCount = swapChainSupport.capabilities.minImageCount + 1;
            if (swapChainSupport.capabilities.maxImageCount > 0 && imageCount > swapChainSupport.capabilities.maxImageCount)
            {
                imageCount = Math.Min(imageCount, swapChainSupport.capabilities.maxImageCount);
            }

            var createInfo = new VkSwapchainCreateInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR,
                surface = vkSurface,
                minImageCount = imageCount,
                imageFormat = surfaceFormat.format,
                imageColorSpace = surfaceFormat.colorSpace,
                imageExtent = extent,
                imageArrayLayers = 1,
                imageUsage = VkImageUsageFlagBits.VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT,
                preTransform = swapChainSupport.capabilities.currentTransform,
                compositeAlpha = VkCompositeAlphaFlagBitsKHR.VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR,
                presentMode = presentMode,
                clipped = true,
            };

            var indices = new QueueFamilyIndices(vkPhysicalDevice, vkSurface);

            uint* QueueFamilyIndicesPtr = stackalloc uint[]
            {
                (uint)indices.GraphicsFamily,
                (uint)indices.PresentFamily,
            };

            if (indices.GraphicsFamily != indices.PresentFamily)
            {
                createInfo.imageSharingMode = VkSharingMode.VK_SHARING_MODE_CONCURRENT;
                createInfo.pQueueFamilyIndices = QueueFamilyIndicesPtr;
            }
            else
            {
                createInfo.imageSharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE;
            }

            VkSwapchainKHR newSwapChain;
            var result = VulkanNative.vkCreateSwapchainKHR(vkDevice, &createInfo, null, &newSwapChain);
            vkSwapChain = newSwapChain;
            Helpers.CheckErrors(result);

            VulkanNative.vkGetSwapchainImagesKHR(vkDevice, vkSwapChain, &imageCount, null);
            VkImage* images = stackalloc VkImage[(int)imageCount];
            result = VulkanNative.vkGetSwapchainImagesKHR(vkDevice, vkSwapChain, &imageCount, images);
            Helpers.CheckErrors(result);

            vkSwapChainImages = new VkImage[imageCount];
            for (int i = 0; i < imageCount; i++)
            {
                vkSwapChainImages[i] = images[i];
            }

            vkSwapChainImageFormat = surfaceFormat.format;
            vkSwapChainExtent = extent;
        }


        private VkSurfaceFormatKHR ChooseSwapSurfaceFormat(VkSurfaceFormatKHR[] formats)
        {
            if (formats.Length == 1 && formats[0].format == VkFormat.VK_FORMAT_UNDEFINED)
            {
                return new VkSurfaceFormatKHR() { format = VkFormat.VK_FORMAT_B8G8R8A8_UNORM, colorSpace = VkColorSpaceKHR.VK_COLORSPACE_SRGB_NONLINEAR_KHR };
            }

            foreach (var availableFormat in formats)
            {
                if (availableFormat.format == VkFormat.VK_FORMAT_B8G8R8A8_UNORM && availableFormat.colorSpace == VkColorSpaceKHR.VK_COLORSPACE_SRGB_NONLINEAR_KHR)
                {
                    return availableFormat;
                }
            }

            return formats[0];
        }

        private VkPresentModeKHR ChooseSwapPresentMode(VkPresentModeKHR[] presentModes)
        {
            VkPresentModeKHR bestMode = VkPresentModeKHR.VK_PRESENT_MODE_FIFO_KHR;

            foreach (var availablePresentMode in presentModes)
            {
                if (availablePresentMode == VkPresentModeKHR.VK_PRESENT_MODE_MAILBOX_KHR)
                {
                    return availablePresentMode;
                }
                else if (availablePresentMode == VkPresentModeKHR.VK_PRESENT_MODE_IMMEDIATE_KHR)
                {
                    bestMode = VkPresentModeKHR.VK_PRESENT_MODE_IMMEDIATE_KHR;
                }
            }

            return bestMode;
        }

        private VkExtent2D ChooseSwapExtent(VkSurfaceCapabilitiesKHR capabilities)
        {
            if (capabilities.currentExtent.width != uint.MaxValue)
            {
                return capabilities.currentExtent;
            }

            return new VkExtent2D()
            {
                width = Math.Max(capabilities.minImageExtent.width, Math.Min(capabilities.maxImageExtent.width, (uint)this.width)),
                height = Math.Max(capabilities.minImageExtent.height, Math.Min(capabilities.maxImageExtent.height, (uint)this.height)),
            };
        }

        private void CreateImageViews()
        {
            vkSwapChainImageViews = new VkImageView[vkSwapChainImages.Length];

            for (int i = 0; i < vkSwapChainImages.Length; i++)
            {
                VkImageViewCreateInfo createInfo = new VkImageViewCreateInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO,
                    image = vkSwapChainImages[i],
                    viewType = VkImageViewType.VK_IMAGE_VIEW_TYPE_2D,
                    format = vkSwapChainImageFormat,
                    components = new VkComponentMapping()
                    {
                        r = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY,
                        g = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY,
                        b = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY,
                        a = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY,
                    },
                    subresourceRange = new VkImageSubresourceRange()
                    {
                        aspectMask = VkImageAspectFlagBits.VK_IMAGE_ASPECT_COLOR_BIT,
                        baseMipLevel = 0,
                        levelCount = 1,
                        baseArrayLayer = 0,
                        layerCount = 1
                    }
                };

                VkImageView newImageView;
                var result = VulkanNative.vkCreateImageView(vkDevice, &createInfo, null, &newImageView);
                vkSwapChainImageViews[i] = newImageView;
                Helpers.CheckErrors(result);
            }
        }

        private void CreateRenderPass()
        {
            var colorAttachment = new VkAttachmentDescription()
            {
                format = vkSwapChainImageFormat,
                samples = VkSampleCountFlagBits.VK_SAMPLE_COUNT_1_BIT,
                loadOp = VkAttachmentLoadOp.VK_ATTACHMENT_LOAD_OP_CLEAR,
                storeOp = VkAttachmentStoreOp.VK_ATTACHMENT_STORE_OP_STORE,
                stencilLoadOp = VkAttachmentLoadOp.VK_ATTACHMENT_LOAD_OP_DONT_CARE,
                stencilStoreOp = VkAttachmentStoreOp.VK_ATTACHMENT_STORE_OP_DONT_CARE,
                initialLayout = VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED,
                finalLayout = VkImageLayout.VK_IMAGE_LAYOUT_PRESENT_SRC_KHR,
            };

            var colorAttachmentRef = new VkAttachmentReference()
            {
                attachment = 0,
                layout = VkImageLayout.VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL,
            };

            var subpass = new VkSubpassDescription()
            {
                pipelineBindPoint = VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_GRAPHICS,
                colorAttachmentCount = 1,
                pColorAttachments = &colorAttachmentRef,
            };

            var dependency = new VkSubpassDependency()
            {
                srcSubpass = VK_SUBPASS_EXTERNAL,
                srcStageMask = VkPipelineStageFlagBits.VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT,
                srcAccessMask = 0,

                dstSubpass = 0,
                dstStageMask = VkPipelineStageFlagBits.VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT,
                dstAccessMask = VkAccessFlagBits.VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT,
            };

            var renderPassInfo = new VkRenderPassCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO,
                attachmentCount = 1,
                pAttachments = &colorAttachment,
                subpassCount = 1,
                pSubpasses = &subpass,
                dependencyCount = 1,
                pDependencies = &dependency,
            };

            VkRenderPass newRenderPass;
            var result = VulkanNative.vkCreateRenderPass(vkDevice, &renderPassInfo, null, &newRenderPass);
            vkRenderPass = newRenderPass;
            Helpers.CheckErrors(result);
        }

        private void CreateGraphicsPipeline()
        {
            // Shader stages
            var vertShaderCode = System.IO.File.ReadAllBytes("Shaders/vert.spv");
            var fragShaderCode = System.IO.File.ReadAllBytes("Shaders/frag.spv");

            var vertShaderModule = CreateShaderModule(vertShaderCode);
            var fragShaderModule = CreateShaderModule(fragShaderCode);

            string name = "main";
            int byteCount = System.Text.Encoding.UTF8.GetByteCount(name);
            byte* utf8Ptr = stackalloc byte[byteCount];

            fixed (char* namePtr = name)
            {
                System.Text.Encoding.UTF8.GetBytes(namePtr, name.Length, utf8Ptr, byteCount);
            }

            var vertShaderStageInfo = new VkPipelineShaderStageCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO,
                stage = VkShaderStageFlagBits.VK_SHADER_STAGE_VERTEX_BIT,
                module = vertShaderModule,
                pName = utf8Ptr,
            };

            var fragShaderStageInfo = new VkPipelineShaderStageCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO,
                stage = VkShaderStageFlagBits.VK_SHADER_STAGE_FRAGMENT_BIT,
                module = fragShaderModule,
                pName = utf8Ptr,
            };

            var shaderStages = stackalloc VkPipelineShaderStageCreateInfo[] { vertShaderStageInfo, fragShaderStageInfo };

            // VertexInput
            var vertexInputInfo = new VkPipelineVertexInputStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO,
                vertexBindingDescriptionCount = 0,
                pVertexBindingDescriptions = null,
                vertexAttributeDescriptionCount = 0,
                pVertexAttributeDescriptions = null,
            };

            var inputAssembly = new VkPipelineInputAssemblyStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO,
                topology = VkPrimitiveTopology.VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST,
                primitiveRestartEnable = false,
            };

            var viewport = new VkViewport()
            {
                x = 0f,
                y = 0f,
                width = (float)vkSwapChainExtent.width,
                height = (float)vkSwapChainExtent.height,
                minDepth = 0f,
                maxDepth = 1f,
            };

            var scissor = new VkRect2D()
            {
                offset = new VkOffset2D() { x = 0, y = 0 },
                extent = vkSwapChainExtent,
            };

            var viewportState = new VkPipelineViewportStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO,
                viewportCount = 1,
                pViewports = &viewport,
                scissorCount = 1,
                pScissors = &scissor,
            };

            var rasterizer = new VkPipelineRasterizationStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO,
                depthClampEnable = false,
                rasterizerDiscardEnable = false,
                polygonMode = VkPolygonMode.VK_POLYGON_MODE_FILL,
                lineWidth = 1f,
                cullMode = VkCullModeFlagBits.VK_CULL_MODE_BACK_BIT,
                frontFace = VkFrontFace.VK_FRONT_FACE_CLOCKWISE,
                depthBiasEnable = false,
                depthBiasConstantFactor = 0f,
                depthBiasClamp = 0f,
                depthBiasSlopeFactor = 0f,
            };

            var multisampling = new VkPipelineMultisampleStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO,
                sampleShadingEnable = false,
                rasterizationSamples = VkSampleCountFlagBits.VK_SAMPLE_COUNT_1_BIT,
                minSampleShading = 1f,
                pSampleMask = null,
                alphaToCoverageEnable = false,
                alphaToOneEnable = false,
            };

            var colorBlendAttachment = new VkPipelineColorBlendAttachmentState()
            {
                colorWriteMask = VkColorComponentFlagBits.VK_COLOR_COMPONENT_R_BIT | VkColorComponentFlagBits.VK_COLOR_COMPONENT_G_BIT | VkColorComponentFlagBits.VK_COLOR_COMPONENT_B_BIT | VkColorComponentFlagBits.VK_COLOR_COMPONENT_A_BIT,
                blendEnable = false,
            };


            var colorBlending = new VkPipelineColorBlendStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO,
                logicOpEnable = false,
                logicOp = VkLogicOp.VK_LOGIC_OP_COPY,
                pAttachments = &colorBlendAttachment,
                attachmentCount = 1,
                blendConstants_0 = 0f,
                blendConstants_1 = 0f,
                blendConstants_2 = 0f,
                blendConstants_3 = 0f,
            };

            var pipelineLayoutInfo = new VkPipelineLayoutCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO,
                setLayoutCount = 0,
                pushConstantRangeCount = 0,
            };

            VkPipelineLayout newPipelineLayout;
            var result = VulkanNative.vkCreatePipelineLayout(vkDevice, &pipelineLayoutInfo, null, &newPipelineLayout);
            vkPipelineLayout = newPipelineLayout;
            Helpers.CheckErrors(result);

            var pipelineInfo = new VkGraphicsPipelineCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO,
                stageCount = 2,
                pStages = shaderStages,
                pVertexInputState = &vertexInputInfo,
                pInputAssemblyState = &inputAssembly,
                pViewportState = &viewportState,
                pRasterizationState = &rasterizer,
                pMultisampleState = &multisampling,
                pDepthStencilState = null,
                pColorBlendState = &colorBlending,
                pDynamicState = null,
                layout = vkPipelineLayout,
                renderPass = vkRenderPass,
                subpass = 0,
                basePipelineHandle = 0,
                basePipelineIndex = -1,
            };

            VkPipeline newPipeline;
            result = VulkanNative.vkCreateGraphicsPipelines(vkDevice, 0, 1, &pipelineInfo, null, &newPipeline);
            vkGraphicsPipeline = newPipeline;
            Helpers.CheckErrors(result);

            VulkanNative.vkDestroyShaderModule(vkDevice, vertShaderModule, null);
            VulkanNative.vkDestroyShaderModule(vkDevice, fragShaderModule, null);
        }

        private VkShaderModule CreateShaderModule(byte[] shaderCode)
        {
            VkShaderModuleCreateInfo createInfo = new VkShaderModuleCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO,
                codeSize = (UIntPtr)shaderCode.Length,
            };

            fixed (byte* sourcePointer = shaderCode)
            {
                createInfo.pCode = (uint*)sourcePointer;
            }

            VkShaderModule newShaderModule;
            var result = VulkanNative.vkCreateShaderModule(vkDevice, &createInfo, null, &newShaderModule);
            Helpers.CheckErrors(result);

            return newShaderModule;
        }

        private void CreateFrameBuffers()
        {
            vkSwapChainFramebuffers = new VkFramebuffer[vkSwapChainImageViews.Length];

            for (int i = 0; i < vkSwapChainImageViews.Length; i++)
            {
                var attachments = stackalloc VkImageView[] { vkSwapChainImageViews[i] };

                var frameBufferInfo = new VkFramebufferCreateInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO,
                    renderPass = vkRenderPass,
                    attachmentCount = 1,
                    pAttachments = attachments,
                    width = vkSwapChainExtent.width,
                    height = vkSwapChainExtent.height,
                    layers = 1,
                };

                VkFramebuffer newFrameBuffer;
                var result = VulkanNative.vkCreateFramebuffer(vkDevice, &frameBufferInfo, null, &newFrameBuffer);
                vkSwapChainFramebuffers[i] = newFrameBuffer;
                Helpers.CheckErrors(result);
            }
        }

        private void CreateCommandPool()
        {
            var indices = new QueueFamilyIndices(vkPhysicalDevice, vkSurface);

            var poolInfo = new VkCommandPoolCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO,
                queueFamilyIndex = (uint)indices.GraphicsFamily,
                flags = 0,
            };

            VkCommandPool newCommandPool;
            var result = VulkanNative.vkCreateCommandPool(vkDevice, &poolInfo, null, &newCommandPool);
            vkCommandPool = newCommandPool;
            Helpers.CheckErrors(result);
        }

        private void CreateCommandBuffers()
        {
            var allocInfo = new VkCommandBufferAllocateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO,
                commandPool = vkCommandPool,
                level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY,
                commandBufferCount = (uint)vkSwapChainFramebuffers.Length,
            };

            vkCommandBuffers = new VkCommandBuffer[vkSwapChainFramebuffers.Length];
            fixed(VkCommandBuffer* newCommandBuffer = vkCommandBuffers)
            VulkanNative.vkAllocateCommandBuffers(vkDevice, &allocInfo, newCommandBuffer);

            for (int i = 0; i < vkCommandBuffers.Length; i++)
            {
                var commandBuffer = vkCommandBuffers[i];

                var beginInfo = new VkCommandBufferBeginInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO,
                    flags = VkCommandBufferUsageFlagBits.VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT,
                    pInheritanceInfo = null,
                };

                var result = VulkanNative.vkBeginCommandBuffer(commandBuffer, &beginInfo);
                Helpers.CheckErrors(result);

                VkClearValue clearColor = new VkClearValue()
                {
                    color = new VkClearColorValue(0, 0, 0, 1f),
                };

                var renderPassInfo = new VkRenderPassBeginInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO,
                    renderPass = vkRenderPass,
                    framebuffer = vkSwapChainFramebuffers[i],
                    renderArea = new VkRect2D() { extent = vkSwapChainExtent },
                    pClearValues = &clearColor,
                    clearValueCount = 1,
                };

                VulkanNative.vkCmdBeginRenderPass(commandBuffer, &renderPassInfo, VkSubpassContents.VK_SUBPASS_CONTENTS_INLINE);
                VulkanNative.vkCmdBindPipeline(commandBuffer, VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_GRAPHICS, vkGraphicsPipeline);
                VulkanNative.vkCmdDraw(commandBuffer, 3, 1, 0, 0);
                VulkanNative.vkCmdEndRenderPass(commandBuffer);
                result = VulkanNative.vkEndCommandBuffer(commandBuffer);
                Helpers.CheckErrors(result);
            }
        }

        private void CreateSemaphores()
        {
            var semaphoreInfo = new VkSemaphoreCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO,
            };

            VkSemaphore vkSemaphore;
            var result = VulkanNative.vkCreateSemaphore(vkDevice, &semaphoreInfo, null, &vkSemaphore);
            vkImageAvailableSemaphore = vkSemaphore;
            Helpers.CheckErrors(result);

            result = VulkanNative.vkCreateSemaphore(vkDevice, &semaphoreInfo, null, &vkSemaphore);
            vkRenderFinishedSemaphore = vkSemaphore;
            Helpers.CheckErrors(result);
        }
    }
}
