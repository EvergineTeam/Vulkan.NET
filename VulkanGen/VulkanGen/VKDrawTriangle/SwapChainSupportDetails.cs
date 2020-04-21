using WaveEngine.Bindings.Vulkan;

namespace VKDrawTriangle
{
    public struct SwapChainSupportDetails
    {
        public VkSurfaceCapabilitiesKHR capabilities;
        public VkSurfaceFormatKHR[] formats;
        public VkPresentModeKHR[] presentModes;

        public bool IsComplete => formats.Length > 0 && presentModes.Length > 0;

        public unsafe SwapChainSupportDetails(VkPhysicalDevice device, VkSurfaceKHR surface)
        {
            VkSurfaceCapabilitiesKHR capabilitiesKHR;
            VulkanNative.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(device, surface, &capabilitiesKHR);
            capabilities = capabilitiesKHR;
            formats = null;
            presentModes = null;

            uint formatCount;
            VulkanNative.vkGetPhysicalDeviceSurfaceFormatsKHR(device, surface, &formatCount, null);
            if (formatCount > 0)
            {
                formats = new VkSurfaceFormatKHR[formatCount];
                fixed (VkSurfaceFormatKHR* formatsPtr = formats)
                {
                    VulkanNative.vkGetPhysicalDeviceSurfaceFormatsKHR(device, surface, &formatCount, formatsPtr);
                }
            }

            uint presentModeCount;
            VulkanNative.vkGetPhysicalDeviceSurfacePresentModesKHR(device, surface, &presentModeCount, null);
            if (presentModeCount > 0)
            {
                presentModes = new VkPresentModeKHR[presentModeCount];
                fixed (VkPresentModeKHR* presentsPtr = presentModes)
                {
                    VulkanNative.vkGetPhysicalDeviceSurfacePresentModesKHR(device, surface, &presentModeCount, presentsPtr);
                }
            }
        }
    }
}
