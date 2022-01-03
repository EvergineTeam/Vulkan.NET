
using System;
using Evergine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        VkShaderModule CreateShaderModule(byte[] code)
        {
            VkShaderModuleCreateInfo createInfo = new VkShaderModuleCreateInfo();
            createInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO;
            createInfo.codeSize = (UIntPtr)code.Length;

            fixed (byte* sourcePointer = code)
            {
                createInfo.pCode = (uint*)sourcePointer;
            }

            VkShaderModule shaderModule;
            Helpers.CheckErrors(VulkanNative.vkCreateShaderModule(device, &createInfo, null, &shaderModule));

            return shaderModule;
        }
    }
}
