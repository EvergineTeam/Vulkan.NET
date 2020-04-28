using System;
using WaveEngine.Bindings.Vulkan;

namespace VulkanRaytracing.Structs
{
    public unsafe struct AccelerationMemory
    {
        public VkBuffer buffer;
        public VkDeviceMemory memory;
        public ulong memoryAddress;
        public void* mappedPointer;
    }
}
