using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.Vulkan
{
	public static unsafe partial class VulkanNative
	{
		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateInstanceDelegate(IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pInstance);
		private static vkCreateInstanceDelegate vkCreateInstance_ptr;
		public static VkResult vkCreateInstance(IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pInstance)
			=> vkCreateInstance_ptr(pCreateInfo, pAllocator, pInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyInstanceDelegate(VkInstance instance, IntPtr pAllocator);
		private static vkDestroyInstanceDelegate vkDestroyInstance_ptr;
		public static void vkDestroyInstance(VkInstance instance, IntPtr pAllocator)
			=> vkDestroyInstance_ptr(instance, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumeratePhysicalDevicesDelegate(VkInstance instance, uint* pPhysicalDeviceCount, IntPtr pPhysicalDevices);
		private static vkEnumeratePhysicalDevicesDelegate vkEnumeratePhysicalDevices_ptr;
		public static VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, IntPtr pPhysicalDevices)
			=> vkEnumeratePhysicalDevices_ptr(instance, pPhysicalDeviceCount, pPhysicalDevices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate PFN_vkVoidFunction vkGetDeviceProcAddrDelegate(VkDevice device, byte* pName);
		private static vkGetDeviceProcAddrDelegate vkGetDeviceProcAddr_ptr;
		public static PFN_vkVoidFunction vkGetDeviceProcAddr(VkDevice device, byte* pName)
			=> vkGetDeviceProcAddr_ptr(device, pName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate PFN_vkVoidFunction vkGetInstanceProcAddrDelegate(VkInstance instance, byte* pName);
		private static vkGetInstanceProcAddrDelegate vkGetInstanceProcAddr_ptr;
		public static PFN_vkVoidFunction vkGetInstanceProcAddr(VkInstance instance, byte* pName)
			=> vkGetInstanceProcAddr_ptr(instance, pName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDevicePropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pProperties);
		private static vkGetPhysicalDevicePropertiesDelegate vkGetPhysicalDeviceProperties_ptr;
		public static void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, IntPtr pProperties)
			=> vkGetPhysicalDeviceProperties_ptr(physicalDevice, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceQueueFamilyPropertiesDelegate(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties);
		private static vkGetPhysicalDeviceQueueFamilyPropertiesDelegate vkGetPhysicalDeviceQueueFamilyProperties_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties)
			=> vkGetPhysicalDeviceQueueFamilyProperties_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceMemoryPropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pMemoryProperties);
		private static vkGetPhysicalDeviceMemoryPropertiesDelegate vkGetPhysicalDeviceMemoryProperties_ptr;
		public static void vkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, IntPtr pMemoryProperties)
			=> vkGetPhysicalDeviceMemoryProperties_ptr(physicalDevice, pMemoryProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFeaturesDelegate(VkPhysicalDevice physicalDevice, IntPtr pFeatures);
		private static vkGetPhysicalDeviceFeaturesDelegate vkGetPhysicalDeviceFeatures_ptr;
		public static void vkGetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, IntPtr pFeatures)
			=> vkGetPhysicalDeviceFeatures_ptr(physicalDevice, pFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, IntPtr pFormatProperties);
		private static vkGetPhysicalDeviceFormatPropertiesDelegate vkGetPhysicalDeviceFormatProperties_ptr;
		public static void vkGetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, IntPtr pFormatProperties)
			=> vkGetPhysicalDeviceFormatProperties_ptr(physicalDevice, format, pFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, IntPtr pImageFormatProperties);
		private static vkGetPhysicalDeviceImageFormatPropertiesDelegate vkGetPhysicalDeviceImageFormatProperties_ptr;
		public static VkResult vkGetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, IntPtr pImageFormatProperties)
			=> vkGetPhysicalDeviceImageFormatProperties_ptr(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDeviceDelegate(VkPhysicalDevice physicalDevice, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDevice);
		private static vkCreateDeviceDelegate vkCreateDevice_ptr;
		public static VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDevice)
			=> vkCreateDevice_ptr(physicalDevice, pCreateInfo, pAllocator, pDevice);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDeviceDelegate(VkDevice device, IntPtr pAllocator);
		private static vkDestroyDeviceDelegate vkDestroyDevice_ptr;
		public static void vkDestroyDevice(VkDevice device, IntPtr pAllocator)
			=> vkDestroyDevice_ptr(device, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateInstanceVersionDelegate(uint* pApiVersion);
		private static vkEnumerateInstanceVersionDelegate vkEnumerateInstanceVersion_ptr;
		public static VkResult vkEnumerateInstanceVersion(uint* pApiVersion)
			=> vkEnumerateInstanceVersion_ptr(pApiVersion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateInstanceLayerPropertiesDelegate(uint* pPropertyCount, IntPtr pProperties);
		private static vkEnumerateInstanceLayerPropertiesDelegate vkEnumerateInstanceLayerProperties_ptr;
		public static VkResult vkEnumerateInstanceLayerProperties(uint* pPropertyCount, IntPtr pProperties)
			=> vkEnumerateInstanceLayerProperties_ptr(pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateInstanceExtensionPropertiesDelegate(byte* pLayerName, uint* pPropertyCount, IntPtr pProperties);
		private static vkEnumerateInstanceExtensionPropertiesDelegate vkEnumerateInstanceExtensionProperties_ptr;
		public static VkResult vkEnumerateInstanceExtensionProperties(byte* pLayerName, uint* pPropertyCount, IntPtr pProperties)
			=> vkEnumerateInstanceExtensionProperties_ptr(pLayerName, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateDeviceLayerPropertiesDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkEnumerateDeviceLayerPropertiesDelegate vkEnumerateDeviceLayerProperties_ptr;
		public static VkResult vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkEnumerateDeviceLayerProperties_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateDeviceExtensionPropertiesDelegate(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, IntPtr pProperties);
		private static vkEnumerateDeviceExtensionPropertiesDelegate vkEnumerateDeviceExtensionProperties_ptr;
		public static VkResult vkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, IntPtr pProperties)
			=> vkEnumerateDeviceExtensionProperties_ptr(physicalDevice, pLayerName, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceQueueDelegate(VkDevice device, uint queueFamilyIndex, uint queueIndex, IntPtr pQueue);
		private static vkGetDeviceQueueDelegate vkGetDeviceQueue_ptr;
		public static void vkGetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, IntPtr pQueue)
			=> vkGetDeviceQueue_ptr(device, queueFamilyIndex, queueIndex, pQueue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueSubmitDelegate(VkQueue queue, uint submitCount, IntPtr pSubmits, VkFence fence);
		private static vkQueueSubmitDelegate vkQueueSubmit_ptr;
		public static VkResult vkQueueSubmit(VkQueue queue, uint submitCount, IntPtr pSubmits, VkFence fence)
			=> vkQueueSubmit_ptr(queue, submitCount, pSubmits, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueWaitIdleDelegate(VkQueue queue);
		private static vkQueueWaitIdleDelegate vkQueueWaitIdle_ptr;
		public static VkResult vkQueueWaitIdle(VkQueue queue)
			=> vkQueueWaitIdle_ptr(queue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDeviceWaitIdleDelegate(VkDevice device);
		private static vkDeviceWaitIdleDelegate vkDeviceWaitIdle_ptr;
		public static VkResult vkDeviceWaitIdle(VkDevice device)
			=> vkDeviceWaitIdle_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAllocateMemoryDelegate(VkDevice device, IntPtr pAllocateInfo, IntPtr pAllocator, IntPtr pMemory);
		private static vkAllocateMemoryDelegate vkAllocateMemory_ptr;
		public static VkResult vkAllocateMemory(VkDevice device, IntPtr pAllocateInfo, IntPtr pAllocator, IntPtr pMemory)
			=> vkAllocateMemory_ptr(device, pAllocateInfo, pAllocator, pMemory);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkFreeMemoryDelegate(VkDevice device, VkDeviceMemory memory, IntPtr pAllocator);
		private static vkFreeMemoryDelegate vkFreeMemory_ptr;
		public static void vkFreeMemory(VkDevice device, VkDeviceMemory memory, IntPtr pAllocator)
			=> vkFreeMemory_ptr(device, memory, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkMapMemoryDelegate(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, uint flags, void** ppData);
		private static vkMapMemoryDelegate vkMapMemory_ptr;
		public static VkResult vkMapMemory(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, uint flags, void** ppData)
			=> vkMapMemory_ptr(device, memory, offset, size, flags, ppData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUnmapMemoryDelegate(VkDevice device, VkDeviceMemory memory);
		private static vkUnmapMemoryDelegate vkUnmapMemory_ptr;
		public static void vkUnmapMemory(VkDevice device, VkDeviceMemory memory)
			=> vkUnmapMemory_ptr(device, memory);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkFlushMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, IntPtr pMemoryRanges);
		private static vkFlushMappedMemoryRangesDelegate vkFlushMappedMemoryRanges_ptr;
		public static VkResult vkFlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, IntPtr pMemoryRanges)
			=> vkFlushMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkInvalidateMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, IntPtr pMemoryRanges);
		private static vkInvalidateMappedMemoryRangesDelegate vkInvalidateMappedMemoryRanges_ptr;
		public static VkResult vkInvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, IntPtr pMemoryRanges)
			=> vkInvalidateMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceMemoryCommitmentDelegate(VkDevice device, VkDeviceMemory memory, IntPtr pCommittedMemoryInBytes);
		private static vkGetDeviceMemoryCommitmentDelegate vkGetDeviceMemoryCommitment_ptr;
		public static void vkGetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, IntPtr pCommittedMemoryInBytes)
			=> vkGetDeviceMemoryCommitment_ptr(device, memory, pCommittedMemoryInBytes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetBufferMemoryRequirementsDelegate(VkDevice device, VkBuffer buffer, IntPtr pMemoryRequirements);
		private static vkGetBufferMemoryRequirementsDelegate vkGetBufferMemoryRequirements_ptr;
		public static void vkGetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, IntPtr pMemoryRequirements)
			=> vkGetBufferMemoryRequirements_ptr(device, buffer, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindBufferMemoryDelegate(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset);
		private static vkBindBufferMemoryDelegate vkBindBufferMemory_ptr;
		public static VkResult vkBindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
			=> vkBindBufferMemory_ptr(device, buffer, memory, memoryOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageMemoryRequirementsDelegate(VkDevice device, VkImage image, IntPtr pMemoryRequirements);
		private static vkGetImageMemoryRequirementsDelegate vkGetImageMemoryRequirements_ptr;
		public static void vkGetImageMemoryRequirements(VkDevice device, VkImage image, IntPtr pMemoryRequirements)
			=> vkGetImageMemoryRequirements_ptr(device, image, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindImageMemoryDelegate(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset);
		private static vkBindImageMemoryDelegate vkBindImageMemory_ptr;
		public static VkResult vkBindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
			=> vkBindImageMemory_ptr(device, image, memory, memoryOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSparseMemoryRequirementsDelegate(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements);
		private static vkGetImageSparseMemoryRequirementsDelegate vkGetImageSparseMemoryRequirements_ptr;
		public static void vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements)
			=> vkGetImageSparseMemoryRequirements_ptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, uint usage, VkImageTiling tiling, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate vkGetPhysicalDeviceSparseImageFormatProperties_ptr;
		public static void vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, uint usage, VkImageTiling tiling, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceSparseImageFormatProperties_ptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueBindSparseDelegate(VkQueue queue, uint bindInfoCount, IntPtr pBindInfo, VkFence fence);
		private static vkQueueBindSparseDelegate vkQueueBindSparse_ptr;
		public static VkResult vkQueueBindSparse(VkQueue queue, uint bindInfoCount, IntPtr pBindInfo, VkFence fence)
			=> vkQueueBindSparse_ptr(queue, bindInfoCount, pBindInfo, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateFenceDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pFence);
		private static vkCreateFenceDelegate vkCreateFence_ptr;
		public static VkResult vkCreateFence(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pFence)
			=> vkCreateFence_ptr(device, pCreateInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyFenceDelegate(VkDevice device, VkFence fence, IntPtr pAllocator);
		private static vkDestroyFenceDelegate vkDestroyFence_ptr;
		public static void vkDestroyFence(VkDevice device, VkFence fence, IntPtr pAllocator)
			=> vkDestroyFence_ptr(device, fence, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetFencesDelegate(VkDevice device, uint fenceCount, IntPtr pFences);
		private static vkResetFencesDelegate vkResetFences_ptr;
		public static VkResult vkResetFences(VkDevice device, uint fenceCount, IntPtr pFences)
			=> vkResetFences_ptr(device, fenceCount, pFences);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceStatusDelegate(VkDevice device, VkFence fence);
		private static vkGetFenceStatusDelegate vkGetFenceStatus_ptr;
		public static VkResult vkGetFenceStatus(VkDevice device, VkFence fence)
			=> vkGetFenceStatus_ptr(device, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWaitForFencesDelegate(VkDevice device, uint fenceCount, IntPtr pFences, uint waitAll, ulong timeout);
		private static vkWaitForFencesDelegate vkWaitForFences_ptr;
		public static VkResult vkWaitForFences(VkDevice device, uint fenceCount, IntPtr pFences, uint waitAll, ulong timeout)
			=> vkWaitForFences_ptr(device, fenceCount, pFences, waitAll, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSemaphoreDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSemaphore);
		private static vkCreateSemaphoreDelegate vkCreateSemaphore_ptr;
		public static VkResult vkCreateSemaphore(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSemaphore)
			=> vkCreateSemaphore_ptr(device, pCreateInfo, pAllocator, pSemaphore);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySemaphoreDelegate(VkDevice device, VkSemaphore semaphore, IntPtr pAllocator);
		private static vkDestroySemaphoreDelegate vkDestroySemaphore_ptr;
		public static void vkDestroySemaphore(VkDevice device, VkSemaphore semaphore, IntPtr pAllocator)
			=> vkDestroySemaphore_ptr(device, semaphore, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateEventDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pEvent);
		private static vkCreateEventDelegate vkCreateEvent_ptr;
		public static VkResult vkCreateEvent(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pEvent)
			=> vkCreateEvent_ptr(device, pCreateInfo, pAllocator, pEvent);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyEventDelegate(VkDevice device, VkEvent vkEvent, IntPtr pAllocator);
		private static vkDestroyEventDelegate vkDestroyEvent_ptr;
		public static void vkDestroyEvent(VkDevice device, VkEvent vkEvent, IntPtr pAllocator)
			=> vkDestroyEvent_ptr(device, vkEvent, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetEventStatusDelegate(VkDevice device, VkEvent vkEvent);
		private static vkGetEventStatusDelegate vkGetEventStatus_ptr;
		public static VkResult vkGetEventStatus(VkDevice device, VkEvent vkEvent)
			=> vkGetEventStatus_ptr(device, vkEvent);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetEventDelegate(VkDevice device, VkEvent vkEvent);
		private static vkSetEventDelegate vkSetEvent_ptr;
		public static VkResult vkSetEvent(VkDevice device, VkEvent vkEvent)
			=> vkSetEvent_ptr(device, vkEvent);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetEventDelegate(VkDevice device, VkEvent vkEvent);
		private static vkResetEventDelegate vkResetEvent_ptr;
		public static VkResult vkResetEvent(VkDevice device, VkEvent vkEvent)
			=> vkResetEvent_ptr(device, vkEvent);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateQueryPoolDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pQueryPool);
		private static vkCreateQueryPoolDelegate vkCreateQueryPool_ptr;
		public static VkResult vkCreateQueryPool(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pQueryPool)
			=> vkCreateQueryPool_ptr(device, pCreateInfo, pAllocator, pQueryPool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, IntPtr pAllocator);
		private static vkDestroyQueryPoolDelegate vkDestroyQueryPool_ptr;
		public static void vkDestroyQueryPool(VkDevice device, VkQueryPool queryPool, IntPtr pAllocator)
			=> vkDestroyQueryPool_ptr(device, queryPool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetQueryPoolResultsDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* pData, ulong stride, uint flags);
		private static vkGetQueryPoolResultsDelegate vkGetQueryPoolResults_ptr;
		public static VkResult vkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* pData, ulong stride, uint flags)
			=> vkGetQueryPoolResults_ptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkResetQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private static vkResetQueryPoolDelegate vkResetQueryPool_ptr;
		public static void vkResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
			=> vkResetQueryPool_ptr(device, queryPool, firstQuery, queryCount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateBufferDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pBuffer);
		private static vkCreateBufferDelegate vkCreateBuffer_ptr;
		public static VkResult vkCreateBuffer(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pBuffer)
			=> vkCreateBuffer_ptr(device, pCreateInfo, pAllocator, pBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyBufferDelegate(VkDevice device, VkBuffer buffer, IntPtr pAllocator);
		private static vkDestroyBufferDelegate vkDestroyBuffer_ptr;
		public static void vkDestroyBuffer(VkDevice device, VkBuffer buffer, IntPtr pAllocator)
			=> vkDestroyBuffer_ptr(device, buffer, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateBufferViewDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pView);
		private static vkCreateBufferViewDelegate vkCreateBufferView_ptr;
		public static VkResult vkCreateBufferView(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pView)
			=> vkCreateBufferView_ptr(device, pCreateInfo, pAllocator, pView);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyBufferViewDelegate(VkDevice device, VkBufferView bufferView, IntPtr pAllocator);
		private static vkDestroyBufferViewDelegate vkDestroyBufferView_ptr;
		public static void vkDestroyBufferView(VkDevice device, VkBufferView bufferView, IntPtr pAllocator)
			=> vkDestroyBufferView_ptr(device, bufferView, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateImageDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pImage);
		private static vkCreateImageDelegate vkCreateImage_ptr;
		public static VkResult vkCreateImage(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pImage)
			=> vkCreateImage_ptr(device, pCreateInfo, pAllocator, pImage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyImageDelegate(VkDevice device, VkImage image, IntPtr pAllocator);
		private static vkDestroyImageDelegate vkDestroyImage_ptr;
		public static void vkDestroyImage(VkDevice device, VkImage image, IntPtr pAllocator)
			=> vkDestroyImage_ptr(device, image, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSubresourceLayoutDelegate(VkDevice device, VkImage image, IntPtr pSubresource, IntPtr pLayout);
		private static vkGetImageSubresourceLayoutDelegate vkGetImageSubresourceLayout_ptr;
		public static void vkGetImageSubresourceLayout(VkDevice device, VkImage image, IntPtr pSubresource, IntPtr pLayout)
			=> vkGetImageSubresourceLayout_ptr(device, image, pSubresource, pLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateImageViewDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pView);
		private static vkCreateImageViewDelegate vkCreateImageView_ptr;
		public static VkResult vkCreateImageView(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pView)
			=> vkCreateImageView_ptr(device, pCreateInfo, pAllocator, pView);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyImageViewDelegate(VkDevice device, VkImageView imageView, IntPtr pAllocator);
		private static vkDestroyImageViewDelegate vkDestroyImageView_ptr;
		public static void vkDestroyImageView(VkDevice device, VkImageView imageView, IntPtr pAllocator)
			=> vkDestroyImageView_ptr(device, imageView, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateShaderModuleDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pShaderModule);
		private static vkCreateShaderModuleDelegate vkCreateShaderModule_ptr;
		public static VkResult vkCreateShaderModule(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pShaderModule)
			=> vkCreateShaderModule_ptr(device, pCreateInfo, pAllocator, pShaderModule);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyShaderModuleDelegate(VkDevice device, VkShaderModule shaderModule, IntPtr pAllocator);
		private static vkDestroyShaderModuleDelegate vkDestroyShaderModule_ptr;
		public static void vkDestroyShaderModule(VkDevice device, VkShaderModule shaderModule, IntPtr pAllocator)
			=> vkDestroyShaderModule_ptr(device, shaderModule, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreatePipelineCacheDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pPipelineCache);
		private static vkCreatePipelineCacheDelegate vkCreatePipelineCache_ptr;
		public static VkResult vkCreatePipelineCache(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pPipelineCache)
			=> vkCreatePipelineCache_ptr(device, pCreateInfo, pAllocator, pPipelineCache);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPipelineCacheDelegate(VkDevice device, VkPipelineCache pipelineCache, IntPtr pAllocator);
		private static vkDestroyPipelineCacheDelegate vkDestroyPipelineCache_ptr;
		public static void vkDestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, IntPtr pAllocator)
			=> vkDestroyPipelineCache_ptr(device, pipelineCache, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineCacheDataDelegate(VkDevice device, VkPipelineCache pipelineCache, UIntPtr* pDataSize, void* pData);
		private static vkGetPipelineCacheDataDelegate vkGetPipelineCacheData_ptr;
		public static VkResult vkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, UIntPtr* pDataSize, void* pData)
			=> vkGetPipelineCacheData_ptr(device, pipelineCache, pDataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkMergePipelineCachesDelegate(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, IntPtr pSrcCaches);
		private static vkMergePipelineCachesDelegate vkMergePipelineCaches_ptr;
		public static VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, IntPtr pSrcCaches)
			=> vkMergePipelineCaches_ptr(device, dstCache, srcCacheCount, pSrcCaches);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateGraphicsPipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines);
		private static vkCreateGraphicsPipelinesDelegate vkCreateGraphicsPipelines_ptr;
		public static VkResult vkCreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines)
			=> vkCreateGraphicsPipelines_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateComputePipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines);
		private static vkCreateComputePipelinesDelegate vkCreateComputePipelines_ptr;
		public static VkResult vkCreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines)
			=> vkCreateComputePipelines_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPipelineDelegate(VkDevice device, VkPipeline pipeline, IntPtr pAllocator);
		private static vkDestroyPipelineDelegate vkDestroyPipeline_ptr;
		public static void vkDestroyPipeline(VkDevice device, VkPipeline pipeline, IntPtr pAllocator)
			=> vkDestroyPipeline_ptr(device, pipeline, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreatePipelineLayoutDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pPipelineLayout);
		private static vkCreatePipelineLayoutDelegate vkCreatePipelineLayout_ptr;
		public static VkResult vkCreatePipelineLayout(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pPipelineLayout)
			=> vkCreatePipelineLayout_ptr(device, pCreateInfo, pAllocator, pPipelineLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPipelineLayoutDelegate(VkDevice device, VkPipelineLayout pipelineLayout, IntPtr pAllocator);
		private static vkDestroyPipelineLayoutDelegate vkDestroyPipelineLayout_ptr;
		public static void vkDestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, IntPtr pAllocator)
			=> vkDestroyPipelineLayout_ptr(device, pipelineLayout, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSamplerDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSampler);
		private static vkCreateSamplerDelegate vkCreateSampler_ptr;
		public static VkResult vkCreateSampler(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSampler)
			=> vkCreateSampler_ptr(device, pCreateInfo, pAllocator, pSampler);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySamplerDelegate(VkDevice device, VkSampler sampler, IntPtr pAllocator);
		private static vkDestroySamplerDelegate vkDestroySampler_ptr;
		public static void vkDestroySampler(VkDevice device, VkSampler sampler, IntPtr pAllocator)
			=> vkDestroySampler_ptr(device, sampler, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDescriptorSetLayoutDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSetLayout);
		private static vkCreateDescriptorSetLayoutDelegate vkCreateDescriptorSetLayout_ptr;
		public static VkResult vkCreateDescriptorSetLayout(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSetLayout)
			=> vkCreateDescriptorSetLayout_ptr(device, pCreateInfo, pAllocator, pSetLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDescriptorSetLayoutDelegate(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, IntPtr pAllocator);
		private static vkDestroyDescriptorSetLayoutDelegate vkDestroyDescriptorSetLayout_ptr;
		public static void vkDestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, IntPtr pAllocator)
			=> vkDestroyDescriptorSetLayout_ptr(device, descriptorSetLayout, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDescriptorPoolDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDescriptorPool);
		private static vkCreateDescriptorPoolDelegate vkCreateDescriptorPool_ptr;
		public static VkResult vkCreateDescriptorPool(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDescriptorPool)
			=> vkCreateDescriptorPool_ptr(device, pCreateInfo, pAllocator, pDescriptorPool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, IntPtr pAllocator);
		private static vkDestroyDescriptorPoolDelegate vkDestroyDescriptorPool_ptr;
		public static void vkDestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, IntPtr pAllocator)
			=> vkDestroyDescriptorPool_ptr(device, descriptorPool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, uint flags);
		private static vkResetDescriptorPoolDelegate vkResetDescriptorPool_ptr;
		public static VkResult vkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, uint flags)
			=> vkResetDescriptorPool_ptr(device, descriptorPool, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAllocateDescriptorSetsDelegate(VkDevice device, IntPtr pAllocateInfo, IntPtr pDescriptorSets);
		private static vkAllocateDescriptorSetsDelegate vkAllocateDescriptorSets_ptr;
		public static VkResult vkAllocateDescriptorSets(VkDevice device, IntPtr pAllocateInfo, IntPtr pDescriptorSets)
			=> vkAllocateDescriptorSets_ptr(device, pAllocateInfo, pDescriptorSets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkFreeDescriptorSetsDelegate(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, IntPtr pDescriptorSets);
		private static vkFreeDescriptorSetsDelegate vkFreeDescriptorSets_ptr;
		public static VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, IntPtr pDescriptorSets)
			=> vkFreeDescriptorSets_ptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUpdateDescriptorSetsDelegate(VkDevice device, uint descriptorWriteCount, IntPtr pDescriptorWrites, uint descriptorCopyCount, IntPtr pDescriptorCopies);
		private static vkUpdateDescriptorSetsDelegate vkUpdateDescriptorSets_ptr;
		public static void vkUpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, IntPtr pDescriptorWrites, uint descriptorCopyCount, IntPtr pDescriptorCopies)
			=> vkUpdateDescriptorSets_ptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateFramebufferDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pFramebuffer);
		private static vkCreateFramebufferDelegate vkCreateFramebuffer_ptr;
		public static VkResult vkCreateFramebuffer(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pFramebuffer)
			=> vkCreateFramebuffer_ptr(device, pCreateInfo, pAllocator, pFramebuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyFramebufferDelegate(VkDevice device, VkFramebuffer framebuffer, IntPtr pAllocator);
		private static vkDestroyFramebufferDelegate vkDestroyFramebuffer_ptr;
		public static void vkDestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, IntPtr pAllocator)
			=> vkDestroyFramebuffer_ptr(device, framebuffer, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRenderPassDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pRenderPass);
		private static vkCreateRenderPassDelegate vkCreateRenderPass_ptr;
		public static VkResult vkCreateRenderPass(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pRenderPass)
			=> vkCreateRenderPass_ptr(device, pCreateInfo, pAllocator, pRenderPass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyRenderPassDelegate(VkDevice device, VkRenderPass renderPass, IntPtr pAllocator);
		private static vkDestroyRenderPassDelegate vkDestroyRenderPass_ptr;
		public static void vkDestroyRenderPass(VkDevice device, VkRenderPass renderPass, IntPtr pAllocator)
			=> vkDestroyRenderPass_ptr(device, renderPass, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetRenderAreaGranularityDelegate(VkDevice device, VkRenderPass renderPass, IntPtr pGranularity);
		private static vkGetRenderAreaGranularityDelegate vkGetRenderAreaGranularity_ptr;
		public static void vkGetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, IntPtr pGranularity)
			=> vkGetRenderAreaGranularity_ptr(device, renderPass, pGranularity);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateCommandPoolDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pCommandPool);
		private static vkCreateCommandPoolDelegate vkCreateCommandPool_ptr;
		public static VkResult vkCreateCommandPool(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pCommandPool)
			=> vkCreateCommandPool_ptr(device, pCreateInfo, pAllocator, pCommandPool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, IntPtr pAllocator);
		private static vkDestroyCommandPoolDelegate vkDestroyCommandPool_ptr;
		public static void vkDestroyCommandPool(VkDevice device, VkCommandPool commandPool, IntPtr pAllocator)
			=> vkDestroyCommandPool_ptr(device, commandPool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, uint flags);
		private static vkResetCommandPoolDelegate vkResetCommandPool_ptr;
		public static VkResult vkResetCommandPool(VkDevice device, VkCommandPool commandPool, uint flags)
			=> vkResetCommandPool_ptr(device, commandPool, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAllocateCommandBuffersDelegate(VkDevice device, IntPtr pAllocateInfo, IntPtr pCommandBuffers);
		private static vkAllocateCommandBuffersDelegate vkAllocateCommandBuffers_ptr;
		public static VkResult vkAllocateCommandBuffers(VkDevice device, IntPtr pAllocateInfo, IntPtr pCommandBuffers)
			=> vkAllocateCommandBuffers_ptr(device, pAllocateInfo, pCommandBuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkFreeCommandBuffersDelegate(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, IntPtr pCommandBuffers);
		private static vkFreeCommandBuffersDelegate vkFreeCommandBuffers_ptr;
		public static void vkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, IntPtr pCommandBuffers)
			=> vkFreeCommandBuffers_ptr(device, commandPool, commandBufferCount, pCommandBuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBeginCommandBufferDelegate(VkCommandBuffer commandBuffer, IntPtr pBeginInfo);
		private static vkBeginCommandBufferDelegate vkBeginCommandBuffer_ptr;
		public static VkResult vkBeginCommandBuffer(VkCommandBuffer commandBuffer, IntPtr pBeginInfo)
			=> vkBeginCommandBuffer_ptr(commandBuffer, pBeginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEndCommandBufferDelegate(VkCommandBuffer commandBuffer);
		private static vkEndCommandBufferDelegate vkEndCommandBuffer_ptr;
		public static VkResult vkEndCommandBuffer(VkCommandBuffer commandBuffer)
			=> vkEndCommandBuffer_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetCommandBufferDelegate(VkCommandBuffer commandBuffer, uint flags);
		private static vkResetCommandBufferDelegate vkResetCommandBuffer_ptr;
		public static VkResult vkResetCommandBuffer(VkCommandBuffer commandBuffer, uint flags)
			=> vkResetCommandBuffer_ptr(commandBuffer, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindPipelineDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
		private static vkCmdBindPipelineDelegate vkCmdBindPipeline_ptr;
		public static void vkCmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
			=> vkCmdBindPipeline_ptr(commandBuffer, pipelineBindPoint, pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewports);
		private static vkCmdSetViewportDelegate vkCmdSetViewport_ptr;
		public static void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewports)
			=> vkCmdSetViewport_ptr(commandBuffer, firstViewport, viewportCount, pViewports);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetScissorDelegate(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, IntPtr pScissors);
		private static vkCmdSetScissorDelegate vkCmdSetScissor_ptr;
		public static void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, IntPtr pScissors)
			=> vkCmdSetScissor_ptr(commandBuffer, firstScissor, scissorCount, pScissors);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLineWidthDelegate(VkCommandBuffer commandBuffer, float lineWidth);
		private static vkCmdSetLineWidthDelegate vkCmdSetLineWidth_ptr;
		public static void vkCmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth)
			=> vkCmdSetLineWidth_ptr(commandBuffer, lineWidth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthBiasDelegate(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
		private static vkCmdSetDepthBiasDelegate vkCmdSetDepthBias_ptr;
		public static void vkCmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
			=> vkCmdSetDepthBias_ptr(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetBlendConstantsDelegate(VkCommandBuffer commandBuffer, float blendConstants);
		private static vkCmdSetBlendConstantsDelegate vkCmdSetBlendConstants_ptr;
		public static void vkCmdSetBlendConstants(VkCommandBuffer commandBuffer, float blendConstants)
			=> vkCmdSetBlendConstants_ptr(commandBuffer, blendConstants);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthBoundsDelegate(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
		private static vkCmdSetDepthBoundsDelegate vkCmdSetDepthBounds_ptr;
		public static void vkCmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)
			=> vkCmdSetDepthBounds_ptr(commandBuffer, minDepthBounds, maxDepthBounds);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilCompareMaskDelegate(VkCommandBuffer commandBuffer, uint faceMask, uint compareMask);
		private static vkCmdSetStencilCompareMaskDelegate vkCmdSetStencilCompareMask_ptr;
		public static void vkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, uint faceMask, uint compareMask)
			=> vkCmdSetStencilCompareMask_ptr(commandBuffer, faceMask, compareMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilWriteMaskDelegate(VkCommandBuffer commandBuffer, uint faceMask, uint writeMask);
		private static vkCmdSetStencilWriteMaskDelegate vkCmdSetStencilWriteMask_ptr;
		public static void vkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, uint faceMask, uint writeMask)
			=> vkCmdSetStencilWriteMask_ptr(commandBuffer, faceMask, writeMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilReferenceDelegate(VkCommandBuffer commandBuffer, uint faceMask, uint reference);
		private static vkCmdSetStencilReferenceDelegate vkCmdSetStencilReference_ptr;
		public static void vkCmdSetStencilReference(VkCommandBuffer commandBuffer, uint faceMask, uint reference)
			=> vkCmdSetStencilReference_ptr(commandBuffer, faceMask, reference);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindDescriptorSetsDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, IntPtr pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
		private static vkCmdBindDescriptorSetsDelegate vkCmdBindDescriptorSets_ptr;
		public static void vkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, IntPtr pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
			=> vkCmdBindDescriptorSets_ptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindIndexBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType);
		private static vkCmdBindIndexBufferDelegate vkCmdBindIndexBuffer_ptr;
		public static void vkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType)
			=> vkCmdBindIndexBuffer_ptr(commandBuffer, buffer, offset, indexType);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindVertexBuffersDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets);
		private static vkCmdBindVertexBuffersDelegate vkCmdBindVertexBuffers_ptr;
		public static void vkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets)
			=> vkCmdBindVertexBuffers_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawDelegate(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		private static vkCmdDrawDelegate vkCmdDraw_ptr;
		public static void vkCmdDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
			=> vkCmdDraw_ptr(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndexedDelegate(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
		private static vkCmdDrawIndexedDelegate vkCmdDrawIndexed_ptr;
		public static void vkCmdDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
			=> vkCmdDrawIndexed_ptr(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawIndirectDelegate vkCmdDrawIndirect_ptr;
		public static void vkCmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawIndirect_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndexedIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawIndexedIndirectDelegate vkCmdDrawIndexedIndirect_ptr;
		public static void vkCmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawIndexedIndirect_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDispatchDelegate(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
		private static vkCmdDispatchDelegate vkCmdDispatch_ptr;
		public static void vkCmdDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
			=> vkCmdDispatch_ptr(commandBuffer, groupCountX, groupCountY, groupCountZ);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDispatchIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset);
		private static vkCmdDispatchIndirectDelegate vkCmdDispatchIndirect_ptr;
		public static void vkCmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
			=> vkCmdDispatchIndirect_ptr(commandBuffer, buffer, offset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, IntPtr pRegions);
		private static vkCmdCopyBufferDelegate vkCmdCopyBuffer_ptr;
		public static void vkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, IntPtr pRegions)
			=> vkCmdCopyBuffer_ptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions);
		private static vkCmdCopyImageDelegate vkCmdCopyImage_ptr;
		public static void vkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions)
			=> vkCmdCopyImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBlitImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions, VkFilter filter);
		private static vkCmdBlitImageDelegate vkCmdBlitImage_ptr;
		public static void vkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions, VkFilter filter)
			=> vkCmdBlitImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyBufferToImageDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions);
		private static vkCmdCopyBufferToImageDelegate vkCmdCopyBufferToImage_ptr;
		public static void vkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions)
			=> vkCmdCopyBufferToImage_ptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImageToBufferDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, IntPtr pRegions);
		private static vkCmdCopyImageToBufferDelegate vkCmdCopyImageToBuffer_ptr;
		public static void vkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, IntPtr pRegions)
			=> vkCmdCopyImageToBuffer_ptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdUpdateBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData);
		private static vkCmdUpdateBufferDelegate vkCmdUpdateBuffer_ptr;
		public static void vkCmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
			=> vkCmdUpdateBuffer_ptr(commandBuffer, dstBuffer, dstOffset, dataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdFillBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data);
		private static vkCmdFillBufferDelegate vkCmdFillBuffer_ptr;
		public static void vkCmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data)
			=> vkCmdFillBuffer_ptr(commandBuffer, dstBuffer, dstOffset, size, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdClearColorImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, IntPtr pColor, uint rangeCount, IntPtr pRanges);
		private static vkCmdClearColorImageDelegate vkCmdClearColorImage_ptr;
		public static void vkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, IntPtr pColor, uint rangeCount, IntPtr pRanges)
			=> vkCmdClearColorImage_ptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdClearDepthStencilImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, IntPtr pDepthStencil, uint rangeCount, IntPtr pRanges);
		private static vkCmdClearDepthStencilImageDelegate vkCmdClearDepthStencilImage_ptr;
		public static void vkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, IntPtr pDepthStencil, uint rangeCount, IntPtr pRanges)
			=> vkCmdClearDepthStencilImage_ptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdClearAttachmentsDelegate(VkCommandBuffer commandBuffer, uint attachmentCount, IntPtr pAttachments, uint rectCount, IntPtr pRects);
		private static vkCmdClearAttachmentsDelegate vkCmdClearAttachments_ptr;
		public static void vkCmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, IntPtr pAttachments, uint rectCount, IntPtr pRects)
			=> vkCmdClearAttachments_ptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResolveImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions);
		private static vkCmdResolveImageDelegate vkCmdResolveImage_ptr;
		public static void vkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions)
			=> vkCmdResolveImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetEventDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, uint stageMask);
		private static vkCmdSetEventDelegate vkCmdSetEvent_ptr;
		public static void vkCmdSetEvent(VkCommandBuffer commandBuffer, VkEvent vkEvent, uint stageMask)
			=> vkCmdSetEvent_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResetEventDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, uint stageMask);
		private static vkCmdResetEventDelegate vkCmdResetEvent_ptr;
		public static void vkCmdResetEvent(VkCommandBuffer commandBuffer, VkEvent vkEvent, uint stageMask)
			=> vkCmdResetEvent_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWaitEventsDelegate(VkCommandBuffer commandBuffer, uint eventCount, IntPtr pEvents, uint srcStageMask, uint dstStageMask, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers);
		private static vkCmdWaitEventsDelegate vkCmdWaitEvents_ptr;
		public static void vkCmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, IntPtr pEvents, uint srcStageMask, uint dstStageMask, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers)
			=> vkCmdWaitEvents_ptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPipelineBarrierDelegate(VkCommandBuffer commandBuffer, uint srcStageMask, uint dstStageMask, uint dependencyFlags, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers);
		private static vkCmdPipelineBarrierDelegate vkCmdPipelineBarrier_ptr;
		public static void vkCmdPipelineBarrier(VkCommandBuffer commandBuffer, uint srcStageMask, uint dstStageMask, uint dependencyFlags, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers)
			=> vkCmdPipelineBarrier_ptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint flags);
		private static vkCmdBeginQueryDelegate vkCmdBeginQuery_ptr;
		public static void vkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint flags)
			=> vkCmdBeginQuery_ptr(commandBuffer, queryPool, query, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
		private static vkCmdEndQueryDelegate vkCmdEndQuery_ptr;
		public static void vkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
			=> vkCmdEndQuery_ptr(commandBuffer, queryPool, query);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pConditionalRenderingBegin);
		private static vkCmdBeginConditionalRenderingEXTDelegate vkCmdBeginConditionalRenderingEXT_ptr;
		public static void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, IntPtr pConditionalRenderingBegin)
			=> vkCmdBeginConditionalRenderingEXT_ptr(commandBuffer, pConditionalRenderingBegin);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndConditionalRenderingEXTDelegate vkCmdEndConditionalRenderingEXT_ptr;
		public static void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
			=> vkCmdEndConditionalRenderingEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResetQueryPoolDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private static vkCmdResetQueryPoolDelegate vkCmdResetQueryPool_ptr;
		public static void vkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
			=> vkCmdResetQueryPool_ptr(commandBuffer, queryPool, firstQuery, queryCount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteTimestampDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query);
		private static vkCmdWriteTimestampDelegate vkCmdWriteTimestamp_ptr;
		public static void vkCmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query)
			=> vkCmdWriteTimestamp_ptr(commandBuffer, pipelineStage, queryPool, query);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyQueryPoolResultsDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, uint flags);
		private static vkCmdCopyQueryPoolResultsDelegate vkCmdCopyQueryPoolResults_ptr;
		public static void vkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, uint flags)
			=> vkCmdCopyQueryPoolResults_ptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPushConstantsDelegate(VkCommandBuffer commandBuffer, VkPipelineLayout layout, uint stageFlags, uint offset, uint size, void* pValues);
		private static vkCmdPushConstantsDelegate vkCmdPushConstants_ptr;
		public static void vkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, uint stageFlags, uint offset, uint size, void* pValues)
			=> vkCmdPushConstants_ptr(commandBuffer, layout, stageFlags, offset, size, pValues);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginRenderPassDelegate(VkCommandBuffer commandBuffer, IntPtr pRenderPassBegin, VkSubpassContents contents);
		private static vkCmdBeginRenderPassDelegate vkCmdBeginRenderPass_ptr;
		public static void vkCmdBeginRenderPass(VkCommandBuffer commandBuffer, IntPtr pRenderPassBegin, VkSubpassContents contents)
			=> vkCmdBeginRenderPass_ptr(commandBuffer, pRenderPassBegin, contents);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdNextSubpassDelegate(VkCommandBuffer commandBuffer, VkSubpassContents contents);
		private static vkCmdNextSubpassDelegate vkCmdNextSubpass_ptr;
		public static void vkCmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents)
			=> vkCmdNextSubpass_ptr(commandBuffer, contents);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndRenderPassDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndRenderPassDelegate vkCmdEndRenderPass_ptr;
		public static void vkCmdEndRenderPass(VkCommandBuffer commandBuffer)
			=> vkCmdEndRenderPass_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdExecuteCommandsDelegate(VkCommandBuffer commandBuffer, uint commandBufferCount, IntPtr pCommandBuffers);
		private static vkCmdExecuteCommandsDelegate vkCmdExecuteCommands_ptr;
		public static void vkCmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, IntPtr pCommandBuffers)
			=> vkCmdExecuteCommands_ptr(commandBuffer, commandBufferCount, pCommandBuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateAndroidSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateAndroidSurfaceKHRDelegate vkCreateAndroidSurfaceKHR_ptr;
		public static VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateAndroidSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceDisplayPropertiesKHRDelegate vkGetPhysicalDeviceDisplayPropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceDisplayPropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayPlaneSupportedDisplaysKHRDelegate(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, IntPtr pDisplays);
		private static vkGetDisplayPlaneSupportedDisplaysKHRDelegate vkGetDisplayPlaneSupportedDisplaysKHR_ptr;
		public static VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, IntPtr pDisplays)
			=> vkGetDisplayPlaneSupportedDisplaysKHR_ptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayModePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetDisplayModePropertiesKHRDelegate vkGetDisplayModePropertiesKHR_ptr;
		public static VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetDisplayModePropertiesKHR_ptr(physicalDevice, display, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDisplayModeKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pMode);
		private static vkCreateDisplayModeKHRDelegate vkCreateDisplayModeKHR_ptr;
		public static VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pMode)
			=> vkCreateDisplayModeKHR_ptr(physicalDevice, display, pCreateInfo, pAllocator, pMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayPlaneCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, IntPtr pCapabilities);
		private static vkGetDisplayPlaneCapabilitiesKHRDelegate vkGetDisplayPlaneCapabilitiesKHR_ptr;
		public static VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, IntPtr pCapabilities)
			=> vkGetDisplayPlaneCapabilitiesKHR_ptr(physicalDevice, mode, planeIndex, pCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDisplayPlaneSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateDisplayPlaneSurfaceKHRDelegate vkCreateDisplayPlaneSurfaceKHR_ptr;
		public static VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateDisplayPlaneSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSharedSwapchainsKHRDelegate(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pSwapchains);
		private static vkCreateSharedSwapchainsKHRDelegate vkCreateSharedSwapchainsKHR_ptr;
		public static VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pSwapchains)
			=> vkCreateSharedSwapchainsKHR_ptr(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySurfaceKHRDelegate(VkInstance instance, VkSurfaceKHR surface, IntPtr pAllocator);
		private static vkDestroySurfaceKHRDelegate vkDestroySurfaceKHR_ptr;
		public static void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, IntPtr pAllocator)
			=> vkDestroySurfaceKHR_ptr(instance, surface, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, IntPtr pSupported);
		private static vkGetPhysicalDeviceSurfaceSupportKHRDelegate vkGetPhysicalDeviceSurfaceSupportKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, IntPtr pSupported)
			=> vkGetPhysicalDeviceSurfaceSupportKHR_ptr(physicalDevice, queueFamilyIndex, surface, pSupported);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr(physicalDevice, surface, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceFormatsKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats);
		private static vkGetPhysicalDeviceSurfaceFormatsKHRDelegate vkGetPhysicalDeviceSurfaceFormatsKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats)
			=> vkGetPhysicalDeviceSurfaceFormatsKHR_ptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfacePresentModesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, IntPtr pPresentModes);
		private static vkGetPhysicalDeviceSurfacePresentModesKHRDelegate vkGetPhysicalDeviceSurfacePresentModesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, IntPtr pPresentModes)
			=> vkGetPhysicalDeviceSurfacePresentModesKHR_ptr(physicalDevice, surface, pPresentModeCount, pPresentModes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSwapchainKHRDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSwapchain);
		private static vkCreateSwapchainKHRDelegate vkCreateSwapchainKHR_ptr;
		public static VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSwapchain)
			=> vkCreateSwapchainKHR_ptr(device, pCreateInfo, pAllocator, pSwapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySwapchainKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, IntPtr pAllocator);
		private static vkDestroySwapchainKHRDelegate vkDestroySwapchainKHR_ptr;
		public static void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, IntPtr pAllocator)
			=> vkDestroySwapchainKHR_ptr(device, swapchain, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainImagesKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, IntPtr pSwapchainImages);
		private static vkGetSwapchainImagesKHRDelegate vkGetSwapchainImagesKHR_ptr;
		public static VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, IntPtr pSwapchainImages)
			=> vkGetSwapchainImagesKHR_ptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireNextImageKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex);
		private static vkAcquireNextImageKHRDelegate vkAcquireNextImageKHR_ptr;
		public static VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
			=> vkAcquireNextImageKHR_ptr(device, swapchain, timeout, semaphore, fence, pImageIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueuePresentKHRDelegate(VkQueue queue, IntPtr pPresentInfo);
		private static vkQueuePresentKHRDelegate vkQueuePresentKHR_ptr;
		public static VkResult vkQueuePresentKHR(VkQueue queue, IntPtr pPresentInfo)
			=> vkQueuePresentKHR_ptr(queue, pPresentInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateViSurfaceNNDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateViSurfaceNNDelegate vkCreateViSurfaceNN_ptr;
		public static VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateViSurfaceNN_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateWaylandSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateWaylandSurfaceKHRDelegate vkCreateWaylandSurfaceKHR_ptr;
		public static VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateWaylandSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display);
		private static vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr;
		public static uint vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display)
			=> vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateWin32SurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateWin32SurfaceKHRDelegate vkCreateWin32SurfaceKHR_ptr;
		public static VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateWin32SurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex);
		private static vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr;
		public static uint vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
			=> vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateXlibSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateXlibSurfaceKHRDelegate vkCreateXlibSurfaceKHR_ptr;
		public static VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateXlibSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID);
		private static vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr;
		public static uint vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
			=> vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, dpy, visualID);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateXcbSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateXcbSurfaceKHRDelegate vkCreateXcbSurfaceKHR_ptr;
		public static VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateXcbSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, IntPtr visual_id);
		private static vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr;
		public static uint vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, IntPtr visual_id)
			=> vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, connection, visual_id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateImagePipeSurfaceFUCHSIADelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateImagePipeSurfaceFUCHSIADelegate vkCreateImagePipeSurfaceFUCHSIA_ptr;
		public static VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateImagePipeSurfaceFUCHSIA_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateStreamDescriptorSurfaceGGPDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateStreamDescriptorSurfaceGGPDelegate vkCreateStreamDescriptorSurfaceGGP_ptr;
		public static VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateStreamDescriptorSurfaceGGP_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDebugReportCallbackEXTDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pCallback);
		private static vkCreateDebugReportCallbackEXTDelegate vkCreateDebugReportCallbackEXT_ptr;
		public static VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pCallback)
			=> vkCreateDebugReportCallbackEXT_ptr(instance, pCreateInfo, pAllocator, pCallback);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDebugReportCallbackEXTDelegate(VkInstance instance, VkDebugReportCallbackEXT callback, IntPtr pAllocator);
		private static vkDestroyDebugReportCallbackEXTDelegate vkDestroyDebugReportCallbackEXT_ptr;
		public static void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, IntPtr pAllocator)
			=> vkDestroyDebugReportCallbackEXT_ptr(instance, callback, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDebugReportMessageEXTDelegate(VkInstance instance, uint flags, VkDebugReportObjectTypeEXT objectType, ulong vkObject, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage);
		private static vkDebugReportMessageEXTDelegate vkDebugReportMessageEXT_ptr;
		public static void vkDebugReportMessageEXT(VkInstance instance, uint flags, VkDebugReportObjectTypeEXT objectType, ulong vkObject, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage)
			=> vkDebugReportMessageEXT_ptr(instance, flags, objectType, vkObject, location, messageCode, pLayerPrefix, pMessage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDebugMarkerSetObjectNameEXTDelegate(VkDevice device, IntPtr pNameInfo);
		private static vkDebugMarkerSetObjectNameEXTDelegate vkDebugMarkerSetObjectNameEXT_ptr;
		public static VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, IntPtr pNameInfo)
			=> vkDebugMarkerSetObjectNameEXT_ptr(device, pNameInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDebugMarkerSetObjectTagEXTDelegate(VkDevice device, IntPtr pTagInfo);
		private static vkDebugMarkerSetObjectTagEXTDelegate vkDebugMarkerSetObjectTagEXT_ptr;
		public static VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, IntPtr pTagInfo)
			=> vkDebugMarkerSetObjectTagEXT_ptr(device, pTagInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDebugMarkerBeginEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo);
		private static vkCmdDebugMarkerBeginEXTDelegate vkCmdDebugMarkerBeginEXT_ptr;
		public static void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
			=> vkCmdDebugMarkerBeginEXT_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDebugMarkerEndEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdDebugMarkerEndEXTDelegate vkCmdDebugMarkerEndEXT_ptr;
		public static void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
			=> vkCmdDebugMarkerEndEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDebugMarkerInsertEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo);
		private static vkCmdDebugMarkerInsertEXTDelegate vkCmdDebugMarkerInsertEXT_ptr;
		public static void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
			=> vkCmdDebugMarkerInsertEXT_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, uint externalHandleType, IntPtr pExternalImageFormatProperties);
		private static vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr;
		public static VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, uint externalHandleType, IntPtr pExternalImageFormatProperties)
			=> vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryWin32HandleNVDelegate(VkDevice device, VkDeviceMemory memory, uint handleType, IntPtr pHandle);
		private static vkGetMemoryWin32HandleNVDelegate vkGetMemoryWin32HandleNV_ptr;
		public static VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, uint handleType, IntPtr pHandle)
			=> vkGetMemoryWin32HandleNV_ptr(device, memory, handleType, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdExecuteGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, uint isPreprocessed, IntPtr pGeneratedCommandsInfo);
		private static vkCmdExecuteGeneratedCommandsNVDelegate vkCmdExecuteGeneratedCommandsNV_ptr;
		public static void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, uint isPreprocessed, IntPtr pGeneratedCommandsInfo)
			=> vkCmdExecuteGeneratedCommandsNV_ptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPreprocessGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, IntPtr pGeneratedCommandsInfo);
		private static vkCmdPreprocessGeneratedCommandsNVDelegate vkCmdPreprocessGeneratedCommandsNV_ptr;
		public static void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, IntPtr pGeneratedCommandsInfo)
			=> vkCmdPreprocessGeneratedCommandsNV_ptr(commandBuffer, pGeneratedCommandsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindPipelineShaderGroupNVDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex);
		private static vkCmdBindPipelineShaderGroupNVDelegate vkCmdBindPipelineShaderGroupNV_ptr;
		public static void vkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
			=> vkCmdBindPipelineShaderGroupNV_ptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetGeneratedCommandsMemoryRequirementsNVDelegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetGeneratedCommandsMemoryRequirementsNVDelegate vkGetGeneratedCommandsMemoryRequirementsNV_ptr;
		public static void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetGeneratedCommandsMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateIndirectCommandsLayoutNVDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pIndirectCommandsLayout);
		private static vkCreateIndirectCommandsLayoutNVDelegate vkCreateIndirectCommandsLayoutNV_ptr;
		public static VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pIndirectCommandsLayout)
			=> vkCreateIndirectCommandsLayoutNV_ptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyIndirectCommandsLayoutNVDelegate(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, IntPtr pAllocator);
		private static vkDestroyIndirectCommandsLayoutNVDelegate vkDestroyIndirectCommandsLayoutNV_ptr;
		public static void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, IntPtr pAllocator)
			=> vkDestroyIndirectCommandsLayoutNV_ptr(device, indirectCommandsLayout, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFeatures2Delegate(VkPhysicalDevice physicalDevice, IntPtr pFeatures);
		private static vkGetPhysicalDeviceFeatures2Delegate vkGetPhysicalDeviceFeatures2_ptr;
		public static void vkGetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, IntPtr pFeatures)
			=> vkGetPhysicalDeviceFeatures2_ptr(physicalDevice, pFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceProperties2Delegate(VkPhysicalDevice physicalDevice, IntPtr pProperties);
		private static vkGetPhysicalDeviceProperties2Delegate vkGetPhysicalDeviceProperties2_ptr;
		public static void vkGetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, IntPtr pProperties)
			=> vkGetPhysicalDeviceProperties2_ptr(physicalDevice, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFormatProperties2Delegate(VkPhysicalDevice physicalDevice, VkFormat format, IntPtr pFormatProperties);
		private static vkGetPhysicalDeviceFormatProperties2Delegate vkGetPhysicalDeviceFormatProperties2_ptr;
		public static void vkGetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, IntPtr pFormatProperties)
			=> vkGetPhysicalDeviceFormatProperties2_ptr(physicalDevice, format, pFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, IntPtr pImageFormatInfo, IntPtr pImageFormatProperties);
		private static vkGetPhysicalDeviceImageFormatProperties2Delegate vkGetPhysicalDeviceImageFormatProperties2_ptr;
		public static VkResult vkGetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, IntPtr pImageFormatInfo, IntPtr pImageFormatProperties)
			=> vkGetPhysicalDeviceImageFormatProperties2_ptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceQueueFamilyProperties2Delegate(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties);
		private static vkGetPhysicalDeviceQueueFamilyProperties2Delegate vkGetPhysicalDeviceQueueFamilyProperties2_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties)
			=> vkGetPhysicalDeviceQueueFamilyProperties2_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceMemoryProperties2Delegate(VkPhysicalDevice physicalDevice, IntPtr pMemoryProperties);
		private static vkGetPhysicalDeviceMemoryProperties2Delegate vkGetPhysicalDeviceMemoryProperties2_ptr;
		public static void vkGetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, IntPtr pMemoryProperties)
			=> vkGetPhysicalDeviceMemoryProperties2_ptr(physicalDevice, pMemoryProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceSparseImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, IntPtr pFormatInfo, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceSparseImageFormatProperties2Delegate vkGetPhysicalDeviceSparseImageFormatProperties2_ptr;
		public static void vkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, IntPtr pFormatInfo, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceSparseImageFormatProperties2_ptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPushDescriptorSetKHRDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, IntPtr pDescriptorWrites);
		private static vkCmdPushDescriptorSetKHRDelegate vkCmdPushDescriptorSetKHR_ptr;
		public static void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, IntPtr pDescriptorWrites)
			=> vkCmdPushDescriptorSetKHR_ptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkTrimCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, uint flags);
		private static vkTrimCommandPoolDelegate vkTrimCommandPool_ptr;
		public static void vkTrimCommandPool(VkDevice device, VkCommandPool commandPool, uint flags)
			=> vkTrimCommandPool_ptr(device, commandPool, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceExternalBufferPropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pExternalBufferInfo, IntPtr pExternalBufferProperties);
		private static vkGetPhysicalDeviceExternalBufferPropertiesDelegate vkGetPhysicalDeviceExternalBufferProperties_ptr;
		public static void vkGetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, IntPtr pExternalBufferInfo, IntPtr pExternalBufferProperties)
			=> vkGetPhysicalDeviceExternalBufferProperties_ptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryWin32HandleKHRDelegate(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetMemoryWin32HandleKHRDelegate vkGetMemoryWin32HandleKHR_ptr;
		public static VkResult vkGetMemoryWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetMemoryWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryWin32HandlePropertiesKHRDelegate(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, IntPtr pMemoryWin32HandleProperties);
		private static vkGetMemoryWin32HandlePropertiesKHRDelegate vkGetMemoryWin32HandlePropertiesKHR_ptr;
		public static VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, IntPtr pMemoryWin32HandleProperties)
			=> vkGetMemoryWin32HandlePropertiesKHR_ptr(device, handleType, handle, pMemoryWin32HandleProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryFdKHRDelegate(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd);
		private static vkGetMemoryFdKHRDelegate vkGetMemoryFdKHR_ptr;
		public static VkResult vkGetMemoryFdKHR(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd)
			=> vkGetMemoryFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryFdPropertiesKHRDelegate(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, IntPtr pMemoryFdProperties);
		private static vkGetMemoryFdPropertiesKHRDelegate vkGetMemoryFdPropertiesKHR_ptr;
		public static VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, IntPtr pMemoryFdProperties)
			=> vkGetMemoryFdPropertiesKHR_ptr(device, handleType, fd, pMemoryFdProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pExternalSemaphoreInfo, IntPtr pExternalSemaphoreProperties);
		private static vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate vkGetPhysicalDeviceExternalSemaphoreProperties_ptr;
		public static void vkGetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, IntPtr pExternalSemaphoreInfo, IntPtr pExternalSemaphoreProperties)
			=> vkGetPhysicalDeviceExternalSemaphoreProperties_ptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreWin32HandleKHRDelegate(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetSemaphoreWin32HandleKHRDelegate vkGetSemaphoreWin32HandleKHR_ptr;
		public static VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetSemaphoreWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportSemaphoreWin32HandleKHRDelegate(VkDevice device, IntPtr pImportSemaphoreWin32HandleInfo);
		private static vkImportSemaphoreWin32HandleKHRDelegate vkImportSemaphoreWin32HandleKHR_ptr;
		public static VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, IntPtr pImportSemaphoreWin32HandleInfo)
			=> vkImportSemaphoreWin32HandleKHR_ptr(device, pImportSemaphoreWin32HandleInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreFdKHRDelegate(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd);
		private static vkGetSemaphoreFdKHRDelegate vkGetSemaphoreFdKHR_ptr;
		public static VkResult vkGetSemaphoreFdKHR(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd)
			=> vkGetSemaphoreFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportSemaphoreFdKHRDelegate(VkDevice device, IntPtr pImportSemaphoreFdInfo);
		private static vkImportSemaphoreFdKHRDelegate vkImportSemaphoreFdKHR_ptr;
		public static VkResult vkImportSemaphoreFdKHR(VkDevice device, IntPtr pImportSemaphoreFdInfo)
			=> vkImportSemaphoreFdKHR_ptr(device, pImportSemaphoreFdInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceExternalFencePropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pExternalFenceInfo, IntPtr pExternalFenceProperties);
		private static vkGetPhysicalDeviceExternalFencePropertiesDelegate vkGetPhysicalDeviceExternalFenceProperties_ptr;
		public static void vkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, IntPtr pExternalFenceInfo, IntPtr pExternalFenceProperties)
			=> vkGetPhysicalDeviceExternalFenceProperties_ptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceWin32HandleKHRDelegate(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetFenceWin32HandleKHRDelegate vkGetFenceWin32HandleKHR_ptr;
		public static VkResult vkGetFenceWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetFenceWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportFenceWin32HandleKHRDelegate(VkDevice device, IntPtr pImportFenceWin32HandleInfo);
		private static vkImportFenceWin32HandleKHRDelegate vkImportFenceWin32HandleKHR_ptr;
		public static VkResult vkImportFenceWin32HandleKHR(VkDevice device, IntPtr pImportFenceWin32HandleInfo)
			=> vkImportFenceWin32HandleKHR_ptr(device, pImportFenceWin32HandleInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceFdKHRDelegate(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd);
		private static vkGetFenceFdKHRDelegate vkGetFenceFdKHR_ptr;
		public static VkResult vkGetFenceFdKHR(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd)
			=> vkGetFenceFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportFenceFdKHRDelegate(VkDevice device, IntPtr pImportFenceFdInfo);
		private static vkImportFenceFdKHRDelegate vkImportFenceFdKHR_ptr;
		public static VkResult vkImportFenceFdKHR(VkDevice device, IntPtr pImportFenceFdInfo)
			=> vkImportFenceFdKHR_ptr(device, pImportFenceFdInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkReleaseDisplayEXTDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
		private static vkReleaseDisplayEXTDelegate vkReleaseDisplayEXT_ptr;
		public static VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
			=> vkReleaseDisplayEXT_ptr(physicalDevice, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireXlibDisplayEXTDelegate(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display);
		private static vkAcquireXlibDisplayEXTDelegate vkAcquireXlibDisplayEXT_ptr;
		public static VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
			=> vkAcquireXlibDisplayEXT_ptr(physicalDevice, dpy, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetRandROutputDisplayEXTDelegate(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, IntPtr pDisplay);
		private static vkGetRandROutputDisplayEXTDelegate vkGetRandROutputDisplayEXT_ptr;
		public static VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, IntPtr pDisplay)
			=> vkGetRandROutputDisplayEXT_ptr(physicalDevice, dpy, rrOutput, pDisplay);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDisplayPowerControlEXTDelegate(VkDevice device, VkDisplayKHR display, IntPtr pDisplayPowerInfo);
		private static vkDisplayPowerControlEXTDelegate vkDisplayPowerControlEXT_ptr;
		public static VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayPowerInfo)
			=> vkDisplayPowerControlEXT_ptr(device, display, pDisplayPowerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkRegisterDeviceEventEXTDelegate(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence);
		private static vkRegisterDeviceEventEXTDelegate vkRegisterDeviceEventEXT_ptr;
		public static VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence)
			=> vkRegisterDeviceEventEXT_ptr(device, pDeviceEventInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkRegisterDisplayEventEXTDelegate(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence);
		private static vkRegisterDisplayEventEXTDelegate vkRegisterDisplayEventEXT_ptr;
		public static VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence)
			=> vkRegisterDisplayEventEXT_ptr(device, display, pDisplayEventInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainCounterEXTDelegate(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue);
		private static vkGetSwapchainCounterEXTDelegate vkGetSwapchainCounterEXT_ptr;
		public static VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue)
			=> vkGetSwapchainCounterEXT_ptr(device, swapchain, counter, pCounterValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr(physicalDevice, surface, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumeratePhysicalDeviceGroupsDelegate(VkInstance instance, uint* pPhysicalDeviceGroupCount, IntPtr pPhysicalDeviceGroupProperties);
		private static vkEnumeratePhysicalDeviceGroupsDelegate vkEnumeratePhysicalDeviceGroups_ptr;
		public static VkResult vkEnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, IntPtr pPhysicalDeviceGroupProperties)
			=> vkEnumeratePhysicalDeviceGroups_ptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceGroupPeerMemoryFeaturesDelegate(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, IntPtr pPeerMemoryFeatures);
		private static vkGetDeviceGroupPeerMemoryFeaturesDelegate vkGetDeviceGroupPeerMemoryFeatures_ptr;
		public static void vkGetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, IntPtr pPeerMemoryFeatures)
			=> vkGetDeviceGroupPeerMemoryFeatures_ptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindBufferMemory2Delegate(VkDevice device, uint bindInfoCount, IntPtr pBindInfos);
		private static vkBindBufferMemory2Delegate vkBindBufferMemory2_ptr;
		public static VkResult vkBindBufferMemory2(VkDevice device, uint bindInfoCount, IntPtr pBindInfos)
			=> vkBindBufferMemory2_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindImageMemory2Delegate(VkDevice device, uint bindInfoCount, IntPtr pBindInfos);
		private static vkBindImageMemory2Delegate vkBindImageMemory2_ptr;
		public static VkResult vkBindImageMemory2(VkDevice device, uint bindInfoCount, IntPtr pBindInfos)
			=> vkBindImageMemory2_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDeviceMaskDelegate(VkCommandBuffer commandBuffer, uint deviceMask);
		private static vkCmdSetDeviceMaskDelegate vkCmdSetDeviceMask_ptr;
		public static void vkCmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
			=> vkCmdSetDeviceMask_ptr(commandBuffer, deviceMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDeviceGroupPresentCapabilitiesKHRDelegate(VkDevice device, IntPtr pDeviceGroupPresentCapabilities);
		private static vkGetDeviceGroupPresentCapabilitiesKHRDelegate vkGetDeviceGroupPresentCapabilitiesKHR_ptr;
		public static VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, IntPtr pDeviceGroupPresentCapabilities)
			=> vkGetDeviceGroupPresentCapabilitiesKHR_ptr(device, pDeviceGroupPresentCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDeviceGroupSurfacePresentModesKHRDelegate(VkDevice device, VkSurfaceKHR surface, IntPtr pModes);
		private static vkGetDeviceGroupSurfacePresentModesKHRDelegate vkGetDeviceGroupSurfacePresentModesKHR_ptr;
		public static VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, IntPtr pModes)
			=> vkGetDeviceGroupSurfacePresentModesKHR_ptr(device, surface, pModes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireNextImage2KHRDelegate(VkDevice device, IntPtr pAcquireInfo, uint* pImageIndex);
		private static vkAcquireNextImage2KHRDelegate vkAcquireNextImage2KHR_ptr;
		public static VkResult vkAcquireNextImage2KHR(VkDevice device, IntPtr pAcquireInfo, uint* pImageIndex)
			=> vkAcquireNextImage2KHR_ptr(device, pAcquireInfo, pImageIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDispatchBaseDelegate(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
		private static vkCmdDispatchBaseDelegate vkCmdDispatchBase_ptr;
		public static void vkCmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
			=> vkCmdDispatchBase_ptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDevicePresentRectanglesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, IntPtr pRects);
		private static vkGetPhysicalDevicePresentRectanglesKHRDelegate vkGetPhysicalDevicePresentRectanglesKHR_ptr;
		public static VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, IntPtr pRects)
			=> vkGetPhysicalDevicePresentRectanglesKHR_ptr(physicalDevice, surface, pRectCount, pRects);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDescriptorUpdateTemplateDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDescriptorUpdateTemplate);
		private static vkCreateDescriptorUpdateTemplateDelegate vkCreateDescriptorUpdateTemplate_ptr;
		public static VkResult vkCreateDescriptorUpdateTemplate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDescriptorUpdateTemplate)
			=> vkCreateDescriptorUpdateTemplate_ptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDescriptorUpdateTemplateDelegate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr pAllocator);
		private static vkDestroyDescriptorUpdateTemplateDelegate vkDestroyDescriptorUpdateTemplate_ptr;
		public static void vkDestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr pAllocator)
			=> vkDestroyDescriptorUpdateTemplate_ptr(device, descriptorUpdateTemplate, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUpdateDescriptorSetWithTemplateDelegate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
		private static vkUpdateDescriptorSetWithTemplateDelegate vkUpdateDescriptorSetWithTemplate_ptr;
		public static void vkUpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
			=> vkUpdateDescriptorSetWithTemplate_ptr(device, descriptorSet, descriptorUpdateTemplate, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPushDescriptorSetWithTemplateKHRDelegate(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData);
		private static vkCmdPushDescriptorSetWithTemplateKHRDelegate vkCmdPushDescriptorSetWithTemplateKHR_ptr;
		public static void vkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
			=> vkCmdPushDescriptorSetWithTemplateKHR_ptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSetHdrMetadataEXTDelegate(VkDevice device, uint swapchainCount, IntPtr pSwapchains, IntPtr pMetadata);
		private static vkSetHdrMetadataEXTDelegate vkSetHdrMetadataEXT_ptr;
		public static void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, IntPtr pSwapchains, IntPtr pMetadata)
			=> vkSetHdrMetadataEXT_ptr(device, swapchainCount, pSwapchains, pMetadata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainStatusKHRDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkGetSwapchainStatusKHRDelegate vkGetSwapchainStatusKHR_ptr;
		public static VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
			=> vkGetSwapchainStatusKHR_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetRefreshCycleDurationGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, IntPtr pDisplayTimingProperties);
		private static vkGetRefreshCycleDurationGOOGLEDelegate vkGetRefreshCycleDurationGOOGLE_ptr;
		public static VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, IntPtr pDisplayTimingProperties)
			=> vkGetRefreshCycleDurationGOOGLE_ptr(device, swapchain, pDisplayTimingProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPastPresentationTimingGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, IntPtr pPresentationTimings);
		private static vkGetPastPresentationTimingGOOGLEDelegate vkGetPastPresentationTimingGOOGLE_ptr;
		public static VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, IntPtr pPresentationTimings)
			=> vkGetPastPresentationTimingGOOGLE_ptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateIOSSurfaceMVKDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateIOSSurfaceMVKDelegate vkCreateIOSSurfaceMVK_ptr;
		public static VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateIOSSurfaceMVK_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateMacOSSurfaceMVKDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateMacOSSurfaceMVKDelegate vkCreateMacOSSurfaceMVK_ptr;
		public static VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateMacOSSurfaceMVK_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateMetalSurfaceEXTDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateMetalSurfaceEXTDelegate vkCreateMetalSurfaceEXT_ptr;
		public static VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateMetalSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportWScalingNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewportWScalings);
		private static vkCmdSetViewportWScalingNVDelegate vkCmdSetViewportWScalingNV_ptr;
		public static void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewportWScalings)
			=> vkCmdSetViewportWScalingNV_ptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDiscardRectangleEXTDelegate(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, IntPtr pDiscardRectangles);
		private static vkCmdSetDiscardRectangleEXTDelegate vkCmdSetDiscardRectangleEXT_ptr;
		public static void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, IntPtr pDiscardRectangles)
			=> vkCmdSetDiscardRectangleEXT_ptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetSampleLocationsEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pSampleLocationsInfo);
		private static vkCmdSetSampleLocationsEXTDelegate vkCmdSetSampleLocationsEXT_ptr;
		public static void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, IntPtr pSampleLocationsInfo)
			=> vkCmdSetSampleLocationsEXT_ptr(commandBuffer, pSampleLocationsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, IntPtr pMultisampleProperties);
		private static vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr;
		public static void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, IntPtr pMultisampleProperties)
			=> vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr(physicalDevice, samples, pMultisampleProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceFormats2KHRDelegate(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats);
		private static vkGetPhysicalDeviceSurfaceFormats2KHRDelegate vkGetPhysicalDeviceSurfaceFormats2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats)
			=> vkGetPhysicalDeviceSurfaceFormats2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayProperties2KHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceDisplayProperties2KHRDelegate vkGetPhysicalDeviceDisplayProperties2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceDisplayProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayModeProperties2KHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetDisplayModeProperties2KHRDelegate vkGetDisplayModeProperties2KHR_ptr;
		public static VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetDisplayModeProperties2KHR_ptr(physicalDevice, display, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayPlaneCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, IntPtr pDisplayPlaneInfo, IntPtr pCapabilities);
		private static vkGetDisplayPlaneCapabilities2KHRDelegate vkGetDisplayPlaneCapabilities2KHR_ptr;
		public static VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pDisplayPlaneInfo, IntPtr pCapabilities)
			=> vkGetDisplayPlaneCapabilities2KHR_ptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetBufferMemoryRequirements2Delegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetBufferMemoryRequirements2Delegate vkGetBufferMemoryRequirements2_ptr;
		public static void vkGetBufferMemoryRequirements2(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetBufferMemoryRequirements2_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageMemoryRequirements2Delegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetImageMemoryRequirements2Delegate vkGetImageMemoryRequirements2_ptr;
		public static void vkGetImageMemoryRequirements2(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetImageMemoryRequirements2_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSparseMemoryRequirements2Delegate(VkDevice device, IntPtr pInfo, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements);
		private static vkGetImageSparseMemoryRequirements2Delegate vkGetImageSparseMemoryRequirements2_ptr;
		public static void vkGetImageSparseMemoryRequirements2(VkDevice device, IntPtr pInfo, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements)
			=> vkGetImageSparseMemoryRequirements2_ptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSamplerYcbcrConversionDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pYcbcrConversion);
		private static vkCreateSamplerYcbcrConversionDelegate vkCreateSamplerYcbcrConversion_ptr;
		public static VkResult vkCreateSamplerYcbcrConversion(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pYcbcrConversion)
			=> vkCreateSamplerYcbcrConversion_ptr(device, pCreateInfo, pAllocator, pYcbcrConversion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySamplerYcbcrConversionDelegate(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, IntPtr pAllocator);
		private static vkDestroySamplerYcbcrConversionDelegate vkDestroySamplerYcbcrConversion_ptr;
		public static void vkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, IntPtr pAllocator)
			=> vkDestroySamplerYcbcrConversion_ptr(device, ycbcrConversion, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceQueue2Delegate(VkDevice device, IntPtr pQueueInfo, IntPtr pQueue);
		private static vkGetDeviceQueue2Delegate vkGetDeviceQueue2_ptr;
		public static void vkGetDeviceQueue2(VkDevice device, IntPtr pQueueInfo, IntPtr pQueue)
			=> vkGetDeviceQueue2_ptr(device, pQueueInfo, pQueue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateValidationCacheEXTDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pValidationCache);
		private static vkCreateValidationCacheEXTDelegate vkCreateValidationCacheEXT_ptr;
		public static VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pValidationCache)
			=> vkCreateValidationCacheEXT_ptr(device, pCreateInfo, pAllocator, pValidationCache);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyValidationCacheEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, IntPtr pAllocator);
		private static vkDestroyValidationCacheEXTDelegate vkDestroyValidationCacheEXT_ptr;
		public static void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, IntPtr pAllocator)
			=> vkDestroyValidationCacheEXT_ptr(device, validationCache, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetValidationCacheDataEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData);
		private static vkGetValidationCacheDataEXTDelegate vkGetValidationCacheDataEXT_ptr;
		public static VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData)
			=> vkGetValidationCacheDataEXT_ptr(device, validationCache, pDataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkMergeValidationCachesEXTDelegate(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, IntPtr pSrcCaches);
		private static vkMergeValidationCachesEXTDelegate vkMergeValidationCachesEXT_ptr;
		public static VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, IntPtr pSrcCaches)
			=> vkMergeValidationCachesEXT_ptr(device, dstCache, srcCacheCount, pSrcCaches);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDescriptorSetLayoutSupportDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pSupport);
		private static vkGetDescriptorSetLayoutSupportDelegate vkGetDescriptorSetLayoutSupport_ptr;
		public static void vkGetDescriptorSetLayoutSupport(VkDevice device, IntPtr pCreateInfo, IntPtr pSupport)
			=> vkGetDescriptorSetLayoutSupport_ptr(device, pCreateInfo, pSupport);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainGrallocUsageANDROIDDelegate(VkDevice device, VkFormat format, uint imageUsage, IntPtr grallocUsage);
		private static vkGetSwapchainGrallocUsageANDROIDDelegate vkGetSwapchainGrallocUsageANDROID_ptr;
		public static VkResult vkGetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, uint imageUsage, IntPtr grallocUsage)
			=> vkGetSwapchainGrallocUsageANDROID_ptr(device, format, imageUsage, grallocUsage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainGrallocUsage2ANDROIDDelegate(VkDevice device, VkFormat format, uint imageUsage, uint swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage);
		private static vkGetSwapchainGrallocUsage2ANDROIDDelegate vkGetSwapchainGrallocUsage2ANDROID_ptr;
		public static VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, uint imageUsage, uint swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage)
			=> vkGetSwapchainGrallocUsage2ANDROID_ptr(device, format, imageUsage, swapchainImageUsage, grallocConsumerUsage, grallocProducerUsage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireImageANDROIDDelegate(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence);
		private static vkAcquireImageANDROIDDelegate vkAcquireImageANDROID_ptr;
		public static VkResult vkAcquireImageANDROID(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
			=> vkAcquireImageANDROID_ptr(device, image, nativeFenceFd, semaphore, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueSignalReleaseImageANDROIDDelegate(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd);
		private static vkQueueSignalReleaseImageANDROIDDelegate vkQueueSignalReleaseImageANDROID_ptr;
		public static VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd)
			=> vkQueueSignalReleaseImageANDROID_ptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetShaderInfoAMDDelegate(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo);
		private static vkGetShaderInfoAMDDelegate vkGetShaderInfoAMD_ptr;
		public static VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo)
			=> vkGetShaderInfoAMD_ptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSetLocalDimmingAMDDelegate(VkDevice device, VkSwapchainKHR swapChain, uint localDimmingEnable);
		private static vkSetLocalDimmingAMDDelegate vkSetLocalDimmingAMD_ptr;
		public static void vkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, uint localDimmingEnable)
			=> vkSetLocalDimmingAMD_ptr(device, swapChain, localDimmingEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, IntPtr pTimeDomains);
		private static vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr;
		public static VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, IntPtr pTimeDomains)
			=> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr(physicalDevice, pTimeDomainCount, pTimeDomains);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetCalibratedTimestampsEXTDelegate(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation);
		private static vkGetCalibratedTimestampsEXTDelegate vkGetCalibratedTimestampsEXT_ptr;
		public static VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
			=> vkGetCalibratedTimestampsEXT_ptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetDebugUtilsObjectNameEXTDelegate(VkDevice device, IntPtr pNameInfo);
		private static vkSetDebugUtilsObjectNameEXTDelegate vkSetDebugUtilsObjectNameEXT_ptr;
		public static VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, IntPtr pNameInfo)
			=> vkSetDebugUtilsObjectNameEXT_ptr(device, pNameInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetDebugUtilsObjectTagEXTDelegate(VkDevice device, IntPtr pTagInfo);
		private static vkSetDebugUtilsObjectTagEXTDelegate vkSetDebugUtilsObjectTagEXT_ptr;
		public static VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, IntPtr pTagInfo)
			=> vkSetDebugUtilsObjectTagEXT_ptr(device, pTagInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkQueueBeginDebugUtilsLabelEXTDelegate(VkQueue queue, IntPtr pLabelInfo);
		private static vkQueueBeginDebugUtilsLabelEXTDelegate vkQueueBeginDebugUtilsLabelEXT_ptr;
		public static void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, IntPtr pLabelInfo)
			=> vkQueueBeginDebugUtilsLabelEXT_ptr(queue, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkQueueEndDebugUtilsLabelEXTDelegate(VkQueue queue);
		private static vkQueueEndDebugUtilsLabelEXTDelegate vkQueueEndDebugUtilsLabelEXT_ptr;
		public static void vkQueueEndDebugUtilsLabelEXT(VkQueue queue)
			=> vkQueueEndDebugUtilsLabelEXT_ptr(queue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkQueueInsertDebugUtilsLabelEXTDelegate(VkQueue queue, IntPtr pLabelInfo);
		private static vkQueueInsertDebugUtilsLabelEXTDelegate vkQueueInsertDebugUtilsLabelEXT_ptr;
		public static void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, IntPtr pLabelInfo)
			=> vkQueueInsertDebugUtilsLabelEXT_ptr(queue, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pLabelInfo);
		private static vkCmdBeginDebugUtilsLabelEXTDelegate vkCmdBeginDebugUtilsLabelEXT_ptr;
		public static void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, IntPtr pLabelInfo)
			=> vkCmdBeginDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndDebugUtilsLabelEXTDelegate vkCmdEndDebugUtilsLabelEXT_ptr;
		public static void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
			=> vkCmdEndDebugUtilsLabelEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdInsertDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pLabelInfo);
		private static vkCmdInsertDebugUtilsLabelEXTDelegate vkCmdInsertDebugUtilsLabelEXT_ptr;
		public static void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, IntPtr pLabelInfo)
			=> vkCmdInsertDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDebugUtilsMessengerEXTDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pMessenger);
		private static vkCreateDebugUtilsMessengerEXTDelegate vkCreateDebugUtilsMessengerEXT_ptr;
		public static VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pMessenger)
			=> vkCreateDebugUtilsMessengerEXT_ptr(instance, pCreateInfo, pAllocator, pMessenger);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDebugUtilsMessengerEXTDelegate(VkInstance instance, VkDebugUtilsMessengerEXT messenger, IntPtr pAllocator);
		private static vkDestroyDebugUtilsMessengerEXTDelegate vkDestroyDebugUtilsMessengerEXT_ptr;
		public static void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, IntPtr pAllocator)
			=> vkDestroyDebugUtilsMessengerEXT_ptr(instance, messenger, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSubmitDebugUtilsMessageEXTDelegate(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, uint messageTypes, IntPtr pCallbackData);
		private static vkSubmitDebugUtilsMessageEXTDelegate vkSubmitDebugUtilsMessageEXT_ptr;
		public static void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, uint messageTypes, IntPtr pCallbackData)
			=> vkSubmitDebugUtilsMessageEXT_ptr(instance, messageSeverity, messageTypes, pCallbackData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryHostPointerPropertiesEXTDelegate(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, IntPtr pMemoryHostPointerProperties);
		private static vkGetMemoryHostPointerPropertiesEXTDelegate vkGetMemoryHostPointerPropertiesEXT_ptr;
		public static VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, IntPtr pMemoryHostPointerProperties)
			=> vkGetMemoryHostPointerPropertiesEXT_ptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteBufferMarkerAMDDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker);
		private static vkCmdWriteBufferMarkerAMDDelegate vkCmdWriteBufferMarkerAMD_ptr;
		public static void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
			=> vkCmdWriteBufferMarkerAMD_ptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRenderPass2Delegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pRenderPass);
		private static vkCreateRenderPass2Delegate vkCreateRenderPass2_ptr;
		public static VkResult vkCreateRenderPass2(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pRenderPass)
			=> vkCreateRenderPass2_ptr(device, pCreateInfo, pAllocator, pRenderPass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginRenderPass2Delegate(VkCommandBuffer commandBuffer, IntPtr pRenderPassBegin, IntPtr pSubpassBeginInfo);
		private static vkCmdBeginRenderPass2Delegate vkCmdBeginRenderPass2_ptr;
		public static void vkCmdBeginRenderPass2(VkCommandBuffer commandBuffer, IntPtr pRenderPassBegin, IntPtr pSubpassBeginInfo)
			=> vkCmdBeginRenderPass2_ptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdNextSubpass2Delegate(VkCommandBuffer commandBuffer, IntPtr pSubpassBeginInfo, IntPtr pSubpassEndInfo);
		private static vkCmdNextSubpass2Delegate vkCmdNextSubpass2_ptr;
		public static void vkCmdNextSubpass2(VkCommandBuffer commandBuffer, IntPtr pSubpassBeginInfo, IntPtr pSubpassEndInfo)
			=> vkCmdNextSubpass2_ptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndRenderPass2Delegate(VkCommandBuffer commandBuffer, IntPtr pSubpassEndInfo);
		private static vkCmdEndRenderPass2Delegate vkCmdEndRenderPass2_ptr;
		public static void vkCmdEndRenderPass2(VkCommandBuffer commandBuffer, IntPtr pSubpassEndInfo)
			=> vkCmdEndRenderPass2_ptr(commandBuffer, pSubpassEndInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreCounterValueDelegate(VkDevice device, VkSemaphore semaphore, ulong* pValue);
		private static vkGetSemaphoreCounterValueDelegate vkGetSemaphoreCounterValue_ptr;
		public static VkResult vkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
			=> vkGetSemaphoreCounterValue_ptr(device, semaphore, pValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWaitSemaphoresDelegate(VkDevice device, IntPtr pWaitInfo, ulong timeout);
		private static vkWaitSemaphoresDelegate vkWaitSemaphores_ptr;
		public static VkResult vkWaitSemaphores(VkDevice device, IntPtr pWaitInfo, ulong timeout)
			=> vkWaitSemaphores_ptr(device, pWaitInfo, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSignalSemaphoreDelegate(VkDevice device, IntPtr pSignalInfo);
		private static vkSignalSemaphoreDelegate vkSignalSemaphore_ptr;
		public static VkResult vkSignalSemaphore(VkDevice device, IntPtr pSignalInfo)
			=> vkSignalSemaphore_ptr(device, pSignalInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetAndroidHardwareBufferPropertiesANDROIDDelegate(VkDevice device, IntPtr buffer, IntPtr pProperties);
		private static vkGetAndroidHardwareBufferPropertiesANDROIDDelegate vkGetAndroidHardwareBufferPropertiesANDROID_ptr;
		public static VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, IntPtr pProperties)
			=> vkGetAndroidHardwareBufferPropertiesANDROID_ptr(device, buffer, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryAndroidHardwareBufferANDROIDDelegate(VkDevice device, IntPtr pInfo, IntPtr pBuffer);
		private static vkGetMemoryAndroidHardwareBufferANDROIDDelegate vkGetMemoryAndroidHardwareBufferANDROID_ptr;
		public static VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, IntPtr pInfo, IntPtr pBuffer)
			=> vkGetMemoryAndroidHardwareBufferANDROID_ptr(device, pInfo, pBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndirectCountDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawIndirectCountDelegate vkCmdDrawIndirectCount_ptr;
		public static void vkCmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawIndirectCount_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndexedIndirectCountDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawIndexedIndirectCountDelegate vkCmdDrawIndexedIndirectCount_ptr;
		public static void vkCmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawIndexedIndirectCount_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCheckpointNVDelegate(VkCommandBuffer commandBuffer, void* pCheckpointMarker);
		private static vkCmdSetCheckpointNVDelegate vkCmdSetCheckpointNV_ptr;
		public static void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
			=> vkCmdSetCheckpointNV_ptr(commandBuffer, pCheckpointMarker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetQueueCheckpointDataNVDelegate(VkQueue queue, uint* pCheckpointDataCount, IntPtr pCheckpointData);
		private static vkGetQueueCheckpointDataNVDelegate vkGetQueueCheckpointDataNV_ptr;
		public static void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, IntPtr pCheckpointData)
			=> vkGetQueueCheckpointDataNV_ptr(queue, pCheckpointDataCount, pCheckpointData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindTransformFeedbackBuffersEXTDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, IntPtr pSizes);
		private static vkCmdBindTransformFeedbackBuffersEXTDelegate vkCmdBindTransformFeedbackBuffersEXT_ptr;
		public static void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, IntPtr pSizes)
			=> vkCmdBindTransformFeedbackBuffersEXT_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets);
		private static vkCmdBeginTransformFeedbackEXTDelegate vkCmdBeginTransformFeedbackEXT_ptr;
		public static void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets)
			=> vkCmdBeginTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets);
		private static vkCmdEndTransformFeedbackEXTDelegate vkCmdEndTransformFeedbackEXT_ptr;
		public static void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets)
			=> vkCmdEndTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginQueryIndexedEXTDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint flags, uint index);
		private static vkCmdBeginQueryIndexedEXTDelegate vkCmdBeginQueryIndexedEXT_ptr;
		public static void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint flags, uint index)
			=> vkCmdBeginQueryIndexedEXT_ptr(commandBuffer, queryPool, query, flags, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndQueryIndexedEXTDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index);
		private static vkCmdEndQueryIndexedEXTDelegate vkCmdEndQueryIndexedEXT_ptr;
		public static void vkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
			=> vkCmdEndQueryIndexedEXT_ptr(commandBuffer, queryPool, query, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawIndirectByteCountEXTDelegate(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride);
		private static vkCmdDrawIndirectByteCountEXTDelegate vkCmdDrawIndirectByteCountEXT_ptr;
		public static void vkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
			=> vkCmdDrawIndirectByteCountEXT_ptr(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetExclusiveScissorNVDelegate(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, IntPtr pExclusiveScissors);
		private static vkCmdSetExclusiveScissorNVDelegate vkCmdSetExclusiveScissorNV_ptr;
		public static void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, IntPtr pExclusiveScissors)
			=> vkCmdSetExclusiveScissorNV_ptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindShadingRateImageNVDelegate(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
		private static vkCmdBindShadingRateImageNVDelegate vkCmdBindShadingRateImageNV_ptr;
		public static void vkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
			=> vkCmdBindShadingRateImageNV_ptr(commandBuffer, imageView, imageLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportShadingRatePaletteNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pShadingRatePalettes);
		private static vkCmdSetViewportShadingRatePaletteNVDelegate vkCmdSetViewportShadingRatePaletteNV_ptr;
		public static void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pShadingRatePalettes)
			=> vkCmdSetViewportShadingRatePaletteNV_ptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCoarseSampleOrderNVDelegate(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, IntPtr pCustomSampleOrders);
		private static vkCmdSetCoarseSampleOrderNVDelegate vkCmdSetCoarseSampleOrderNV_ptr;
		public static void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, IntPtr pCustomSampleOrders)
			=> vkCmdSetCoarseSampleOrderNV_ptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMeshTasksNVDelegate(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask);
		private static vkCmdDrawMeshTasksNVDelegate vkCmdDrawMeshTasksNV_ptr;
		public static void vkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
			=> vkCmdDrawMeshTasksNV_ptr(commandBuffer, taskCount, firstTask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMeshTasksIndirectNVDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawMeshTasksIndirectNVDelegate vkCmdDrawMeshTasksIndirectNV_ptr;
		public static void vkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawMeshTasksIndirectNV_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMeshTasksIndirectCountNVDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawMeshTasksIndirectCountNVDelegate vkCmdDrawMeshTasksIndirectCountNV_ptr;
		public static void vkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawMeshTasksIndirectCountNV_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCompileDeferredNVDelegate(VkDevice device, VkPipeline pipeline, uint shader);
		private static vkCompileDeferredNVDelegate vkCompileDeferredNV_ptr;
		public static VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
			=> vkCompileDeferredNV_ptr(device, pipeline, shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateAccelerationStructureNVDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pAccelerationStructure);
		private static vkCreateAccelerationStructureNVDelegate vkCreateAccelerationStructureNV_ptr;
		public static VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pAccelerationStructure)
			=> vkCreateAccelerationStructureNV_ptr(device, pCreateInfo, pAllocator, pAccelerationStructure);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyAccelerationStructureKHRDelegate(VkDevice device, VkAccelerationStructureKHR accelerationStructure, IntPtr pAllocator);
		private static vkDestroyAccelerationStructureKHRDelegate vkDestroyAccelerationStructureKHR_ptr;
		public static void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, IntPtr pAllocator)
			=> vkDestroyAccelerationStructureKHR_ptr(device, accelerationStructure, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetAccelerationStructureMemoryRequirementsKHRDelegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetAccelerationStructureMemoryRequirementsKHRDelegate vkGetAccelerationStructureMemoryRequirementsKHR_ptr;
		public static void vkGetAccelerationStructureMemoryRequirementsKHR(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetAccelerationStructureMemoryRequirementsKHR_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetAccelerationStructureMemoryRequirementsNVDelegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetAccelerationStructureMemoryRequirementsNVDelegate vkGetAccelerationStructureMemoryRequirementsNV_ptr;
		public static void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetAccelerationStructureMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindAccelerationStructureMemoryKHRDelegate(VkDevice device, uint bindInfoCount, IntPtr pBindInfos);
		private static vkBindAccelerationStructureMemoryKHRDelegate vkBindAccelerationStructureMemoryKHR_ptr;
		public static VkResult vkBindAccelerationStructureMemoryKHR(VkDevice device, uint bindInfoCount, IntPtr pBindInfos)
			=> vkBindAccelerationStructureMemoryKHR_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, VkAccelerationStructureKHR dst, VkAccelerationStructureKHR src, VkCopyAccelerationStructureModeKHR mode);
		private static vkCmdCopyAccelerationStructureNVDelegate vkCmdCopyAccelerationStructureNV_ptr;
		public static void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureKHR dst, VkAccelerationStructureKHR src, VkCopyAccelerationStructureModeKHR mode)
			=> vkCmdCopyAccelerationStructureNV_ptr(commandBuffer, dst, src, mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo);
		private static vkCmdCopyAccelerationStructureKHRDelegate vkCmdCopyAccelerationStructureKHR_ptr;
		public static void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
			=> vkCmdCopyAccelerationStructureKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyAccelerationStructureKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkCopyAccelerationStructureKHRDelegate vkCopyAccelerationStructureKHR_ptr;
		public static VkResult vkCopyAccelerationStructureKHR(VkDevice device, IntPtr pInfo)
			=> vkCopyAccelerationStructureKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyAccelerationStructureToMemoryKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo);
		private static vkCmdCopyAccelerationStructureToMemoryKHRDelegate vkCmdCopyAccelerationStructureToMemoryKHR_ptr;
		public static void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
			=> vkCmdCopyAccelerationStructureToMemoryKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyAccelerationStructureToMemoryKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkCopyAccelerationStructureToMemoryKHRDelegate vkCopyAccelerationStructureToMemoryKHR_ptr;
		public static VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, IntPtr pInfo)
			=> vkCopyAccelerationStructureToMemoryKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyMemoryToAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo);
		private static vkCmdCopyMemoryToAccelerationStructureKHRDelegate vkCmdCopyMemoryToAccelerationStructureKHR_ptr;
		public static void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
			=> vkCmdCopyMemoryToAccelerationStructureKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyMemoryToAccelerationStructureKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkCopyMemoryToAccelerationStructureKHRDelegate vkCopyMemoryToAccelerationStructureKHR_ptr;
		public static VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, IntPtr pInfo)
			=> vkCopyMemoryToAccelerationStructureKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteAccelerationStructuresPropertiesKHRDelegate(VkCommandBuffer commandBuffer, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
		private static vkCmdWriteAccelerationStructuresPropertiesKHRDelegate vkCmdWriteAccelerationStructuresPropertiesKHR_ptr;
		public static void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
			=> vkCmdWriteAccelerationStructuresPropertiesKHR_ptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer instanceData, ulong instanceOffset, uint update, VkAccelerationStructureKHR dst, VkAccelerationStructureKHR src, VkBuffer scratch, ulong scratchOffset);
		private static vkCmdBuildAccelerationStructureNVDelegate vkCmdBuildAccelerationStructureNV_ptr;
		public static void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer instanceData, ulong instanceOffset, uint update, VkAccelerationStructureKHR dst, VkAccelerationStructureKHR src, VkBuffer scratch, ulong scratchOffset)
			=> vkCmdBuildAccelerationStructureNV_ptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWriteAccelerationStructuresPropertiesKHRDelegate(VkDevice device, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride);
		private static vkWriteAccelerationStructuresPropertiesKHRDelegate vkWriteAccelerationStructuresPropertiesKHR_ptr;
		public static VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
			=> vkWriteAccelerationStructuresPropertiesKHR_ptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdTraceRaysKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth);
		private static vkCmdTraceRaysKHRDelegate vkCmdTraceRaysKHR_ptr;
		public static void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
			=> vkCmdTraceRaysKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdTraceRaysNVDelegate(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth);
		private static vkCmdTraceRaysNVDelegate vkCmdTraceRaysNV_ptr;
		public static void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
			=> vkCmdTraceRaysNV_ptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetRayTracingShaderGroupHandlesKHRDelegate(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData);
		private static vkGetRayTracingShaderGroupHandlesKHRDelegate vkGetRayTracingShaderGroupHandlesKHR_ptr;
		public static VkResult vkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
			=> vkGetRayTracingShaderGroupHandlesKHR_ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData);
		private static vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr;
		public static VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
			=> vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetAccelerationStructureHandleNVDelegate(VkDevice device, VkAccelerationStructureKHR accelerationStructure, UIntPtr dataSize, void* pData);
		private static vkGetAccelerationStructureHandleNVDelegate vkGetAccelerationStructureHandleNV_ptr;
		public static VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureKHR accelerationStructure, UIntPtr dataSize, void* pData)
			=> vkGetAccelerationStructureHandleNV_ptr(device, accelerationStructure, dataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRayTracingPipelinesNVDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines);
		private static vkCreateRayTracingPipelinesNVDelegate vkCreateRayTracingPipelinesNV_ptr;
		public static VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines)
			=> vkCreateRayTracingPipelinesNV_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRayTracingPipelinesKHRDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines);
		private static vkCreateRayTracingPipelinesKHRDelegate vkCreateRayTracingPipelinesKHR_ptr;
		public static VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines)
			=> vkCreateRayTracingPipelinesKHR_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr;
		public static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdTraceRaysIndirectKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, VkBuffer buffer, ulong offset);
		private static vkCmdTraceRaysIndirectKHRDelegate vkCmdTraceRaysIndirectKHR_ptr;
		public static void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, VkBuffer buffer, ulong offset)
			=> vkCmdTraceRaysIndirectKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, buffer, offset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDeviceAccelerationStructureCompatibilityKHRDelegate(VkDevice device, IntPtr version);
		private static vkGetDeviceAccelerationStructureCompatibilityKHRDelegate vkGetDeviceAccelerationStructureCompatibilityKHR_ptr;
		public static VkResult vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, IntPtr version)
			=> vkGetDeviceAccelerationStructureCompatibilityKHR_ptr(device, version);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint vkGetImageViewHandleNVXDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetImageViewHandleNVXDelegate vkGetImageViewHandleNVX_ptr;
		public static uint vkGetImageViewHandleNVX(VkDevice device, IntPtr pInfo)
			=> vkGetImageViewHandleNVX_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetImageViewAddressNVXDelegate(VkDevice device, VkImageView imageView, IntPtr pProperties);
		private static vkGetImageViewAddressNVXDelegate vkGetImageViewAddressNVX_ptr;
		public static VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, IntPtr pProperties)
			=> vkGetImageViewAddressNVX_ptr(device, imageView, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pPresentModeCount, IntPtr pPresentModes);
		private static vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr;
		public static VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pPresentModeCount, IntPtr pPresentModes)
			=> vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDeviceGroupSurfacePresentModes2EXTDelegate(VkDevice device, IntPtr pSurfaceInfo, IntPtr pModes);
		private static vkGetDeviceGroupSurfacePresentModes2EXTDelegate vkGetDeviceGroupSurfacePresentModes2EXT_ptr;
		public static VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, IntPtr pSurfaceInfo, IntPtr pModes)
			=> vkGetDeviceGroupSurfacePresentModes2EXT_ptr(device, pSurfaceInfo, pModes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireFullScreenExclusiveModeEXTDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkAcquireFullScreenExclusiveModeEXTDelegate vkAcquireFullScreenExclusiveModeEXT_ptr;
		public static VkResult vkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
			=> vkAcquireFullScreenExclusiveModeEXT_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkReleaseFullScreenExclusiveModeEXTDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkReleaseFullScreenExclusiveModeEXTDelegate vkReleaseFullScreenExclusiveModeEXT_ptr;
		public static VkResult vkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
			=> vkReleaseFullScreenExclusiveModeEXT_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions);
		private static vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr;
		public static VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions)
			=> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate(VkPhysicalDevice physicalDevice, IntPtr pPerformanceQueryCreateInfo, uint* pNumPasses);
		private static vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, IntPtr pPerformanceQueryCreateInfo, uint* pNumPasses)
			=> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireProfilingLockKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkAcquireProfilingLockKHRDelegate vkAcquireProfilingLockKHR_ptr;
		public static VkResult vkAcquireProfilingLockKHR(VkDevice device, IntPtr pInfo)
			=> vkAcquireProfilingLockKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkReleaseProfilingLockKHRDelegate(VkDevice device);
		private static vkReleaseProfilingLockKHRDelegate vkReleaseProfilingLockKHR_ptr;
		public static void vkReleaseProfilingLockKHR(VkDevice device)
			=> vkReleaseProfilingLockKHR_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetImageDrmFormatModifierPropertiesEXTDelegate(VkDevice device, VkImage image, IntPtr pProperties);
		private static vkGetImageDrmFormatModifierPropertiesEXTDelegate vkGetImageDrmFormatModifierPropertiesEXT_ptr;
		public static VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, IntPtr pProperties)
			=> vkGetImageDrmFormatModifierPropertiesEXT_ptr(device, image, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetBufferOpaqueCaptureAddressDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetBufferOpaqueCaptureAddressDelegate vkGetBufferOpaqueCaptureAddress_ptr;
		public static ulong vkGetBufferOpaqueCaptureAddress(VkDevice device, IntPtr pInfo)
			=> vkGetBufferOpaqueCaptureAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetBufferDeviceAddressDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetBufferDeviceAddressDelegate vkGetBufferDeviceAddress_ptr;
		public static ulong vkGetBufferDeviceAddress(VkDevice device, IntPtr pInfo)
			=> vkGetBufferDeviceAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateHeadlessSurfaceEXTDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateHeadlessSurfaceEXTDelegate vkCreateHeadlessSurfaceEXT_ptr;
		public static VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateHeadlessSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate(VkPhysicalDevice physicalDevice, uint* pCombinationCount, IntPtr pCombinations);
		private static vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr;
		public static VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, IntPtr pCombinations)
			=> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr(physicalDevice, pCombinationCount, pCombinations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkInitializePerformanceApiINTELDelegate(VkDevice device, IntPtr pInitializeInfo);
		private static vkInitializePerformanceApiINTELDelegate vkInitializePerformanceApiINTEL_ptr;
		public static VkResult vkInitializePerformanceApiINTEL(VkDevice device, IntPtr pInitializeInfo)
			=> vkInitializePerformanceApiINTEL_ptr(device, pInitializeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUninitializePerformanceApiINTELDelegate(VkDevice device);
		private static vkUninitializePerformanceApiINTELDelegate vkUninitializePerformanceApiINTEL_ptr;
		public static void vkUninitializePerformanceApiINTEL(VkDevice device)
			=> vkUninitializePerformanceApiINTEL_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCmdSetPerformanceMarkerINTELDelegate(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo);
		private static vkCmdSetPerformanceMarkerINTELDelegate vkCmdSetPerformanceMarkerINTEL_ptr;
		public static VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
			=> vkCmdSetPerformanceMarkerINTEL_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCmdSetPerformanceStreamMarkerINTELDelegate(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo);
		private static vkCmdSetPerformanceStreamMarkerINTELDelegate vkCmdSetPerformanceStreamMarkerINTEL_ptr;
		public static VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
			=> vkCmdSetPerformanceStreamMarkerINTEL_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCmdSetPerformanceOverrideINTELDelegate(VkCommandBuffer commandBuffer, IntPtr pOverrideInfo);
		private static vkCmdSetPerformanceOverrideINTELDelegate vkCmdSetPerformanceOverrideINTEL_ptr;
		public static VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, IntPtr pOverrideInfo)
			=> vkCmdSetPerformanceOverrideINTEL_ptr(commandBuffer, pOverrideInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquirePerformanceConfigurationINTELDelegate(VkDevice device, IntPtr pAcquireInfo, IntPtr pConfiguration);
		private static vkAcquirePerformanceConfigurationINTELDelegate vkAcquirePerformanceConfigurationINTEL_ptr;
		public static VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, IntPtr pAcquireInfo, IntPtr pConfiguration)
			=> vkAcquirePerformanceConfigurationINTEL_ptr(device, pAcquireInfo, pConfiguration);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkReleasePerformanceConfigurationINTELDelegate(VkDevice device, VkPerformanceConfigurationINTEL configuration);
		private static vkReleasePerformanceConfigurationINTELDelegate vkReleasePerformanceConfigurationINTEL_ptr;
		public static VkResult vkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
			=> vkReleasePerformanceConfigurationINTEL_ptr(device, configuration);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueSetPerformanceConfigurationINTELDelegate(VkQueue queue, VkPerformanceConfigurationINTEL configuration);
		private static vkQueueSetPerformanceConfigurationINTELDelegate vkQueueSetPerformanceConfigurationINTEL_ptr;
		public static VkResult vkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
			=> vkQueueSetPerformanceConfigurationINTEL_ptr(queue, configuration);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPerformanceParameterINTELDelegate(VkDevice device, VkPerformanceParameterTypeINTEL parameter, IntPtr pValue);
		private static vkGetPerformanceParameterINTELDelegate vkGetPerformanceParameterINTEL_ptr;
		public static VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, IntPtr pValue)
			=> vkGetPerformanceParameterINTEL_ptr(device, parameter, pValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetDeviceMemoryOpaqueCaptureAddressDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetDeviceMemoryOpaqueCaptureAddressDelegate vkGetDeviceMemoryOpaqueCaptureAddress_ptr;
		public static ulong vkGetDeviceMemoryOpaqueCaptureAddress(VkDevice device, IntPtr pInfo)
			=> vkGetDeviceMemoryOpaqueCaptureAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineExecutablePropertiesKHRDelegate(VkDevice device, IntPtr pPipelineInfo, uint* pExecutableCount, IntPtr pProperties);
		private static vkGetPipelineExecutablePropertiesKHRDelegate vkGetPipelineExecutablePropertiesKHR_ptr;
		public static VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, uint* pExecutableCount, IntPtr pProperties)
			=> vkGetPipelineExecutablePropertiesKHR_ptr(device, pPipelineInfo, pExecutableCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineExecutableStatisticsKHRDelegate(VkDevice device, IntPtr pExecutableInfo, uint* pStatisticCount, IntPtr pStatistics);
		private static vkGetPipelineExecutableStatisticsKHRDelegate vkGetPipelineExecutableStatisticsKHR_ptr;
		public static VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pStatisticCount, IntPtr pStatistics)
			=> vkGetPipelineExecutableStatisticsKHR_ptr(device, pExecutableInfo, pStatisticCount, pStatistics);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineExecutableInternalRepresentationsKHRDelegate(VkDevice device, IntPtr pExecutableInfo, uint* pInternalRepresentationCount, IntPtr pInternalRepresentations);
		private static vkGetPipelineExecutableInternalRepresentationsKHRDelegate vkGetPipelineExecutableInternalRepresentationsKHR_ptr;
		public static VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pInternalRepresentationCount, IntPtr pInternalRepresentations)
			=> vkGetPipelineExecutableInternalRepresentationsKHR_ptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLineStippleEXTDelegate(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
		private static vkCmdSetLineStippleEXTDelegate vkCmdSetLineStippleEXT_ptr;
		public static void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
			=> vkCmdSetLineStippleEXT_ptr(commandBuffer, lineStippleFactor, lineStipplePattern);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceToolPropertiesEXTDelegate(VkPhysicalDevice physicalDevice, uint* pToolCount, IntPtr pToolProperties);
		private static vkGetPhysicalDeviceToolPropertiesEXTDelegate vkGetPhysicalDeviceToolPropertiesEXT_ptr;
		public static VkResult vkGetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* pToolCount, IntPtr pToolProperties)
			=> vkGetPhysicalDeviceToolPropertiesEXT_ptr(physicalDevice, pToolCount, pToolProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateAccelerationStructureKHRDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pAccelerationStructure);
		private static vkCreateAccelerationStructureKHRDelegate vkCreateAccelerationStructureKHR_ptr;
		public static VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pAccelerationStructure)
			=> vkCreateAccelerationStructureKHR_ptr(device, pCreateInfo, pAllocator, pAccelerationStructure);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr ppOffsetInfos);
		private static vkCmdBuildAccelerationStructureKHRDelegate vkCmdBuildAccelerationStructureKHR_ptr;
		public static void vkCmdBuildAccelerationStructureKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr ppOffsetInfos)
			=> vkCmdBuildAccelerationStructureKHR_ptr(commandBuffer, infoCount, pInfos, ppOffsetInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildAccelerationStructureIndirectKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer indirectBuffer, ulong indirectOffset, uint indirectStride);
		private static vkCmdBuildAccelerationStructureIndirectKHRDelegate vkCmdBuildAccelerationStructureIndirectKHR_ptr;
		public static void vkCmdBuildAccelerationStructureIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer indirectBuffer, ulong indirectOffset, uint indirectStride)
			=> vkCmdBuildAccelerationStructureIndirectKHR_ptr(commandBuffer, pInfo, indirectBuffer, indirectOffset, indirectStride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBuildAccelerationStructureKHRDelegate(VkDevice device, uint infoCount, IntPtr pInfos, IntPtr ppOffsetInfos);
		private static vkBuildAccelerationStructureKHRDelegate vkBuildAccelerationStructureKHR_ptr;
		public static VkResult vkBuildAccelerationStructureKHR(VkDevice device, uint infoCount, IntPtr pInfos, IntPtr ppOffsetInfos)
			=> vkBuildAccelerationStructureKHR_ptr(device, infoCount, pInfos, ppOffsetInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetAccelerationStructureDeviceAddressKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetAccelerationStructureDeviceAddressKHRDelegate vkGetAccelerationStructureDeviceAddressKHR_ptr;
		public static ulong vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, IntPtr pInfo)
			=> vkGetAccelerationStructureDeviceAddressKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDeferredOperationKHRDelegate(VkDevice device, IntPtr pAllocator, IntPtr pDeferredOperation);
		private static vkCreateDeferredOperationKHRDelegate vkCreateDeferredOperationKHR_ptr;
		public static VkResult vkCreateDeferredOperationKHR(VkDevice device, IntPtr pAllocator, IntPtr pDeferredOperation)
			=> vkCreateDeferredOperationKHR_ptr(device, pAllocator, pDeferredOperation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDeferredOperationKHRDelegate(VkDevice device, VkDeferredOperationKHR operation, IntPtr pAllocator);
		private static vkDestroyDeferredOperationKHRDelegate vkDestroyDeferredOperationKHR_ptr;
		public static void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, IntPtr pAllocator)
			=> vkDestroyDeferredOperationKHR_ptr(device, operation, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint vkGetDeferredOperationMaxConcurrencyKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
		private static vkGetDeferredOperationMaxConcurrencyKHRDelegate vkGetDeferredOperationMaxConcurrencyKHR_ptr;
		public static uint vkGetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
			=> vkGetDeferredOperationMaxConcurrencyKHR_ptr(device, operation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDeferredOperationResultKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
		private static vkGetDeferredOperationResultKHRDelegate vkGetDeferredOperationResultKHR_ptr;
		public static VkResult vkGetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
			=> vkGetDeferredOperationResultKHR_ptr(device, operation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDeferredOperationJoinKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
		private static vkDeferredOperationJoinKHRDelegate vkDeferredOperationJoinKHR_ptr;
		public static VkResult vkDeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
			=> vkDeferredOperationJoinKHR_ptr(device, operation);

		private static void LoadFuncionPointers()
		{
			nativeLib.LoadFunction("vkCreateInstance",  out vkCreateInstance_ptr);
			nativeLib.LoadFunction("vkDestroyInstance",  out vkDestroyInstance_ptr);
			nativeLib.LoadFunction("vkEnumeratePhysicalDevices",  out vkEnumeratePhysicalDevices_ptr);
			nativeLib.LoadFunction("vkGetDeviceProcAddr",  out vkGetDeviceProcAddr_ptr);
			nativeLib.LoadFunction("vkGetInstanceProcAddr",  out vkGetInstanceProcAddr_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceProperties",  out vkGetPhysicalDeviceProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceQueueFamilyProperties",  out vkGetPhysicalDeviceQueueFamilyProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceMemoryProperties",  out vkGetPhysicalDeviceMemoryProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceFeatures",  out vkGetPhysicalDeviceFeatures_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceFormatProperties",  out vkGetPhysicalDeviceFormatProperties_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceImageFormatProperties",  out vkGetPhysicalDeviceImageFormatProperties_ptr);
			nativeLib.LoadFunction("vkCreateDevice",  out vkCreateDevice_ptr);
			nativeLib.LoadFunction("vkDestroyDevice",  out vkDestroyDevice_ptr);
			nativeLib.LoadFunction("vkEnumerateInstanceVersion",  out vkEnumerateInstanceVersion_ptr);
			nativeLib.LoadFunction("vkEnumerateInstanceLayerProperties",  out vkEnumerateInstanceLayerProperties_ptr);
			nativeLib.LoadFunction("vkEnumerateInstanceExtensionProperties",  out vkEnumerateInstanceExtensionProperties_ptr);
			nativeLib.LoadFunction("vkEnumerateDeviceLayerProperties",  out vkEnumerateDeviceLayerProperties_ptr);
			nativeLib.LoadFunction("vkEnumerateDeviceExtensionProperties",  out vkEnumerateDeviceExtensionProperties_ptr);
			nativeLib.LoadFunction("vkGetDeviceQueue",  out vkGetDeviceQueue_ptr);
			nativeLib.LoadFunction("vkQueueSubmit",  out vkQueueSubmit_ptr);
			nativeLib.LoadFunction("vkQueueWaitIdle",  out vkQueueWaitIdle_ptr);
			nativeLib.LoadFunction("vkDeviceWaitIdle",  out vkDeviceWaitIdle_ptr);
			nativeLib.LoadFunction("vkAllocateMemory",  out vkAllocateMemory_ptr);
			nativeLib.LoadFunction("vkFreeMemory",  out vkFreeMemory_ptr);
			nativeLib.LoadFunction("vkMapMemory",  out vkMapMemory_ptr);
			nativeLib.LoadFunction("vkUnmapMemory",  out vkUnmapMemory_ptr);
			nativeLib.LoadFunction("vkFlushMappedMemoryRanges",  out vkFlushMappedMemoryRanges_ptr);
			nativeLib.LoadFunction("vkInvalidateMappedMemoryRanges",  out vkInvalidateMappedMemoryRanges_ptr);
			nativeLib.LoadFunction("vkGetDeviceMemoryCommitment",  out vkGetDeviceMemoryCommitment_ptr);
			nativeLib.LoadFunction("vkGetBufferMemoryRequirements",  out vkGetBufferMemoryRequirements_ptr);
			nativeLib.LoadFunction("vkBindBufferMemory",  out vkBindBufferMemory_ptr);
			nativeLib.LoadFunction("vkGetImageMemoryRequirements",  out vkGetImageMemoryRequirements_ptr);
			nativeLib.LoadFunction("vkBindImageMemory",  out vkBindImageMemory_ptr);
			nativeLib.LoadFunction("vkGetImageSparseMemoryRequirements",  out vkGetImageSparseMemoryRequirements_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSparseImageFormatProperties",  out vkGetPhysicalDeviceSparseImageFormatProperties_ptr);
			nativeLib.LoadFunction("vkQueueBindSparse",  out vkQueueBindSparse_ptr);
			nativeLib.LoadFunction("vkCreateFence",  out vkCreateFence_ptr);
			nativeLib.LoadFunction("vkDestroyFence",  out vkDestroyFence_ptr);
			nativeLib.LoadFunction("vkResetFences",  out vkResetFences_ptr);
			nativeLib.LoadFunction("vkGetFenceStatus",  out vkGetFenceStatus_ptr);
			nativeLib.LoadFunction("vkWaitForFences",  out vkWaitForFences_ptr);
			nativeLib.LoadFunction("vkCreateSemaphore",  out vkCreateSemaphore_ptr);
			nativeLib.LoadFunction("vkDestroySemaphore",  out vkDestroySemaphore_ptr);
			nativeLib.LoadFunction("vkCreateEvent",  out vkCreateEvent_ptr);
			nativeLib.LoadFunction("vkDestroyEvent",  out vkDestroyEvent_ptr);
			nativeLib.LoadFunction("vkGetEventStatus",  out vkGetEventStatus_ptr);
			nativeLib.LoadFunction("vkSetEvent",  out vkSetEvent_ptr);
			nativeLib.LoadFunction("vkResetEvent",  out vkResetEvent_ptr);
			nativeLib.LoadFunction("vkCreateQueryPool",  out vkCreateQueryPool_ptr);
			nativeLib.LoadFunction("vkDestroyQueryPool",  out vkDestroyQueryPool_ptr);
			nativeLib.LoadFunction("vkGetQueryPoolResults",  out vkGetQueryPoolResults_ptr);
			nativeLib.LoadFunction("vkResetQueryPool",  out vkResetQueryPool_ptr);
			nativeLib.LoadFunction("vkCreateBuffer",  out vkCreateBuffer_ptr);
			nativeLib.LoadFunction("vkDestroyBuffer",  out vkDestroyBuffer_ptr);
			nativeLib.LoadFunction("vkCreateBufferView",  out vkCreateBufferView_ptr);
			nativeLib.LoadFunction("vkDestroyBufferView",  out vkDestroyBufferView_ptr);
			nativeLib.LoadFunction("vkCreateImage",  out vkCreateImage_ptr);
			nativeLib.LoadFunction("vkDestroyImage",  out vkDestroyImage_ptr);
			nativeLib.LoadFunction("vkGetImageSubresourceLayout",  out vkGetImageSubresourceLayout_ptr);
			nativeLib.LoadFunction("vkCreateImageView",  out vkCreateImageView_ptr);
			nativeLib.LoadFunction("vkDestroyImageView",  out vkDestroyImageView_ptr);
			nativeLib.LoadFunction("vkCreateShaderModule",  out vkCreateShaderModule_ptr);
			nativeLib.LoadFunction("vkDestroyShaderModule",  out vkDestroyShaderModule_ptr);
			nativeLib.LoadFunction("vkCreatePipelineCache",  out vkCreatePipelineCache_ptr);
			nativeLib.LoadFunction("vkDestroyPipelineCache",  out vkDestroyPipelineCache_ptr);
			nativeLib.LoadFunction("vkGetPipelineCacheData",  out vkGetPipelineCacheData_ptr);
			nativeLib.LoadFunction("vkMergePipelineCaches",  out vkMergePipelineCaches_ptr);
			nativeLib.LoadFunction("vkCreateGraphicsPipelines",  out vkCreateGraphicsPipelines_ptr);
			nativeLib.LoadFunction("vkCreateComputePipelines",  out vkCreateComputePipelines_ptr);
			nativeLib.LoadFunction("vkDestroyPipeline",  out vkDestroyPipeline_ptr);
			nativeLib.LoadFunction("vkCreatePipelineLayout",  out vkCreatePipelineLayout_ptr);
			nativeLib.LoadFunction("vkDestroyPipelineLayout",  out vkDestroyPipelineLayout_ptr);
			nativeLib.LoadFunction("vkCreateSampler",  out vkCreateSampler_ptr);
			nativeLib.LoadFunction("vkDestroySampler",  out vkDestroySampler_ptr);
			nativeLib.LoadFunction("vkCreateDescriptorSetLayout",  out vkCreateDescriptorSetLayout_ptr);
			nativeLib.LoadFunction("vkDestroyDescriptorSetLayout",  out vkDestroyDescriptorSetLayout_ptr);
			nativeLib.LoadFunction("vkCreateDescriptorPool",  out vkCreateDescriptorPool_ptr);
			nativeLib.LoadFunction("vkDestroyDescriptorPool",  out vkDestroyDescriptorPool_ptr);
			nativeLib.LoadFunction("vkResetDescriptorPool",  out vkResetDescriptorPool_ptr);
			nativeLib.LoadFunction("vkAllocateDescriptorSets",  out vkAllocateDescriptorSets_ptr);
			nativeLib.LoadFunction("vkFreeDescriptorSets",  out vkFreeDescriptorSets_ptr);
			nativeLib.LoadFunction("vkUpdateDescriptorSets",  out vkUpdateDescriptorSets_ptr);
			nativeLib.LoadFunction("vkCreateFramebuffer",  out vkCreateFramebuffer_ptr);
			nativeLib.LoadFunction("vkDestroyFramebuffer",  out vkDestroyFramebuffer_ptr);
			nativeLib.LoadFunction("vkCreateRenderPass",  out vkCreateRenderPass_ptr);
			nativeLib.LoadFunction("vkDestroyRenderPass",  out vkDestroyRenderPass_ptr);
			nativeLib.LoadFunction("vkGetRenderAreaGranularity",  out vkGetRenderAreaGranularity_ptr);
			nativeLib.LoadFunction("vkCreateCommandPool",  out vkCreateCommandPool_ptr);
			nativeLib.LoadFunction("vkDestroyCommandPool",  out vkDestroyCommandPool_ptr);
			nativeLib.LoadFunction("vkResetCommandPool",  out vkResetCommandPool_ptr);
			nativeLib.LoadFunction("vkAllocateCommandBuffers",  out vkAllocateCommandBuffers_ptr);
			nativeLib.LoadFunction("vkFreeCommandBuffers",  out vkFreeCommandBuffers_ptr);
			nativeLib.LoadFunction("vkBeginCommandBuffer",  out vkBeginCommandBuffer_ptr);
			nativeLib.LoadFunction("vkEndCommandBuffer",  out vkEndCommandBuffer_ptr);
			nativeLib.LoadFunction("vkResetCommandBuffer",  out vkResetCommandBuffer_ptr);
			nativeLib.LoadFunction("vkCmdBindPipeline",  out vkCmdBindPipeline_ptr);
			nativeLib.LoadFunction("vkCmdSetViewport",  out vkCmdSetViewport_ptr);
			nativeLib.LoadFunction("vkCmdSetScissor",  out vkCmdSetScissor_ptr);
			nativeLib.LoadFunction("vkCmdSetLineWidth",  out vkCmdSetLineWidth_ptr);
			nativeLib.LoadFunction("vkCmdSetDepthBias",  out vkCmdSetDepthBias_ptr);
			nativeLib.LoadFunction("vkCmdSetBlendConstants",  out vkCmdSetBlendConstants_ptr);
			nativeLib.LoadFunction("vkCmdSetDepthBounds",  out vkCmdSetDepthBounds_ptr);
			nativeLib.LoadFunction("vkCmdSetStencilCompareMask",  out vkCmdSetStencilCompareMask_ptr);
			nativeLib.LoadFunction("vkCmdSetStencilWriteMask",  out vkCmdSetStencilWriteMask_ptr);
			nativeLib.LoadFunction("vkCmdSetStencilReference",  out vkCmdSetStencilReference_ptr);
			nativeLib.LoadFunction("vkCmdBindDescriptorSets",  out vkCmdBindDescriptorSets_ptr);
			nativeLib.LoadFunction("vkCmdBindIndexBuffer",  out vkCmdBindIndexBuffer_ptr);
			nativeLib.LoadFunction("vkCmdBindVertexBuffers",  out vkCmdBindVertexBuffers_ptr);
			nativeLib.LoadFunction("vkCmdDraw",  out vkCmdDraw_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndexed",  out vkCmdDrawIndexed_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndirect",  out vkCmdDrawIndirect_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndexedIndirect",  out vkCmdDrawIndexedIndirect_ptr);
			nativeLib.LoadFunction("vkCmdDispatch",  out vkCmdDispatch_ptr);
			nativeLib.LoadFunction("vkCmdDispatchIndirect",  out vkCmdDispatchIndirect_ptr);
			nativeLib.LoadFunction("vkCmdCopyBuffer",  out vkCmdCopyBuffer_ptr);
			nativeLib.LoadFunction("vkCmdCopyImage",  out vkCmdCopyImage_ptr);
			nativeLib.LoadFunction("vkCmdBlitImage",  out vkCmdBlitImage_ptr);
			nativeLib.LoadFunction("vkCmdCopyBufferToImage",  out vkCmdCopyBufferToImage_ptr);
			nativeLib.LoadFunction("vkCmdCopyImageToBuffer",  out vkCmdCopyImageToBuffer_ptr);
			nativeLib.LoadFunction("vkCmdUpdateBuffer",  out vkCmdUpdateBuffer_ptr);
			nativeLib.LoadFunction("vkCmdFillBuffer",  out vkCmdFillBuffer_ptr);
			nativeLib.LoadFunction("vkCmdClearColorImage",  out vkCmdClearColorImage_ptr);
			nativeLib.LoadFunction("vkCmdClearDepthStencilImage",  out vkCmdClearDepthStencilImage_ptr);
			nativeLib.LoadFunction("vkCmdClearAttachments",  out vkCmdClearAttachments_ptr);
			nativeLib.LoadFunction("vkCmdResolveImage",  out vkCmdResolveImage_ptr);
			nativeLib.LoadFunction("vkCmdSetEvent",  out vkCmdSetEvent_ptr);
			nativeLib.LoadFunction("vkCmdResetEvent",  out vkCmdResetEvent_ptr);
			nativeLib.LoadFunction("vkCmdWaitEvents",  out vkCmdWaitEvents_ptr);
			nativeLib.LoadFunction("vkCmdPipelineBarrier",  out vkCmdPipelineBarrier_ptr);
			nativeLib.LoadFunction("vkCmdBeginQuery",  out vkCmdBeginQuery_ptr);
			nativeLib.LoadFunction("vkCmdEndQuery",  out vkCmdEndQuery_ptr);
			nativeLib.LoadFunction("vkCmdBeginConditionalRenderingEXT",  out vkCmdBeginConditionalRenderingEXT_ptr);
			nativeLib.LoadFunction("vkCmdEndConditionalRenderingEXT",  out vkCmdEndConditionalRenderingEXT_ptr);
			nativeLib.LoadFunction("vkCmdResetQueryPool",  out vkCmdResetQueryPool_ptr);
			nativeLib.LoadFunction("vkCmdWriteTimestamp",  out vkCmdWriteTimestamp_ptr);
			nativeLib.LoadFunction("vkCmdCopyQueryPoolResults",  out vkCmdCopyQueryPoolResults_ptr);
			nativeLib.LoadFunction("vkCmdPushConstants",  out vkCmdPushConstants_ptr);
			nativeLib.LoadFunction("vkCmdBeginRenderPass",  out vkCmdBeginRenderPass_ptr);
			nativeLib.LoadFunction("vkCmdNextSubpass",  out vkCmdNextSubpass_ptr);
			nativeLib.LoadFunction("vkCmdEndRenderPass",  out vkCmdEndRenderPass_ptr);
			nativeLib.LoadFunction("vkCmdExecuteCommands",  out vkCmdExecuteCommands_ptr);
			nativeLib.LoadFunction("vkCreateAndroidSurfaceKHR",  out vkCreateAndroidSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceDisplayPropertiesKHR",  out vkGetPhysicalDeviceDisplayPropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceDisplayPlanePropertiesKHR",  out vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayPlaneSupportedDisplaysKHR",  out vkGetDisplayPlaneSupportedDisplaysKHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayModePropertiesKHR",  out vkGetDisplayModePropertiesKHR_ptr);
			nativeLib.LoadFunction("vkCreateDisplayModeKHR",  out vkCreateDisplayModeKHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayPlaneCapabilitiesKHR",  out vkGetDisplayPlaneCapabilitiesKHR_ptr);
			nativeLib.LoadFunction("vkCreateDisplayPlaneSurfaceKHR",  out vkCreateDisplayPlaneSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkCreateSharedSwapchainsKHR",  out vkCreateSharedSwapchainsKHR_ptr);
			nativeLib.LoadFunction("vkDestroySurfaceKHR",  out vkDestroySurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceSupportKHR",  out vkGetPhysicalDeviceSurfaceSupportKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceCapabilitiesKHR",  out vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceFormatsKHR",  out vkGetPhysicalDeviceSurfaceFormatsKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfacePresentModesKHR",  out vkGetPhysicalDeviceSurfacePresentModesKHR_ptr);
			nativeLib.LoadFunction("vkCreateSwapchainKHR",  out vkCreateSwapchainKHR_ptr);
			nativeLib.LoadFunction("vkDestroySwapchainKHR",  out vkDestroySwapchainKHR_ptr);
			nativeLib.LoadFunction("vkGetSwapchainImagesKHR",  out vkGetSwapchainImagesKHR_ptr);
			nativeLib.LoadFunction("vkAcquireNextImageKHR",  out vkAcquireNextImageKHR_ptr);
			nativeLib.LoadFunction("vkQueuePresentKHR",  out vkQueuePresentKHR_ptr);
			nativeLib.LoadFunction("vkCreateViSurfaceNN",  out vkCreateViSurfaceNN_ptr);
			nativeLib.LoadFunction("vkCreateWaylandSurfaceKHR",  out vkCreateWaylandSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceWaylandPresentationSupportKHR",  out vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr);
			nativeLib.LoadFunction("vkCreateWin32SurfaceKHR",  out vkCreateWin32SurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceWin32PresentationSupportKHR",  out vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr);
			nativeLib.LoadFunction("vkCreateXlibSurfaceKHR",  out vkCreateXlibSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceXlibPresentationSupportKHR",  out vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr);
			nativeLib.LoadFunction("vkCreateXcbSurfaceKHR",  out vkCreateXcbSurfaceKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceXcbPresentationSupportKHR",  out vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr);
			nativeLib.LoadFunction("vkCreateImagePipeSurfaceFUCHSIA",  out vkCreateImagePipeSurfaceFUCHSIA_ptr);
			nativeLib.LoadFunction("vkCreateStreamDescriptorSurfaceGGP",  out vkCreateStreamDescriptorSurfaceGGP_ptr);
			nativeLib.LoadFunction("vkCreateDebugReportCallbackEXT",  out vkCreateDebugReportCallbackEXT_ptr);
			nativeLib.LoadFunction("vkDestroyDebugReportCallbackEXT",  out vkDestroyDebugReportCallbackEXT_ptr);
			nativeLib.LoadFunction("vkDebugReportMessageEXT",  out vkDebugReportMessageEXT_ptr);
			nativeLib.LoadFunction("vkDebugMarkerSetObjectNameEXT",  out vkDebugMarkerSetObjectNameEXT_ptr);
			nativeLib.LoadFunction("vkDebugMarkerSetObjectTagEXT",  out vkDebugMarkerSetObjectTagEXT_ptr);
			nativeLib.LoadFunction("vkCmdDebugMarkerBeginEXT",  out vkCmdDebugMarkerBeginEXT_ptr);
			nativeLib.LoadFunction("vkCmdDebugMarkerEndEXT",  out vkCmdDebugMarkerEndEXT_ptr);
			nativeLib.LoadFunction("vkCmdDebugMarkerInsertEXT",  out vkCmdDebugMarkerInsertEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceExternalImageFormatPropertiesNV",  out vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr);
			nativeLib.LoadFunction("vkGetMemoryWin32HandleNV",  out vkGetMemoryWin32HandleNV_ptr);
			nativeLib.LoadFunction("vkCmdExecuteGeneratedCommandsNV",  out vkCmdExecuteGeneratedCommandsNV_ptr);
			nativeLib.LoadFunction("vkCmdPreprocessGeneratedCommandsNV",  out vkCmdPreprocessGeneratedCommandsNV_ptr);
			nativeLib.LoadFunction("vkCmdBindPipelineShaderGroupNV",  out vkCmdBindPipelineShaderGroupNV_ptr);
			nativeLib.LoadFunction("vkGetGeneratedCommandsMemoryRequirementsNV",  out vkGetGeneratedCommandsMemoryRequirementsNV_ptr);
			nativeLib.LoadFunction("vkCreateIndirectCommandsLayoutNV",  out vkCreateIndirectCommandsLayoutNV_ptr);
			nativeLib.LoadFunction("vkDestroyIndirectCommandsLayoutNV",  out vkDestroyIndirectCommandsLayoutNV_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceFeatures2",  out vkGetPhysicalDeviceFeatures2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceProperties2",  out vkGetPhysicalDeviceProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceFormatProperties2",  out vkGetPhysicalDeviceFormatProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceImageFormatProperties2",  out vkGetPhysicalDeviceImageFormatProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceQueueFamilyProperties2",  out vkGetPhysicalDeviceQueueFamilyProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceMemoryProperties2",  out vkGetPhysicalDeviceMemoryProperties2_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSparseImageFormatProperties2",  out vkGetPhysicalDeviceSparseImageFormatProperties2_ptr);
			nativeLib.LoadFunction("vkCmdPushDescriptorSetKHR",  out vkCmdPushDescriptorSetKHR_ptr);
			nativeLib.LoadFunction("vkTrimCommandPool",  out vkTrimCommandPool_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceExternalBufferProperties",  out vkGetPhysicalDeviceExternalBufferProperties_ptr);
			nativeLib.LoadFunction("vkGetMemoryWin32HandleKHR",  out vkGetMemoryWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkGetMemoryWin32HandlePropertiesKHR",  out vkGetMemoryWin32HandlePropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetMemoryFdKHR",  out vkGetMemoryFdKHR_ptr);
			nativeLib.LoadFunction("vkGetMemoryFdPropertiesKHR",  out vkGetMemoryFdPropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceExternalSemaphoreProperties",  out vkGetPhysicalDeviceExternalSemaphoreProperties_ptr);
			nativeLib.LoadFunction("vkGetSemaphoreWin32HandleKHR",  out vkGetSemaphoreWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkImportSemaphoreWin32HandleKHR",  out vkImportSemaphoreWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkGetSemaphoreFdKHR",  out vkGetSemaphoreFdKHR_ptr);
			nativeLib.LoadFunction("vkImportSemaphoreFdKHR",  out vkImportSemaphoreFdKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceExternalFenceProperties",  out vkGetPhysicalDeviceExternalFenceProperties_ptr);
			nativeLib.LoadFunction("vkGetFenceWin32HandleKHR",  out vkGetFenceWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkImportFenceWin32HandleKHR",  out vkImportFenceWin32HandleKHR_ptr);
			nativeLib.LoadFunction("vkGetFenceFdKHR",  out vkGetFenceFdKHR_ptr);
			nativeLib.LoadFunction("vkImportFenceFdKHR",  out vkImportFenceFdKHR_ptr);
			nativeLib.LoadFunction("vkReleaseDisplayEXT",  out vkReleaseDisplayEXT_ptr);
			nativeLib.LoadFunction("vkAcquireXlibDisplayEXT",  out vkAcquireXlibDisplayEXT_ptr);
			nativeLib.LoadFunction("vkGetRandROutputDisplayEXT",  out vkGetRandROutputDisplayEXT_ptr);
			nativeLib.LoadFunction("vkDisplayPowerControlEXT",  out vkDisplayPowerControlEXT_ptr);
			nativeLib.LoadFunction("vkRegisterDeviceEventEXT",  out vkRegisterDeviceEventEXT_ptr);
			nativeLib.LoadFunction("vkRegisterDisplayEventEXT",  out vkRegisterDisplayEventEXT_ptr);
			nativeLib.LoadFunction("vkGetSwapchainCounterEXT",  out vkGetSwapchainCounterEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceCapabilities2EXT",  out vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr);
			nativeLib.LoadFunction("vkEnumeratePhysicalDeviceGroups",  out vkEnumeratePhysicalDeviceGroups_ptr);
			nativeLib.LoadFunction("vkGetDeviceGroupPeerMemoryFeatures",  out vkGetDeviceGroupPeerMemoryFeatures_ptr);
			nativeLib.LoadFunction("vkBindBufferMemory2",  out vkBindBufferMemory2_ptr);
			nativeLib.LoadFunction("vkBindImageMemory2",  out vkBindImageMemory2_ptr);
			nativeLib.LoadFunction("vkCmdSetDeviceMask",  out vkCmdSetDeviceMask_ptr);
			nativeLib.LoadFunction("vkGetDeviceGroupPresentCapabilitiesKHR",  out vkGetDeviceGroupPresentCapabilitiesKHR_ptr);
			nativeLib.LoadFunction("vkGetDeviceGroupSurfacePresentModesKHR",  out vkGetDeviceGroupSurfacePresentModesKHR_ptr);
			nativeLib.LoadFunction("vkAcquireNextImage2KHR",  out vkAcquireNextImage2KHR_ptr);
			nativeLib.LoadFunction("vkCmdDispatchBase",  out vkCmdDispatchBase_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDevicePresentRectanglesKHR",  out vkGetPhysicalDevicePresentRectanglesKHR_ptr);
			nativeLib.LoadFunction("vkCreateDescriptorUpdateTemplate",  out vkCreateDescriptorUpdateTemplate_ptr);
			nativeLib.LoadFunction("vkDestroyDescriptorUpdateTemplate",  out vkDestroyDescriptorUpdateTemplate_ptr);
			nativeLib.LoadFunction("vkUpdateDescriptorSetWithTemplate",  out vkUpdateDescriptorSetWithTemplate_ptr);
			nativeLib.LoadFunction("vkCmdPushDescriptorSetWithTemplateKHR",  out vkCmdPushDescriptorSetWithTemplateKHR_ptr);
			nativeLib.LoadFunction("vkSetHdrMetadataEXT",  out vkSetHdrMetadataEXT_ptr);
			nativeLib.LoadFunction("vkGetSwapchainStatusKHR",  out vkGetSwapchainStatusKHR_ptr);
			nativeLib.LoadFunction("vkGetRefreshCycleDurationGOOGLE",  out vkGetRefreshCycleDurationGOOGLE_ptr);
			nativeLib.LoadFunction("vkGetPastPresentationTimingGOOGLE",  out vkGetPastPresentationTimingGOOGLE_ptr);
			nativeLib.LoadFunction("vkCreateIOSSurfaceMVK",  out vkCreateIOSSurfaceMVK_ptr);
			nativeLib.LoadFunction("vkCreateMacOSSurfaceMVK",  out vkCreateMacOSSurfaceMVK_ptr);
			nativeLib.LoadFunction("vkCreateMetalSurfaceEXT",  out vkCreateMetalSurfaceEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetViewportWScalingNV",  out vkCmdSetViewportWScalingNV_ptr);
			nativeLib.LoadFunction("vkCmdSetDiscardRectangleEXT",  out vkCmdSetDiscardRectangleEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetSampleLocationsEXT",  out vkCmdSetSampleLocationsEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceMultisamplePropertiesEXT",  out vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceCapabilities2KHR",  out vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceFormats2KHR",  out vkGetPhysicalDeviceSurfaceFormats2KHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceDisplayProperties2KHR",  out vkGetPhysicalDeviceDisplayProperties2KHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceDisplayPlaneProperties2KHR",  out vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayModeProperties2KHR",  out vkGetDisplayModeProperties2KHR_ptr);
			nativeLib.LoadFunction("vkGetDisplayPlaneCapabilities2KHR",  out vkGetDisplayPlaneCapabilities2KHR_ptr);
			nativeLib.LoadFunction("vkGetBufferMemoryRequirements2",  out vkGetBufferMemoryRequirements2_ptr);
			nativeLib.LoadFunction("vkGetImageMemoryRequirements2",  out vkGetImageMemoryRequirements2_ptr);
			nativeLib.LoadFunction("vkGetImageSparseMemoryRequirements2",  out vkGetImageSparseMemoryRequirements2_ptr);
			nativeLib.LoadFunction("vkCreateSamplerYcbcrConversion",  out vkCreateSamplerYcbcrConversion_ptr);
			nativeLib.LoadFunction("vkDestroySamplerYcbcrConversion",  out vkDestroySamplerYcbcrConversion_ptr);
			nativeLib.LoadFunction("vkGetDeviceQueue2",  out vkGetDeviceQueue2_ptr);
			nativeLib.LoadFunction("vkCreateValidationCacheEXT",  out vkCreateValidationCacheEXT_ptr);
			nativeLib.LoadFunction("vkDestroyValidationCacheEXT",  out vkDestroyValidationCacheEXT_ptr);
			nativeLib.LoadFunction("vkGetValidationCacheDataEXT",  out vkGetValidationCacheDataEXT_ptr);
			nativeLib.LoadFunction("vkMergeValidationCachesEXT",  out vkMergeValidationCachesEXT_ptr);
			nativeLib.LoadFunction("vkGetDescriptorSetLayoutSupport",  out vkGetDescriptorSetLayoutSupport_ptr);
			nativeLib.LoadFunction("vkGetSwapchainGrallocUsageANDROID",  out vkGetSwapchainGrallocUsageANDROID_ptr);
			nativeLib.LoadFunction("vkGetSwapchainGrallocUsage2ANDROID",  out vkGetSwapchainGrallocUsage2ANDROID_ptr);
			nativeLib.LoadFunction("vkAcquireImageANDROID",  out vkAcquireImageANDROID_ptr);
			nativeLib.LoadFunction("vkQueueSignalReleaseImageANDROID",  out vkQueueSignalReleaseImageANDROID_ptr);
			nativeLib.LoadFunction("vkGetShaderInfoAMD",  out vkGetShaderInfoAMD_ptr);
			nativeLib.LoadFunction("vkSetLocalDimmingAMD",  out vkSetLocalDimmingAMD_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT",  out vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr);
			nativeLib.LoadFunction("vkGetCalibratedTimestampsEXT",  out vkGetCalibratedTimestampsEXT_ptr);
			nativeLib.LoadFunction("vkSetDebugUtilsObjectNameEXT",  out vkSetDebugUtilsObjectNameEXT_ptr);
			nativeLib.LoadFunction("vkSetDebugUtilsObjectTagEXT",  out vkSetDebugUtilsObjectTagEXT_ptr);
			nativeLib.LoadFunction("vkQueueBeginDebugUtilsLabelEXT",  out vkQueueBeginDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkQueueEndDebugUtilsLabelEXT",  out vkQueueEndDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkQueueInsertDebugUtilsLabelEXT",  out vkQueueInsertDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkCmdBeginDebugUtilsLabelEXT",  out vkCmdBeginDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkCmdEndDebugUtilsLabelEXT",  out vkCmdEndDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkCmdInsertDebugUtilsLabelEXT",  out vkCmdInsertDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("vkCreateDebugUtilsMessengerEXT",  out vkCreateDebugUtilsMessengerEXT_ptr);
			nativeLib.LoadFunction("vkDestroyDebugUtilsMessengerEXT",  out vkDestroyDebugUtilsMessengerEXT_ptr);
			nativeLib.LoadFunction("vkSubmitDebugUtilsMessageEXT",  out vkSubmitDebugUtilsMessageEXT_ptr);
			nativeLib.LoadFunction("vkGetMemoryHostPointerPropertiesEXT",  out vkGetMemoryHostPointerPropertiesEXT_ptr);
			nativeLib.LoadFunction("vkCmdWriteBufferMarkerAMD",  out vkCmdWriteBufferMarkerAMD_ptr);
			nativeLib.LoadFunction("vkCreateRenderPass2",  out vkCreateRenderPass2_ptr);
			nativeLib.LoadFunction("vkCmdBeginRenderPass2",  out vkCmdBeginRenderPass2_ptr);
			nativeLib.LoadFunction("vkCmdNextSubpass2",  out vkCmdNextSubpass2_ptr);
			nativeLib.LoadFunction("vkCmdEndRenderPass2",  out vkCmdEndRenderPass2_ptr);
			nativeLib.LoadFunction("vkGetSemaphoreCounterValue",  out vkGetSemaphoreCounterValue_ptr);
			nativeLib.LoadFunction("vkWaitSemaphores",  out vkWaitSemaphores_ptr);
			nativeLib.LoadFunction("vkSignalSemaphore",  out vkSignalSemaphore_ptr);
			nativeLib.LoadFunction("vkGetAndroidHardwareBufferPropertiesANDROID",  out vkGetAndroidHardwareBufferPropertiesANDROID_ptr);
			nativeLib.LoadFunction("vkGetMemoryAndroidHardwareBufferANDROID",  out vkGetMemoryAndroidHardwareBufferANDROID_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndirectCount",  out vkCmdDrawIndirectCount_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndexedIndirectCount",  out vkCmdDrawIndexedIndirectCount_ptr);
			nativeLib.LoadFunction("vkCmdSetCheckpointNV",  out vkCmdSetCheckpointNV_ptr);
			nativeLib.LoadFunction("vkGetQueueCheckpointDataNV",  out vkGetQueueCheckpointDataNV_ptr);
			nativeLib.LoadFunction("vkCmdBindTransformFeedbackBuffersEXT",  out vkCmdBindTransformFeedbackBuffersEXT_ptr);
			nativeLib.LoadFunction("vkCmdBeginTransformFeedbackEXT",  out vkCmdBeginTransformFeedbackEXT_ptr);
			nativeLib.LoadFunction("vkCmdEndTransformFeedbackEXT",  out vkCmdEndTransformFeedbackEXT_ptr);
			nativeLib.LoadFunction("vkCmdBeginQueryIndexedEXT",  out vkCmdBeginQueryIndexedEXT_ptr);
			nativeLib.LoadFunction("vkCmdEndQueryIndexedEXT",  out vkCmdEndQueryIndexedEXT_ptr);
			nativeLib.LoadFunction("vkCmdDrawIndirectByteCountEXT",  out vkCmdDrawIndirectByteCountEXT_ptr);
			nativeLib.LoadFunction("vkCmdSetExclusiveScissorNV",  out vkCmdSetExclusiveScissorNV_ptr);
			nativeLib.LoadFunction("vkCmdBindShadingRateImageNV",  out vkCmdBindShadingRateImageNV_ptr);
			nativeLib.LoadFunction("vkCmdSetViewportShadingRatePaletteNV",  out vkCmdSetViewportShadingRatePaletteNV_ptr);
			nativeLib.LoadFunction("vkCmdSetCoarseSampleOrderNV",  out vkCmdSetCoarseSampleOrderNV_ptr);
			nativeLib.LoadFunction("vkCmdDrawMeshTasksNV",  out vkCmdDrawMeshTasksNV_ptr);
			nativeLib.LoadFunction("vkCmdDrawMeshTasksIndirectNV",  out vkCmdDrawMeshTasksIndirectNV_ptr);
			nativeLib.LoadFunction("vkCmdDrawMeshTasksIndirectCountNV",  out vkCmdDrawMeshTasksIndirectCountNV_ptr);
			nativeLib.LoadFunction("vkCompileDeferredNV",  out vkCompileDeferredNV_ptr);
			nativeLib.LoadFunction("vkCreateAccelerationStructureNV",  out vkCreateAccelerationStructureNV_ptr);
			nativeLib.LoadFunction("vkDestroyAccelerationStructureKHR",  out vkDestroyAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkGetAccelerationStructureMemoryRequirementsKHR",  out vkGetAccelerationStructureMemoryRequirementsKHR_ptr);
			nativeLib.LoadFunction("vkGetAccelerationStructureMemoryRequirementsNV",  out vkGetAccelerationStructureMemoryRequirementsNV_ptr);
			nativeLib.LoadFunction("vkBindAccelerationStructureMemoryKHR",  out vkBindAccelerationStructureMemoryKHR_ptr);
			nativeLib.LoadFunction("vkCmdCopyAccelerationStructureNV",  out vkCmdCopyAccelerationStructureNV_ptr);
			nativeLib.LoadFunction("vkCmdCopyAccelerationStructureKHR",  out vkCmdCopyAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkCopyAccelerationStructureKHR",  out vkCopyAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkCmdCopyAccelerationStructureToMemoryKHR",  out vkCmdCopyAccelerationStructureToMemoryKHR_ptr);
			nativeLib.LoadFunction("vkCopyAccelerationStructureToMemoryKHR",  out vkCopyAccelerationStructureToMemoryKHR_ptr);
			nativeLib.LoadFunction("vkCmdCopyMemoryToAccelerationStructureKHR",  out vkCmdCopyMemoryToAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkCopyMemoryToAccelerationStructureKHR",  out vkCopyMemoryToAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkCmdWriteAccelerationStructuresPropertiesKHR",  out vkCmdWriteAccelerationStructuresPropertiesKHR_ptr);
			nativeLib.LoadFunction("vkCmdBuildAccelerationStructureNV",  out vkCmdBuildAccelerationStructureNV_ptr);
			nativeLib.LoadFunction("vkWriteAccelerationStructuresPropertiesKHR",  out vkWriteAccelerationStructuresPropertiesKHR_ptr);
			nativeLib.LoadFunction("vkCmdTraceRaysKHR",  out vkCmdTraceRaysKHR_ptr);
			nativeLib.LoadFunction("vkCmdTraceRaysNV",  out vkCmdTraceRaysNV_ptr);
			nativeLib.LoadFunction("vkGetRayTracingShaderGroupHandlesKHR",  out vkGetRayTracingShaderGroupHandlesKHR_ptr);
			nativeLib.LoadFunction("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR",  out vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr);
			nativeLib.LoadFunction("vkGetAccelerationStructureHandleNV",  out vkGetAccelerationStructureHandleNV_ptr);
			nativeLib.LoadFunction("vkCreateRayTracingPipelinesNV",  out vkCreateRayTracingPipelinesNV_ptr);
			nativeLib.LoadFunction("vkCreateRayTracingPipelinesKHR",  out vkCreateRayTracingPipelinesKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV",  out vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr);
			nativeLib.LoadFunction("vkCmdTraceRaysIndirectKHR",  out vkCmdTraceRaysIndirectKHR_ptr);
			nativeLib.LoadFunction("vkGetDeviceAccelerationStructureCompatibilityKHR",  out vkGetDeviceAccelerationStructureCompatibilityKHR_ptr);
			nativeLib.LoadFunction("vkGetImageViewHandleNVX",  out vkGetImageViewHandleNVX_ptr);
			nativeLib.LoadFunction("vkGetImageViewAddressNVX",  out vkGetImageViewAddressNVX_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSurfacePresentModes2EXT",  out vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr);
			nativeLib.LoadFunction("vkGetDeviceGroupSurfacePresentModes2EXT",  out vkGetDeviceGroupSurfacePresentModes2EXT_ptr);
			nativeLib.LoadFunction("vkAcquireFullScreenExclusiveModeEXT",  out vkAcquireFullScreenExclusiveModeEXT_ptr);
			nativeLib.LoadFunction("vkReleaseFullScreenExclusiveModeEXT",  out vkReleaseFullScreenExclusiveModeEXT_ptr);
			nativeLib.LoadFunction("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR",  out vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR",  out vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr);
			nativeLib.LoadFunction("vkAcquireProfilingLockKHR",  out vkAcquireProfilingLockKHR_ptr);
			nativeLib.LoadFunction("vkReleaseProfilingLockKHR",  out vkReleaseProfilingLockKHR_ptr);
			nativeLib.LoadFunction("vkGetImageDrmFormatModifierPropertiesEXT",  out vkGetImageDrmFormatModifierPropertiesEXT_ptr);
			nativeLib.LoadFunction("vkGetBufferOpaqueCaptureAddress",  out vkGetBufferOpaqueCaptureAddress_ptr);
			nativeLib.LoadFunction("vkGetBufferDeviceAddress",  out vkGetBufferDeviceAddress_ptr);
			nativeLib.LoadFunction("vkCreateHeadlessSurfaceEXT",  out vkCreateHeadlessSurfaceEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV",  out vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr);
			nativeLib.LoadFunction("vkInitializePerformanceApiINTEL",  out vkInitializePerformanceApiINTEL_ptr);
			nativeLib.LoadFunction("vkUninitializePerformanceApiINTEL",  out vkUninitializePerformanceApiINTEL_ptr);
			nativeLib.LoadFunction("vkCmdSetPerformanceMarkerINTEL",  out vkCmdSetPerformanceMarkerINTEL_ptr);
			nativeLib.LoadFunction("vkCmdSetPerformanceStreamMarkerINTEL",  out vkCmdSetPerformanceStreamMarkerINTEL_ptr);
			nativeLib.LoadFunction("vkCmdSetPerformanceOverrideINTEL",  out vkCmdSetPerformanceOverrideINTEL_ptr);
			nativeLib.LoadFunction("vkAcquirePerformanceConfigurationINTEL",  out vkAcquirePerformanceConfigurationINTEL_ptr);
			nativeLib.LoadFunction("vkReleasePerformanceConfigurationINTEL",  out vkReleasePerformanceConfigurationINTEL_ptr);
			nativeLib.LoadFunction("vkQueueSetPerformanceConfigurationINTEL",  out vkQueueSetPerformanceConfigurationINTEL_ptr);
			nativeLib.LoadFunction("vkGetPerformanceParameterINTEL",  out vkGetPerformanceParameterINTEL_ptr);
			nativeLib.LoadFunction("vkGetDeviceMemoryOpaqueCaptureAddress",  out vkGetDeviceMemoryOpaqueCaptureAddress_ptr);
			nativeLib.LoadFunction("vkGetPipelineExecutablePropertiesKHR",  out vkGetPipelineExecutablePropertiesKHR_ptr);
			nativeLib.LoadFunction("vkGetPipelineExecutableStatisticsKHR",  out vkGetPipelineExecutableStatisticsKHR_ptr);
			nativeLib.LoadFunction("vkGetPipelineExecutableInternalRepresentationsKHR",  out vkGetPipelineExecutableInternalRepresentationsKHR_ptr);
			nativeLib.LoadFunction("vkCmdSetLineStippleEXT",  out vkCmdSetLineStippleEXT_ptr);
			nativeLib.LoadFunction("vkGetPhysicalDeviceToolPropertiesEXT",  out vkGetPhysicalDeviceToolPropertiesEXT_ptr);
			nativeLib.LoadFunction("vkCreateAccelerationStructureKHR",  out vkCreateAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkCmdBuildAccelerationStructureKHR",  out vkCmdBuildAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkCmdBuildAccelerationStructureIndirectKHR",  out vkCmdBuildAccelerationStructureIndirectKHR_ptr);
			nativeLib.LoadFunction("vkBuildAccelerationStructureKHR",  out vkBuildAccelerationStructureKHR_ptr);
			nativeLib.LoadFunction("vkGetAccelerationStructureDeviceAddressKHR",  out vkGetAccelerationStructureDeviceAddressKHR_ptr);
			nativeLib.LoadFunction("vkCreateDeferredOperationKHR",  out vkCreateDeferredOperationKHR_ptr);
			nativeLib.LoadFunction("vkDestroyDeferredOperationKHR",  out vkDestroyDeferredOperationKHR_ptr);
			nativeLib.LoadFunction("vkGetDeferredOperationMaxConcurrencyKHR",  out vkGetDeferredOperationMaxConcurrencyKHR_ptr);
			nativeLib.LoadFunction("vkGetDeferredOperationResultKHR",  out vkGetDeferredOperationResultKHR_ptr);
			nativeLib.LoadFunction("vkDeferredOperationJoinKHR",  out vkDeferredOperationJoinKHR_ptr);
		}
	}
}
