using WaveEngine.Bindings.Vulkan;

namespace VKDrawTriangle
{
    public struct SwapChainSupportDetails
    {
        public VkSurfaceCapabilitiesKHR capabilities;
        public VkSurfaceFormatKHR[] formats;
        public VkPresentModeKHR[] presentModes;

        public bool IsComplete => formats.Length > 0 && presentModes.Length > 0;

        public SwapChainSupportDetails(VkPhysicalDevice device, VkSurfaceKHR surface)
        {
            capabilities = device.GetSurfaceCapabilitiesKHR(surface);
            formats = device.GetSurfaceFormatsKHR(surface);
            presentModes = device.GetSurfacePresentModesKHR(surface);
        }
    }
}
