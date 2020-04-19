using System;
using WaveEngine.Bindings.Vulkan;

namespace VKDrawTriangle
{
    class Program
    {
        static unsafe void Main(string[] args)
        {

            VkBufferCopy c = new VkBufferCopy();
            VulkanNative.vkCmdCopyBuffer(new VkCommandBuffer(), new VkBuffer(), new VkBuffer(), 0, &c);
        }
    }
}
