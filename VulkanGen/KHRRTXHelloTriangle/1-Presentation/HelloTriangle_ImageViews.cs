
using Evergine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        private VkImageView[] swapChainImageViews;

        private void CreateImageViews()
        {
            swapChainImageViews = new VkImageView[swapChainImages.Length];

            for (int i = 0; i < swapChainImages.Length; i++)
            {
                VkImageViewCreateInfo createInfo = new VkImageViewCreateInfo();
                createInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO;
                createInfo.image = swapChainImages[i];
                createInfo.viewType = VkImageViewType.VK_IMAGE_VIEW_TYPE_2D;
                createInfo.format = swapChainImageFormat;
                createInfo.components.r = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY;
                createInfo.components.g = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY;
                createInfo.components.b = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY;
                createInfo.components.a = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_IDENTITY;
                createInfo.subresourceRange.aspectMask = VkImageAspectFlags.VK_IMAGE_ASPECT_COLOR_BIT;
                createInfo.subresourceRange.baseMipLevel = 0;
                createInfo.subresourceRange.levelCount = 1;
                createInfo.subresourceRange.baseArrayLayer = 0;
                createInfo.subresourceRange.layerCount = 1;

                fixed (VkImageView* swapChainImageViewPtr = &swapChainImageViews[i])
                {
                    Helpers.CheckErrors(VulkanNative.vkCreateImageView(device, &createInfo, null, swapChainImageViewPtr));
                }
            }
        }
    }
}
