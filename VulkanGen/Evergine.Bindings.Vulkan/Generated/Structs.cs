using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Vulkan
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBaseOutStructure
	{
		public VkStructureType sType;
		public VkBaseOutStructure* pNext;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBaseInStructure
	{
		public VkStructureType sType;
		public VkBaseInStructure* pNext;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOffset2D
	{
		public int x;
		public int y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOffset3D
	{
		public int x;
		public int y;
		public int z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExtent2D
	{
		public uint width;
		public uint height;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExtent3D
	{
		public uint width;
		public uint height;
		public uint depth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkViewport
	{
		public float x;
		public float y;
		public float width;
		public float height;
		public float minDepth;
		public float maxDepth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRect2D
	{
		public VkOffset2D offset;
		public VkExtent2D extent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkClearRect
	{
		public VkRect2D rect;
		public uint baseArrayLayer;
		public uint layerCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkComponentMapping
	{
		public VkComponentSwizzle r;
		public VkComponentSwizzle g;
		public VkComponentSwizzle b;
		public VkComponentSwizzle a;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProperties
	{
		public uint apiVersion;
		public uint driverVersion;
		public uint vendorID;
		public uint deviceID;
		public VkPhysicalDeviceType deviceType;
		public fixed byte deviceName[(int)VulkanNative.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
		public fixed byte pipelineCacheUUID[(int)VulkanNative.VK_UUID_SIZE];
		public VkPhysicalDeviceLimits limits;
		public VkPhysicalDeviceSparseProperties sparseProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExtensionProperties
	{
		public fixed byte extensionName[(int)VulkanNative.VK_MAX_EXTENSION_NAME_SIZE];
		public uint specVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkLayerProperties
	{
		public fixed byte layerName[(int)VulkanNative.VK_MAX_EXTENSION_NAME_SIZE];
		public uint specVersion;
		public uint implementationVersion;
		public fixed byte description[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkApplicationInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* pApplicationName;
		public uint applicationVersion;
		public byte* pEngineName;
		public uint engineVersion;
		public uint apiVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAllocationCallbacks
	{
		public void* pUserData;
		public IntPtr pfnAllocation;
		public IntPtr pfnReallocation;
		public IntPtr pfnFree;
		public IntPtr pfnInternalAllocation;
		public IntPtr pfnInternalFree;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceQueueCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceQueueCreateFlags flags;
		public uint queueFamilyIndex;
		public uint queueCount;
		public float* pQueuePriorities;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint queueCreateInfoCount;
		public VkDeviceQueueCreateInfo* pQueueCreateInfos;
		public uint enabledLayerCount;
		public byte** ppEnabledLayerNames;
		public uint enabledExtensionCount;
		public byte** ppEnabledExtensionNames;
		public VkPhysicalDeviceFeatures* pEnabledFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkInstanceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkInstanceCreateFlags flags;
		public VkApplicationInfo* pApplicationInfo;
		public uint enabledLayerCount;
		public byte** ppEnabledLayerNames;
		public uint enabledExtensionCount;
		public byte** ppEnabledExtensionNames;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyProperties
	{
		public VkQueueFlags queueFlags;
		public uint queueCount;
		public uint timestampValidBits;
		public VkExtent3D minImageTransferGranularity;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryProperties
	{
		public uint memoryTypeCount;
		public VkMemoryType memoryTypes_0;
		public VkMemoryType memoryTypes_1;
		public VkMemoryType memoryTypes_2;
		public VkMemoryType memoryTypes_3;
		public VkMemoryType memoryTypes_4;
		public VkMemoryType memoryTypes_5;
		public VkMemoryType memoryTypes_6;
		public VkMemoryType memoryTypes_7;
		public VkMemoryType memoryTypes_8;
		public VkMemoryType memoryTypes_9;
		public VkMemoryType memoryTypes_10;
		public VkMemoryType memoryTypes_11;
		public VkMemoryType memoryTypes_12;
		public VkMemoryType memoryTypes_13;
		public VkMemoryType memoryTypes_14;
		public VkMemoryType memoryTypes_15;
		public VkMemoryType memoryTypes_16;
		public VkMemoryType memoryTypes_17;
		public VkMemoryType memoryTypes_18;
		public VkMemoryType memoryTypes_19;
		public VkMemoryType memoryTypes_20;
		public VkMemoryType memoryTypes_21;
		public VkMemoryType memoryTypes_22;
		public VkMemoryType memoryTypes_23;
		public VkMemoryType memoryTypes_24;
		public VkMemoryType memoryTypes_25;
		public VkMemoryType memoryTypes_26;
		public VkMemoryType memoryTypes_27;
		public VkMemoryType memoryTypes_28;
		public VkMemoryType memoryTypes_29;
		public VkMemoryType memoryTypes_30;
		public VkMemoryType memoryTypes_31;
		public uint memoryHeapCount;
		public VkMemoryHeap memoryHeaps_0;
		public VkMemoryHeap memoryHeaps_1;
		public VkMemoryHeap memoryHeaps_2;
		public VkMemoryHeap memoryHeaps_3;
		public VkMemoryHeap memoryHeaps_4;
		public VkMemoryHeap memoryHeaps_5;
		public VkMemoryHeap memoryHeaps_6;
		public VkMemoryHeap memoryHeaps_7;
		public VkMemoryHeap memoryHeaps_8;
		public VkMemoryHeap memoryHeaps_9;
		public VkMemoryHeap memoryHeaps_10;
		public VkMemoryHeap memoryHeaps_11;
		public VkMemoryHeap memoryHeaps_12;
		public VkMemoryHeap memoryHeaps_13;
		public VkMemoryHeap memoryHeaps_14;
		public VkMemoryHeap memoryHeaps_15;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong allocationSize;
		public uint memoryTypeIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryRequirements
	{
		public ulong size;
		public ulong alignment;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageFormatProperties
	{
		public VkImageAspectFlags aspectMask;
		public VkExtent3D imageGranularity;
		public VkSparseImageFormatFlags flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageMemoryRequirements
	{
		public VkSparseImageFormatProperties formatProperties;
		public uint imageMipTailFirstLod;
		public ulong imageMipTailSize;
		public ulong imageMipTailOffset;
		public ulong imageMipTailStride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryType
	{
		public VkMemoryPropertyFlags propertyFlags;
		public uint heapIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryHeap
	{
		public ulong size;
		public VkMemoryHeapFlags flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMappedMemoryRange
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public ulong offset;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFormatProperties
	{
		public VkFormatFeatureFlags linearTilingFeatures;
		public VkFormatFeatureFlags optimalTilingFeatures;
		public VkFormatFeatureFlags bufferFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageFormatProperties
	{
		public VkExtent3D maxExtent;
		public uint maxMipLevels;
		public uint maxArrayLayers;
		public VkSampleCountFlags sampleCounts;
		public ulong maxResourceSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorBufferInfo
	{
		public VkBuffer buffer;
		public ulong offset;
		public ulong range;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorImageInfo
	{
		public VkSampler sampler;
		public VkImageView imageView;
		public VkImageLayout imageLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWriteDescriptorSet
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorSet dstSet;
		public uint dstBinding;
		public uint dstArrayElement;
		public uint descriptorCount;
		public VkDescriptorType descriptorType;
		public VkDescriptorImageInfo* pImageInfo;
		public VkDescriptorBufferInfo* pBufferInfo;
		public VkBufferView* pTexelBufferView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyDescriptorSet
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorSet srcSet;
		public uint srcBinding;
		public uint srcArrayElement;
		public VkDescriptorSet dstSet;
		public uint dstBinding;
		public uint dstArrayElement;
		public uint descriptorCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferUsageFlags2CreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong usage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBufferCreateFlags flags;
		public ulong size;
		public VkBufferUsageFlags usage;
		public VkSharingMode sharingMode;
		public uint queueFamilyIndexCount;
		public uint* pQueueFamilyIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferViewCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBuffer buffer;
		public VkFormat format;
		public ulong offset;
		public ulong range;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSubresource
	{
		public VkImageAspectFlags aspectMask;
		public uint mipLevel;
		public uint arrayLayer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSubresourceLayers
	{
		public VkImageAspectFlags aspectMask;
		public uint mipLevel;
		public uint baseArrayLayer;
		public uint layerCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSubresourceRange
	{
		public VkImageAspectFlags aspectMask;
		public uint baseMipLevel;
		public uint levelCount;
		public uint baseArrayLayer;
		public uint layerCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryBarrier
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccessFlags srcAccessMask;
		public VkAccessFlags dstAccessMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferMemoryBarrier
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccessFlags srcAccessMask;
		public VkAccessFlags dstAccessMask;
		public uint srcQueueFamilyIndex;
		public uint dstQueueFamilyIndex;
		public VkBuffer buffer;
		public ulong offset;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageMemoryBarrier
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccessFlags srcAccessMask;
		public VkAccessFlags dstAccessMask;
		public VkImageLayout oldLayout;
		public VkImageLayout newLayout;
		public uint srcQueueFamilyIndex;
		public uint dstQueueFamilyIndex;
		public VkImage image;
		public VkImageSubresourceRange subresourceRange;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageCreateFlags flags;
		public VkImageType imageType;
		public VkFormat format;
		public VkExtent3D extent;
		public uint mipLevels;
		public uint arrayLayers;
		public VkSampleCountFlags samples;
		public VkImageTiling tiling;
		public VkImageUsageFlags usage;
		public VkSharingMode sharingMode;
		public uint queueFamilyIndexCount;
		public uint* pQueueFamilyIndices;
		public VkImageLayout initialLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubresourceLayout
	{
		public ulong offset;
		public ulong size;
		public ulong rowPitch;
		public ulong arrayPitch;
		public ulong depthPitch;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageViewCreateFlags flags;
		public VkImage image;
		public VkImageViewType viewType;
		public VkFormat format;
		public VkComponentMapping components;
		public VkImageSubresourceRange subresourceRange;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCopy
	{
		public ulong srcOffset;
		public ulong dstOffset;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseMemoryBind
	{
		public ulong resourceOffset;
		public ulong size;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
		public VkSparseMemoryBindFlags flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageMemoryBind
	{
		public VkImageSubresource subresource;
		public VkOffset3D offset;
		public VkExtent3D extent;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
		public VkSparseMemoryBindFlags flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseBufferMemoryBindInfo
	{
		public VkBuffer buffer;
		public uint bindCount;
		public VkSparseMemoryBind* pBinds;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageOpaqueMemoryBindInfo
	{
		public VkImage image;
		public uint bindCount;
		public VkSparseMemoryBind* pBinds;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageMemoryBindInfo
	{
		public VkImage image;
		public uint bindCount;
		public VkSparseImageMemoryBind* pBinds;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindSparseInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreCount;
		public VkSemaphore* pWaitSemaphores;
		public uint bufferBindCount;
		public VkSparseBufferMemoryBindInfo* pBufferBinds;
		public uint imageOpaqueBindCount;
		public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
		public uint imageBindCount;
		public VkSparseImageMemoryBindInfo* pImageBinds;
		public uint signalSemaphoreCount;
		public VkSemaphore* pSignalSemaphores;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageCopy
	{
		public VkImageSubresourceLayers srcSubresource;
		public VkOffset3D srcOffset;
		public VkImageSubresourceLayers dstSubresource;
		public VkOffset3D dstOffset;
		public VkExtent3D extent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageBlit
	{
		public VkImageSubresourceLayers srcSubresource;
		public VkOffset3D srcOffsets_0;
		public VkOffset3D srcOffsets_1;
		public VkImageSubresourceLayers dstSubresource;
		public VkOffset3D dstOffsets_0;
		public VkOffset3D dstOffsets_1;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferImageCopy
	{
		public ulong bufferOffset;
		public uint bufferRowLength;
		public uint bufferImageHeight;
		public VkImageSubresourceLayers imageSubresource;
		public VkOffset3D imageOffset;
		public VkExtent3D imageExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyMemoryIndirectCommandNV
	{
		public ulong srcAddress;
		public ulong dstAddress;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyMemoryToImageIndirectCommandNV
	{
		public ulong srcAddress;
		public uint bufferRowLength;
		public uint bufferImageHeight;
		public VkImageSubresourceLayers imageSubresource;
		public VkOffset3D imageOffset;
		public VkExtent3D imageExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageResolve
	{
		public VkImageSubresourceLayers srcSubresource;
		public VkOffset3D srcOffset;
		public VkImageSubresourceLayers dstSubresource;
		public VkOffset3D dstOffset;
		public VkExtent3D extent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderModuleCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public UIntPtr codeSize;
		public uint* pCode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetLayoutBinding
	{
		public uint binding;
		public VkDescriptorType descriptorType;
		public uint descriptorCount;
		public VkShaderStageFlags stageFlags;
		public VkSampler* pImmutableSamplers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetLayoutCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorSetLayoutCreateFlags flags;
		public uint bindingCount;
		public VkDescriptorSetLayoutBinding* pBindings;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorPoolSize
	{
		public VkDescriptorType type;
		public uint descriptorCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorPoolCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorPoolCreateFlags flags;
		public uint maxSets;
		public uint poolSizeCount;
		public VkDescriptorPoolSize* pPoolSizes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorPool descriptorPool;
		public uint descriptorSetCount;
		public VkDescriptorSetLayout* pSetLayouts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSpecializationMapEntry
	{
		public uint constantID;
		public uint offset;
		public UIntPtr size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSpecializationInfo
	{
		public uint mapEntryCount;
		public VkSpecializationMapEntry* pMapEntries;
		public UIntPtr dataSize;
		public void* pData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineShaderStageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineShaderStageCreateFlags flags;
		public VkShaderStageFlags stage;
		public VkShaderModule module;
		public byte* pName;
		public VkSpecializationInfo* pSpecializationInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkComputePipelineCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreateFlags flags;
		public VkPipelineShaderStageCreateInfo stage;
		public VkPipelineLayout layout;
		public VkPipeline basePipelineHandle;
		public int basePipelineIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkComputePipelineIndirectBufferInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong deviceAddress;
		public ulong size;
		public ulong pipelineDeviceAddressCaptureReplay;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCreateFlags2CreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVertexInputBindingDescription
	{
		public uint binding;
		public uint stride;
		public VkVertexInputRate inputRate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVertexInputAttributeDescription
	{
		public uint location;
		public uint binding;
		public VkFormat format;
		public uint offset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineVertexInputStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint vertexBindingDescriptionCount;
		public VkVertexInputBindingDescription* pVertexBindingDescriptions;
		public uint vertexAttributeDescriptionCount;
		public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineInputAssemblyStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkPrimitiveTopology topology;
		public VkBool32 primitiveRestartEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineTessellationStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint patchControlPoints;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint viewportCount;
		public VkViewport* pViewports;
		public uint scissorCount;
		public VkRect2D* pScissors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBool32 depthClampEnable;
		public VkBool32 rasterizerDiscardEnable;
		public VkPolygonMode polygonMode;
		public VkCullModeFlags cullMode;
		public VkFrontFace frontFace;
		public VkBool32 depthBiasEnable;
		public float depthBiasConstantFactor;
		public float depthBiasClamp;
		public float depthBiasSlopeFactor;
		public float lineWidth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineMultisampleStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkSampleCountFlags rasterizationSamples;
		public VkBool32 sampleShadingEnable;
		public float minSampleShading;
		public uint* pSampleMask;
		public VkBool32 alphaToCoverageEnable;
		public VkBool32 alphaToOneEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineColorBlendAttachmentState
	{
		public VkBool32 blendEnable;
		public VkBlendFactor srcColorBlendFactor;
		public VkBlendFactor dstColorBlendFactor;
		public VkBlendOp colorBlendOp;
		public VkBlendFactor srcAlphaBlendFactor;
		public VkBlendFactor dstAlphaBlendFactor;
		public VkBlendOp alphaBlendOp;
		public VkColorComponentFlags colorWriteMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineColorBlendStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineColorBlendStateCreateFlags flags;
		public VkBool32 logicOpEnable;
		public VkLogicOp logicOp;
		public uint attachmentCount;
		public VkPipelineColorBlendAttachmentState* pAttachments;
		public float blendConstants_0;
		public float blendConstants_1;
		public float blendConstants_2;
		public float blendConstants_3;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineDynamicStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint dynamicStateCount;
		public VkDynamicState* pDynamicStates;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkStencilOpState
	{
		public VkStencilOp failOp;
		public VkStencilOp passOp;
		public VkStencilOp depthFailOp;
		public VkCompareOp compareOp;
		public uint compareMask;
		public uint writeMask;
		public uint reference;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineDepthStencilStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineDepthStencilStateCreateFlags flags;
		public VkBool32 depthTestEnable;
		public VkBool32 depthWriteEnable;
		public VkCompareOp depthCompareOp;
		public VkBool32 depthBoundsTestEnable;
		public VkBool32 stencilTestEnable;
		public VkStencilOpState front;
		public VkStencilOpState back;
		public float minDepthBounds;
		public float maxDepthBounds;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGraphicsPipelineCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreateFlags flags;
		public uint stageCount;
		public VkPipelineShaderStageCreateInfo* pStages;
		public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
		public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
		public VkPipelineTessellationStateCreateInfo* pTessellationState;
		public VkPipelineViewportStateCreateInfo* pViewportState;
		public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
		public VkPipelineMultisampleStateCreateInfo* pMultisampleState;
		public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
		public VkPipelineColorBlendStateCreateInfo* pColorBlendState;
		public VkPipelineDynamicStateCreateInfo* pDynamicState;
		public VkPipelineLayout layout;
		public VkRenderPass renderPass;
		public uint subpass;
		public VkPipeline basePipelineHandle;
		public int basePipelineIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCacheCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCacheCreateFlags flags;
		public UIntPtr initialDataSize;
		public void* pInitialData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCacheHeaderVersionOne
	{
		public uint headerSize;
		public VkPipelineCacheHeaderVersion headerVersion;
		public uint vendorID;
		public uint deviceID;
		public fixed byte pipelineCacheUUID[(int)VulkanNative.VK_UUID_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCacheStageValidationIndexEntry
	{
		public ulong codeSize;
		public ulong codeOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCacheSafetyCriticalIndexEntry
	{
		public fixed byte pipelineIdentifier[(int)VulkanNative.VK_UUID_SIZE];
		public ulong pipelineMemorySize;
		public ulong jsonSize;
		public ulong jsonOffset;
		public uint stageIndexCount;
		public uint stageIndexStride;
		public ulong stageIndexOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCacheHeaderVersionSafetyCriticalOne
	{
		public VkPipelineCacheHeaderVersionOne headerVersionOne;
		public VkPipelineCacheValidationVersion validationVersion;
		public uint implementationData;
		public uint pipelineIndexCount;
		public uint pipelineIndexStride;
		public ulong pipelineIndexOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPushConstantRange
	{
		public VkShaderStageFlags stageFlags;
		public uint offset;
		public uint size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineLayoutCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineLayoutCreateFlags flags;
		public uint setLayoutCount;
		public VkDescriptorSetLayout* pSetLayouts;
		public uint pushConstantRangeCount;
		public VkPushConstantRange* pPushConstantRanges;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSamplerCreateFlags flags;
		public VkFilter magFilter;
		public VkFilter minFilter;
		public VkSamplerMipmapMode mipmapMode;
		public VkSamplerAddressMode addressModeU;
		public VkSamplerAddressMode addressModeV;
		public VkSamplerAddressMode addressModeW;
		public float mipLodBias;
		public VkBool32 anisotropyEnable;
		public float maxAnisotropy;
		public VkBool32 compareEnable;
		public VkCompareOp compareOp;
		public float minLod;
		public float maxLod;
		public VkBorderColor borderColor;
		public VkBool32 unnormalizedCoordinates;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandPoolCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCommandPoolCreateFlags flags;
		public uint queueFamilyIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCommandPool commandPool;
		public VkCommandBufferLevel level;
		public uint commandBufferCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferInheritanceInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPass renderPass;
		public uint subpass;
		public VkFramebuffer framebuffer;
		public VkBool32 occlusionQueryEnable;
		public VkQueryControlFlags queryFlags;
		public VkQueryPipelineStatisticFlags pipelineStatistics;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCommandBufferUsageFlags flags;
		public VkCommandBufferInheritanceInfo* pInheritanceInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPass renderPass;
		public VkFramebuffer framebuffer;
		public VkRect2D renderArea;
		public uint clearValueCount;
		public VkClearValue* pClearValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkClearDepthStencilValue
	{
		public float depth;
		public uint stencil;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkClearAttachment
	{
		public VkImageAspectFlags aspectMask;
		public uint colorAttachment;
		public VkClearValue clearValue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentDescription
	{
		public VkAttachmentDescriptionFlags flags;
		public VkFormat format;
		public VkSampleCountFlags samples;
		public VkAttachmentLoadOp loadOp;
		public VkAttachmentStoreOp storeOp;
		public VkAttachmentLoadOp stencilLoadOp;
		public VkAttachmentStoreOp stencilStoreOp;
		public VkImageLayout initialLayout;
		public VkImageLayout finalLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentReference
	{
		public uint attachment;
		public VkImageLayout layout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDescription
	{
		public VkSubpassDescriptionFlags flags;
		public VkPipelineBindPoint pipelineBindPoint;
		public uint inputAttachmentCount;
		public VkAttachmentReference* pInputAttachments;
		public uint colorAttachmentCount;
		public VkAttachmentReference* pColorAttachments;
		public VkAttachmentReference* pResolveAttachments;
		public VkAttachmentReference* pDepthStencilAttachment;
		public uint preserveAttachmentCount;
		public uint* pPreserveAttachments;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDependency
	{
		public uint srcSubpass;
		public uint dstSubpass;
		public VkPipelineStageFlags srcStageMask;
		public VkPipelineStageFlags dstStageMask;
		public VkAccessFlags srcAccessMask;
		public VkAccessFlags dstAccessMask;
		public VkDependencyFlags dependencyFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPassCreateFlags flags;
		public uint attachmentCount;
		public VkAttachmentDescription* pAttachments;
		public uint subpassCount;
		public VkSubpassDescription* pSubpasses;
		public uint dependencyCount;
		public VkSubpassDependency* pDependencies;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkEventCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkEventCreateFlags flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFenceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFenceCreateFlags flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFeatures
	{
		public VkBool32 robustBufferAccess;
		public VkBool32 fullDrawIndexUint32;
		public VkBool32 imageCubeArray;
		public VkBool32 independentBlend;
		public VkBool32 geometryShader;
		public VkBool32 tessellationShader;
		public VkBool32 sampleRateShading;
		public VkBool32 dualSrcBlend;
		public VkBool32 logicOp;
		public VkBool32 multiDrawIndirect;
		public VkBool32 drawIndirectFirstInstance;
		public VkBool32 depthClamp;
		public VkBool32 depthBiasClamp;
		public VkBool32 fillModeNonSolid;
		public VkBool32 depthBounds;
		public VkBool32 wideLines;
		public VkBool32 largePoints;
		public VkBool32 alphaToOne;
		public VkBool32 multiViewport;
		public VkBool32 samplerAnisotropy;
		public VkBool32 textureCompressionETC2;
		public VkBool32 textureCompressionASTC_LDR;
		public VkBool32 textureCompressionBC;
		public VkBool32 occlusionQueryPrecise;
		public VkBool32 pipelineStatisticsQuery;
		public VkBool32 vertexPipelineStoresAndAtomics;
		public VkBool32 fragmentStoresAndAtomics;
		public VkBool32 shaderTessellationAndGeometryPointSize;
		public VkBool32 shaderImageGatherExtended;
		public VkBool32 shaderStorageImageExtendedFormats;
		public VkBool32 shaderStorageImageMultisample;
		public VkBool32 shaderStorageImageReadWithoutFormat;
		public VkBool32 shaderStorageImageWriteWithoutFormat;
		public VkBool32 shaderUniformBufferArrayDynamicIndexing;
		public VkBool32 shaderSampledImageArrayDynamicIndexing;
		public VkBool32 shaderStorageBufferArrayDynamicIndexing;
		public VkBool32 shaderStorageImageArrayDynamicIndexing;
		public VkBool32 shaderClipDistance;
		public VkBool32 shaderCullDistance;
		public VkBool32 shaderFloat64;
		public VkBool32 shaderInt64;
		public VkBool32 shaderInt16;
		public VkBool32 shaderResourceResidency;
		public VkBool32 shaderResourceMinLod;
		public VkBool32 sparseBinding;
		public VkBool32 sparseResidencyBuffer;
		public VkBool32 sparseResidencyImage2D;
		public VkBool32 sparseResidencyImage3D;
		public VkBool32 sparseResidency2Samples;
		public VkBool32 sparseResidency4Samples;
		public VkBool32 sparseResidency8Samples;
		public VkBool32 sparseResidency16Samples;
		public VkBool32 sparseResidencyAliased;
		public VkBool32 variableMultisampleRate;
		public VkBool32 inheritedQueries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSparseProperties
	{
		public VkBool32 residencyStandard2DBlockShape;
		public VkBool32 residencyStandard2DMultisampleBlockShape;
		public VkBool32 residencyStandard3DBlockShape;
		public VkBool32 residencyAlignedMipSize;
		public VkBool32 residencyNonResidentStrict;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLimits
	{
		public uint maxImageDimension1D;
		public uint maxImageDimension2D;
		public uint maxImageDimension3D;
		public uint maxImageDimensionCube;
		public uint maxImageArrayLayers;
		public uint maxTexelBufferElements;
		public uint maxUniformBufferRange;
		public uint maxStorageBufferRange;
		public uint maxPushConstantsSize;
		public uint maxMemoryAllocationCount;
		public uint maxSamplerAllocationCount;
		public ulong bufferImageGranularity;
		public ulong sparseAddressSpaceSize;
		public uint maxBoundDescriptorSets;
		public uint maxPerStageDescriptorSamplers;
		public uint maxPerStageDescriptorUniformBuffers;
		public uint maxPerStageDescriptorStorageBuffers;
		public uint maxPerStageDescriptorSampledImages;
		public uint maxPerStageDescriptorStorageImages;
		public uint maxPerStageDescriptorInputAttachments;
		public uint maxPerStageResources;
		public uint maxDescriptorSetSamplers;
		public uint maxDescriptorSetUniformBuffers;
		public uint maxDescriptorSetUniformBuffersDynamic;
		public uint maxDescriptorSetStorageBuffers;
		public uint maxDescriptorSetStorageBuffersDynamic;
		public uint maxDescriptorSetSampledImages;
		public uint maxDescriptorSetStorageImages;
		public uint maxDescriptorSetInputAttachments;
		public uint maxVertexInputAttributes;
		public uint maxVertexInputBindings;
		public uint maxVertexInputAttributeOffset;
		public uint maxVertexInputBindingStride;
		public uint maxVertexOutputComponents;
		public uint maxTessellationGenerationLevel;
		public uint maxTessellationPatchSize;
		public uint maxTessellationControlPerVertexInputComponents;
		public uint maxTessellationControlPerVertexOutputComponents;
		public uint maxTessellationControlPerPatchOutputComponents;
		public uint maxTessellationControlTotalOutputComponents;
		public uint maxTessellationEvaluationInputComponents;
		public uint maxTessellationEvaluationOutputComponents;
		public uint maxGeometryShaderInvocations;
		public uint maxGeometryInputComponents;
		public uint maxGeometryOutputComponents;
		public uint maxGeometryOutputVertices;
		public uint maxGeometryTotalOutputComponents;
		public uint maxFragmentInputComponents;
		public uint maxFragmentOutputAttachments;
		public uint maxFragmentDualSrcAttachments;
		public uint maxFragmentCombinedOutputResources;
		public uint maxComputeSharedMemorySize;
		public uint maxComputeWorkGroupCount_0;
		public uint maxComputeWorkGroupCount_1;
		public uint maxComputeWorkGroupCount_2;
		public uint maxComputeWorkGroupInvocations;
		public uint maxComputeWorkGroupSize_0;
		public uint maxComputeWorkGroupSize_1;
		public uint maxComputeWorkGroupSize_2;
		public uint subPixelPrecisionBits;
		public uint subTexelPrecisionBits;
		public uint mipmapPrecisionBits;
		public uint maxDrawIndexedIndexValue;
		public uint maxDrawIndirectCount;
		public float maxSamplerLodBias;
		public float maxSamplerAnisotropy;
		public uint maxViewports;
		public uint maxViewportDimensions_0;
		public uint maxViewportDimensions_1;
		public float viewportBoundsRange_0;
		public float viewportBoundsRange_1;
		public uint viewportSubPixelBits;
		public UIntPtr minMemoryMapAlignment;
		public ulong minTexelBufferOffsetAlignment;
		public ulong minUniformBufferOffsetAlignment;
		public ulong minStorageBufferOffsetAlignment;
		public int minTexelOffset;
		public uint maxTexelOffset;
		public int minTexelGatherOffset;
		public uint maxTexelGatherOffset;
		public float minInterpolationOffset;
		public float maxInterpolationOffset;
		public uint subPixelInterpolationOffsetBits;
		public uint maxFramebufferWidth;
		public uint maxFramebufferHeight;
		public uint maxFramebufferLayers;
		public VkSampleCountFlags framebufferColorSampleCounts;
		public VkSampleCountFlags framebufferDepthSampleCounts;
		public VkSampleCountFlags framebufferStencilSampleCounts;
		public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
		public uint maxColorAttachments;
		public VkSampleCountFlags sampledImageColorSampleCounts;
		public VkSampleCountFlags sampledImageIntegerSampleCounts;
		public VkSampleCountFlags sampledImageDepthSampleCounts;
		public VkSampleCountFlags sampledImageStencilSampleCounts;
		public VkSampleCountFlags storageImageSampleCounts;
		public uint maxSampleMaskWords;
		public VkBool32 timestampComputeAndGraphics;
		public float timestampPeriod;
		public uint maxClipDistances;
		public uint maxCullDistances;
		public uint maxCombinedClipAndCullDistances;
		public uint discreteQueuePriorities;
		public float pointSizeRange_0;
		public float pointSizeRange_1;
		public float lineWidthRange_0;
		public float lineWidthRange_1;
		public float pointSizeGranularity;
		public float lineWidthGranularity;
		public VkBool32 strictLines;
		public VkBool32 standardSampleLocations;
		public ulong optimalBufferCopyOffsetAlignment;
		public ulong optimalBufferCopyRowPitchAlignment;
		public ulong nonCoherentAtomSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueryPoolCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkQueryType queryType;
		public uint queryCount;
		public VkQueryPipelineStatisticFlags pipelineStatistics;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFramebufferCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFramebufferCreateFlags flags;
		public VkRenderPass renderPass;
		public uint attachmentCount;
		public VkImageView* pAttachments;
		public uint width;
		public uint height;
		public uint layers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrawIndirectCommand
	{
		public uint vertexCount;
		public uint instanceCount;
		public uint firstVertex;
		public uint firstInstance;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrawIndexedIndirectCommand
	{
		public uint indexCount;
		public uint instanceCount;
		public uint firstIndex;
		public int vertexOffset;
		public uint firstInstance;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDispatchIndirectCommand
	{
		public uint x;
		public uint y;
		public uint z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMultiDrawInfoEXT
	{
		public uint firstVertex;
		public uint vertexCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMultiDrawIndexedInfoEXT
	{
		public uint firstIndex;
		public uint indexCount;
		public int vertexOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreCount;
		public VkSemaphore* pWaitSemaphores;
		public VkPipelineStageFlags* pWaitDstStageMask;
		public uint commandBufferCount;
		public VkCommandBuffer* pCommandBuffers;
		public uint signalSemaphoreCount;
		public VkSemaphore* pSignalSemaphores;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPropertiesKHR
	{
		public VkDisplayKHR display;
		public byte* displayName;
		public VkExtent2D physicalDimensions;
		public VkExtent2D physicalResolution;
		public VkSurfaceTransformFlagsKHR supportedTransforms;
		public VkBool32 planeReorderPossible;
		public VkBool32 persistentContent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlanePropertiesKHR
	{
		public VkDisplayKHR currentDisplay;
		public uint currentStackIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayModeParametersKHR
	{
		public VkExtent2D visibleRegion;
		public uint refreshRate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayModePropertiesKHR
	{
		public VkDisplayModeKHR displayMode;
		public VkDisplayModeParametersKHR parameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayModeCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkDisplayModeParametersKHR parameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlaneCapabilitiesKHR
	{
		public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
		public VkOffset2D minSrcPosition;
		public VkOffset2D maxSrcPosition;
		public VkExtent2D minSrcExtent;
		public VkExtent2D maxSrcExtent;
		public VkOffset2D minDstPosition;
		public VkOffset2D maxDstPosition;
		public VkExtent2D minDstExtent;
		public VkExtent2D maxDstExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplaySurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkDisplayModeKHR displayMode;
		public uint planeIndex;
		public uint planeStackIndex;
		public VkSurfaceTransformFlagsKHR transform;
		public float globalAlpha;
		public VkDisplayPlaneAlphaFlagsKHR alphaMode;
		public VkExtent2D imageExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPresentInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRect2D srcRect;
		public VkRect2D dstRect;
		public VkBool32 persistent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceCapabilitiesKHR
	{
		public uint minImageCount;
		public uint maxImageCount;
		public VkExtent2D currentExtent;
		public VkExtent2D minImageExtent;
		public VkExtent2D maxImageExtent;
		public uint maxImageArrayLayers;
		public VkSurfaceTransformFlagsKHR supportedTransforms;
		public VkSurfaceTransformFlagsKHR currentTransform;
		public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
		public VkImageUsageFlags supportedUsageFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidSurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkViSurfaceCreateInfoNN
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public void* window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWaylandSurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr display;
		public IntPtr surface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWin32SurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr hinstance;
		public IntPtr hwnd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkXlibSurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr dpy;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkXcbSurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr connection;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDirectFBSurfaceCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr dfb;
		public IntPtr surface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImagePipeSurfaceCreateInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr imagePipeHandle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkStreamDescriptorSurfaceCreateInfoGGP
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr streamDescriptor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkScreenSurfaceCreateInfoQNX
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr context;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceFormatKHR
	{
		public VkFormat format;
		public VkColorSpaceKHR colorSpace;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainCreateFlagsKHR flags;
		public VkSurfaceKHR surface;
		public uint minImageCount;
		public VkFormat imageFormat;
		public VkColorSpaceKHR imageColorSpace;
		public VkExtent2D imageExtent;
		public uint imageArrayLayers;
		public VkImageUsageFlags imageUsage;
		public VkSharingMode imageSharingMode;
		public uint queueFamilyIndexCount;
		public uint* pQueueFamilyIndices;
		public VkSurfaceTransformFlagsKHR preTransform;
		public VkCompositeAlphaFlagsKHR compositeAlpha;
		public VkPresentModeKHR presentMode;
		public VkBool32 clipped;
		public VkSwapchainKHR oldSwapchain;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreCount;
		public VkSemaphore* pWaitSemaphores;
		public uint swapchainCount;
		public VkSwapchainKHR* pSwapchains;
		public uint* pImageIndices;
		public VkResult* pResults;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugReportCallbackCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDebugReportFlagsEXT flags;
		public IntPtr pfnCallback;
		public void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkValidationFlagsEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint disabledValidationCheckCount;
		public VkValidationCheckEXT* pDisabledValidationChecks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkValidationFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint enabledValidationFeatureCount;
		public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
		public uint disabledValidationFeatureCount;
		public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkLayerSettingsCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint settingCount;
		public VkLayerSettingEXT* pSettings;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkLayerSettingEXT
	{
		public byte* pLayerName;
		public byte* pSettingName;
		public VkLayerSettingTypeEXT type;
		public uint valueCount;
		public void* pValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkApplicationParametersEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint vendorID;
		public uint deviceID;
		public uint key;
		public ulong value;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationStateRasterizationOrderAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRasterizationOrderAMD rasterizationOrder;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugMarkerObjectNameInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDebugReportObjectTypeEXT objectType;
		public ulong vkObject;
		public byte* pObjectName;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugMarkerObjectTagInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDebugReportObjectTypeEXT objectType;
		public ulong vkObject;
		public ulong tagName;
		public UIntPtr tagSize;
		public void* pTag;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugMarkerMarkerInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* pMarkerName;
		public float color_0;
		public float color_1;
		public float color_2;
		public float color_3;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDedicatedAllocationImageCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dedicatedAllocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDedicatedAllocationBufferCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dedicatedAllocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDedicatedAllocationMemoryAllocateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalImageFormatPropertiesNV
	{
		public VkImageFormatProperties imageFormatProperties;
		public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;
		public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
		public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalMemoryImageCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagsNV handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMemoryAllocateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagsNV handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryWin32HandleInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagsNV handleType;
		public IntPtr handle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMemoryWin32HandleInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
		public IntPtr dwAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMemorySciBufInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemorySciBufInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlags handleType;
		public IntPtr handle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryGetSciBufInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public VkExternalMemoryHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemorySciBufPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalMemorySciBufFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 sciBufImport;
		public VkBool32 sciBufExport;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint acquireCount;
		public VkDeviceMemory* pAcquireSyncs;
		public ulong* pAcquireKeys;
		public uint* pAcquireTimeoutMilliseconds;
		public uint releaseCount;
		public VkDeviceMemory* pReleaseSyncs;
		public ulong* pReleaseKeys;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 deviceGeneratedCommands;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 deviceGeneratedCompute;
		public VkBool32 deviceGeneratedComputePipelines;
		public VkBool32 deviceGeneratedComputeCaptureReplay;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDevicePrivateDataCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint privateDataSlotRequestCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPrivateDataSlotCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePrivateDataFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 privateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxGraphicsShaderGroupCount;
		public uint maxIndirectSequenceCount;
		public uint maxIndirectCommandsTokenCount;
		public uint maxIndirectCommandsStreamCount;
		public uint maxIndirectCommandsTokenOffset;
		public uint maxIndirectCommandsStreamStride;
		public uint minSequencesCountBufferOffsetAlignment;
		public uint minSequencesIndexBufferOffsetAlignment;
		public uint minIndirectCommandsBufferOffsetAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiDrawPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxMultiDrawCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGraphicsShaderGroupCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint stageCount;
		public VkPipelineShaderStageCreateInfo* pStages;
		public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
		public VkPipelineTessellationStateCreateInfo* pTessellationState;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGraphicsPipelineShaderGroupsCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint groupCount;
		public VkGraphicsShaderGroupCreateInfoNV* pGroups;
		public uint pipelineCount;
		public VkPipeline* pPipelines;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindShaderGroupIndirectCommandNV
	{
		public uint groupIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindIndexBufferIndirectCommandNV
	{
		public ulong bufferAddress;
		public uint size;
		public VkIndexType indexType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindVertexBufferIndirectCommandNV
	{
		public ulong bufferAddress;
		public uint size;
		public uint stride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSetStateFlagsIndirectCommandNV
	{
		public uint data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkIndirectCommandsStreamNV
	{
		public VkBuffer buffer;
		public ulong offset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkIndirectCommandsLayoutTokenNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkIndirectCommandsTokenTypeNV tokenType;
		public uint stream;
		public uint offset;
		public uint vertexBindingUnit;
		public VkBool32 vertexDynamicStride;
		public VkPipelineLayout pushconstantPipelineLayout;
		public VkShaderStageFlags pushconstantShaderStageFlags;
		public uint pushconstantOffset;
		public uint pushconstantSize;
		public VkIndirectStateFlagsNV indirectStateFlags;
		public uint indexTypeCount;
		public VkIndexType* pIndexTypes;
		public uint* pIndexTypeValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkIndirectCommandsLayoutCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkIndirectCommandsLayoutUsageFlagsNV flags;
		public VkPipelineBindPoint pipelineBindPoint;
		public uint tokenCount;
		public VkIndirectCommandsLayoutTokenNV* pTokens;
		public uint streamCount;
		public uint* pStreamStrides;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeneratedCommandsInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineBindPoint pipelineBindPoint;
		public VkPipeline pipeline;
		public VkIndirectCommandsLayoutNV indirectCommandsLayout;
		public uint streamCount;
		public VkIndirectCommandsStreamNV* pStreams;
		public uint sequencesCount;
		public VkBuffer preprocessBuffer;
		public ulong preprocessOffset;
		public ulong preprocessSize;
		public VkBuffer sequencesCountBuffer;
		public ulong sequencesCountOffset;
		public VkBuffer sequencesIndexBuffer;
		public ulong sequencesIndexOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeneratedCommandsMemoryRequirementsInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineBindPoint pipelineBindPoint;
		public VkPipeline pipeline;
		public VkIndirectCommandsLayoutNV indirectCommandsLayout;
		public uint maxSequencesCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineIndirectDeviceAddressInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineBindPoint pipelineBindPoint;
		public VkPipeline pipeline;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindPipelineIndirectCommandNV
	{
		public ulong pipelineAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFeatures2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPhysicalDeviceFeatures features;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPhysicalDeviceProperties properties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFormatProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormatProperties formatProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageFormatProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageFormatProperties imageFormatProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageFormatInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public VkImageType type;
		public VkImageTiling tiling;
		public VkImageUsageFlags usage;
		public VkImageCreateFlags flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkQueueFamilyProperties queueFamilyProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPhysicalDeviceMemoryProperties memoryProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageFormatProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSparseImageFormatProperties properties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSparseImageFormatInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public VkImageType type;
		public VkSampleCountFlags samples;
		public VkImageUsageFlags usage;
		public VkImageTiling tiling;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePushDescriptorPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxPushDescriptors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkConformanceVersion
	{
		public byte major;
		public byte minor;
		public byte subminor;
		public byte patch;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDriverProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDriverId driverID;
		public fixed byte driverName[(int)VulkanNative.VK_MAX_DRIVER_NAME_SIZE];
		public fixed byte driverInfo[(int)VulkanNative.VK_MAX_DRIVER_INFO_SIZE];
		public VkConformanceVersion conformanceVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentRegionsKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint swapchainCount;
		public VkPresentRegionKHR* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentRegionKHR
	{
		public uint rectangleCount;
		public VkRectLayerKHR* pRectangles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRectLayerKHR
	{
		public VkOffset2D offset;
		public VkExtent2D extent;
		public uint layer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVariablePointersFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 variablePointersStorageBuffer;
		public VkBool32 variablePointers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalMemoryProperties
	{
		public VkExternalMemoryFeatureFlags externalMemoryFeatures;
		public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
		public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalImageFormatProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryProperties externalMemoryProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalBufferInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBufferCreateFlags flags;
		public VkBufferUsageFlags usage;
		public VkExternalMemoryHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalBufferProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryProperties externalMemoryProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceIDProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte deviceUUID[(int)VulkanNative.VK_UUID_SIZE];
		public fixed byte driverUUID[(int)VulkanNative.VK_UUID_SIZE];
		public fixed byte deviceLUID[(int)VulkanNative.VK_LUID_SIZE];
		public uint deviceNodeMask;
		public VkBool32 deviceLUIDValid;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalMemoryImageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlags handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalMemoryBufferCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlags handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMemoryAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlags handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlags handleType;
		public IntPtr handle;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMemoryWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
		public IntPtr dwAccess;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryZirconHandleInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlags handleType;
		public IntPtr handle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryZirconHandlePropertiesFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryGetZirconHandleInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public VkExternalMemoryHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryWin32HandlePropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryGetWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public VkExternalMemoryHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlags handleType;
		public int fd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryFdPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryGetFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public VkExternalMemoryHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint acquireCount;
		public VkDeviceMemory* pAcquireSyncs;
		public ulong* pAcquireKeys;
		public uint* pAcquireTimeouts;
		public uint releaseCount;
		public VkDeviceMemory* pReleaseSyncs;
		public ulong* pReleaseKeys;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalSemaphoreInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalSemaphoreHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalSemaphoreProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
		public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
		public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportSemaphoreCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalSemaphoreHandleTypeFlags handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportSemaphoreWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkSemaphoreImportFlags flags;
		public VkExternalSemaphoreHandleTypeFlags handleType;
		public IntPtr handle;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportSemaphoreWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
		public IntPtr dwAccess;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkD3D12FenceSubmitInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreValuesCount;
		public ulong* pWaitSemaphoreValues;
		public uint signalSemaphoreValuesCount;
		public ulong* pSignalSemaphoreValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreGetWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkExternalSemaphoreHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportSemaphoreFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkSemaphoreImportFlags flags;
		public VkExternalSemaphoreHandleTypeFlags handleType;
		public int fd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreGetFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkExternalSemaphoreHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportSemaphoreZirconHandleInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkSemaphoreImportFlags flags;
		public VkExternalSemaphoreHandleTypeFlags handleType;
		public IntPtr zirconHandle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreGetZirconHandleInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkExternalSemaphoreHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalFenceInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalFenceHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalFenceProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
		public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
		public VkExternalFenceFeatureFlags externalFenceFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportFenceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalFenceHandleTypeFlags handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportFenceWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkFenceImportFlags flags;
		public VkExternalFenceHandleTypeFlags handleType;
		public IntPtr handle;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportFenceWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
		public IntPtr dwAccess;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFenceGetWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkExternalFenceHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportFenceFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkFenceImportFlags flags;
		public VkExternalFenceHandleTypeFlags handleType;
		public int fd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFenceGetFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkExternalFenceHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportFenceSciSyncInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportFenceSciSyncInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkExternalFenceHandleTypeFlags handleType;
		public void* handle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFenceGetSciSyncInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkExternalFenceHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportSemaphoreSciSyncInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportSemaphoreSciSyncInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkExternalSemaphoreHandleTypeFlags handleType;
		public void* handle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreGetSciSyncInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkExternalSemaphoreHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSciSyncAttributesInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSciSyncClientTypeNV clientType;
		public VkSciSyncPrimitiveTypeNV primitiveType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalSciSyncFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 sciSyncFence;
		public VkBool32 sciSyncSemaphore;
		public VkBool32 sciSyncImport;
		public VkBool32 sciSyncExport;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalSciSync2FeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 sciSyncFence;
		public VkBool32 sciSyncSemaphore2;
		public VkBool32 sciSyncImport;
		public VkBool32 sciSyncExport;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreSciSyncPoolCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr handle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreSciSyncCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphoreSciSyncPoolNV semaphorePool;
		public IntPtr pFence;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceSemaphoreSciSyncPoolReservationCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint semaphoreSciSyncPoolRequestCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiviewFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 multiview;
		public VkBool32 multiviewGeometryShader;
		public VkBool32 multiviewTessellationShader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiviewProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxMultiviewViewCount;
		public uint maxMultiviewInstanceIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassMultiviewCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint subpassCount;
		public uint* pViewMasks;
		public uint dependencyCount;
		public int* pViewOffsets;
		public uint correlationMaskCount;
		public uint* pCorrelationMasks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceCapabilities2EXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint minImageCount;
		public uint maxImageCount;
		public VkExtent2D currentExtent;
		public VkExtent2D minImageExtent;
		public VkExtent2D maxImageExtent;
		public uint maxImageArrayLayers;
		public VkSurfaceTransformFlagsKHR supportedTransforms;
		public VkSurfaceTransformFlagsKHR currentTransform;
		public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
		public VkImageUsageFlags supportedUsageFlags;
		public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPowerInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayPowerStateEXT powerState;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceEventInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceEventTypeEXT deviceEvent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayEventInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayEventTypeEXT displayEvent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainCounterCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceCounterFlagsEXT surfaceCounters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceGroupProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint physicalDeviceCount;
		public VkPhysicalDevice physicalDevices_0;
		public VkPhysicalDevice physicalDevices_1;
		public VkPhysicalDevice physicalDevices_2;
		public VkPhysicalDevice physicalDevices_3;
		public VkPhysicalDevice physicalDevices_4;
		public VkPhysicalDevice physicalDevices_5;
		public VkPhysicalDevice physicalDevices_6;
		public VkPhysicalDevice physicalDevices_7;
		public VkPhysicalDevice physicalDevices_8;
		public VkPhysicalDevice physicalDevices_9;
		public VkPhysicalDevice physicalDevices_10;
		public VkPhysicalDevice physicalDevices_11;
		public VkPhysicalDevice physicalDevices_12;
		public VkPhysicalDevice physicalDevices_13;
		public VkPhysicalDevice physicalDevices_14;
		public VkPhysicalDevice physicalDevices_15;
		public VkPhysicalDevice physicalDevices_16;
		public VkPhysicalDevice physicalDevices_17;
		public VkPhysicalDevice physicalDevices_18;
		public VkPhysicalDevice physicalDevices_19;
		public VkPhysicalDevice physicalDevices_20;
		public VkPhysicalDevice physicalDevices_21;
		public VkPhysicalDevice physicalDevices_22;
		public VkPhysicalDevice physicalDevices_23;
		public VkPhysicalDevice physicalDevices_24;
		public VkPhysicalDevice physicalDevices_25;
		public VkPhysicalDevice physicalDevices_26;
		public VkPhysicalDevice physicalDevices_27;
		public VkPhysicalDevice physicalDevices_28;
		public VkPhysicalDevice physicalDevices_29;
		public VkPhysicalDevice physicalDevices_30;
		public VkPhysicalDevice physicalDevices_31;
		public VkBool32 subsetAllocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryAllocateFlagsInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMemoryAllocateFlags flags;
		public uint deviceMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindBufferMemoryInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindBufferMemoryDeviceGroupInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint deviceIndexCount;
		public uint* pDeviceIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindImageMemoryInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindImageMemoryDeviceGroupInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint deviceIndexCount;
		public uint* pDeviceIndices;
		public uint splitInstanceBindRegionCount;
		public VkRect2D* pSplitInstanceBindRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupRenderPassBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint deviceMask;
		public uint deviceRenderAreaCount;
		public VkRect2D* pDeviceRenderAreas;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupCommandBufferBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint deviceMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreCount;
		public uint* pWaitSemaphoreDeviceIndices;
		public uint commandBufferCount;
		public uint* pCommandBufferDeviceMasks;
		public uint signalSemaphoreCount;
		public uint* pSignalSemaphoreDeviceIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupBindSparseInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint resourceDeviceIndex;
		public uint memoryDeviceIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupPresentCapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed uint presentMask[(int)VulkanNative.VK_MAX_DEVICE_GROUP_SIZE];
		public VkDeviceGroupPresentModeFlagsKHR modes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSwapchainCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainKHR swapchain;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindImageMemorySwapchainInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainKHR swapchain;
		public uint imageIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAcquireNextImageInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainKHR swapchain;
		public ulong timeout;
		public VkSemaphore semaphore;
		public VkFence fence;
		public uint deviceMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupPresentInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint swapchainCount;
		public uint* pDeviceMasks;
		public VkDeviceGroupPresentModeFlagsKHR mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupDeviceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint physicalDeviceCount;
		public VkPhysicalDevice* pPhysicalDevices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupSwapchainCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceGroupPresentModeFlagsKHR modes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorUpdateTemplateEntry
	{
		public uint dstBinding;
		public uint dstArrayElement;
		public uint descriptorCount;
		public VkDescriptorType descriptorType;
		public UIntPtr offset;
		public UIntPtr stride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorUpdateTemplateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint descriptorUpdateEntryCount;
		public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
		public VkDescriptorUpdateTemplateType templateType;
		public VkDescriptorSetLayout descriptorSetLayout;
		public VkPipelineBindPoint pipelineBindPoint;
		public VkPipelineLayout pipelineLayout;
		public uint set;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkXYColorEXT
	{
		public float x;
		public float y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePresentIdFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 presentId;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentIdKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint swapchainCount;
		public ulong* pPresentIds;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePresentWaitFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 presentWait;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkHdrMetadataEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkXYColorEXT displayPrimaryRed;
		public VkXYColorEXT displayPrimaryGreen;
		public VkXYColorEXT displayPrimaryBlue;
		public VkXYColorEXT whitePoint;
		public float maxLuminance;
		public float minLuminance;
		public float maxContentLightLevel;
		public float maxFrameAverageLightLevel;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 localDimmingSupport;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainDisplayNativeHdrCreateInfoAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 localDimmingEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRefreshCycleDurationGOOGLE
	{
		public ulong refreshDuration;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPastPresentationTimingGOOGLE
	{
		public uint presentID;
		public ulong desiredPresentTime;
		public ulong actualPresentTime;
		public ulong earliestPresentTime;
		public ulong presentMargin;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentTimesInfoGOOGLE
	{
		public VkStructureType sType;
		public void* pNext;
		public uint swapchainCount;
		public VkPresentTimeGOOGLE* pTimes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentTimeGOOGLE
	{
		public uint presentID;
		public ulong desiredPresentTime;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkIOSSurfaceCreateInfoMVK
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public void* pView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMacOSSurfaceCreateInfoMVK
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public void* pView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMetalSurfaceCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr pLayer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkViewportWScalingNV
	{
		public float xcoeff;
		public float ycoeff;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 viewportWScalingEnable;
		public uint viewportCount;
		public VkViewportWScalingNV* pViewportWScalings;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkViewportSwizzleNV
	{
		public VkViewportCoordinateSwizzleNV x;
		public VkViewportCoordinateSwizzleNV y;
		public VkViewportCoordinateSwizzleNV z;
		public VkViewportCoordinateSwizzleNV w;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportSwizzleStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint viewportCount;
		public VkViewportSwizzleNV* pViewportSwizzles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxDiscardRectangles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineDiscardRectangleStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkDiscardRectangleModeEXT discardRectangleMode;
		public uint discardRectangleCount;
		public VkRect2D* pDiscardRectangles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 perViewPositionAllComponents;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkInputAttachmentAspectReference
	{
		public uint subpass;
		public uint inputAttachmentIndex;
		public VkImageAspectFlags aspectMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint aspectReferenceCount;
		public VkInputAttachmentAspectReference* pAspectReferences;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSurfaceInfo2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceKHR surface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceCapabilities2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceCapabilitiesKHR surfaceCapabilities;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceFormat2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceFormatKHR surfaceFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayProperties2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayPropertiesKHR displayProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlaneProperties2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayPlanePropertiesKHR displayPlaneProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayModeProperties2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayModePropertiesKHR displayModeProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlaneInfo2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayModeKHR mode;
		public uint planeIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlaneCapabilities2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayPlaneCapabilitiesKHR capabilities;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSharedPresentSurfaceCapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageUsageFlags sharedPresentSupportedUsageFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevice16BitStorageFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 storageBuffer16BitAccess;
		public VkBool32 uniformAndStorageBuffer16BitAccess;
		public VkBool32 storagePushConstant16;
		public VkBool32 storageInputOutput16;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSubgroupProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint subgroupSize;
		public VkShaderStageFlags supportedStages;
		public VkSubgroupFeatureFlags supportedOperations;
		public VkBool32 quadOperationsInAllStages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderSubgroupExtendedTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferMemoryRequirementsInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceBufferMemoryRequirements
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBufferCreateInfo* pCreateInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageMemoryRequirementsInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSparseMemoryRequirementsInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceImageMemoryRequirements
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageCreateInfo* pCreateInfo;
		public VkImageAspectFlags planeAspect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryRequirements2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMemoryRequirements memoryRequirements;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageMemoryRequirements2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSparseImageMemoryRequirements memoryRequirements;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePointClippingProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPointClippingBehavior pointClippingBehavior;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryDedicatedRequirements
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 prefersDedicatedAllocation;
		public VkBool32 requiresDedicatedAllocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryDedicatedAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewUsageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageUsageFlags usage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewSlicedCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint sliceOffset;
		public uint sliceCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineTessellationDomainOriginStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkTessellationDomainOrigin domainOrigin;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerYcbcrConversionInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSamplerYcbcrConversion conversion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerYcbcrConversionCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public VkSamplerYcbcrModelConversion ycbcrModel;
		public VkSamplerYcbcrRange ycbcrRange;
		public VkComponentMapping components;
		public VkChromaLocation xChromaOffset;
		public VkChromaLocation yChromaOffset;
		public VkFilter chromaFilter;
		public VkBool32 forceExplicitReconstruction;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindImagePlaneMemoryInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageAspectFlags planeAspect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImagePlaneMemoryRequirementsInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageAspectFlags planeAspect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 samplerYcbcrConversion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerYcbcrConversionImageFormatProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint combinedImageSamplerDescriptorCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTextureLODGatherFormatPropertiesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 supportsTextureGatherLODBiasAMD;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkConditionalRenderingBeginInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
		public ulong offset;
		public VkConditionalRenderingFlagsEXT flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkProtectedSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 protectedSubmit;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProtectedMemoryFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 protectedMemory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProtectedMemoryProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 protectedNoFault;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceQueueInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceQueueCreateFlags flags;
		public uint queueFamilyIndex;
		public uint queueIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCoverageToColorStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBool32 coverageToColorEnable;
		public uint coverageToColorLocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 filterMinmaxSingleComponentFormats;
		public VkBool32 filterMinmaxImageComponentMapping;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSampleLocationEXT
	{
		public float x;
		public float y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSampleLocationsInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSampleCountFlags sampleLocationsPerPixel;
		public VkExtent2D sampleLocationGridSize;
		public uint sampleLocationsCount;
		public VkSampleLocationEXT* pSampleLocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentSampleLocationsEXT
	{
		public uint attachmentIndex;
		public VkSampleLocationsInfoEXT sampleLocationsInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassSampleLocationsEXT
	{
		public uint subpassIndex;
		public VkSampleLocationsInfoEXT sampleLocationsInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassSampleLocationsBeginInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint attachmentInitialSampleLocationsCount;
		public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
		public uint postSubpassSampleLocationsCount;
		public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineSampleLocationsStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 sampleLocationsEnable;
		public VkSampleLocationsInfoEXT sampleLocationsInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSampleCountFlags sampleLocationSampleCounts;
		public VkExtent2D maxSampleLocationGridSize;
		public float sampleLocationCoordinateRange_0;
		public float sampleLocationCoordinateRange_1;
		public uint sampleLocationSubPixelBits;
		public VkBool32 variableSampleLocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMultisamplePropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D maxSampleLocationGridSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerReductionModeCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSamplerReductionMode reductionMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 advancedBlendCoherentOperations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiDrawFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 multiDraw;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint advancedBlendMaxColorAttachments;
		public VkBool32 advancedBlendIndependentBlend;
		public VkBool32 advancedBlendNonPremultipliedSrcColor;
		public VkBool32 advancedBlendNonPremultipliedDstColor;
		public VkBool32 advancedBlendCorrelatedOverlap;
		public VkBool32 advancedBlendAllOperations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 srcPremultiplied;
		public VkBool32 dstPremultiplied;
		public VkBlendOverlapEXT blendOverlap;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceInlineUniformBlockFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 inlineUniformBlock;
		public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceInlineUniformBlockProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxInlineUniformBlockSize;
		public uint maxPerStageDescriptorInlineUniformBlocks;
		public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
		public uint maxDescriptorSetInlineUniformBlocks;
		public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWriteDescriptorSetInlineUniformBlock
	{
		public VkStructureType sType;
		public void* pNext;
		public uint dataSize;
		public void* pData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorPoolInlineUniformBlockCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxInlineUniformBlockBindings;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkCoverageModulationModeNV coverageModulationMode;
		public VkBool32 coverageModulationTableEnable;
		public uint coverageModulationTableCount;
		public float* pCoverageModulationTable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageFormatListCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint viewFormatCount;
		public VkFormat* pViewFormats;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkValidationCacheCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public UIntPtr initialDataSize;
		public void* pInitialData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderModuleValidationCacheCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkValidationCacheEXT validationCache;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance3Properties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxPerSetDescriptors;
		public ulong maxMemoryAllocationSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance4Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 maintenance4;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance4Properties
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong maxBufferSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance5FeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 maintenance5;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance5PropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 earlyFragmentMultisampleCoverageAfterSampleCounting;
		public VkBool32 earlyFragmentSampleMaskTestBeforeSampleCounting;
		public VkBool32 depthStencilSwizzleOneSupport;
		public VkBool32 polygonModePointSize;
		public VkBool32 nonStrictSinglePixelWideLinesUseParallelogram;
		public VkBool32 nonStrictWideLinesUseParallelogram;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance6FeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 maintenance6;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance6PropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 blockTexelViewCompatibleMultipleLayers;
		public uint maxCombinedImageSamplerDescriptorCount;
		public VkBool32 fragmentShadingRateClampCombinerInputs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance7FeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 maintenance7;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance7PropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 robustFragmentShadingRateAttachmentAccess;
		public VkBool32 separateDepthStencilAttachmentAccess;
		public uint maxDescriptorSetTotalUniformBuffersDynamic;
		public uint maxDescriptorSetTotalStorageBuffersDynamic;
		public uint maxDescriptorSetTotalBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLayeredApiPropertiesListKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint layeredApiCount;
		public VkPhysicalDeviceLayeredApiPropertiesKHR* pLayeredApis;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLayeredApiPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint vendorID;
		public uint deviceID;
		public VkPhysicalDeviceLayeredApiKHR layeredAPI;
		public fixed byte deviceName[(int)VulkanNative.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLayeredApiVulkanPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPhysicalDeviceProperties2 properties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderingAreaInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint viewMask;
		public uint colorAttachmentCount;
		public VkFormat* pColorAttachmentFormats;
		public VkFormat depthAttachmentFormat;
		public VkFormat stencilAttachmentFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetLayoutSupport
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 supported;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderDrawParametersFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderDrawParameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderFloat16Int8Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderFloat16;
		public VkBool32 shaderInt8;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFloatControlsProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderFloatControlsIndependence denormBehaviorIndependence;
		public VkShaderFloatControlsIndependence roundingModeIndependence;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
		public VkBool32 shaderDenormPreserveFloat16;
		public VkBool32 shaderDenormPreserveFloat32;
		public VkBool32 shaderDenormPreserveFloat64;
		public VkBool32 shaderDenormFlushToZeroFloat16;
		public VkBool32 shaderDenormFlushToZeroFloat32;
		public VkBool32 shaderDenormFlushToZeroFloat64;
		public VkBool32 shaderRoundingModeRTEFloat16;
		public VkBool32 shaderRoundingModeRTEFloat32;
		public VkBool32 shaderRoundingModeRTEFloat64;
		public VkBool32 shaderRoundingModeRTZFloat16;
		public VkBool32 shaderRoundingModeRTZFloat32;
		public VkBool32 shaderRoundingModeRTZFloat64;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceHostQueryResetFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 hostQueryReset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkNativeBufferUsage2ANDROID
	{
		public ulong consumer;
		public ulong producer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkNativeBufferANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public void* handle;
		public int stride;
		public int format;
		public int usage;
		public VkNativeBufferUsage2ANDROID usage2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainImageCreateInfoANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainImageUsageFlagsANDROID usage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePresentationPropertiesANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 sharedImage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderResourceUsageAMD
	{
		public uint numUsedVgprs;
		public uint numUsedSgprs;
		public uint ldsSizePerLocalWorkGroup;
		public UIntPtr ldsUsageSizeInBytes;
		public UIntPtr scratchMemUsageInBytes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderStatisticsInfoAMD
	{
		public VkShaderStageFlags shaderStageMask;
		public VkShaderResourceUsageAMD resourceUsage;
		public uint numPhysicalVgprs;
		public uint numPhysicalSgprs;
		public uint numAvailableVgprs;
		public uint numAvailableSgprs;
		public uint computeWorkGroupSize_0;
		public uint computeWorkGroupSize_1;
		public uint computeWorkGroupSize_2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkQueueGlobalPriorityKHR globalPriority;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 globalPriorityQuery;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyGlobalPriorityPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint priorityCount;
		public VkQueueGlobalPriorityKHR priorities_0;
		public VkQueueGlobalPriorityKHR priorities_1;
		public VkQueueGlobalPriorityKHR priorities_2;
		public VkQueueGlobalPriorityKHR priorities_3;
		public VkQueueGlobalPriorityKHR priorities_4;
		public VkQueueGlobalPriorityKHR priorities_5;
		public VkQueueGlobalPriorityKHR priorities_6;
		public VkQueueGlobalPriorityKHR priorities_7;
		public VkQueueGlobalPriorityKHR priorities_8;
		public VkQueueGlobalPriorityKHR priorities_9;
		public VkQueueGlobalPriorityKHR priorities_10;
		public VkQueueGlobalPriorityKHR priorities_11;
		public VkQueueGlobalPriorityKHR priorities_12;
		public VkQueueGlobalPriorityKHR priorities_13;
		public VkQueueGlobalPriorityKHR priorities_14;
		public VkQueueGlobalPriorityKHR priorities_15;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsObjectNameInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkObjectType objectType;
		public ulong objectHandle;
		public byte* pObjectName;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsObjectTagInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkObjectType objectType;
		public ulong objectHandle;
		public ulong tagName;
		public UIntPtr tagSize;
		public void* pTag;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsLabelEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* pLabelName;
		public float color_0;
		public float color_1;
		public float color_2;
		public float color_3;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
		public VkDebugUtilsMessageTypeFlagsEXT messageType;
		public IntPtr pfnUserCallback;
		public void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public byte* pMessageIdName;
		public int messageIdNumber;
		public byte* pMessage;
		public uint queueLabelCount;
		public VkDebugUtilsLabelEXT* pQueueLabels;
		public uint cmdBufLabelCount;
		public VkDebugUtilsLabelEXT* pCmdBufLabels;
		public uint objectCount;
		public VkDebugUtilsObjectNameInfoEXT* pObjects;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 deviceMemoryReport;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceDeviceMemoryReportCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr pfnUserCallback;
		public void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceMemoryReportCallbackDataEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkDeviceMemoryReportEventTypeEXT type;
		public ulong memoryObjectId;
		public ulong size;
		public VkObjectType objectType;
		public ulong objectHandle;
		public uint heapIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryHostPointerInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlags handleType;
		public void* pHostPointer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryHostPointerPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong minImportedHostPointerAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public float primitiveOverestimationSize;
		public float maxExtraPrimitiveOverestimationSize;
		public float extraPrimitiveOverestimationSizeGranularity;
		public VkBool32 primitiveUnderestimation;
		public VkBool32 conservativePointAndLineRasterization;
		public VkBool32 degenerateTrianglesRasterized;
		public VkBool32 degenerateLinesRasterized;
		public VkBool32 fullyCoveredFragmentShaderInputVariable;
		public VkBool32 conservativeRasterizationPostDepthCoverage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCalibratedTimestampInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkTimeDomainKHR timeDomain;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public uint shaderEngineCount;
		public uint shaderArraysPerEngineCount;
		public uint computeUnitsPerShaderArray;
		public uint simdPerComputeUnit;
		public uint wavefrontsPerSimd;
		public uint wavefrontSize;
		public uint sgprsPerSimd;
		public uint minSgprAllocation;
		public uint maxSgprAllocation;
		public uint sgprAllocationGranularity;
		public uint vgprsPerSimd;
		public uint minVgprAllocation;
		public uint maxVgprAllocation;
		public uint vgprAllocationGranularity;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderCoreProperties2AMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
		public uint activeComputeUnitCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationConservativeStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
		public float extraPrimitiveOverestimationSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
		public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
		public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
		public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
		public VkBool32 shaderSampledImageArrayNonUniformIndexing;
		public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
		public VkBool32 shaderStorageImageArrayNonUniformIndexing;
		public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
		public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
		public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
		public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
		public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
		public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
		public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
		public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
		public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
		public VkBool32 descriptorBindingUpdateUnusedWhilePending;
		public VkBool32 descriptorBindingPartiallyBound;
		public VkBool32 descriptorBindingVariableDescriptorCount;
		public VkBool32 runtimeDescriptorArray;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDescriptorIndexingProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxUpdateAfterBindDescriptorsInAllPools;
		public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
		public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
		public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
		public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
		public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
		public VkBool32 robustBufferAccessUpdateAfterBind;
		public VkBool32 quadDivergentImplicitLod;
		public uint maxPerStageDescriptorUpdateAfterBindSamplers;
		public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
		public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
		public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
		public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
		public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
		public uint maxPerStageUpdateAfterBindResources;
		public uint maxDescriptorSetUpdateAfterBindSamplers;
		public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
		public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
		public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindSampledImages;
		public uint maxDescriptorSetUpdateAfterBindStorageImages;
		public uint maxDescriptorSetUpdateAfterBindInputAttachments;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint bindingCount;
		public VkDescriptorBindingFlags* pBindingFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint descriptorSetCount;
		public uint* pDescriptorCounts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupport
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxVariableDescriptorCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentDescription2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAttachmentDescriptionFlags flags;
		public VkFormat format;
		public VkSampleCountFlags samples;
		public VkAttachmentLoadOp loadOp;
		public VkAttachmentStoreOp storeOp;
		public VkAttachmentLoadOp stencilLoadOp;
		public VkAttachmentStoreOp stencilStoreOp;
		public VkImageLayout initialLayout;
		public VkImageLayout finalLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentReference2
	{
		public VkStructureType sType;
		public void* pNext;
		public uint attachment;
		public VkImageLayout layout;
		public VkImageAspectFlags aspectMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDescription2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSubpassDescriptionFlags flags;
		public VkPipelineBindPoint pipelineBindPoint;
		public uint viewMask;
		public uint inputAttachmentCount;
		public VkAttachmentReference2* pInputAttachments;
		public uint colorAttachmentCount;
		public VkAttachmentReference2* pColorAttachments;
		public VkAttachmentReference2* pResolveAttachments;
		public VkAttachmentReference2* pDepthStencilAttachment;
		public uint preserveAttachmentCount;
		public uint* pPreserveAttachments;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDependency2
	{
		public VkStructureType sType;
		public void* pNext;
		public uint srcSubpass;
		public uint dstSubpass;
		public VkPipelineStageFlags srcStageMask;
		public VkPipelineStageFlags dstStageMask;
		public VkAccessFlags srcAccessMask;
		public VkAccessFlags dstAccessMask;
		public VkDependencyFlags dependencyFlags;
		public int viewOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassCreateInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPassCreateFlags flags;
		public uint attachmentCount;
		public VkAttachmentDescription2* pAttachments;
		public uint subpassCount;
		public VkSubpassDescription2* pSubpasses;
		public uint dependencyCount;
		public VkSubpassDependency2* pDependencies;
		public uint correlatedViewMaskCount;
		public uint* pCorrelatedViewMasks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSubpassContents contents;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassEndInfo
	{
		public VkStructureType sType;
		public void* pNext;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 timelineSemaphore;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong maxTimelineSemaphoreValueDifference;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreTypeCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphoreType semaphoreType;
		public ulong initialValue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTimelineSemaphoreSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreValueCount;
		public ulong* pWaitSemaphoreValues;
		public uint signalSemaphoreValueCount;
		public ulong* pSignalSemaphoreValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreWaitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphoreWaitFlags flags;
		public uint semaphoreCount;
		public VkSemaphore* pSemaphores;
		public ulong* pValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreSignalInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public ulong value;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVertexInputBindingDivisorDescriptionKHR
	{
		public uint binding;
		public uint divisor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint vertexBindingDivisorCount;
		public VkVertexInputBindingDivisorDescriptionKHR* pVertexBindingDivisors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxVertexAttribDivisor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxVertexAttribDivisor;
		public VkBool32 supportsNonZeroFirstInstance;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePCIBusInfoPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint pciDomain;
		public uint pciBus;
		public uint pciDevice;
		public uint pciFunction;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportAndroidHardwareBufferInfoANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidHardwareBufferUsageANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong androidHardwareBufferUsage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidHardwareBufferPropertiesANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong allocationSize;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryGetAndroidHardwareBufferInfoANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidHardwareBufferFormatPropertiesANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public ulong externalFormat;
		public VkFormatFeatureFlags formatFeatures;
		public VkComponentMapping samplerYcbcrConversionComponents;
		public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
		public VkSamplerYcbcrRange suggestedYcbcrRange;
		public VkChromaLocation suggestedXChromaOffset;
		public VkChromaLocation suggestedYChromaOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 conditionalRenderingEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalFormatANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong externalFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevice8BitStorageFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 storageBuffer8BitAccess;
		public VkBool32 uniformAndStorageBuffer8BitAccess;
		public VkBool32 storagePushConstant8;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 conditionalRendering;
		public VkBool32 inheritedConditionalRendering;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 vulkanMemoryModel;
		public VkBool32 vulkanMemoryModelDeviceScope;
		public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderBufferInt64Atomics;
		public VkBool32 shaderSharedInt64Atomics;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderBufferFloat32Atomics;
		public VkBool32 shaderBufferFloat32AtomicAdd;
		public VkBool32 shaderBufferFloat64Atomics;
		public VkBool32 shaderBufferFloat64AtomicAdd;
		public VkBool32 shaderSharedFloat32Atomics;
		public VkBool32 shaderSharedFloat32AtomicAdd;
		public VkBool32 shaderSharedFloat64Atomics;
		public VkBool32 shaderSharedFloat64AtomicAdd;
		public VkBool32 shaderImageFloat32Atomics;
		public VkBool32 shaderImageFloat32AtomicAdd;
		public VkBool32 sparseImageFloat32Atomics;
		public VkBool32 sparseImageFloat32AtomicAdd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderBufferFloat16Atomics;
		public VkBool32 shaderBufferFloat16AtomicAdd;
		public VkBool32 shaderBufferFloat16AtomicMinMax;
		public VkBool32 shaderBufferFloat32AtomicMinMax;
		public VkBool32 shaderBufferFloat64AtomicMinMax;
		public VkBool32 shaderSharedFloat16Atomics;
		public VkBool32 shaderSharedFloat16AtomicAdd;
		public VkBool32 shaderSharedFloat16AtomicMinMax;
		public VkBool32 shaderSharedFloat32AtomicMinMax;
		public VkBool32 shaderSharedFloat64AtomicMinMax;
		public VkBool32 shaderImageFloat32AtomicMinMax;
		public VkBool32 sparseImageFloat32AtomicMinMax;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 vertexAttributeInstanceRateDivisor;
		public VkBool32 vertexAttributeInstanceRateZeroDivisor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyCheckpointPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineStageFlags checkpointExecutionStageMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCheckpointDataNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineStageFlags stage;
		public void* pCheckpointMarker;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDepthStencilResolveProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkResolveModeFlags supportedDepthResolveModes;
		public VkResolveModeFlags supportedStencilResolveModes;
		public VkBool32 independentResolveNone;
		public VkBool32 independentResolve;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDescriptionDepthStencilResolve
	{
		public VkStructureType sType;
		public void* pNext;
		public VkResolveModeFlags depthResolveMode;
		public VkResolveModeFlags stencilResolveMode;
		public VkAttachmentReference2* pDepthStencilResolveAttachment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewASTCDecodeModeEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat decodeMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceASTCDecodeFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 decodeModeSharedExponent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 transformFeedback;
		public VkBool32 geometryStreams;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxTransformFeedbackStreams;
		public uint maxTransformFeedbackBuffers;
		public ulong maxTransformFeedbackBufferSize;
		public uint maxTransformFeedbackStreamDataSize;
		public uint maxTransformFeedbackBufferDataSize;
		public uint maxTransformFeedbackBufferDataStride;
		public VkBool32 transformFeedbackQueries;
		public VkBool32 transformFeedbackStreamsLinesTriangles;
		public VkBool32 transformFeedbackRasterizationStreamSelect;
		public VkBool32 transformFeedbackDraw;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationStateStreamCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint rasterizationStream;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 representativeFragmentTest;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 representativeFragmentTestEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExclusiveScissorFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 exclusiveScissor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint exclusiveScissorCount;
		public VkRect2D* pExclusiveScissors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCornerSampledImageFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 cornerSampledImage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 computeDerivativeGroupQuads;
		public VkBool32 computeDerivativeGroupLinear;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 imageFootprint;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dedicatedAllocationImageAliasing;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCopyMemoryIndirectFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 indirectCopy;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCopyMemoryIndirectPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkQueueFlags supportedQueues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryDecompressionFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 memoryDecompression;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong decompressionMethods;
		public ulong maxDecompressionIndirectCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShadingRatePaletteNV
	{
		public uint shadingRatePaletteEntryCount;
		public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportShadingRateImageStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shadingRateImageEnable;
		public uint viewportCount;
		public VkShadingRatePaletteNV* pShadingRatePalettes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShadingRateImageFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shadingRateImage;
		public VkBool32 shadingRateCoarseSampleOrder;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShadingRateImagePropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D shadingRateTexelSize;
		public uint shadingRatePaletteSize;
		public uint shadingRateMaxCoarseSamples;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 invocationMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCoarseSampleLocationNV
	{
		public uint pixelX;
		public uint pixelY;
		public uint sample;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCoarseSampleOrderCustomNV
	{
		public VkShadingRatePaletteEntryNV shadingRate;
		public uint sampleCount;
		public uint sampleLocationCount;
		public VkCoarseSampleLocationNV* pSampleLocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCoarseSampleOrderTypeNV sampleOrderType;
		public uint customSampleOrderCount;
		public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 taskShader;
		public VkBool32 meshShader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxDrawMeshTasksCount;
		public uint maxTaskWorkGroupInvocations;
		public uint maxTaskWorkGroupSize_0;
		public uint maxTaskWorkGroupSize_1;
		public uint maxTaskWorkGroupSize_2;
		public uint maxTaskTotalMemorySize;
		public uint maxTaskOutputCount;
		public uint maxMeshWorkGroupInvocations;
		public uint maxMeshWorkGroupSize_0;
		public uint maxMeshWorkGroupSize_1;
		public uint maxMeshWorkGroupSize_2;
		public uint maxMeshTotalMemorySize;
		public uint maxMeshOutputVertices;
		public uint maxMeshOutputPrimitives;
		public uint maxMeshMultiviewViewCount;
		public uint meshOutputPerVertexGranularity;
		public uint meshOutputPerPrimitiveGranularity;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrawMeshTasksIndirectCommandNV
	{
		public uint taskCount;
		public uint firstTask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 taskShader;
		public VkBool32 meshShader;
		public VkBool32 multiviewMeshShader;
		public VkBool32 primitiveFragmentShadingRateMeshShader;
		public VkBool32 meshShaderQueries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxTaskWorkGroupTotalCount;
		public uint maxTaskWorkGroupCount_0;
		public uint maxTaskWorkGroupCount_1;
		public uint maxTaskWorkGroupCount_2;
		public uint maxTaskWorkGroupInvocations;
		public uint maxTaskWorkGroupSize_0;
		public uint maxTaskWorkGroupSize_1;
		public uint maxTaskWorkGroupSize_2;
		public uint maxTaskPayloadSize;
		public uint maxTaskSharedMemorySize;
		public uint maxTaskPayloadAndSharedMemorySize;
		public uint maxMeshWorkGroupTotalCount;
		public uint maxMeshWorkGroupCount_0;
		public uint maxMeshWorkGroupCount_1;
		public uint maxMeshWorkGroupCount_2;
		public uint maxMeshWorkGroupInvocations;
		public uint maxMeshWorkGroupSize_0;
		public uint maxMeshWorkGroupSize_1;
		public uint maxMeshWorkGroupSize_2;
		public uint maxMeshSharedMemorySize;
		public uint maxMeshPayloadAndSharedMemorySize;
		public uint maxMeshOutputMemorySize;
		public uint maxMeshPayloadAndOutputMemorySize;
		public uint maxMeshOutputComponents;
		public uint maxMeshOutputVertices;
		public uint maxMeshOutputPrimitives;
		public uint maxMeshOutputLayers;
		public uint maxMeshMultiviewViewCount;
		public uint meshOutputPerVertexGranularity;
		public uint meshOutputPerPrimitiveGranularity;
		public uint maxPreferredTaskWorkGroupInvocations;
		public uint maxPreferredMeshWorkGroupInvocations;
		public VkBool32 prefersLocalInvocationVertexOutput;
		public VkBool32 prefersLocalInvocationPrimitiveOutput;
		public VkBool32 prefersCompactVertexOutput;
		public VkBool32 prefersCompactPrimitiveOutput;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrawMeshTasksIndirectCommandEXT
	{
		public uint groupCountX;
		public uint groupCountY;
		public uint groupCountZ;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingShaderGroupCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRayTracingShaderGroupTypeKHR type;
		public uint generalShader;
		public uint closestHitShader;
		public uint anyHitShader;
		public uint intersectionShader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingShaderGroupCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRayTracingShaderGroupTypeKHR type;
		public uint generalShader;
		public uint closestHitShader;
		public uint anyHitShader;
		public uint intersectionShader;
		public void* pShaderGroupCaptureReplayHandle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingPipelineCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreateFlags flags;
		public uint stageCount;
		public VkPipelineShaderStageCreateInfo* pStages;
		public uint groupCount;
		public VkRayTracingShaderGroupCreateInfoNV* pGroups;
		public uint maxRecursionDepth;
		public VkPipelineLayout layout;
		public VkPipeline basePipelineHandle;
		public int basePipelineIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingPipelineCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreateFlags flags;
		public uint stageCount;
		public VkPipelineShaderStageCreateInfo* pStages;
		public uint groupCount;
		public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
		public uint maxPipelineRayRecursionDepth;
		public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
		public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
		public VkPipelineDynamicStateCreateInfo* pDynamicState;
		public VkPipelineLayout layout;
		public VkPipeline basePipelineHandle;
		public int basePipelineIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeometryTrianglesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer vertexData;
		public ulong vertexOffset;
		public uint vertexCount;
		public ulong vertexStride;
		public VkFormat vertexFormat;
		public VkBuffer indexData;
		public ulong indexOffset;
		public uint indexCount;
		public VkIndexType indexType;
		public VkBuffer transformData;
		public ulong transformOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeometryAABBNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer aabbData;
		public uint numAABBs;
		public uint stride;
		public ulong offset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeometryDataNV
	{
		public VkGeometryTrianglesNV triangles;
		public VkGeometryAABBNV aabbs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeometryNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkGeometryTypeKHR geometryType;
		public VkGeometryDataNV geometry;
		public VkGeometryFlagsKHR flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureTypeKHR type;
		public VkBuildAccelerationStructureFlagsKHR flags;
		public uint instanceCount;
		public uint geometryCount;
		public VkGeometryNV* pGeometries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong compactedSize;
		public VkAccelerationStructureInfoNV info;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindAccelerationStructureMemoryInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureNV accelerationStructure;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
		public uint deviceIndexCount;
		public uint* pDeviceIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWriteDescriptorSetAccelerationStructureKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint accelerationStructureCount;
		public VkAccelerationStructureKHR* pAccelerationStructures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWriteDescriptorSetAccelerationStructureNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint accelerationStructureCount;
		public VkAccelerationStructureNV* pAccelerationStructures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureMemoryRequirementsInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureMemoryRequirementsTypeNV type;
		public VkAccelerationStructureNV accelerationStructure;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 accelerationStructure;
		public VkBool32 accelerationStructureCaptureReplay;
		public VkBool32 accelerationStructureIndirectBuild;
		public VkBool32 accelerationStructureHostCommands;
		public VkBool32 descriptorBindingAccelerationStructureUpdateAfterBind;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rayTracingPipeline;
		public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplay;
		public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
		public VkBool32 rayTracingPipelineTraceRaysIndirect;
		public VkBool32 rayTraversalPrimitiveCulling;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayQueryFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rayQuery;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong maxGeometryCount;
		public ulong maxInstanceCount;
		public ulong maxPrimitiveCount;
		public uint maxPerStageDescriptorAccelerationStructures;
		public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
		public uint maxDescriptorSetAccelerationStructures;
		public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;
		public uint minAccelerationStructureScratchOffsetAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint shaderGroupHandleSize;
		public uint maxRayRecursionDepth;
		public uint maxShaderGroupStride;
		public uint shaderGroupBaseAlignment;
		public uint shaderGroupHandleCaptureReplaySize;
		public uint maxRayDispatchInvocationCount;
		public uint shaderGroupHandleAlignment;
		public uint maxRayHitAttributeSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint shaderGroupHandleSize;
		public uint maxRecursionDepth;
		public uint maxShaderGroupStride;
		public uint shaderGroupBaseAlignment;
		public ulong maxGeometryCount;
		public ulong maxInstanceCount;
		public ulong maxTriangleCount;
		public uint maxDescriptorSetAccelerationStructures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkStridedDeviceAddressRegionKHR
	{
		public ulong deviceAddress;
		public ulong stride;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTraceRaysIndirectCommandKHR
	{
		public uint width;
		public uint height;
		public uint depth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTraceRaysIndirectCommand2KHR
	{
		public ulong raygenShaderRecordAddress;
		public ulong raygenShaderRecordSize;
		public ulong missShaderBindingTableAddress;
		public ulong missShaderBindingTableSize;
		public ulong missShaderBindingTableStride;
		public ulong hitShaderBindingTableAddress;
		public ulong hitShaderBindingTableSize;
		public ulong hitShaderBindingTableStride;
		public ulong callableShaderBindingTableAddress;
		public ulong callableShaderBindingTableSize;
		public ulong callableShaderBindingTableStride;
		public uint width;
		public uint height;
		public uint depth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rayTracingMaintenance1;
		public VkBool32 rayTracingPipelineTraceRaysIndirect2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrmFormatModifierPropertiesListEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint drmFormatModifierCount;
		public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrmFormatModifierPropertiesEXT
	{
		public ulong drmFormatModifier;
		public uint drmFormatModifierPlaneCount;
		public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong drmFormatModifier;
		public VkSharingMode sharingMode;
		public uint queueFamilyIndexCount;
		public uint* pQueueFamilyIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageDrmFormatModifierListCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint drmFormatModifierCount;
		public ulong* pDrmFormatModifiers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageDrmFormatModifierExplicitCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong drmFormatModifier;
		public uint drmFormatModifierPlaneCount;
		public VkSubresourceLayout* pPlaneLayouts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageDrmFormatModifierPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong drmFormatModifier;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageStencilUsageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageUsageFlags stencilUsage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceMemoryOverallocationCreateInfoAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fragmentDensityMap;
		public VkBool32 fragmentDensityMapDynamic;
		public VkBool32 fragmentDensityMapNonSubsampledImages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fragmentDensityMapDeferred;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fragmentDensityMapOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D minFragmentDensityTexelSize;
		public VkExtent2D maxFragmentDensityTexelSize;
		public VkBool32 fragmentDensityInvocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 subsampledLoads;
		public VkBool32 subsampledCoarseReconstructionEarlyAccess;
		public uint maxSubsampledArrayLayers;
		public uint maxDescriptorSetSubsampledSamplers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D fragmentDensityOffsetGranularity;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassFragmentDensityMapCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAttachmentReference fragmentDensityMapAttachment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public uint fragmentDensityOffsetCount;
		public VkOffset2D* pFragmentDensityOffsets;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceScalarBlockLayoutFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 scalarBlockLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceProtectedCapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 supportsProtected;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 uniformBufferStandardLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 depthClipEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBool32 depthClipEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed ulong heapBudget[(int)VulkanNative.VK_MAX_MEMORY_HEAPS];
		public fixed ulong heapUsage[(int)VulkanNative.VK_MAX_MEMORY_HEAPS];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 memoryPriority;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryPriorityAllocateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public float priority;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pageableDeviceLocalMemory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 bufferDeviceAddress;
		public VkBool32 bufferDeviceAddressCaptureReplay;
		public VkBool32 bufferDeviceAddressMultiDevice;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 bufferDeviceAddress;
		public VkBool32 bufferDeviceAddressCaptureReplay;
		public VkBool32 bufferDeviceAddressMultiDevice;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferDeviceAddressInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferOpaqueCaptureAddressCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong opaqueCaptureAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferDeviceAddressCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong deviceAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageViewImageFormatInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageViewType imageViewType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFilterCubicImageViewImageFormatPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 filterCubic;
		public VkBool32 filterCubicMinmax;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImagelessFramebufferFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 imagelessFramebuffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFramebufferAttachmentsCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint attachmentImageInfoCount;
		public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFramebufferAttachmentImageInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageCreateFlags flags;
		public VkImageUsageFlags usage;
		public uint width;
		public uint height;
		public uint layerCount;
		public uint viewFormatCount;
		public VkFormat* pViewFormats;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassAttachmentBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint attachmentCount;
		public VkImageView* pAttachments;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 textureCompressionASTC_HDR;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 cooperativeMatrix;
		public VkBool32 cooperativeMatrixRobustBufferAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderStageFlags cooperativeMatrixSupportedStages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCooperativeMatrixPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint MSize;
		public uint NSize;
		public uint KSize;
		public VkComponentTypeKHR AType;
		public VkComponentTypeKHR BType;
		public VkComponentTypeKHR CType;
		public VkComponentTypeKHR DType;
		public VkScopeKHR scope;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 ycbcrImageArrays;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewHandleInfoNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageView imageView;
		public VkDescriptorType descriptorType;
		public VkSampler sampler;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewAddressPropertiesNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong deviceAddress;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentFrameTokenGGP
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr frameToken;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCreationFeedback
	{
		public VkPipelineCreationFeedbackFlags flags;
		public ulong duration;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCreationFeedbackCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreationFeedback* pPipelineCreationFeedback;
		public uint pipelineStageCreationFeedbackCount;
		public VkPipelineCreationFeedback* pPipelineStageCreationFeedbacks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceFullScreenExclusiveInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFullScreenExclusiveEXT fullScreenExclusive;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceFullScreenExclusiveWin32InfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr hmonitor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fullScreenExclusiveSupported;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePresentBarrierFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 presentBarrier;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceCapabilitiesPresentBarrierNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 presentBarrierSupported;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainPresentBarrierCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 presentBarrierEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePerformanceQueryFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 performanceCounterQueryPools;
		public VkBool32 performanceCounterMultipleQueryPools;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePerformanceQueryPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 allowCommandBufferQueryCopies;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceCounterKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPerformanceCounterUnitKHR unit;
		public VkPerformanceCounterScopeKHR scope;
		public VkPerformanceCounterStorageKHR storage;
		public fixed byte uuid[(int)VulkanNative.VK_UUID_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceCounterDescriptionKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPerformanceCounterDescriptionFlagsKHR flags;
		public fixed byte name[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte category[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte description[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueryPoolPerformanceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint queueFamilyIndex;
		public uint counterIndexCount;
		public uint* pCounterIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAcquireProfilingLockInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAcquireProfilingLockFlagsKHR flags;
		public ulong timeout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceQuerySubmitInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint counterPassIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceQueryReservationInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxPerformanceQueriesPerPool;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkHeadlessSurfaceCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 coverageReductionMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCoverageReductionStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkCoverageReductionModeNV coverageReductionMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFramebufferMixedSamplesCombinationNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCoverageReductionModeNV coverageReductionMode;
		public VkSampleCountFlags rasterizationSamples;
		public VkSampleCountFlags depthStencilSamples;
		public VkSampleCountFlags colorSamples;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderIntegerFunctions2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceValueINTEL
	{
		public VkPerformanceValueTypeINTEL type;
		public VkPerformanceValueDataINTEL data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkInitializePerformanceApiInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueryPoolPerformanceQueryCreateInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceMarkerInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong marker;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceStreamMarkerInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public uint marker;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceOverrideInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPerformanceOverrideTypeINTEL type;
		public VkBool32 enable;
		public ulong parameter;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceConfigurationAcquireInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPerformanceConfigurationTypeINTEL type;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderClockFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderSubgroupClock;
		public VkBool32 shaderDeviceClock;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceIndexTypeUint8FeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 indexTypeUint8;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint shaderSMCount;
		public uint shaderWarpsPerSM;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderSMBuiltins;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fragmentShaderSampleInterlock;
		public VkBool32 fragmentShaderPixelInterlock;
		public VkBool32 fragmentShaderShadingRateInterlock;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 separateDepthStencilLayouts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentReferenceStencilLayout
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageLayout stencilLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 primitiveTopologyListRestart;
		public VkBool32 primitiveTopologyPatchListRestart;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentDescriptionStencilLayout
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageLayout stencilInitialLayout;
		public VkImageLayout stencilFinalLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pipelineExecutableInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipeline pipeline;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineExecutablePropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderStageFlags stages;
		public fixed byte name[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte description[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public uint subgroupSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineExecutableInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipeline pipeline;
		public uint executableIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineExecutableStatisticKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte name[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte description[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public VkPipelineExecutableStatisticFormatKHR format;
		public VkPipelineExecutableStatisticValueKHR value;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineExecutableInternalRepresentationKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte name[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte description[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public VkBool32 isText;
		public UIntPtr dataSize;
		public void* pData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderDemoteToHelperInvocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 texelBufferAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong storageTexelBufferOffsetAlignmentBytes;
		public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
		public ulong uniformTexelBufferOffsetAlignmentBytes;
		public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 subgroupSizeControl;
		public VkBool32 computeFullSubgroups;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint minSubgroupSize;
		public uint maxSubgroupSize;
		public uint maxComputeWorkgroupSubgroups;
		public VkShaderStageFlags requiredSubgroupSizeStages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint requiredSubgroupSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassShadingPipelineCreateInfoHUAWEI
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPass renderPass;
		public uint subpass;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxSubpassShadingWorkgroupSizeAspectRatio;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxWorkGroupCount_0;
		public uint maxWorkGroupCount_1;
		public uint maxWorkGroupCount_2;
		public uint maxWorkGroupSize_0;
		public uint maxWorkGroupSize_1;
		public uint maxWorkGroupSize_2;
		public uint maxOutputClusterCount;
		public ulong indirectBufferOffsetAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryOpaqueCaptureAddressAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong opaqueCaptureAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceMemoryOpaqueCaptureAddressInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLineRasterizationFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rectangularLines;
		public VkBool32 bresenhamLines;
		public VkBool32 smoothLines;
		public VkBool32 stippledRectangularLines;
		public VkBool32 stippledBresenhamLines;
		public VkBool32 stippledSmoothLines;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLineRasterizationPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint lineSubPixelPrecisionBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationLineStateCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkLineRasterizationModeKHR lineRasterizationMode;
		public VkBool32 stippledLineEnable;
		public uint lineStippleFactor;
		public ushort lineStipplePattern;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePipelineCreationCacheControlFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pipelineCreationCacheControl;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan11Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 storageBuffer16BitAccess;
		public VkBool32 uniformAndStorageBuffer16BitAccess;
		public VkBool32 storagePushConstant16;
		public VkBool32 storageInputOutput16;
		public VkBool32 multiview;
		public VkBool32 multiviewGeometryShader;
		public VkBool32 multiviewTessellationShader;
		public VkBool32 variablePointersStorageBuffer;
		public VkBool32 variablePointers;
		public VkBool32 protectedMemory;
		public VkBool32 samplerYcbcrConversion;
		public VkBool32 shaderDrawParameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan11Properties
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte deviceUUID[(int)VulkanNative.VK_UUID_SIZE];
		public fixed byte driverUUID[(int)VulkanNative.VK_UUID_SIZE];
		public fixed byte deviceLUID[(int)VulkanNative.VK_LUID_SIZE];
		public uint deviceNodeMask;
		public VkBool32 deviceLUIDValid;
		public uint subgroupSize;
		public VkShaderStageFlags subgroupSupportedStages;
		public VkSubgroupFeatureFlags subgroupSupportedOperations;
		public VkBool32 subgroupQuadOperationsInAllStages;
		public VkPointClippingBehavior pointClippingBehavior;
		public uint maxMultiviewViewCount;
		public uint maxMultiviewInstanceIndex;
		public VkBool32 protectedNoFault;
		public uint maxPerSetDescriptors;
		public ulong maxMemoryAllocationSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan12Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 samplerMirrorClampToEdge;
		public VkBool32 drawIndirectCount;
		public VkBool32 storageBuffer8BitAccess;
		public VkBool32 uniformAndStorageBuffer8BitAccess;
		public VkBool32 storagePushConstant8;
		public VkBool32 shaderBufferInt64Atomics;
		public VkBool32 shaderSharedInt64Atomics;
		public VkBool32 shaderFloat16;
		public VkBool32 shaderInt8;
		public VkBool32 descriptorIndexing;
		public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
		public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
		public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
		public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
		public VkBool32 shaderSampledImageArrayNonUniformIndexing;
		public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
		public VkBool32 shaderStorageImageArrayNonUniformIndexing;
		public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
		public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
		public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
		public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
		public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
		public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
		public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
		public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
		public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
		public VkBool32 descriptorBindingUpdateUnusedWhilePending;
		public VkBool32 descriptorBindingPartiallyBound;
		public VkBool32 descriptorBindingVariableDescriptorCount;
		public VkBool32 runtimeDescriptorArray;
		public VkBool32 samplerFilterMinmax;
		public VkBool32 scalarBlockLayout;
		public VkBool32 imagelessFramebuffer;
		public VkBool32 uniformBufferStandardLayout;
		public VkBool32 shaderSubgroupExtendedTypes;
		public VkBool32 separateDepthStencilLayouts;
		public VkBool32 hostQueryReset;
		public VkBool32 timelineSemaphore;
		public VkBool32 bufferDeviceAddress;
		public VkBool32 bufferDeviceAddressCaptureReplay;
		public VkBool32 bufferDeviceAddressMultiDevice;
		public VkBool32 vulkanMemoryModel;
		public VkBool32 vulkanMemoryModelDeviceScope;
		public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
		public VkBool32 shaderOutputViewportIndex;
		public VkBool32 shaderOutputLayer;
		public VkBool32 subgroupBroadcastDynamicId;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan12Properties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDriverId driverID;
		public fixed byte driverName[(int)VulkanNative.VK_MAX_DRIVER_NAME_SIZE];
		public fixed byte driverInfo[(int)VulkanNative.VK_MAX_DRIVER_INFO_SIZE];
		public VkConformanceVersion conformanceVersion;
		public VkShaderFloatControlsIndependence denormBehaviorIndependence;
		public VkShaderFloatControlsIndependence roundingModeIndependence;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
		public VkBool32 shaderDenormPreserveFloat16;
		public VkBool32 shaderDenormPreserveFloat32;
		public VkBool32 shaderDenormPreserveFloat64;
		public VkBool32 shaderDenormFlushToZeroFloat16;
		public VkBool32 shaderDenormFlushToZeroFloat32;
		public VkBool32 shaderDenormFlushToZeroFloat64;
		public VkBool32 shaderRoundingModeRTEFloat16;
		public VkBool32 shaderRoundingModeRTEFloat32;
		public VkBool32 shaderRoundingModeRTEFloat64;
		public VkBool32 shaderRoundingModeRTZFloat16;
		public VkBool32 shaderRoundingModeRTZFloat32;
		public VkBool32 shaderRoundingModeRTZFloat64;
		public uint maxUpdateAfterBindDescriptorsInAllPools;
		public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
		public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
		public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
		public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
		public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
		public VkBool32 robustBufferAccessUpdateAfterBind;
		public VkBool32 quadDivergentImplicitLod;
		public uint maxPerStageDescriptorUpdateAfterBindSamplers;
		public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
		public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
		public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
		public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
		public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
		public uint maxPerStageUpdateAfterBindResources;
		public uint maxDescriptorSetUpdateAfterBindSamplers;
		public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
		public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
		public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindSampledImages;
		public uint maxDescriptorSetUpdateAfterBindStorageImages;
		public uint maxDescriptorSetUpdateAfterBindInputAttachments;
		public VkResolveModeFlags supportedDepthResolveModes;
		public VkResolveModeFlags supportedStencilResolveModes;
		public VkBool32 independentResolveNone;
		public VkBool32 independentResolve;
		public VkBool32 filterMinmaxSingleComponentFormats;
		public VkBool32 filterMinmaxImageComponentMapping;
		public ulong maxTimelineSemaphoreValueDifference;
		public VkSampleCountFlags framebufferIntegerColorSampleCounts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan13Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 robustImageAccess;
		public VkBool32 inlineUniformBlock;
		public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
		public VkBool32 pipelineCreationCacheControl;
		public VkBool32 privateData;
		public VkBool32 shaderDemoteToHelperInvocation;
		public VkBool32 shaderTerminateInvocation;
		public VkBool32 subgroupSizeControl;
		public VkBool32 computeFullSubgroups;
		public VkBool32 synchronization2;
		public VkBool32 textureCompressionASTC_HDR;
		public VkBool32 shaderZeroInitializeWorkgroupMemory;
		public VkBool32 dynamicRendering;
		public VkBool32 shaderIntegerDotProduct;
		public VkBool32 maintenance4;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan13Properties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint minSubgroupSize;
		public uint maxSubgroupSize;
		public uint maxComputeWorkgroupSubgroups;
		public VkShaderStageFlags requiredSubgroupSizeStages;
		public uint maxInlineUniformBlockSize;
		public uint maxPerStageDescriptorInlineUniformBlocks;
		public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
		public uint maxDescriptorSetInlineUniformBlocks;
		public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
		public uint maxInlineUniformTotalSize;
		public VkBool32 integerDotProduct8BitUnsignedAccelerated;
		public VkBool32 integerDotProduct8BitSignedAccelerated;
		public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
		public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
		public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
		public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
		public VkBool32 integerDotProduct16BitUnsignedAccelerated;
		public VkBool32 integerDotProduct16BitSignedAccelerated;
		public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
		public VkBool32 integerDotProduct32BitUnsignedAccelerated;
		public VkBool32 integerDotProduct32BitSignedAccelerated;
		public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
		public VkBool32 integerDotProduct64BitUnsignedAccelerated;
		public VkBool32 integerDotProduct64BitSignedAccelerated;
		public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
		public ulong storageTexelBufferOffsetAlignmentBytes;
		public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
		public ulong uniformTexelBufferOffsetAlignmentBytes;
		public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
		public ulong maxBufferSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCompilerControlCreateInfoAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 deviceCoherentMemory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFaultData
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFaultLevel faultLevel;
		public VkFaultType faultType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFaultCallbackInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint faultCount;
		public VkFaultData* pFaults;
		public IntPtr pfnFaultCallback;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceToolProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte name[(int)VulkanNative.VK_MAX_EXTENSION_NAME_SIZE];
		public fixed byte version[(int)VulkanNative.VK_MAX_EXTENSION_NAME_SIZE];
		public VkToolPurposeFlags purposes;
		public fixed byte description[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte layer[(int)VulkanNative.VK_MAX_EXTENSION_NAME_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerCustomBorderColorCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkClearColorValue customBorderColor;
		public VkFormat format;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxCustomBorderColorSamplers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 customBorderColors;
		public VkBool32 customBorderColorWithoutFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerBorderColorComponentMappingCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkComponentMapping components;
		public VkBool32 srgb;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 borderColorSwizzle;
		public VkBool32 borderColorSwizzleFromImage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureGeometryTrianglesDataKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat vertexFormat;
		public VkDeviceOrHostAddressConstKHR vertexData;
		public ulong vertexStride;
		public uint maxVertex;
		public VkIndexType indexType;
		public VkDeviceOrHostAddressConstKHR indexData;
		public VkDeviceOrHostAddressConstKHR transformData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureGeometryAabbsDataKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceOrHostAddressConstKHR data;
		public ulong stride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureGeometryInstancesDataKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 arrayOfPointers;
		public VkDeviceOrHostAddressConstKHR data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureGeometryKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkGeometryTypeKHR geometryType;
		public VkAccelerationStructureGeometryDataKHR geometry;
		public VkGeometryFlagsKHR flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureBuildGeometryInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureTypeKHR type;
		public VkBuildAccelerationStructureFlagsKHR flags;
		public VkBuildAccelerationStructureModeKHR mode;
		public VkAccelerationStructureKHR srcAccelerationStructure;
		public VkAccelerationStructureKHR dstAccelerationStructure;
		public uint geometryCount;
		public VkAccelerationStructureGeometryKHR* pGeometries;
		public VkAccelerationStructureGeometryKHR** ppGeometries;
		public VkDeviceOrHostAddressKHR scratchData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureBuildRangeInfoKHR
	{
		public uint primitiveCount;
		public uint primitiveOffset;
		public uint firstVertex;
		public uint transformOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureCreateFlagsKHR createFlags;
		public VkBuffer buffer;
		public ulong offset;
		public ulong size;
		public VkAccelerationStructureTypeKHR type;
		public ulong deviceAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAabbPositionsKHR
	{
		public float minX;
		public float minY;
		public float minZ;
		public float maxX;
		public float maxY;
		public float maxZ;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTransformMatrixKHR
	{
		public float matrix_0;
		public float matrix_1;
		public float matrix_2;
		public float matrix_3;
		public float matrix_4;
		public float matrix_5;
		public float matrix_6;
		public float matrix_7;
		public float matrix_8;
		public float matrix_9;
		public float matrix_10;
		public float matrix_11;
	}

	[StructLayout(LayoutKind.Explicit)]
	public unsafe partial struct VkAccelerationStructureInstanceKHR
	{
		[FieldOffset(0)]
		public VkTransformMatrixKHR transform;
		[FieldOffset(48)]
		public uint instanceCustomIndex;
		[FieldOffset(51)]
		public uint mask;
		[FieldOffset(52)]
		public uint instanceShaderBindingTableRecordOffset;
		[FieldOffset(55)]
		public VkGeometryInstanceFlagsKHR flags;
		[FieldOffset(56)]
		public ulong accelerationStructureReference;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureDeviceAddressInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureKHR accelerationStructure;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureVersionInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* pVersionData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyAccelerationStructureInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureKHR src;
		public VkAccelerationStructureKHR dst;
		public VkCopyAccelerationStructureModeKHR mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyAccelerationStructureToMemoryInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureKHR src;
		public VkDeviceOrHostAddressKHR dst;
		public VkCopyAccelerationStructureModeKHR mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyMemoryToAccelerationStructureInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceOrHostAddressConstKHR src;
		public VkAccelerationStructureKHR dst;
		public VkCopyAccelerationStructureModeKHR mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingPipelineInterfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxPipelineRayPayloadSize;
		public uint maxPipelineRayHitAttributeSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineLibraryCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint libraryCount;
		public VkPipeline* pLibraries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRefreshObjectKHR
	{
		public VkObjectType objectType;
		public ulong objectHandle;
		public VkRefreshObjectFlagsKHR flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRefreshObjectListKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint objectCount;
		public VkRefreshObjectKHR* pObjects;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 extendedDynamicState;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 extendedDynamicState2;
		public VkBool32 extendedDynamicState2LogicOp;
		public VkBool32 extendedDynamicState2PatchControlPoints;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 extendedDynamicState3TessellationDomainOrigin;
		public VkBool32 extendedDynamicState3DepthClampEnable;
		public VkBool32 extendedDynamicState3PolygonMode;
		public VkBool32 extendedDynamicState3RasterizationSamples;
		public VkBool32 extendedDynamicState3SampleMask;
		public VkBool32 extendedDynamicState3AlphaToCoverageEnable;
		public VkBool32 extendedDynamicState3AlphaToOneEnable;
		public VkBool32 extendedDynamicState3LogicOpEnable;
		public VkBool32 extendedDynamicState3ColorBlendEnable;
		public VkBool32 extendedDynamicState3ColorBlendEquation;
		public VkBool32 extendedDynamicState3ColorWriteMask;
		public VkBool32 extendedDynamicState3RasterizationStream;
		public VkBool32 extendedDynamicState3ConservativeRasterizationMode;
		public VkBool32 extendedDynamicState3ExtraPrimitiveOverestimationSize;
		public VkBool32 extendedDynamicState3DepthClipEnable;
		public VkBool32 extendedDynamicState3SampleLocationsEnable;
		public VkBool32 extendedDynamicState3ColorBlendAdvanced;
		public VkBool32 extendedDynamicState3ProvokingVertexMode;
		public VkBool32 extendedDynamicState3LineRasterizationMode;
		public VkBool32 extendedDynamicState3LineStippleEnable;
		public VkBool32 extendedDynamicState3DepthClipNegativeOneToOne;
		public VkBool32 extendedDynamicState3ViewportWScalingEnable;
		public VkBool32 extendedDynamicState3ViewportSwizzle;
		public VkBool32 extendedDynamicState3CoverageToColorEnable;
		public VkBool32 extendedDynamicState3CoverageToColorLocation;
		public VkBool32 extendedDynamicState3CoverageModulationMode;
		public VkBool32 extendedDynamicState3CoverageModulationTableEnable;
		public VkBool32 extendedDynamicState3CoverageModulationTable;
		public VkBool32 extendedDynamicState3CoverageReductionMode;
		public VkBool32 extendedDynamicState3RepresentativeFragmentTestEnable;
		public VkBool32 extendedDynamicState3ShadingRateImageEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dynamicPrimitiveTopologyUnrestricted;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkColorBlendEquationEXT
	{
		public VkBlendFactor srcColorBlendFactor;
		public VkBlendFactor dstColorBlendFactor;
		public VkBlendOp colorBlendOp;
		public VkBlendFactor srcAlphaBlendFactor;
		public VkBlendFactor dstAlphaBlendFactor;
		public VkBlendOp alphaBlendOp;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkColorBlendAdvancedEXT
	{
		public VkBlendOp advancedBlendOp;
		public VkBool32 srcPremultiplied;
		public VkBool32 dstPremultiplied;
		public VkBlendOverlapEXT blendOverlap;
		public VkBool32 clampResults;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassTransformBeginInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceTransformFlagsKHR transform;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyCommandTransformInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceTransformFlagsKHR transform;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceTransformFlagsKHR transform;
		public VkRect2D renderArea;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 diagnosticsConfig;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceDiagnosticsConfigCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceDiagnosticsConfigFlagsNV flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineOfflineCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte pipelineIdentifier[(int)VulkanNative.VK_UUID_SIZE];
		public VkPipelineMatchControl matchControl;
		public ulong poolEntrySize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderZeroInitializeWorkgroupMemory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderSubgroupUniformControlFlow;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRobustness2FeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 robustBufferAccess2;
		public VkBool32 robustImageAccess2;
		public VkBool32 nullDescriptor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRobustness2PropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong robustStorageBufferAccessSizeAlignment;
		public ulong robustUniformBufferAccessSizeAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageRobustnessFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 robustImageAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 workgroupMemoryExplicitLayout;
		public VkBool32 workgroupMemoryExplicitLayoutScalarBlockLayout;
		public VkBool32 workgroupMemoryExplicitLayout8BitAccess;
		public VkBool32 workgroupMemoryExplicitLayout16BitAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePortabilitySubsetFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 constantAlphaColorBlendFactors;
		public VkBool32 events;
		public VkBool32 imageViewFormatReinterpretation;
		public VkBool32 imageViewFormatSwizzle;
		public VkBool32 imageView2DOn3DImage;
		public VkBool32 multisampleArrayImage;
		public VkBool32 mutableComparisonSamplers;
		public VkBool32 pointPolygons;
		public VkBool32 samplerMipLodBias;
		public VkBool32 separateStencilMaskRef;
		public VkBool32 shaderSampleRateInterpolationFunctions;
		public VkBool32 tessellationIsolines;
		public VkBool32 tessellationPointMode;
		public VkBool32 triangleFans;
		public VkBool32 vertexAttributeAccessBeyondStride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePortabilitySubsetPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint minVertexInputBindingStrideAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevice4444FormatsFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 formatA4R4G4B4;
		public VkBool32 formatA4B4G4R4;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 subpassShading;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 clustercullingShader;
		public VkBool32 multiviewClusterCullingShader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 clusterShadingRate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCopy2
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong srcOffset;
		public ulong dstOffset;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageCopy2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageSubresourceLayers srcSubresource;
		public VkOffset3D srcOffset;
		public VkImageSubresourceLayers dstSubresource;
		public VkOffset3D dstOffset;
		public VkExtent3D extent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageBlit2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageSubresourceLayers srcSubresource;
		public VkOffset3D srcOffsets_0;
		public VkOffset3D srcOffsets_1;
		public VkImageSubresourceLayers dstSubresource;
		public VkOffset3D dstOffsets_0;
		public VkOffset3D dstOffsets_1;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferImageCopy2
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong bufferOffset;
		public uint bufferRowLength;
		public uint bufferImageHeight;
		public VkImageSubresourceLayers imageSubresource;
		public VkOffset3D imageOffset;
		public VkExtent3D imageExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageResolve2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageSubresourceLayers srcSubresource;
		public VkOffset3D srcOffset;
		public VkImageSubresourceLayers dstSubresource;
		public VkOffset3D dstOffset;
		public VkExtent3D extent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyBufferInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer srcBuffer;
		public VkBuffer dstBuffer;
		public uint regionCount;
		public VkBufferCopy2* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyImageInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage srcImage;
		public VkImageLayout srcImageLayout;
		public VkImage dstImage;
		public VkImageLayout dstImageLayout;
		public uint regionCount;
		public VkImageCopy2* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBlitImageInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage srcImage;
		public VkImageLayout srcImageLayout;
		public VkImage dstImage;
		public VkImageLayout dstImageLayout;
		public uint regionCount;
		public VkImageBlit2* pRegions;
		public VkFilter filter;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyBufferToImageInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer srcBuffer;
		public VkImage dstImage;
		public VkImageLayout dstImageLayout;
		public uint regionCount;
		public VkBufferImageCopy2* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyImageToBufferInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage srcImage;
		public VkImageLayout srcImageLayout;
		public VkBuffer dstBuffer;
		public uint regionCount;
		public VkBufferImageCopy2* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkResolveImageInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage srcImage;
		public VkImageLayout srcImageLayout;
		public VkImage dstImage;
		public VkImageLayout dstImageLayout;
		public uint regionCount;
		public VkImageResolve2* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderImageInt64Atomics;
		public VkBool32 sparseImageInt64Atomics;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFragmentShadingRateAttachmentInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAttachmentReference2* pFragmentShadingRateAttachment;
		public VkExtent2D shadingRateAttachmentTexelSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineFragmentShadingRateStateCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D fragmentSize;
		public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
		public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pipelineFragmentShadingRate;
		public VkBool32 primitiveFragmentShadingRate;
		public VkBool32 attachmentFragmentShadingRate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D minFragmentShadingRateAttachmentTexelSize;
		public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;
		public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
		public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;
		public VkBool32 layeredShadingRateAttachments;
		public VkBool32 fragmentShadingRateNonTrivialCombinerOps;
		public VkExtent2D maxFragmentSize;
		public uint maxFragmentSizeAspectRatio;
		public uint maxFragmentShadingRateCoverageSamples;
		public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;
		public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;
		public VkBool32 fragmentShadingRateWithSampleMask;
		public VkBool32 fragmentShadingRateWithShaderSampleMask;
		public VkBool32 fragmentShadingRateWithConservativeRasterization;
		public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;
		public VkBool32 fragmentShadingRateWithCustomSampleLocations;
		public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShadingRateKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSampleCountFlags sampleCounts;
		public VkExtent2D fragmentSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderTerminateInvocationFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderTerminateInvocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fragmentShadingRateEnums;
		public VkBool32 supersampleFragmentShadingRates;
		public VkBool32 noInvocationFragmentShadingRates;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSampleCountFlags maxFragmentShadingRateInvocationCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFragmentShadingRateTypeNV shadingRateType;
		public VkFragmentShadingRateNV shadingRate;
		public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
		public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureBuildSizesInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong accelerationStructureSize;
		public ulong updateScratchSize;
		public ulong buildScratchSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 image2DViewOf3D;
		public VkBool32 sampler2DViewOf3D;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 imageSlicedViewOf3D;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 attachmentFeedbackLoopDynamicState;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 legacyVertexAttributes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 nativeUnalignedPerformance;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 mutableDescriptorType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMutableDescriptorTypeListEXT
	{
		public uint descriptorTypeCount;
		public VkDescriptorType* pDescriptorTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMutableDescriptorTypeCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint mutableDescriptorTypeListCount;
		public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDepthClipControlFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 depthClipControl;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportDepthClipControlCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 negativeOneToOne;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 vertexInputDynamicState;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 externalMemoryRDMA;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderRelaxedExtendedInstruction;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVertexInputBindingDescription2EXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint binding;
		public uint stride;
		public VkVertexInputRate inputRate;
		public uint divisor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVertexInputAttributeDescription2EXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint location;
		public uint binding;
		public VkFormat format;
		public uint offset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 colorWriteEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineColorWriteCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint attachmentCount;
		public VkBool32* pColorWriteEnables;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryBarrier2
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong srcStageMask;
		public ulong srcAccessMask;
		public ulong dstStageMask;
		public ulong dstAccessMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageMemoryBarrier2
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong srcStageMask;
		public ulong srcAccessMask;
		public ulong dstStageMask;
		public ulong dstAccessMask;
		public VkImageLayout oldLayout;
		public VkImageLayout newLayout;
		public uint srcQueueFamilyIndex;
		public uint dstQueueFamilyIndex;
		public VkImage image;
		public VkImageSubresourceRange subresourceRange;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferMemoryBarrier2
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong srcStageMask;
		public ulong srcAccessMask;
		public ulong dstStageMask;
		public ulong dstAccessMask;
		public uint srcQueueFamilyIndex;
		public uint dstQueueFamilyIndex;
		public VkBuffer buffer;
		public ulong offset;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDependencyInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDependencyFlags dependencyFlags;
		public uint memoryBarrierCount;
		public VkMemoryBarrier2* pMemoryBarriers;
		public uint bufferMemoryBarrierCount;
		public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
		public uint imageMemoryBarrierCount;
		public VkImageMemoryBarrier2* pImageMemoryBarriers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public ulong value;
		public ulong stageMask;
		public uint deviceIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCommandBuffer commandBuffer;
		public uint deviceMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubmitInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSubmitFlags flags;
		public uint waitSemaphoreInfoCount;
		public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
		public uint commandBufferInfoCount;
		public VkCommandBufferSubmitInfo* pCommandBufferInfos;
		public uint signalSemaphoreInfoCount;
		public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyCheckpointProperties2NV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong checkpointExecutionStageMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCheckpointData2NV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong stage;
		public void* pCheckpointMarker;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSynchronization2Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 synchronization2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceHostImageCopyFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 hostImageCopy;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceHostImageCopyPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint copySrcLayoutCount;
		public VkImageLayout* pCopySrcLayouts;
		public uint copyDstLayoutCount;
		public VkImageLayout* pCopyDstLayouts;
		public fixed byte optimalTilingLayoutUUID[(int)VulkanNative.VK_UUID_SIZE];
		public VkBool32 identicalMemoryTypeRequirements;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryToImageCopyEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public void* pHostPointer;
		public uint memoryRowLength;
		public uint memoryImageHeight;
		public VkImageSubresourceLayers imageSubresource;
		public VkOffset3D imageOffset;
		public VkExtent3D imageExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageToMemoryCopyEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public void* pHostPointer;
		public uint memoryRowLength;
		public uint memoryImageHeight;
		public VkImageSubresourceLayers imageSubresource;
		public VkOffset3D imageOffset;
		public VkExtent3D imageExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyMemoryToImageInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkHostImageCopyFlagsEXT flags;
		public VkImage dstImage;
		public VkImageLayout dstImageLayout;
		public uint regionCount;
		public VkMemoryToImageCopyEXT* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyImageToMemoryInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkHostImageCopyFlagsEXT flags;
		public VkImage srcImage;
		public VkImageLayout srcImageLayout;
		public uint regionCount;
		public VkImageToMemoryCopyEXT* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyImageToImageInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkHostImageCopyFlagsEXT flags;
		public VkImage srcImage;
		public VkImageLayout srcImageLayout;
		public VkImage dstImage;
		public VkImageLayout dstImageLayout;
		public uint regionCount;
		public VkImageCopy2* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkHostImageLayoutTransitionInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
		public VkImageLayout oldLayout;
		public VkImageLayout newLayout;
		public VkImageSubresourceRange subresourceRange;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubresourceHostMemcpySizeEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkHostImageCopyDevicePerformanceQueryEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 optimalDeviceAccess;
		public VkBool32 identicalMemoryLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkanSC10Properties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 deviceNoDynamicHostAllocations;
		public VkBool32 deviceDestroyFreesMemory;
		public VkBool32 commandPoolMultipleCommandBuffersRecording;
		public VkBool32 commandPoolResetCommandBuffer;
		public VkBool32 commandBufferSimultaneousUse;
		public VkBool32 secondaryCommandBufferNullOrImagelessFramebuffer;
		public VkBool32 recycleDescriptorSetMemory;
		public VkBool32 recyclePipelineMemory;
		public uint maxRenderPassSubpasses;
		public uint maxRenderPassDependencies;
		public uint maxSubpassInputAttachments;
		public uint maxSubpassPreserveAttachments;
		public uint maxFramebufferAttachments;
		public uint maxDescriptorSetLayoutBindings;
		public uint maxQueryFaultCount;
		public uint maxCallbackFaultCount;
		public uint maxCommandPoolCommandBuffers;
		public ulong maxCommandBufferSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelinePoolSize
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong poolEntrySize;
		public uint poolEntryCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceObjectReservationCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint pipelineCacheCreateInfoCount;
		public VkPipelineCacheCreateInfo* pPipelineCacheCreateInfos;
		public uint pipelinePoolSizeCount;
		public VkPipelinePoolSize* pPipelinePoolSizes;
		public uint semaphoreRequestCount;
		public uint commandBufferRequestCount;
		public uint fenceRequestCount;
		public uint deviceMemoryRequestCount;
		public uint bufferRequestCount;
		public uint imageRequestCount;
		public uint eventRequestCount;
		public uint queryPoolRequestCount;
		public uint bufferViewRequestCount;
		public uint imageViewRequestCount;
		public uint layeredImageViewRequestCount;
		public uint pipelineCacheRequestCount;
		public uint pipelineLayoutRequestCount;
		public uint renderPassRequestCount;
		public uint graphicsPipelineRequestCount;
		public uint computePipelineRequestCount;
		public uint descriptorSetLayoutRequestCount;
		public uint samplerRequestCount;
		public uint descriptorPoolRequestCount;
		public uint descriptorSetRequestCount;
		public uint framebufferRequestCount;
		public uint commandPoolRequestCount;
		public uint samplerYcbcrConversionRequestCount;
		public uint surfaceRequestCount;
		public uint swapchainRequestCount;
		public uint displayModeRequestCount;
		public uint subpassDescriptionRequestCount;
		public uint attachmentDescriptionRequestCount;
		public uint descriptorSetLayoutBindingRequestCount;
		public uint descriptorSetLayoutBindingLimit;
		public uint maxImageViewMipLevels;
		public uint maxImageViewArrayLayers;
		public uint maxLayeredImageViewMipLevels;
		public uint maxOcclusionQueriesPerPool;
		public uint maxPipelineStatisticsQueriesPerPool;
		public uint maxTimestampQueriesPerPool;
		public uint maxImmutableSamplersPerDescriptorSetLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandPoolMemoryReservationCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong commandPoolReservedSize;
		public uint commandPoolMaxCommandBuffers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandPoolMemoryConsumption
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong commandPoolAllocated;
		public ulong commandPoolReservedSize;
		public ulong commandBufferAllocated;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkanSC10Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderAtomicInstructions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 primitivesGeneratedQuery;
		public VkBool32 primitivesGeneratedQueryWithRasterizerDiscard;
		public VkBool32 primitivesGeneratedQueryWithNonZeroStreams;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLegacyDitheringFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 legacyDithering;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 multisampledRenderToSingleSampled;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassResolvePerformanceQueryEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 optimal;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMultisampledRenderToSingleSampledInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 multisampledRenderToSingleSampledEnable;
		public VkSampleCountFlags rasterizationSamples;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePipelineProtectedAccessFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pipelineProtectedAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyVideoPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoCodecOperationFlagsKHR videoCodecOperations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyQueryResultStatusPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 queryResultStatusSupport;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoProfileListInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint profileCount;
		public VkVideoProfileInfoKHR* pProfiles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVideoFormatInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageUsageFlags imageUsage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoFormatPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public VkComponentMapping componentMapping;
		public VkImageCreateFlags imageCreateFlags;
		public VkImageType imageType;
		public VkImageTiling imageTiling;
		public VkImageUsageFlags imageUsageFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoProfileInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoCodecOperationFlagsKHR videoCodecOperation;
		public VkVideoChromaSubsamplingFlagsKHR chromaSubsampling;
		public VkVideoComponentDepthFlagBitsKHR lumaBitDepth;
		public VkVideoComponentDepthFlagBitsKHR chromaBitDepth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoCapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoCapabilityFlagsKHR flags;
		public ulong minBitstreamBufferOffsetAlignment;
		public ulong minBitstreamBufferSizeAlignment;
		public VkExtent2D pictureAccessGranularity;
		public VkExtent2D minCodedExtent;
		public VkExtent2D maxCodedExtent;
		public uint maxDpbSlots;
		public uint maxActiveReferencePictures;
		public VkExtensionProperties stdHeaderVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoSessionMemoryRequirementsKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryBindIndex;
		public VkMemoryRequirements memoryRequirements;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindVideoSessionMemoryInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryBindIndex;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
		public ulong memorySize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoPictureResourceInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkOffset2D codedOffset;
		public VkExtent2D codedExtent;
		public uint baseArrayLayer;
		public VkImageView imageViewBinding;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoReferenceSlotInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public int slotIndex;
		public VkVideoPictureResourceInfoKHR* pPictureResource;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeCapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoDecodeCapabilityFlagsKHR flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeUsageInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoDecodeUsageFlagsKHR videoUsageHints;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBuffer srcBuffer;
		public ulong srcBufferOffset;
		public ulong srcBufferRange;
		public VkVideoPictureResourceInfoKHR dstPictureResource;
		public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
		public uint referenceSlotCount;
		public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVideoMaintenance1FeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 videoMaintenance1;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoInlineQueryInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkQueryPool queryPool;
		public uint firstQuery;
		public uint queryCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH264ProfileInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr stdProfileIdc;
		public VkVideoDecodeH264PictureLayoutFlagsKHR pictureLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH264CapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr maxLevelIdc;
		public VkOffset2D fieldOffsetGranularity;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH264SessionParametersAddInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint stdSPSCount;
		public IntPtr pStdSPSs;
		public uint stdPPSCount;
		public IntPtr pStdPPSs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH264SessionParametersCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxStdSPSCount;
		public uint maxStdPPSCount;
		public VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH264PictureInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pStdPictureInfo;
		public uint sliceCount;
		public uint* pSliceOffsets;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH264DpbSlotInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pStdReferenceInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH265ProfileInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr stdProfileIdc;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH265CapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr maxLevelIdc;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH265SessionParametersAddInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint stdVPSCount;
		public IntPtr pStdVPSs;
		public uint stdSPSCount;
		public IntPtr pStdSPSs;
		public uint stdPPSCount;
		public IntPtr pStdPPSs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH265SessionParametersCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxStdVPSCount;
		public uint maxStdSPSCount;
		public uint maxStdPPSCount;
		public VkVideoDecodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH265PictureInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pStdPictureInfo;
		public uint sliceSegmentCount;
		public uint* pSliceSegmentOffsets;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeH265DpbSlotInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pStdReferenceInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeAV1ProfileInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr stdProfile;
		public VkBool32 filmGrainSupport;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeAV1CapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr maxLevel;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeAV1SessionParametersCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pStdSequenceHeader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeAV1PictureInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pStdPictureInfo;
		public fixed int referenceNameSlotIndices[(int)VulkanNative.VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR];
		public uint frameHeaderOffset;
		public uint tileCount;
		public uint* pTileOffsets;
		public uint* pTileSizes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoDecodeAV1DpbSlotInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pStdReferenceInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoSessionCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint queueFamilyIndex;
		public VkVideoSessionCreateFlagsKHR flags;
		public VkVideoProfileInfoKHR* pVideoProfile;
		public VkFormat pictureFormat;
		public VkExtent2D maxCodedExtent;
		public VkFormat referencePictureFormat;
		public uint maxDpbSlots;
		public uint maxActiveReferencePictures;
		public VkExtensionProperties* pStdHeaderVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoSessionParametersCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkVideoSessionParametersKHR videoSessionParametersTemplate;
		public VkVideoSessionKHR videoSession;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoSessionParametersUpdateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint updateSequenceCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeSessionParametersGetInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoSessionParametersKHR videoSessionParameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeSessionParametersFeedbackInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 hasOverrides;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoBeginCodingInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkVideoSessionKHR videoSession;
		public VkVideoSessionParametersKHR videoSessionParameters;
		public uint referenceSlotCount;
		public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEndCodingInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoCodingControlInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoCodingControlFlagsKHR flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeUsageInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeUsageFlagsKHR videoUsageHints;
		public VkVideoEncodeContentFlagsKHR videoContentHints;
		public VkVideoEncodeTuningModeKHR tuningMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBuffer dstBuffer;
		public ulong dstBufferOffset;
		public ulong dstBufferRange;
		public VkVideoPictureResourceInfoKHR srcPictureResource;
		public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
		public uint referenceSlotCount;
		public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
		public uint precedingExternallyEncodedBytes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueryPoolVideoEncodeFeedbackCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeFeedbackFlagsKHR encodeFeedbackFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeQualityLevelInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint qualityLevel;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoProfileInfoKHR* pVideoProfile;
		public uint qualityLevel;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeQualityLevelPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeRateControlModeFlagsKHR preferredRateControlMode;
		public uint preferredRateControlLayerCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeRateControlInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkVideoEncodeRateControlModeFlagsKHR rateControlMode;
		public uint layerCount;
		public VkVideoEncodeRateControlLayerInfoKHR* pLayers;
		public uint virtualBufferSizeInMs;
		public uint initialVirtualBufferSizeInMs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeRateControlLayerInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong averageBitrate;
		public ulong maxBitrate;
		public uint frameRateNumerator;
		public uint frameRateDenominator;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeCapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeCapabilityFlagsKHR flags;
		public VkVideoEncodeRateControlModeFlagsKHR rateControlModes;
		public uint maxRateControlLayers;
		public ulong maxBitrate;
		public uint maxQualityLevels;
		public VkExtent2D encodeInputPictureGranularity;
		public VkVideoEncodeFeedbackFlagsKHR supportedEncodeFeedbackFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264CapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeH264CapabilityFlagsKHR flags;
		public IntPtr maxLevelIdc;
		public uint maxSliceCount;
		public uint maxPPictureL0ReferenceCount;
		public uint maxBPictureL0ReferenceCount;
		public uint maxL1ReferenceCount;
		public uint maxTemporalLayerCount;
		public VkBool32 expectDyadicTemporalLayerPattern;
		public int minQp;
		public int maxQp;
		public VkBool32 prefersGopRemainingFrames;
		public VkBool32 requiresGopRemainingFrames;
		public VkVideoEncodeH264StdFlagsKHR stdSyntaxFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264QualityLevelPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeH264RateControlFlagsKHR preferredRateControlFlags;
		public uint preferredGopFrameCount;
		public uint preferredIdrPeriod;
		public uint preferredConsecutiveBFrameCount;
		public uint preferredTemporalLayerCount;
		public VkVideoEncodeH264QpKHR preferredConstantQp;
		public uint preferredMaxL0ReferenceCount;
		public uint preferredMaxL1ReferenceCount;
		public VkBool32 preferredStdEntropyCodingModeFlag;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264SessionCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 useMaxLevelIdc;
		public IntPtr maxLevelIdc;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264SessionParametersAddInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint stdSPSCount;
		public IntPtr pStdSPSs;
		public uint stdPPSCount;
		public IntPtr pStdPPSs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264SessionParametersCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxStdSPSCount;
		public uint maxStdPPSCount;
		public VkVideoEncodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264SessionParametersGetInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 writeStdSPS;
		public VkBool32 writeStdPPS;
		public uint stdSPSId;
		public uint stdPPSId;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264SessionParametersFeedbackInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 hasStdSPSOverrides;
		public VkBool32 hasStdPPSOverrides;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264DpbSlotInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pStdReferenceInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264PictureInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint naluSliceEntryCount;
		public VkVideoEncodeH264NaluSliceInfoKHR* pNaluSliceEntries;
		public IntPtr pStdPictureInfo;
		public VkBool32 generatePrefixNalu;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264ProfileInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr stdProfileIdc;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264NaluSliceInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public int constantQp;
		public IntPtr pStdSliceHeader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264RateControlInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeH264RateControlFlagsKHR flags;
		public uint gopFrameCount;
		public uint idrPeriod;
		public uint consecutiveBFrameCount;
		public uint temporalLayerCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264QpKHR
	{
		public int qpI;
		public int qpP;
		public int qpB;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264FrameSizeKHR
	{
		public uint frameISize;
		public uint framePSize;
		public uint frameBSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264GopRemainingFrameInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 useGopRemainingFrames;
		public uint gopRemainingI;
		public uint gopRemainingP;
		public uint gopRemainingB;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH264RateControlLayerInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 useMinQp;
		public VkVideoEncodeH264QpKHR minQp;
		public VkBool32 useMaxQp;
		public VkVideoEncodeH264QpKHR maxQp;
		public VkBool32 useMaxFrameSize;
		public VkVideoEncodeH264FrameSizeKHR maxFrameSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265CapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeH265CapabilityFlagsKHR flags;
		public IntPtr maxLevelIdc;
		public uint maxSliceSegmentCount;
		public VkExtent2D maxTiles;
		public VkVideoEncodeH265CtbSizeFlagsKHR ctbSizes;
		public VkVideoEncodeH265TransformBlockSizeFlagsKHR transformBlockSizes;
		public uint maxPPictureL0ReferenceCount;
		public uint maxBPictureL0ReferenceCount;
		public uint maxL1ReferenceCount;
		public uint maxSubLayerCount;
		public VkBool32 expectDyadicTemporalSubLayerPattern;
		public int minQp;
		public int maxQp;
		public VkBool32 prefersGopRemainingFrames;
		public VkBool32 requiresGopRemainingFrames;
		public VkVideoEncodeH265StdFlagsKHR stdSyntaxFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265QualityLevelPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeH265RateControlFlagsKHR preferredRateControlFlags;
		public uint preferredGopFrameCount;
		public uint preferredIdrPeriod;
		public uint preferredConsecutiveBFrameCount;
		public uint preferredSubLayerCount;
		public VkVideoEncodeH265QpKHR preferredConstantQp;
		public uint preferredMaxL0ReferenceCount;
		public uint preferredMaxL1ReferenceCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265SessionCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 useMaxLevelIdc;
		public IntPtr maxLevelIdc;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265SessionParametersAddInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint stdVPSCount;
		public IntPtr pStdVPSs;
		public uint stdSPSCount;
		public IntPtr pStdSPSs;
		public uint stdPPSCount;
		public IntPtr pStdPPSs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265SessionParametersCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxStdVPSCount;
		public uint maxStdSPSCount;
		public uint maxStdPPSCount;
		public VkVideoEncodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265SessionParametersGetInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 writeStdVPS;
		public VkBool32 writeStdSPS;
		public VkBool32 writeStdPPS;
		public uint stdVPSId;
		public uint stdSPSId;
		public uint stdPPSId;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265SessionParametersFeedbackInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 hasStdVPSOverrides;
		public VkBool32 hasStdSPSOverrides;
		public VkBool32 hasStdPPSOverrides;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265PictureInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint naluSliceSegmentEntryCount;
		public VkVideoEncodeH265NaluSliceSegmentInfoKHR* pNaluSliceSegmentEntries;
		public IntPtr pStdPictureInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265NaluSliceSegmentInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public int constantQp;
		public IntPtr pStdSliceSegmentHeader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265RateControlInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkVideoEncodeH265RateControlFlagsKHR flags;
		public uint gopFrameCount;
		public uint idrPeriod;
		public uint consecutiveBFrameCount;
		public uint subLayerCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265QpKHR
	{
		public int qpI;
		public int qpP;
		public int qpB;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265FrameSizeKHR
	{
		public uint frameISize;
		public uint framePSize;
		public uint frameBSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265GopRemainingFrameInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 useGopRemainingFrames;
		public uint gopRemainingI;
		public uint gopRemainingP;
		public uint gopRemainingB;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265RateControlLayerInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 useMinQp;
		public VkVideoEncodeH265QpKHR minQp;
		public VkBool32 useMaxQp;
		public VkVideoEncodeH265QpKHR maxQp;
		public VkBool32 useMaxFrameSize;
		public VkVideoEncodeH265FrameSizeKHR maxFrameSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265ProfileInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr stdProfileIdc;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVideoEncodeH265DpbSlotInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pStdReferenceInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 inheritedViewportScissor2D;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferInheritanceViewportScissorInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 viewportScissor2D;
		public uint viewportDepthCount;
		public VkViewport* pViewportDepths;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 ycbcr2plane444Formats;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProvokingVertexFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 provokingVertexLast;
		public VkBool32 transformFeedbackPreservesProvokingVertex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProvokingVertexPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 provokingVertexModePerPipeline;
		public VkBool32 transformFeedbackPreservesTriangleFanProvokingVertex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkProvokingVertexModeEXT provokingVertexMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCuModuleCreateInfoNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public UIntPtr dataSize;
		public void* pData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCuFunctionCreateInfoNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCuModuleNVX module;
		public byte* pName;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCuLaunchInfoNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCuFunctionNVX function;
		public uint gridDimX;
		public uint gridDimY;
		public uint gridDimZ;
		public uint blockDimX;
		public uint blockDimY;
		public uint blockDimZ;
		public uint sharedMemBytes;
		public UIntPtr paramCount;
		public void* pParams;
		public UIntPtr extraCount;
		public void* pExtras;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 descriptorBuffer;
		public VkBool32 descriptorBufferCaptureReplay;
		public VkBool32 descriptorBufferImageLayoutIgnored;
		public VkBool32 descriptorBufferPushDescriptors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 combinedImageSamplerDescriptorSingleArray;
		public VkBool32 bufferlessPushDescriptors;
		public VkBool32 allowSamplerImageViewPostSubmitCreation;
		public ulong descriptorBufferOffsetAlignment;
		public uint maxDescriptorBufferBindings;
		public uint maxResourceDescriptorBufferBindings;
		public uint maxSamplerDescriptorBufferBindings;
		public uint maxEmbeddedImmutableSamplerBindings;
		public uint maxEmbeddedImmutableSamplers;
		public UIntPtr bufferCaptureReplayDescriptorDataSize;
		public UIntPtr imageCaptureReplayDescriptorDataSize;
		public UIntPtr imageViewCaptureReplayDescriptorDataSize;
		public UIntPtr samplerCaptureReplayDescriptorDataSize;
		public UIntPtr accelerationStructureCaptureReplayDescriptorDataSize;
		public UIntPtr samplerDescriptorSize;
		public UIntPtr combinedImageSamplerDescriptorSize;
		public UIntPtr sampledImageDescriptorSize;
		public UIntPtr storageImageDescriptorSize;
		public UIntPtr uniformTexelBufferDescriptorSize;
		public UIntPtr robustUniformTexelBufferDescriptorSize;
		public UIntPtr storageTexelBufferDescriptorSize;
		public UIntPtr robustStorageTexelBufferDescriptorSize;
		public UIntPtr uniformBufferDescriptorSize;
		public UIntPtr robustUniformBufferDescriptorSize;
		public UIntPtr storageBufferDescriptorSize;
		public UIntPtr robustStorageBufferDescriptorSize;
		public UIntPtr inputAttachmentDescriptorSize;
		public UIntPtr accelerationStructureDescriptorSize;
		public ulong maxSamplerDescriptorBufferRange;
		public ulong maxResourceDescriptorBufferRange;
		public ulong samplerDescriptorBufferAddressSpaceSize;
		public ulong resourceDescriptorBufferAddressSpaceSize;
		public ulong descriptorBufferAddressSpaceSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public UIntPtr combinedImageSamplerDensityMapDescriptorSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorAddressInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong address;
		public ulong range;
		public VkFormat format;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorBufferBindingInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong address;
		public VkBufferUsageFlags usage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorGetInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorType type;
		public VkDescriptorDataEXT data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCaptureDescriptorDataInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageCaptureDescriptorDataInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewCaptureDescriptorDataInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageView imageView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerCaptureDescriptorDataInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSampler sampler;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureKHR accelerationStructure;
		public VkAccelerationStructureNV accelerationStructureNV;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public void* opaqueCaptureDescriptorData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderIntegerDotProduct;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 integerDotProduct8BitUnsignedAccelerated;
		public VkBool32 integerDotProduct8BitSignedAccelerated;
		public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
		public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
		public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
		public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
		public VkBool32 integerDotProduct16BitUnsignedAccelerated;
		public VkBool32 integerDotProduct16BitSignedAccelerated;
		public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
		public VkBool32 integerDotProduct32BitUnsignedAccelerated;
		public VkBool32 integerDotProduct32BitSignedAccelerated;
		public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
		public VkBool32 integerDotProduct64BitUnsignedAccelerated;
		public VkBool32 integerDotProduct64BitSignedAccelerated;
		public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
		public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDrmPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 hasPrimary;
		public VkBool32 hasRender;
		public long primaryMajor;
		public long primaryMinor;
		public long renderMajor;
		public long renderMinor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fragmentShaderBarycentric;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 triStripVertexOrderIndependentOfProvokingVertex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rayTracingMotionBlur;
		public VkBool32 rayTracingMotionBlurPipelineTraceRaysIndirect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingValidationFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rayTracingValidation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureGeometryMotionTrianglesDataNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceOrHostAddressConstKHR vertexData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureMotionInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxInstances;
		public uint flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSRTDataNV
	{
		public float sx;
		public float a;
		public float b;
		public float pvx;
		public float sy;
		public float c;
		public float pvy;
		public float sz;
		public float pvz;
		public float qx;
		public float qy;
		public float qz;
		public float qw;
		public float tx;
		public float ty;
		public float tz;
	}

	[StructLayout(LayoutKind.Explicit)]
	public unsafe partial struct VkAccelerationStructureSRTMotionInstanceNV
	{
		[FieldOffset(0)]
		public VkSRTDataNV transformT0;
		[FieldOffset(64)]
		public VkSRTDataNV transformT1;
		[FieldOffset(128)]
		public uint instanceCustomIndex;
		[FieldOffset(131)]
		public uint mask;
		[FieldOffset(132)]
		public uint instanceShaderBindingTableRecordOffset;
		[FieldOffset(135)]
		public VkGeometryInstanceFlagsKHR flags;
		[FieldOffset(136)]
		public ulong accelerationStructureReference;
	}

	[StructLayout(LayoutKind.Explicit)]
	public unsafe partial struct VkAccelerationStructureMatrixMotionInstanceNV
	{
		[FieldOffset(0)]
		public VkTransformMatrixKHR transformT0;
		[FieldOffset(48)]
		public VkTransformMatrixKHR transformT1;
		[FieldOffset(96)]
		public uint instanceCustomIndex;
		[FieldOffset(99)]
		public uint mask;
		[FieldOffset(100)]
		public uint instanceShaderBindingTableRecordOffset;
		[FieldOffset(103)]
		public VkGeometryInstanceFlagsKHR flags;
		[FieldOffset(104)]
		public ulong accelerationStructureReference;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureMotionInstanceNV
	{
		public VkAccelerationStructureMotionInstanceTypeNV type;
		public uint flags;
		public VkAccelerationStructureMotionInstanceDataNV data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryGetRemoteAddressInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public VkExternalMemoryHandleTypeFlags handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryBufferCollectionFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBufferCollectionFUCHSIA collection;
		public uint index;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCollectionImageCreateInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBufferCollectionFUCHSIA collection;
		public uint index;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCollectionBufferCreateInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBufferCollectionFUCHSIA collection;
		public uint index;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCollectionCreateInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr collectionToken;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCollectionPropertiesFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryTypeBits;
		public uint bufferCount;
		public uint createInfoIndex;
		public ulong sysmemPixelFormat;
		public VkFormatFeatureFlags formatFeatures;
		public VkSysmemColorSpaceFUCHSIA sysmemColorSpaceIndex;
		public VkComponentMapping samplerYcbcrConversionComponents;
		public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
		public VkSamplerYcbcrRange suggestedYcbcrRange;
		public VkChromaLocation suggestedXChromaOffset;
		public VkChromaLocation suggestedYChromaOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferConstraintsInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBufferCreateInfo createInfo;
		public VkFormatFeatureFlags requiredFormatFeatures;
		public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSysmemColorSpaceFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public uint colorSpace;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageFormatConstraintsInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageCreateInfo imageCreateInfo;
		public VkFormatFeatureFlags requiredFormatFeatures;
		public uint flags;
		public ulong sysmemPixelFormat;
		public uint colorSpaceCount;
		public VkSysmemColorSpaceFUCHSIA* pColorSpaces;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageConstraintsInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public uint formatConstraintsCount;
		public VkImageFormatConstraintsInfoFUCHSIA* pFormatConstraints;
		public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
		public VkImageConstraintsInfoFlagsFUCHSIA flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCollectionConstraintsInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public uint minBufferCount;
		public uint maxBufferCount;
		public uint minBufferCountForCamping;
		public uint minBufferCountForDedicatedSlack;
		public uint minBufferCountForSharedSlack;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCudaModuleCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public UIntPtr dataSize;
		public void* pData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCudaFunctionCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCudaModuleNV module;
		public byte* pName;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCudaLaunchInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCudaFunctionNV function;
		public uint gridDimX;
		public uint gridDimY;
		public uint gridDimZ;
		public uint blockDimX;
		public uint blockDimY;
		public uint blockDimZ;
		public uint sharedMemBytes;
		public UIntPtr paramCount;
		public void* pParams;
		public UIntPtr extraCount;
		public void* pExtras;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 formatRgba10x6WithoutYCbCrSampler;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFormatProperties3
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong linearTilingFeatures;
		public ulong optimalTilingFeatures;
		public ulong bufferFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrmFormatModifierPropertiesList2EXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint drmFormatModifierCount;
		public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrmFormatModifierProperties2EXT
	{
		public ulong drmFormatModifier;
		public uint drmFormatModifierPlaneCount;
		public ulong drmFormatModifierTilingFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidHardwareBufferFormatProperties2ANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public ulong externalFormat;
		public ulong formatFeatures;
		public VkComponentMapping samplerYcbcrConversionComponents;
		public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
		public VkSamplerYcbcrRange suggestedYcbcrRange;
		public VkChromaLocation suggestedXChromaOffset;
		public VkChromaLocation suggestedYChromaOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRenderingCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint viewMask;
		public uint colorAttachmentCount;
		public VkFormat* pColorAttachmentFormats;
		public VkFormat depthAttachmentFormat;
		public VkFormat stencilAttachmentFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderingInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderingFlags flags;
		public VkRect2D renderArea;
		public uint layerCount;
		public uint viewMask;
		public uint colorAttachmentCount;
		public VkRenderingAttachmentInfo* pColorAttachments;
		public VkRenderingAttachmentInfo* pDepthAttachment;
		public VkRenderingAttachmentInfo* pStencilAttachment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderingAttachmentInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageView imageView;
		public VkImageLayout imageLayout;
		public VkResolveModeFlags resolveMode;
		public VkImageView resolveImageView;
		public VkImageLayout resolveImageLayout;
		public VkAttachmentLoadOp loadOp;
		public VkAttachmentStoreOp storeOp;
		public VkClearValue clearValue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderingFragmentShadingRateAttachmentInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageView imageView;
		public VkImageLayout imageLayout;
		public VkExtent2D shadingRateAttachmentTexelSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderingFragmentDensityMapAttachmentInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageView imageView;
		public VkImageLayout imageLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDynamicRenderingFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dynamicRendering;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferInheritanceRenderingInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderingFlags flags;
		public uint viewMask;
		public uint colorAttachmentCount;
		public VkFormat* pColorAttachmentFormats;
		public VkFormat depthAttachmentFormat;
		public VkFormat stencilAttachmentFormat;
		public VkSampleCountFlags rasterizationSamples;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentSampleCountInfoAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public uint colorAttachmentCount;
		public VkSampleCountFlags* pColorAttachmentSamples;
		public VkSampleCountFlags depthStencilAttachmentSamples;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMultiviewPerViewAttributesInfoNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 perViewAttributes;
		public VkBool32 perViewAttributesPositionXOnly;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 minLod;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewMinLodCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public float minLod;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rasterizationOrderColorAttachmentAccess;
		public VkBool32 rasterizationOrderDepthAttachmentAccess;
		public VkBool32 rasterizationOrderStencilAttachmentAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 linearColorAttachment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 graphicsPipelineLibrary;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 graphicsPipelineLibraryFastLinking;
		public VkBool32 graphicsPipelineLibraryIndependentInterpolationDecoration;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGraphicsPipelineLibraryCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkGraphicsPipelineLibraryFlagsEXT flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 descriptorSetHostMapping;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetBindingReferenceVALVE
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorSetLayout descriptorSetLayout;
		public uint binding;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetLayoutHostMappingInfoVALVE
	{
		public VkStructureType sType;
		public void* pNext;
		public UIntPtr descriptorOffset;
		public uint descriptorSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceNestedCommandBufferFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 nestedCommandBuffer;
		public VkBool32 nestedCommandBufferRendering;
		public VkBool32 nestedCommandBufferSimultaneousUse;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceNestedCommandBufferPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxCommandBufferNestingLevel;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderModuleIdentifier;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte shaderModuleIdentifierAlgorithmUUID[(int)VulkanNative.VK_UUID_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint identifierSize;
		public byte* pIdentifier;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderModuleIdentifierEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint identifierSize;
		public fixed byte identifier[(int)VulkanNative.VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageCompressionControlEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageCompressionFlagsEXT flags;
		public uint compressionControlPlaneCount;
		public VkImageCompressionFixedRateFlagsEXT* pFixedRateFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 imageCompressionControl;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageCompressionPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageCompressionFlagsEXT imageCompressionFlags;
		public VkImageCompressionFixedRateFlagsEXT imageCompressionFixedRateFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 imageCompressionControlSwapchain;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSubresource2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageSubresource imageSubresource;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubresourceLayout2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSubresourceLayout subresourceLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassCreationControlEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 disallowMerging;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassCreationFeedbackInfoEXT
	{
		public uint postMergeSubpassCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassCreationFeedbackCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPassCreationFeedbackInfoEXT* pRenderPassFeedback;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassSubpassFeedbackInfoEXT
	{
		public VkSubpassMergeStatusEXT subpassMergeStatus;
		public fixed byte description[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public uint postMergeIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassSubpassFeedbackCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 subpassMergeFeedback;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMicromapBuildInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMicromapTypeEXT type;
		public VkBuildMicromapFlagsEXT flags;
		public VkBuildMicromapModeEXT mode;
		public VkMicromapEXT dstMicromap;
		public uint usageCountsCount;
		public VkMicromapUsageEXT* pUsageCounts;
		public VkMicromapUsageEXT** ppUsageCounts;
		public VkDeviceOrHostAddressConstKHR data;
		public VkDeviceOrHostAddressKHR scratchData;
		public VkDeviceOrHostAddressConstKHR triangleArray;
		public ulong triangleArrayStride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMicromapCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMicromapCreateFlagsEXT createFlags;
		public VkBuffer buffer;
		public ulong offset;
		public ulong size;
		public VkMicromapTypeEXT type;
		public ulong deviceAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMicromapVersionInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* pVersionData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyMicromapInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMicromapEXT src;
		public VkMicromapEXT dst;
		public VkCopyMicromapModeEXT mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyMicromapToMemoryInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMicromapEXT src;
		public VkDeviceOrHostAddressKHR dst;
		public VkCopyMicromapModeEXT mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyMemoryToMicromapInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceOrHostAddressConstKHR src;
		public VkMicromapEXT dst;
		public VkCopyMicromapModeEXT mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMicromapBuildSizesInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong micromapSize;
		public ulong buildScratchSize;
		public VkBool32 discardable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMicromapUsageEXT
	{
		public uint count;
		public uint subdivisionLevel;
		public uint format;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMicromapTriangleEXT
	{
		public uint dataOffset;
		public ushort subdivisionLevel;
		public ushort format;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 micromap;
		public VkBool32 micromapCaptureReplay;
		public VkBool32 micromapHostCommands;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceOpacityMicromapPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxOpacity2StateSubdivisionLevel;
		public uint maxOpacity4StateSubdivisionLevel;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureTrianglesOpacityMicromapEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkIndexType indexType;
		public VkDeviceOrHostAddressConstKHR indexBuffer;
		public ulong indexStride;
		public uint baseTriangle;
		public uint usageCountsCount;
		public VkMicromapUsageEXT* pUsageCounts;
		public VkMicromapUsageEXT** ppUsageCounts;
		public VkMicromapEXT micromap;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDisplacementMicromapFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 displacementMicromap;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDisplacementMicromapPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxDisplacementMicromapSubdivisionLevel;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureTrianglesDisplacementMicromapNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat displacementBiasAndScaleFormat;
		public VkFormat displacementVectorFormat;
		public VkDeviceOrHostAddressConstKHR displacementBiasAndScaleBuffer;
		public ulong displacementBiasAndScaleStride;
		public VkDeviceOrHostAddressConstKHR displacementVectorBuffer;
		public ulong displacementVectorStride;
		public VkDeviceOrHostAddressConstKHR displacedMicromapPrimitiveFlags;
		public ulong displacedMicromapPrimitiveFlagsStride;
		public VkIndexType indexType;
		public VkDeviceOrHostAddressConstKHR indexBuffer;
		public ulong indexStride;
		public uint baseTriangle;
		public uint usageCountsCount;
		public VkMicromapUsageEXT* pUsageCounts;
		public VkMicromapUsageEXT** ppUsageCounts;
		public VkMicromapEXT micromap;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelinePropertiesIdentifierEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte pipelineIdentifier[(int)VulkanNative.VK_UUID_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pipelinePropertiesIdentifier;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderEarlyAndLateFragmentTests;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalMemoryAcquireUnmodifiedEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 acquireUnmodifiedMemory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMetalObjectCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExportMetalObjectTypeFlagsEXT exportObjectType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMetalObjectsInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMetalDeviceInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr mtlDevice;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMetalCommandQueueInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkQueue queue;
		public IntPtr mtlCommandQueue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMetalBufferInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public IntPtr mtlBuffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMetalBufferInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr mtlBuffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMetalTextureInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
		public VkImageView imageView;
		public VkBufferView bufferView;
		public VkImageAspectFlags plane;
		public IntPtr mtlTexture;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMetalTextureInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageAspectFlags plane;
		public IntPtr mtlTexture;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMetalIOSurfaceInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
		public IntPtr ioSurface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMetalIOSurfaceInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr ioSurface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMetalSharedEventInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkEvent vkEvent;
		public IntPtr mtlSharedEvent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMetalSharedEventInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr mtlSharedEvent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 nonSeamlessCubeMap;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePipelineRobustnessFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pipelineRobustness;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRobustnessCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineRobustnessBufferBehaviorEXT storageBuffers;
		public VkPipelineRobustnessBufferBehaviorEXT uniformBuffers;
		public VkPipelineRobustnessBufferBehaviorEXT vertexInputs;
		public VkPipelineRobustnessImageBehaviorEXT images;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessStorageBuffers;
		public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessUniformBuffers;
		public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessVertexInputs;
		public VkPipelineRobustnessImageBehaviorEXT defaultRobustnessImages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewSampleWeightCreateInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkOffset2D filterCenter;
		public VkExtent2D filterSize;
		public uint numPhases;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageProcessingFeaturesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 textureSampleWeighted;
		public VkBool32 textureBoxFilter;
		public VkBool32 textureBlockMatch;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageProcessingPropertiesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxWeightFilterPhases;
		public VkExtent2D maxWeightFilterDimension;
		public VkExtent2D maxBlockMatchRegion;
		public VkExtent2D maxBoxFilterBlockSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 tileProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTilePropertiesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent3D tileSize;
		public VkExtent2D apronSize;
		public VkOffset2D origin;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 amigoProfiling;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAmigoProfilingSubmitInfoSEC
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong firstDrawTimestamp;
		public ulong swapBufferTimestamp;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 attachmentFeedbackLoopLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 depthClampZeroOne;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceAddressBindingReportFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 reportAddressBinding;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceAddressBindingCallbackDataEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceAddressBindingFlagsEXT flags;
		public ulong baseAddress;
		public ulong size;
		public VkDeviceAddressBindingTypeEXT bindingType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceOpticalFlowFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 opticalFlow;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceOpticalFlowPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkOpticalFlowGridSizeFlagsNV supportedOutputGridSizes;
		public VkOpticalFlowGridSizeFlagsNV supportedHintGridSizes;
		public VkBool32 hintSupported;
		public VkBool32 costSupported;
		public VkBool32 bidirectionalFlowSupported;
		public VkBool32 globalFlowSupported;
		public uint minWidth;
		public uint minHeight;
		public uint maxWidth;
		public uint maxHeight;
		public uint maxNumRegionsOfInterest;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOpticalFlowImageFormatInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkOpticalFlowUsageFlagsNV usage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOpticalFlowImageFormatPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOpticalFlowSessionCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint width;
		public uint height;
		public VkFormat imageFormat;
		public VkFormat flowVectorFormat;
		public VkFormat costFormat;
		public VkOpticalFlowGridSizeFlagsNV outputGridSize;
		public VkOpticalFlowGridSizeFlagsNV hintGridSize;
		public VkOpticalFlowPerformanceLevelNV performanceLevel;
		public VkOpticalFlowSessionCreateFlagsNV flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOpticalFlowSessionCreatePrivateDataInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint id;
		public uint size;
		public void* pPrivateData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOpticalFlowExecuteInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkOpticalFlowExecuteFlagsNV flags;
		public uint regionCount;
		public VkRect2D* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFaultFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 deviceFault;
		public VkBool32 deviceFaultVendorBinary;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceFaultAddressInfoEXT
	{
		public VkDeviceFaultAddressTypeEXT addressType;
		public ulong reportedAddress;
		public ulong addressPrecision;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceFaultVendorInfoEXT
	{
		public fixed byte description[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public ulong vendorFaultCode;
		public ulong vendorFaultData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceFaultCountsEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint addressInfoCount;
		public uint vendorInfoCount;
		public ulong vendorBinarySize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceFaultInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte description[(int)VulkanNative.VK_MAX_DESCRIPTION_SIZE];
		public VkDeviceFaultAddressInfoEXT* pAddressInfos;
		public VkDeviceFaultVendorInfoEXT* pVendorInfos;
		public void* pVendorBinaryData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
	{
		public uint headerSize;
		public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;
		public uint vendorID;
		public uint deviceID;
		public uint driverVersion;
		public fixed byte pipelineCacheUUID[(int)VulkanNative.VK_UUID_SIZE];
		public uint applicationNameOffset;
		public uint applicationVersion;
		public uint engineNameOffset;
		public uint engineVersion;
		public uint apiVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pipelineLibraryGroupHandles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDepthBiasInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public float depthBiasConstantFactor;
		public float depthBiasClamp;
		public float depthBiasSlopeFactor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDepthBiasRepresentationInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDepthBiasRepresentationEXT depthBiasRepresentation;
		public VkBool32 depthBiasExact;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDecompressMemoryRegionNV
	{
		public ulong srcAddress;
		public ulong dstAddress;
		public ulong compressedSize;
		public ulong decompressedSize;
		public ulong decompressionMethod;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong shaderCoreMask;
		public uint shaderCoreCount;
		public uint shaderWarpsPerCore;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderCoreBuiltins;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFrameBoundaryEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFrameBoundaryFlagsEXT flags;
		public ulong frameID;
		public uint imageCount;
		public VkImage* pImages;
		public uint bufferCount;
		public VkBuffer* pBuffers;
		public ulong tagName;
		public UIntPtr tagSize;
		public void* pTag;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFrameBoundaryFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 frameBoundary;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dynamicRenderingUnusedAttachments;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfacePresentModeEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPresentModeKHR presentMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfacePresentScalingCapabilitiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPresentScalingFlagsEXT supportedPresentScaling;
		public VkPresentGravityFlagsEXT supportedPresentGravityX;
		public VkPresentGravityFlagsEXT supportedPresentGravityY;
		public VkExtent2D minScaledImageExtent;
		public VkExtent2D maxScaledImageExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfacePresentModeCompatibilityEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint presentModeCount;
		public VkPresentModeKHR* pPresentModes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 swapchainMaintenance1;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainPresentFenceInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint swapchainCount;
		public VkFence* pFences;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainPresentModesCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint presentModeCount;
		public VkPresentModeKHR* pPresentModes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainPresentModeInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint swapchainCount;
		public VkPresentModeKHR* pPresentModes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainPresentScalingCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPresentScalingFlagsEXT scalingBehavior;
		public VkPresentGravityFlagsEXT presentGravityX;
		public VkPresentGravityFlagsEXT presentGravityY;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkReleaseSwapchainImagesInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainKHR swapchain;
		public uint imageIndexCount;
		public uint* pImageIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDepthBiasControlFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 depthBiasControl;
		public VkBool32 leastRepresentableValueForceUnormRepresentation;
		public VkBool32 floatRepresentation;
		public VkBool32 depthBiasExact;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rayTracingInvocationReorder;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRayTracingInvocationReorderModeNV rayTracingInvocationReorderReorderingHint;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 extendedSparseAddressSpace;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong extendedSparseAddressSpaceSize;
		public VkImageUsageFlags extendedSparseImageUsageFlags;
		public VkBufferUsageFlags extendedSparseBufferUsageFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDirectDriverLoadingInfoLUNARG
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr pfnGetInstanceProcAddr;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDirectDriverLoadingListLUNARG
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDirectDriverLoadingModeLUNARG mode;
		public uint driverCount;
		public VkDirectDriverLoadingInfoLUNARG* pDrivers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 multiviewPerViewViewports;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rayTracingPositionFetch;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceImageSubresourceInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageCreateInfo* pCreateInfo;
		public VkImageSubresource2KHR* pSubresource;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesARM
	{
		public VkStructureType sType;
		public void* pNext;
		public uint pixelRate;
		public uint texelRate;
		public uint fmaRate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 multiviewPerViewRenderAreas;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public uint perViewRenderAreaCount;
		public VkRect2D* pPerViewRenderAreas;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueryLowLatencySupportNV
	{
		public VkStructureType sType;
		public void* pNext;
		public void* pQueriedLowLatencyData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryMapInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMemoryMapFlags flags;
		public VkDeviceMemory memory;
		public ulong offset;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryUnmapInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMemoryUnmapFlagsKHR flags;
		public VkDeviceMemory memory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderObjectFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderObject;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderObjectPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte shaderBinaryUUID[(int)VulkanNative.VK_UUID_SIZE];
		public uint shaderBinaryVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderCreateFlagsEXT flags;
		public VkShaderStageFlags stage;
		public VkShaderStageFlags nextStage;
		public VkShaderCodeTypeEXT codeType;
		public UIntPtr codeSize;
		public void* pCode;
		public byte* pName;
		public uint setLayoutCount;
		public VkDescriptorSetLayout* pSetLayouts;
		public uint pushConstantRangeCount;
		public VkPushConstantRange* pPushConstantRanges;
		public VkSpecializationInfo* pSpecializationInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderTileImageFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderTileImageColorReadAccess;
		public VkBool32 shaderTileImageDepthReadAccess;
		public VkBool32 shaderTileImageStencilReadAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderTileImagePropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderTileImageCoherentReadAccelerated;
		public VkBool32 shaderTileImageReadSampleFromPixelRateInvocation;
		public VkBool32 shaderTileImageReadFromHelperInvocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportScreenBufferInfoQNX
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkScreenBufferPropertiesQNX
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong allocationSize;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkScreenBufferFormatPropertiesQNX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public ulong externalFormat;
		public ulong screenUsage;
		public VkFormatFeatureFlags formatFeatures;
		public VkComponentMapping samplerYcbcrConversionComponents;
		public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
		public VkSamplerYcbcrRange suggestedYcbcrRange;
		public VkChromaLocation suggestedXChromaOffset;
		public VkChromaLocation suggestedYChromaOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalFormatQNX
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong externalFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 screenBufferImport;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCooperativeMatrixFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 cooperativeMatrix;
		public VkBool32 cooperativeMatrixRobustBufferAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCooperativeMatrixPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint MSize;
		public uint NSize;
		public uint KSize;
		public VkComponentTypeKHR AType;
		public VkComponentTypeKHR BType;
		public VkComponentTypeKHR CType;
		public VkComponentTypeKHR ResultType;
		public VkBool32 saturatingAccumulation;
		public VkScopeKHR scope;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderStageFlags cooperativeMatrixSupportedStages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderEnqueuePropertiesAMDX
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxExecutionGraphDepth;
		public uint maxExecutionGraphShaderOutputNodes;
		public uint maxExecutionGraphShaderPayloadSize;
		public uint maxExecutionGraphShaderPayloadCount;
		public uint executionGraphDispatchAddressAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderEnqueueFeaturesAMDX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderEnqueue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExecutionGraphPipelineCreateInfoAMDX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreateFlags flags;
		public uint stageCount;
		public VkPipelineShaderStageCreateInfo* pStages;
		public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
		public VkPipelineLayout layout;
		public VkPipeline basePipelineHandle;
		public int basePipelineIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineShaderStageNodeCreateInfoAMDX
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* pName;
		public uint index;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExecutionGraphPipelineScratchSizeAMDX
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDispatchGraphInfoAMDX
	{
		public uint nodeIndex;
		public uint payloadCount;
		public VkDeviceOrHostAddressConstAMDX payloads;
		public ulong payloadStride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDispatchGraphCountInfoAMDX
	{
		public uint count;
		public VkDeviceOrHostAddressConstAMDX infos;
		public ulong stride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceAntiLagFeaturesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 antiLag;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAntiLagDataAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAntiLagModeAMD mode;
		public uint maxFPS;
		public VkAntiLagPresentationInfoAMD* pPresentationInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAntiLagPresentationInfoAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAntiLagStageAMD stage;
		public ulong frameIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindMemoryStatusKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkResult* pResult;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindDescriptorSetsInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderStageFlags stageFlags;
		public VkPipelineLayout layout;
		public uint firstSet;
		public uint descriptorSetCount;
		public VkDescriptorSet* pDescriptorSets;
		public uint dynamicOffsetCount;
		public uint* pDynamicOffsets;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPushConstantsInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineLayout layout;
		public VkShaderStageFlags stageFlags;
		public uint offset;
		public uint size;
		public void* pValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPushDescriptorSetInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderStageFlags stageFlags;
		public VkPipelineLayout layout;
		public uint set;
		public uint descriptorWriteCount;
		public VkWriteDescriptorSet* pDescriptorWrites;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPushDescriptorSetWithTemplateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorUpdateTemplate descriptorUpdateTemplate;
		public VkPipelineLayout layout;
		public uint set;
		public void* pData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSetDescriptorBufferOffsetsInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderStageFlags stageFlags;
		public VkPipelineLayout layout;
		public uint firstSet;
		public uint setCount;
		public uint* pBufferIndices;
		public ulong* pOffsets;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindDescriptorBufferEmbeddedSamplersInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderStageFlags stageFlags;
		public VkPipelineLayout layout;
		public uint set;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCubicClampFeaturesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 cubicRangeClamp;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceYcbcrDegammaFeaturesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 ycbcrDegamma;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 enableYDegamma;
		public VkBool32 enableCbCrDegamma;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCubicWeightsFeaturesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 selectableCubicWeights;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerCubicWeightsCreateInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCubicFilterWeightsQCOM cubicWeights;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBlitImageCubicWeightsInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCubicFilterWeightsQCOM cubicWeights;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageProcessing2FeaturesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 textureBlockMatch2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageProcessing2PropertiesQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D maxBlockMatchWindow;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerBlockMatchWindowCreateInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D windowExtent;
		public VkBlockMatchWindowCompareModeQCOM windowCompareMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 descriptorPoolOverallocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLayeredDriverPropertiesMSFT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkLayeredDriverUnderlyingApiMSFT underlyingAPI;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePerStageDescriptorSetFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 perStageDescriptorSet;
		public VkBool32 dynamicPipelineLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalFormatResolveFeaturesANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 externalFormatResolve;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalFormatResolvePropertiesANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 nullColorAttachmentWithExternalFormatResolve;
		public VkChromaLocation externalFormatResolveChromaOffsetX;
		public VkChromaLocation externalFormatResolveChromaOffsetY;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidHardwareBufferFormatResolvePropertiesANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat colorAttachmentFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkLatencySleepModeInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 lowLatencyMode;
		public VkBool32 lowLatencyBoost;
		public uint minimumIntervalUs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkLatencySleepInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore signalSemaphore;
		public ulong value;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSetLatencyMarkerInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong presentID;
		public VkLatencyMarkerNV marker;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGetLatencyMarkerInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint timingCount;
		public VkLatencyTimingsFrameReportNV* pTimings;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkLatencyTimingsFrameReportNV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong presentID;
		public ulong inputSampleTimeUs;
		public ulong simStartTimeUs;
		public ulong simEndTimeUs;
		public ulong renderSubmitStartTimeUs;
		public ulong renderSubmitEndTimeUs;
		public ulong presentStartTimeUs;
		public ulong presentEndTimeUs;
		public ulong driverStartTimeUs;
		public ulong driverEndTimeUs;
		public ulong osRenderQueueStartTimeUs;
		public ulong osRenderQueueEndTimeUs;
		public ulong gpuRenderStartTimeUs;
		public ulong gpuRenderEndTimeUs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOutOfBandQueueTypeInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkOutOfBandQueueTypeNV queueType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkLatencySubmissionPresentIdNV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong presentID;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainLatencyCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 latencyModeEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkLatencySurfaceCapabilitiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint presentModeCount;
		public VkPresentModeKHR* pPresentModes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCudaKernelLaunchFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 cudaKernelLaunchFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCudaKernelLaunchPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint computeCapabilityMinor;
		public uint computeCapabilityMajor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceQueueShaderCoreControlCreateInfoARM
	{
		public VkStructureType sType;
		public void* pNext;
		public uint shaderCoreCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSchedulingControlsFeaturesARM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 schedulingControls;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSchedulingControlsPropertiesARM
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong schedulingControlsFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 relaxedLineRasterization;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRenderPassStripedFeaturesARM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 renderPassStriped;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRenderPassStripedPropertiesARM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D renderPassStripeGranularity;
		public uint maxRenderPassStripes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassStripeInfoARM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRect2D stripeArea;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassStripeBeginInfoARM
	{
		public VkStructureType sType;
		public void* pNext;
		public uint stripeInfoCount;
		public VkRenderPassStripeInfoARM* pStripeInfos;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassStripeSubmitInfoARM
	{
		public VkStructureType sType;
		public void* pNext;
		public uint stripeSemaphoreInfoCount;
		public VkSemaphoreSubmitInfo* pStripeSemaphoreInfos;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderMaximalReconvergence;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderSubgroupRotateFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderSubgroupRotate;
		public VkBool32 shaderSubgroupRotateClustered;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderExpectAssumeFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderExpectAssume;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderFloatControls2FeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderFloatControls2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDynamicRenderingLocalReadFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dynamicRenderingLocalRead;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderingAttachmentLocationInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint colorAttachmentCount;
		public uint* pColorAttachmentLocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderingInputAttachmentIndexInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint colorAttachmentCount;
		public uint* pColorAttachmentInputIndices;
		public uint* pDepthInputAttachmentIndex;
		public uint* pStencilInputAttachmentIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderQuadControlFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderQuadControl;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderFloat16VectorAtomics;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMapMemoryPlacedFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 memoryMapPlaced;
		public VkBool32 memoryMapRangePlaced;
		public VkBool32 memoryUnmapReserve;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMapMemoryPlacedPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong minPlacedMemoryMapAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryMapPlacedInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public void* pPlacedAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRawAccessChainsFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderRawAccessChains;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageAlignmentControlFeaturesMESA
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 imageAlignmentControl;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageAlignmentControlPropertiesMESA
	{
		public VkStructureType sType;
		public void* pNext;
		public uint supportedImageAlignmentMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageAlignmentControlCreateInfoMESA
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maximumRequestedAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderReplicatedComposites;
	}

}

