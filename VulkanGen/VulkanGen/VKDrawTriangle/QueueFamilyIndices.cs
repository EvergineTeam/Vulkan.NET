using WaveEngine.Bindings.Vulkan;

namespace VKDrawTriangle
{
    public struct QueueFamilyIndices
    {
        public readonly int GraphicsFamily;
        public readonly int PresentFamily;

        public bool IsComplete => GraphicsFamily >= 0 && PresentFamily >= 0;

        public unsafe QueueFamilyIndices(VkPhysicalDevice device, VkSurfaceKHR surface)
        {
            int graphicsIndex = -1;
            int presentIndex = -1;

            uint queueFamilyCount = 0;
            VulkanNative.vkGetPhysicalDeviceQueueFamilyProperties(device, &queueFamilyCount, null);
            VkQueueFamilyProperties* queueFamilies = stackalloc VkQueueFamilyProperties[(int)queueFamilyCount];
            VulkanNative.vkGetPhysicalDeviceQueueFamilyProperties(device, &queueFamilyCount, queueFamilies);

            for (int i = 0; i < queueFamilyCount; i++)
            {
                var q = queueFamilies[i];

                if (q.queueCount > 0 && (q.queueFlags & VkQueueFlagBits.VK_QUEUE_GRAPHICS_BIT) != 0)
                    graphicsIndex = i;

                VkBool32 presentSupported = false;
                VkResult result = VulkanNative.vkGetPhysicalDeviceSurfaceSupportKHR(device, (uint)i, surface, &presentSupported);
                Helpers.CheckErrors(result);
                if (presentIndex < 0 && q.queueCount > 0 && presentSupported)
                    presentIndex = i;
            }

            GraphicsFamily = graphicsIndex;
            PresentFamily = presentIndex;
        }
    }
}
