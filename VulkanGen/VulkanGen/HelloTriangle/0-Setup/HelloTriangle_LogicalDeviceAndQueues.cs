using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using WaveEngine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        string[] deviceExtensions = new string[] {
            "VK_KHR_swapchain"           
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

            // Raytracing extensions
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
