using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.Vulkan
{
	public static unsafe partial class VulkanNative
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateInstanceDelegate(IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pInstance);
		private static vkCreateInstanceDelegate vkCreateInstance_ptr;
		public static VkResult vkCreateInstance(IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pInstance)
			=> vkCreateInstance_ptr(pCreateInfo, pAllocator, pInstance);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyInstanceDelegate(VkInstance instance, IntPtr pAllocator);
		private static vkDestroyInstanceDelegate vkDestroyInstance_ptr;
		public static void vkDestroyInstance(VkInstance instance, IntPtr pAllocator)
			=> vkDestroyInstance_ptr(instance, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkEnumeratePhysicalDevicesDelegate(VkInstance instance, uint* pPhysicalDeviceCount, IntPtr pPhysicalDevices);
		private static vkEnumeratePhysicalDevicesDelegate vkEnumeratePhysicalDevices_ptr;
		public static VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, IntPtr pPhysicalDevices)
			=> vkEnumeratePhysicalDevices_ptr(instance, pPhysicalDeviceCount, pPhysicalDevices);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate PFN_vkVoidFunction vkGetDeviceProcAddrDelegate(VkDevice device, byte* pName);
		private static vkGetDeviceProcAddrDelegate vkGetDeviceProcAddr_ptr;
		public static PFN_vkVoidFunction vkGetDeviceProcAddr(VkDevice device, byte* pName)
			=> vkGetDeviceProcAddr_ptr(device, pName);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate PFN_vkVoidFunction vkGetInstanceProcAddrDelegate(VkInstance instance, byte* pName);
		private static vkGetInstanceProcAddrDelegate vkGetInstanceProcAddr_ptr;
		public static PFN_vkVoidFunction vkGetInstanceProcAddr(VkInstance instance, byte* pName)
			=> vkGetInstanceProcAddr_ptr(instance, pName);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDevicePropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pProperties);
		private static vkGetPhysicalDevicePropertiesDelegate vkGetPhysicalDeviceProperties_ptr;
		public static void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, IntPtr pProperties)
			=> vkGetPhysicalDeviceProperties_ptr(physicalDevice, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceQueueFamilyPropertiesDelegate(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties);
		private static vkGetPhysicalDeviceQueueFamilyPropertiesDelegate vkGetPhysicalDeviceQueueFamilyProperties_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties)
			=> vkGetPhysicalDeviceQueueFamilyProperties_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceMemoryPropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pMemoryProperties);
		private static vkGetPhysicalDeviceMemoryPropertiesDelegate vkGetPhysicalDeviceMemoryProperties_ptr;
		public static void vkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, IntPtr pMemoryProperties)
			=> vkGetPhysicalDeviceMemoryProperties_ptr(physicalDevice, pMemoryProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceFeaturesDelegate(VkPhysicalDevice physicalDevice, IntPtr pFeatures);
		private static vkGetPhysicalDeviceFeaturesDelegate vkGetPhysicalDeviceFeatures_ptr;
		public static void vkGetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, IntPtr pFeatures)
			=> vkGetPhysicalDeviceFeatures_ptr(physicalDevice, pFeatures);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, IntPtr pFormatProperties);
		private static vkGetPhysicalDeviceFormatPropertiesDelegate vkGetPhysicalDeviceFormatProperties_ptr;
		public static void vkGetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, IntPtr pFormatProperties)
			=> vkGetPhysicalDeviceFormatProperties_ptr(physicalDevice, format, pFormatProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, IntPtr pImageFormatProperties);
		private static vkGetPhysicalDeviceImageFormatPropertiesDelegate vkGetPhysicalDeviceImageFormatProperties_ptr;
		public static VkResult vkGetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, IntPtr pImageFormatProperties)
			=> vkGetPhysicalDeviceImageFormatProperties_ptr(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateDeviceDelegate(VkPhysicalDevice physicalDevice, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDevice);
		private static vkCreateDeviceDelegate vkCreateDevice_ptr;
		public static VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDevice)
			=> vkCreateDevice_ptr(physicalDevice, pCreateInfo, pAllocator, pDevice);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyDeviceDelegate(VkDevice device, IntPtr pAllocator);
		private static vkDestroyDeviceDelegate vkDestroyDevice_ptr;
		public static void vkDestroyDevice(VkDevice device, IntPtr pAllocator)
			=> vkDestroyDevice_ptr(device, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkEnumerateInstanceVersionDelegate(uint* pApiVersion);
		private static vkEnumerateInstanceVersionDelegate vkEnumerateInstanceVersion_ptr;
		public static VkResult vkEnumerateInstanceVersion(uint* pApiVersion)
			=> vkEnumerateInstanceVersion_ptr(pApiVersion);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkEnumerateInstanceLayerPropertiesDelegate(uint* pPropertyCount, IntPtr pProperties);
		private static vkEnumerateInstanceLayerPropertiesDelegate vkEnumerateInstanceLayerProperties_ptr;
		public static VkResult vkEnumerateInstanceLayerProperties(uint* pPropertyCount, IntPtr pProperties)
			=> vkEnumerateInstanceLayerProperties_ptr(pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkEnumerateInstanceExtensionPropertiesDelegate(byte* pLayerName, uint* pPropertyCount, IntPtr pProperties);
		private static vkEnumerateInstanceExtensionPropertiesDelegate vkEnumerateInstanceExtensionProperties_ptr;
		public static VkResult vkEnumerateInstanceExtensionProperties(byte* pLayerName, uint* pPropertyCount, IntPtr pProperties)
			=> vkEnumerateInstanceExtensionProperties_ptr(pLayerName, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkEnumerateDeviceLayerPropertiesDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkEnumerateDeviceLayerPropertiesDelegate vkEnumerateDeviceLayerProperties_ptr;
		public static VkResult vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkEnumerateDeviceLayerProperties_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkEnumerateDeviceExtensionPropertiesDelegate(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, IntPtr pProperties);
		private static vkEnumerateDeviceExtensionPropertiesDelegate vkEnumerateDeviceExtensionProperties_ptr;
		public static VkResult vkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, IntPtr pProperties)
			=> vkEnumerateDeviceExtensionProperties_ptr(physicalDevice, pLayerName, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetDeviceQueueDelegate(VkDevice device, uint queueFamilyIndex, uint queueIndex, IntPtr pQueue);
		private static vkGetDeviceQueueDelegate vkGetDeviceQueue_ptr;
		public static void vkGetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, IntPtr pQueue)
			=> vkGetDeviceQueue_ptr(device, queueFamilyIndex, queueIndex, pQueue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkQueueSubmitDelegate(VkQueue queue, uint submitCount, IntPtr pSubmits, VkFence fence);
		private static vkQueueSubmitDelegate vkQueueSubmit_ptr;
		public static VkResult vkQueueSubmit(VkQueue queue, uint submitCount, IntPtr pSubmits, VkFence fence)
			=> vkQueueSubmit_ptr(queue, submitCount, pSubmits, fence);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkQueueWaitIdleDelegate(VkQueue queue);
		private static vkQueueWaitIdleDelegate vkQueueWaitIdle_ptr;
		public static VkResult vkQueueWaitIdle(VkQueue queue)
			=> vkQueueWaitIdle_ptr(queue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkDeviceWaitIdleDelegate(VkDevice device);
		private static vkDeviceWaitIdleDelegate vkDeviceWaitIdle_ptr;
		public static VkResult vkDeviceWaitIdle(VkDevice device)
			=> vkDeviceWaitIdle_ptr(device);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAllocateMemoryDelegate(VkDevice device, IntPtr pAllocateInfo, IntPtr pAllocator, IntPtr pMemory);
		private static vkAllocateMemoryDelegate vkAllocateMemory_ptr;
		public static VkResult vkAllocateMemory(VkDevice device, IntPtr pAllocateInfo, IntPtr pAllocator, IntPtr pMemory)
			=> vkAllocateMemory_ptr(device, pAllocateInfo, pAllocator, pMemory);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkFreeMemoryDelegate(VkDevice device, VkDeviceMemory memory, IntPtr pAllocator);
		private static vkFreeMemoryDelegate vkFreeMemory_ptr;
		public static void vkFreeMemory(VkDevice device, VkDeviceMemory memory, IntPtr pAllocator)
			=> vkFreeMemory_ptr(device, memory, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkMapMemoryDelegate(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, uint flags, void** ppData);
		private static vkMapMemoryDelegate vkMapMemory_ptr;
		public static VkResult vkMapMemory(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, uint flags, void** ppData)
			=> vkMapMemory_ptr(device, memory, offset, size, flags, ppData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkUnmapMemoryDelegate(VkDevice device, VkDeviceMemory memory);
		private static vkUnmapMemoryDelegate vkUnmapMemory_ptr;
		public static void vkUnmapMemory(VkDevice device, VkDeviceMemory memory)
			=> vkUnmapMemory_ptr(device, memory);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkFlushMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, IntPtr pMemoryRanges);
		private static vkFlushMappedMemoryRangesDelegate vkFlushMappedMemoryRanges_ptr;
		public static VkResult vkFlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, IntPtr pMemoryRanges)
			=> vkFlushMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkInvalidateMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, IntPtr pMemoryRanges);
		private static vkInvalidateMappedMemoryRangesDelegate vkInvalidateMappedMemoryRanges_ptr;
		public static VkResult vkInvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, IntPtr pMemoryRanges)
			=> vkInvalidateMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetDeviceMemoryCommitmentDelegate(VkDevice device, VkDeviceMemory memory, IntPtr pCommittedMemoryInBytes);
		private static vkGetDeviceMemoryCommitmentDelegate vkGetDeviceMemoryCommitment_ptr;
		public static void vkGetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, IntPtr pCommittedMemoryInBytes)
			=> vkGetDeviceMemoryCommitment_ptr(device, memory, pCommittedMemoryInBytes);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetBufferMemoryRequirementsDelegate(VkDevice device, VkBuffer buffer, IntPtr pMemoryRequirements);
		private static vkGetBufferMemoryRequirementsDelegate vkGetBufferMemoryRequirements_ptr;
		public static void vkGetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, IntPtr pMemoryRequirements)
			=> vkGetBufferMemoryRequirements_ptr(device, buffer, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkBindBufferMemoryDelegate(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset);
		private static vkBindBufferMemoryDelegate vkBindBufferMemory_ptr;
		public static VkResult vkBindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
			=> vkBindBufferMemory_ptr(device, buffer, memory, memoryOffset);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetImageMemoryRequirementsDelegate(VkDevice device, VkImage image, IntPtr pMemoryRequirements);
		private static vkGetImageMemoryRequirementsDelegate vkGetImageMemoryRequirements_ptr;
		public static void vkGetImageMemoryRequirements(VkDevice device, VkImage image, IntPtr pMemoryRequirements)
			=> vkGetImageMemoryRequirements_ptr(device, image, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkBindImageMemoryDelegate(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset);
		private static vkBindImageMemoryDelegate vkBindImageMemory_ptr;
		public static VkResult vkBindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
			=> vkBindImageMemory_ptr(device, image, memory, memoryOffset);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetImageSparseMemoryRequirementsDelegate(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements);
		private static vkGetImageSparseMemoryRequirementsDelegate vkGetImageSparseMemoryRequirements_ptr;
		public static void vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements)
			=> vkGetImageSparseMemoryRequirements_ptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, uint usage, VkImageTiling tiling, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate vkGetPhysicalDeviceSparseImageFormatProperties_ptr;
		public static void vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, uint usage, VkImageTiling tiling, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceSparseImageFormatProperties_ptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkQueueBindSparseDelegate(VkQueue queue, uint bindInfoCount, IntPtr pBindInfo, VkFence fence);
		private static vkQueueBindSparseDelegate vkQueueBindSparse_ptr;
		public static VkResult vkQueueBindSparse(VkQueue queue, uint bindInfoCount, IntPtr pBindInfo, VkFence fence)
			=> vkQueueBindSparse_ptr(queue, bindInfoCount, pBindInfo, fence);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateFenceDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pFence);
		private static vkCreateFenceDelegate vkCreateFence_ptr;
		public static VkResult vkCreateFence(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pFence)
			=> vkCreateFence_ptr(device, pCreateInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyFenceDelegate(VkDevice device, VkFence fence, IntPtr pAllocator);
		private static vkDestroyFenceDelegate vkDestroyFence_ptr;
		public static void vkDestroyFence(VkDevice device, VkFence fence, IntPtr pAllocator)
			=> vkDestroyFence_ptr(device, fence, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkResetFencesDelegate(VkDevice device, uint fenceCount, IntPtr pFences);
		private static vkResetFencesDelegate vkResetFences_ptr;
		public static VkResult vkResetFences(VkDevice device, uint fenceCount, IntPtr pFences)
			=> vkResetFences_ptr(device, fenceCount, pFences);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetFenceStatusDelegate(VkDevice device, VkFence fence);
		private static vkGetFenceStatusDelegate vkGetFenceStatus_ptr;
		public static VkResult vkGetFenceStatus(VkDevice device, VkFence fence)
			=> vkGetFenceStatus_ptr(device, fence);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkWaitForFencesDelegate(VkDevice device, uint fenceCount, IntPtr pFences, uint waitAll, ulong timeout);
		private static vkWaitForFencesDelegate vkWaitForFences_ptr;
		public static VkResult vkWaitForFences(VkDevice device, uint fenceCount, IntPtr pFences, uint waitAll, ulong timeout)
			=> vkWaitForFences_ptr(device, fenceCount, pFences, waitAll, timeout);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateSemaphoreDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSemaphore);
		private static vkCreateSemaphoreDelegate vkCreateSemaphore_ptr;
		public static VkResult vkCreateSemaphore(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSemaphore)
			=> vkCreateSemaphore_ptr(device, pCreateInfo, pAllocator, pSemaphore);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroySemaphoreDelegate(VkDevice device, VkSemaphore semaphore, IntPtr pAllocator);
		private static vkDestroySemaphoreDelegate vkDestroySemaphore_ptr;
		public static void vkDestroySemaphore(VkDevice device, VkSemaphore semaphore, IntPtr pAllocator)
			=> vkDestroySemaphore_ptr(device, semaphore, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateEventDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pEvent);
		private static vkCreateEventDelegate vkCreateEvent_ptr;
		public static VkResult vkCreateEvent(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pEvent)
			=> vkCreateEvent_ptr(device, pCreateInfo, pAllocator, pEvent);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyEventDelegate(VkDevice device, VkEvent vkEvent, IntPtr pAllocator);
		private static vkDestroyEventDelegate vkDestroyEvent_ptr;
		public static void vkDestroyEvent(VkDevice device, VkEvent vkEvent, IntPtr pAllocator)
			=> vkDestroyEvent_ptr(device, vkEvent, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetEventStatusDelegate(VkDevice device, VkEvent vkEvent);
		private static vkGetEventStatusDelegate vkGetEventStatus_ptr;
		public static VkResult vkGetEventStatus(VkDevice device, VkEvent vkEvent)
			=> vkGetEventStatus_ptr(device, vkEvent);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkSetEventDelegate(VkDevice device, VkEvent vkEvent);
		private static vkSetEventDelegate vkSetEvent_ptr;
		public static VkResult vkSetEvent(VkDevice device, VkEvent vkEvent)
			=> vkSetEvent_ptr(device, vkEvent);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkResetEventDelegate(VkDevice device, VkEvent vkEvent);
		private static vkResetEventDelegate vkResetEvent_ptr;
		public static VkResult vkResetEvent(VkDevice device, VkEvent vkEvent)
			=> vkResetEvent_ptr(device, vkEvent);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateQueryPoolDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pQueryPool);
		private static vkCreateQueryPoolDelegate vkCreateQueryPool_ptr;
		public static VkResult vkCreateQueryPool(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pQueryPool)
			=> vkCreateQueryPool_ptr(device, pCreateInfo, pAllocator, pQueryPool);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, IntPtr pAllocator);
		private static vkDestroyQueryPoolDelegate vkDestroyQueryPool_ptr;
		public static void vkDestroyQueryPool(VkDevice device, VkQueryPool queryPool, IntPtr pAllocator)
			=> vkDestroyQueryPool_ptr(device, queryPool, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetQueryPoolResultsDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* pData, ulong stride, uint flags);
		private static vkGetQueryPoolResultsDelegate vkGetQueryPoolResults_ptr;
		public static VkResult vkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* pData, ulong stride, uint flags)
			=> vkGetQueryPoolResults_ptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkResetQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private static vkResetQueryPoolDelegate vkResetQueryPool_ptr;
		public static void vkResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
			=> vkResetQueryPool_ptr(device, queryPool, firstQuery, queryCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateBufferDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pBuffer);
		private static vkCreateBufferDelegate vkCreateBuffer_ptr;
		public static VkResult vkCreateBuffer(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pBuffer)
			=> vkCreateBuffer_ptr(device, pCreateInfo, pAllocator, pBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyBufferDelegate(VkDevice device, VkBuffer buffer, IntPtr pAllocator);
		private static vkDestroyBufferDelegate vkDestroyBuffer_ptr;
		public static void vkDestroyBuffer(VkDevice device, VkBuffer buffer, IntPtr pAllocator)
			=> vkDestroyBuffer_ptr(device, buffer, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateBufferViewDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pView);
		private static vkCreateBufferViewDelegate vkCreateBufferView_ptr;
		public static VkResult vkCreateBufferView(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pView)
			=> vkCreateBufferView_ptr(device, pCreateInfo, pAllocator, pView);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyBufferViewDelegate(VkDevice device, VkBufferView bufferView, IntPtr pAllocator);
		private static vkDestroyBufferViewDelegate vkDestroyBufferView_ptr;
		public static void vkDestroyBufferView(VkDevice device, VkBufferView bufferView, IntPtr pAllocator)
			=> vkDestroyBufferView_ptr(device, bufferView, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateImageDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pImage);
		private static vkCreateImageDelegate vkCreateImage_ptr;
		public static VkResult vkCreateImage(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pImage)
			=> vkCreateImage_ptr(device, pCreateInfo, pAllocator, pImage);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyImageDelegate(VkDevice device, VkImage image, IntPtr pAllocator);
		private static vkDestroyImageDelegate vkDestroyImage_ptr;
		public static void vkDestroyImage(VkDevice device, VkImage image, IntPtr pAllocator)
			=> vkDestroyImage_ptr(device, image, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetImageSubresourceLayoutDelegate(VkDevice device, VkImage image, IntPtr pSubresource, IntPtr pLayout);
		private static vkGetImageSubresourceLayoutDelegate vkGetImageSubresourceLayout_ptr;
		public static void vkGetImageSubresourceLayout(VkDevice device, VkImage image, IntPtr pSubresource, IntPtr pLayout)
			=> vkGetImageSubresourceLayout_ptr(device, image, pSubresource, pLayout);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateImageViewDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pView);
		private static vkCreateImageViewDelegate vkCreateImageView_ptr;
		public static VkResult vkCreateImageView(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pView)
			=> vkCreateImageView_ptr(device, pCreateInfo, pAllocator, pView);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyImageViewDelegate(VkDevice device, VkImageView imageView, IntPtr pAllocator);
		private static vkDestroyImageViewDelegate vkDestroyImageView_ptr;
		public static void vkDestroyImageView(VkDevice device, VkImageView imageView, IntPtr pAllocator)
			=> vkDestroyImageView_ptr(device, imageView, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateShaderModuleDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pShaderModule);
		private static vkCreateShaderModuleDelegate vkCreateShaderModule_ptr;
		public static VkResult vkCreateShaderModule(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pShaderModule)
			=> vkCreateShaderModule_ptr(device, pCreateInfo, pAllocator, pShaderModule);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyShaderModuleDelegate(VkDevice device, VkShaderModule shaderModule, IntPtr pAllocator);
		private static vkDestroyShaderModuleDelegate vkDestroyShaderModule_ptr;
		public static void vkDestroyShaderModule(VkDevice device, VkShaderModule shaderModule, IntPtr pAllocator)
			=> vkDestroyShaderModule_ptr(device, shaderModule, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreatePipelineCacheDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pPipelineCache);
		private static vkCreatePipelineCacheDelegate vkCreatePipelineCache_ptr;
		public static VkResult vkCreatePipelineCache(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pPipelineCache)
			=> vkCreatePipelineCache_ptr(device, pCreateInfo, pAllocator, pPipelineCache);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyPipelineCacheDelegate(VkDevice device, VkPipelineCache pipelineCache, IntPtr pAllocator);
		private static vkDestroyPipelineCacheDelegate vkDestroyPipelineCache_ptr;
		public static void vkDestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, IntPtr pAllocator)
			=> vkDestroyPipelineCache_ptr(device, pipelineCache, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPipelineCacheDataDelegate(VkDevice device, VkPipelineCache pipelineCache, UIntPtr* pDataSize, void* pData);
		private static vkGetPipelineCacheDataDelegate vkGetPipelineCacheData_ptr;
		public static VkResult vkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, UIntPtr* pDataSize, void* pData)
			=> vkGetPipelineCacheData_ptr(device, pipelineCache, pDataSize, pData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkMergePipelineCachesDelegate(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, IntPtr pSrcCaches);
		private static vkMergePipelineCachesDelegate vkMergePipelineCaches_ptr;
		public static VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, IntPtr pSrcCaches)
			=> vkMergePipelineCaches_ptr(device, dstCache, srcCacheCount, pSrcCaches);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateGraphicsPipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines);
		private static vkCreateGraphicsPipelinesDelegate vkCreateGraphicsPipelines_ptr;
		public static VkResult vkCreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines)
			=> vkCreateGraphicsPipelines_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateComputePipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines);
		private static vkCreateComputePipelinesDelegate vkCreateComputePipelines_ptr;
		public static VkResult vkCreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines)
			=> vkCreateComputePipelines_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyPipelineDelegate(VkDevice device, VkPipeline pipeline, IntPtr pAllocator);
		private static vkDestroyPipelineDelegate vkDestroyPipeline_ptr;
		public static void vkDestroyPipeline(VkDevice device, VkPipeline pipeline, IntPtr pAllocator)
			=> vkDestroyPipeline_ptr(device, pipeline, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreatePipelineLayoutDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pPipelineLayout);
		private static vkCreatePipelineLayoutDelegate vkCreatePipelineLayout_ptr;
		public static VkResult vkCreatePipelineLayout(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pPipelineLayout)
			=> vkCreatePipelineLayout_ptr(device, pCreateInfo, pAllocator, pPipelineLayout);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyPipelineLayoutDelegate(VkDevice device, VkPipelineLayout pipelineLayout, IntPtr pAllocator);
		private static vkDestroyPipelineLayoutDelegate vkDestroyPipelineLayout_ptr;
		public static void vkDestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, IntPtr pAllocator)
			=> vkDestroyPipelineLayout_ptr(device, pipelineLayout, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateSamplerDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSampler);
		private static vkCreateSamplerDelegate vkCreateSampler_ptr;
		public static VkResult vkCreateSampler(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSampler)
			=> vkCreateSampler_ptr(device, pCreateInfo, pAllocator, pSampler);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroySamplerDelegate(VkDevice device, VkSampler sampler, IntPtr pAllocator);
		private static vkDestroySamplerDelegate vkDestroySampler_ptr;
		public static void vkDestroySampler(VkDevice device, VkSampler sampler, IntPtr pAllocator)
			=> vkDestroySampler_ptr(device, sampler, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateDescriptorSetLayoutDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSetLayout);
		private static vkCreateDescriptorSetLayoutDelegate vkCreateDescriptorSetLayout_ptr;
		public static VkResult vkCreateDescriptorSetLayout(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSetLayout)
			=> vkCreateDescriptorSetLayout_ptr(device, pCreateInfo, pAllocator, pSetLayout);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyDescriptorSetLayoutDelegate(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, IntPtr pAllocator);
		private static vkDestroyDescriptorSetLayoutDelegate vkDestroyDescriptorSetLayout_ptr;
		public static void vkDestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, IntPtr pAllocator)
			=> vkDestroyDescriptorSetLayout_ptr(device, descriptorSetLayout, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateDescriptorPoolDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDescriptorPool);
		private static vkCreateDescriptorPoolDelegate vkCreateDescriptorPool_ptr;
		public static VkResult vkCreateDescriptorPool(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDescriptorPool)
			=> vkCreateDescriptorPool_ptr(device, pCreateInfo, pAllocator, pDescriptorPool);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, IntPtr pAllocator);
		private static vkDestroyDescriptorPoolDelegate vkDestroyDescriptorPool_ptr;
		public static void vkDestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, IntPtr pAllocator)
			=> vkDestroyDescriptorPool_ptr(device, descriptorPool, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkResetDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, uint flags);
		private static vkResetDescriptorPoolDelegate vkResetDescriptorPool_ptr;
		public static VkResult vkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, uint flags)
			=> vkResetDescriptorPool_ptr(device, descriptorPool, flags);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAllocateDescriptorSetsDelegate(VkDevice device, IntPtr pAllocateInfo, IntPtr pDescriptorSets);
		private static vkAllocateDescriptorSetsDelegate vkAllocateDescriptorSets_ptr;
		public static VkResult vkAllocateDescriptorSets(VkDevice device, IntPtr pAllocateInfo, IntPtr pDescriptorSets)
			=> vkAllocateDescriptorSets_ptr(device, pAllocateInfo, pDescriptorSets);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkFreeDescriptorSetsDelegate(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, IntPtr pDescriptorSets);
		private static vkFreeDescriptorSetsDelegate vkFreeDescriptorSets_ptr;
		public static VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, IntPtr pDescriptorSets)
			=> vkFreeDescriptorSets_ptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkUpdateDescriptorSetsDelegate(VkDevice device, uint descriptorWriteCount, IntPtr pDescriptorWrites, uint descriptorCopyCount, IntPtr pDescriptorCopies);
		private static vkUpdateDescriptorSetsDelegate vkUpdateDescriptorSets_ptr;
		public static void vkUpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, IntPtr pDescriptorWrites, uint descriptorCopyCount, IntPtr pDescriptorCopies)
			=> vkUpdateDescriptorSets_ptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateFramebufferDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pFramebuffer);
		private static vkCreateFramebufferDelegate vkCreateFramebuffer_ptr;
		public static VkResult vkCreateFramebuffer(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pFramebuffer)
			=> vkCreateFramebuffer_ptr(device, pCreateInfo, pAllocator, pFramebuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyFramebufferDelegate(VkDevice device, VkFramebuffer framebuffer, IntPtr pAllocator);
		private static vkDestroyFramebufferDelegate vkDestroyFramebuffer_ptr;
		public static void vkDestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, IntPtr pAllocator)
			=> vkDestroyFramebuffer_ptr(device, framebuffer, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateRenderPassDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pRenderPass);
		private static vkCreateRenderPassDelegate vkCreateRenderPass_ptr;
		public static VkResult vkCreateRenderPass(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pRenderPass)
			=> vkCreateRenderPass_ptr(device, pCreateInfo, pAllocator, pRenderPass);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyRenderPassDelegate(VkDevice device, VkRenderPass renderPass, IntPtr pAllocator);
		private static vkDestroyRenderPassDelegate vkDestroyRenderPass_ptr;
		public static void vkDestroyRenderPass(VkDevice device, VkRenderPass renderPass, IntPtr pAllocator)
			=> vkDestroyRenderPass_ptr(device, renderPass, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetRenderAreaGranularityDelegate(VkDevice device, VkRenderPass renderPass, IntPtr pGranularity);
		private static vkGetRenderAreaGranularityDelegate vkGetRenderAreaGranularity_ptr;
		public static void vkGetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, IntPtr pGranularity)
			=> vkGetRenderAreaGranularity_ptr(device, renderPass, pGranularity);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateCommandPoolDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pCommandPool);
		private static vkCreateCommandPoolDelegate vkCreateCommandPool_ptr;
		public static VkResult vkCreateCommandPool(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pCommandPool)
			=> vkCreateCommandPool_ptr(device, pCreateInfo, pAllocator, pCommandPool);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, IntPtr pAllocator);
		private static vkDestroyCommandPoolDelegate vkDestroyCommandPool_ptr;
		public static void vkDestroyCommandPool(VkDevice device, VkCommandPool commandPool, IntPtr pAllocator)
			=> vkDestroyCommandPool_ptr(device, commandPool, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkResetCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, uint flags);
		private static vkResetCommandPoolDelegate vkResetCommandPool_ptr;
		public static VkResult vkResetCommandPool(VkDevice device, VkCommandPool commandPool, uint flags)
			=> vkResetCommandPool_ptr(device, commandPool, flags);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAllocateCommandBuffersDelegate(VkDevice device, IntPtr pAllocateInfo, IntPtr pCommandBuffers);
		private static vkAllocateCommandBuffersDelegate vkAllocateCommandBuffers_ptr;
		public static VkResult vkAllocateCommandBuffers(VkDevice device, IntPtr pAllocateInfo, IntPtr pCommandBuffers)
			=> vkAllocateCommandBuffers_ptr(device, pAllocateInfo, pCommandBuffers);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkFreeCommandBuffersDelegate(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, IntPtr pCommandBuffers);
		private static vkFreeCommandBuffersDelegate vkFreeCommandBuffers_ptr;
		public static void vkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, IntPtr pCommandBuffers)
			=> vkFreeCommandBuffers_ptr(device, commandPool, commandBufferCount, pCommandBuffers);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkBeginCommandBufferDelegate(VkCommandBuffer commandBuffer, IntPtr pBeginInfo);
		private static vkBeginCommandBufferDelegate vkBeginCommandBuffer_ptr;
		public static VkResult vkBeginCommandBuffer(VkCommandBuffer commandBuffer, IntPtr pBeginInfo)
			=> vkBeginCommandBuffer_ptr(commandBuffer, pBeginInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkEndCommandBufferDelegate(VkCommandBuffer commandBuffer);
		private static vkEndCommandBufferDelegate vkEndCommandBuffer_ptr;
		public static VkResult vkEndCommandBuffer(VkCommandBuffer commandBuffer)
			=> vkEndCommandBuffer_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkResetCommandBufferDelegate(VkCommandBuffer commandBuffer, uint flags);
		private static vkResetCommandBufferDelegate vkResetCommandBuffer_ptr;
		public static VkResult vkResetCommandBuffer(VkCommandBuffer commandBuffer, uint flags)
			=> vkResetCommandBuffer_ptr(commandBuffer, flags);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBindPipelineDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
		private static vkCmdBindPipelineDelegate vkCmdBindPipeline_ptr;
		public static void vkCmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
			=> vkCmdBindPipeline_ptr(commandBuffer, pipelineBindPoint, pipeline);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetViewportDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewports);
		private static vkCmdSetViewportDelegate vkCmdSetViewport_ptr;
		public static void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewports)
			=> vkCmdSetViewport_ptr(commandBuffer, firstViewport, viewportCount, pViewports);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetScissorDelegate(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, IntPtr pScissors);
		private static vkCmdSetScissorDelegate vkCmdSetScissor_ptr;
		public static void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, IntPtr pScissors)
			=> vkCmdSetScissor_ptr(commandBuffer, firstScissor, scissorCount, pScissors);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetLineWidthDelegate(VkCommandBuffer commandBuffer, float lineWidth);
		private static vkCmdSetLineWidthDelegate vkCmdSetLineWidth_ptr;
		public static void vkCmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth)
			=> vkCmdSetLineWidth_ptr(commandBuffer, lineWidth);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetDepthBiasDelegate(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
		private static vkCmdSetDepthBiasDelegate vkCmdSetDepthBias_ptr;
		public static void vkCmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
			=> vkCmdSetDepthBias_ptr(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetBlendConstantsDelegate(VkCommandBuffer commandBuffer, float blendConstants);
		private static vkCmdSetBlendConstantsDelegate vkCmdSetBlendConstants_ptr;
		public static void vkCmdSetBlendConstants(VkCommandBuffer commandBuffer, float blendConstants)
			=> vkCmdSetBlendConstants_ptr(commandBuffer, blendConstants);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetDepthBoundsDelegate(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
		private static vkCmdSetDepthBoundsDelegate vkCmdSetDepthBounds_ptr;
		public static void vkCmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)
			=> vkCmdSetDepthBounds_ptr(commandBuffer, minDepthBounds, maxDepthBounds);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetStencilCompareMaskDelegate(VkCommandBuffer commandBuffer, uint faceMask, uint compareMask);
		private static vkCmdSetStencilCompareMaskDelegate vkCmdSetStencilCompareMask_ptr;
		public static void vkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, uint faceMask, uint compareMask)
			=> vkCmdSetStencilCompareMask_ptr(commandBuffer, faceMask, compareMask);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetStencilWriteMaskDelegate(VkCommandBuffer commandBuffer, uint faceMask, uint writeMask);
		private static vkCmdSetStencilWriteMaskDelegate vkCmdSetStencilWriteMask_ptr;
		public static void vkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, uint faceMask, uint writeMask)
			=> vkCmdSetStencilWriteMask_ptr(commandBuffer, faceMask, writeMask);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetStencilReferenceDelegate(VkCommandBuffer commandBuffer, uint faceMask, uint reference);
		private static vkCmdSetStencilReferenceDelegate vkCmdSetStencilReference_ptr;
		public static void vkCmdSetStencilReference(VkCommandBuffer commandBuffer, uint faceMask, uint reference)
			=> vkCmdSetStencilReference_ptr(commandBuffer, faceMask, reference);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBindDescriptorSetsDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, IntPtr pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
		private static vkCmdBindDescriptorSetsDelegate vkCmdBindDescriptorSets_ptr;
		public static void vkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, IntPtr pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
			=> vkCmdBindDescriptorSets_ptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBindIndexBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType);
		private static vkCmdBindIndexBufferDelegate vkCmdBindIndexBuffer_ptr;
		public static void vkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType)
			=> vkCmdBindIndexBuffer_ptr(commandBuffer, buffer, offset, indexType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBindVertexBuffersDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets);
		private static vkCmdBindVertexBuffersDelegate vkCmdBindVertexBuffers_ptr;
		public static void vkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets)
			=> vkCmdBindVertexBuffers_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawDelegate(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		private static vkCmdDrawDelegate vkCmdDraw_ptr;
		public static void vkCmdDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
			=> vkCmdDraw_ptr(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawIndexedDelegate(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
		private static vkCmdDrawIndexedDelegate vkCmdDrawIndexed_ptr;
		public static void vkCmdDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
			=> vkCmdDrawIndexed_ptr(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawIndirectDelegate vkCmdDrawIndirect_ptr;
		public static void vkCmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawIndirect_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawIndexedIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawIndexedIndirectDelegate vkCmdDrawIndexedIndirect_ptr;
		public static void vkCmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawIndexedIndirect_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDispatchDelegate(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
		private static vkCmdDispatchDelegate vkCmdDispatch_ptr;
		public static void vkCmdDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
			=> vkCmdDispatch_ptr(commandBuffer, groupCountX, groupCountY, groupCountZ);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDispatchIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset);
		private static vkCmdDispatchIndirectDelegate vkCmdDispatchIndirect_ptr;
		public static void vkCmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
			=> vkCmdDispatchIndirect_ptr(commandBuffer, buffer, offset);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdCopyBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, IntPtr pRegions);
		private static vkCmdCopyBufferDelegate vkCmdCopyBuffer_ptr;
		public static void vkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, IntPtr pRegions)
			=> vkCmdCopyBuffer_ptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdCopyImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions);
		private static vkCmdCopyImageDelegate vkCmdCopyImage_ptr;
		public static void vkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions)
			=> vkCmdCopyImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBlitImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions, VkFilter filter);
		private static vkCmdBlitImageDelegate vkCmdBlitImage_ptr;
		public static void vkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions, VkFilter filter)
			=> vkCmdBlitImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdCopyBufferToImageDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions);
		private static vkCmdCopyBufferToImageDelegate vkCmdCopyBufferToImage_ptr;
		public static void vkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions)
			=> vkCmdCopyBufferToImage_ptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdCopyImageToBufferDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, IntPtr pRegions);
		private static vkCmdCopyImageToBufferDelegate vkCmdCopyImageToBuffer_ptr;
		public static void vkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, IntPtr pRegions)
			=> vkCmdCopyImageToBuffer_ptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdUpdateBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData);
		private static vkCmdUpdateBufferDelegate vkCmdUpdateBuffer_ptr;
		public static void vkCmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
			=> vkCmdUpdateBuffer_ptr(commandBuffer, dstBuffer, dstOffset, dataSize, pData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdFillBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data);
		private static vkCmdFillBufferDelegate vkCmdFillBuffer_ptr;
		public static void vkCmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data)
			=> vkCmdFillBuffer_ptr(commandBuffer, dstBuffer, dstOffset, size, data);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdClearColorImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, IntPtr pColor, uint rangeCount, IntPtr pRanges);
		private static vkCmdClearColorImageDelegate vkCmdClearColorImage_ptr;
		public static void vkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, IntPtr pColor, uint rangeCount, IntPtr pRanges)
			=> vkCmdClearColorImage_ptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdClearDepthStencilImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, IntPtr pDepthStencil, uint rangeCount, IntPtr pRanges);
		private static vkCmdClearDepthStencilImageDelegate vkCmdClearDepthStencilImage_ptr;
		public static void vkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, IntPtr pDepthStencil, uint rangeCount, IntPtr pRanges)
			=> vkCmdClearDepthStencilImage_ptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdClearAttachmentsDelegate(VkCommandBuffer commandBuffer, uint attachmentCount, IntPtr pAttachments, uint rectCount, IntPtr pRects);
		private static vkCmdClearAttachmentsDelegate vkCmdClearAttachments_ptr;
		public static void vkCmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, IntPtr pAttachments, uint rectCount, IntPtr pRects)
			=> vkCmdClearAttachments_ptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdResolveImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions);
		private static vkCmdResolveImageDelegate vkCmdResolveImage_ptr;
		public static void vkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, IntPtr pRegions)
			=> vkCmdResolveImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetEventDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, uint stageMask);
		private static vkCmdSetEventDelegate vkCmdSetEvent_ptr;
		public static void vkCmdSetEvent(VkCommandBuffer commandBuffer, VkEvent vkEvent, uint stageMask)
			=> vkCmdSetEvent_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdResetEventDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, uint stageMask);
		private static vkCmdResetEventDelegate vkCmdResetEvent_ptr;
		public static void vkCmdResetEvent(VkCommandBuffer commandBuffer, VkEvent vkEvent, uint stageMask)
			=> vkCmdResetEvent_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdWaitEventsDelegate(VkCommandBuffer commandBuffer, uint eventCount, IntPtr pEvents, uint srcStageMask, uint dstStageMask, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers);
		private static vkCmdWaitEventsDelegate vkCmdWaitEvents_ptr;
		public static void vkCmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, IntPtr pEvents, uint srcStageMask, uint dstStageMask, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers)
			=> vkCmdWaitEvents_ptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdPipelineBarrierDelegate(VkCommandBuffer commandBuffer, uint srcStageMask, uint dstStageMask, uint dependencyFlags, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers);
		private static vkCmdPipelineBarrierDelegate vkCmdPipelineBarrier_ptr;
		public static void vkCmdPipelineBarrier(VkCommandBuffer commandBuffer, uint srcStageMask, uint dstStageMask, uint dependencyFlags, uint memoryBarrierCount, IntPtr pMemoryBarriers, uint bufferMemoryBarrierCount, IntPtr pBufferMemoryBarriers, uint imageMemoryBarrierCount, IntPtr pImageMemoryBarriers)
			=> vkCmdPipelineBarrier_ptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBeginQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint flags);
		private static vkCmdBeginQueryDelegate vkCmdBeginQuery_ptr;
		public static void vkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint flags)
			=> vkCmdBeginQuery_ptr(commandBuffer, queryPool, query, flags);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdEndQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
		private static vkCmdEndQueryDelegate vkCmdEndQuery_ptr;
		public static void vkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
			=> vkCmdEndQuery_ptr(commandBuffer, queryPool, query);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBeginConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pConditionalRenderingBegin);
		private static vkCmdBeginConditionalRenderingEXTDelegate vkCmdBeginConditionalRenderingEXT_ptr;
		public static void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, IntPtr pConditionalRenderingBegin)
			=> vkCmdBeginConditionalRenderingEXT_ptr(commandBuffer, pConditionalRenderingBegin);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdEndConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndConditionalRenderingEXTDelegate vkCmdEndConditionalRenderingEXT_ptr;
		public static void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
			=> vkCmdEndConditionalRenderingEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdResetQueryPoolDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private static vkCmdResetQueryPoolDelegate vkCmdResetQueryPool_ptr;
		public static void vkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
			=> vkCmdResetQueryPool_ptr(commandBuffer, queryPool, firstQuery, queryCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdWriteTimestampDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query);
		private static vkCmdWriteTimestampDelegate vkCmdWriteTimestamp_ptr;
		public static void vkCmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query)
			=> vkCmdWriteTimestamp_ptr(commandBuffer, pipelineStage, queryPool, query);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdCopyQueryPoolResultsDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, uint flags);
		private static vkCmdCopyQueryPoolResultsDelegate vkCmdCopyQueryPoolResults_ptr;
		public static void vkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, uint flags)
			=> vkCmdCopyQueryPoolResults_ptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdPushConstantsDelegate(VkCommandBuffer commandBuffer, VkPipelineLayout layout, uint stageFlags, uint offset, uint size, void* pValues);
		private static vkCmdPushConstantsDelegate vkCmdPushConstants_ptr;
		public static void vkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, uint stageFlags, uint offset, uint size, void* pValues)
			=> vkCmdPushConstants_ptr(commandBuffer, layout, stageFlags, offset, size, pValues);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBeginRenderPassDelegate(VkCommandBuffer commandBuffer, IntPtr pRenderPassBegin, VkSubpassContents contents);
		private static vkCmdBeginRenderPassDelegate vkCmdBeginRenderPass_ptr;
		public static void vkCmdBeginRenderPass(VkCommandBuffer commandBuffer, IntPtr pRenderPassBegin, VkSubpassContents contents)
			=> vkCmdBeginRenderPass_ptr(commandBuffer, pRenderPassBegin, contents);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdNextSubpassDelegate(VkCommandBuffer commandBuffer, VkSubpassContents contents);
		private static vkCmdNextSubpassDelegate vkCmdNextSubpass_ptr;
		public static void vkCmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents)
			=> vkCmdNextSubpass_ptr(commandBuffer, contents);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdEndRenderPassDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndRenderPassDelegate vkCmdEndRenderPass_ptr;
		public static void vkCmdEndRenderPass(VkCommandBuffer commandBuffer)
			=> vkCmdEndRenderPass_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdExecuteCommandsDelegate(VkCommandBuffer commandBuffer, uint commandBufferCount, IntPtr pCommandBuffers);
		private static vkCmdExecuteCommandsDelegate vkCmdExecuteCommands_ptr;
		public static void vkCmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, IntPtr pCommandBuffers)
			=> vkCmdExecuteCommands_ptr(commandBuffer, commandBufferCount, pCommandBuffers);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateAndroidSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateAndroidSurfaceKHRDelegate vkCreateAndroidSurfaceKHR_ptr;
		public static VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateAndroidSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceDisplayPropertiesKHRDelegate vkGetPhysicalDeviceDisplayPropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceDisplayPropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDisplayPlaneSupportedDisplaysKHRDelegate(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, IntPtr pDisplays);
		private static vkGetDisplayPlaneSupportedDisplaysKHRDelegate vkGetDisplayPlaneSupportedDisplaysKHR_ptr;
		public static VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, IntPtr pDisplays)
			=> vkGetDisplayPlaneSupportedDisplaysKHR_ptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDisplayModePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetDisplayModePropertiesKHRDelegate vkGetDisplayModePropertiesKHR_ptr;
		public static VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetDisplayModePropertiesKHR_ptr(physicalDevice, display, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateDisplayModeKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pMode);
		private static vkCreateDisplayModeKHRDelegate vkCreateDisplayModeKHR_ptr;
		public static VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pMode)
			=> vkCreateDisplayModeKHR_ptr(physicalDevice, display, pCreateInfo, pAllocator, pMode);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDisplayPlaneCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, IntPtr pCapabilities);
		private static vkGetDisplayPlaneCapabilitiesKHRDelegate vkGetDisplayPlaneCapabilitiesKHR_ptr;
		public static VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, IntPtr pCapabilities)
			=> vkGetDisplayPlaneCapabilitiesKHR_ptr(physicalDevice, mode, planeIndex, pCapabilities);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateDisplayPlaneSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateDisplayPlaneSurfaceKHRDelegate vkCreateDisplayPlaneSurfaceKHR_ptr;
		public static VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateDisplayPlaneSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateSharedSwapchainsKHRDelegate(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pSwapchains);
		private static vkCreateSharedSwapchainsKHRDelegate vkCreateSharedSwapchainsKHR_ptr;
		public static VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pSwapchains)
			=> vkCreateSharedSwapchainsKHR_ptr(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroySurfaceKHRDelegate(VkInstance instance, VkSurfaceKHR surface, IntPtr pAllocator);
		private static vkDestroySurfaceKHRDelegate vkDestroySurfaceKHR_ptr;
		public static void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, IntPtr pAllocator)
			=> vkDestroySurfaceKHR_ptr(instance, surface, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, IntPtr pSupported);
		private static vkGetPhysicalDeviceSurfaceSupportKHRDelegate vkGetPhysicalDeviceSurfaceSupportKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, IntPtr pSupported)
			=> vkGetPhysicalDeviceSurfaceSupportKHR_ptr(physicalDevice, queueFamilyIndex, surface, pSupported);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr(physicalDevice, surface, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceFormatsKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats);
		private static vkGetPhysicalDeviceSurfaceFormatsKHRDelegate vkGetPhysicalDeviceSurfaceFormatsKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats)
			=> vkGetPhysicalDeviceSurfaceFormatsKHR_ptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceSurfacePresentModesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, IntPtr pPresentModes);
		private static vkGetPhysicalDeviceSurfacePresentModesKHRDelegate vkGetPhysicalDeviceSurfacePresentModesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, IntPtr pPresentModes)
			=> vkGetPhysicalDeviceSurfacePresentModesKHR_ptr(physicalDevice, surface, pPresentModeCount, pPresentModes);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateSwapchainKHRDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSwapchain);
		private static vkCreateSwapchainKHRDelegate vkCreateSwapchainKHR_ptr;
		public static VkResult vkCreateSwapchainKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSwapchain)
			=> vkCreateSwapchainKHR_ptr(device, pCreateInfo, pAllocator, pSwapchain);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroySwapchainKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, IntPtr pAllocator);
		private static vkDestroySwapchainKHRDelegate vkDestroySwapchainKHR_ptr;
		public static void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, IntPtr pAllocator)
			=> vkDestroySwapchainKHR_ptr(device, swapchain, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetSwapchainImagesKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, IntPtr pSwapchainImages);
		private static vkGetSwapchainImagesKHRDelegate vkGetSwapchainImagesKHR_ptr;
		public static VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, IntPtr pSwapchainImages)
			=> vkGetSwapchainImagesKHR_ptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAcquireNextImageKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex);
		private static vkAcquireNextImageKHRDelegate vkAcquireNextImageKHR_ptr;
		public static VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
			=> vkAcquireNextImageKHR_ptr(device, swapchain, timeout, semaphore, fence, pImageIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkQueuePresentKHRDelegate(VkQueue queue, IntPtr pPresentInfo);
		private static vkQueuePresentKHRDelegate vkQueuePresentKHR_ptr;
		public static VkResult vkQueuePresentKHR(VkQueue queue, IntPtr pPresentInfo)
			=> vkQueuePresentKHR_ptr(queue, pPresentInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateViSurfaceNNDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateViSurfaceNNDelegate vkCreateViSurfaceNN_ptr;
		public static VkResult vkCreateViSurfaceNN(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateViSurfaceNN_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateWaylandSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateWaylandSurfaceKHRDelegate vkCreateWaylandSurfaceKHR_ptr;
		public static VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateWaylandSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate uint vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display);
		private static vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr;
		public static uint vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display)
			=> vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, display);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateWin32SurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateWin32SurfaceKHRDelegate vkCreateWin32SurfaceKHR_ptr;
		public static VkResult vkCreateWin32SurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateWin32SurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate uint vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex);
		private static vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr;
		public static uint vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
			=> vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateXlibSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateXlibSurfaceKHRDelegate vkCreateXlibSurfaceKHR_ptr;
		public static VkResult vkCreateXlibSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateXlibSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate uint vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID);
		private static vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr;
		public static uint vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
			=> vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, dpy, visualID);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateXcbSurfaceKHRDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateXcbSurfaceKHRDelegate vkCreateXcbSurfaceKHR_ptr;
		public static VkResult vkCreateXcbSurfaceKHR(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateXcbSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate uint vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, IntPtr visual_id);
		private static vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr;
		public static uint vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, IntPtr visual_id)
			=> vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, connection, visual_id);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateImagePipeSurfaceFUCHSIADelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateImagePipeSurfaceFUCHSIADelegate vkCreateImagePipeSurfaceFUCHSIA_ptr;
		public static VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateImagePipeSurfaceFUCHSIA_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateStreamDescriptorSurfaceGGPDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateStreamDescriptorSurfaceGGPDelegate vkCreateStreamDescriptorSurfaceGGP_ptr;
		public static VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateStreamDescriptorSurfaceGGP_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateDebugReportCallbackEXTDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pCallback);
		private static vkCreateDebugReportCallbackEXTDelegate vkCreateDebugReportCallbackEXT_ptr;
		public static VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pCallback)
			=> vkCreateDebugReportCallbackEXT_ptr(instance, pCreateInfo, pAllocator, pCallback);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyDebugReportCallbackEXTDelegate(VkInstance instance, VkDebugReportCallbackEXT callback, IntPtr pAllocator);
		private static vkDestroyDebugReportCallbackEXTDelegate vkDestroyDebugReportCallbackEXT_ptr;
		public static void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, IntPtr pAllocator)
			=> vkDestroyDebugReportCallbackEXT_ptr(instance, callback, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDebugReportMessageEXTDelegate(VkInstance instance, uint flags, VkDebugReportObjectTypeEXT objectType, ulong vkObject, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage);
		private static vkDebugReportMessageEXTDelegate vkDebugReportMessageEXT_ptr;
		public static void vkDebugReportMessageEXT(VkInstance instance, uint flags, VkDebugReportObjectTypeEXT objectType, ulong vkObject, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage)
			=> vkDebugReportMessageEXT_ptr(instance, flags, objectType, vkObject, location, messageCode, pLayerPrefix, pMessage);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkDebugMarkerSetObjectNameEXTDelegate(VkDevice device, IntPtr pNameInfo);
		private static vkDebugMarkerSetObjectNameEXTDelegate vkDebugMarkerSetObjectNameEXT_ptr;
		public static VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, IntPtr pNameInfo)
			=> vkDebugMarkerSetObjectNameEXT_ptr(device, pNameInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkDebugMarkerSetObjectTagEXTDelegate(VkDevice device, IntPtr pTagInfo);
		private static vkDebugMarkerSetObjectTagEXTDelegate vkDebugMarkerSetObjectTagEXT_ptr;
		public static VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, IntPtr pTagInfo)
			=> vkDebugMarkerSetObjectTagEXT_ptr(device, pTagInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDebugMarkerBeginEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo);
		private static vkCmdDebugMarkerBeginEXTDelegate vkCmdDebugMarkerBeginEXT_ptr;
		public static void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
			=> vkCmdDebugMarkerBeginEXT_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDebugMarkerEndEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdDebugMarkerEndEXTDelegate vkCmdDebugMarkerEndEXT_ptr;
		public static void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
			=> vkCmdDebugMarkerEndEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDebugMarkerInsertEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo);
		private static vkCmdDebugMarkerInsertEXTDelegate vkCmdDebugMarkerInsertEXT_ptr;
		public static void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
			=> vkCmdDebugMarkerInsertEXT_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, uint externalHandleType, IntPtr pExternalImageFormatProperties);
		private static vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr;
		public static VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, uint externalHandleType, IntPtr pExternalImageFormatProperties)
			=> vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetMemoryWin32HandleNVDelegate(VkDevice device, VkDeviceMemory memory, uint handleType, IntPtr pHandle);
		private static vkGetMemoryWin32HandleNVDelegate vkGetMemoryWin32HandleNV_ptr;
		public static VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, uint handleType, IntPtr pHandle)
			=> vkGetMemoryWin32HandleNV_ptr(device, memory, handleType, pHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdExecuteGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, uint isPreprocessed, IntPtr pGeneratedCommandsInfo);
		private static vkCmdExecuteGeneratedCommandsNVDelegate vkCmdExecuteGeneratedCommandsNV_ptr;
		public static void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, uint isPreprocessed, IntPtr pGeneratedCommandsInfo)
			=> vkCmdExecuteGeneratedCommandsNV_ptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdPreprocessGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, IntPtr pGeneratedCommandsInfo);
		private static vkCmdPreprocessGeneratedCommandsNVDelegate vkCmdPreprocessGeneratedCommandsNV_ptr;
		public static void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, IntPtr pGeneratedCommandsInfo)
			=> vkCmdPreprocessGeneratedCommandsNV_ptr(commandBuffer, pGeneratedCommandsInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBindPipelineShaderGroupNVDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex);
		private static vkCmdBindPipelineShaderGroupNVDelegate vkCmdBindPipelineShaderGroupNV_ptr;
		public static void vkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
			=> vkCmdBindPipelineShaderGroupNV_ptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetGeneratedCommandsMemoryRequirementsNVDelegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetGeneratedCommandsMemoryRequirementsNVDelegate vkGetGeneratedCommandsMemoryRequirementsNV_ptr;
		public static void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetGeneratedCommandsMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateIndirectCommandsLayoutNVDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pIndirectCommandsLayout);
		private static vkCreateIndirectCommandsLayoutNVDelegate vkCreateIndirectCommandsLayoutNV_ptr;
		public static VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pIndirectCommandsLayout)
			=> vkCreateIndirectCommandsLayoutNV_ptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyIndirectCommandsLayoutNVDelegate(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, IntPtr pAllocator);
		private static vkDestroyIndirectCommandsLayoutNVDelegate vkDestroyIndirectCommandsLayoutNV_ptr;
		public static void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, IntPtr pAllocator)
			=> vkDestroyIndirectCommandsLayoutNV_ptr(device, indirectCommandsLayout, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceFeatures2Delegate(VkPhysicalDevice physicalDevice, IntPtr pFeatures);
		private static vkGetPhysicalDeviceFeatures2Delegate vkGetPhysicalDeviceFeatures2_ptr;
		public static void vkGetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, IntPtr pFeatures)
			=> vkGetPhysicalDeviceFeatures2_ptr(physicalDevice, pFeatures);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceProperties2Delegate(VkPhysicalDevice physicalDevice, IntPtr pProperties);
		private static vkGetPhysicalDeviceProperties2Delegate vkGetPhysicalDeviceProperties2_ptr;
		public static void vkGetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, IntPtr pProperties)
			=> vkGetPhysicalDeviceProperties2_ptr(physicalDevice, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceFormatProperties2Delegate(VkPhysicalDevice physicalDevice, VkFormat format, IntPtr pFormatProperties);
		private static vkGetPhysicalDeviceFormatProperties2Delegate vkGetPhysicalDeviceFormatProperties2_ptr;
		public static void vkGetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, IntPtr pFormatProperties)
			=> vkGetPhysicalDeviceFormatProperties2_ptr(physicalDevice, format, pFormatProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, IntPtr pImageFormatInfo, IntPtr pImageFormatProperties);
		private static vkGetPhysicalDeviceImageFormatProperties2Delegate vkGetPhysicalDeviceImageFormatProperties2_ptr;
		public static VkResult vkGetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, IntPtr pImageFormatInfo, IntPtr pImageFormatProperties)
			=> vkGetPhysicalDeviceImageFormatProperties2_ptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceQueueFamilyProperties2Delegate(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties);
		private static vkGetPhysicalDeviceQueueFamilyProperties2Delegate vkGetPhysicalDeviceQueueFamilyProperties2_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, IntPtr pQueueFamilyProperties)
			=> vkGetPhysicalDeviceQueueFamilyProperties2_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceMemoryProperties2Delegate(VkPhysicalDevice physicalDevice, IntPtr pMemoryProperties);
		private static vkGetPhysicalDeviceMemoryProperties2Delegate vkGetPhysicalDeviceMemoryProperties2_ptr;
		public static void vkGetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, IntPtr pMemoryProperties)
			=> vkGetPhysicalDeviceMemoryProperties2_ptr(physicalDevice, pMemoryProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceSparseImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, IntPtr pFormatInfo, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceSparseImageFormatProperties2Delegate vkGetPhysicalDeviceSparseImageFormatProperties2_ptr;
		public static void vkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, IntPtr pFormatInfo, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceSparseImageFormatProperties2_ptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdPushDescriptorSetKHRDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, IntPtr pDescriptorWrites);
		private static vkCmdPushDescriptorSetKHRDelegate vkCmdPushDescriptorSetKHR_ptr;
		public static void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, IntPtr pDescriptorWrites)
			=> vkCmdPushDescriptorSetKHR_ptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkTrimCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, uint flags);
		private static vkTrimCommandPoolDelegate vkTrimCommandPool_ptr;
		public static void vkTrimCommandPool(VkDevice device, VkCommandPool commandPool, uint flags)
			=> vkTrimCommandPool_ptr(device, commandPool, flags);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceExternalBufferPropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pExternalBufferInfo, IntPtr pExternalBufferProperties);
		private static vkGetPhysicalDeviceExternalBufferPropertiesDelegate vkGetPhysicalDeviceExternalBufferProperties_ptr;
		public static void vkGetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, IntPtr pExternalBufferInfo, IntPtr pExternalBufferProperties)
			=> vkGetPhysicalDeviceExternalBufferProperties_ptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetMemoryWin32HandleKHRDelegate(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetMemoryWin32HandleKHRDelegate vkGetMemoryWin32HandleKHR_ptr;
		public static VkResult vkGetMemoryWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetMemoryWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetMemoryWin32HandlePropertiesKHRDelegate(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, IntPtr pMemoryWin32HandleProperties);
		private static vkGetMemoryWin32HandlePropertiesKHRDelegate vkGetMemoryWin32HandlePropertiesKHR_ptr;
		public static VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, IntPtr pMemoryWin32HandleProperties)
			=> vkGetMemoryWin32HandlePropertiesKHR_ptr(device, handleType, handle, pMemoryWin32HandleProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetMemoryFdKHRDelegate(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd);
		private static vkGetMemoryFdKHRDelegate vkGetMemoryFdKHR_ptr;
		public static VkResult vkGetMemoryFdKHR(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd)
			=> vkGetMemoryFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetMemoryFdPropertiesKHRDelegate(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, IntPtr pMemoryFdProperties);
		private static vkGetMemoryFdPropertiesKHRDelegate vkGetMemoryFdPropertiesKHR_ptr;
		public static VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, IntPtr pMemoryFdProperties)
			=> vkGetMemoryFdPropertiesKHR_ptr(device, handleType, fd, pMemoryFdProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pExternalSemaphoreInfo, IntPtr pExternalSemaphoreProperties);
		private static vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate vkGetPhysicalDeviceExternalSemaphoreProperties_ptr;
		public static void vkGetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, IntPtr pExternalSemaphoreInfo, IntPtr pExternalSemaphoreProperties)
			=> vkGetPhysicalDeviceExternalSemaphoreProperties_ptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetSemaphoreWin32HandleKHRDelegate(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetSemaphoreWin32HandleKHRDelegate vkGetSemaphoreWin32HandleKHR_ptr;
		public static VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetSemaphoreWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkImportSemaphoreWin32HandleKHRDelegate(VkDevice device, IntPtr pImportSemaphoreWin32HandleInfo);
		private static vkImportSemaphoreWin32HandleKHRDelegate vkImportSemaphoreWin32HandleKHR_ptr;
		public static VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, IntPtr pImportSemaphoreWin32HandleInfo)
			=> vkImportSemaphoreWin32HandleKHR_ptr(device, pImportSemaphoreWin32HandleInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetSemaphoreFdKHRDelegate(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd);
		private static vkGetSemaphoreFdKHRDelegate vkGetSemaphoreFdKHR_ptr;
		public static VkResult vkGetSemaphoreFdKHR(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd)
			=> vkGetSemaphoreFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkImportSemaphoreFdKHRDelegate(VkDevice device, IntPtr pImportSemaphoreFdInfo);
		private static vkImportSemaphoreFdKHRDelegate vkImportSemaphoreFdKHR_ptr;
		public static VkResult vkImportSemaphoreFdKHR(VkDevice device, IntPtr pImportSemaphoreFdInfo)
			=> vkImportSemaphoreFdKHR_ptr(device, pImportSemaphoreFdInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceExternalFencePropertiesDelegate(VkPhysicalDevice physicalDevice, IntPtr pExternalFenceInfo, IntPtr pExternalFenceProperties);
		private static vkGetPhysicalDeviceExternalFencePropertiesDelegate vkGetPhysicalDeviceExternalFenceProperties_ptr;
		public static void vkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, IntPtr pExternalFenceInfo, IntPtr pExternalFenceProperties)
			=> vkGetPhysicalDeviceExternalFenceProperties_ptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetFenceWin32HandleKHRDelegate(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetFenceWin32HandleKHRDelegate vkGetFenceWin32HandleKHR_ptr;
		public static VkResult vkGetFenceWin32HandleKHR(VkDevice device, IntPtr pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetFenceWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkImportFenceWin32HandleKHRDelegate(VkDevice device, IntPtr pImportFenceWin32HandleInfo);
		private static vkImportFenceWin32HandleKHRDelegate vkImportFenceWin32HandleKHR_ptr;
		public static VkResult vkImportFenceWin32HandleKHR(VkDevice device, IntPtr pImportFenceWin32HandleInfo)
			=> vkImportFenceWin32HandleKHR_ptr(device, pImportFenceWin32HandleInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetFenceFdKHRDelegate(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd);
		private static vkGetFenceFdKHRDelegate vkGetFenceFdKHR_ptr;
		public static VkResult vkGetFenceFdKHR(VkDevice device, IntPtr pGetFdInfo, IntPtr pFd)
			=> vkGetFenceFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkImportFenceFdKHRDelegate(VkDevice device, IntPtr pImportFenceFdInfo);
		private static vkImportFenceFdKHRDelegate vkImportFenceFdKHR_ptr;
		public static VkResult vkImportFenceFdKHR(VkDevice device, IntPtr pImportFenceFdInfo)
			=> vkImportFenceFdKHR_ptr(device, pImportFenceFdInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkReleaseDisplayEXTDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
		private static vkReleaseDisplayEXTDelegate vkReleaseDisplayEXT_ptr;
		public static VkResult vkReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
			=> vkReleaseDisplayEXT_ptr(physicalDevice, display);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAcquireXlibDisplayEXTDelegate(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display);
		private static vkAcquireXlibDisplayEXTDelegate vkAcquireXlibDisplayEXT_ptr;
		public static VkResult vkAcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
			=> vkAcquireXlibDisplayEXT_ptr(physicalDevice, dpy, display);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetRandROutputDisplayEXTDelegate(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, IntPtr pDisplay);
		private static vkGetRandROutputDisplayEXTDelegate vkGetRandROutputDisplayEXT_ptr;
		public static VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, IntPtr pDisplay)
			=> vkGetRandROutputDisplayEXT_ptr(physicalDevice, dpy, rrOutput, pDisplay);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkDisplayPowerControlEXTDelegate(VkDevice device, VkDisplayKHR display, IntPtr pDisplayPowerInfo);
		private static vkDisplayPowerControlEXTDelegate vkDisplayPowerControlEXT_ptr;
		public static VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayPowerInfo)
			=> vkDisplayPowerControlEXT_ptr(device, display, pDisplayPowerInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkRegisterDeviceEventEXTDelegate(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence);
		private static vkRegisterDeviceEventEXTDelegate vkRegisterDeviceEventEXT_ptr;
		public static VkResult vkRegisterDeviceEventEXT(VkDevice device, IntPtr pDeviceEventInfo, IntPtr pAllocator, IntPtr pFence)
			=> vkRegisterDeviceEventEXT_ptr(device, pDeviceEventInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkRegisterDisplayEventEXTDelegate(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence);
		private static vkRegisterDisplayEventEXTDelegate vkRegisterDisplayEventEXT_ptr;
		public static VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, IntPtr pDisplayEventInfo, IntPtr pAllocator, IntPtr pFence)
			=> vkRegisterDisplayEventEXT_ptr(device, display, pDisplayEventInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetSwapchainCounterEXTDelegate(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue);
		private static vkGetSwapchainCounterEXTDelegate vkGetSwapchainCounterEXT_ptr;
		public static VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue)
			=> vkGetSwapchainCounterEXT_ptr(device, swapchain, counter, pCounterValue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, IntPtr pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr(physicalDevice, surface, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkEnumeratePhysicalDeviceGroupsDelegate(VkInstance instance, uint* pPhysicalDeviceGroupCount, IntPtr pPhysicalDeviceGroupProperties);
		private static vkEnumeratePhysicalDeviceGroupsDelegate vkEnumeratePhysicalDeviceGroups_ptr;
		public static VkResult vkEnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, IntPtr pPhysicalDeviceGroupProperties)
			=> vkEnumeratePhysicalDeviceGroups_ptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetDeviceGroupPeerMemoryFeaturesDelegate(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, IntPtr pPeerMemoryFeatures);
		private static vkGetDeviceGroupPeerMemoryFeaturesDelegate vkGetDeviceGroupPeerMemoryFeatures_ptr;
		public static void vkGetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, IntPtr pPeerMemoryFeatures)
			=> vkGetDeviceGroupPeerMemoryFeatures_ptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkBindBufferMemory2Delegate(VkDevice device, uint bindInfoCount, IntPtr pBindInfos);
		private static vkBindBufferMemory2Delegate vkBindBufferMemory2_ptr;
		public static VkResult vkBindBufferMemory2(VkDevice device, uint bindInfoCount, IntPtr pBindInfos)
			=> vkBindBufferMemory2_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkBindImageMemory2Delegate(VkDevice device, uint bindInfoCount, IntPtr pBindInfos);
		private static vkBindImageMemory2Delegate vkBindImageMemory2_ptr;
		public static VkResult vkBindImageMemory2(VkDevice device, uint bindInfoCount, IntPtr pBindInfos)
			=> vkBindImageMemory2_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetDeviceMaskDelegate(VkCommandBuffer commandBuffer, uint deviceMask);
		private static vkCmdSetDeviceMaskDelegate vkCmdSetDeviceMask_ptr;
		public static void vkCmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
			=> vkCmdSetDeviceMask_ptr(commandBuffer, deviceMask);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDeviceGroupPresentCapabilitiesKHRDelegate(VkDevice device, IntPtr pDeviceGroupPresentCapabilities);
		private static vkGetDeviceGroupPresentCapabilitiesKHRDelegate vkGetDeviceGroupPresentCapabilitiesKHR_ptr;
		public static VkResult vkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, IntPtr pDeviceGroupPresentCapabilities)
			=> vkGetDeviceGroupPresentCapabilitiesKHR_ptr(device, pDeviceGroupPresentCapabilities);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDeviceGroupSurfacePresentModesKHRDelegate(VkDevice device, VkSurfaceKHR surface, IntPtr pModes);
		private static vkGetDeviceGroupSurfacePresentModesKHRDelegate vkGetDeviceGroupSurfacePresentModesKHR_ptr;
		public static VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, IntPtr pModes)
			=> vkGetDeviceGroupSurfacePresentModesKHR_ptr(device, surface, pModes);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAcquireNextImage2KHRDelegate(VkDevice device, IntPtr pAcquireInfo, uint* pImageIndex);
		private static vkAcquireNextImage2KHRDelegate vkAcquireNextImage2KHR_ptr;
		public static VkResult vkAcquireNextImage2KHR(VkDevice device, IntPtr pAcquireInfo, uint* pImageIndex)
			=> vkAcquireNextImage2KHR_ptr(device, pAcquireInfo, pImageIndex);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDispatchBaseDelegate(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
		private static vkCmdDispatchBaseDelegate vkCmdDispatchBase_ptr;
		public static void vkCmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
			=> vkCmdDispatchBase_ptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDevicePresentRectanglesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, IntPtr pRects);
		private static vkGetPhysicalDevicePresentRectanglesKHRDelegate vkGetPhysicalDevicePresentRectanglesKHR_ptr;
		public static VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, IntPtr pRects)
			=> vkGetPhysicalDevicePresentRectanglesKHR_ptr(physicalDevice, surface, pRectCount, pRects);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateDescriptorUpdateTemplateDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDescriptorUpdateTemplate);
		private static vkCreateDescriptorUpdateTemplateDelegate vkCreateDescriptorUpdateTemplate_ptr;
		public static VkResult vkCreateDescriptorUpdateTemplate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pDescriptorUpdateTemplate)
			=> vkCreateDescriptorUpdateTemplate_ptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyDescriptorUpdateTemplateDelegate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr pAllocator);
		private static vkDestroyDescriptorUpdateTemplateDelegate vkDestroyDescriptorUpdateTemplate_ptr;
		public static void vkDestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr pAllocator)
			=> vkDestroyDescriptorUpdateTemplate_ptr(device, descriptorUpdateTemplate, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkUpdateDescriptorSetWithTemplateDelegate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
		private static vkUpdateDescriptorSetWithTemplateDelegate vkUpdateDescriptorSetWithTemplate_ptr;
		public static void vkUpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
			=> vkUpdateDescriptorSetWithTemplate_ptr(device, descriptorSet, descriptorUpdateTemplate, pData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdPushDescriptorSetWithTemplateKHRDelegate(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData);
		private static vkCmdPushDescriptorSetWithTemplateKHRDelegate vkCmdPushDescriptorSetWithTemplateKHR_ptr;
		public static void vkCmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
			=> vkCmdPushDescriptorSetWithTemplateKHR_ptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkSetHdrMetadataEXTDelegate(VkDevice device, uint swapchainCount, IntPtr pSwapchains, IntPtr pMetadata);
		private static vkSetHdrMetadataEXTDelegate vkSetHdrMetadataEXT_ptr;
		public static void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, IntPtr pSwapchains, IntPtr pMetadata)
			=> vkSetHdrMetadataEXT_ptr(device, swapchainCount, pSwapchains, pMetadata);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetSwapchainStatusKHRDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkGetSwapchainStatusKHRDelegate vkGetSwapchainStatusKHR_ptr;
		public static VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
			=> vkGetSwapchainStatusKHR_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetRefreshCycleDurationGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, IntPtr pDisplayTimingProperties);
		private static vkGetRefreshCycleDurationGOOGLEDelegate vkGetRefreshCycleDurationGOOGLE_ptr;
		public static VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, IntPtr pDisplayTimingProperties)
			=> vkGetRefreshCycleDurationGOOGLE_ptr(device, swapchain, pDisplayTimingProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPastPresentationTimingGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, IntPtr pPresentationTimings);
		private static vkGetPastPresentationTimingGOOGLEDelegate vkGetPastPresentationTimingGOOGLE_ptr;
		public static VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, IntPtr pPresentationTimings)
			=> vkGetPastPresentationTimingGOOGLE_ptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateIOSSurfaceMVKDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateIOSSurfaceMVKDelegate vkCreateIOSSurfaceMVK_ptr;
		public static VkResult vkCreateIOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateIOSSurfaceMVK_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateMacOSSurfaceMVKDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateMacOSSurfaceMVKDelegate vkCreateMacOSSurfaceMVK_ptr;
		public static VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateMacOSSurfaceMVK_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateMetalSurfaceEXTDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateMetalSurfaceEXTDelegate vkCreateMetalSurfaceEXT_ptr;
		public static VkResult vkCreateMetalSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateMetalSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetViewportWScalingNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewportWScalings);
		private static vkCmdSetViewportWScalingNVDelegate vkCmdSetViewportWScalingNV_ptr;
		public static void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pViewportWScalings)
			=> vkCmdSetViewportWScalingNV_ptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetDiscardRectangleEXTDelegate(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, IntPtr pDiscardRectangles);
		private static vkCmdSetDiscardRectangleEXTDelegate vkCmdSetDiscardRectangleEXT_ptr;
		public static void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, IntPtr pDiscardRectangles)
			=> vkCmdSetDiscardRectangleEXT_ptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetSampleLocationsEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pSampleLocationsInfo);
		private static vkCmdSetSampleLocationsEXTDelegate vkCmdSetSampleLocationsEXT_ptr;
		public static void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, IntPtr pSampleLocationsInfo)
			=> vkCmdSetSampleLocationsEXT_ptr(commandBuffer, pSampleLocationsInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, IntPtr pMultisampleProperties);
		private static vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr;
		public static void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, IntPtr pMultisampleProperties)
			=> vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr(physicalDevice, samples, pMultisampleProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, IntPtr pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceFormats2KHRDelegate(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats);
		private static vkGetPhysicalDeviceSurfaceFormats2KHRDelegate vkGetPhysicalDeviceSurfaceFormats2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pSurfaceFormatCount, IntPtr pSurfaceFormats)
			=> vkGetPhysicalDeviceSurfaceFormats2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceDisplayProperties2KHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceDisplayProperties2KHRDelegate vkGetPhysicalDeviceDisplayProperties2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceDisplayProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDisplayModeProperties2KHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetDisplayModeProperties2KHRDelegate vkGetDisplayModeProperties2KHR_ptr;
		public static VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetDisplayModeProperties2KHR_ptr(physicalDevice, display, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDisplayPlaneCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, IntPtr pDisplayPlaneInfo, IntPtr pCapabilities);
		private static vkGetDisplayPlaneCapabilities2KHRDelegate vkGetDisplayPlaneCapabilities2KHR_ptr;
		public static VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, IntPtr pDisplayPlaneInfo, IntPtr pCapabilities)
			=> vkGetDisplayPlaneCapabilities2KHR_ptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetBufferMemoryRequirements2Delegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetBufferMemoryRequirements2Delegate vkGetBufferMemoryRequirements2_ptr;
		public static void vkGetBufferMemoryRequirements2(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetBufferMemoryRequirements2_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetImageMemoryRequirements2Delegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetImageMemoryRequirements2Delegate vkGetImageMemoryRequirements2_ptr;
		public static void vkGetImageMemoryRequirements2(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetImageMemoryRequirements2_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetImageSparseMemoryRequirements2Delegate(VkDevice device, IntPtr pInfo, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements);
		private static vkGetImageSparseMemoryRequirements2Delegate vkGetImageSparseMemoryRequirements2_ptr;
		public static void vkGetImageSparseMemoryRequirements2(VkDevice device, IntPtr pInfo, uint* pSparseMemoryRequirementCount, IntPtr pSparseMemoryRequirements)
			=> vkGetImageSparseMemoryRequirements2_ptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateSamplerYcbcrConversionDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pYcbcrConversion);
		private static vkCreateSamplerYcbcrConversionDelegate vkCreateSamplerYcbcrConversion_ptr;
		public static VkResult vkCreateSamplerYcbcrConversion(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pYcbcrConversion)
			=> vkCreateSamplerYcbcrConversion_ptr(device, pCreateInfo, pAllocator, pYcbcrConversion);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroySamplerYcbcrConversionDelegate(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, IntPtr pAllocator);
		private static vkDestroySamplerYcbcrConversionDelegate vkDestroySamplerYcbcrConversion_ptr;
		public static void vkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, IntPtr pAllocator)
			=> vkDestroySamplerYcbcrConversion_ptr(device, ycbcrConversion, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetDeviceQueue2Delegate(VkDevice device, IntPtr pQueueInfo, IntPtr pQueue);
		private static vkGetDeviceQueue2Delegate vkGetDeviceQueue2_ptr;
		public static void vkGetDeviceQueue2(VkDevice device, IntPtr pQueueInfo, IntPtr pQueue)
			=> vkGetDeviceQueue2_ptr(device, pQueueInfo, pQueue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateValidationCacheEXTDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pValidationCache);
		private static vkCreateValidationCacheEXTDelegate vkCreateValidationCacheEXT_ptr;
		public static VkResult vkCreateValidationCacheEXT(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pValidationCache)
			=> vkCreateValidationCacheEXT_ptr(device, pCreateInfo, pAllocator, pValidationCache);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyValidationCacheEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, IntPtr pAllocator);
		private static vkDestroyValidationCacheEXTDelegate vkDestroyValidationCacheEXT_ptr;
		public static void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, IntPtr pAllocator)
			=> vkDestroyValidationCacheEXT_ptr(device, validationCache, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetValidationCacheDataEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData);
		private static vkGetValidationCacheDataEXTDelegate vkGetValidationCacheDataEXT_ptr;
		public static VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData)
			=> vkGetValidationCacheDataEXT_ptr(device, validationCache, pDataSize, pData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkMergeValidationCachesEXTDelegate(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, IntPtr pSrcCaches);
		private static vkMergeValidationCachesEXTDelegate vkMergeValidationCachesEXT_ptr;
		public static VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, IntPtr pSrcCaches)
			=> vkMergeValidationCachesEXT_ptr(device, dstCache, srcCacheCount, pSrcCaches);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetDescriptorSetLayoutSupportDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pSupport);
		private static vkGetDescriptorSetLayoutSupportDelegate vkGetDescriptorSetLayoutSupport_ptr;
		public static void vkGetDescriptorSetLayoutSupport(VkDevice device, IntPtr pCreateInfo, IntPtr pSupport)
			=> vkGetDescriptorSetLayoutSupport_ptr(device, pCreateInfo, pSupport);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetSwapchainGrallocUsageANDROIDDelegate(VkDevice device, VkFormat format, uint imageUsage, IntPtr grallocUsage);
		private static vkGetSwapchainGrallocUsageANDROIDDelegate vkGetSwapchainGrallocUsageANDROID_ptr;
		public static VkResult vkGetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, uint imageUsage, IntPtr grallocUsage)
			=> vkGetSwapchainGrallocUsageANDROID_ptr(device, format, imageUsage, grallocUsage);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetSwapchainGrallocUsage2ANDROIDDelegate(VkDevice device, VkFormat format, uint imageUsage, uint swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage);
		private static vkGetSwapchainGrallocUsage2ANDROIDDelegate vkGetSwapchainGrallocUsage2ANDROID_ptr;
		public static VkResult vkGetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, uint imageUsage, uint swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage)
			=> vkGetSwapchainGrallocUsage2ANDROID_ptr(device, format, imageUsage, swapchainImageUsage, grallocConsumerUsage, grallocProducerUsage);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAcquireImageANDROIDDelegate(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence);
		private static vkAcquireImageANDROIDDelegate vkAcquireImageANDROID_ptr;
		public static VkResult vkAcquireImageANDROID(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
			=> vkAcquireImageANDROID_ptr(device, image, nativeFenceFd, semaphore, fence);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkQueueSignalReleaseImageANDROIDDelegate(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd);
		private static vkQueueSignalReleaseImageANDROIDDelegate vkQueueSignalReleaseImageANDROID_ptr;
		public static VkResult vkQueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, IntPtr pWaitSemaphores, VkImage image, IntPtr pNativeFenceFd)
			=> vkQueueSignalReleaseImageANDROID_ptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetShaderInfoAMDDelegate(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo);
		private static vkGetShaderInfoAMDDelegate vkGetShaderInfoAMD_ptr;
		public static VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo)
			=> vkGetShaderInfoAMD_ptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkSetLocalDimmingAMDDelegate(VkDevice device, VkSwapchainKHR swapChain, uint localDimmingEnable);
		private static vkSetLocalDimmingAMDDelegate vkSetLocalDimmingAMD_ptr;
		public static void vkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, uint localDimmingEnable)
			=> vkSetLocalDimmingAMD_ptr(device, swapChain, localDimmingEnable);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, IntPtr pTimeDomains);
		private static vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr;
		public static VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, IntPtr pTimeDomains)
			=> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr(physicalDevice, pTimeDomainCount, pTimeDomains);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetCalibratedTimestampsEXTDelegate(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation);
		private static vkGetCalibratedTimestampsEXTDelegate vkGetCalibratedTimestampsEXT_ptr;
		public static VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, IntPtr pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
			=> vkGetCalibratedTimestampsEXT_ptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkSetDebugUtilsObjectNameEXTDelegate(VkDevice device, IntPtr pNameInfo);
		private static vkSetDebugUtilsObjectNameEXTDelegate vkSetDebugUtilsObjectNameEXT_ptr;
		public static VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, IntPtr pNameInfo)
			=> vkSetDebugUtilsObjectNameEXT_ptr(device, pNameInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkSetDebugUtilsObjectTagEXTDelegate(VkDevice device, IntPtr pTagInfo);
		private static vkSetDebugUtilsObjectTagEXTDelegate vkSetDebugUtilsObjectTagEXT_ptr;
		public static VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, IntPtr pTagInfo)
			=> vkSetDebugUtilsObjectTagEXT_ptr(device, pTagInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkQueueBeginDebugUtilsLabelEXTDelegate(VkQueue queue, IntPtr pLabelInfo);
		private static vkQueueBeginDebugUtilsLabelEXTDelegate vkQueueBeginDebugUtilsLabelEXT_ptr;
		public static void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, IntPtr pLabelInfo)
			=> vkQueueBeginDebugUtilsLabelEXT_ptr(queue, pLabelInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkQueueEndDebugUtilsLabelEXTDelegate(VkQueue queue);
		private static vkQueueEndDebugUtilsLabelEXTDelegate vkQueueEndDebugUtilsLabelEXT_ptr;
		public static void vkQueueEndDebugUtilsLabelEXT(VkQueue queue)
			=> vkQueueEndDebugUtilsLabelEXT_ptr(queue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkQueueInsertDebugUtilsLabelEXTDelegate(VkQueue queue, IntPtr pLabelInfo);
		private static vkQueueInsertDebugUtilsLabelEXTDelegate vkQueueInsertDebugUtilsLabelEXT_ptr;
		public static void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, IntPtr pLabelInfo)
			=> vkQueueInsertDebugUtilsLabelEXT_ptr(queue, pLabelInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBeginDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pLabelInfo);
		private static vkCmdBeginDebugUtilsLabelEXTDelegate vkCmdBeginDebugUtilsLabelEXT_ptr;
		public static void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, IntPtr pLabelInfo)
			=> vkCmdBeginDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdEndDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndDebugUtilsLabelEXTDelegate vkCmdEndDebugUtilsLabelEXT_ptr;
		public static void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
			=> vkCmdEndDebugUtilsLabelEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdInsertDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, IntPtr pLabelInfo);
		private static vkCmdInsertDebugUtilsLabelEXTDelegate vkCmdInsertDebugUtilsLabelEXT_ptr;
		public static void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, IntPtr pLabelInfo)
			=> vkCmdInsertDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateDebugUtilsMessengerEXTDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pMessenger);
		private static vkCreateDebugUtilsMessengerEXTDelegate vkCreateDebugUtilsMessengerEXT_ptr;
		public static VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pMessenger)
			=> vkCreateDebugUtilsMessengerEXT_ptr(instance, pCreateInfo, pAllocator, pMessenger);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyDebugUtilsMessengerEXTDelegate(VkInstance instance, VkDebugUtilsMessengerEXT messenger, IntPtr pAllocator);
		private static vkDestroyDebugUtilsMessengerEXTDelegate vkDestroyDebugUtilsMessengerEXT_ptr;
		public static void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, IntPtr pAllocator)
			=> vkDestroyDebugUtilsMessengerEXT_ptr(instance, messenger, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkSubmitDebugUtilsMessageEXTDelegate(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, uint messageTypes, IntPtr pCallbackData);
		private static vkSubmitDebugUtilsMessageEXTDelegate vkSubmitDebugUtilsMessageEXT_ptr;
		public static void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, uint messageTypes, IntPtr pCallbackData)
			=> vkSubmitDebugUtilsMessageEXT_ptr(instance, messageSeverity, messageTypes, pCallbackData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetMemoryHostPointerPropertiesEXTDelegate(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, IntPtr pMemoryHostPointerProperties);
		private static vkGetMemoryHostPointerPropertiesEXTDelegate vkGetMemoryHostPointerPropertiesEXT_ptr;
		public static VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, IntPtr pMemoryHostPointerProperties)
			=> vkGetMemoryHostPointerPropertiesEXT_ptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdWriteBufferMarkerAMDDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker);
		private static vkCmdWriteBufferMarkerAMDDelegate vkCmdWriteBufferMarkerAMD_ptr;
		public static void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
			=> vkCmdWriteBufferMarkerAMD_ptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateRenderPass2Delegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pRenderPass);
		private static vkCreateRenderPass2Delegate vkCreateRenderPass2_ptr;
		public static VkResult vkCreateRenderPass2(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pRenderPass)
			=> vkCreateRenderPass2_ptr(device, pCreateInfo, pAllocator, pRenderPass);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBeginRenderPass2Delegate(VkCommandBuffer commandBuffer, IntPtr pRenderPassBegin, IntPtr pSubpassBeginInfo);
		private static vkCmdBeginRenderPass2Delegate vkCmdBeginRenderPass2_ptr;
		public static void vkCmdBeginRenderPass2(VkCommandBuffer commandBuffer, IntPtr pRenderPassBegin, IntPtr pSubpassBeginInfo)
			=> vkCmdBeginRenderPass2_ptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdNextSubpass2Delegate(VkCommandBuffer commandBuffer, IntPtr pSubpassBeginInfo, IntPtr pSubpassEndInfo);
		private static vkCmdNextSubpass2Delegate vkCmdNextSubpass2_ptr;
		public static void vkCmdNextSubpass2(VkCommandBuffer commandBuffer, IntPtr pSubpassBeginInfo, IntPtr pSubpassEndInfo)
			=> vkCmdNextSubpass2_ptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdEndRenderPass2Delegate(VkCommandBuffer commandBuffer, IntPtr pSubpassEndInfo);
		private static vkCmdEndRenderPass2Delegate vkCmdEndRenderPass2_ptr;
		public static void vkCmdEndRenderPass2(VkCommandBuffer commandBuffer, IntPtr pSubpassEndInfo)
			=> vkCmdEndRenderPass2_ptr(commandBuffer, pSubpassEndInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetSemaphoreCounterValueDelegate(VkDevice device, VkSemaphore semaphore, ulong* pValue);
		private static vkGetSemaphoreCounterValueDelegate vkGetSemaphoreCounterValue_ptr;
		public static VkResult vkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
			=> vkGetSemaphoreCounterValue_ptr(device, semaphore, pValue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkWaitSemaphoresDelegate(VkDevice device, IntPtr pWaitInfo, ulong timeout);
		private static vkWaitSemaphoresDelegate vkWaitSemaphores_ptr;
		public static VkResult vkWaitSemaphores(VkDevice device, IntPtr pWaitInfo, ulong timeout)
			=> vkWaitSemaphores_ptr(device, pWaitInfo, timeout);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkSignalSemaphoreDelegate(VkDevice device, IntPtr pSignalInfo);
		private static vkSignalSemaphoreDelegate vkSignalSemaphore_ptr;
		public static VkResult vkSignalSemaphore(VkDevice device, IntPtr pSignalInfo)
			=> vkSignalSemaphore_ptr(device, pSignalInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetAndroidHardwareBufferPropertiesANDROIDDelegate(VkDevice device, IntPtr buffer, IntPtr pProperties);
		private static vkGetAndroidHardwareBufferPropertiesANDROIDDelegate vkGetAndroidHardwareBufferPropertiesANDROID_ptr;
		public static VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, IntPtr pProperties)
			=> vkGetAndroidHardwareBufferPropertiesANDROID_ptr(device, buffer, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetMemoryAndroidHardwareBufferANDROIDDelegate(VkDevice device, IntPtr pInfo, IntPtr pBuffer);
		private static vkGetMemoryAndroidHardwareBufferANDROIDDelegate vkGetMemoryAndroidHardwareBufferANDROID_ptr;
		public static VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, IntPtr pInfo, IntPtr pBuffer)
			=> vkGetMemoryAndroidHardwareBufferANDROID_ptr(device, pInfo, pBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawIndirectCountDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawIndirectCountDelegate vkCmdDrawIndirectCount_ptr;
		public static void vkCmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawIndirectCount_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawIndexedIndirectCountDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawIndexedIndirectCountDelegate vkCmdDrawIndexedIndirectCount_ptr;
		public static void vkCmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawIndexedIndirectCount_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetCheckpointNVDelegate(VkCommandBuffer commandBuffer, void* pCheckpointMarker);
		private static vkCmdSetCheckpointNVDelegate vkCmdSetCheckpointNV_ptr;
		public static void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
			=> vkCmdSetCheckpointNV_ptr(commandBuffer, pCheckpointMarker);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetQueueCheckpointDataNVDelegate(VkQueue queue, uint* pCheckpointDataCount, IntPtr pCheckpointData);
		private static vkGetQueueCheckpointDataNVDelegate vkGetQueueCheckpointDataNV_ptr;
		public static void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, IntPtr pCheckpointData)
			=> vkGetQueueCheckpointDataNV_ptr(queue, pCheckpointDataCount, pCheckpointData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBindTransformFeedbackBuffersEXTDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, IntPtr pSizes);
		private static vkCmdBindTransformFeedbackBuffersEXTDelegate vkCmdBindTransformFeedbackBuffersEXT_ptr;
		public static void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, IntPtr pBuffers, IntPtr pOffsets, IntPtr pSizes)
			=> vkCmdBindTransformFeedbackBuffersEXT_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBeginTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets);
		private static vkCmdBeginTransformFeedbackEXTDelegate vkCmdBeginTransformFeedbackEXT_ptr;
		public static void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets)
			=> vkCmdBeginTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdEndTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets);
		private static vkCmdEndTransformFeedbackEXTDelegate vkCmdEndTransformFeedbackEXT_ptr;
		public static void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr pCounterBuffers, IntPtr pCounterBufferOffsets)
			=> vkCmdEndTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBeginQueryIndexedEXTDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint flags, uint index);
		private static vkCmdBeginQueryIndexedEXTDelegate vkCmdBeginQueryIndexedEXT_ptr;
		public static void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint flags, uint index)
			=> vkCmdBeginQueryIndexedEXT_ptr(commandBuffer, queryPool, query, flags, index);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdEndQueryIndexedEXTDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index);
		private static vkCmdEndQueryIndexedEXTDelegate vkCmdEndQueryIndexedEXT_ptr;
		public static void vkCmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
			=> vkCmdEndQueryIndexedEXT_ptr(commandBuffer, queryPool, query, index);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawIndirectByteCountEXTDelegate(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride);
		private static vkCmdDrawIndirectByteCountEXTDelegate vkCmdDrawIndirectByteCountEXT_ptr;
		public static void vkCmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
			=> vkCmdDrawIndirectByteCountEXT_ptr(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetExclusiveScissorNVDelegate(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, IntPtr pExclusiveScissors);
		private static vkCmdSetExclusiveScissorNVDelegate vkCmdSetExclusiveScissorNV_ptr;
		public static void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, IntPtr pExclusiveScissors)
			=> vkCmdSetExclusiveScissorNV_ptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBindShadingRateImageNVDelegate(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
		private static vkCmdBindShadingRateImageNVDelegate vkCmdBindShadingRateImageNV_ptr;
		public static void vkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
			=> vkCmdBindShadingRateImageNV_ptr(commandBuffer, imageView, imageLayout);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetViewportShadingRatePaletteNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pShadingRatePalettes);
		private static vkCmdSetViewportShadingRatePaletteNVDelegate vkCmdSetViewportShadingRatePaletteNV_ptr;
		public static void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, IntPtr pShadingRatePalettes)
			=> vkCmdSetViewportShadingRatePaletteNV_ptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetCoarseSampleOrderNVDelegate(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, IntPtr pCustomSampleOrders);
		private static vkCmdSetCoarseSampleOrderNVDelegate vkCmdSetCoarseSampleOrderNV_ptr;
		public static void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, IntPtr pCustomSampleOrders)
			=> vkCmdSetCoarseSampleOrderNV_ptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawMeshTasksNVDelegate(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask);
		private static vkCmdDrawMeshTasksNVDelegate vkCmdDrawMeshTasksNV_ptr;
		public static void vkCmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
			=> vkCmdDrawMeshTasksNV_ptr(commandBuffer, taskCount, firstTask);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawMeshTasksIndirectNVDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawMeshTasksIndirectNVDelegate vkCmdDrawMeshTasksIndirectNV_ptr;
		public static void vkCmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawMeshTasksIndirectNV_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdDrawMeshTasksIndirectCountNVDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawMeshTasksIndirectCountNVDelegate vkCmdDrawMeshTasksIndirectCountNV_ptr;
		public static void vkCmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawMeshTasksIndirectCountNV_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCompileDeferredNVDelegate(VkDevice device, VkPipeline pipeline, uint shader);
		private static vkCompileDeferredNVDelegate vkCompileDeferredNV_ptr;
		public static VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
			=> vkCompileDeferredNV_ptr(device, pipeline, shader);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateAccelerationStructureNVDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pAccelerationStructure);
		private static vkCreateAccelerationStructureNVDelegate vkCreateAccelerationStructureNV_ptr;
		public static VkResult vkCreateAccelerationStructureNV(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pAccelerationStructure)
			=> vkCreateAccelerationStructureNV_ptr(device, pCreateInfo, pAllocator, pAccelerationStructure);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyAccelerationStructureKHRDelegate(VkDevice device, VkAccelerationStructureKHR accelerationStructure, IntPtr pAllocator);
		private static vkDestroyAccelerationStructureKHRDelegate vkDestroyAccelerationStructureKHR_ptr;
		public static void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, IntPtr pAllocator)
			=> vkDestroyAccelerationStructureKHR_ptr(device, accelerationStructure, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetAccelerationStructureMemoryRequirementsKHRDelegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetAccelerationStructureMemoryRequirementsKHRDelegate vkGetAccelerationStructureMemoryRequirementsKHR_ptr;
		public static void vkGetAccelerationStructureMemoryRequirementsKHR(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetAccelerationStructureMemoryRequirementsKHR_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetAccelerationStructureMemoryRequirementsNVDelegate(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements);
		private static vkGetAccelerationStructureMemoryRequirementsNVDelegate vkGetAccelerationStructureMemoryRequirementsNV_ptr;
		public static void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, IntPtr pInfo, IntPtr pMemoryRequirements)
			=> vkGetAccelerationStructureMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkBindAccelerationStructureMemoryKHRDelegate(VkDevice device, uint bindInfoCount, IntPtr pBindInfos);
		private static vkBindAccelerationStructureMemoryKHRDelegate vkBindAccelerationStructureMemoryKHR_ptr;
		public static VkResult vkBindAccelerationStructureMemoryKHR(VkDevice device, uint bindInfoCount, IntPtr pBindInfos)
			=> vkBindAccelerationStructureMemoryKHR_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdCopyAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, VkAccelerationStructureKHR dst, VkAccelerationStructureKHR src, VkCopyAccelerationStructureModeKHR mode);
		private static vkCmdCopyAccelerationStructureNVDelegate vkCmdCopyAccelerationStructureNV_ptr;
		public static void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureKHR dst, VkAccelerationStructureKHR src, VkCopyAccelerationStructureModeKHR mode)
			=> vkCmdCopyAccelerationStructureNV_ptr(commandBuffer, dst, src, mode);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdCopyAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo);
		private static vkCmdCopyAccelerationStructureKHRDelegate vkCmdCopyAccelerationStructureKHR_ptr;
		public static void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
			=> vkCmdCopyAccelerationStructureKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCopyAccelerationStructureKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkCopyAccelerationStructureKHRDelegate vkCopyAccelerationStructureKHR_ptr;
		public static VkResult vkCopyAccelerationStructureKHR(VkDevice device, IntPtr pInfo)
			=> vkCopyAccelerationStructureKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdCopyAccelerationStructureToMemoryKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo);
		private static vkCmdCopyAccelerationStructureToMemoryKHRDelegate vkCmdCopyAccelerationStructureToMemoryKHR_ptr;
		public static void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
			=> vkCmdCopyAccelerationStructureToMemoryKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCopyAccelerationStructureToMemoryKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkCopyAccelerationStructureToMemoryKHRDelegate vkCopyAccelerationStructureToMemoryKHR_ptr;
		public static VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, IntPtr pInfo)
			=> vkCopyAccelerationStructureToMemoryKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdCopyMemoryToAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo);
		private static vkCmdCopyMemoryToAccelerationStructureKHRDelegate vkCmdCopyMemoryToAccelerationStructureKHR_ptr;
		public static void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, IntPtr pInfo)
			=> vkCmdCopyMemoryToAccelerationStructureKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCopyMemoryToAccelerationStructureKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkCopyMemoryToAccelerationStructureKHRDelegate vkCopyMemoryToAccelerationStructureKHR_ptr;
		public static VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, IntPtr pInfo)
			=> vkCopyMemoryToAccelerationStructureKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdWriteAccelerationStructuresPropertiesKHRDelegate(VkCommandBuffer commandBuffer, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
		private static vkCmdWriteAccelerationStructuresPropertiesKHRDelegate vkCmdWriteAccelerationStructuresPropertiesKHR_ptr;
		public static void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
			=> vkCmdWriteAccelerationStructuresPropertiesKHR_ptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBuildAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer instanceData, ulong instanceOffset, uint update, VkAccelerationStructureKHR dst, VkAccelerationStructureKHR src, VkBuffer scratch, ulong scratchOffset);
		private static vkCmdBuildAccelerationStructureNVDelegate vkCmdBuildAccelerationStructureNV_ptr;
		public static void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer instanceData, ulong instanceOffset, uint update, VkAccelerationStructureKHR dst, VkAccelerationStructureKHR src, VkBuffer scratch, ulong scratchOffset)
			=> vkCmdBuildAccelerationStructureNV_ptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkWriteAccelerationStructuresPropertiesKHRDelegate(VkDevice device, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride);
		private static vkWriteAccelerationStructuresPropertiesKHRDelegate vkWriteAccelerationStructuresPropertiesKHR_ptr;
		public static VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, IntPtr pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
			=> vkWriteAccelerationStructuresPropertiesKHR_ptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdTraceRaysKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth);
		private static vkCmdTraceRaysKHRDelegate vkCmdTraceRaysKHR_ptr;
		public static void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, uint width, uint height, uint depth)
			=> vkCmdTraceRaysKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdTraceRaysNVDelegate(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth);
		private static vkCmdTraceRaysNVDelegate vkCmdTraceRaysNV_ptr;
		public static void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
			=> vkCmdTraceRaysNV_ptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetRayTracingShaderGroupHandlesKHRDelegate(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData);
		private static vkGetRayTracingShaderGroupHandlesKHRDelegate vkGetRayTracingShaderGroupHandlesKHR_ptr;
		public static VkResult vkGetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
			=> vkGetRayTracingShaderGroupHandlesKHR_ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData);
		private static vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr;
		public static VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, UIntPtr dataSize, void* pData)
			=> vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr(device, pipeline, firstGroup, groupCount, dataSize, pData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetAccelerationStructureHandleNVDelegate(VkDevice device, VkAccelerationStructureKHR accelerationStructure, UIntPtr dataSize, void* pData);
		private static vkGetAccelerationStructureHandleNVDelegate vkGetAccelerationStructureHandleNV_ptr;
		public static VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureKHR accelerationStructure, UIntPtr dataSize, void* pData)
			=> vkGetAccelerationStructureHandleNV_ptr(device, accelerationStructure, dataSize, pData);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateRayTracingPipelinesNVDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines);
		private static vkCreateRayTracingPipelinesNVDelegate vkCreateRayTracingPipelinesNV_ptr;
		public static VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines)
			=> vkCreateRayTracingPipelinesNV_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateRayTracingPipelinesKHRDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines);
		private static vkCreateRayTracingPipelinesKHRDelegate vkCreateRayTracingPipelinesKHR_ptr;
		public static VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, IntPtr pCreateInfos, IntPtr pAllocator, IntPtr pPipelines)
			=> vkCreateRayTracingPipelinesKHR_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties);
		private static vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr;
		public static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, IntPtr pProperties)
			=> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdTraceRaysIndirectKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, VkBuffer buffer, ulong offset);
		private static vkCmdTraceRaysIndirectKHRDelegate vkCmdTraceRaysIndirectKHR_ptr;
		public static void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pRaygenShaderBindingTable, IntPtr pMissShaderBindingTable, IntPtr pHitShaderBindingTable, IntPtr pCallableShaderBindingTable, VkBuffer buffer, ulong offset)
			=> vkCmdTraceRaysIndirectKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, buffer, offset);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDeviceAccelerationStructureCompatibilityKHRDelegate(VkDevice device, IntPtr version);
		private static vkGetDeviceAccelerationStructureCompatibilityKHRDelegate vkGetDeviceAccelerationStructureCompatibilityKHR_ptr;
		public static VkResult vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, IntPtr version)
			=> vkGetDeviceAccelerationStructureCompatibilityKHR_ptr(device, version);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate uint vkGetImageViewHandleNVXDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetImageViewHandleNVXDelegate vkGetImageViewHandleNVX_ptr;
		public static uint vkGetImageViewHandleNVX(VkDevice device, IntPtr pInfo)
			=> vkGetImageViewHandleNVX_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetImageViewAddressNVXDelegate(VkDevice device, VkImageView imageView, IntPtr pProperties);
		private static vkGetImageViewAddressNVXDelegate vkGetImageViewAddressNVX_ptr;
		public static VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, IntPtr pProperties)
			=> vkGetImageViewAddressNVX_ptr(device, imageView, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pPresentModeCount, IntPtr pPresentModes);
		private static vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr;
		public static VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, IntPtr pSurfaceInfo, uint* pPresentModeCount, IntPtr pPresentModes)
			=> vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDeviceGroupSurfacePresentModes2EXTDelegate(VkDevice device, IntPtr pSurfaceInfo, IntPtr pModes);
		private static vkGetDeviceGroupSurfacePresentModes2EXTDelegate vkGetDeviceGroupSurfacePresentModes2EXT_ptr;
		public static VkResult vkGetDeviceGroupSurfacePresentModes2EXT(VkDevice device, IntPtr pSurfaceInfo, IntPtr pModes)
			=> vkGetDeviceGroupSurfacePresentModes2EXT_ptr(device, pSurfaceInfo, pModes);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAcquireFullScreenExclusiveModeEXTDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkAcquireFullScreenExclusiveModeEXTDelegate vkAcquireFullScreenExclusiveModeEXT_ptr;
		public static VkResult vkAcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
			=> vkAcquireFullScreenExclusiveModeEXT_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkReleaseFullScreenExclusiveModeEXTDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkReleaseFullScreenExclusiveModeEXTDelegate vkReleaseFullScreenExclusiveModeEXT_ptr;
		public static VkResult vkReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
			=> vkReleaseFullScreenExclusiveModeEXT_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions);
		private static vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr;
		public static VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, IntPtr pCounters, IntPtr pCounterDescriptions)
			=> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate(VkPhysicalDevice physicalDevice, IntPtr pPerformanceQueryCreateInfo, uint* pNumPasses);
		private static vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, IntPtr pPerformanceQueryCreateInfo, uint* pNumPasses)
			=> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAcquireProfilingLockKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkAcquireProfilingLockKHRDelegate vkAcquireProfilingLockKHR_ptr;
		public static VkResult vkAcquireProfilingLockKHR(VkDevice device, IntPtr pInfo)
			=> vkAcquireProfilingLockKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkReleaseProfilingLockKHRDelegate(VkDevice device);
		private static vkReleaseProfilingLockKHRDelegate vkReleaseProfilingLockKHR_ptr;
		public static void vkReleaseProfilingLockKHR(VkDevice device)
			=> vkReleaseProfilingLockKHR_ptr(device);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetImageDrmFormatModifierPropertiesEXTDelegate(VkDevice device, VkImage image, IntPtr pProperties);
		private static vkGetImageDrmFormatModifierPropertiesEXTDelegate vkGetImageDrmFormatModifierPropertiesEXT_ptr;
		public static VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, IntPtr pProperties)
			=> vkGetImageDrmFormatModifierPropertiesEXT_ptr(device, image, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate ulong vkGetBufferOpaqueCaptureAddressDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetBufferOpaqueCaptureAddressDelegate vkGetBufferOpaqueCaptureAddress_ptr;
		public static ulong vkGetBufferOpaqueCaptureAddress(VkDevice device, IntPtr pInfo)
			=> vkGetBufferOpaqueCaptureAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate ulong vkGetBufferDeviceAddressDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetBufferDeviceAddressDelegate vkGetBufferDeviceAddress_ptr;
		public static ulong vkGetBufferDeviceAddress(VkDevice device, IntPtr pInfo)
			=> vkGetBufferDeviceAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateHeadlessSurfaceEXTDelegate(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface);
		private static vkCreateHeadlessSurfaceEXTDelegate vkCreateHeadlessSurfaceEXT_ptr;
		public static VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pSurface)
			=> vkCreateHeadlessSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate(VkPhysicalDevice physicalDevice, uint* pCombinationCount, IntPtr pCombinations);
		private static vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr;
		public static VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, IntPtr pCombinations)
			=> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr(physicalDevice, pCombinationCount, pCombinations);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkInitializePerformanceApiINTELDelegate(VkDevice device, IntPtr pInitializeInfo);
		private static vkInitializePerformanceApiINTELDelegate vkInitializePerformanceApiINTEL_ptr;
		public static VkResult vkInitializePerformanceApiINTEL(VkDevice device, IntPtr pInitializeInfo)
			=> vkInitializePerformanceApiINTEL_ptr(device, pInitializeInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkUninitializePerformanceApiINTELDelegate(VkDevice device);
		private static vkUninitializePerformanceApiINTELDelegate vkUninitializePerformanceApiINTEL_ptr;
		public static void vkUninitializePerformanceApiINTEL(VkDevice device)
			=> vkUninitializePerformanceApiINTEL_ptr(device);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCmdSetPerformanceMarkerINTELDelegate(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo);
		private static vkCmdSetPerformanceMarkerINTELDelegate vkCmdSetPerformanceMarkerINTEL_ptr;
		public static VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
			=> vkCmdSetPerformanceMarkerINTEL_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCmdSetPerformanceStreamMarkerINTELDelegate(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo);
		private static vkCmdSetPerformanceStreamMarkerINTELDelegate vkCmdSetPerformanceStreamMarkerINTEL_ptr;
		public static VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, IntPtr pMarkerInfo)
			=> vkCmdSetPerformanceStreamMarkerINTEL_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCmdSetPerformanceOverrideINTELDelegate(VkCommandBuffer commandBuffer, IntPtr pOverrideInfo);
		private static vkCmdSetPerformanceOverrideINTELDelegate vkCmdSetPerformanceOverrideINTEL_ptr;
		public static VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, IntPtr pOverrideInfo)
			=> vkCmdSetPerformanceOverrideINTEL_ptr(commandBuffer, pOverrideInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkAcquirePerformanceConfigurationINTELDelegate(VkDevice device, IntPtr pAcquireInfo, IntPtr pConfiguration);
		private static vkAcquirePerformanceConfigurationINTELDelegate vkAcquirePerformanceConfigurationINTEL_ptr;
		public static VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, IntPtr pAcquireInfo, IntPtr pConfiguration)
			=> vkAcquirePerformanceConfigurationINTEL_ptr(device, pAcquireInfo, pConfiguration);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkReleasePerformanceConfigurationINTELDelegate(VkDevice device, VkPerformanceConfigurationINTEL configuration);
		private static vkReleasePerformanceConfigurationINTELDelegate vkReleasePerformanceConfigurationINTEL_ptr;
		public static VkResult vkReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
			=> vkReleasePerformanceConfigurationINTEL_ptr(device, configuration);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkQueueSetPerformanceConfigurationINTELDelegate(VkQueue queue, VkPerformanceConfigurationINTEL configuration);
		private static vkQueueSetPerformanceConfigurationINTELDelegate vkQueueSetPerformanceConfigurationINTEL_ptr;
		public static VkResult vkQueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
			=> vkQueueSetPerformanceConfigurationINTEL_ptr(queue, configuration);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPerformanceParameterINTELDelegate(VkDevice device, VkPerformanceParameterTypeINTEL parameter, IntPtr pValue);
		private static vkGetPerformanceParameterINTELDelegate vkGetPerformanceParameterINTEL_ptr;
		public static VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, IntPtr pValue)
			=> vkGetPerformanceParameterINTEL_ptr(device, parameter, pValue);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate ulong vkGetDeviceMemoryOpaqueCaptureAddressDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetDeviceMemoryOpaqueCaptureAddressDelegate vkGetDeviceMemoryOpaqueCaptureAddress_ptr;
		public static ulong vkGetDeviceMemoryOpaqueCaptureAddress(VkDevice device, IntPtr pInfo)
			=> vkGetDeviceMemoryOpaqueCaptureAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPipelineExecutablePropertiesKHRDelegate(VkDevice device, IntPtr pPipelineInfo, uint* pExecutableCount, IntPtr pProperties);
		private static vkGetPipelineExecutablePropertiesKHRDelegate vkGetPipelineExecutablePropertiesKHR_ptr;
		public static VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, IntPtr pPipelineInfo, uint* pExecutableCount, IntPtr pProperties)
			=> vkGetPipelineExecutablePropertiesKHR_ptr(device, pPipelineInfo, pExecutableCount, pProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPipelineExecutableStatisticsKHRDelegate(VkDevice device, IntPtr pExecutableInfo, uint* pStatisticCount, IntPtr pStatistics);
		private static vkGetPipelineExecutableStatisticsKHRDelegate vkGetPipelineExecutableStatisticsKHR_ptr;
		public static VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pStatisticCount, IntPtr pStatistics)
			=> vkGetPipelineExecutableStatisticsKHR_ptr(device, pExecutableInfo, pStatisticCount, pStatistics);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPipelineExecutableInternalRepresentationsKHRDelegate(VkDevice device, IntPtr pExecutableInfo, uint* pInternalRepresentationCount, IntPtr pInternalRepresentations);
		private static vkGetPipelineExecutableInternalRepresentationsKHRDelegate vkGetPipelineExecutableInternalRepresentationsKHR_ptr;
		public static VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, IntPtr pExecutableInfo, uint* pInternalRepresentationCount, IntPtr pInternalRepresentations)
			=> vkGetPipelineExecutableInternalRepresentationsKHR_ptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdSetLineStippleEXTDelegate(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
		private static vkCmdSetLineStippleEXTDelegate vkCmdSetLineStippleEXT_ptr;
		public static void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
			=> vkCmdSetLineStippleEXT_ptr(commandBuffer, lineStippleFactor, lineStipplePattern);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetPhysicalDeviceToolPropertiesEXTDelegate(VkPhysicalDevice physicalDevice, uint* pToolCount, IntPtr pToolProperties);
		private static vkGetPhysicalDeviceToolPropertiesEXTDelegate vkGetPhysicalDeviceToolPropertiesEXT_ptr;
		public static VkResult vkGetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* pToolCount, IntPtr pToolProperties)
			=> vkGetPhysicalDeviceToolPropertiesEXT_ptr(physicalDevice, pToolCount, pToolProperties);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateAccelerationStructureKHRDelegate(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pAccelerationStructure);
		private static vkCreateAccelerationStructureKHRDelegate vkCreateAccelerationStructureKHR_ptr;
		public static VkResult vkCreateAccelerationStructureKHR(VkDevice device, IntPtr pCreateInfo, IntPtr pAllocator, IntPtr pAccelerationStructure)
			=> vkCreateAccelerationStructureKHR_ptr(device, pCreateInfo, pAllocator, pAccelerationStructure);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBuildAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr ppOffsetInfos);
		private static vkCmdBuildAccelerationStructureKHRDelegate vkCmdBuildAccelerationStructureKHR_ptr;
		public static void vkCmdBuildAccelerationStructureKHR(VkCommandBuffer commandBuffer, uint infoCount, IntPtr pInfos, IntPtr ppOffsetInfos)
			=> vkCmdBuildAccelerationStructureKHR_ptr(commandBuffer, infoCount, pInfos, ppOffsetInfos);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkCmdBuildAccelerationStructureIndirectKHRDelegate(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer indirectBuffer, ulong indirectOffset, uint indirectStride);
		private static vkCmdBuildAccelerationStructureIndirectKHRDelegate vkCmdBuildAccelerationStructureIndirectKHR_ptr;
		public static void vkCmdBuildAccelerationStructureIndirectKHR(VkCommandBuffer commandBuffer, IntPtr pInfo, VkBuffer indirectBuffer, ulong indirectOffset, uint indirectStride)
			=> vkCmdBuildAccelerationStructureIndirectKHR_ptr(commandBuffer, pInfo, indirectBuffer, indirectOffset, indirectStride);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkBuildAccelerationStructureKHRDelegate(VkDevice device, uint infoCount, IntPtr pInfos, IntPtr ppOffsetInfos);
		private static vkBuildAccelerationStructureKHRDelegate vkBuildAccelerationStructureKHR_ptr;
		public static VkResult vkBuildAccelerationStructureKHR(VkDevice device, uint infoCount, IntPtr pInfos, IntPtr ppOffsetInfos)
			=> vkBuildAccelerationStructureKHR_ptr(device, infoCount, pInfos, ppOffsetInfos);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate ulong vkGetAccelerationStructureDeviceAddressKHRDelegate(VkDevice device, IntPtr pInfo);
		private static vkGetAccelerationStructureDeviceAddressKHRDelegate vkGetAccelerationStructureDeviceAddressKHR_ptr;
		public static ulong vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, IntPtr pInfo)
			=> vkGetAccelerationStructureDeviceAddressKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkCreateDeferredOperationKHRDelegate(VkDevice device, IntPtr pAllocator, IntPtr pDeferredOperation);
		private static vkCreateDeferredOperationKHRDelegate vkCreateDeferredOperationKHR_ptr;
		public static VkResult vkCreateDeferredOperationKHR(VkDevice device, IntPtr pAllocator, IntPtr pDeferredOperation)
			=> vkCreateDeferredOperationKHR_ptr(device, pAllocator, pDeferredOperation);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void vkDestroyDeferredOperationKHRDelegate(VkDevice device, VkDeferredOperationKHR operation, IntPtr pAllocator);
		private static vkDestroyDeferredOperationKHRDelegate vkDestroyDeferredOperationKHR_ptr;
		public static void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, IntPtr pAllocator)
			=> vkDestroyDeferredOperationKHR_ptr(device, operation, pAllocator);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate uint vkGetDeferredOperationMaxConcurrencyKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
		private static vkGetDeferredOperationMaxConcurrencyKHRDelegate vkGetDeferredOperationMaxConcurrencyKHR_ptr;
		public static uint vkGetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
			=> vkGetDeferredOperationMaxConcurrencyKHR_ptr(device, operation);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkGetDeferredOperationResultKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
		private static vkGetDeferredOperationResultKHRDelegate vkGetDeferredOperationResultKHR_ptr;
		public static VkResult vkGetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
			=> vkGetDeferredOperationResultKHR_ptr(device, operation);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate VkResult vkDeferredOperationJoinKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
		private static vkDeferredOperationJoinKHRDelegate vkDeferredOperationJoinKHR_ptr;
		public static VkResult vkDeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
			=> vkDeferredOperationJoinKHR_ptr(device, operation);

	}
}
