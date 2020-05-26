using System;
using System.Collections.Generic;
using WaveEngine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        private VkPhysicalDevice physicalDevice;

        private void PickPhysicalDevice()
        {
            uint deviceCount = 0;
            Helpers.CheckErrors(VulkanNative.vkEnumeratePhysicalDevices(instance, &deviceCount, null));
            if (deviceCount == 0)
            {
                throw new Exception("Failed to find GPUs with Vulkan support!");
            }

            VkPhysicalDevice* devices = stackalloc VkPhysicalDevice[(int)deviceCount];
            Helpers.CheckErrors(VulkanNative.vkEnumeratePhysicalDevices(instance, &deviceCount, devices));

            for (int i = 0; i < deviceCount; i++)
            {
                var device = devices[i];
                if (this.IsPhysicalDeviceSuitable(device))
                {
                    this.physicalDevice = device;
                    break;
                }
            }

            if (this.physicalDevice == default)
            {
                throw new Exception("failed to find a suitable GPU!");
            }
        }

        private bool IsPhysicalDeviceSuitable(VkPhysicalDevice physicalDevice)
        {
            QueueFamilyIndices indices = this.FindQueueFamilies(physicalDevice);

            bool extensionsSupported = this.CheckPhysicalDeviceExtensionSupport(physicalDevice);

            // acquire Raytracing features
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
            VulkanNative.vkGetPhysicalDeviceFeatures2(physicalDevice, &deviceFeatures2);

            extensionsSupported = extensionsSupported && rayTracingFeatures.rayTracing;

            bool swapChainAdequate = false;
            if (extensionsSupported)
            {
                SwapChainSupportDetails swapChainSupport = this.QuerySwapChainSupport(physicalDevice);
                swapChainAdequate = (swapChainSupport.formats.Length != 0 && swapChainSupport.presentModes.Length != 0);
            }

            return indices.IsComplete() && extensionsSupported && swapChainAdequate;
        }

        private bool CheckPhysicalDeviceExtensionSupport(VkPhysicalDevice physicalDevice)
        {
            uint extensionCount;
            Helpers.CheckErrors(VulkanNative.vkEnumerateDeviceExtensionProperties(physicalDevice, null, &extensionCount, null));

            VkExtensionProperties* availableExtensions = stackalloc VkExtensionProperties[(int)extensionCount];
            Helpers.CheckErrors(VulkanNative.vkEnumerateDeviceExtensionProperties(physicalDevice, null, &extensionCount, availableExtensions));

            HashSet<string> requiredExtensions = new HashSet<string>(deviceExtensions);

            for(int i = 0; i < extensionCount; i++)
            {
                var extension = availableExtensions[i];
                requiredExtensions.Remove(Helpers.GetString(extension.extensionName));
            }

            return requiredExtensions.Count == 0;
        }

        public struct QueueFamilyIndices
        {
            public uint? graphicsFamily;
            public uint? presentFamily;

            public bool IsComplete()
            {
                return graphicsFamily.HasValue && presentFamily.HasValue;
            }
        }

        private QueueFamilyIndices FindQueueFamilies(VkPhysicalDevice physicalDevice)
        {
            QueueFamilyIndices indices = default;

            uint queueFamilyCount = 0;
            VulkanNative.vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &queueFamilyCount, null);

            VkQueueFamilyProperties* queueFamilies = stackalloc VkQueueFamilyProperties[(int)queueFamilyCount];
            VulkanNative.vkGetPhysicalDeviceQueueFamilyProperties(physicalDevice, &queueFamilyCount, queueFamilies);

            for (uint i = 0; i < queueFamilyCount; i++)
            {
                var queueFamily = queueFamilies[i];
                if ((queueFamily.queueFlags & VkQueueFlags.VK_QUEUE_GRAPHICS_BIT) != 0)
                {                    
                    indices.graphicsFamily = i;
                }

                VkBool32 presentSupport = false;
                Helpers.CheckErrors(VulkanNative.vkGetPhysicalDeviceSurfaceSupportKHR(physicalDevice, i, this.surface, &presentSupport));

                if (presentSupport)
                {
                    indices.presentFamily = i;
                }

                if (indices.IsComplete())
                {
                    break;
                }
            }

            return indices;
        }

        private bool IsDeviceSuitable(VkPhysicalDevice physicalDevice)
        {
            QueueFamilyIndices indices = this.FindQueueFamilies(physicalDevice);

            return indices.IsComplete();
        }
    }
}
