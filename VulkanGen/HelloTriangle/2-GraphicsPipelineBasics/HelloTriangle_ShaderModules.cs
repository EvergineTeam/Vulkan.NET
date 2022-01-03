
using System;
using System.IO;
using Evergine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        private VkPipelineLayout pipelineLayout;
        private VkPipeline graphicsPipeline;

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

        private void CreateGraphicsPipeline()
        {
            byte[] vertShaderCode = File.ReadAllBytes("Shaders/vert.spv");
            byte[] fragShaderCode = File.ReadAllBytes("Shaders/frag.spv");

            VkShaderModule vertShaderModule = this.CreateShaderModule(vertShaderCode);
            VkShaderModule fragShaderModule = this.CreateShaderModule(fragShaderCode);

            VkPipelineShaderStageCreateInfo vertShaderStageInfo = new VkPipelineShaderStageCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO,
                stage = VkShaderStageFlags.VK_SHADER_STAGE_VERTEX_BIT,
                module = vertShaderModule,
                pName = "main".ToPointer(),
            };

            VkPipelineShaderStageCreateInfo fragShaderStageInfo = new VkPipelineShaderStageCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO,
                stage = VkShaderStageFlags.VK_SHADER_STAGE_FRAGMENT_BIT,
                module = fragShaderModule,
                pName = "main".ToPointer(),
            };

            VkPipelineShaderStageCreateInfo* shaderStages = stackalloc VkPipelineShaderStageCreateInfo[] { vertShaderStageInfo, fragShaderStageInfo };

            // Vertex Input
            VkPipelineVertexInputStateCreateInfo vertexInputInfo = new VkPipelineVertexInputStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO,
                vertexBindingDescriptionCount = 0,
                pVertexBindingDescriptions = null, // Optional
                vertexAttributeDescriptionCount = 0,
                pVertexAttributeDescriptions = null, // Optional
            };

            // Input assembly
            VkPipelineInputAssemblyStateCreateInfo inputAssembly = new VkPipelineInputAssemblyStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO,
                topology = VkPrimitiveTopology.VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST,
                primitiveRestartEnable = false,
            };

            // Viewports and scissors
            VkViewport viewport = new VkViewport()
            {
                x = 0.0f,
                y = 0.0f,
                width = (float)swapChainExtent.width,
                height = (float)swapChainExtent.height,
                minDepth = 0.0f,
                maxDepth = 1.0f,
            };

            VkRect2D scissor = new VkRect2D()
            {
                offset = new VkOffset2D(0, 0),
                extent = swapChainExtent,
            };

            VkPipelineViewportStateCreateInfo viewportState = new VkPipelineViewportStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO,
                viewportCount = 1,
                pViewports = &viewport,
                scissorCount = 1,
                pScissors = &scissor,
            };

            // Rasterizer
            VkPipelineRasterizationStateCreateInfo rasterizer = new VkPipelineRasterizationStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO,
                depthClampEnable = false,
                rasterizerDiscardEnable = false,
                polygonMode = VkPolygonMode.VK_POLYGON_MODE_FILL,
                lineWidth = 1.0f,
                cullMode = VkCullModeFlags.VK_CULL_MODE_BACK_BIT,
                frontFace = VkFrontFace.VK_FRONT_FACE_CLOCKWISE,
                depthBiasEnable = false,
                depthBiasConstantFactor = 0.0f, // Optional
                depthBiasClamp = 0.0f, // Optional
                depthBiasSlopeFactor = 0.0f, // Optional
            };

            VkPipelineMultisampleStateCreateInfo multisampling = new VkPipelineMultisampleStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO,
                sampleShadingEnable = false,
                rasterizationSamples = VkSampleCountFlags.VK_SAMPLE_COUNT_1_BIT,
                minSampleShading = 1.0f, // Optional
                pSampleMask = null, // Optional
                alphaToCoverageEnable = false, // Optional
                alphaToOneEnable = false, // Optional
            };

            // Depth and Stencil testing
            //VkPipelineDepthStencilStateCreateInfo

            // Color blending
            VkPipelineColorBlendAttachmentState colorBlendAttachment = new VkPipelineColorBlendAttachmentState()
            {
                colorWriteMask = VkColorComponentFlags.VK_COLOR_COMPONENT_R_BIT |
                                 VkColorComponentFlags.VK_COLOR_COMPONENT_G_BIT |
                                 VkColorComponentFlags.VK_COLOR_COMPONENT_B_BIT |
                                 VkColorComponentFlags.VK_COLOR_COMPONENT_A_BIT,
                blendEnable = false,
                srcColorBlendFactor = VkBlendFactor.VK_BLEND_FACTOR_ONE, // Optional
                dstColorBlendFactor = VkBlendFactor.VK_BLEND_FACTOR_ZERO, // Optional
                colorBlendOp = VkBlendOp.VK_BLEND_OP_ADD, // Optional
                srcAlphaBlendFactor = VkBlendFactor.VK_BLEND_FACTOR_ONE, // Optional
                dstAlphaBlendFactor = VkBlendFactor.VK_BLEND_FACTOR_ZERO, // Optional
                alphaBlendOp = VkBlendOp.VK_BLEND_OP_ADD, // Optional
            };

            VkPipelineColorBlendStateCreateInfo colorBlending = new VkPipelineColorBlendStateCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO,
                logicOpEnable = false,
                logicOp = VkLogicOp.VK_LOGIC_OP_COPY, // Optional
                attachmentCount = 1,
                pAttachments = &colorBlendAttachment,
                blendConstants_0 = 0.0f, // Optional
                blendConstants_1 = 0.0f, // Optional
                blendConstants_2 = 0.0f, // Optional
                blendConstants_3 = 0.0f, // Optional
            };

            VkPipelineLayoutCreateInfo pipelineLayoutInfo = new VkPipelineLayoutCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO,
                setLayoutCount = 0, // Optional
                pSetLayouts = null, // Optional
                pushConstantRangeCount = 0, // Optional
                pPushConstantRanges = null, // Optional
            };

            fixed (VkPipelineLayout* pipelineLayoutPtr = &pipelineLayout)
            {
                Helpers.CheckErrors(VulkanNative.vkCreatePipelineLayout(device, &pipelineLayoutInfo, null, pipelineLayoutPtr));
            }

            VkGraphicsPipelineCreateInfo pipelineInfo = new VkGraphicsPipelineCreateInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO,
                stageCount = 2,
                pStages = shaderStages,
                pVertexInputState = &vertexInputInfo,
                pInputAssemblyState = &inputAssembly,
                pViewportState = &viewportState,
                pRasterizationState = &rasterizer,
                pMultisampleState = &multisampling,
                pDepthStencilState = null, // Optional
                pColorBlendState = &colorBlending,
                pDynamicState = null, // Optional
                layout = this.pipelineLayout,
                renderPass = this.renderPass,
                subpass = 0,
                basePipelineHandle = 0, // Optional
                basePipelineIndex = -1, // Optional
            };

            fixed (VkPipeline* graphicsPipelinePtr = &this.graphicsPipeline)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateGraphicsPipelines(this.device, 0, 1, &pipelineInfo, null, graphicsPipelinePtr));
            }

            VulkanNative.vkDestroyShaderModule(device, fragShaderModule, null);
            VulkanNative.vkDestroyShaderModule(device, vertShaderModule, null);
        }
    }
}
