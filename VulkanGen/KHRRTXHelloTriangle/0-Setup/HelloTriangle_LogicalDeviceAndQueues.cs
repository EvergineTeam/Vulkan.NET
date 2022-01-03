using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Evergine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        string[] deviceExtensions = new string[] {
            "VK_KHR_swapchain",
            "VK_KHR_acceleration_structure",
            "VK_KHR_ray_tracing_pipeline",
            "VK_EXT_descriptor_indexing",
            "VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations",
            "VK_KHR_spirv_1_4",
            "VK_KHR_shader_float_controls",
        };

        private VkDevice device;
        private VkQueue graphicsQueue;
        private VkQueue presentQueue;

        private void CreateLogicalDevice()
        {
            QueueFamilyIndices indices = this.FindQueueFamilies(physicalDevice);

            List<VkDeviceQueueCreateInfo> queueCreateInfos = new List<VkDeviceQueueCreateInfo>();
            HashSet<uint> uniqueQueueFamilies = new HashSet<uint>() { indices.graphicsFamily.Value, indices.presentFamily.Value };

            float queuePriority = 1.0f;
            foreach (uint queueFamily in uniqueQueueFamilies)
            {
                VkDeviceQueueCreateInfo queueCreateInfo = new VkDeviceQueueCreateInfo()
                {
                    sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO,
                    queueFamilyIndex = queueFamily,
                    queueCount = 1,
                    pQueuePriorities = &queuePriority,
                };
                queueCreateInfos.Add(queueCreateInfo);
            }

            VkPhysicalDeviceFeatures deviceFeatures = default;

            // chain multiple features required for RT into deviceInfo.pNext

            // require buffer device address feature
            VkPhysicalDeviceBufferDeviceAddressFeatures deviceBufferDeviceAddressFeatures = new VkPhysicalDeviceBufferDeviceAddressFeatures()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES,
                bufferDeviceAddress = true,
                pNext = null,
            };

            // require ray tracing pipeline feature
            VkPhysicalDeviceRayTracingPipelineFeaturesKHR deviceRayTracingPipelineFeatures = new VkPhysicalDeviceRayTracingPipelineFeaturesKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR,
                pNext = &deviceBufferDeviceAddressFeatures,
                rayTracingPipeline = true,
            };

            // require acceleration structure feature
            VkPhysicalDeviceAccelerationStructureFeaturesKHR deviceAccelerationStructureFeatures = new VkPhysicalDeviceAccelerationStructureFeaturesKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR,
                accelerationStructure = true,
                pNext = &deviceRayTracingPipelineFeatures,
            };

            VkPhysicalDeviceVulkan12Features deviceVulkan12Features = new VkPhysicalDeviceVulkan12Features()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES,
                pNext = &deviceAccelerationStructureFeatures,
                bufferDeviceAddress = true,
            };

            int deviceExtensionsCount = deviceExtensions.Length;
            IntPtr* deviceExtensionsArray = stackalloc IntPtr[deviceExtensionsCount];
            for (int i = 0; i < deviceExtensionsCount; i++)
            {
                string extension = deviceExtensions[i];
                deviceExtensionsArray[i] = Marshal.StringToHGlobalAnsi(extension);
            }

            VkDeviceCreateInfo createInfo = new VkDeviceCreateInfo();
            createInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO;
            createInfo.pNext = &deviceVulkan12Features;

            VkDeviceQueueCreateInfo[] queueCreateInfosArray = queueCreateInfos.ToArray();
            fixed (VkDeviceQueueCreateInfo* queueCreateInfosArrayPtr = &queueCreateInfosArray[0])
            {
                createInfo.queueCreateInfoCount = (uint)queueCreateInfos.Count;
                createInfo.pQueueCreateInfos = queueCreateInfosArrayPtr;
            }

            createInfo.pEnabledFeatures = &deviceFeatures;
            createInfo.enabledExtensionCount = (uint)deviceExtensions.Length;
            createInfo.ppEnabledExtensionNames = (byte**)deviceExtensionsArray;

            fixed (VkDevice* devicePtr = &device)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateDevice(physicalDevice, &createInfo, null, devicePtr));
            }

            fixed (VkQueue* graphicsQueuePtr = &graphicsQueue)
            {
                VulkanNative.vkGetDeviceQueue(device, indices.graphicsFamily.Value, 0, graphicsQueuePtr);
            }

            fixed(VkQueue* presentQueuePtr = &presentQueue)
            {
                VulkanNative.vkGetDeviceQueue(device, indices.presentFamily.Value, 0, presentQueuePtr); // TODO queue index 0 ?¿?¿
            }
        }
    }
}
