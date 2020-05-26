using System;
using System.Collections.Generic;
using System.Text;
using WaveEngine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        private VkSemaphore imageAvailableSemaphore;
        private VkSemaphore renderFinishedSemaphore;

        private void CreateSemaphores()
        {
            VkSemaphoreCreateInfo semaphoreInfo = new VkSemaphoreCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO,
            };

            fixed (VkSemaphore* imageAvailableSemaphorePtr = &this.imageAvailableSemaphore)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateSemaphore(this.device, &semaphoreInfo, null, imageAvailableSemaphorePtr));
            }

            fixed (VkSemaphore* renderFinishedSemaphorePtr = &this.renderFinishedSemaphore)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateSemaphore(this.device, &semaphoreInfo, null, renderFinishedSemaphorePtr));
            }
        }

        private void DrawFrame()
        {
            // Acquiring and image from the swap chain
            uint imageIndex;
            Helpers.CheckErrors(VulkanNative.vkAcquireNextImageKHR(this.device, this.swapChain, ulong.MaxValue, this.imageAvailableSemaphore, 0, &imageIndex));

            // Submitting the command buffer
            VkSemaphore* waitSemaphores = stackalloc VkSemaphore[] { this.imageAvailableSemaphore };
            VkPipelineStageFlags* waitStages = stackalloc VkPipelineStageFlags[] { VkPipelineStageFlags.VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT };
            VkSemaphore* signalSemaphores = stackalloc VkSemaphore[] { this.renderFinishedSemaphore };
            VkCommandBuffer* commandBuffersPtr = stackalloc VkCommandBuffer[] { commandBuffers[imageIndex] };

            VkSubmitInfo submitInfo = new VkSubmitInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO,
                waitSemaphoreCount = 1,
                pWaitSemaphores = waitSemaphores,
                pWaitDstStageMask = waitStages,
                commandBufferCount = 1,
                pCommandBuffers = commandBuffersPtr,
                signalSemaphoreCount = 1,
                pSignalSemaphores = signalSemaphores,
            };

            Helpers.CheckErrors(VulkanNative.vkQueueSubmit(this.graphicsQueue, 1, &submitInfo, 0));

            // Presentation
            VkSwapchainKHR* swapChains = stackalloc VkSwapchainKHR[] { this.swapChain };
            VkPresentInfoKHR presentInfo = new VkPresentInfoKHR()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_INFO_KHR,
                waitSemaphoreCount = 1,
                pWaitSemaphores = signalSemaphores,
                swapchainCount = 1,
                pSwapchains = swapChains,
                pImageIndices = &imageIndex,
                pResults = null, // Optional
            };

            Helpers.CheckErrors(VulkanNative.vkQueuePresentKHR(this.presentQueue, &presentInfo));

            Helpers.CheckErrors(VulkanNative.vkQueueWaitIdle(this.presentQueue));
        }
    }
}
