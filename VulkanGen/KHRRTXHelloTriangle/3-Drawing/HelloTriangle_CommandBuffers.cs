using Evergine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        private VkCommandPool commandPool;
        private VkCommandBuffer[] commandBuffers;

        private void CreateCommandPool()
        {
            QueueFamilyIndices queueFamilyIndices = this.FindQueueFamilies(this.physicalDevice);

            VkCommandPoolCreateInfo poolInfo = new VkCommandPoolCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO,
                queueFamilyIndex = queueFamilyIndices.graphicsFamily.Value,
                flags = 0, // Optional,
            };

            fixed (VkCommandPool* commandPoolPtr = &this.commandPool)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateCommandPool(device, &poolInfo, null, commandPoolPtr));
            }
        }        
    }
}
