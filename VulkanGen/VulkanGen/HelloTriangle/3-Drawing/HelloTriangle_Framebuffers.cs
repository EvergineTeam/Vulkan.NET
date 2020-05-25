using WaveEngine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        private VkFramebuffer[] swapChainFramebuffers;

        private void CreateFramebuffers()
        {
            this.swapChainFramebuffers = new VkFramebuffer[this.swapChainImageViews.Length];

            for (int i = 0; i < this.swapChainImageViews.Length; i++)
            {

                VkFramebufferCreateInfo framebufferInfo = new VkFramebufferCreateInfo();
                framebufferInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO;
                framebufferInfo.renderPass = renderPass;
                framebufferInfo.attachmentCount = 1;

                fixed (VkImageView* attachments = &swapChainImageViews[i])
                {
                    framebufferInfo.pAttachments = attachments;
                }

                framebufferInfo.width = swapChainExtent.width;
                framebufferInfo.height = swapChainExtent.height;
                framebufferInfo.layers = 1;

                fixed (VkFramebuffer* swapChainFramebufferPtr = &this.swapChainFramebuffers[i])
                {
                    Helpers.CheckErrors(VulkanNative.vkCreateFramebuffer(device, &framebufferInfo, null, swapChainFramebufferPtr));
                }
            }
        }
    }
}
