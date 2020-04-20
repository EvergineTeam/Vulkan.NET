using WaveEngine.Bindings.Vulkan;

namespace VKDrawTriangle
{
    public struct QueueFamilyIndices
    {
        public readonly int GraphicsFamily;
        public readonly int PresentFamily;

        public bool IsComplete => GraphicsFamily >= 0 && PresentFamily >= 0;

        public QueueFamilyIndices(VkPhysicalDevice device, VkSurfaceKHR surface)
        {
            int graphicsIndex = -1;
            int presentIndex = -1;

            int i = 0;
            var queues = device.GetQueueFamilyProperties();
            foreach (var f in queues)
            {
                if (graphicsIndex < 0 && f.QueueCount > 0 && (f.QueueFlags & QueueFlags.Graphics) != 0)
                    graphicsIndex = i;

                if (presentIndex < 0 && f.QueueCount > 0 && device.GetSurfaceSupportKHR((uint)i, surface))
                    presentIndex = i;

                ++i;
            }

            GraphicsFamily = graphicsIndex;
            PresentFamily = presentIndex;
        }
    }
}
