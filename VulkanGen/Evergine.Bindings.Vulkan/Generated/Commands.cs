using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Vulkan
{
	public static unsafe partial class VulkanNative
	{
		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateInstanceDelegate(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance);
		private static vkCreateInstanceDelegate vkCreateInstance_ptr;
		public static VkResult vkCreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)
			=> vkCreateInstance_ptr(pCreateInfo, pAllocator, pInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyInstanceDelegate(VkInstance instance, VkAllocationCallbacks* pAllocator);
		private static vkDestroyInstanceDelegate vkDestroyInstance_ptr;
		public static void vkDestroyInstance(VkInstance instance, VkAllocationCallbacks* pAllocator)
			=> vkDestroyInstance_ptr(instance, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumeratePhysicalDevicesDelegate(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices);
		private static vkEnumeratePhysicalDevicesDelegate vkEnumeratePhysicalDevices_ptr;
		public static VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
			=> vkEnumeratePhysicalDevices_ptr(instance, pPhysicalDeviceCount, pPhysicalDevices);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFeaturesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures);
		private static vkGetPhysicalDeviceFeaturesDelegate vkGetPhysicalDeviceFeatures_ptr;
		public static void vkGetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures)
			=> vkGetPhysicalDeviceFeatures_ptr(physicalDevice, pFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties);
		private static vkGetPhysicalDeviceFormatPropertiesDelegate vkGetPhysicalDeviceFormatProperties_ptr;
		public static void vkGetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)
			=> vkGetPhysicalDeviceFormatProperties_ptr(physicalDevice, format, pFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties);
		private static vkGetPhysicalDeviceImageFormatPropertiesDelegate vkGetPhysicalDeviceImageFormatProperties_ptr;
		public static VkResult vkGetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties)
			=> vkGetPhysicalDeviceImageFormatProperties_ptr(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDevicePropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties);
		private static vkGetPhysicalDevicePropertiesDelegate vkGetPhysicalDeviceProperties_ptr;
		public static void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties)
			=> vkGetPhysicalDeviceProperties_ptr(physicalDevice, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceQueueFamilyPropertiesDelegate(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties);
		private static vkGetPhysicalDeviceQueueFamilyPropertiesDelegate vkGetPhysicalDeviceQueueFamilyProperties_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)
			=> vkGetPhysicalDeviceQueueFamilyProperties_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceMemoryPropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties);
		private static vkGetPhysicalDeviceMemoryPropertiesDelegate vkGetPhysicalDeviceMemoryProperties_ptr;
		public static void vkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)
			=> vkGetPhysicalDeviceMemoryProperties_ptr(physicalDevice, pMemoryProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr vkGetInstanceProcAddrDelegate(VkInstance instance, byte* pName);
		private static vkGetInstanceProcAddrDelegate vkGetInstanceProcAddr_ptr;
		public static IntPtr vkGetInstanceProcAddr(VkInstance instance, byte* pName)
			=> vkGetInstanceProcAddr_ptr(instance, pName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate IntPtr vkGetDeviceProcAddrDelegate(VkDevice device, byte* pName);
		private static vkGetDeviceProcAddrDelegate vkGetDeviceProcAddr_ptr;
		public static IntPtr vkGetDeviceProcAddr(VkDevice device, byte* pName)
			=> vkGetDeviceProcAddr_ptr(device, pName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDeviceDelegate(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice);
		private static vkCreateDeviceDelegate vkCreateDevice_ptr;
		public static VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice)
			=> vkCreateDevice_ptr(physicalDevice, pCreateInfo, pAllocator, pDevice);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDeviceDelegate(VkDevice device, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDeviceDelegate vkDestroyDevice_ptr;
		public static void vkDestroyDevice(VkDevice device, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDevice_ptr(device, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateInstanceExtensionPropertiesDelegate(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties);
		private static vkEnumerateInstanceExtensionPropertiesDelegate vkEnumerateInstanceExtensionProperties_ptr;
		public static VkResult vkEnumerateInstanceExtensionProperties(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
			=> vkEnumerateInstanceExtensionProperties_ptr(pLayerName, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateDeviceExtensionPropertiesDelegate(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties);
		private static vkEnumerateDeviceExtensionPropertiesDelegate vkEnumerateDeviceExtensionProperties_ptr;
		public static VkResult vkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
			=> vkEnumerateDeviceExtensionProperties_ptr(physicalDevice, pLayerName, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateInstanceLayerPropertiesDelegate(uint* pPropertyCount, VkLayerProperties* pProperties);
		private static vkEnumerateInstanceLayerPropertiesDelegate vkEnumerateInstanceLayerProperties_ptr;
		public static VkResult vkEnumerateInstanceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties)
			=> vkEnumerateInstanceLayerProperties_ptr(pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateDeviceLayerPropertiesDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties);
		private static vkEnumerateDeviceLayerPropertiesDelegate vkEnumerateDeviceLayerProperties_ptr;
		public static VkResult vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties)
			=> vkEnumerateDeviceLayerProperties_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceQueueDelegate(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue);
		private static vkGetDeviceQueueDelegate vkGetDeviceQueue_ptr;
		public static void vkGetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue)
			=> vkGetDeviceQueue_ptr(device, queueFamilyIndex, queueIndex, pQueue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueSubmitDelegate(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence);
		private static vkQueueSubmitDelegate vkQueueSubmit_ptr;
		public static VkResult vkQueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence)
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
		private delegate VkResult vkAllocateMemoryDelegate(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory);
		private static vkAllocateMemoryDelegate vkAllocateMemory_ptr;
		public static VkResult vkAllocateMemory(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory)
			=> vkAllocateMemory_ptr(device, pAllocateInfo, pAllocator, pMemory);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkFreeMemoryDelegate(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator);
		private static vkFreeMemoryDelegate vkFreeMemory_ptr;
		public static void vkFreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator)
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
		private delegate VkResult vkFlushMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
		private static vkFlushMappedMemoryRangesDelegate vkFlushMappedMemoryRanges_ptr;
		public static VkResult vkFlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
			=> vkFlushMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkInvalidateMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
		private static vkInvalidateMappedMemoryRangesDelegate vkInvalidateMappedMemoryRanges_ptr;
		public static VkResult vkInvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
			=> vkInvalidateMappedMemoryRanges_ptr(device, memoryRangeCount, pMemoryRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceMemoryCommitmentDelegate(VkDevice device, VkDeviceMemory memory, ulong* pCommittedMemoryInBytes);
		private static vkGetDeviceMemoryCommitmentDelegate vkGetDeviceMemoryCommitment_ptr;
		public static void vkGetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, ulong* pCommittedMemoryInBytes)
			=> vkGetDeviceMemoryCommitment_ptr(device, memory, pCommittedMemoryInBytes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindBufferMemoryDelegate(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset);
		private static vkBindBufferMemoryDelegate vkBindBufferMemory_ptr;
		public static VkResult vkBindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
			=> vkBindBufferMemory_ptr(device, buffer, memory, memoryOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindImageMemoryDelegate(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset);
		private static vkBindImageMemoryDelegate vkBindImageMemory_ptr;
		public static VkResult vkBindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
			=> vkBindImageMemory_ptr(device, image, memory, memoryOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetBufferMemoryRequirementsDelegate(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements);
		private static vkGetBufferMemoryRequirementsDelegate vkGetBufferMemoryRequirements_ptr;
		public static void vkGetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements)
			=> vkGetBufferMemoryRequirements_ptr(device, buffer, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageMemoryRequirementsDelegate(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements);
		private static vkGetImageMemoryRequirementsDelegate vkGetImageMemoryRequirements_ptr;
		public static void vkGetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements)
			=> vkGetImageMemoryRequirements_ptr(device, image, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSparseMemoryRequirementsDelegate(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements);
		private static vkGetImageSparseMemoryRequirementsDelegate vkGetImageSparseMemoryRequirements_ptr;
		public static void vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
			=> vkGetImageSparseMemoryRequirements_ptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties);
		private static vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate vkGetPhysicalDeviceSparseImageFormatProperties_ptr;
		public static void vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties)
			=> vkGetPhysicalDeviceSparseImageFormatProperties_ptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueBindSparseDelegate(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence);
		private static vkQueueBindSparseDelegate vkQueueBindSparse_ptr;
		public static VkResult vkQueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)
			=> vkQueueBindSparse_ptr(queue, bindInfoCount, pBindInfo, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateFenceDelegate(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
		private static vkCreateFenceDelegate vkCreateFence_ptr;
		public static VkResult vkCreateFence(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
			=> vkCreateFence_ptr(device, pCreateInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyFenceDelegate(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator);
		private static vkDestroyFenceDelegate vkDestroyFence_ptr;
		public static void vkDestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator)
			=> vkDestroyFence_ptr(device, fence, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetFencesDelegate(VkDevice device, uint fenceCount, VkFence* pFences);
		private static vkResetFencesDelegate vkResetFences_ptr;
		public static VkResult vkResetFences(VkDevice device, uint fenceCount, VkFence* pFences)
			=> vkResetFences_ptr(device, fenceCount, pFences);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceStatusDelegate(VkDevice device, VkFence fence);
		private static vkGetFenceStatusDelegate vkGetFenceStatus_ptr;
		public static VkResult vkGetFenceStatus(VkDevice device, VkFence fence)
			=> vkGetFenceStatus_ptr(device, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWaitForFencesDelegate(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout);
		private static vkWaitForFencesDelegate vkWaitForFences_ptr;
		public static VkResult vkWaitForFences(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout)
			=> vkWaitForFences_ptr(device, fenceCount, pFences, waitAll, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSemaphoreDelegate(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore);
		private static vkCreateSemaphoreDelegate vkCreateSemaphore_ptr;
		public static VkResult vkCreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore)
			=> vkCreateSemaphore_ptr(device, pCreateInfo, pAllocator, pSemaphore);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySemaphoreDelegate(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator);
		private static vkDestroySemaphoreDelegate vkDestroySemaphore_ptr;
		public static void vkDestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator)
			=> vkDestroySemaphore_ptr(device, semaphore, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateEventDelegate(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent);
		private static vkCreateEventDelegate vkCreateEvent_ptr;
		public static VkResult vkCreateEvent(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent)
			=> vkCreateEvent_ptr(device, pCreateInfo, pAllocator, pEvent);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyEventDelegate(VkDevice device, VkEvent vkEvent, VkAllocationCallbacks* pAllocator);
		private static vkDestroyEventDelegate vkDestroyEvent_ptr;
		public static void vkDestroyEvent(VkDevice device, VkEvent vkEvent, VkAllocationCallbacks* pAllocator)
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
		private delegate VkResult vkCreateQueryPoolDelegate(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool);
		private static vkCreateQueryPoolDelegate vkCreateQueryPool_ptr;
		public static VkResult vkCreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool)
			=> vkCreateQueryPool_ptr(device, pCreateInfo, pAllocator, pQueryPool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator);
		private static vkDestroyQueryPoolDelegate vkDestroyQueryPool_ptr;
		public static void vkDestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator)
			=> vkDestroyQueryPool_ptr(device, queryPool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetQueryPoolResultsDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* pData, ulong stride, VkQueryResultFlags flags);
		private static vkGetQueryPoolResultsDelegate vkGetQueryPoolResults_ptr;
		public static VkResult vkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* pData, ulong stride, VkQueryResultFlags flags)
			=> vkGetQueryPoolResults_ptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateBufferDelegate(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer);
		private static vkCreateBufferDelegate vkCreateBuffer_ptr;
		public static VkResult vkCreateBuffer(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer)
			=> vkCreateBuffer_ptr(device, pCreateInfo, pAllocator, pBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyBufferDelegate(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator);
		private static vkDestroyBufferDelegate vkDestroyBuffer_ptr;
		public static void vkDestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator)
			=> vkDestroyBuffer_ptr(device, buffer, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateBufferViewDelegate(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView);
		private static vkCreateBufferViewDelegate vkCreateBufferView_ptr;
		public static VkResult vkCreateBufferView(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView)
			=> vkCreateBufferView_ptr(device, pCreateInfo, pAllocator, pView);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyBufferViewDelegate(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator);
		private static vkDestroyBufferViewDelegate vkDestroyBufferView_ptr;
		public static void vkDestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator)
			=> vkDestroyBufferView_ptr(device, bufferView, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateImageDelegate(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage);
		private static vkCreateImageDelegate vkCreateImage_ptr;
		public static VkResult vkCreateImage(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage)
			=> vkCreateImage_ptr(device, pCreateInfo, pAllocator, pImage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyImageDelegate(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator);
		private static vkDestroyImageDelegate vkDestroyImage_ptr;
		public static void vkDestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator)
			=> vkDestroyImage_ptr(device, image, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSubresourceLayoutDelegate(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout);
		private static vkGetImageSubresourceLayoutDelegate vkGetImageSubresourceLayout_ptr;
		public static void vkGetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)
			=> vkGetImageSubresourceLayout_ptr(device, image, pSubresource, pLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateImageViewDelegate(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView);
		private static vkCreateImageViewDelegate vkCreateImageView_ptr;
		public static VkResult vkCreateImageView(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView)
			=> vkCreateImageView_ptr(device, pCreateInfo, pAllocator, pView);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyImageViewDelegate(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator);
		private static vkDestroyImageViewDelegate vkDestroyImageView_ptr;
		public static void vkDestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator)
			=> vkDestroyImageView_ptr(device, imageView, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateShaderModuleDelegate(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule);
		private static vkCreateShaderModuleDelegate vkCreateShaderModule_ptr;
		public static VkResult vkCreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule)
			=> vkCreateShaderModule_ptr(device, pCreateInfo, pAllocator, pShaderModule);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyShaderModuleDelegate(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator);
		private static vkDestroyShaderModuleDelegate vkDestroyShaderModule_ptr;
		public static void vkDestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator)
			=> vkDestroyShaderModule_ptr(device, shaderModule, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreatePipelineCacheDelegate(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache);
		private static vkCreatePipelineCacheDelegate vkCreatePipelineCache_ptr;
		public static VkResult vkCreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache)
			=> vkCreatePipelineCache_ptr(device, pCreateInfo, pAllocator, pPipelineCache);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPipelineCacheDelegate(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator);
		private static vkDestroyPipelineCacheDelegate vkDestroyPipelineCache_ptr;
		public static void vkDestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator)
			=> vkDestroyPipelineCache_ptr(device, pipelineCache, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineCacheDataDelegate(VkDevice device, VkPipelineCache pipelineCache, UIntPtr* pDataSize, void* pData);
		private static vkGetPipelineCacheDataDelegate vkGetPipelineCacheData_ptr;
		public static VkResult vkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, UIntPtr* pDataSize, void* pData)
			=> vkGetPipelineCacheData_ptr(device, pipelineCache, pDataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkMergePipelineCachesDelegate(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches);
		private static vkMergePipelineCachesDelegate vkMergePipelineCaches_ptr;
		public static VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches)
			=> vkMergePipelineCaches_ptr(device, dstCache, srcCacheCount, pSrcCaches);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateGraphicsPipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
		private static vkCreateGraphicsPipelinesDelegate vkCreateGraphicsPipelines_ptr;
		public static VkResult vkCreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
			=> vkCreateGraphicsPipelines_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateComputePipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
		private static vkCreateComputePipelinesDelegate vkCreateComputePipelines_ptr;
		public static VkResult vkCreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
			=> vkCreateComputePipelines_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPipelineDelegate(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator);
		private static vkDestroyPipelineDelegate vkDestroyPipeline_ptr;
		public static void vkDestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator)
			=> vkDestroyPipeline_ptr(device, pipeline, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreatePipelineLayoutDelegate(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout);
		private static vkCreatePipelineLayoutDelegate vkCreatePipelineLayout_ptr;
		public static VkResult vkCreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout)
			=> vkCreatePipelineLayout_ptr(device, pCreateInfo, pAllocator, pPipelineLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPipelineLayoutDelegate(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator);
		private static vkDestroyPipelineLayoutDelegate vkDestroyPipelineLayout_ptr;
		public static void vkDestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator)
			=> vkDestroyPipelineLayout_ptr(device, pipelineLayout, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSamplerDelegate(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler);
		private static vkCreateSamplerDelegate vkCreateSampler_ptr;
		public static VkResult vkCreateSampler(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler)
			=> vkCreateSampler_ptr(device, pCreateInfo, pAllocator, pSampler);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySamplerDelegate(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator);
		private static vkDestroySamplerDelegate vkDestroySampler_ptr;
		public static void vkDestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator)
			=> vkDestroySampler_ptr(device, sampler, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDescriptorSetLayoutDelegate(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout);
		private static vkCreateDescriptorSetLayoutDelegate vkCreateDescriptorSetLayout_ptr;
		public static VkResult vkCreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout)
			=> vkCreateDescriptorSetLayout_ptr(device, pCreateInfo, pAllocator, pSetLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDescriptorSetLayoutDelegate(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDescriptorSetLayoutDelegate vkDestroyDescriptorSetLayout_ptr;
		public static void vkDestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDescriptorSetLayout_ptr(device, descriptorSetLayout, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDescriptorPoolDelegate(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool);
		private static vkCreateDescriptorPoolDelegate vkCreateDescriptorPool_ptr;
		public static VkResult vkCreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool)
			=> vkCreateDescriptorPool_ptr(device, pCreateInfo, pAllocator, pDescriptorPool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDescriptorPoolDelegate vkDestroyDescriptorPool_ptr;
		public static void vkDestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDescriptorPool_ptr(device, descriptorPool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, uint flags);
		private static vkResetDescriptorPoolDelegate vkResetDescriptorPool_ptr;
		public static VkResult vkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, uint flags)
			=> vkResetDescriptorPool_ptr(device, descriptorPool, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAllocateDescriptorSetsDelegate(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets);
		private static vkAllocateDescriptorSetsDelegate vkAllocateDescriptorSets_ptr;
		public static VkResult vkAllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)
			=> vkAllocateDescriptorSets_ptr(device, pAllocateInfo, pDescriptorSets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkFreeDescriptorSetsDelegate(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets);
		private static vkFreeDescriptorSetsDelegate vkFreeDescriptorSets_ptr;
		public static VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets)
			=> vkFreeDescriptorSets_ptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUpdateDescriptorSetsDelegate(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies);
		private static vkUpdateDescriptorSetsDelegate vkUpdateDescriptorSets_ptr;
		public static void vkUpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)
			=> vkUpdateDescriptorSets_ptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateFramebufferDelegate(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer);
		private static vkCreateFramebufferDelegate vkCreateFramebuffer_ptr;
		public static VkResult vkCreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer)
			=> vkCreateFramebuffer_ptr(device, pCreateInfo, pAllocator, pFramebuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyFramebufferDelegate(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator);
		private static vkDestroyFramebufferDelegate vkDestroyFramebuffer_ptr;
		public static void vkDestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator)
			=> vkDestroyFramebuffer_ptr(device, framebuffer, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRenderPassDelegate(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
		private static vkCreateRenderPassDelegate vkCreateRenderPass_ptr;
		public static VkResult vkCreateRenderPass(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
			=> vkCreateRenderPass_ptr(device, pCreateInfo, pAllocator, pRenderPass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyRenderPassDelegate(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator);
		private static vkDestroyRenderPassDelegate vkDestroyRenderPass_ptr;
		public static void vkDestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator)
			=> vkDestroyRenderPass_ptr(device, renderPass, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetRenderAreaGranularityDelegate(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity);
		private static vkGetRenderAreaGranularityDelegate vkGetRenderAreaGranularity_ptr;
		public static void vkGetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity)
			=> vkGetRenderAreaGranularity_ptr(device, renderPass, pGranularity);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateCommandPoolDelegate(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool);
		private static vkCreateCommandPoolDelegate vkCreateCommandPool_ptr;
		public static VkResult vkCreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool)
			=> vkCreateCommandPool_ptr(device, pCreateInfo, pAllocator, pCommandPool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator);
		private static vkDestroyCommandPoolDelegate vkDestroyCommandPool_ptr;
		public static void vkDestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator)
			=> vkDestroyCommandPool_ptr(device, commandPool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);
		private static vkResetCommandPoolDelegate vkResetCommandPool_ptr;
		public static VkResult vkResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags)
			=> vkResetCommandPool_ptr(device, commandPool, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAllocateCommandBuffersDelegate(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers);
		private static vkAllocateCommandBuffersDelegate vkAllocateCommandBuffers_ptr;
		public static VkResult vkAllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)
			=> vkAllocateCommandBuffers_ptr(device, pAllocateInfo, pCommandBuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkFreeCommandBuffersDelegate(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
		private static vkFreeCommandBuffersDelegate vkFreeCommandBuffers_ptr;
		public static void vkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
			=> vkFreeCommandBuffers_ptr(device, commandPool, commandBufferCount, pCommandBuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBeginCommandBufferDelegate(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo);
		private static vkBeginCommandBufferDelegate vkBeginCommandBuffer_ptr;
		public static VkResult vkBeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)
			=> vkBeginCommandBuffer_ptr(commandBuffer, pBeginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEndCommandBufferDelegate(VkCommandBuffer commandBuffer);
		private static vkEndCommandBufferDelegate vkEndCommandBuffer_ptr;
		public static VkResult vkEndCommandBuffer(VkCommandBuffer commandBuffer)
			=> vkEndCommandBuffer_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkResetCommandBufferDelegate(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);
		private static vkResetCommandBufferDelegate vkResetCommandBuffer_ptr;
		public static VkResult vkResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags)
			=> vkResetCommandBuffer_ptr(commandBuffer, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindPipelineDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
		private static vkCmdBindPipelineDelegate vkCmdBindPipeline_ptr;
		public static void vkCmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
			=> vkCmdBindPipeline_ptr(commandBuffer, pipelineBindPoint, pipeline);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports);
		private static vkCmdSetViewportDelegate vkCmdSetViewport_ptr;
		public static void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
			=> vkCmdSetViewport_ptr(commandBuffer, firstViewport, viewportCount, pViewports);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetScissorDelegate(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors);
		private static vkCmdSetScissorDelegate vkCmdSetScissor_ptr;
		public static void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
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
		private delegate void vkCmdSetStencilCompareMaskDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask);
		private static vkCmdSetStencilCompareMaskDelegate vkCmdSetStencilCompareMask_ptr;
		public static void vkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask)
			=> vkCmdSetStencilCompareMask_ptr(commandBuffer, faceMask, compareMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilWriteMaskDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask);
		private static vkCmdSetStencilWriteMaskDelegate vkCmdSetStencilWriteMask_ptr;
		public static void vkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask)
			=> vkCmdSetStencilWriteMask_ptr(commandBuffer, faceMask, writeMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilReferenceDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference);
		private static vkCmdSetStencilReferenceDelegate vkCmdSetStencilReference_ptr;
		public static void vkCmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference)
			=> vkCmdSetStencilReference_ptr(commandBuffer, faceMask, reference);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindDescriptorSetsDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
		private static vkCmdBindDescriptorSetsDelegate vkCmdBindDescriptorSets_ptr;
		public static void vkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
			=> vkCmdBindDescriptorSets_ptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindIndexBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType);
		private static vkCmdBindIndexBufferDelegate vkCmdBindIndexBuffer_ptr;
		public static void vkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType)
			=> vkCmdBindIndexBuffer_ptr(commandBuffer, buffer, offset, indexType);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindVertexBuffersDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets);
		private static vkCmdBindVertexBuffersDelegate vkCmdBindVertexBuffers_ptr;
		public static void vkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets)
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
		private delegate void vkCmdCopyBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions);
		private static vkCmdCopyBufferDelegate vkCmdCopyBuffer_ptr;
		public static void vkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions)
			=> vkCmdCopyBuffer_ptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions);
		private static vkCmdCopyImageDelegate vkCmdCopyImage_ptr;
		public static void vkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
			=> vkCmdCopyImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBlitImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter);
		private static vkCmdBlitImageDelegate vkCmdBlitImage_ptr;
		public static void vkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
			=> vkCmdBlitImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyBufferToImageDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions);
		private static vkCmdCopyBufferToImageDelegate vkCmdCopyBufferToImage_ptr;
		public static void vkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
			=> vkCmdCopyBufferToImage_ptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImageToBufferDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions);
		private static vkCmdCopyImageToBufferDelegate vkCmdCopyImageToBuffer_ptr;
		public static void vkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
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
		private delegate void vkCmdClearColorImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges);
		private static vkCmdClearColorImageDelegate vkCmdClearColorImage_ptr;
		public static void vkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
			=> vkCmdClearColorImage_ptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdClearDepthStencilImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges);
		private static vkCmdClearDepthStencilImageDelegate vkCmdClearDepthStencilImage_ptr;
		public static void vkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
			=> vkCmdClearDepthStencilImage_ptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdClearAttachmentsDelegate(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects);
		private static vkCmdClearAttachmentsDelegate vkCmdClearAttachments_ptr;
		public static void vkCmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
			=> vkCmdClearAttachments_ptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResolveImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions);
		private static vkCmdResolveImageDelegate vkCmdResolveImage_ptr;
		public static void vkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
			=> vkCmdResolveImage_ptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetEventDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkPipelineStageFlags stageMask);
		private static vkCmdSetEventDelegate vkCmdSetEvent_ptr;
		public static void vkCmdSetEvent(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkPipelineStageFlags stageMask)
			=> vkCmdSetEvent_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResetEventDelegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkPipelineStageFlags stageMask);
		private static vkCmdResetEventDelegate vkCmdResetEvent_ptr;
		public static void vkCmdResetEvent(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkPipelineStageFlags stageMask)
			=> vkCmdResetEvent_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWaitEventsDelegate(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
		private static vkCmdWaitEventsDelegate vkCmdWaitEvents_ptr;
		public static void vkCmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
			=> vkCmdWaitEvents_ptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPipelineBarrierDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
		private static vkCmdPipelineBarrierDelegate vkCmdPipelineBarrier_ptr;
		public static void vkCmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
			=> vkCmdPipelineBarrier_ptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags);
		private static vkCmdBeginQueryDelegate vkCmdBeginQuery_ptr;
		public static void vkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags)
			=> vkCmdBeginQuery_ptr(commandBuffer, queryPool, query, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
		private static vkCmdEndQueryDelegate vkCmdEndQuery_ptr;
		public static void vkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
			=> vkCmdEndQuery_ptr(commandBuffer, queryPool, query);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResetQueryPoolDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private static vkCmdResetQueryPoolDelegate vkCmdResetQueryPool_ptr;
		public static void vkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
			=> vkCmdResetQueryPool_ptr(commandBuffer, queryPool, firstQuery, queryCount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteTimestampDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query);
		private static vkCmdWriteTimestampDelegate vkCmdWriteTimestamp_ptr;
		public static void vkCmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query)
			=> vkCmdWriteTimestamp_ptr(commandBuffer, pipelineStage, queryPool, query);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyQueryPoolResultsDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlags flags);
		private static vkCmdCopyQueryPoolResultsDelegate vkCmdCopyQueryPoolResults_ptr;
		public static void vkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlags flags)
			=> vkCmdCopyQueryPoolResults_ptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPushConstantsDelegate(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues);
		private static vkCmdPushConstantsDelegate vkCmdPushConstants_ptr;
		public static void vkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues)
			=> vkCmdPushConstants_ptr(commandBuffer, layout, stageFlags, offset, size, pValues);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginRenderPassDelegate(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);
		private static vkCmdBeginRenderPassDelegate vkCmdBeginRenderPass_ptr;
		public static void vkCmdBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)
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
		private delegate void vkCmdExecuteCommandsDelegate(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
		private static vkCmdExecuteCommandsDelegate vkCmdExecuteCommands_ptr;
		public static void vkCmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
			=> vkCmdExecuteCommands_ptr(commandBuffer, commandBufferCount, pCommandBuffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumerateInstanceVersionDelegate(uint* pApiVersion);
		private static vkEnumerateInstanceVersionDelegate vkEnumerateInstanceVersion_ptr;
		public static VkResult vkEnumerateInstanceVersion(uint* pApiVersion)
			=> vkEnumerateInstanceVersion_ptr(pApiVersion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindBufferMemory2Delegate(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos);
		private static vkBindBufferMemory2Delegate vkBindBufferMemory2_ptr;
		public static VkResult vkBindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
			=> vkBindBufferMemory2_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindImageMemory2Delegate(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos);
		private static vkBindImageMemory2Delegate vkBindImageMemory2_ptr;
		public static VkResult vkBindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
			=> vkBindImageMemory2_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceGroupPeerMemoryFeaturesDelegate(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);
		private static vkGetDeviceGroupPeerMemoryFeaturesDelegate vkGetDeviceGroupPeerMemoryFeatures_ptr;
		public static void vkGetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures)
			=> vkGetDeviceGroupPeerMemoryFeatures_ptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDeviceMaskDelegate(VkCommandBuffer commandBuffer, uint deviceMask);
		private static vkCmdSetDeviceMaskDelegate vkCmdSetDeviceMask_ptr;
		public static void vkCmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
			=> vkCmdSetDeviceMask_ptr(commandBuffer, deviceMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDispatchBaseDelegate(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
		private static vkCmdDispatchBaseDelegate vkCmdDispatchBase_ptr;
		public static void vkCmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
			=> vkCmdDispatchBase_ptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumeratePhysicalDeviceGroupsDelegate(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
		private static vkEnumeratePhysicalDeviceGroupsDelegate vkEnumeratePhysicalDeviceGroups_ptr;
		public static VkResult vkEnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
			=> vkEnumeratePhysicalDeviceGroups_ptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageMemoryRequirements2Delegate(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetImageMemoryRequirements2Delegate vkGetImageMemoryRequirements2_ptr;
		public static void vkGetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetImageMemoryRequirements2_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetBufferMemoryRequirements2Delegate(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetBufferMemoryRequirements2Delegate vkGetBufferMemoryRequirements2_ptr;
		public static void vkGetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetBufferMemoryRequirements2_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSparseMemoryRequirements2Delegate(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
		private static vkGetImageSparseMemoryRequirements2Delegate vkGetImageSparseMemoryRequirements2_ptr;
		public static void vkGetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
			=> vkGetImageSparseMemoryRequirements2_ptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFeatures2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures);
		private static vkGetPhysicalDeviceFeatures2Delegate vkGetPhysicalDeviceFeatures2_ptr;
		public static void vkGetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
			=> vkGetPhysicalDeviceFeatures2_ptr(physicalDevice, pFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceProperties2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties);
		private static vkGetPhysicalDeviceProperties2Delegate vkGetPhysicalDeviceProperties2_ptr;
		public static void vkGetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
			=> vkGetPhysicalDeviceProperties2_ptr(physicalDevice, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceFormatProperties2Delegate(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties);
		private static vkGetPhysicalDeviceFormatProperties2Delegate vkGetPhysicalDeviceFormatProperties2_ptr;
		public static void vkGetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
			=> vkGetPhysicalDeviceFormatProperties2_ptr(physicalDevice, format, pFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties);
		private static vkGetPhysicalDeviceImageFormatProperties2Delegate vkGetPhysicalDeviceImageFormatProperties2_ptr;
		public static VkResult vkGetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
			=> vkGetPhysicalDeviceImageFormatProperties2_ptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceQueueFamilyProperties2Delegate(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);
		private static vkGetPhysicalDeviceQueueFamilyProperties2Delegate vkGetPhysicalDeviceQueueFamilyProperties2_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
			=> vkGetPhysicalDeviceQueueFamilyProperties2_ptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceMemoryProperties2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties);
		private static vkGetPhysicalDeviceMemoryProperties2Delegate vkGetPhysicalDeviceMemoryProperties2_ptr;
		public static void vkGetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
			=> vkGetPhysicalDeviceMemoryProperties2_ptr(physicalDevice, pMemoryProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceSparseImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties);
		private static vkGetPhysicalDeviceSparseImageFormatProperties2Delegate vkGetPhysicalDeviceSparseImageFormatProperties2_ptr;
		public static void vkGetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
			=> vkGetPhysicalDeviceSparseImageFormatProperties2_ptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkTrimCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, uint flags);
		private static vkTrimCommandPoolDelegate vkTrimCommandPool_ptr;
		public static void vkTrimCommandPool(VkDevice device, VkCommandPool commandPool, uint flags)
			=> vkTrimCommandPool_ptr(device, commandPool, flags);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceQueue2Delegate(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue);
		private static vkGetDeviceQueue2Delegate vkGetDeviceQueue2_ptr;
		public static void vkGetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue)
			=> vkGetDeviceQueue2_ptr(device, pQueueInfo, pQueue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSamplerYcbcrConversionDelegate(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion);
		private static vkCreateSamplerYcbcrConversionDelegate vkCreateSamplerYcbcrConversion_ptr;
		public static VkResult vkCreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
			=> vkCreateSamplerYcbcrConversion_ptr(device, pCreateInfo, pAllocator, pYcbcrConversion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySamplerYcbcrConversionDelegate(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator);
		private static vkDestroySamplerYcbcrConversionDelegate vkDestroySamplerYcbcrConversion_ptr;
		public static void vkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
			=> vkDestroySamplerYcbcrConversion_ptr(device, ycbcrConversion, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDescriptorUpdateTemplateDelegate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate);
		private static vkCreateDescriptorUpdateTemplateDelegate vkCreateDescriptorUpdateTemplate_ptr;
		public static VkResult vkCreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
			=> vkCreateDescriptorUpdateTemplate_ptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDescriptorUpdateTemplateDelegate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDescriptorUpdateTemplateDelegate vkDestroyDescriptorUpdateTemplate_ptr;
		public static void vkDestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDescriptorUpdateTemplate_ptr(device, descriptorUpdateTemplate, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUpdateDescriptorSetWithTemplateDelegate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
		private static vkUpdateDescriptorSetWithTemplateDelegate vkUpdateDescriptorSetWithTemplate_ptr;
		public static void vkUpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
			=> vkUpdateDescriptorSetWithTemplate_ptr(device, descriptorSet, descriptorUpdateTemplate, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceExternalBufferPropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties);
		private static vkGetPhysicalDeviceExternalBufferPropertiesDelegate vkGetPhysicalDeviceExternalBufferProperties_ptr;
		public static void vkGetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
			=> vkGetPhysicalDeviceExternalBufferProperties_ptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceExternalFencePropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties);
		private static vkGetPhysicalDeviceExternalFencePropertiesDelegate vkGetPhysicalDeviceExternalFenceProperties_ptr;
		public static void vkGetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
			=> vkGetPhysicalDeviceExternalFenceProperties_ptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties);
		private static vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate vkGetPhysicalDeviceExternalSemaphoreProperties_ptr;
		public static void vkGetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
			=> vkGetPhysicalDeviceExternalSemaphoreProperties_ptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDescriptorSetLayoutSupportDelegate(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport);
		private static vkGetDescriptorSetLayoutSupportDelegate vkGetDescriptorSetLayoutSupport_ptr;
		public static void vkGetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
			=> vkGetDescriptorSetLayoutSupport_ptr(device, pCreateInfo, pSupport);

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
		private delegate VkResult vkCreateRenderPass2Delegate(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
		private static vkCreateRenderPass2Delegate vkCreateRenderPass2_ptr;
		public static VkResult vkCreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
			=> vkCreateRenderPass2_ptr(device, pCreateInfo, pAllocator, pRenderPass);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginRenderPass2Delegate(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo);
		private static vkCmdBeginRenderPass2Delegate vkCmdBeginRenderPass2_ptr;
		public static void vkCmdBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
			=> vkCmdBeginRenderPass2_ptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdNextSubpass2Delegate(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo);
		private static vkCmdNextSubpass2Delegate vkCmdNextSubpass2_ptr;
		public static void vkCmdNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
			=> vkCmdNextSubpass2_ptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndRenderPass2Delegate(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo);
		private static vkCmdEndRenderPass2Delegate vkCmdEndRenderPass2_ptr;
		public static void vkCmdEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
			=> vkCmdEndRenderPass2_ptr(commandBuffer, pSubpassEndInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkResetQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
		private static vkResetQueryPoolDelegate vkResetQueryPool_ptr;
		public static void vkResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
			=> vkResetQueryPool_ptr(device, queryPool, firstQuery, queryCount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreCounterValueDelegate(VkDevice device, VkSemaphore semaphore, ulong* pValue);
		private static vkGetSemaphoreCounterValueDelegate vkGetSemaphoreCounterValue_ptr;
		public static VkResult vkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
			=> vkGetSemaphoreCounterValue_ptr(device, semaphore, pValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWaitSemaphoresDelegate(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout);
		private static vkWaitSemaphoresDelegate vkWaitSemaphores_ptr;
		public static VkResult vkWaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
			=> vkWaitSemaphores_ptr(device, pWaitInfo, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSignalSemaphoreDelegate(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo);
		private static vkSignalSemaphoreDelegate vkSignalSemaphore_ptr;
		public static VkResult vkSignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
			=> vkSignalSemaphore_ptr(device, pSignalInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetBufferDeviceAddressDelegate(VkDevice device, VkBufferDeviceAddressInfo* pInfo);
		private static vkGetBufferDeviceAddressDelegate vkGetBufferDeviceAddress_ptr;
		public static ulong vkGetBufferDeviceAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
			=> vkGetBufferDeviceAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetBufferOpaqueCaptureAddressDelegate(VkDevice device, VkBufferDeviceAddressInfo* pInfo);
		private static vkGetBufferOpaqueCaptureAddressDelegate vkGetBufferOpaqueCaptureAddress_ptr;
		public static ulong vkGetBufferOpaqueCaptureAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
			=> vkGetBufferOpaqueCaptureAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetDeviceMemoryOpaqueCaptureAddressDelegate(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);
		private static vkGetDeviceMemoryOpaqueCaptureAddressDelegate vkGetDeviceMemoryOpaqueCaptureAddress_ptr;
		public static ulong vkGetDeviceMemoryOpaqueCaptureAddress(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
			=> vkGetDeviceMemoryOpaqueCaptureAddress_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceToolPropertiesDelegate(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties);
		private static vkGetPhysicalDeviceToolPropertiesDelegate vkGetPhysicalDeviceToolProperties_ptr;
		public static VkResult vkGetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
			=> vkGetPhysicalDeviceToolProperties_ptr(physicalDevice, pToolCount, pToolProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreatePrivateDataSlotDelegate(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot);
		private static vkCreatePrivateDataSlotDelegate vkCreatePrivateDataSlot_ptr;
		public static VkResult vkCreatePrivateDataSlot(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot)
			=> vkCreatePrivateDataSlot_ptr(device, pCreateInfo, pAllocator, pPrivateDataSlot);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyPrivateDataSlotDelegate(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator);
		private static vkDestroyPrivateDataSlotDelegate vkDestroyPrivateDataSlot_ptr;
		public static void vkDestroyPrivateDataSlot(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator)
			=> vkDestroyPrivateDataSlot_ptr(device, privateDataSlot, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetPrivateDataDelegate(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data);
		private static vkSetPrivateDataDelegate vkSetPrivateData_ptr;
		public static VkResult vkSetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data)
			=> vkSetPrivateData_ptr(device, objectType, objectHandle, privateDataSlot, data);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPrivateDataDelegate(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData);
		private static vkGetPrivateDataDelegate vkGetPrivateData_ptr;
		public static void vkGetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData)
			=> vkGetPrivateData_ptr(device, objectType, objectHandle, privateDataSlot, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetEvent2Delegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkDependencyInfo* pDependencyInfo);
		private static vkCmdSetEvent2Delegate vkCmdSetEvent2_ptr;
		public static void vkCmdSetEvent2(VkCommandBuffer commandBuffer, VkEvent vkEvent, VkDependencyInfo* pDependencyInfo)
			=> vkCmdSetEvent2_ptr(commandBuffer, vkEvent, pDependencyInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResetEvent2Delegate(VkCommandBuffer commandBuffer, VkEvent vkEvent, ulong stageMask);
		private static vkCmdResetEvent2Delegate vkCmdResetEvent2_ptr;
		public static void vkCmdResetEvent2(VkCommandBuffer commandBuffer, VkEvent vkEvent, ulong stageMask)
			=> vkCmdResetEvent2_ptr(commandBuffer, vkEvent, stageMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWaitEvents2Delegate(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos);
		private static vkCmdWaitEvents2Delegate vkCmdWaitEvents2_ptr;
		public static void vkCmdWaitEvents2(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos)
			=> vkCmdWaitEvents2_ptr(commandBuffer, eventCount, pEvents, pDependencyInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPipelineBarrier2Delegate(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo);
		private static vkCmdPipelineBarrier2Delegate vkCmdPipelineBarrier2_ptr;
		public static void vkCmdPipelineBarrier2(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo)
			=> vkCmdPipelineBarrier2_ptr(commandBuffer, pDependencyInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteTimestamp2Delegate(VkCommandBuffer commandBuffer, ulong stage, VkQueryPool queryPool, uint query);
		private static vkCmdWriteTimestamp2Delegate vkCmdWriteTimestamp2_ptr;
		public static void vkCmdWriteTimestamp2(VkCommandBuffer commandBuffer, ulong stage, VkQueryPool queryPool, uint query)
			=> vkCmdWriteTimestamp2_ptr(commandBuffer, stage, queryPool, query);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueueSubmit2Delegate(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence);
		private static vkQueueSubmit2Delegate vkQueueSubmit2_ptr;
		public static VkResult vkQueueSubmit2(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
			=> vkQueueSubmit2_ptr(queue, submitCount, pSubmits, fence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyBuffer2Delegate(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo);
		private static vkCmdCopyBuffer2Delegate vkCmdCopyBuffer2_ptr;
		public static void vkCmdCopyBuffer2(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
			=> vkCmdCopyBuffer2_ptr(commandBuffer, pCopyBufferInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImage2Delegate(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo);
		private static vkCmdCopyImage2Delegate vkCmdCopyImage2_ptr;
		public static void vkCmdCopyImage2(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
			=> vkCmdCopyImage2_ptr(commandBuffer, pCopyImageInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyBufferToImage2Delegate(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo);
		private static vkCmdCopyBufferToImage2Delegate vkCmdCopyBufferToImage2_ptr;
		public static void vkCmdCopyBufferToImage2(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
			=> vkCmdCopyBufferToImage2_ptr(commandBuffer, pCopyBufferToImageInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyImageToBuffer2Delegate(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo);
		private static vkCmdCopyImageToBuffer2Delegate vkCmdCopyImageToBuffer2_ptr;
		public static void vkCmdCopyImageToBuffer2(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
			=> vkCmdCopyImageToBuffer2_ptr(commandBuffer, pCopyImageToBufferInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBlitImage2Delegate(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo);
		private static vkCmdBlitImage2Delegate vkCmdBlitImage2_ptr;
		public static void vkCmdBlitImage2(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
			=> vkCmdBlitImage2_ptr(commandBuffer, pBlitImageInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdResolveImage2Delegate(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo);
		private static vkCmdResolveImage2Delegate vkCmdResolveImage2_ptr;
		public static void vkCmdResolveImage2(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
			=> vkCmdResolveImage2_ptr(commandBuffer, pResolveImageInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginRenderingDelegate(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo);
		private static vkCmdBeginRenderingDelegate vkCmdBeginRendering_ptr;
		public static void vkCmdBeginRendering(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo)
			=> vkCmdBeginRendering_ptr(commandBuffer, pRenderingInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndRenderingDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndRenderingDelegate vkCmdEndRendering_ptr;
		public static void vkCmdEndRendering(VkCommandBuffer commandBuffer)
			=> vkCmdEndRendering_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCullModeDelegate(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode);
		private static vkCmdSetCullModeDelegate vkCmdSetCullMode_ptr;
		public static void vkCmdSetCullMode(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode)
			=> vkCmdSetCullMode_ptr(commandBuffer, cullMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetFrontFaceDelegate(VkCommandBuffer commandBuffer, VkFrontFace frontFace);
		private static vkCmdSetFrontFaceDelegate vkCmdSetFrontFace_ptr;
		public static void vkCmdSetFrontFace(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
			=> vkCmdSetFrontFace_ptr(commandBuffer, frontFace);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetPrimitiveTopologyDelegate(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology);
		private static vkCmdSetPrimitiveTopologyDelegate vkCmdSetPrimitiveTopology_ptr;
		public static void vkCmdSetPrimitiveTopology(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
			=> vkCmdSetPrimitiveTopology_ptr(commandBuffer, primitiveTopology);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportWithCountDelegate(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports);
		private static vkCmdSetViewportWithCountDelegate vkCmdSetViewportWithCount_ptr;
		public static void vkCmdSetViewportWithCount(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
			=> vkCmdSetViewportWithCount_ptr(commandBuffer, viewportCount, pViewports);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetScissorWithCountDelegate(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors);
		private static vkCmdSetScissorWithCountDelegate vkCmdSetScissorWithCount_ptr;
		public static void vkCmdSetScissorWithCount(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
			=> vkCmdSetScissorWithCount_ptr(commandBuffer, scissorCount, pScissors);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindVertexBuffers2Delegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides);
		private static vkCmdBindVertexBuffers2Delegate vkCmdBindVertexBuffers2_ptr;
		public static void vkCmdBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides)
			=> vkCmdBindVertexBuffers2_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthTestEnableDelegate(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable);
		private static vkCmdSetDepthTestEnableDelegate vkCmdSetDepthTestEnable_ptr;
		public static void vkCmdSetDepthTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable)
			=> vkCmdSetDepthTestEnable_ptr(commandBuffer, depthTestEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthWriteEnableDelegate(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable);
		private static vkCmdSetDepthWriteEnableDelegate vkCmdSetDepthWriteEnable_ptr;
		public static void vkCmdSetDepthWriteEnable(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable)
			=> vkCmdSetDepthWriteEnable_ptr(commandBuffer, depthWriteEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthCompareOpDelegate(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp);
		private static vkCmdSetDepthCompareOpDelegate vkCmdSetDepthCompareOp_ptr;
		public static void vkCmdSetDepthCompareOp(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
			=> vkCmdSetDepthCompareOp_ptr(commandBuffer, depthCompareOp);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthBoundsTestEnableDelegate(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable);
		private static vkCmdSetDepthBoundsTestEnableDelegate vkCmdSetDepthBoundsTestEnable_ptr;
		public static void vkCmdSetDepthBoundsTestEnable(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable)
			=> vkCmdSetDepthBoundsTestEnable_ptr(commandBuffer, depthBoundsTestEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilTestEnableDelegate(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable);
		private static vkCmdSetStencilTestEnableDelegate vkCmdSetStencilTestEnable_ptr;
		public static void vkCmdSetStencilTestEnable(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable)
			=> vkCmdSetStencilTestEnable_ptr(commandBuffer, stencilTestEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetStencilOpDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp);
		private static vkCmdSetStencilOpDelegate vkCmdSetStencilOp_ptr;
		public static void vkCmdSetStencilOp(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
			=> vkCmdSetStencilOp_ptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetRasterizerDiscardEnableDelegate(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable);
		private static vkCmdSetRasterizerDiscardEnableDelegate vkCmdSetRasterizerDiscardEnable_ptr;
		public static void vkCmdSetRasterizerDiscardEnable(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable)
			=> vkCmdSetRasterizerDiscardEnable_ptr(commandBuffer, rasterizerDiscardEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthBiasEnableDelegate(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable);
		private static vkCmdSetDepthBiasEnableDelegate vkCmdSetDepthBiasEnable_ptr;
		public static void vkCmdSetDepthBiasEnable(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable)
			=> vkCmdSetDepthBiasEnable_ptr(commandBuffer, depthBiasEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetPrimitiveRestartEnableDelegate(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable);
		private static vkCmdSetPrimitiveRestartEnableDelegate vkCmdSetPrimitiveRestartEnable_ptr;
		public static void vkCmdSetPrimitiveRestartEnable(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable)
			=> vkCmdSetPrimitiveRestartEnable_ptr(commandBuffer, primitiveRestartEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceBufferMemoryRequirementsDelegate(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetDeviceBufferMemoryRequirementsDelegate vkGetDeviceBufferMemoryRequirements_ptr;
		public static void vkGetDeviceBufferMemoryRequirements(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetDeviceBufferMemoryRequirements_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceImageMemoryRequirementsDelegate(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetDeviceImageMemoryRequirementsDelegate vkGetDeviceImageMemoryRequirements_ptr;
		public static void vkGetDeviceImageMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetDeviceImageMemoryRequirements_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceImageSparseMemoryRequirementsDelegate(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
		private static vkGetDeviceImageSparseMemoryRequirementsDelegate vkGetDeviceImageSparseMemoryRequirements_ptr;
		public static void vkGetDeviceImageSparseMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
			=> vkGetDeviceImageSparseMemoryRequirements_ptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetCommandPoolMemoryConsumptionDelegate(VkDevice device, VkCommandPool commandPool, VkCommandBuffer commandBuffer, VkCommandPoolMemoryConsumption* pConsumption);
		private static vkGetCommandPoolMemoryConsumptionDelegate vkGetCommandPoolMemoryConsumption_ptr;
		public static void vkGetCommandPoolMemoryConsumption(VkDevice device, VkCommandPool commandPool, VkCommandBuffer commandBuffer, VkCommandPoolMemoryConsumption* pConsumption)
			=> vkGetCommandPoolMemoryConsumption_ptr(device, commandPool, commandBuffer, pConsumption);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFaultDataDelegate(VkDevice device, VkFaultQueryBehavior faultQueryBehavior, VkBool32* pUnrecordedFaults, uint* pFaultCount, VkFaultData* pFaults);
		private static vkGetFaultDataDelegate vkGetFaultData_ptr;
		public static VkResult vkGetFaultData(VkDevice device, VkFaultQueryBehavior faultQueryBehavior, VkBool32* pUnrecordedFaults, uint* pFaultCount, VkFaultData* pFaults)
			=> vkGetFaultData_ptr(device, faultQueryBehavior, pUnrecordedFaults, pFaultCount, pFaults);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySurfaceKHRDelegate(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator);
		private static vkDestroySurfaceKHRDelegate vkDestroySurfaceKHR_ptr;
		public static void vkDestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
			=> vkDestroySurfaceKHR_ptr(instance, surface, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported);
		private static vkGetPhysicalDeviceSurfaceSupportKHRDelegate vkGetPhysicalDeviceSurfaceSupportKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, VkBool32* pSupported)
			=> vkGetPhysicalDeviceSurfaceSupportKHR_ptr(physicalDevice, queueFamilyIndex, surface, pSupported);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr(physicalDevice, surface, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceFormatsKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats);
		private static vkGetPhysicalDeviceSurfaceFormatsKHRDelegate vkGetPhysicalDeviceSurfaceFormatsKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
			=> vkGetPhysicalDeviceSurfaceFormatsKHR_ptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfacePresentModesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);
		private static vkGetPhysicalDeviceSurfacePresentModesKHRDelegate vkGetPhysicalDeviceSurfacePresentModesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
			=> vkGetPhysicalDeviceSurfacePresentModesKHR_ptr(physicalDevice, surface, pPresentModeCount, pPresentModes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSwapchainKHRDelegate(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain);
		private static vkCreateSwapchainKHRDelegate vkCreateSwapchainKHR_ptr;
		public static VkResult vkCreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
			=> vkCreateSwapchainKHR_ptr(device, pCreateInfo, pAllocator, pSwapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySwapchainKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator);
		private static vkDestroySwapchainKHRDelegate vkDestroySwapchainKHR_ptr;
		public static void vkDestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)
			=> vkDestroySwapchainKHR_ptr(device, swapchain, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainImagesKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages);
		private static vkGetSwapchainImagesKHRDelegate vkGetSwapchainImagesKHR_ptr;
		public static VkResult vkGetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages)
			=> vkGetSwapchainImagesKHR_ptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireNextImageKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex);
		private static vkAcquireNextImageKHRDelegate vkAcquireNextImageKHR_ptr;
		public static VkResult vkAcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
			=> vkAcquireNextImageKHR_ptr(device, swapchain, timeout, semaphore, fence, pImageIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkQueuePresentKHRDelegate(VkQueue queue, VkPresentInfoKHR* pPresentInfo);
		private static vkQueuePresentKHRDelegate vkQueuePresentKHR_ptr;
		public static VkResult vkQueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
			=> vkQueuePresentKHR_ptr(queue, pPresentInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties);
		private static vkGetPhysicalDeviceDisplayPropertiesKHRDelegate vkGetPhysicalDeviceDisplayPropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
			=> vkGetPhysicalDeviceDisplayPropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties);
		private static vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
			=> vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayPlaneSupportedDisplaysKHRDelegate(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays);
		private static vkGetDisplayPlaneSupportedDisplaysKHRDelegate vkGetDisplayPlaneSupportedDisplaysKHR_ptr;
		public static VkResult vkGetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays)
			=> vkGetDisplayPlaneSupportedDisplaysKHR_ptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayModePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties);
		private static vkGetDisplayModePropertiesKHRDelegate vkGetDisplayModePropertiesKHR_ptr;
		public static VkResult vkGetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
			=> vkGetDisplayModePropertiesKHR_ptr(physicalDevice, display, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDisplayModeKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode);
		private static vkCreateDisplayModeKHRDelegate vkCreateDisplayModeKHR_ptr;
		public static VkResult vkCreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
			=> vkCreateDisplayModeKHR_ptr(physicalDevice, display, pCreateInfo, pAllocator, pMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayPlaneCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities);
		private static vkGetDisplayPlaneCapabilitiesKHRDelegate vkGetDisplayPlaneCapabilitiesKHR_ptr;
		public static VkResult vkGetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
			=> vkGetDisplayPlaneCapabilitiesKHR_ptr(physicalDevice, mode, planeIndex, pCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDisplayPlaneSurfaceKHRDelegate(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateDisplayPlaneSurfaceKHRDelegate vkCreateDisplayPlaneSurfaceKHR_ptr;
		public static VkResult vkCreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateDisplayPlaneSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSharedSwapchainsKHRDelegate(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains);
		private static vkCreateSharedSwapchainsKHRDelegate vkCreateSharedSwapchainsKHR_ptr;
		public static VkResult vkCreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
			=> vkCreateSharedSwapchainsKHR_ptr(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateXlibSurfaceKHRDelegate(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateXlibSurfaceKHRDelegate vkCreateXlibSurfaceKHR_ptr;
		public static VkResult vkCreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateXlibSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID);
		private static vkGetPhysicalDeviceXlibPresentationSupportKHRDelegate vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr;
		public static VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
			=> vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, dpy, visualID);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateXcbSurfaceKHRDelegate(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateXcbSurfaceKHRDelegate vkCreateXcbSurfaceKHR_ptr;
		public static VkResult vkCreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateXcbSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, IntPtr visual_id);
		private static vkGetPhysicalDeviceXcbPresentationSupportKHRDelegate vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr;
		public static VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, IntPtr visual_id)
			=> vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, connection, visual_id);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateWaylandSurfaceKHRDelegate(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateWaylandSurfaceKHRDelegate vkCreateWaylandSurfaceKHR_ptr;
		public static VkResult vkCreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateWaylandSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display);
		private static vkGetPhysicalDeviceWaylandPresentationSupportKHRDelegate vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr;
		public static VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display)
			=> vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateAndroidSurfaceKHRDelegate(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateAndroidSurfaceKHRDelegate vkCreateAndroidSurfaceKHR_ptr;
		public static VkResult vkCreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateAndroidSurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateWin32SurfaceKHRDelegate(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateWin32SurfaceKHRDelegate vkCreateWin32SurfaceKHR_ptr;
		public static VkResult vkCreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateWin32SurfaceKHR_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex);
		private static vkGetPhysicalDeviceWin32PresentationSupportKHRDelegate vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr;
		public static VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
			=> vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr(physicalDevice, queueFamilyIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDebugReportCallbackEXTDelegate(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback);
		private static vkCreateDebugReportCallbackEXTDelegate vkCreateDebugReportCallbackEXT_ptr;
		public static VkResult vkCreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
			=> vkCreateDebugReportCallbackEXT_ptr(instance, pCreateInfo, pAllocator, pCallback);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDebugReportCallbackEXTDelegate(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDebugReportCallbackEXTDelegate vkDestroyDebugReportCallbackEXT_ptr;
		public static void vkDestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDebugReportCallbackEXT_ptr(instance, callback, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDebugReportMessageEXTDelegate(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong vkObject, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage);
		private static vkDebugReportMessageEXTDelegate vkDebugReportMessageEXT_ptr;
		public static void vkDebugReportMessageEXT(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong vkObject, UIntPtr location, int messageCode, byte* pLayerPrefix, byte* pMessage)
			=> vkDebugReportMessageEXT_ptr(instance, flags, objectType, vkObject, location, messageCode, pLayerPrefix, pMessage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDebugMarkerSetObjectTagEXTDelegate(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo);
		private static vkDebugMarkerSetObjectTagEXTDelegate vkDebugMarkerSetObjectTagEXT_ptr;
		public static VkResult vkDebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
			=> vkDebugMarkerSetObjectTagEXT_ptr(device, pTagInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDebugMarkerSetObjectNameEXTDelegate(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo);
		private static vkDebugMarkerSetObjectNameEXTDelegate vkDebugMarkerSetObjectNameEXT_ptr;
		public static VkResult vkDebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
			=> vkDebugMarkerSetObjectNameEXT_ptr(device, pNameInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDebugMarkerBeginEXTDelegate(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
		private static vkCmdDebugMarkerBeginEXTDelegate vkCmdDebugMarkerBeginEXT_ptr;
		public static void vkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
			=> vkCmdDebugMarkerBeginEXT_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDebugMarkerEndEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdDebugMarkerEndEXTDelegate vkCmdDebugMarkerEndEXT_ptr;
		public static void vkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
			=> vkCmdDebugMarkerEndEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDebugMarkerInsertEXTDelegate(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo);
		private static vkCmdDebugMarkerInsertEXTDelegate vkCmdDebugMarkerInsertEXT_ptr;
		public static void vkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
			=> vkCmdDebugMarkerInsertEXT_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceVideoCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities);
		private static vkGetPhysicalDeviceVideoCapabilitiesKHRDelegate vkGetPhysicalDeviceVideoCapabilitiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
			=> vkGetPhysicalDeviceVideoCapabilitiesKHR_ptr(physicalDevice, pVideoProfile, pCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties);
		private static vkGetPhysicalDeviceVideoFormatPropertiesKHRDelegate vkGetPhysicalDeviceVideoFormatPropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
			=> vkGetPhysicalDeviceVideoFormatPropertiesKHR_ptr(physicalDevice, pVideoFormatInfo, pVideoFormatPropertyCount, pVideoFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateVideoSessionKHRDelegate(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession);
		private static vkCreateVideoSessionKHRDelegate vkCreateVideoSessionKHR_ptr;
		public static VkResult vkCreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
			=> vkCreateVideoSessionKHR_ptr(device, pCreateInfo, pAllocator, pVideoSession);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyVideoSessionKHRDelegate(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator);
		private static vkDestroyVideoSessionKHRDelegate vkDestroyVideoSessionKHR_ptr;
		public static void vkDestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator)
			=> vkDestroyVideoSessionKHR_ptr(device, videoSession, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetVideoSessionMemoryRequirementsKHRDelegate(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements);
		private static vkGetVideoSessionMemoryRequirementsKHRDelegate vkGetVideoSessionMemoryRequirementsKHR_ptr;
		public static VkResult vkGetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
			=> vkGetVideoSessionMemoryRequirementsKHR_ptr(device, videoSession, pMemoryRequirementsCount, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindVideoSessionMemoryKHRDelegate(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos);
		private static vkBindVideoSessionMemoryKHRDelegate vkBindVideoSessionMemoryKHR_ptr;
		public static VkResult vkBindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos)
			=> vkBindVideoSessionMemoryKHR_ptr(device, videoSession, bindSessionMemoryInfoCount, pBindSessionMemoryInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateVideoSessionParametersKHRDelegate(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters);
		private static vkCreateVideoSessionParametersKHRDelegate vkCreateVideoSessionParametersKHR_ptr;
		public static VkResult vkCreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
			=> vkCreateVideoSessionParametersKHR_ptr(device, pCreateInfo, pAllocator, pVideoSessionParameters);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkUpdateVideoSessionParametersKHRDelegate(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo);
		private static vkUpdateVideoSessionParametersKHRDelegate vkUpdateVideoSessionParametersKHR_ptr;
		public static VkResult vkUpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
			=> vkUpdateVideoSessionParametersKHR_ptr(device, videoSessionParameters, pUpdateInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyVideoSessionParametersKHRDelegate(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator);
		private static vkDestroyVideoSessionParametersKHRDelegate vkDestroyVideoSessionParametersKHR_ptr;
		public static void vkDestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator)
			=> vkDestroyVideoSessionParametersKHR_ptr(device, videoSessionParameters, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginVideoCodingKHRDelegate(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo);
		private static vkCmdBeginVideoCodingKHRDelegate vkCmdBeginVideoCodingKHR_ptr;
		public static void vkCmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
			=> vkCmdBeginVideoCodingKHR_ptr(commandBuffer, pBeginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndVideoCodingKHRDelegate(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo);
		private static vkCmdEndVideoCodingKHRDelegate vkCmdEndVideoCodingKHR_ptr;
		public static void vkCmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
			=> vkCmdEndVideoCodingKHR_ptr(commandBuffer, pEndCodingInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdControlVideoCodingKHRDelegate(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo);
		private static vkCmdControlVideoCodingKHRDelegate vkCmdControlVideoCodingKHR_ptr;
		public static void vkCmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
			=> vkCmdControlVideoCodingKHR_ptr(commandBuffer, pCodingControlInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDecodeVideoKHRDelegate(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo);
		private static vkCmdDecodeVideoKHRDelegate vkCmdDecodeVideoKHR_ptr;
		public static void vkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
			=> vkCmdDecodeVideoKHR_ptr(commandBuffer, pDecodeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindTransformFeedbackBuffersEXTDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes);
		private static vkCmdBindTransformFeedbackBuffersEXTDelegate vkCmdBindTransformFeedbackBuffersEXT_ptr;
		public static void vkCmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes)
			=> vkCmdBindTransformFeedbackBuffersEXT_ptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets);
		private static vkCmdBeginTransformFeedbackEXTDelegate vkCmdBeginTransformFeedbackEXT_ptr;
		public static void vkCmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
			=> vkCmdBeginTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets);
		private static vkCmdEndTransformFeedbackEXTDelegate vkCmdEndTransformFeedbackEXT_ptr;
		public static void vkCmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
			=> vkCmdEndTransformFeedbackEXT_ptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginQueryIndexedEXTDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index);
		private static vkCmdBeginQueryIndexedEXTDelegate vkCmdBeginQueryIndexedEXT_ptr;
		public static void vkCmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index)
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
		private delegate VkResult vkCreateCuModuleNVXDelegate(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule);
		private static vkCreateCuModuleNVXDelegate vkCreateCuModuleNVX_ptr;
		public static VkResult vkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
			=> vkCreateCuModuleNVX_ptr(device, pCreateInfo, pAllocator, pModule);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateCuFunctionNVXDelegate(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction);
		private static vkCreateCuFunctionNVXDelegate vkCreateCuFunctionNVX_ptr;
		public static VkResult vkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
			=> vkCreateCuFunctionNVX_ptr(device, pCreateInfo, pAllocator, pFunction);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyCuModuleNVXDelegate(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator);
		private static vkDestroyCuModuleNVXDelegate vkDestroyCuModuleNVX_ptr;
		public static void vkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator)
			=> vkDestroyCuModuleNVX_ptr(device, module, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyCuFunctionNVXDelegate(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator);
		private static vkDestroyCuFunctionNVXDelegate vkDestroyCuFunctionNVX_ptr;
		public static void vkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator)
			=> vkDestroyCuFunctionNVX_ptr(device, function, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCuLaunchKernelNVXDelegate(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo);
		private static vkCmdCuLaunchKernelNVXDelegate vkCmdCuLaunchKernelNVX_ptr;
		public static void vkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
			=> vkCmdCuLaunchKernelNVX_ptr(commandBuffer, pLaunchInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate uint vkGetImageViewHandleNVXDelegate(VkDevice device, VkImageViewHandleInfoNVX* pInfo);
		private static vkGetImageViewHandleNVXDelegate vkGetImageViewHandleNVX_ptr;
		public static uint vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
			=> vkGetImageViewHandleNVX_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetImageViewAddressNVXDelegate(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties);
		private static vkGetImageViewAddressNVXDelegate vkGetImageViewAddressNVX_ptr;
		public static VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
			=> vkGetImageViewAddressNVX_ptr(device, imageView, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetShaderInfoAMDDelegate(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo);
		private static vkGetShaderInfoAMDDelegate vkGetShaderInfoAMD_ptr;
		public static VkResult vkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, UIntPtr* pInfoSize, void* pInfo)
			=> vkGetShaderInfoAMD_ptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateStreamDescriptorSurfaceGGPDelegate(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateStreamDescriptorSurfaceGGPDelegate vkCreateStreamDescriptorSurfaceGGP_ptr;
		public static VkResult vkCreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateStreamDescriptorSurfaceGGP_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);
		private static vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr;
		public static VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
			=> vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryWin32HandleNVDelegate(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr pHandle);
		private static vkGetMemoryWin32HandleNVDelegate vkGetMemoryWin32HandleNV_ptr;
		public static VkResult vkGetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr pHandle)
			=> vkGetMemoryWin32HandleNV_ptr(device, memory, handleType, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateViSurfaceNNDelegate(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateViSurfaceNNDelegate vkCreateViSurfaceNN_ptr;
		public static VkResult vkCreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateViSurfaceNN_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryWin32HandleKHRDelegate(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetMemoryWin32HandleKHRDelegate vkGetMemoryWin32HandleKHR_ptr;
		public static VkResult vkGetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetMemoryWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryWin32HandlePropertiesKHRDelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);
		private static vkGetMemoryWin32HandlePropertiesKHRDelegate vkGetMemoryWin32HandlePropertiesKHR_ptr;
		public static VkResult vkGetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
			=> vkGetMemoryWin32HandlePropertiesKHR_ptr(device, handleType, handle, pMemoryWin32HandleProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryFdKHRDelegate(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd);
		private static vkGetMemoryFdKHRDelegate vkGetMemoryFdKHR_ptr;
		public static VkResult vkGetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
			=> vkGetMemoryFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryFdPropertiesKHRDelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties);
		private static vkGetMemoryFdPropertiesKHRDelegate vkGetMemoryFdPropertiesKHR_ptr;
		public static VkResult vkGetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
			=> vkGetMemoryFdPropertiesKHR_ptr(device, handleType, fd, pMemoryFdProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportSemaphoreWin32HandleKHRDelegate(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
		private static vkImportSemaphoreWin32HandleKHRDelegate vkImportSemaphoreWin32HandleKHR_ptr;
		public static VkResult vkImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
			=> vkImportSemaphoreWin32HandleKHR_ptr(device, pImportSemaphoreWin32HandleInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreWin32HandleKHRDelegate(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetSemaphoreWin32HandleKHRDelegate vkGetSemaphoreWin32HandleKHR_ptr;
		public static VkResult vkGetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetSemaphoreWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportSemaphoreFdKHRDelegate(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);
		private static vkImportSemaphoreFdKHRDelegate vkImportSemaphoreFdKHR_ptr;
		public static VkResult vkImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
			=> vkImportSemaphoreFdKHR_ptr(device, pImportSemaphoreFdInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreFdKHRDelegate(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd);
		private static vkGetSemaphoreFdKHRDelegate vkGetSemaphoreFdKHR_ptr;
		public static VkResult vkGetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
			=> vkGetSemaphoreFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPushDescriptorSetKHRDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites);
		private static vkCmdPushDescriptorSetKHRDelegate vkCmdPushDescriptorSetKHR_ptr;
		public static void vkCmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
			=> vkCmdPushDescriptorSetKHR_ptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);
		private static vkCmdBeginConditionalRenderingEXTDelegate vkCmdBeginConditionalRenderingEXT_ptr;
		public static void vkCmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
			=> vkCmdBeginConditionalRenderingEXT_ptr(commandBuffer, pConditionalRenderingBegin);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndConditionalRenderingEXTDelegate vkCmdEndConditionalRenderingEXT_ptr;
		public static void vkCmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
			=> vkCmdEndConditionalRenderingEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportWScalingNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings);
		private static vkCmdSetViewportWScalingNVDelegate vkCmdSetViewportWScalingNV_ptr;
		public static void vkCmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
			=> vkCmdSetViewportWScalingNV_ptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);

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
		private delegate VkResult vkGetRandROutputDisplayEXTDelegate(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay);
		private static vkGetRandROutputDisplayEXTDelegate vkGetRandROutputDisplayEXT_ptr;
		public static VkResult vkGetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, IntPtr rrOutput, VkDisplayKHR* pDisplay)
			=> vkGetRandROutputDisplayEXT_ptr(physicalDevice, dpy, rrOutput, pDisplay);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr(physicalDevice, surface, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkDisplayPowerControlEXTDelegate(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo);
		private static vkDisplayPowerControlEXTDelegate vkDisplayPowerControlEXT_ptr;
		public static VkResult vkDisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
			=> vkDisplayPowerControlEXT_ptr(device, display, pDisplayPowerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkRegisterDeviceEventEXTDelegate(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
		private static vkRegisterDeviceEventEXTDelegate vkRegisterDeviceEventEXT_ptr;
		public static VkResult vkRegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
			=> vkRegisterDeviceEventEXT_ptr(device, pDeviceEventInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkRegisterDisplayEventEXTDelegate(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence);
		private static vkRegisterDisplayEventEXTDelegate vkRegisterDisplayEventEXT_ptr;
		public static VkResult vkRegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
			=> vkRegisterDisplayEventEXT_ptr(device, display, pDisplayEventInfo, pAllocator, pFence);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainCounterEXTDelegate(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ulong* pCounterValue);
		private static vkGetSwapchainCounterEXTDelegate vkGetSwapchainCounterEXT_ptr;
		public static VkResult vkGetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ulong* pCounterValue)
			=> vkGetSwapchainCounterEXT_ptr(device, swapchain, counter, pCounterValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetRefreshCycleDurationGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);
		private static vkGetRefreshCycleDurationGOOGLEDelegate vkGetRefreshCycleDurationGOOGLE_ptr;
		public static VkResult vkGetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
			=> vkGetRefreshCycleDurationGOOGLE_ptr(device, swapchain, pDisplayTimingProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPastPresentationTimingGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings);
		private static vkGetPastPresentationTimingGOOGLEDelegate vkGetPastPresentationTimingGOOGLE_ptr;
		public static VkResult vkGetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
			=> vkGetPastPresentationTimingGOOGLE_ptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDiscardRectangleEXTDelegate(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles);
		private static vkCmdSetDiscardRectangleEXTDelegate vkCmdSetDiscardRectangleEXT_ptr;
		public static void vkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
			=> vkCmdSetDiscardRectangleEXT_ptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDiscardRectangleEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 discardRectangleEnable);
		private static vkCmdSetDiscardRectangleEnableEXTDelegate vkCmdSetDiscardRectangleEnableEXT_ptr;
		public static void vkCmdSetDiscardRectangleEnableEXT(VkCommandBuffer commandBuffer, VkBool32 discardRectangleEnable)
			=> vkCmdSetDiscardRectangleEnableEXT_ptr(commandBuffer, discardRectangleEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDiscardRectangleModeEXTDelegate(VkCommandBuffer commandBuffer, VkDiscardRectangleModeEXT discardRectangleMode);
		private static vkCmdSetDiscardRectangleModeEXTDelegate vkCmdSetDiscardRectangleModeEXT_ptr;
		public static void vkCmdSetDiscardRectangleModeEXT(VkCommandBuffer commandBuffer, VkDiscardRectangleModeEXT discardRectangleMode)
			=> vkCmdSetDiscardRectangleModeEXT_ptr(commandBuffer, discardRectangleMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSetHdrMetadataEXTDelegate(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata);
		private static vkSetHdrMetadataEXTDelegate vkSetHdrMetadataEXT_ptr;
		public static void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
			=> vkSetHdrMetadataEXT_ptr(device, swapchainCount, pSwapchains, pMetadata);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSwapchainStatusKHRDelegate(VkDevice device, VkSwapchainKHR swapchain);
		private static vkGetSwapchainStatusKHRDelegate vkGetSwapchainStatusKHR_ptr;
		public static VkResult vkGetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
			=> vkGetSwapchainStatusKHR_ptr(device, swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportFenceWin32HandleKHRDelegate(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);
		private static vkImportFenceWin32HandleKHRDelegate vkImportFenceWin32HandleKHR_ptr;
		public static VkResult vkImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
			=> vkImportFenceWin32HandleKHR_ptr(device, pImportFenceWin32HandleInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceWin32HandleKHRDelegate(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);
		private static vkGetFenceWin32HandleKHRDelegate vkGetFenceWin32HandleKHR_ptr;
		public static VkResult vkGetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle)
			=> vkGetFenceWin32HandleKHR_ptr(device, pGetWin32HandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportFenceFdKHRDelegate(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo);
		private static vkImportFenceFdKHRDelegate vkImportFenceFdKHR_ptr;
		public static VkResult vkImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
			=> vkImportFenceFdKHR_ptr(device, pImportFenceFdInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceFdKHRDelegate(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd);
		private static vkGetFenceFdKHRDelegate vkGetFenceFdKHR_ptr;
		public static VkResult vkGetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
			=> vkGetFenceFdKHR_ptr(device, pGetFdInfo, pFd);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions);
		private static vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr;
		public static VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
			=> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses);
		private static vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr;
		public static void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
			=> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireProfilingLockKHRDelegate(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo);
		private static vkAcquireProfilingLockKHRDelegate vkAcquireProfilingLockKHR_ptr;
		public static VkResult vkAcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
			=> vkAcquireProfilingLockKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkReleaseProfilingLockKHRDelegate(VkDevice device);
		private static vkReleaseProfilingLockKHRDelegate vkReleaseProfilingLockKHR_ptr;
		public static void vkReleaseProfilingLockKHR(VkDevice device)
			=> vkReleaseProfilingLockKHR_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities);
		private static vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
			=> vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfaceFormats2KHRDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats);
		private static vkGetPhysicalDeviceSurfaceFormats2KHRDelegate vkGetPhysicalDeviceSurfaceFormats2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
			=> vkGetPhysicalDeviceSurfaceFormats2KHR_ptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayProperties2KHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties);
		private static vkGetPhysicalDeviceDisplayProperties2KHRDelegate vkGetPhysicalDeviceDisplayProperties2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
			=> vkGetPhysicalDeviceDisplayProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties);
		private static vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr;
		public static VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
			=> vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayModeProperties2KHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties);
		private static vkGetDisplayModeProperties2KHRDelegate vkGetDisplayModeProperties2KHR_ptr;
		public static VkResult vkGetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
			=> vkGetDisplayModeProperties2KHR_ptr(physicalDevice, display, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDisplayPlaneCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities);
		private static vkGetDisplayPlaneCapabilities2KHRDelegate vkGetDisplayPlaneCapabilities2KHR_ptr;
		public static VkResult vkGetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
			=> vkGetDisplayPlaneCapabilities2KHR_ptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateIOSSurfaceMVKDelegate(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateIOSSurfaceMVKDelegate vkCreateIOSSurfaceMVK_ptr;
		public static VkResult vkCreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateIOSSurfaceMVK_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateMacOSSurfaceMVKDelegate(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateMacOSSurfaceMVKDelegate vkCreateMacOSSurfaceMVK_ptr;
		public static VkResult vkCreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateMacOSSurfaceMVK_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetDebugUtilsObjectNameEXTDelegate(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo);
		private static vkSetDebugUtilsObjectNameEXTDelegate vkSetDebugUtilsObjectNameEXT_ptr;
		public static VkResult vkSetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
			=> vkSetDebugUtilsObjectNameEXT_ptr(device, pNameInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetDebugUtilsObjectTagEXTDelegate(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo);
		private static vkSetDebugUtilsObjectTagEXTDelegate vkSetDebugUtilsObjectTagEXT_ptr;
		public static VkResult vkSetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
			=> vkSetDebugUtilsObjectTagEXT_ptr(device, pTagInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkQueueBeginDebugUtilsLabelEXTDelegate(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo);
		private static vkQueueBeginDebugUtilsLabelEXTDelegate vkQueueBeginDebugUtilsLabelEXT_ptr;
		public static void vkQueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
			=> vkQueueBeginDebugUtilsLabelEXT_ptr(queue, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkQueueEndDebugUtilsLabelEXTDelegate(VkQueue queue);
		private static vkQueueEndDebugUtilsLabelEXTDelegate vkQueueEndDebugUtilsLabelEXT_ptr;
		public static void vkQueueEndDebugUtilsLabelEXT(VkQueue queue)
			=> vkQueueEndDebugUtilsLabelEXT_ptr(queue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkQueueInsertDebugUtilsLabelEXTDelegate(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo);
		private static vkQueueInsertDebugUtilsLabelEXTDelegate vkQueueInsertDebugUtilsLabelEXT_ptr;
		public static void vkQueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
			=> vkQueueInsertDebugUtilsLabelEXT_ptr(queue, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBeginDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo);
		private static vkCmdBeginDebugUtilsLabelEXTDelegate vkCmdBeginDebugUtilsLabelEXT_ptr;
		public static void vkCmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
			=> vkCmdBeginDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEndDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdEndDebugUtilsLabelEXTDelegate vkCmdEndDebugUtilsLabelEXT_ptr;
		public static void vkCmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
			=> vkCmdEndDebugUtilsLabelEXT_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdInsertDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo);
		private static vkCmdInsertDebugUtilsLabelEXTDelegate vkCmdInsertDebugUtilsLabelEXT_ptr;
		public static void vkCmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
			=> vkCmdInsertDebugUtilsLabelEXT_ptr(commandBuffer, pLabelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDebugUtilsMessengerEXTDelegate(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger);
		private static vkCreateDebugUtilsMessengerEXTDelegate vkCreateDebugUtilsMessengerEXT_ptr;
		public static VkResult vkCreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
			=> vkCreateDebugUtilsMessengerEXT_ptr(instance, pCreateInfo, pAllocator, pMessenger);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDebugUtilsMessengerEXTDelegate(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDebugUtilsMessengerEXTDelegate vkDestroyDebugUtilsMessengerEXT_ptr;
		public static void vkDestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator)
			=> vkDestroyDebugUtilsMessengerEXT_ptr(instance, messenger, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSubmitDebugUtilsMessageEXTDelegate(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);
		private static vkSubmitDebugUtilsMessageEXTDelegate vkSubmitDebugUtilsMessageEXT_ptr;
		public static void vkSubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
			=> vkSubmitDebugUtilsMessageEXT_ptr(instance, messageSeverity, messageTypes, pCallbackData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetAndroidHardwareBufferPropertiesANDROIDDelegate(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties);
		private static vkGetAndroidHardwareBufferPropertiesANDROIDDelegate vkGetAndroidHardwareBufferPropertiesANDROID_ptr;
		public static VkResult vkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
			=> vkGetAndroidHardwareBufferPropertiesANDROID_ptr(device, buffer, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryAndroidHardwareBufferANDROIDDelegate(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr pBuffer);
		private static vkGetMemoryAndroidHardwareBufferANDROIDDelegate vkGetMemoryAndroidHardwareBufferANDROID_ptr;
		public static VkResult vkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr pBuffer)
			=> vkGetMemoryAndroidHardwareBufferANDROID_ptr(device, pInfo, pBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetSampleLocationsEXTDelegate(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo);
		private static vkCmdSetSampleLocationsEXTDelegate vkCmdSetSampleLocationsEXT_ptr;
		public static void vkCmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
			=> vkCmdSetSampleLocationsEXT_ptr(commandBuffer, pSampleLocationsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties);
		private static vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr;
		public static void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
			=> vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr(physicalDevice, samples, pMultisampleProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateAccelerationStructureKHRDelegate(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure);
		private static vkCreateAccelerationStructureKHRDelegate vkCreateAccelerationStructureKHR_ptr;
		public static VkResult vkCreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
			=> vkCreateAccelerationStructureKHR_ptr(device, pCreateInfo, pAllocator, pAccelerationStructure);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyAccelerationStructureKHRDelegate(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator);
		private static vkDestroyAccelerationStructureKHRDelegate vkDestroyAccelerationStructureKHR_ptr;
		public static void vkDestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator)
			=> vkDestroyAccelerationStructureKHR_ptr(device, accelerationStructure, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildAccelerationStructuresKHRDelegate(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
		private static vkCmdBuildAccelerationStructuresKHRDelegate vkCmdBuildAccelerationStructuresKHR_ptr;
		public static void vkCmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
			=> vkCmdBuildAccelerationStructuresKHR_ptr(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildAccelerationStructuresIndirectKHRDelegate(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts);
		private static vkCmdBuildAccelerationStructuresIndirectKHRDelegate vkCmdBuildAccelerationStructuresIndirectKHR_ptr;
		public static void vkCmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
			=> vkCmdBuildAccelerationStructuresIndirectKHR_ptr(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBuildAccelerationStructuresKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
		private static vkBuildAccelerationStructuresKHRDelegate vkBuildAccelerationStructuresKHR_ptr;
		public static VkResult vkBuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
			=> vkBuildAccelerationStructuresKHR_ptr(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyAccelerationStructureKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo);
		private static vkCopyAccelerationStructureKHRDelegate vkCopyAccelerationStructureKHR_ptr;
		public static VkResult vkCopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
			=> vkCopyAccelerationStructureKHR_ptr(device, deferredOperation, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyAccelerationStructureToMemoryKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);
		private static vkCopyAccelerationStructureToMemoryKHRDelegate vkCopyAccelerationStructureToMemoryKHR_ptr;
		public static VkResult vkCopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
			=> vkCopyAccelerationStructureToMemoryKHR_ptr(device, deferredOperation, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyMemoryToAccelerationStructureKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);
		private static vkCopyMemoryToAccelerationStructureKHRDelegate vkCopyMemoryToAccelerationStructureKHR_ptr;
		public static VkResult vkCopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
			=> vkCopyMemoryToAccelerationStructureKHR_ptr(device, deferredOperation, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWriteAccelerationStructuresPropertiesKHRDelegate(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride);
		private static vkWriteAccelerationStructuresPropertiesKHRDelegate vkWriteAccelerationStructuresPropertiesKHR_ptr;
		public static VkResult vkWriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
			=> vkWriteAccelerationStructuresPropertiesKHR_ptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo);
		private static vkCmdCopyAccelerationStructureKHRDelegate vkCmdCopyAccelerationStructureKHR_ptr;
		public static void vkCmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
			=> vkCmdCopyAccelerationStructureKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyAccelerationStructureToMemoryKHRDelegate(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);
		private static vkCmdCopyAccelerationStructureToMemoryKHRDelegate vkCmdCopyAccelerationStructureToMemoryKHR_ptr;
		public static void vkCmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
			=> vkCmdCopyAccelerationStructureToMemoryKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyMemoryToAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);
		private static vkCmdCopyMemoryToAccelerationStructureKHRDelegate vkCmdCopyMemoryToAccelerationStructureKHR_ptr;
		public static void vkCmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
			=> vkCmdCopyMemoryToAccelerationStructureKHR_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetAccelerationStructureDeviceAddressKHRDelegate(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo);
		private static vkGetAccelerationStructureDeviceAddressKHRDelegate vkGetAccelerationStructureDeviceAddressKHR_ptr;
		public static ulong vkGetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
			=> vkGetAccelerationStructureDeviceAddressKHR_ptr(device, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteAccelerationStructuresPropertiesKHRDelegate(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
		private static vkCmdWriteAccelerationStructuresPropertiesKHRDelegate vkCmdWriteAccelerationStructuresPropertiesKHR_ptr;
		public static void vkCmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
			=> vkCmdWriteAccelerationStructuresPropertiesKHR_ptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceAccelerationStructureCompatibilityKHRDelegate(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility);
		private static vkGetDeviceAccelerationStructureCompatibilityKHRDelegate vkGetDeviceAccelerationStructureCompatibilityKHR_ptr;
		public static void vkGetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
			=> vkGetDeviceAccelerationStructureCompatibilityKHR_ptr(device, pVersionInfo, pCompatibility);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetAccelerationStructureBuildSizesKHRDelegate(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo);
		private static vkGetAccelerationStructureBuildSizesKHRDelegate vkGetAccelerationStructureBuildSizesKHR_ptr;
		public static void vkGetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
			=> vkGetAccelerationStructureBuildSizesKHR_ptr(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdTraceRaysKHRDelegate(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth);
		private static vkCmdTraceRaysKHRDelegate vkCmdTraceRaysKHR_ptr;
		public static void vkCmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
			=> vkCmdTraceRaysKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRayTracingPipelinesKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
		private static vkCreateRayTracingPipelinesKHRDelegate vkCreateRayTracingPipelinesKHR_ptr;
		public static VkResult vkCreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
			=> vkCreateRayTracingPipelinesKHR_ptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

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
		private delegate void vkCmdTraceRaysIndirectKHRDelegate(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress);
		private static vkCmdTraceRaysIndirectKHRDelegate vkCmdTraceRaysIndirectKHR_ptr;
		public static void vkCmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
			=> vkCmdTraceRaysIndirectKHR_ptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate ulong vkGetRayTracingShaderGroupStackSizeKHRDelegate(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader);
		private static vkGetRayTracingShaderGroupStackSizeKHRDelegate vkGetRayTracingShaderGroupStackSizeKHR_ptr;
		public static ulong vkGetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
			=> vkGetRayTracingShaderGroupStackSizeKHR_ptr(device, pipeline, group, groupShader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetRayTracingPipelineStackSizeKHRDelegate(VkCommandBuffer commandBuffer, uint pipelineStackSize);
		private static vkCmdSetRayTracingPipelineStackSizeKHRDelegate vkCmdSetRayTracingPipelineStackSizeKHR_ptr;
		public static void vkCmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize)
			=> vkCmdSetRayTracingPipelineStackSizeKHR_ptr(commandBuffer, pipelineStackSize);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetImageDrmFormatModifierPropertiesEXTDelegate(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties);
		private static vkGetImageDrmFormatModifierPropertiesEXTDelegate vkGetImageDrmFormatModifierPropertiesEXT_ptr;
		public static VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
			=> vkGetImageDrmFormatModifierPropertiesEXT_ptr(device, image, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateValidationCacheEXTDelegate(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache);
		private static vkCreateValidationCacheEXTDelegate vkCreateValidationCacheEXT_ptr;
		public static VkResult vkCreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
			=> vkCreateValidationCacheEXT_ptr(device, pCreateInfo, pAllocator, pValidationCache);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyValidationCacheEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator);
		private static vkDestroyValidationCacheEXTDelegate vkDestroyValidationCacheEXT_ptr;
		public static void vkDestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator)
			=> vkDestroyValidationCacheEXT_ptr(device, validationCache, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkMergeValidationCachesEXTDelegate(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches);
		private static vkMergeValidationCachesEXTDelegate vkMergeValidationCachesEXT_ptr;
		public static VkResult vkMergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
			=> vkMergeValidationCachesEXT_ptr(device, dstCache, srcCacheCount, pSrcCaches);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetValidationCacheDataEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData);
		private static vkGetValidationCacheDataEXTDelegate vkGetValidationCacheDataEXT_ptr;
		public static VkResult vkGetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, UIntPtr* pDataSize, void* pData)
			=> vkGetValidationCacheDataEXT_ptr(device, validationCache, pDataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindShadingRateImageNVDelegate(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
		private static vkCmdBindShadingRateImageNVDelegate vkCmdBindShadingRateImageNV_ptr;
		public static void vkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
			=> vkCmdBindShadingRateImageNV_ptr(commandBuffer, imageView, imageLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportShadingRatePaletteNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes);
		private static vkCmdSetViewportShadingRatePaletteNVDelegate vkCmdSetViewportShadingRatePaletteNV_ptr;
		public static void vkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
			=> vkCmdSetViewportShadingRatePaletteNV_ptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCoarseSampleOrderNVDelegate(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders);
		private static vkCmdSetCoarseSampleOrderNVDelegate vkCmdSetCoarseSampleOrderNV_ptr;
		public static void vkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
			=> vkCmdSetCoarseSampleOrderNV_ptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateAccelerationStructureNVDelegate(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure);
		private static vkCreateAccelerationStructureNVDelegate vkCreateAccelerationStructureNV_ptr;
		public static VkResult vkCreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
			=> vkCreateAccelerationStructureNV_ptr(device, pCreateInfo, pAllocator, pAccelerationStructure);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyAccelerationStructureNVDelegate(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator);
		private static vkDestroyAccelerationStructureNVDelegate vkDestroyAccelerationStructureNV_ptr;
		public static void vkDestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
			=> vkDestroyAccelerationStructureNV_ptr(device, accelerationStructure, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetAccelerationStructureMemoryRequirementsNVDelegate(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetAccelerationStructureMemoryRequirementsNVDelegate vkGetAccelerationStructureMemoryRequirementsNV_ptr;
		public static void vkGetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetAccelerationStructureMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindAccelerationStructureMemoryNVDelegate(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos);
		private static vkBindAccelerationStructureMemoryNVDelegate vkBindAccelerationStructureMemoryNV_ptr;
		public static VkResult vkBindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
			=> vkBindAccelerationStructureMemoryNV_ptr(device, bindInfoCount, pBindInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset);
		private static vkCmdBuildAccelerationStructureNVDelegate vkCmdBuildAccelerationStructureNV_ptr;
		public static void vkCmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
			=> vkCmdBuildAccelerationStructureNV_ptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode);
		private static vkCmdCopyAccelerationStructureNVDelegate vkCmdCopyAccelerationStructureNV_ptr;
		public static void vkCmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
			=> vkCmdCopyAccelerationStructureNV_ptr(commandBuffer, dst, src, mode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdTraceRaysNVDelegate(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth);
		private static vkCmdTraceRaysNVDelegate vkCmdTraceRaysNV_ptr;
		public static void vkCmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
			=> vkCmdTraceRaysNV_ptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateRayTracingPipelinesNVDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
		private static vkCreateRayTracingPipelinesNVDelegate vkCreateRayTracingPipelinesNV_ptr;
		public static VkResult vkCreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
			=> vkCreateRayTracingPipelinesNV_ptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetAccelerationStructureHandleNVDelegate(VkDevice device, VkAccelerationStructureNV accelerationStructure, UIntPtr dataSize, void* pData);
		private static vkGetAccelerationStructureHandleNVDelegate vkGetAccelerationStructureHandleNV_ptr;
		public static VkResult vkGetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, UIntPtr dataSize, void* pData)
			=> vkGetAccelerationStructureHandleNV_ptr(device, accelerationStructure, dataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteAccelerationStructuresPropertiesNVDelegate(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
		private static vkCmdWriteAccelerationStructuresPropertiesNVDelegate vkCmdWriteAccelerationStructuresPropertiesNV_ptr;
		public static void vkCmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
			=> vkCmdWriteAccelerationStructuresPropertiesNV_ptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCompileDeferredNVDelegate(VkDevice device, VkPipeline pipeline, uint shader);
		private static vkCompileDeferredNVDelegate vkCompileDeferredNV_ptr;
		public static VkResult vkCompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
			=> vkCompileDeferredNV_ptr(device, pipeline, shader);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryHostPointerPropertiesEXTDelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);
		private static vkGetMemoryHostPointerPropertiesEXTDelegate vkGetMemoryHostPointerPropertiesEXT_ptr;
		public static VkResult vkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
			=> vkGetMemoryHostPointerPropertiesEXT_ptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteBufferMarkerAMDDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker);
		private static vkCmdWriteBufferMarkerAMDDelegate vkCmdWriteBufferMarkerAMD_ptr;
		public static void vkCmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
			=> vkCmdWriteBufferMarkerAMD_ptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains);
		private static vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr;
		public static VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains)
			=> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr(physicalDevice, pTimeDomainCount, pTimeDomains);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetCalibratedTimestampsEXTDelegate(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation);
		private static vkGetCalibratedTimestampsEXTDelegate vkGetCalibratedTimestampsEXT_ptr;
		public static VkResult vkGetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoEXT* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
			=> vkGetCalibratedTimestampsEXT_ptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);

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
		private delegate void vkCmdSetExclusiveScissorEnableNVDelegate(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkBool32* pExclusiveScissorEnables);
		private static vkCmdSetExclusiveScissorEnableNVDelegate vkCmdSetExclusiveScissorEnableNV_ptr;
		public static void vkCmdSetExclusiveScissorEnableNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkBool32* pExclusiveScissorEnables)
			=> vkCmdSetExclusiveScissorEnableNV_ptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissorEnables);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetExclusiveScissorNVDelegate(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors);
		private static vkCmdSetExclusiveScissorNVDelegate vkCmdSetExclusiveScissorNV_ptr;
		public static void vkCmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
			=> vkCmdSetExclusiveScissorNV_ptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCheckpointNVDelegate(VkCommandBuffer commandBuffer, void* pCheckpointMarker);
		private static vkCmdSetCheckpointNVDelegate vkCmdSetCheckpointNV_ptr;
		public static void vkCmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
			=> vkCmdSetCheckpointNV_ptr(commandBuffer, pCheckpointMarker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetQueueCheckpointDataNVDelegate(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData);
		private static vkGetQueueCheckpointDataNVDelegate vkGetQueueCheckpointDataNV_ptr;
		public static void vkGetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
			=> vkGetQueueCheckpointDataNV_ptr(queue, pCheckpointDataCount, pCheckpointData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkInitializePerformanceApiINTELDelegate(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo);
		private static vkInitializePerformanceApiINTELDelegate vkInitializePerformanceApiINTEL_ptr;
		public static VkResult vkInitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
			=> vkInitializePerformanceApiINTEL_ptr(device, pInitializeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkUninitializePerformanceApiINTELDelegate(VkDevice device);
		private static vkUninitializePerformanceApiINTELDelegate vkUninitializePerformanceApiINTEL_ptr;
		public static void vkUninitializePerformanceApiINTEL(VkDevice device)
			=> vkUninitializePerformanceApiINTEL_ptr(device);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCmdSetPerformanceMarkerINTELDelegate(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo);
		private static vkCmdSetPerformanceMarkerINTELDelegate vkCmdSetPerformanceMarkerINTEL_ptr;
		public static VkResult vkCmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
			=> vkCmdSetPerformanceMarkerINTEL_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCmdSetPerformanceStreamMarkerINTELDelegate(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);
		private static vkCmdSetPerformanceStreamMarkerINTELDelegate vkCmdSetPerformanceStreamMarkerINTEL_ptr;
		public static VkResult vkCmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
			=> vkCmdSetPerformanceStreamMarkerINTEL_ptr(commandBuffer, pMarkerInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCmdSetPerformanceOverrideINTELDelegate(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo);
		private static vkCmdSetPerformanceOverrideINTELDelegate vkCmdSetPerformanceOverrideINTEL_ptr;
		public static VkResult vkCmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
			=> vkCmdSetPerformanceOverrideINTEL_ptr(commandBuffer, pOverrideInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquirePerformanceConfigurationINTELDelegate(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration);
		private static vkAcquirePerformanceConfigurationINTELDelegate vkAcquirePerformanceConfigurationINTEL_ptr;
		public static VkResult vkAcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
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
		private delegate VkResult vkGetPerformanceParameterINTELDelegate(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue);
		private static vkGetPerformanceParameterINTELDelegate vkGetPerformanceParameterINTEL_ptr;
		public static VkResult vkGetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
			=> vkGetPerformanceParameterINTEL_ptr(device, parameter, pValue);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSetLocalDimmingAMDDelegate(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable);
		private static vkSetLocalDimmingAMDDelegate vkSetLocalDimmingAMD_ptr;
		public static void vkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable)
			=> vkSetLocalDimmingAMD_ptr(device, swapChain, localDimmingEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateImagePipeSurfaceFUCHSIADelegate(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateImagePipeSurfaceFUCHSIADelegate vkCreateImagePipeSurfaceFUCHSIA_ptr;
		public static VkResult vkCreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateImagePipeSurfaceFUCHSIA_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateMetalSurfaceEXTDelegate(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateMetalSurfaceEXTDelegate vkCreateMetalSurfaceEXT_ptr;
		public static VkResult vkCreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateMetalSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceFragmentShadingRatesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates);
		private static vkGetPhysicalDeviceFragmentShadingRatesKHRDelegate vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
			=> vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetFragmentShadingRateKHRDelegate(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps);
		private static vkCmdSetFragmentShadingRateKHRDelegate vkCmdSetFragmentShadingRateKHR_ptr;
		public static void vkCmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR combinerOps)
			=> vkCmdSetFragmentShadingRateKHR_ptr(commandBuffer, pFragmentSize, combinerOps);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWaitForPresentKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout);
		private static vkWaitForPresentKHRDelegate vkWaitForPresentKHR_ptr;
		public static VkResult vkWaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
			=> vkWaitForPresentKHR_ptr(device, swapchain, presentId, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties);
		private static vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr;
		public static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
			=> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations);
		private static vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr;
		public static VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
			=> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr(physicalDevice, pCombinationCount, pCombinations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes);
		private static vkGetPhysicalDeviceSurfacePresentModes2EXTDelegate vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr;
		public static VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
			=> vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);

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
		private delegate VkResult vkCreateHeadlessSurfaceEXTDelegate(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateHeadlessSurfaceEXTDelegate vkCreateHeadlessSurfaceEXT_ptr;
		public static VkResult vkCreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateHeadlessSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLineStippleEXTDelegate(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
		private static vkCmdSetLineStippleEXTDelegate vkCmdSetLineStippleEXT_ptr;
		public static void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
			=> vkCmdSetLineStippleEXT_ptr(commandBuffer, lineStippleFactor, lineStipplePattern);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDeferredOperationKHRDelegate(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation);
		private static vkCreateDeferredOperationKHRDelegate vkCreateDeferredOperationKHR_ptr;
		public static VkResult vkCreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation)
			=> vkCreateDeferredOperationKHR_ptr(device, pAllocator, pDeferredOperation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyDeferredOperationKHRDelegate(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator);
		private static vkDestroyDeferredOperationKHRDelegate vkDestroyDeferredOperationKHR_ptr;
		public static void vkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator)
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

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineExecutablePropertiesKHRDelegate(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties);
		private static vkGetPipelineExecutablePropertiesKHRDelegate vkGetPipelineExecutablePropertiesKHR_ptr;
		public static VkResult vkGetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
			=> vkGetPipelineExecutablePropertiesKHR_ptr(device, pPipelineInfo, pExecutableCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineExecutableStatisticsKHRDelegate(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics);
		private static vkGetPipelineExecutableStatisticsKHRDelegate vkGetPipelineExecutableStatisticsKHR_ptr;
		public static VkResult vkGetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
			=> vkGetPipelineExecutableStatisticsKHR_ptr(device, pExecutableInfo, pStatisticCount, pStatistics);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelineExecutableInternalRepresentationsKHRDelegate(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);
		private static vkGetPipelineExecutableInternalRepresentationsKHRDelegate vkGetPipelineExecutableInternalRepresentationsKHR_ptr;
		public static VkResult vkGetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
			=> vkGetPipelineExecutableInternalRepresentationsKHR_ptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkMapMemory2KHRDelegate(VkDevice device, VkMemoryMapInfoKHR* pMemoryMapInfo, void** ppData);
		private static vkMapMemory2KHRDelegate vkMapMemory2KHR_ptr;
		public static VkResult vkMapMemory2KHR(VkDevice device, VkMemoryMapInfoKHR* pMemoryMapInfo, void** ppData)
			=> vkMapMemory2KHR_ptr(device, pMemoryMapInfo, ppData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkUnmapMemory2KHRDelegate(VkDevice device, VkMemoryUnmapInfoKHR* pMemoryUnmapInfo);
		private static vkUnmapMemory2KHRDelegate vkUnmapMemory2KHR_ptr;
		public static VkResult vkUnmapMemory2KHR(VkDevice device, VkMemoryUnmapInfoKHR* pMemoryUnmapInfo)
			=> vkUnmapMemory2KHR_ptr(device, pMemoryUnmapInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkReleaseSwapchainImagesEXTDelegate(VkDevice device, VkReleaseSwapchainImagesInfoEXT* pReleaseInfo);
		private static vkReleaseSwapchainImagesEXTDelegate vkReleaseSwapchainImagesEXT_ptr;
		public static VkResult vkReleaseSwapchainImagesEXT(VkDevice device, VkReleaseSwapchainImagesInfoEXT* pReleaseInfo)
			=> vkReleaseSwapchainImagesEXT_ptr(device, pReleaseInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetGeneratedCommandsMemoryRequirementsNVDelegate(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements);
		private static vkGetGeneratedCommandsMemoryRequirementsNVDelegate vkGetGeneratedCommandsMemoryRequirementsNV_ptr;
		public static void vkGetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
			=> vkGetGeneratedCommandsMemoryRequirementsNV_ptr(device, pInfo, pMemoryRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdPreprocessGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);
		private static vkCmdPreprocessGeneratedCommandsNVDelegate vkCmdPreprocessGeneratedCommandsNV_ptr;
		public static void vkCmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
			=> vkCmdPreprocessGeneratedCommandsNV_ptr(commandBuffer, pGeneratedCommandsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdExecuteGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);
		private static vkCmdExecuteGeneratedCommandsNVDelegate vkCmdExecuteGeneratedCommandsNV_ptr;
		public static void vkCmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
			=> vkCmdExecuteGeneratedCommandsNV_ptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindPipelineShaderGroupNVDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex);
		private static vkCmdBindPipelineShaderGroupNVDelegate vkCmdBindPipelineShaderGroupNV_ptr;
		public static void vkCmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
			=> vkCmdBindPipelineShaderGroupNV_ptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateIndirectCommandsLayoutNVDelegate(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout);
		private static vkCreateIndirectCommandsLayoutNVDelegate vkCreateIndirectCommandsLayoutNV_ptr;
		public static VkResult vkCreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
			=> vkCreateIndirectCommandsLayoutNV_ptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyIndirectCommandsLayoutNVDelegate(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator);
		private static vkDestroyIndirectCommandsLayoutNVDelegate vkDestroyIndirectCommandsLayoutNV_ptr;
		public static void vkDestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
			=> vkDestroyIndirectCommandsLayoutNV_ptr(device, indirectCommandsLayout, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthBias2EXTDelegate(VkCommandBuffer commandBuffer, VkDepthBiasInfoEXT* pDepthBiasInfo);
		private static vkCmdSetDepthBias2EXTDelegate vkCmdSetDepthBias2EXT_ptr;
		public static void vkCmdSetDepthBias2EXT(VkCommandBuffer commandBuffer, VkDepthBiasInfoEXT* pDepthBiasInfo)
			=> vkCmdSetDepthBias2EXT_ptr(commandBuffer, pDepthBiasInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireDrmDisplayEXTDelegate(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display);
		private static vkAcquireDrmDisplayEXTDelegate vkAcquireDrmDisplayEXT_ptr;
		public static VkResult vkAcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display)
			=> vkAcquireDrmDisplayEXT_ptr(physicalDevice, drmFd, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDrmDisplayEXTDelegate(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, VkDisplayKHR* display);
		private static vkGetDrmDisplayEXTDelegate vkGetDrmDisplayEXT_ptr;
		public static VkResult vkGetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, VkDisplayKHR* display)
			=> vkGetDrmDisplayEXT_ptr(physicalDevice, drmFd, connectorId, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, VkVideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties);
		private static vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHRDelegate vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, VkVideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties)
			=> vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_ptr(physicalDevice, pQualityLevelInfo, pQualityLevelProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetEncodedVideoSessionParametersKHRDelegate(VkDevice device, VkVideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, VkVideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, UIntPtr* pDataSize, void* pData);
		private static vkGetEncodedVideoSessionParametersKHRDelegate vkGetEncodedVideoSessionParametersKHR_ptr;
		public static VkResult vkGetEncodedVideoSessionParametersKHR(VkDevice device, VkVideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, VkVideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, UIntPtr* pDataSize, void* pData)
			=> vkGetEncodedVideoSessionParametersKHR_ptr(device, pVideoSessionParametersInfo, pFeedbackInfo, pDataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdEncodeVideoKHRDelegate(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo);
		private static vkCmdEncodeVideoKHRDelegate vkCmdEncodeVideoKHR_ptr;
		public static void vkCmdEncodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo)
			=> vkCmdEncodeVideoKHR_ptr(commandBuffer, pEncodeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdRefreshObjectsKHRDelegate(VkCommandBuffer commandBuffer, VkRefreshObjectListKHR* pRefreshObjects);
		private static vkCmdRefreshObjectsKHRDelegate vkCmdRefreshObjectsKHR_ptr;
		public static void vkCmdRefreshObjectsKHR(VkCommandBuffer commandBuffer, VkRefreshObjectListKHR* pRefreshObjects)
			=> vkCmdRefreshObjectsKHR_ptr(commandBuffer, pRefreshObjects);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceRefreshableObjectTypesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pRefreshableObjectTypeCount, VkObjectType* pRefreshableObjectTypes);
		private static vkGetPhysicalDeviceRefreshableObjectTypesKHRDelegate vkGetPhysicalDeviceRefreshableObjectTypesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceRefreshableObjectTypesKHR(VkPhysicalDevice physicalDevice, uint* pRefreshableObjectTypeCount, VkObjectType* pRefreshableObjectTypes)
			=> vkGetPhysicalDeviceRefreshableObjectTypesKHR_ptr(physicalDevice, pRefreshableObjectTypeCount, pRefreshableObjectTypes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkExportMetalObjectsEXTDelegate(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo);
		private static vkExportMetalObjectsEXTDelegate vkExportMetalObjectsEXT_ptr;
		public static void vkExportMetalObjectsEXT(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
			=> vkExportMetalObjectsEXT_ptr(device, pMetalObjectsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDescriptorSetLayoutSizeEXTDelegate(VkDevice device, VkDescriptorSetLayout layout, ulong* pLayoutSizeInBytes);
		private static vkGetDescriptorSetLayoutSizeEXTDelegate vkGetDescriptorSetLayoutSizeEXT_ptr;
		public static void vkGetDescriptorSetLayoutSizeEXT(VkDevice device, VkDescriptorSetLayout layout, ulong* pLayoutSizeInBytes)
			=> vkGetDescriptorSetLayoutSizeEXT_ptr(device, layout, pLayoutSizeInBytes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDescriptorSetLayoutBindingOffsetEXTDelegate(VkDevice device, VkDescriptorSetLayout layout, uint binding, ulong* pOffset);
		private static vkGetDescriptorSetLayoutBindingOffsetEXTDelegate vkGetDescriptorSetLayoutBindingOffsetEXT_ptr;
		public static void vkGetDescriptorSetLayoutBindingOffsetEXT(VkDevice device, VkDescriptorSetLayout layout, uint binding, ulong* pOffset)
			=> vkGetDescriptorSetLayoutBindingOffsetEXT_ptr(device, layout, binding, pOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDescriptorEXTDelegate(VkDevice device, VkDescriptorGetInfoEXT* pDescriptorInfo, UIntPtr dataSize, void* pDescriptor);
		private static vkGetDescriptorEXTDelegate vkGetDescriptorEXT_ptr;
		public static void vkGetDescriptorEXT(VkDevice device, VkDescriptorGetInfoEXT* pDescriptorInfo, UIntPtr dataSize, void* pDescriptor)
			=> vkGetDescriptorEXT_ptr(device, pDescriptorInfo, dataSize, pDescriptor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindDescriptorBuffersEXTDelegate(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos);
		private static vkCmdBindDescriptorBuffersEXTDelegate vkCmdBindDescriptorBuffersEXT_ptr;
		public static void vkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos)
			=> vkCmdBindDescriptorBuffersEXT_ptr(commandBuffer, bufferCount, pBindingInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDescriptorBufferOffsetsEXTDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets);
		private static vkCmdSetDescriptorBufferOffsetsEXTDelegate vkCmdSetDescriptorBufferOffsetsEXT_ptr;
		public static void vkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets)
			=> vkCmdSetDescriptorBufferOffsetsEXT_ptr(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, pOffsets);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindDescriptorBufferEmbeddedSamplersEXTDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set);
		private static vkCmdBindDescriptorBufferEmbeddedSamplersEXTDelegate vkCmdBindDescriptorBufferEmbeddedSamplersEXT_ptr;
		public static void vkCmdBindDescriptorBufferEmbeddedSamplersEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set)
			=> vkCmdBindDescriptorBufferEmbeddedSamplersEXT_ptr(commandBuffer, pipelineBindPoint, layout, set);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetBufferOpaqueCaptureDescriptorDataEXTDelegate(VkDevice device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData);
		private static vkGetBufferOpaqueCaptureDescriptorDataEXTDelegate vkGetBufferOpaqueCaptureDescriptorDataEXT_ptr;
		public static VkResult vkGetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
			=> vkGetBufferOpaqueCaptureDescriptorDataEXT_ptr(device, pInfo, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetImageOpaqueCaptureDescriptorDataEXTDelegate(VkDevice device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData);
		private static vkGetImageOpaqueCaptureDescriptorDataEXTDelegate vkGetImageOpaqueCaptureDescriptorDataEXT_ptr;
		public static VkResult vkGetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData)
			=> vkGetImageOpaqueCaptureDescriptorDataEXT_ptr(device, pInfo, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetImageViewOpaqueCaptureDescriptorDataEXTDelegate(VkDevice device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData);
		private static vkGetImageViewOpaqueCaptureDescriptorDataEXTDelegate vkGetImageViewOpaqueCaptureDescriptorDataEXT_ptr;
		public static VkResult vkGetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData)
			=> vkGetImageViewOpaqueCaptureDescriptorDataEXT_ptr(device, pInfo, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSamplerOpaqueCaptureDescriptorDataEXTDelegate(VkDevice device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData);
		private static vkGetSamplerOpaqueCaptureDescriptorDataEXTDelegate vkGetSamplerOpaqueCaptureDescriptorDataEXT_ptr;
		public static VkResult vkGetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData)
			=> vkGetSamplerOpaqueCaptureDescriptorDataEXT_ptr(device, pInfo, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetFragmentShadingRateEnumNVDelegate(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps);
		private static vkCmdSetFragmentShadingRateEnumNVDelegate vkCmdSetFragmentShadingRateEnumNV_ptr;
		public static void vkCmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR combinerOps)
			=> vkCmdSetFragmentShadingRateEnumNV_ptr(commandBuffer, shadingRate, combinerOps);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMeshTasksEXTDelegate(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
		private static vkCmdDrawMeshTasksEXTDelegate vkCmdDrawMeshTasksEXT_ptr;
		public static void vkCmdDrawMeshTasksEXT(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
			=> vkCmdDrawMeshTasksEXT_ptr(commandBuffer, groupCountX, groupCountY, groupCountZ);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMeshTasksIndirectEXTDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
		private static vkCmdDrawMeshTasksIndirectEXTDelegate vkCmdDrawMeshTasksIndirectEXT_ptr;
		public static void vkCmdDrawMeshTasksIndirectEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
			=> vkCmdDrawMeshTasksIndirectEXT_ptr(commandBuffer, buffer, offset, drawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMeshTasksIndirectCountEXTDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
		private static vkCmdDrawMeshTasksIndirectCountEXTDelegate vkCmdDrawMeshTasksIndirectCountEXT_ptr;
		public static void vkCmdDrawMeshTasksIndirectCountEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
			=> vkCmdDrawMeshTasksIndirectCountEXT_ptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetImageSubresourceLayout2EXTDelegate(VkDevice device, VkImage image, VkImageSubresource2EXT* pSubresource, VkSubresourceLayout2EXT* pLayout);
		private static vkGetImageSubresourceLayout2EXTDelegate vkGetImageSubresourceLayout2EXT_ptr;
		public static void vkGetImageSubresourceLayout2EXT(VkDevice device, VkImage image, VkImageSubresource2EXT* pSubresource, VkSubresourceLayout2EXT* pLayout)
			=> vkGetImageSubresourceLayout2EXT_ptr(device, image, pSubresource, pLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDeviceFaultInfoEXTDelegate(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo);
		private static vkGetDeviceFaultInfoEXTDelegate vkGetDeviceFaultInfoEXT_ptr;
		public static VkResult vkGetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
			=> vkGetDeviceFaultInfoEXT_ptr(device, pFaultCounts, pFaultInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkAcquireWinrtDisplayNVDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
		private static vkAcquireWinrtDisplayNVDelegate vkAcquireWinrtDisplayNV_ptr;
		public static VkResult vkAcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
			=> vkAcquireWinrtDisplayNV_ptr(physicalDevice, display);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetWinrtDisplayNVDelegate(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay);
		private static vkGetWinrtDisplayNVDelegate vkGetWinrtDisplayNV_ptr;
		public static VkResult vkGetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
			=> vkGetWinrtDisplayNV_ptr(physicalDevice, deviceRelativeId, pDisplay);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateDirectFBSurfaceEXTDelegate(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateDirectFBSurfaceEXTDelegate vkCreateDirectFBSurfaceEXT_ptr;
		public static VkResult vkCreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateDirectFBSurfaceEXT_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceDirectFBPresentationSupportEXTDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dfb);
		private static vkGetPhysicalDeviceDirectFBPresentationSupportEXTDelegate vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr;
		public static VkBool32 vkGetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dfb)
			=> vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr(physicalDevice, queueFamilyIndex, dfb);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetVertexInputEXTDelegate(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions);
		private static vkCmdSetVertexInputEXTDelegate vkCmdSetVertexInputEXT_ptr;
		public static void vkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
			=> vkCmdSetVertexInputEXT_ptr(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryZirconHandleFUCHSIADelegate(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr pZirconHandle);
		private static vkGetMemoryZirconHandleFUCHSIADelegate vkGetMemoryZirconHandleFUCHSIA_ptr;
		public static VkResult vkGetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr pZirconHandle)
			=> vkGetMemoryZirconHandleFUCHSIA_ptr(device, pGetZirconHandleInfo, pZirconHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryZirconHandlePropertiesFUCHSIADelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties);
		private static vkGetMemoryZirconHandlePropertiesFUCHSIADelegate vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr;
		public static VkResult vkGetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, IntPtr zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
			=> vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr(device, handleType, zirconHandle, pMemoryZirconHandleProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportSemaphoreZirconHandleFUCHSIADelegate(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo);
		private static vkImportSemaphoreZirconHandleFUCHSIADelegate vkImportSemaphoreZirconHandleFUCHSIA_ptr;
		public static VkResult vkImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
			=> vkImportSemaphoreZirconHandleFUCHSIA_ptr(device, pImportSemaphoreZirconHandleInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreZirconHandleFUCHSIADelegate(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr pZirconHandle);
		private static vkGetSemaphoreZirconHandleFUCHSIADelegate vkGetSemaphoreZirconHandleFUCHSIA_ptr;
		public static VkResult vkGetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, IntPtr pZirconHandle)
			=> vkGetSemaphoreZirconHandleFUCHSIA_ptr(device, pGetZirconHandleInfo, pZirconHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateBufferCollectionFUCHSIADelegate(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection);
		private static vkCreateBufferCollectionFUCHSIADelegate vkCreateBufferCollectionFUCHSIA_ptr;
		public static VkResult vkCreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
			=> vkCreateBufferCollectionFUCHSIA_ptr(device, pCreateInfo, pAllocator, pCollection);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetBufferCollectionImageConstraintsFUCHSIADelegate(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo);
		private static vkSetBufferCollectionImageConstraintsFUCHSIADelegate vkSetBufferCollectionImageConstraintsFUCHSIA_ptr;
		public static VkResult vkSetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
			=> vkSetBufferCollectionImageConstraintsFUCHSIA_ptr(device, collection, pImageConstraintsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkSetBufferCollectionBufferConstraintsFUCHSIADelegate(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo);
		private static vkSetBufferCollectionBufferConstraintsFUCHSIADelegate vkSetBufferCollectionBufferConstraintsFUCHSIA_ptr;
		public static VkResult vkSetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
			=> vkSetBufferCollectionBufferConstraintsFUCHSIA_ptr(device, collection, pBufferConstraintsInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyBufferCollectionFUCHSIADelegate(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator);
		private static vkDestroyBufferCollectionFUCHSIADelegate vkDestroyBufferCollectionFUCHSIA_ptr;
		public static void vkDestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator)
			=> vkDestroyBufferCollectionFUCHSIA_ptr(device, collection, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetBufferCollectionPropertiesFUCHSIADelegate(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties);
		private static vkGetBufferCollectionPropertiesFUCHSIADelegate vkGetBufferCollectionPropertiesFUCHSIA_ptr;
		public static VkResult vkGetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
			=> vkGetBufferCollectionPropertiesFUCHSIA_ptr(device, collection, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize);
		private static vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_ptr;
		public static VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize)
			=> vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_ptr(device, renderpass, pMaxWorkgroupSize);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSubpassShadingHUAWEIDelegate(VkCommandBuffer commandBuffer);
		private static vkCmdSubpassShadingHUAWEIDelegate vkCmdSubpassShadingHUAWEI_ptr;
		public static void vkCmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer)
			=> vkCmdSubpassShadingHUAWEI_ptr(commandBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindInvocationMaskHUAWEIDelegate(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
		private static vkCmdBindInvocationMaskHUAWEIDelegate vkCmdBindInvocationMaskHUAWEI_ptr;
		public static void vkCmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
			=> vkCmdBindInvocationMaskHUAWEI_ptr(commandBuffer, imageView, imageLayout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemoryRemoteAddressNVDelegate(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, void* pAddress);
		private static vkGetMemoryRemoteAddressNVDelegate vkGetMemoryRemoteAddressNV_ptr;
		public static VkResult vkGetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, void* pAddress)
			=> vkGetMemoryRemoteAddressNV_ptr(device, pMemoryGetRemoteAddressInfo, pAddress);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPipelinePropertiesEXTDelegate(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, VkBaseOutStructure* pPipelineProperties);
		private static vkGetPipelinePropertiesEXTDelegate vkGetPipelinePropertiesEXT_ptr;
		public static VkResult vkGetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
			=> vkGetPipelinePropertiesEXT_ptr(device, pPipelineInfo, pPipelineProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceSciSyncFenceNVDelegate(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle);
		private static vkGetFenceSciSyncFenceNVDelegate vkGetFenceSciSyncFenceNV_ptr;
		public static VkResult vkGetFenceSciSyncFenceNV(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
			=> vkGetFenceSciSyncFenceNV_ptr(device, pGetSciSyncHandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFenceSciSyncObjNVDelegate(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle);
		private static vkGetFenceSciSyncObjNVDelegate vkGetFenceSciSyncObjNV_ptr;
		public static VkResult vkGetFenceSciSyncObjNV(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
			=> vkGetFenceSciSyncObjNV_ptr(device, pGetSciSyncHandleInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportFenceSciSyncFenceNVDelegate(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo);
		private static vkImportFenceSciSyncFenceNVDelegate vkImportFenceSciSyncFenceNV_ptr;
		public static VkResult vkImportFenceSciSyncFenceNV(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
			=> vkImportFenceSciSyncFenceNV_ptr(device, pImportFenceSciSyncInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportFenceSciSyncObjNVDelegate(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo);
		private static vkImportFenceSciSyncObjNVDelegate vkImportFenceSciSyncObjNV_ptr;
		public static VkResult vkImportFenceSciSyncObjNV(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
			=> vkImportFenceSciSyncObjNV_ptr(device, pImportFenceSciSyncInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSciSyncAttributesNVDelegate(VkPhysicalDevice physicalDevice, VkSciSyncAttributesInfoNV* pSciSyncAttributesInfo, IntPtr pAttributes);
		private static vkGetPhysicalDeviceSciSyncAttributesNVDelegate vkGetPhysicalDeviceSciSyncAttributesNV_ptr;
		public static VkResult vkGetPhysicalDeviceSciSyncAttributesNV(VkPhysicalDevice physicalDevice, VkSciSyncAttributesInfoNV* pSciSyncAttributesInfo, IntPtr pAttributes)
			=> vkGetPhysicalDeviceSciSyncAttributesNV_ptr(physicalDevice, pSciSyncAttributesInfo, pAttributes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetSemaphoreSciSyncObjNVDelegate(VkDevice device, VkSemaphoreGetSciSyncInfoNV* pGetSciSyncInfo, void* pHandle);
		private static vkGetSemaphoreSciSyncObjNVDelegate vkGetSemaphoreSciSyncObjNV_ptr;
		public static VkResult vkGetSemaphoreSciSyncObjNV(VkDevice device, VkSemaphoreGetSciSyncInfoNV* pGetSciSyncInfo, void* pHandle)
			=> vkGetSemaphoreSciSyncObjNV_ptr(device, pGetSciSyncInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkImportSemaphoreSciSyncObjNVDelegate(VkDevice device, VkImportSemaphoreSciSyncInfoNV* pImportSemaphoreSciSyncInfo);
		private static vkImportSemaphoreSciSyncObjNVDelegate vkImportSemaphoreSciSyncObjNV_ptr;
		public static VkResult vkImportSemaphoreSciSyncObjNV(VkDevice device, VkImportSemaphoreSciSyncInfoNV* pImportSemaphoreSciSyncInfo)
			=> vkImportSemaphoreSciSyncObjNV_ptr(device, pImportSemaphoreSciSyncInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetMemorySciBufNVDelegate(VkDevice device, VkMemoryGetSciBufInfoNV* pGetSciBufInfo, IntPtr pHandle);
		private static vkGetMemorySciBufNVDelegate vkGetMemorySciBufNV_ptr;
		public static VkResult vkGetMemorySciBufNV(VkDevice device, VkMemoryGetSciBufInfoNV* pGetSciBufInfo, IntPtr pHandle)
			=> vkGetMemorySciBufNV_ptr(device, pGetSciBufInfo, pHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceExternalMemorySciBufPropertiesNVDelegate(VkPhysicalDevice physicalDevice, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, VkMemorySciBufPropertiesNV* pMemorySciBufProperties);
		private static vkGetPhysicalDeviceExternalMemorySciBufPropertiesNVDelegate vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_ptr;
		public static VkResult vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV(VkPhysicalDevice physicalDevice, VkExternalMemoryHandleTypeFlags handleType, IntPtr handle, VkMemorySciBufPropertiesNV* pMemorySciBufProperties)
			=> vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_ptr(physicalDevice, handleType, handle, pMemorySciBufProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceSciBufAttributesNVDelegate(VkPhysicalDevice physicalDevice, IntPtr pAttributes);
		private static vkGetPhysicalDeviceSciBufAttributesNVDelegate vkGetPhysicalDeviceSciBufAttributesNV_ptr;
		public static VkResult vkGetPhysicalDeviceSciBufAttributesNV(VkPhysicalDevice physicalDevice, IntPtr pAttributes)
			=> vkGetPhysicalDeviceSciBufAttributesNV_ptr(physicalDevice, pAttributes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetPatchControlPointsEXTDelegate(VkCommandBuffer commandBuffer, uint patchControlPoints);
		private static vkCmdSetPatchControlPointsEXTDelegate vkCmdSetPatchControlPointsEXT_ptr;
		public static void vkCmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints)
			=> vkCmdSetPatchControlPointsEXT_ptr(commandBuffer, patchControlPoints);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLogicOpEXTDelegate(VkCommandBuffer commandBuffer, VkLogicOp logicOp);
		private static vkCmdSetLogicOpEXTDelegate vkCmdSetLogicOpEXT_ptr;
		public static void vkCmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
			=> vkCmdSetLogicOpEXT_ptr(commandBuffer, logicOp);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateScreenSurfaceQNXDelegate(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface);
		private static vkCreateScreenSurfaceQNXDelegate vkCreateScreenSurfaceQNX_ptr;
		public static VkResult vkCreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
			=> vkCreateScreenSurfaceQNX_ptr(instance, pCreateInfo, pAllocator, pSurface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNXDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr window);
		private static vkGetPhysicalDeviceScreenPresentationSupportQNXDelegate vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr;
		public static VkBool32 vkGetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr window)
			=> vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr(physicalDevice, queueFamilyIndex, window);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetColorWriteEnableEXTDelegate(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* pColorWriteEnables);
		private static vkCmdSetColorWriteEnableEXTDelegate vkCmdSetColorWriteEnableEXT_ptr;
		public static void vkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* pColorWriteEnables)
			=> vkCmdSetColorWriteEnableEXT_ptr(commandBuffer, attachmentCount, pColorWriteEnables);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMultiEXTDelegate(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride);
		private static vkCmdDrawMultiEXTDelegate vkCmdDrawMultiEXT_ptr;
		public static void vkCmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
			=> vkCmdDrawMultiEXT_ptr(commandBuffer, drawCount, pVertexInfo, instanceCount, firstInstance, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawMultiIndexedEXTDelegate(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset);
		private static vkCmdDrawMultiIndexedEXTDelegate vkCmdDrawMultiIndexedEXT_ptr;
		public static void vkCmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
			=> vkCmdDrawMultiIndexedEXT_ptr(commandBuffer, drawCount, pIndexInfo, instanceCount, firstInstance, stride, pVertexOffset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateMicromapEXTDelegate(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap);
		private static vkCreateMicromapEXTDelegate vkCreateMicromapEXT_ptr;
		public static VkResult vkCreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
			=> vkCreateMicromapEXT_ptr(device, pCreateInfo, pAllocator, pMicromap);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyMicromapEXTDelegate(VkDevice device, VkMicromapEXT micromap, VkAllocationCallbacks* pAllocator);
		private static vkDestroyMicromapEXTDelegate vkDestroyMicromapEXT_ptr;
		public static void vkDestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, VkAllocationCallbacks* pAllocator)
			=> vkDestroyMicromapEXT_ptr(device, micromap, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBuildMicromapsEXTDelegate(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos);
		private static vkCmdBuildMicromapsEXTDelegate vkCmdBuildMicromapsEXT_ptr;
		public static void vkCmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
			=> vkCmdBuildMicromapsEXT_ptr(commandBuffer, infoCount, pInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBuildMicromapsEXTDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos);
		private static vkBuildMicromapsEXTDelegate vkBuildMicromapsEXT_ptr;
		public static VkResult vkBuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
			=> vkBuildMicromapsEXT_ptr(device, deferredOperation, infoCount, pInfos);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyMicromapEXTDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapInfoEXT* pInfo);
		private static vkCopyMicromapEXTDelegate vkCopyMicromapEXT_ptr;
		public static VkResult vkCopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapInfoEXT* pInfo)
			=> vkCopyMicromapEXT_ptr(device, deferredOperation, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyMicromapToMemoryEXTDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo);
		private static vkCopyMicromapToMemoryEXTDelegate vkCopyMicromapToMemoryEXT_ptr;
		public static VkResult vkCopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo)
			=> vkCopyMicromapToMemoryEXT_ptr(device, deferredOperation, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCopyMemoryToMicromapEXTDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo);
		private static vkCopyMemoryToMicromapEXTDelegate vkCopyMemoryToMicromapEXT_ptr;
		public static VkResult vkCopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
			=> vkCopyMemoryToMicromapEXT_ptr(device, deferredOperation, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkWriteMicromapsPropertiesEXTDelegate(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride);
		private static vkWriteMicromapsPropertiesEXTDelegate vkWriteMicromapsPropertiesEXT_ptr;
		public static VkResult vkWriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, UIntPtr dataSize, void* pData, UIntPtr stride)
			=> vkWriteMicromapsPropertiesEXT_ptr(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyMicromapEXTDelegate(VkCommandBuffer commandBuffer, VkCopyMicromapInfoEXT* pInfo);
		private static vkCmdCopyMicromapEXTDelegate vkCmdCopyMicromapEXT_ptr;
		public static void vkCmdCopyMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMicromapInfoEXT* pInfo)
			=> vkCmdCopyMicromapEXT_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyMicromapToMemoryEXTDelegate(VkCommandBuffer commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo);
		private static vkCmdCopyMicromapToMemoryEXTDelegate vkCmdCopyMicromapToMemoryEXT_ptr;
		public static void vkCmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo)
			=> vkCmdCopyMicromapToMemoryEXT_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyMemoryToMicromapEXTDelegate(VkCommandBuffer commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo);
		private static vkCmdCopyMemoryToMicromapEXTDelegate vkCmdCopyMemoryToMicromapEXT_ptr;
		public static void vkCmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo)
			=> vkCmdCopyMemoryToMicromapEXT_ptr(commandBuffer, pInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdWriteMicromapsPropertiesEXTDelegate(VkCommandBuffer commandBuffer, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
		private static vkCmdWriteMicromapsPropertiesEXTDelegate vkCmdWriteMicromapsPropertiesEXT_ptr;
		public static void vkCmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
			=> vkCmdWriteMicromapsPropertiesEXT_ptr(commandBuffer, micromapCount, pMicromaps, queryType, queryPool, firstQuery);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDeviceMicromapCompatibilityEXTDelegate(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility);
		private static vkGetDeviceMicromapCompatibilityEXTDelegate vkGetDeviceMicromapCompatibilityEXT_ptr;
		public static void vkGetDeviceMicromapCompatibilityEXT(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
			=> vkGetDeviceMicromapCompatibilityEXT_ptr(device, pVersionInfo, pCompatibility);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetMicromapBuildSizesEXTDelegate(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo);
		private static vkGetMicromapBuildSizesEXTDelegate vkGetMicromapBuildSizesEXT_ptr;
		public static void vkGetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
			=> vkGetMicromapBuildSizesEXT_ptr(device, buildType, pBuildInfo, pSizeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawClusterHUAWEIDelegate(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
		private static vkCmdDrawClusterHUAWEIDelegate vkCmdDrawClusterHUAWEI_ptr;
		public static void vkCmdDrawClusterHUAWEI(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
			=> vkCmdDrawClusterHUAWEI_ptr(commandBuffer, groupCountX, groupCountY, groupCountZ);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDrawClusterIndirectHUAWEIDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset);
		private static vkCmdDrawClusterIndirectHUAWEIDelegate vkCmdDrawClusterIndirectHUAWEI_ptr;
		public static void vkCmdDrawClusterIndirectHUAWEI(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
			=> vkCmdDrawClusterIndirectHUAWEI_ptr(commandBuffer, buffer, offset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkSetDeviceMemoryPriorityEXTDelegate(VkDevice device, VkDeviceMemory memory, float priority);
		private static vkSetDeviceMemoryPriorityEXTDelegate vkSetDeviceMemoryPriorityEXT_ptr;
		public static void vkSetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority)
			=> vkSetDeviceMemoryPriorityEXT_ptr(device, memory, priority);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDescriptorSetLayoutHostMappingInfoVALVEDelegate(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping);
		private static vkGetDescriptorSetLayoutHostMappingInfoVALVEDelegate vkGetDescriptorSetLayoutHostMappingInfoVALVE_ptr;
		public static void vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
			=> vkGetDescriptorSetLayoutHostMappingInfoVALVE_ptr(device, pBindingReference, pHostMapping);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetDescriptorSetHostMappingVALVEDelegate(VkDevice device, VkDescriptorSet descriptorSet, void** ppData);
		private static vkGetDescriptorSetHostMappingVALVEDelegate vkGetDescriptorSetHostMappingVALVE_ptr;
		public static void vkGetDescriptorSetHostMappingVALVE(VkDevice device, VkDescriptorSet descriptorSet, void** ppData)
			=> vkGetDescriptorSetHostMappingVALVE_ptr(device, descriptorSet, ppData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyMemoryIndirectNVDelegate(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride);
		private static vkCmdCopyMemoryIndirectNVDelegate vkCmdCopyMemoryIndirectNV_ptr;
		public static void vkCmdCopyMemoryIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride)
			=> vkCmdCopyMemoryIndirectNV_ptr(commandBuffer, copyBufferAddress, copyCount, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdCopyMemoryToImageIndirectNVDelegate(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources);
		private static vkCmdCopyMemoryToImageIndirectNVDelegate vkCmdCopyMemoryToImageIndirectNV_ptr;
		public static void vkCmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
			=> vkCmdCopyMemoryToImageIndirectNV_ptr(commandBuffer, copyBufferAddress, copyCount, stride, dstImage, dstImageLayout, pImageSubresources);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDecompressMemoryNVDelegate(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions);
		private static vkCmdDecompressMemoryNVDelegate vkCmdDecompressMemoryNV_ptr;
		public static void vkCmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
			=> vkCmdDecompressMemoryNV_ptr(commandBuffer, decompressRegionCount, pDecompressMemoryRegions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdDecompressMemoryIndirectCountNVDelegate(VkCommandBuffer commandBuffer, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint stride);
		private static vkCmdDecompressMemoryIndirectCountNVDelegate vkCmdDecompressMemoryIndirectCountNV_ptr;
		public static void vkCmdDecompressMemoryIndirectCountNV(VkCommandBuffer commandBuffer, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint stride)
			=> vkCmdDecompressMemoryIndirectCountNV_ptr(commandBuffer, indirectCommandsAddress, indirectCommandsCountAddress, stride);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetTessellationDomainOriginEXTDelegate(VkCommandBuffer commandBuffer, VkTessellationDomainOrigin domainOrigin);
		private static vkCmdSetTessellationDomainOriginEXTDelegate vkCmdSetTessellationDomainOriginEXT_ptr;
		public static void vkCmdSetTessellationDomainOriginEXT(VkCommandBuffer commandBuffer, VkTessellationDomainOrigin domainOrigin)
			=> vkCmdSetTessellationDomainOriginEXT_ptr(commandBuffer, domainOrigin);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthClampEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthClampEnable);
		private static vkCmdSetDepthClampEnableEXTDelegate vkCmdSetDepthClampEnableEXT_ptr;
		public static void vkCmdSetDepthClampEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthClampEnable)
			=> vkCmdSetDepthClampEnableEXT_ptr(commandBuffer, depthClampEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetPolygonModeEXTDelegate(VkCommandBuffer commandBuffer, VkPolygonMode polygonMode);
		private static vkCmdSetPolygonModeEXTDelegate vkCmdSetPolygonModeEXT_ptr;
		public static void vkCmdSetPolygonModeEXT(VkCommandBuffer commandBuffer, VkPolygonMode polygonMode)
			=> vkCmdSetPolygonModeEXT_ptr(commandBuffer, polygonMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetRasterizationSamplesEXTDelegate(VkCommandBuffer commandBuffer, VkSampleCountFlags rasterizationSamples);
		private static vkCmdSetRasterizationSamplesEXTDelegate vkCmdSetRasterizationSamplesEXT_ptr;
		public static void vkCmdSetRasterizationSamplesEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags rasterizationSamples)
			=> vkCmdSetRasterizationSamplesEXT_ptr(commandBuffer, rasterizationSamples);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetSampleMaskEXTDelegate(VkCommandBuffer commandBuffer, VkSampleCountFlags samples, uint* pSampleMask);
		private static vkCmdSetSampleMaskEXTDelegate vkCmdSetSampleMaskEXT_ptr;
		public static void vkCmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlags samples, uint* pSampleMask)
			=> vkCmdSetSampleMaskEXT_ptr(commandBuffer, samples, pSampleMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetAlphaToCoverageEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 alphaToCoverageEnable);
		private static vkCmdSetAlphaToCoverageEnableEXTDelegate vkCmdSetAlphaToCoverageEnableEXT_ptr;
		public static void vkCmdSetAlphaToCoverageEnableEXT(VkCommandBuffer commandBuffer, VkBool32 alphaToCoverageEnable)
			=> vkCmdSetAlphaToCoverageEnableEXT_ptr(commandBuffer, alphaToCoverageEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetAlphaToOneEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 alphaToOneEnable);
		private static vkCmdSetAlphaToOneEnableEXTDelegate vkCmdSetAlphaToOneEnableEXT_ptr;
		public static void vkCmdSetAlphaToOneEnableEXT(VkCommandBuffer commandBuffer, VkBool32 alphaToOneEnable)
			=> vkCmdSetAlphaToOneEnableEXT_ptr(commandBuffer, alphaToOneEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLogicOpEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 logicOpEnable);
		private static vkCmdSetLogicOpEnableEXTDelegate vkCmdSetLogicOpEnableEXT_ptr;
		public static void vkCmdSetLogicOpEnableEXT(VkCommandBuffer commandBuffer, VkBool32 logicOpEnable)
			=> vkCmdSetLogicOpEnableEXT_ptr(commandBuffer, logicOpEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetColorBlendEnableEXTDelegate(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkBool32* pColorBlendEnables);
		private static vkCmdSetColorBlendEnableEXTDelegate vkCmdSetColorBlendEnableEXT_ptr;
		public static void vkCmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkBool32* pColorBlendEnables)
			=> vkCmdSetColorBlendEnableEXT_ptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetColorBlendEquationEXTDelegate(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations);
		private static vkCmdSetColorBlendEquationEXTDelegate vkCmdSetColorBlendEquationEXT_ptr;
		public static void vkCmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations)
			=> vkCmdSetColorBlendEquationEXT_ptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEquations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetColorWriteMaskEXTDelegate(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlags* pColorWriteMasks);
		private static vkCmdSetColorWriteMaskEXTDelegate vkCmdSetColorWriteMaskEXT_ptr;
		public static void vkCmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlags* pColorWriteMasks)
			=> vkCmdSetColorWriteMaskEXT_ptr(commandBuffer, firstAttachment, attachmentCount, pColorWriteMasks);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetRasterizationStreamEXTDelegate(VkCommandBuffer commandBuffer, uint rasterizationStream);
		private static vkCmdSetRasterizationStreamEXTDelegate vkCmdSetRasterizationStreamEXT_ptr;
		public static void vkCmdSetRasterizationStreamEXT(VkCommandBuffer commandBuffer, uint rasterizationStream)
			=> vkCmdSetRasterizationStreamEXT_ptr(commandBuffer, rasterizationStream);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetConservativeRasterizationModeEXTDelegate(VkCommandBuffer commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode);
		private static vkCmdSetConservativeRasterizationModeEXTDelegate vkCmdSetConservativeRasterizationModeEXT_ptr;
		public static void vkCmdSetConservativeRasterizationModeEXT(VkCommandBuffer commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode)
			=> vkCmdSetConservativeRasterizationModeEXT_ptr(commandBuffer, conservativeRasterizationMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetExtraPrimitiveOverestimationSizeEXTDelegate(VkCommandBuffer commandBuffer, float extraPrimitiveOverestimationSize);
		private static vkCmdSetExtraPrimitiveOverestimationSizeEXTDelegate vkCmdSetExtraPrimitiveOverestimationSizeEXT_ptr;
		public static void vkCmdSetExtraPrimitiveOverestimationSizeEXT(VkCommandBuffer commandBuffer, float extraPrimitiveOverestimationSize)
			=> vkCmdSetExtraPrimitiveOverestimationSizeEXT_ptr(commandBuffer, extraPrimitiveOverestimationSize);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthClipEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthClipEnable);
		private static vkCmdSetDepthClipEnableEXTDelegate vkCmdSetDepthClipEnableEXT_ptr;
		public static void vkCmdSetDepthClipEnableEXT(VkCommandBuffer commandBuffer, VkBool32 depthClipEnable)
			=> vkCmdSetDepthClipEnableEXT_ptr(commandBuffer, depthClipEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetSampleLocationsEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 sampleLocationsEnable);
		private static vkCmdSetSampleLocationsEnableEXTDelegate vkCmdSetSampleLocationsEnableEXT_ptr;
		public static void vkCmdSetSampleLocationsEnableEXT(VkCommandBuffer commandBuffer, VkBool32 sampleLocationsEnable)
			=> vkCmdSetSampleLocationsEnableEXT_ptr(commandBuffer, sampleLocationsEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetColorBlendAdvancedEXTDelegate(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced);
		private static vkCmdSetColorBlendAdvancedEXTDelegate vkCmdSetColorBlendAdvancedEXT_ptr;
		public static void vkCmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced)
			=> vkCmdSetColorBlendAdvancedEXT_ptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendAdvanced);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetProvokingVertexModeEXTDelegate(VkCommandBuffer commandBuffer, VkProvokingVertexModeEXT provokingVertexMode);
		private static vkCmdSetProvokingVertexModeEXTDelegate vkCmdSetProvokingVertexModeEXT_ptr;
		public static void vkCmdSetProvokingVertexModeEXT(VkCommandBuffer commandBuffer, VkProvokingVertexModeEXT provokingVertexMode)
			=> vkCmdSetProvokingVertexModeEXT_ptr(commandBuffer, provokingVertexMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLineRasterizationModeEXTDelegate(VkCommandBuffer commandBuffer, VkLineRasterizationModeEXT lineRasterizationMode);
		private static vkCmdSetLineRasterizationModeEXTDelegate vkCmdSetLineRasterizationModeEXT_ptr;
		public static void vkCmdSetLineRasterizationModeEXT(VkCommandBuffer commandBuffer, VkLineRasterizationModeEXT lineRasterizationMode)
			=> vkCmdSetLineRasterizationModeEXT_ptr(commandBuffer, lineRasterizationMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetLineStippleEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 stippledLineEnable);
		private static vkCmdSetLineStippleEnableEXTDelegate vkCmdSetLineStippleEnableEXT_ptr;
		public static void vkCmdSetLineStippleEnableEXT(VkCommandBuffer commandBuffer, VkBool32 stippledLineEnable)
			=> vkCmdSetLineStippleEnableEXT_ptr(commandBuffer, stippledLineEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetDepthClipNegativeOneToOneEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 negativeOneToOne);
		private static vkCmdSetDepthClipNegativeOneToOneEXTDelegate vkCmdSetDepthClipNegativeOneToOneEXT_ptr;
		public static void vkCmdSetDepthClipNegativeOneToOneEXT(VkCommandBuffer commandBuffer, VkBool32 negativeOneToOne)
			=> vkCmdSetDepthClipNegativeOneToOneEXT_ptr(commandBuffer, negativeOneToOne);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportWScalingEnableNVDelegate(VkCommandBuffer commandBuffer, VkBool32 viewportWScalingEnable);
		private static vkCmdSetViewportWScalingEnableNVDelegate vkCmdSetViewportWScalingEnableNV_ptr;
		public static void vkCmdSetViewportWScalingEnableNV(VkCommandBuffer commandBuffer, VkBool32 viewportWScalingEnable)
			=> vkCmdSetViewportWScalingEnableNV_ptr(commandBuffer, viewportWScalingEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetViewportSwizzleNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles);
		private static vkCmdSetViewportSwizzleNVDelegate vkCmdSetViewportSwizzleNV_ptr;
		public static void vkCmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
			=> vkCmdSetViewportSwizzleNV_ptr(commandBuffer, firstViewport, viewportCount, pViewportSwizzles);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCoverageToColorEnableNVDelegate(VkCommandBuffer commandBuffer, VkBool32 coverageToColorEnable);
		private static vkCmdSetCoverageToColorEnableNVDelegate vkCmdSetCoverageToColorEnableNV_ptr;
		public static void vkCmdSetCoverageToColorEnableNV(VkCommandBuffer commandBuffer, VkBool32 coverageToColorEnable)
			=> vkCmdSetCoverageToColorEnableNV_ptr(commandBuffer, coverageToColorEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCoverageToColorLocationNVDelegate(VkCommandBuffer commandBuffer, uint coverageToColorLocation);
		private static vkCmdSetCoverageToColorLocationNVDelegate vkCmdSetCoverageToColorLocationNV_ptr;
		public static void vkCmdSetCoverageToColorLocationNV(VkCommandBuffer commandBuffer, uint coverageToColorLocation)
			=> vkCmdSetCoverageToColorLocationNV_ptr(commandBuffer, coverageToColorLocation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCoverageModulationModeNVDelegate(VkCommandBuffer commandBuffer, VkCoverageModulationModeNV coverageModulationMode);
		private static vkCmdSetCoverageModulationModeNVDelegate vkCmdSetCoverageModulationModeNV_ptr;
		public static void vkCmdSetCoverageModulationModeNV(VkCommandBuffer commandBuffer, VkCoverageModulationModeNV coverageModulationMode)
			=> vkCmdSetCoverageModulationModeNV_ptr(commandBuffer, coverageModulationMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCoverageModulationTableEnableNVDelegate(VkCommandBuffer commandBuffer, VkBool32 coverageModulationTableEnable);
		private static vkCmdSetCoverageModulationTableEnableNVDelegate vkCmdSetCoverageModulationTableEnableNV_ptr;
		public static void vkCmdSetCoverageModulationTableEnableNV(VkCommandBuffer commandBuffer, VkBool32 coverageModulationTableEnable)
			=> vkCmdSetCoverageModulationTableEnableNV_ptr(commandBuffer, coverageModulationTableEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCoverageModulationTableNVDelegate(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable);
		private static vkCmdSetCoverageModulationTableNVDelegate vkCmdSetCoverageModulationTableNV_ptr;
		public static void vkCmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable)
			=> vkCmdSetCoverageModulationTableNV_ptr(commandBuffer, coverageModulationTableCount, pCoverageModulationTable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetShadingRateImageEnableNVDelegate(VkCommandBuffer commandBuffer, VkBool32 shadingRateImageEnable);
		private static vkCmdSetShadingRateImageEnableNVDelegate vkCmdSetShadingRateImageEnableNV_ptr;
		public static void vkCmdSetShadingRateImageEnableNV(VkCommandBuffer commandBuffer, VkBool32 shadingRateImageEnable)
			=> vkCmdSetShadingRateImageEnableNV_ptr(commandBuffer, shadingRateImageEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetRepresentativeFragmentTestEnableNVDelegate(VkCommandBuffer commandBuffer, VkBool32 representativeFragmentTestEnable);
		private static vkCmdSetRepresentativeFragmentTestEnableNVDelegate vkCmdSetRepresentativeFragmentTestEnableNV_ptr;
		public static void vkCmdSetRepresentativeFragmentTestEnableNV(VkCommandBuffer commandBuffer, VkBool32 representativeFragmentTestEnable)
			=> vkCmdSetRepresentativeFragmentTestEnableNV_ptr(commandBuffer, representativeFragmentTestEnable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetCoverageReductionModeNVDelegate(VkCommandBuffer commandBuffer, VkCoverageReductionModeNV coverageReductionMode);
		private static vkCmdSetCoverageReductionModeNVDelegate vkCmdSetCoverageReductionModeNV_ptr;
		public static void vkCmdSetCoverageReductionModeNV(VkCommandBuffer commandBuffer, VkCoverageReductionModeNV coverageReductionMode)
			=> vkCmdSetCoverageReductionModeNV_ptr(commandBuffer, coverageReductionMode);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetShaderModuleIdentifierEXTDelegate(VkDevice device, VkShaderModule shaderModule, VkShaderModuleIdentifierEXT* pIdentifier);
		private static vkGetShaderModuleIdentifierEXTDelegate vkGetShaderModuleIdentifierEXT_ptr;
		public static void vkGetShaderModuleIdentifierEXT(VkDevice device, VkShaderModule shaderModule, VkShaderModuleIdentifierEXT* pIdentifier)
			=> vkGetShaderModuleIdentifierEXT_ptr(device, shaderModule, pIdentifier);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkGetShaderModuleCreateInfoIdentifierEXTDelegate(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier);
		private static vkGetShaderModuleCreateInfoIdentifierEXTDelegate vkGetShaderModuleCreateInfoIdentifierEXT_ptr;
		public static void vkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
			=> vkGetShaderModuleCreateInfoIdentifierEXT_ptr(device, pCreateInfo, pIdentifier);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNVDelegate(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties);
		private static vkGetPhysicalDeviceOpticalFlowImageFormatsNVDelegate vkGetPhysicalDeviceOpticalFlowImageFormatsNV_ptr;
		public static VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
			=> vkGetPhysicalDeviceOpticalFlowImageFormatsNV_ptr(physicalDevice, pOpticalFlowImageFormatInfo, pFormatCount, pImageFormatProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateOpticalFlowSessionNVDelegate(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession);
		private static vkCreateOpticalFlowSessionNVDelegate vkCreateOpticalFlowSessionNV_ptr;
		public static VkResult vkCreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
			=> vkCreateOpticalFlowSessionNV_ptr(device, pCreateInfo, pAllocator, pSession);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyOpticalFlowSessionNVDelegate(VkDevice device, VkOpticalFlowSessionNV session, VkAllocationCallbacks* pAllocator);
		private static vkDestroyOpticalFlowSessionNVDelegate vkDestroyOpticalFlowSessionNV_ptr;
		public static void vkDestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, VkAllocationCallbacks* pAllocator)
			=> vkDestroyOpticalFlowSessionNV_ptr(device, session, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkBindOpticalFlowSessionImageNVDelegate(VkDevice device, VkOpticalFlowSessionNV session, VkOpticalFlowSessionBindingPointNV bindingPoint, VkImageView view, VkImageLayout layout);
		private static vkBindOpticalFlowSessionImageNVDelegate vkBindOpticalFlowSessionImageNV_ptr;
		public static VkResult vkBindOpticalFlowSessionImageNV(VkDevice device, VkOpticalFlowSessionNV session, VkOpticalFlowSessionBindingPointNV bindingPoint, VkImageView view, VkImageLayout layout)
			=> vkBindOpticalFlowSessionImageNV_ptr(device, session, bindingPoint, view, layout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdOpticalFlowExecuteNVDelegate(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, VkOpticalFlowExecuteInfoNV* pExecuteInfo);
		private static vkCmdOpticalFlowExecuteNVDelegate vkCmdOpticalFlowExecuteNV_ptr;
		public static void vkCmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
			=> vkCmdOpticalFlowExecuteNV_ptr(commandBuffer, session, pExecuteInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateShadersEXTDelegate(VkDevice device, uint createInfoCount, VkShaderCreateInfoEXT* pCreateInfos, VkAllocationCallbacks* pAllocator, VkShaderEXT* pShaders);
		private static vkCreateShadersEXTDelegate vkCreateShadersEXT_ptr;
		public static VkResult vkCreateShadersEXT(VkDevice device, uint createInfoCount, VkShaderCreateInfoEXT* pCreateInfos, VkAllocationCallbacks* pAllocator, VkShaderEXT* pShaders)
			=> vkCreateShadersEXT_ptr(device, createInfoCount, pCreateInfos, pAllocator, pShaders);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroyShaderEXTDelegate(VkDevice device, VkShaderEXT shader, VkAllocationCallbacks* pAllocator);
		private static vkDestroyShaderEXTDelegate vkDestroyShaderEXT_ptr;
		public static void vkDestroyShaderEXT(VkDevice device, VkShaderEXT shader, VkAllocationCallbacks* pAllocator)
			=> vkDestroyShaderEXT_ptr(device, shader, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetShaderBinaryDataEXTDelegate(VkDevice device, VkShaderEXT shader, UIntPtr* pDataSize, void* pData);
		private static vkGetShaderBinaryDataEXTDelegate vkGetShaderBinaryDataEXT_ptr;
		public static VkResult vkGetShaderBinaryDataEXT(VkDevice device, VkShaderEXT shader, UIntPtr* pDataSize, void* pData)
			=> vkGetShaderBinaryDataEXT_ptr(device, shader, pDataSize, pData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdBindShadersEXTDelegate(VkCommandBuffer commandBuffer, uint stageCount, VkShaderStageFlags* pStages, VkShaderEXT* pShaders);
		private static vkCmdBindShadersEXTDelegate vkCmdBindShadersEXT_ptr;
		public static void vkCmdBindShadersEXT(VkCommandBuffer commandBuffer, uint stageCount, VkShaderStageFlags* pStages, VkShaderEXT* pShaders)
			=> vkCmdBindShadersEXT_ptr(commandBuffer, stageCount, pStages, pShaders);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetFramebufferTilePropertiesQCOMDelegate(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties);
		private static vkGetFramebufferTilePropertiesQCOMDelegate vkGetFramebufferTilePropertiesQCOM_ptr;
		public static VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
			=> vkGetFramebufferTilePropertiesQCOM_ptr(device, framebuffer, pPropertiesCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetDynamicRenderingTilePropertiesQCOMDelegate(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties);
		private static vkGetDynamicRenderingTilePropertiesQCOMDelegate vkGetDynamicRenderingTilePropertiesQCOM_ptr;
		public static VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
			=> vkGetDynamicRenderingTilePropertiesQCOM_ptr(device, pRenderingInfo, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkCreateSemaphoreSciSyncPoolNVDelegate(VkDevice device, VkSemaphoreSciSyncPoolCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphoreSciSyncPoolNV* pSemaphorePool);
		private static vkCreateSemaphoreSciSyncPoolNVDelegate vkCreateSemaphoreSciSyncPoolNV_ptr;
		public static VkResult vkCreateSemaphoreSciSyncPoolNV(VkDevice device, VkSemaphoreSciSyncPoolCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphoreSciSyncPoolNV* pSemaphorePool)
			=> vkCreateSemaphoreSciSyncPoolNV_ptr(device, pCreateInfo, pAllocator, pSemaphorePool);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkDestroySemaphoreSciSyncPoolNVDelegate(VkDevice device, VkSemaphoreSciSyncPoolNV semaphorePool, VkAllocationCallbacks* pAllocator);
		private static vkDestroySemaphoreSciSyncPoolNVDelegate vkDestroySemaphoreSciSyncPoolNV_ptr;
		public static void vkDestroySemaphoreSciSyncPoolNV(VkDevice device, VkSemaphoreSciSyncPoolNV semaphorePool, VkAllocationCallbacks* pAllocator)
			=> vkDestroySemaphoreSciSyncPoolNV_ptr(device, semaphorePool, pAllocator);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesKHR* pProperties);
		private static vkGetPhysicalDeviceCooperativeMatrixPropertiesKHRDelegate vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_ptr;
		public static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesKHR* pProperties)
			=> vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_ptr(physicalDevice, pPropertyCount, pProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate void vkCmdSetAttachmentFeedbackLoopEnableEXTDelegate(VkCommandBuffer commandBuffer, VkImageAspectFlags aspectMask);
		private static vkCmdSetAttachmentFeedbackLoopEnableEXTDelegate vkCmdSetAttachmentFeedbackLoopEnableEXT_ptr;
		public static void vkCmdSetAttachmentFeedbackLoopEnableEXT(VkCommandBuffer commandBuffer, VkImageAspectFlags aspectMask)
			=> vkCmdSetAttachmentFeedbackLoopEnableEXT_ptr(commandBuffer, aspectMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate VkResult vkGetScreenBufferPropertiesQNXDelegate(VkDevice device, IntPtr buffer, VkScreenBufferPropertiesQNX* pProperties);
		private static vkGetScreenBufferPropertiesQNXDelegate vkGetScreenBufferPropertiesQNX_ptr;
		public static VkResult vkGetScreenBufferPropertiesQNX(VkDevice device, IntPtr buffer, VkScreenBufferPropertiesQNX* pProperties)
			=> vkGetScreenBufferPropertiesQNX_ptr(device, buffer, pProperties);

		public static void LoadFuncionPointers(VkInstance instance = default)
		{
			if (instance != default)
			{
				NativeLib.instance = instance;
			}

			NativeLib.LoadFunction("vkCreateInstance",  out vkCreateInstance_ptr);
			NativeLib.LoadFunction("vkDestroyInstance",  out vkDestroyInstance_ptr);
			NativeLib.LoadFunction("vkEnumeratePhysicalDevices",  out vkEnumeratePhysicalDevices_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceFeatures",  out vkGetPhysicalDeviceFeatures_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceFormatProperties",  out vkGetPhysicalDeviceFormatProperties_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceImageFormatProperties",  out vkGetPhysicalDeviceImageFormatProperties_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceProperties",  out vkGetPhysicalDeviceProperties_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceQueueFamilyProperties",  out vkGetPhysicalDeviceQueueFamilyProperties_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceMemoryProperties",  out vkGetPhysicalDeviceMemoryProperties_ptr);
			NativeLib.LoadFunction("vkGetInstanceProcAddr",  out vkGetInstanceProcAddr_ptr);
			NativeLib.LoadFunction("vkGetDeviceProcAddr",  out vkGetDeviceProcAddr_ptr);
			NativeLib.LoadFunction("vkCreateDevice",  out vkCreateDevice_ptr);
			NativeLib.LoadFunction("vkDestroyDevice",  out vkDestroyDevice_ptr);
			NativeLib.LoadFunction("vkEnumerateInstanceExtensionProperties",  out vkEnumerateInstanceExtensionProperties_ptr);
			NativeLib.LoadFunction("vkEnumerateDeviceExtensionProperties",  out vkEnumerateDeviceExtensionProperties_ptr);
			NativeLib.LoadFunction("vkEnumerateInstanceLayerProperties",  out vkEnumerateInstanceLayerProperties_ptr);
			NativeLib.LoadFunction("vkEnumerateDeviceLayerProperties",  out vkEnumerateDeviceLayerProperties_ptr);
			NativeLib.LoadFunction("vkGetDeviceQueue",  out vkGetDeviceQueue_ptr);
			NativeLib.LoadFunction("vkQueueSubmit",  out vkQueueSubmit_ptr);
			NativeLib.LoadFunction("vkQueueWaitIdle",  out vkQueueWaitIdle_ptr);
			NativeLib.LoadFunction("vkDeviceWaitIdle",  out vkDeviceWaitIdle_ptr);
			NativeLib.LoadFunction("vkAllocateMemory",  out vkAllocateMemory_ptr);
			NativeLib.LoadFunction("vkFreeMemory",  out vkFreeMemory_ptr);
			NativeLib.LoadFunction("vkMapMemory",  out vkMapMemory_ptr);
			NativeLib.LoadFunction("vkUnmapMemory",  out vkUnmapMemory_ptr);
			NativeLib.LoadFunction("vkFlushMappedMemoryRanges",  out vkFlushMappedMemoryRanges_ptr);
			NativeLib.LoadFunction("vkInvalidateMappedMemoryRanges",  out vkInvalidateMappedMemoryRanges_ptr);
			NativeLib.LoadFunction("vkGetDeviceMemoryCommitment",  out vkGetDeviceMemoryCommitment_ptr);
			NativeLib.LoadFunction("vkBindBufferMemory",  out vkBindBufferMemory_ptr);
			NativeLib.LoadFunction("vkBindImageMemory",  out vkBindImageMemory_ptr);
			NativeLib.LoadFunction("vkGetBufferMemoryRequirements",  out vkGetBufferMemoryRequirements_ptr);
			NativeLib.LoadFunction("vkGetImageMemoryRequirements",  out vkGetImageMemoryRequirements_ptr);
			NativeLib.LoadFunction("vkGetImageSparseMemoryRequirements",  out vkGetImageSparseMemoryRequirements_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSparseImageFormatProperties",  out vkGetPhysicalDeviceSparseImageFormatProperties_ptr);
			NativeLib.LoadFunction("vkQueueBindSparse",  out vkQueueBindSparse_ptr);
			NativeLib.LoadFunction("vkCreateFence",  out vkCreateFence_ptr);
			NativeLib.LoadFunction("vkDestroyFence",  out vkDestroyFence_ptr);
			NativeLib.LoadFunction("vkResetFences",  out vkResetFences_ptr);
			NativeLib.LoadFunction("vkGetFenceStatus",  out vkGetFenceStatus_ptr);
			NativeLib.LoadFunction("vkWaitForFences",  out vkWaitForFences_ptr);
			NativeLib.LoadFunction("vkCreateSemaphore",  out vkCreateSemaphore_ptr);
			NativeLib.LoadFunction("vkDestroySemaphore",  out vkDestroySemaphore_ptr);
			NativeLib.LoadFunction("vkCreateEvent",  out vkCreateEvent_ptr);
			NativeLib.LoadFunction("vkDestroyEvent",  out vkDestroyEvent_ptr);
			NativeLib.LoadFunction("vkGetEventStatus",  out vkGetEventStatus_ptr);
			NativeLib.LoadFunction("vkSetEvent",  out vkSetEvent_ptr);
			NativeLib.LoadFunction("vkResetEvent",  out vkResetEvent_ptr);
			NativeLib.LoadFunction("vkCreateQueryPool",  out vkCreateQueryPool_ptr);
			NativeLib.LoadFunction("vkDestroyQueryPool",  out vkDestroyQueryPool_ptr);
			NativeLib.LoadFunction("vkGetQueryPoolResults",  out vkGetQueryPoolResults_ptr);
			NativeLib.LoadFunction("vkCreateBuffer",  out vkCreateBuffer_ptr);
			NativeLib.LoadFunction("vkDestroyBuffer",  out vkDestroyBuffer_ptr);
			NativeLib.LoadFunction("vkCreateBufferView",  out vkCreateBufferView_ptr);
			NativeLib.LoadFunction("vkDestroyBufferView",  out vkDestroyBufferView_ptr);
			NativeLib.LoadFunction("vkCreateImage",  out vkCreateImage_ptr);
			NativeLib.LoadFunction("vkDestroyImage",  out vkDestroyImage_ptr);
			NativeLib.LoadFunction("vkGetImageSubresourceLayout",  out vkGetImageSubresourceLayout_ptr);
			NativeLib.LoadFunction("vkCreateImageView",  out vkCreateImageView_ptr);
			NativeLib.LoadFunction("vkDestroyImageView",  out vkDestroyImageView_ptr);
			NativeLib.LoadFunction("vkCreateShaderModule",  out vkCreateShaderModule_ptr);
			NativeLib.LoadFunction("vkDestroyShaderModule",  out vkDestroyShaderModule_ptr);
			NativeLib.LoadFunction("vkCreatePipelineCache",  out vkCreatePipelineCache_ptr);
			NativeLib.LoadFunction("vkDestroyPipelineCache",  out vkDestroyPipelineCache_ptr);
			NativeLib.LoadFunction("vkGetPipelineCacheData",  out vkGetPipelineCacheData_ptr);
			NativeLib.LoadFunction("vkMergePipelineCaches",  out vkMergePipelineCaches_ptr);
			NativeLib.LoadFunction("vkCreateGraphicsPipelines",  out vkCreateGraphicsPipelines_ptr);
			NativeLib.LoadFunction("vkCreateComputePipelines",  out vkCreateComputePipelines_ptr);
			NativeLib.LoadFunction("vkDestroyPipeline",  out vkDestroyPipeline_ptr);
			NativeLib.LoadFunction("vkCreatePipelineLayout",  out vkCreatePipelineLayout_ptr);
			NativeLib.LoadFunction("vkDestroyPipelineLayout",  out vkDestroyPipelineLayout_ptr);
			NativeLib.LoadFunction("vkCreateSampler",  out vkCreateSampler_ptr);
			NativeLib.LoadFunction("vkDestroySampler",  out vkDestroySampler_ptr);
			NativeLib.LoadFunction("vkCreateDescriptorSetLayout",  out vkCreateDescriptorSetLayout_ptr);
			NativeLib.LoadFunction("vkDestroyDescriptorSetLayout",  out vkDestroyDescriptorSetLayout_ptr);
			NativeLib.LoadFunction("vkCreateDescriptorPool",  out vkCreateDescriptorPool_ptr);
			NativeLib.LoadFunction("vkDestroyDescriptorPool",  out vkDestroyDescriptorPool_ptr);
			NativeLib.LoadFunction("vkResetDescriptorPool",  out vkResetDescriptorPool_ptr);
			NativeLib.LoadFunction("vkAllocateDescriptorSets",  out vkAllocateDescriptorSets_ptr);
			NativeLib.LoadFunction("vkFreeDescriptorSets",  out vkFreeDescriptorSets_ptr);
			NativeLib.LoadFunction("vkUpdateDescriptorSets",  out vkUpdateDescriptorSets_ptr);
			NativeLib.LoadFunction("vkCreateFramebuffer",  out vkCreateFramebuffer_ptr);
			NativeLib.LoadFunction("vkDestroyFramebuffer",  out vkDestroyFramebuffer_ptr);
			NativeLib.LoadFunction("vkCreateRenderPass",  out vkCreateRenderPass_ptr);
			NativeLib.LoadFunction("vkDestroyRenderPass",  out vkDestroyRenderPass_ptr);
			NativeLib.LoadFunction("vkGetRenderAreaGranularity",  out vkGetRenderAreaGranularity_ptr);
			NativeLib.LoadFunction("vkCreateCommandPool",  out vkCreateCommandPool_ptr);
			NativeLib.LoadFunction("vkDestroyCommandPool",  out vkDestroyCommandPool_ptr);
			NativeLib.LoadFunction("vkResetCommandPool",  out vkResetCommandPool_ptr);
			NativeLib.LoadFunction("vkAllocateCommandBuffers",  out vkAllocateCommandBuffers_ptr);
			NativeLib.LoadFunction("vkFreeCommandBuffers",  out vkFreeCommandBuffers_ptr);
			NativeLib.LoadFunction("vkBeginCommandBuffer",  out vkBeginCommandBuffer_ptr);
			NativeLib.LoadFunction("vkEndCommandBuffer",  out vkEndCommandBuffer_ptr);
			NativeLib.LoadFunction("vkResetCommandBuffer",  out vkResetCommandBuffer_ptr);
			NativeLib.LoadFunction("vkCmdBindPipeline",  out vkCmdBindPipeline_ptr);
			NativeLib.LoadFunction("vkCmdSetViewport",  out vkCmdSetViewport_ptr);
			NativeLib.LoadFunction("vkCmdSetScissor",  out vkCmdSetScissor_ptr);
			NativeLib.LoadFunction("vkCmdSetLineWidth",  out vkCmdSetLineWidth_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthBias",  out vkCmdSetDepthBias_ptr);
			NativeLib.LoadFunction("vkCmdSetBlendConstants",  out vkCmdSetBlendConstants_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthBounds",  out vkCmdSetDepthBounds_ptr);
			NativeLib.LoadFunction("vkCmdSetStencilCompareMask",  out vkCmdSetStencilCompareMask_ptr);
			NativeLib.LoadFunction("vkCmdSetStencilWriteMask",  out vkCmdSetStencilWriteMask_ptr);
			NativeLib.LoadFunction("vkCmdSetStencilReference",  out vkCmdSetStencilReference_ptr);
			NativeLib.LoadFunction("vkCmdBindDescriptorSets",  out vkCmdBindDescriptorSets_ptr);
			NativeLib.LoadFunction("vkCmdBindIndexBuffer",  out vkCmdBindIndexBuffer_ptr);
			NativeLib.LoadFunction("vkCmdBindVertexBuffers",  out vkCmdBindVertexBuffers_ptr);
			NativeLib.LoadFunction("vkCmdDraw",  out vkCmdDraw_ptr);
			NativeLib.LoadFunction("vkCmdDrawIndexed",  out vkCmdDrawIndexed_ptr);
			NativeLib.LoadFunction("vkCmdDrawIndirect",  out vkCmdDrawIndirect_ptr);
			NativeLib.LoadFunction("vkCmdDrawIndexedIndirect",  out vkCmdDrawIndexedIndirect_ptr);
			NativeLib.LoadFunction("vkCmdDispatch",  out vkCmdDispatch_ptr);
			NativeLib.LoadFunction("vkCmdDispatchIndirect",  out vkCmdDispatchIndirect_ptr);
			NativeLib.LoadFunction("vkCmdCopyBuffer",  out vkCmdCopyBuffer_ptr);
			NativeLib.LoadFunction("vkCmdCopyImage",  out vkCmdCopyImage_ptr);
			NativeLib.LoadFunction("vkCmdBlitImage",  out vkCmdBlitImage_ptr);
			NativeLib.LoadFunction("vkCmdCopyBufferToImage",  out vkCmdCopyBufferToImage_ptr);
			NativeLib.LoadFunction("vkCmdCopyImageToBuffer",  out vkCmdCopyImageToBuffer_ptr);
			NativeLib.LoadFunction("vkCmdUpdateBuffer",  out vkCmdUpdateBuffer_ptr);
			NativeLib.LoadFunction("vkCmdFillBuffer",  out vkCmdFillBuffer_ptr);
			NativeLib.LoadFunction("vkCmdClearColorImage",  out vkCmdClearColorImage_ptr);
			NativeLib.LoadFunction("vkCmdClearDepthStencilImage",  out vkCmdClearDepthStencilImage_ptr);
			NativeLib.LoadFunction("vkCmdClearAttachments",  out vkCmdClearAttachments_ptr);
			NativeLib.LoadFunction("vkCmdResolveImage",  out vkCmdResolveImage_ptr);
			NativeLib.LoadFunction("vkCmdSetEvent",  out vkCmdSetEvent_ptr);
			NativeLib.LoadFunction("vkCmdResetEvent",  out vkCmdResetEvent_ptr);
			NativeLib.LoadFunction("vkCmdWaitEvents",  out vkCmdWaitEvents_ptr);
			NativeLib.LoadFunction("vkCmdPipelineBarrier",  out vkCmdPipelineBarrier_ptr);
			NativeLib.LoadFunction("vkCmdBeginQuery",  out vkCmdBeginQuery_ptr);
			NativeLib.LoadFunction("vkCmdEndQuery",  out vkCmdEndQuery_ptr);
			NativeLib.LoadFunction("vkCmdResetQueryPool",  out vkCmdResetQueryPool_ptr);
			NativeLib.LoadFunction("vkCmdWriteTimestamp",  out vkCmdWriteTimestamp_ptr);
			NativeLib.LoadFunction("vkCmdCopyQueryPoolResults",  out vkCmdCopyQueryPoolResults_ptr);
			NativeLib.LoadFunction("vkCmdPushConstants",  out vkCmdPushConstants_ptr);
			NativeLib.LoadFunction("vkCmdBeginRenderPass",  out vkCmdBeginRenderPass_ptr);
			NativeLib.LoadFunction("vkCmdNextSubpass",  out vkCmdNextSubpass_ptr);
			NativeLib.LoadFunction("vkCmdEndRenderPass",  out vkCmdEndRenderPass_ptr);
			NativeLib.LoadFunction("vkCmdExecuteCommands",  out vkCmdExecuteCommands_ptr);
			NativeLib.LoadFunction("vkEnumerateInstanceVersion",  out vkEnumerateInstanceVersion_ptr);
			NativeLib.LoadFunction("vkBindBufferMemory2",  out vkBindBufferMemory2_ptr);
			NativeLib.LoadFunction("vkBindImageMemory2",  out vkBindImageMemory2_ptr);
			NativeLib.LoadFunction("vkGetDeviceGroupPeerMemoryFeatures",  out vkGetDeviceGroupPeerMemoryFeatures_ptr);
			NativeLib.LoadFunction("vkCmdSetDeviceMask",  out vkCmdSetDeviceMask_ptr);
			NativeLib.LoadFunction("vkCmdDispatchBase",  out vkCmdDispatchBase_ptr);
			NativeLib.LoadFunction("vkEnumeratePhysicalDeviceGroups",  out vkEnumeratePhysicalDeviceGroups_ptr);
			NativeLib.LoadFunction("vkGetImageMemoryRequirements2",  out vkGetImageMemoryRequirements2_ptr);
			NativeLib.LoadFunction("vkGetBufferMemoryRequirements2",  out vkGetBufferMemoryRequirements2_ptr);
			NativeLib.LoadFunction("vkGetImageSparseMemoryRequirements2",  out vkGetImageSparseMemoryRequirements2_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceFeatures2",  out vkGetPhysicalDeviceFeatures2_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceProperties2",  out vkGetPhysicalDeviceProperties2_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceFormatProperties2",  out vkGetPhysicalDeviceFormatProperties2_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceImageFormatProperties2",  out vkGetPhysicalDeviceImageFormatProperties2_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceQueueFamilyProperties2",  out vkGetPhysicalDeviceQueueFamilyProperties2_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceMemoryProperties2",  out vkGetPhysicalDeviceMemoryProperties2_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSparseImageFormatProperties2",  out vkGetPhysicalDeviceSparseImageFormatProperties2_ptr);
			NativeLib.LoadFunction("vkTrimCommandPool",  out vkTrimCommandPool_ptr);
			NativeLib.LoadFunction("vkGetDeviceQueue2",  out vkGetDeviceQueue2_ptr);
			NativeLib.LoadFunction("vkCreateSamplerYcbcrConversion",  out vkCreateSamplerYcbcrConversion_ptr);
			NativeLib.LoadFunction("vkDestroySamplerYcbcrConversion",  out vkDestroySamplerYcbcrConversion_ptr);
			NativeLib.LoadFunction("vkCreateDescriptorUpdateTemplate",  out vkCreateDescriptorUpdateTemplate_ptr);
			NativeLib.LoadFunction("vkDestroyDescriptorUpdateTemplate",  out vkDestroyDescriptorUpdateTemplate_ptr);
			NativeLib.LoadFunction("vkUpdateDescriptorSetWithTemplate",  out vkUpdateDescriptorSetWithTemplate_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceExternalBufferProperties",  out vkGetPhysicalDeviceExternalBufferProperties_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceExternalFenceProperties",  out vkGetPhysicalDeviceExternalFenceProperties_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceExternalSemaphoreProperties",  out vkGetPhysicalDeviceExternalSemaphoreProperties_ptr);
			NativeLib.LoadFunction("vkGetDescriptorSetLayoutSupport",  out vkGetDescriptorSetLayoutSupport_ptr);
			NativeLib.LoadFunction("vkCmdDrawIndirectCount",  out vkCmdDrawIndirectCount_ptr);
			NativeLib.LoadFunction("vkCmdDrawIndexedIndirectCount",  out vkCmdDrawIndexedIndirectCount_ptr);
			NativeLib.LoadFunction("vkCreateRenderPass2",  out vkCreateRenderPass2_ptr);
			NativeLib.LoadFunction("vkCmdBeginRenderPass2",  out vkCmdBeginRenderPass2_ptr);
			NativeLib.LoadFunction("vkCmdNextSubpass2",  out vkCmdNextSubpass2_ptr);
			NativeLib.LoadFunction("vkCmdEndRenderPass2",  out vkCmdEndRenderPass2_ptr);
			NativeLib.LoadFunction("vkResetQueryPool",  out vkResetQueryPool_ptr);
			NativeLib.LoadFunction("vkGetSemaphoreCounterValue",  out vkGetSemaphoreCounterValue_ptr);
			NativeLib.LoadFunction("vkWaitSemaphores",  out vkWaitSemaphores_ptr);
			NativeLib.LoadFunction("vkSignalSemaphore",  out vkSignalSemaphore_ptr);
			NativeLib.LoadFunction("vkGetBufferDeviceAddress",  out vkGetBufferDeviceAddress_ptr);
			NativeLib.LoadFunction("vkGetBufferOpaqueCaptureAddress",  out vkGetBufferOpaqueCaptureAddress_ptr);
			NativeLib.LoadFunction("vkGetDeviceMemoryOpaqueCaptureAddress",  out vkGetDeviceMemoryOpaqueCaptureAddress_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceToolProperties",  out vkGetPhysicalDeviceToolProperties_ptr);
			NativeLib.LoadFunction("vkCreatePrivateDataSlot",  out vkCreatePrivateDataSlot_ptr);
			NativeLib.LoadFunction("vkDestroyPrivateDataSlot",  out vkDestroyPrivateDataSlot_ptr);
			NativeLib.LoadFunction("vkSetPrivateData",  out vkSetPrivateData_ptr);
			NativeLib.LoadFunction("vkGetPrivateData",  out vkGetPrivateData_ptr);
			NativeLib.LoadFunction("vkCmdSetEvent2",  out vkCmdSetEvent2_ptr);
			NativeLib.LoadFunction("vkCmdResetEvent2",  out vkCmdResetEvent2_ptr);
			NativeLib.LoadFunction("vkCmdWaitEvents2",  out vkCmdWaitEvents2_ptr);
			NativeLib.LoadFunction("vkCmdPipelineBarrier2",  out vkCmdPipelineBarrier2_ptr);
			NativeLib.LoadFunction("vkCmdWriteTimestamp2",  out vkCmdWriteTimestamp2_ptr);
			NativeLib.LoadFunction("vkQueueSubmit2",  out vkQueueSubmit2_ptr);
			NativeLib.LoadFunction("vkCmdCopyBuffer2",  out vkCmdCopyBuffer2_ptr);
			NativeLib.LoadFunction("vkCmdCopyImage2",  out vkCmdCopyImage2_ptr);
			NativeLib.LoadFunction("vkCmdCopyBufferToImage2",  out vkCmdCopyBufferToImage2_ptr);
			NativeLib.LoadFunction("vkCmdCopyImageToBuffer2",  out vkCmdCopyImageToBuffer2_ptr);
			NativeLib.LoadFunction("vkCmdBlitImage2",  out vkCmdBlitImage2_ptr);
			NativeLib.LoadFunction("vkCmdResolveImage2",  out vkCmdResolveImage2_ptr);
			NativeLib.LoadFunction("vkCmdBeginRendering",  out vkCmdBeginRendering_ptr);
			NativeLib.LoadFunction("vkCmdEndRendering",  out vkCmdEndRendering_ptr);
			NativeLib.LoadFunction("vkCmdSetCullMode",  out vkCmdSetCullMode_ptr);
			NativeLib.LoadFunction("vkCmdSetFrontFace",  out vkCmdSetFrontFace_ptr);
			NativeLib.LoadFunction("vkCmdSetPrimitiveTopology",  out vkCmdSetPrimitiveTopology_ptr);
			NativeLib.LoadFunction("vkCmdSetViewportWithCount",  out vkCmdSetViewportWithCount_ptr);
			NativeLib.LoadFunction("vkCmdSetScissorWithCount",  out vkCmdSetScissorWithCount_ptr);
			NativeLib.LoadFunction("vkCmdBindVertexBuffers2",  out vkCmdBindVertexBuffers2_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthTestEnable",  out vkCmdSetDepthTestEnable_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthWriteEnable",  out vkCmdSetDepthWriteEnable_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthCompareOp",  out vkCmdSetDepthCompareOp_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthBoundsTestEnable",  out vkCmdSetDepthBoundsTestEnable_ptr);
			NativeLib.LoadFunction("vkCmdSetStencilTestEnable",  out vkCmdSetStencilTestEnable_ptr);
			NativeLib.LoadFunction("vkCmdSetStencilOp",  out vkCmdSetStencilOp_ptr);
			NativeLib.LoadFunction("vkCmdSetRasterizerDiscardEnable",  out vkCmdSetRasterizerDiscardEnable_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthBiasEnable",  out vkCmdSetDepthBiasEnable_ptr);
			NativeLib.LoadFunction("vkCmdSetPrimitiveRestartEnable",  out vkCmdSetPrimitiveRestartEnable_ptr);
			NativeLib.LoadFunction("vkGetDeviceBufferMemoryRequirements",  out vkGetDeviceBufferMemoryRequirements_ptr);
			NativeLib.LoadFunction("vkGetDeviceImageMemoryRequirements",  out vkGetDeviceImageMemoryRequirements_ptr);
			NativeLib.LoadFunction("vkGetDeviceImageSparseMemoryRequirements",  out vkGetDeviceImageSparseMemoryRequirements_ptr);
			NativeLib.LoadFunction("vkGetCommandPoolMemoryConsumption",  out vkGetCommandPoolMemoryConsumption_ptr);
			NativeLib.LoadFunction("vkGetFaultData",  out vkGetFaultData_ptr);
			NativeLib.LoadFunction("vkDestroySurfaceKHR",  out vkDestroySurfaceKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceSupportKHR",  out vkGetPhysicalDeviceSurfaceSupportKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceCapabilitiesKHR",  out vkGetPhysicalDeviceSurfaceCapabilitiesKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceFormatsKHR",  out vkGetPhysicalDeviceSurfaceFormatsKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSurfacePresentModesKHR",  out vkGetPhysicalDeviceSurfacePresentModesKHR_ptr);
			NativeLib.LoadFunction("vkCreateSwapchainKHR",  out vkCreateSwapchainKHR_ptr);
			NativeLib.LoadFunction("vkDestroySwapchainKHR",  out vkDestroySwapchainKHR_ptr);
			NativeLib.LoadFunction("vkGetSwapchainImagesKHR",  out vkGetSwapchainImagesKHR_ptr);
			NativeLib.LoadFunction("vkAcquireNextImageKHR",  out vkAcquireNextImageKHR_ptr);
			NativeLib.LoadFunction("vkQueuePresentKHR",  out vkQueuePresentKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceDisplayPropertiesKHR",  out vkGetPhysicalDeviceDisplayPropertiesKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceDisplayPlanePropertiesKHR",  out vkGetPhysicalDeviceDisplayPlanePropertiesKHR_ptr);
			NativeLib.LoadFunction("vkGetDisplayPlaneSupportedDisplaysKHR",  out vkGetDisplayPlaneSupportedDisplaysKHR_ptr);
			NativeLib.LoadFunction("vkGetDisplayModePropertiesKHR",  out vkGetDisplayModePropertiesKHR_ptr);
			NativeLib.LoadFunction("vkCreateDisplayModeKHR",  out vkCreateDisplayModeKHR_ptr);
			NativeLib.LoadFunction("vkGetDisplayPlaneCapabilitiesKHR",  out vkGetDisplayPlaneCapabilitiesKHR_ptr);
			NativeLib.LoadFunction("vkCreateDisplayPlaneSurfaceKHR",  out vkCreateDisplayPlaneSurfaceKHR_ptr);
			NativeLib.LoadFunction("vkCreateSharedSwapchainsKHR",  out vkCreateSharedSwapchainsKHR_ptr);
			NativeLib.LoadFunction("vkCreateXlibSurfaceKHR",  out vkCreateXlibSurfaceKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceXlibPresentationSupportKHR",  out vkGetPhysicalDeviceXlibPresentationSupportKHR_ptr);
			NativeLib.LoadFunction("vkCreateXcbSurfaceKHR",  out vkCreateXcbSurfaceKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceXcbPresentationSupportKHR",  out vkGetPhysicalDeviceXcbPresentationSupportKHR_ptr);
			NativeLib.LoadFunction("vkCreateWaylandSurfaceKHR",  out vkCreateWaylandSurfaceKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceWaylandPresentationSupportKHR",  out vkGetPhysicalDeviceWaylandPresentationSupportKHR_ptr);
			NativeLib.LoadFunction("vkCreateAndroidSurfaceKHR",  out vkCreateAndroidSurfaceKHR_ptr);
			NativeLib.LoadFunction("vkCreateWin32SurfaceKHR",  out vkCreateWin32SurfaceKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceWin32PresentationSupportKHR",  out vkGetPhysicalDeviceWin32PresentationSupportKHR_ptr);
			NativeLib.LoadFunction("vkCreateDebugReportCallbackEXT",  out vkCreateDebugReportCallbackEXT_ptr);
			NativeLib.LoadFunction("vkDestroyDebugReportCallbackEXT",  out vkDestroyDebugReportCallbackEXT_ptr);
			NativeLib.LoadFunction("vkDebugReportMessageEXT",  out vkDebugReportMessageEXT_ptr);
			NativeLib.LoadFunction("vkDebugMarkerSetObjectTagEXT",  out vkDebugMarkerSetObjectTagEXT_ptr);
			NativeLib.LoadFunction("vkDebugMarkerSetObjectNameEXT",  out vkDebugMarkerSetObjectNameEXT_ptr);
			NativeLib.LoadFunction("vkCmdDebugMarkerBeginEXT",  out vkCmdDebugMarkerBeginEXT_ptr);
			NativeLib.LoadFunction("vkCmdDebugMarkerEndEXT",  out vkCmdDebugMarkerEndEXT_ptr);
			NativeLib.LoadFunction("vkCmdDebugMarkerInsertEXT",  out vkCmdDebugMarkerInsertEXT_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceVideoCapabilitiesKHR",  out vkGetPhysicalDeviceVideoCapabilitiesKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceVideoFormatPropertiesKHR",  out vkGetPhysicalDeviceVideoFormatPropertiesKHR_ptr);
			NativeLib.LoadFunction("vkCreateVideoSessionKHR",  out vkCreateVideoSessionKHR_ptr);
			NativeLib.LoadFunction("vkDestroyVideoSessionKHR",  out vkDestroyVideoSessionKHR_ptr);
			NativeLib.LoadFunction("vkGetVideoSessionMemoryRequirementsKHR",  out vkGetVideoSessionMemoryRequirementsKHR_ptr);
			NativeLib.LoadFunction("vkBindVideoSessionMemoryKHR",  out vkBindVideoSessionMemoryKHR_ptr);
			NativeLib.LoadFunction("vkCreateVideoSessionParametersKHR",  out vkCreateVideoSessionParametersKHR_ptr);
			NativeLib.LoadFunction("vkUpdateVideoSessionParametersKHR",  out vkUpdateVideoSessionParametersKHR_ptr);
			NativeLib.LoadFunction("vkDestroyVideoSessionParametersKHR",  out vkDestroyVideoSessionParametersKHR_ptr);
			NativeLib.LoadFunction("vkCmdBeginVideoCodingKHR",  out vkCmdBeginVideoCodingKHR_ptr);
			NativeLib.LoadFunction("vkCmdEndVideoCodingKHR",  out vkCmdEndVideoCodingKHR_ptr);
			NativeLib.LoadFunction("vkCmdControlVideoCodingKHR",  out vkCmdControlVideoCodingKHR_ptr);
			NativeLib.LoadFunction("vkCmdDecodeVideoKHR",  out vkCmdDecodeVideoKHR_ptr);
			NativeLib.LoadFunction("vkCmdBindTransformFeedbackBuffersEXT",  out vkCmdBindTransformFeedbackBuffersEXT_ptr);
			NativeLib.LoadFunction("vkCmdBeginTransformFeedbackEXT",  out vkCmdBeginTransformFeedbackEXT_ptr);
			NativeLib.LoadFunction("vkCmdEndTransformFeedbackEXT",  out vkCmdEndTransformFeedbackEXT_ptr);
			NativeLib.LoadFunction("vkCmdBeginQueryIndexedEXT",  out vkCmdBeginQueryIndexedEXT_ptr);
			NativeLib.LoadFunction("vkCmdEndQueryIndexedEXT",  out vkCmdEndQueryIndexedEXT_ptr);
			NativeLib.LoadFunction("vkCmdDrawIndirectByteCountEXT",  out vkCmdDrawIndirectByteCountEXT_ptr);
			NativeLib.LoadFunction("vkCreateCuModuleNVX",  out vkCreateCuModuleNVX_ptr);
			NativeLib.LoadFunction("vkCreateCuFunctionNVX",  out vkCreateCuFunctionNVX_ptr);
			NativeLib.LoadFunction("vkDestroyCuModuleNVX",  out vkDestroyCuModuleNVX_ptr);
			NativeLib.LoadFunction("vkDestroyCuFunctionNVX",  out vkDestroyCuFunctionNVX_ptr);
			NativeLib.LoadFunction("vkCmdCuLaunchKernelNVX",  out vkCmdCuLaunchKernelNVX_ptr);
			NativeLib.LoadFunction("vkGetImageViewHandleNVX",  out vkGetImageViewHandleNVX_ptr);
			NativeLib.LoadFunction("vkGetImageViewAddressNVX",  out vkGetImageViewAddressNVX_ptr);
			NativeLib.LoadFunction("vkGetShaderInfoAMD",  out vkGetShaderInfoAMD_ptr);
			NativeLib.LoadFunction("vkCreateStreamDescriptorSurfaceGGP",  out vkCreateStreamDescriptorSurfaceGGP_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceExternalImageFormatPropertiesNV",  out vkGetPhysicalDeviceExternalImageFormatPropertiesNV_ptr);
			NativeLib.LoadFunction("vkGetMemoryWin32HandleNV",  out vkGetMemoryWin32HandleNV_ptr);
			NativeLib.LoadFunction("vkCreateViSurfaceNN",  out vkCreateViSurfaceNN_ptr);
			NativeLib.LoadFunction("vkGetMemoryWin32HandleKHR",  out vkGetMemoryWin32HandleKHR_ptr);
			NativeLib.LoadFunction("vkGetMemoryWin32HandlePropertiesKHR",  out vkGetMemoryWin32HandlePropertiesKHR_ptr);
			NativeLib.LoadFunction("vkGetMemoryFdKHR",  out vkGetMemoryFdKHR_ptr);
			NativeLib.LoadFunction("vkGetMemoryFdPropertiesKHR",  out vkGetMemoryFdPropertiesKHR_ptr);
			NativeLib.LoadFunction("vkImportSemaphoreWin32HandleKHR",  out vkImportSemaphoreWin32HandleKHR_ptr);
			NativeLib.LoadFunction("vkGetSemaphoreWin32HandleKHR",  out vkGetSemaphoreWin32HandleKHR_ptr);
			NativeLib.LoadFunction("vkImportSemaphoreFdKHR",  out vkImportSemaphoreFdKHR_ptr);
			NativeLib.LoadFunction("vkGetSemaphoreFdKHR",  out vkGetSemaphoreFdKHR_ptr);
			NativeLib.LoadFunction("vkCmdPushDescriptorSetKHR",  out vkCmdPushDescriptorSetKHR_ptr);
			NativeLib.LoadFunction("vkCmdBeginConditionalRenderingEXT",  out vkCmdBeginConditionalRenderingEXT_ptr);
			NativeLib.LoadFunction("vkCmdEndConditionalRenderingEXT",  out vkCmdEndConditionalRenderingEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetViewportWScalingNV",  out vkCmdSetViewportWScalingNV_ptr);
			NativeLib.LoadFunction("vkReleaseDisplayEXT",  out vkReleaseDisplayEXT_ptr);
			NativeLib.LoadFunction("vkAcquireXlibDisplayEXT",  out vkAcquireXlibDisplayEXT_ptr);
			NativeLib.LoadFunction("vkGetRandROutputDisplayEXT",  out vkGetRandROutputDisplayEXT_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceCapabilities2EXT",  out vkGetPhysicalDeviceSurfaceCapabilities2EXT_ptr);
			NativeLib.LoadFunction("vkDisplayPowerControlEXT",  out vkDisplayPowerControlEXT_ptr);
			NativeLib.LoadFunction("vkRegisterDeviceEventEXT",  out vkRegisterDeviceEventEXT_ptr);
			NativeLib.LoadFunction("vkRegisterDisplayEventEXT",  out vkRegisterDisplayEventEXT_ptr);
			NativeLib.LoadFunction("vkGetSwapchainCounterEXT",  out vkGetSwapchainCounterEXT_ptr);
			NativeLib.LoadFunction("vkGetRefreshCycleDurationGOOGLE",  out vkGetRefreshCycleDurationGOOGLE_ptr);
			NativeLib.LoadFunction("vkGetPastPresentationTimingGOOGLE",  out vkGetPastPresentationTimingGOOGLE_ptr);
			NativeLib.LoadFunction("vkCmdSetDiscardRectangleEXT",  out vkCmdSetDiscardRectangleEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetDiscardRectangleEnableEXT",  out vkCmdSetDiscardRectangleEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetDiscardRectangleModeEXT",  out vkCmdSetDiscardRectangleModeEXT_ptr);
			NativeLib.LoadFunction("vkSetHdrMetadataEXT",  out vkSetHdrMetadataEXT_ptr);
			NativeLib.LoadFunction("vkGetSwapchainStatusKHR",  out vkGetSwapchainStatusKHR_ptr);
			NativeLib.LoadFunction("vkImportFenceWin32HandleKHR",  out vkImportFenceWin32HandleKHR_ptr);
			NativeLib.LoadFunction("vkGetFenceWin32HandleKHR",  out vkGetFenceWin32HandleKHR_ptr);
			NativeLib.LoadFunction("vkImportFenceFdKHR",  out vkImportFenceFdKHR_ptr);
			NativeLib.LoadFunction("vkGetFenceFdKHR",  out vkGetFenceFdKHR_ptr);
			NativeLib.LoadFunction("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR",  out vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR",  out vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_ptr);
			NativeLib.LoadFunction("vkAcquireProfilingLockKHR",  out vkAcquireProfilingLockKHR_ptr);
			NativeLib.LoadFunction("vkReleaseProfilingLockKHR",  out vkReleaseProfilingLockKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceCapabilities2KHR",  out vkGetPhysicalDeviceSurfaceCapabilities2KHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSurfaceFormats2KHR",  out vkGetPhysicalDeviceSurfaceFormats2KHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceDisplayProperties2KHR",  out vkGetPhysicalDeviceDisplayProperties2KHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceDisplayPlaneProperties2KHR",  out vkGetPhysicalDeviceDisplayPlaneProperties2KHR_ptr);
			NativeLib.LoadFunction("vkGetDisplayModeProperties2KHR",  out vkGetDisplayModeProperties2KHR_ptr);
			NativeLib.LoadFunction("vkGetDisplayPlaneCapabilities2KHR",  out vkGetDisplayPlaneCapabilities2KHR_ptr);
			NativeLib.LoadFunction("vkCreateIOSSurfaceMVK",  out vkCreateIOSSurfaceMVK_ptr);
			NativeLib.LoadFunction("vkCreateMacOSSurfaceMVK",  out vkCreateMacOSSurfaceMVK_ptr);
			NativeLib.LoadFunction("vkSetDebugUtilsObjectNameEXT",  out vkSetDebugUtilsObjectNameEXT_ptr);
			NativeLib.LoadFunction("vkSetDebugUtilsObjectTagEXT",  out vkSetDebugUtilsObjectTagEXT_ptr);
			NativeLib.LoadFunction("vkQueueBeginDebugUtilsLabelEXT",  out vkQueueBeginDebugUtilsLabelEXT_ptr);
			NativeLib.LoadFunction("vkQueueEndDebugUtilsLabelEXT",  out vkQueueEndDebugUtilsLabelEXT_ptr);
			NativeLib.LoadFunction("vkQueueInsertDebugUtilsLabelEXT",  out vkQueueInsertDebugUtilsLabelEXT_ptr);
			NativeLib.LoadFunction("vkCmdBeginDebugUtilsLabelEXT",  out vkCmdBeginDebugUtilsLabelEXT_ptr);
			NativeLib.LoadFunction("vkCmdEndDebugUtilsLabelEXT",  out vkCmdEndDebugUtilsLabelEXT_ptr);
			NativeLib.LoadFunction("vkCmdInsertDebugUtilsLabelEXT",  out vkCmdInsertDebugUtilsLabelEXT_ptr);
			NativeLib.LoadFunction("vkCreateDebugUtilsMessengerEXT",  out vkCreateDebugUtilsMessengerEXT_ptr);
			NativeLib.LoadFunction("vkDestroyDebugUtilsMessengerEXT",  out vkDestroyDebugUtilsMessengerEXT_ptr);
			NativeLib.LoadFunction("vkSubmitDebugUtilsMessageEXT",  out vkSubmitDebugUtilsMessageEXT_ptr);
			NativeLib.LoadFunction("vkGetAndroidHardwareBufferPropertiesANDROID",  out vkGetAndroidHardwareBufferPropertiesANDROID_ptr);
			NativeLib.LoadFunction("vkGetMemoryAndroidHardwareBufferANDROID",  out vkGetMemoryAndroidHardwareBufferANDROID_ptr);
			NativeLib.LoadFunction("vkCmdSetSampleLocationsEXT",  out vkCmdSetSampleLocationsEXT_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceMultisamplePropertiesEXT",  out vkGetPhysicalDeviceMultisamplePropertiesEXT_ptr);
			NativeLib.LoadFunction("vkCreateAccelerationStructureKHR",  out vkCreateAccelerationStructureKHR_ptr);
			NativeLib.LoadFunction("vkDestroyAccelerationStructureKHR",  out vkDestroyAccelerationStructureKHR_ptr);
			NativeLib.LoadFunction("vkCmdBuildAccelerationStructuresKHR",  out vkCmdBuildAccelerationStructuresKHR_ptr);
			NativeLib.LoadFunction("vkCmdBuildAccelerationStructuresIndirectKHR",  out vkCmdBuildAccelerationStructuresIndirectKHR_ptr);
			NativeLib.LoadFunction("vkBuildAccelerationStructuresKHR",  out vkBuildAccelerationStructuresKHR_ptr);
			NativeLib.LoadFunction("vkCopyAccelerationStructureKHR",  out vkCopyAccelerationStructureKHR_ptr);
			NativeLib.LoadFunction("vkCopyAccelerationStructureToMemoryKHR",  out vkCopyAccelerationStructureToMemoryKHR_ptr);
			NativeLib.LoadFunction("vkCopyMemoryToAccelerationStructureKHR",  out vkCopyMemoryToAccelerationStructureKHR_ptr);
			NativeLib.LoadFunction("vkWriteAccelerationStructuresPropertiesKHR",  out vkWriteAccelerationStructuresPropertiesKHR_ptr);
			NativeLib.LoadFunction("vkCmdCopyAccelerationStructureKHR",  out vkCmdCopyAccelerationStructureKHR_ptr);
			NativeLib.LoadFunction("vkCmdCopyAccelerationStructureToMemoryKHR",  out vkCmdCopyAccelerationStructureToMemoryKHR_ptr);
			NativeLib.LoadFunction("vkCmdCopyMemoryToAccelerationStructureKHR",  out vkCmdCopyMemoryToAccelerationStructureKHR_ptr);
			NativeLib.LoadFunction("vkGetAccelerationStructureDeviceAddressKHR",  out vkGetAccelerationStructureDeviceAddressKHR_ptr);
			NativeLib.LoadFunction("vkCmdWriteAccelerationStructuresPropertiesKHR",  out vkCmdWriteAccelerationStructuresPropertiesKHR_ptr);
			NativeLib.LoadFunction("vkGetDeviceAccelerationStructureCompatibilityKHR",  out vkGetDeviceAccelerationStructureCompatibilityKHR_ptr);
			NativeLib.LoadFunction("vkGetAccelerationStructureBuildSizesKHR",  out vkGetAccelerationStructureBuildSizesKHR_ptr);
			NativeLib.LoadFunction("vkCmdTraceRaysKHR",  out vkCmdTraceRaysKHR_ptr);
			NativeLib.LoadFunction("vkCreateRayTracingPipelinesKHR",  out vkCreateRayTracingPipelinesKHR_ptr);
			NativeLib.LoadFunction("vkGetRayTracingShaderGroupHandlesKHR",  out vkGetRayTracingShaderGroupHandlesKHR_ptr);
			NativeLib.LoadFunction("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR",  out vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_ptr);
			NativeLib.LoadFunction("vkCmdTraceRaysIndirectKHR",  out vkCmdTraceRaysIndirectKHR_ptr);
			NativeLib.LoadFunction("vkGetRayTracingShaderGroupStackSizeKHR",  out vkGetRayTracingShaderGroupStackSizeKHR_ptr);
			NativeLib.LoadFunction("vkCmdSetRayTracingPipelineStackSizeKHR",  out vkCmdSetRayTracingPipelineStackSizeKHR_ptr);
			NativeLib.LoadFunction("vkGetImageDrmFormatModifierPropertiesEXT",  out vkGetImageDrmFormatModifierPropertiesEXT_ptr);
			NativeLib.LoadFunction("vkCreateValidationCacheEXT",  out vkCreateValidationCacheEXT_ptr);
			NativeLib.LoadFunction("vkDestroyValidationCacheEXT",  out vkDestroyValidationCacheEXT_ptr);
			NativeLib.LoadFunction("vkMergeValidationCachesEXT",  out vkMergeValidationCachesEXT_ptr);
			NativeLib.LoadFunction("vkGetValidationCacheDataEXT",  out vkGetValidationCacheDataEXT_ptr);
			NativeLib.LoadFunction("vkCmdBindShadingRateImageNV",  out vkCmdBindShadingRateImageNV_ptr);
			NativeLib.LoadFunction("vkCmdSetViewportShadingRatePaletteNV",  out vkCmdSetViewportShadingRatePaletteNV_ptr);
			NativeLib.LoadFunction("vkCmdSetCoarseSampleOrderNV",  out vkCmdSetCoarseSampleOrderNV_ptr);
			NativeLib.LoadFunction("vkCreateAccelerationStructureNV",  out vkCreateAccelerationStructureNV_ptr);
			NativeLib.LoadFunction("vkDestroyAccelerationStructureNV",  out vkDestroyAccelerationStructureNV_ptr);
			NativeLib.LoadFunction("vkGetAccelerationStructureMemoryRequirementsNV",  out vkGetAccelerationStructureMemoryRequirementsNV_ptr);
			NativeLib.LoadFunction("vkBindAccelerationStructureMemoryNV",  out vkBindAccelerationStructureMemoryNV_ptr);
			NativeLib.LoadFunction("vkCmdBuildAccelerationStructureNV",  out vkCmdBuildAccelerationStructureNV_ptr);
			NativeLib.LoadFunction("vkCmdCopyAccelerationStructureNV",  out vkCmdCopyAccelerationStructureNV_ptr);
			NativeLib.LoadFunction("vkCmdTraceRaysNV",  out vkCmdTraceRaysNV_ptr);
			NativeLib.LoadFunction("vkCreateRayTracingPipelinesNV",  out vkCreateRayTracingPipelinesNV_ptr);
			NativeLib.LoadFunction("vkGetAccelerationStructureHandleNV",  out vkGetAccelerationStructureHandleNV_ptr);
			NativeLib.LoadFunction("vkCmdWriteAccelerationStructuresPropertiesNV",  out vkCmdWriteAccelerationStructuresPropertiesNV_ptr);
			NativeLib.LoadFunction("vkCompileDeferredNV",  out vkCompileDeferredNV_ptr);
			NativeLib.LoadFunction("vkGetMemoryHostPointerPropertiesEXT",  out vkGetMemoryHostPointerPropertiesEXT_ptr);
			NativeLib.LoadFunction("vkCmdWriteBufferMarkerAMD",  out vkCmdWriteBufferMarkerAMD_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceCalibrateableTimeDomainsEXT",  out vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_ptr);
			NativeLib.LoadFunction("vkGetCalibratedTimestampsEXT",  out vkGetCalibratedTimestampsEXT_ptr);
			NativeLib.LoadFunction("vkCmdDrawMeshTasksNV",  out vkCmdDrawMeshTasksNV_ptr);
			NativeLib.LoadFunction("vkCmdDrawMeshTasksIndirectNV",  out vkCmdDrawMeshTasksIndirectNV_ptr);
			NativeLib.LoadFunction("vkCmdDrawMeshTasksIndirectCountNV",  out vkCmdDrawMeshTasksIndirectCountNV_ptr);
			NativeLib.LoadFunction("vkCmdSetExclusiveScissorEnableNV",  out vkCmdSetExclusiveScissorEnableNV_ptr);
			NativeLib.LoadFunction("vkCmdSetExclusiveScissorNV",  out vkCmdSetExclusiveScissorNV_ptr);
			NativeLib.LoadFunction("vkCmdSetCheckpointNV",  out vkCmdSetCheckpointNV_ptr);
			NativeLib.LoadFunction("vkGetQueueCheckpointDataNV",  out vkGetQueueCheckpointDataNV_ptr);
			NativeLib.LoadFunction("vkInitializePerformanceApiINTEL",  out vkInitializePerformanceApiINTEL_ptr);
			NativeLib.LoadFunction("vkUninitializePerformanceApiINTEL",  out vkUninitializePerformanceApiINTEL_ptr);
			NativeLib.LoadFunction("vkCmdSetPerformanceMarkerINTEL",  out vkCmdSetPerformanceMarkerINTEL_ptr);
			NativeLib.LoadFunction("vkCmdSetPerformanceStreamMarkerINTEL",  out vkCmdSetPerformanceStreamMarkerINTEL_ptr);
			NativeLib.LoadFunction("vkCmdSetPerformanceOverrideINTEL",  out vkCmdSetPerformanceOverrideINTEL_ptr);
			NativeLib.LoadFunction("vkAcquirePerformanceConfigurationINTEL",  out vkAcquirePerformanceConfigurationINTEL_ptr);
			NativeLib.LoadFunction("vkReleasePerformanceConfigurationINTEL",  out vkReleasePerformanceConfigurationINTEL_ptr);
			NativeLib.LoadFunction("vkQueueSetPerformanceConfigurationINTEL",  out vkQueueSetPerformanceConfigurationINTEL_ptr);
			NativeLib.LoadFunction("vkGetPerformanceParameterINTEL",  out vkGetPerformanceParameterINTEL_ptr);
			NativeLib.LoadFunction("vkSetLocalDimmingAMD",  out vkSetLocalDimmingAMD_ptr);
			NativeLib.LoadFunction("vkCreateImagePipeSurfaceFUCHSIA",  out vkCreateImagePipeSurfaceFUCHSIA_ptr);
			NativeLib.LoadFunction("vkCreateMetalSurfaceEXT",  out vkCreateMetalSurfaceEXT_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceFragmentShadingRatesKHR",  out vkGetPhysicalDeviceFragmentShadingRatesKHR_ptr);
			NativeLib.LoadFunction("vkCmdSetFragmentShadingRateKHR",  out vkCmdSetFragmentShadingRateKHR_ptr);
			NativeLib.LoadFunction("vkWaitForPresentKHR",  out vkWaitForPresentKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV",  out vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV",  out vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSurfacePresentModes2EXT",  out vkGetPhysicalDeviceSurfacePresentModes2EXT_ptr);
			NativeLib.LoadFunction("vkAcquireFullScreenExclusiveModeEXT",  out vkAcquireFullScreenExclusiveModeEXT_ptr);
			NativeLib.LoadFunction("vkReleaseFullScreenExclusiveModeEXT",  out vkReleaseFullScreenExclusiveModeEXT_ptr);
			NativeLib.LoadFunction("vkCreateHeadlessSurfaceEXT",  out vkCreateHeadlessSurfaceEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetLineStippleEXT",  out vkCmdSetLineStippleEXT_ptr);
			NativeLib.LoadFunction("vkCreateDeferredOperationKHR",  out vkCreateDeferredOperationKHR_ptr);
			NativeLib.LoadFunction("vkDestroyDeferredOperationKHR",  out vkDestroyDeferredOperationKHR_ptr);
			NativeLib.LoadFunction("vkGetDeferredOperationMaxConcurrencyKHR",  out vkGetDeferredOperationMaxConcurrencyKHR_ptr);
			NativeLib.LoadFunction("vkGetDeferredOperationResultKHR",  out vkGetDeferredOperationResultKHR_ptr);
			NativeLib.LoadFunction("vkDeferredOperationJoinKHR",  out vkDeferredOperationJoinKHR_ptr);
			NativeLib.LoadFunction("vkGetPipelineExecutablePropertiesKHR",  out vkGetPipelineExecutablePropertiesKHR_ptr);
			NativeLib.LoadFunction("vkGetPipelineExecutableStatisticsKHR",  out vkGetPipelineExecutableStatisticsKHR_ptr);
			NativeLib.LoadFunction("vkGetPipelineExecutableInternalRepresentationsKHR",  out vkGetPipelineExecutableInternalRepresentationsKHR_ptr);
			NativeLib.LoadFunction("vkMapMemory2KHR",  out vkMapMemory2KHR_ptr);
			NativeLib.LoadFunction("vkUnmapMemory2KHR",  out vkUnmapMemory2KHR_ptr);
			NativeLib.LoadFunction("vkReleaseSwapchainImagesEXT",  out vkReleaseSwapchainImagesEXT_ptr);
			NativeLib.LoadFunction("vkGetGeneratedCommandsMemoryRequirementsNV",  out vkGetGeneratedCommandsMemoryRequirementsNV_ptr);
			NativeLib.LoadFunction("vkCmdPreprocessGeneratedCommandsNV",  out vkCmdPreprocessGeneratedCommandsNV_ptr);
			NativeLib.LoadFunction("vkCmdExecuteGeneratedCommandsNV",  out vkCmdExecuteGeneratedCommandsNV_ptr);
			NativeLib.LoadFunction("vkCmdBindPipelineShaderGroupNV",  out vkCmdBindPipelineShaderGroupNV_ptr);
			NativeLib.LoadFunction("vkCreateIndirectCommandsLayoutNV",  out vkCreateIndirectCommandsLayoutNV_ptr);
			NativeLib.LoadFunction("vkDestroyIndirectCommandsLayoutNV",  out vkDestroyIndirectCommandsLayoutNV_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthBias2EXT",  out vkCmdSetDepthBias2EXT_ptr);
			NativeLib.LoadFunction("vkAcquireDrmDisplayEXT",  out vkAcquireDrmDisplayEXT_ptr);
			NativeLib.LoadFunction("vkGetDrmDisplayEXT",  out vkGetDrmDisplayEXT_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR",  out vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_ptr);
			NativeLib.LoadFunction("vkGetEncodedVideoSessionParametersKHR",  out vkGetEncodedVideoSessionParametersKHR_ptr);
			NativeLib.LoadFunction("vkCmdEncodeVideoKHR",  out vkCmdEncodeVideoKHR_ptr);
			NativeLib.LoadFunction("vkCmdRefreshObjectsKHR",  out vkCmdRefreshObjectsKHR_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceRefreshableObjectTypesKHR",  out vkGetPhysicalDeviceRefreshableObjectTypesKHR_ptr);
			NativeLib.LoadFunction("vkExportMetalObjectsEXT",  out vkExportMetalObjectsEXT_ptr);
			NativeLib.LoadFunction("vkGetDescriptorSetLayoutSizeEXT",  out vkGetDescriptorSetLayoutSizeEXT_ptr);
			NativeLib.LoadFunction("vkGetDescriptorSetLayoutBindingOffsetEXT",  out vkGetDescriptorSetLayoutBindingOffsetEXT_ptr);
			NativeLib.LoadFunction("vkGetDescriptorEXT",  out vkGetDescriptorEXT_ptr);
			NativeLib.LoadFunction("vkCmdBindDescriptorBuffersEXT",  out vkCmdBindDescriptorBuffersEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetDescriptorBufferOffsetsEXT",  out vkCmdSetDescriptorBufferOffsetsEXT_ptr);
			NativeLib.LoadFunction("vkCmdBindDescriptorBufferEmbeddedSamplersEXT",  out vkCmdBindDescriptorBufferEmbeddedSamplersEXT_ptr);
			NativeLib.LoadFunction("vkGetBufferOpaqueCaptureDescriptorDataEXT",  out vkGetBufferOpaqueCaptureDescriptorDataEXT_ptr);
			NativeLib.LoadFunction("vkGetImageOpaqueCaptureDescriptorDataEXT",  out vkGetImageOpaqueCaptureDescriptorDataEXT_ptr);
			NativeLib.LoadFunction("vkGetImageViewOpaqueCaptureDescriptorDataEXT",  out vkGetImageViewOpaqueCaptureDescriptorDataEXT_ptr);
			NativeLib.LoadFunction("vkGetSamplerOpaqueCaptureDescriptorDataEXT",  out vkGetSamplerOpaqueCaptureDescriptorDataEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetFragmentShadingRateEnumNV",  out vkCmdSetFragmentShadingRateEnumNV_ptr);
			NativeLib.LoadFunction("vkCmdDrawMeshTasksEXT",  out vkCmdDrawMeshTasksEXT_ptr);
			NativeLib.LoadFunction("vkCmdDrawMeshTasksIndirectEXT",  out vkCmdDrawMeshTasksIndirectEXT_ptr);
			NativeLib.LoadFunction("vkCmdDrawMeshTasksIndirectCountEXT",  out vkCmdDrawMeshTasksIndirectCountEXT_ptr);
			NativeLib.LoadFunction("vkGetImageSubresourceLayout2EXT",  out vkGetImageSubresourceLayout2EXT_ptr);
			NativeLib.LoadFunction("vkGetDeviceFaultInfoEXT",  out vkGetDeviceFaultInfoEXT_ptr);
			NativeLib.LoadFunction("vkAcquireWinrtDisplayNV",  out vkAcquireWinrtDisplayNV_ptr);
			NativeLib.LoadFunction("vkGetWinrtDisplayNV",  out vkGetWinrtDisplayNV_ptr);
			NativeLib.LoadFunction("vkCreateDirectFBSurfaceEXT",  out vkCreateDirectFBSurfaceEXT_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceDirectFBPresentationSupportEXT",  out vkGetPhysicalDeviceDirectFBPresentationSupportEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetVertexInputEXT",  out vkCmdSetVertexInputEXT_ptr);
			NativeLib.LoadFunction("vkGetMemoryZirconHandleFUCHSIA",  out vkGetMemoryZirconHandleFUCHSIA_ptr);
			NativeLib.LoadFunction("vkGetMemoryZirconHandlePropertiesFUCHSIA",  out vkGetMemoryZirconHandlePropertiesFUCHSIA_ptr);
			NativeLib.LoadFunction("vkImportSemaphoreZirconHandleFUCHSIA",  out vkImportSemaphoreZirconHandleFUCHSIA_ptr);
			NativeLib.LoadFunction("vkGetSemaphoreZirconHandleFUCHSIA",  out vkGetSemaphoreZirconHandleFUCHSIA_ptr);
			NativeLib.LoadFunction("vkCreateBufferCollectionFUCHSIA",  out vkCreateBufferCollectionFUCHSIA_ptr);
			NativeLib.LoadFunction("vkSetBufferCollectionImageConstraintsFUCHSIA",  out vkSetBufferCollectionImageConstraintsFUCHSIA_ptr);
			NativeLib.LoadFunction("vkSetBufferCollectionBufferConstraintsFUCHSIA",  out vkSetBufferCollectionBufferConstraintsFUCHSIA_ptr);
			NativeLib.LoadFunction("vkDestroyBufferCollectionFUCHSIA",  out vkDestroyBufferCollectionFUCHSIA_ptr);
			NativeLib.LoadFunction("vkGetBufferCollectionPropertiesFUCHSIA",  out vkGetBufferCollectionPropertiesFUCHSIA_ptr);
			NativeLib.LoadFunction("vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI",  out vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_ptr);
			NativeLib.LoadFunction("vkCmdSubpassShadingHUAWEI",  out vkCmdSubpassShadingHUAWEI_ptr);
			NativeLib.LoadFunction("vkCmdBindInvocationMaskHUAWEI",  out vkCmdBindInvocationMaskHUAWEI_ptr);
			NativeLib.LoadFunction("vkGetMemoryRemoteAddressNV",  out vkGetMemoryRemoteAddressNV_ptr);
			NativeLib.LoadFunction("vkGetPipelinePropertiesEXT",  out vkGetPipelinePropertiesEXT_ptr);
			NativeLib.LoadFunction("vkGetFenceSciSyncFenceNV",  out vkGetFenceSciSyncFenceNV_ptr);
			NativeLib.LoadFunction("vkGetFenceSciSyncObjNV",  out vkGetFenceSciSyncObjNV_ptr);
			NativeLib.LoadFunction("vkImportFenceSciSyncFenceNV",  out vkImportFenceSciSyncFenceNV_ptr);
			NativeLib.LoadFunction("vkImportFenceSciSyncObjNV",  out vkImportFenceSciSyncObjNV_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSciSyncAttributesNV",  out vkGetPhysicalDeviceSciSyncAttributesNV_ptr);
			NativeLib.LoadFunction("vkGetSemaphoreSciSyncObjNV",  out vkGetSemaphoreSciSyncObjNV_ptr);
			NativeLib.LoadFunction("vkImportSemaphoreSciSyncObjNV",  out vkImportSemaphoreSciSyncObjNV_ptr);
			NativeLib.LoadFunction("vkGetMemorySciBufNV",  out vkGetMemorySciBufNV_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV",  out vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceSciBufAttributesNV",  out vkGetPhysicalDeviceSciBufAttributesNV_ptr);
			NativeLib.LoadFunction("vkCmdSetPatchControlPointsEXT",  out vkCmdSetPatchControlPointsEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetLogicOpEXT",  out vkCmdSetLogicOpEXT_ptr);
			NativeLib.LoadFunction("vkCreateScreenSurfaceQNX",  out vkCreateScreenSurfaceQNX_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceScreenPresentationSupportQNX",  out vkGetPhysicalDeviceScreenPresentationSupportQNX_ptr);
			NativeLib.LoadFunction("vkCmdSetColorWriteEnableEXT",  out vkCmdSetColorWriteEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdDrawMultiEXT",  out vkCmdDrawMultiEXT_ptr);
			NativeLib.LoadFunction("vkCmdDrawMultiIndexedEXT",  out vkCmdDrawMultiIndexedEXT_ptr);
			NativeLib.LoadFunction("vkCreateMicromapEXT",  out vkCreateMicromapEXT_ptr);
			NativeLib.LoadFunction("vkDestroyMicromapEXT",  out vkDestroyMicromapEXT_ptr);
			NativeLib.LoadFunction("vkCmdBuildMicromapsEXT",  out vkCmdBuildMicromapsEXT_ptr);
			NativeLib.LoadFunction("vkBuildMicromapsEXT",  out vkBuildMicromapsEXT_ptr);
			NativeLib.LoadFunction("vkCopyMicromapEXT",  out vkCopyMicromapEXT_ptr);
			NativeLib.LoadFunction("vkCopyMicromapToMemoryEXT",  out vkCopyMicromapToMemoryEXT_ptr);
			NativeLib.LoadFunction("vkCopyMemoryToMicromapEXT",  out vkCopyMemoryToMicromapEXT_ptr);
			NativeLib.LoadFunction("vkWriteMicromapsPropertiesEXT",  out vkWriteMicromapsPropertiesEXT_ptr);
			NativeLib.LoadFunction("vkCmdCopyMicromapEXT",  out vkCmdCopyMicromapEXT_ptr);
			NativeLib.LoadFunction("vkCmdCopyMicromapToMemoryEXT",  out vkCmdCopyMicromapToMemoryEXT_ptr);
			NativeLib.LoadFunction("vkCmdCopyMemoryToMicromapEXT",  out vkCmdCopyMemoryToMicromapEXT_ptr);
			NativeLib.LoadFunction("vkCmdWriteMicromapsPropertiesEXT",  out vkCmdWriteMicromapsPropertiesEXT_ptr);
			NativeLib.LoadFunction("vkGetDeviceMicromapCompatibilityEXT",  out vkGetDeviceMicromapCompatibilityEXT_ptr);
			NativeLib.LoadFunction("vkGetMicromapBuildSizesEXT",  out vkGetMicromapBuildSizesEXT_ptr);
			NativeLib.LoadFunction("vkCmdDrawClusterHUAWEI",  out vkCmdDrawClusterHUAWEI_ptr);
			NativeLib.LoadFunction("vkCmdDrawClusterIndirectHUAWEI",  out vkCmdDrawClusterIndirectHUAWEI_ptr);
			NativeLib.LoadFunction("vkSetDeviceMemoryPriorityEXT",  out vkSetDeviceMemoryPriorityEXT_ptr);
			NativeLib.LoadFunction("vkGetDescriptorSetLayoutHostMappingInfoVALVE",  out vkGetDescriptorSetLayoutHostMappingInfoVALVE_ptr);
			NativeLib.LoadFunction("vkGetDescriptorSetHostMappingVALVE",  out vkGetDescriptorSetHostMappingVALVE_ptr);
			NativeLib.LoadFunction("vkCmdCopyMemoryIndirectNV",  out vkCmdCopyMemoryIndirectNV_ptr);
			NativeLib.LoadFunction("vkCmdCopyMemoryToImageIndirectNV",  out vkCmdCopyMemoryToImageIndirectNV_ptr);
			NativeLib.LoadFunction("vkCmdDecompressMemoryNV",  out vkCmdDecompressMemoryNV_ptr);
			NativeLib.LoadFunction("vkCmdDecompressMemoryIndirectCountNV",  out vkCmdDecompressMemoryIndirectCountNV_ptr);
			NativeLib.LoadFunction("vkCmdSetTessellationDomainOriginEXT",  out vkCmdSetTessellationDomainOriginEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthClampEnableEXT",  out vkCmdSetDepthClampEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetPolygonModeEXT",  out vkCmdSetPolygonModeEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetRasterizationSamplesEXT",  out vkCmdSetRasterizationSamplesEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetSampleMaskEXT",  out vkCmdSetSampleMaskEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetAlphaToCoverageEnableEXT",  out vkCmdSetAlphaToCoverageEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetAlphaToOneEnableEXT",  out vkCmdSetAlphaToOneEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetLogicOpEnableEXT",  out vkCmdSetLogicOpEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetColorBlendEnableEXT",  out vkCmdSetColorBlendEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetColorBlendEquationEXT",  out vkCmdSetColorBlendEquationEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetColorWriteMaskEXT",  out vkCmdSetColorWriteMaskEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetRasterizationStreamEXT",  out vkCmdSetRasterizationStreamEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetConservativeRasterizationModeEXT",  out vkCmdSetConservativeRasterizationModeEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetExtraPrimitiveOverestimationSizeEXT",  out vkCmdSetExtraPrimitiveOverestimationSizeEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthClipEnableEXT",  out vkCmdSetDepthClipEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetSampleLocationsEnableEXT",  out vkCmdSetSampleLocationsEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetColorBlendAdvancedEXT",  out vkCmdSetColorBlendAdvancedEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetProvokingVertexModeEXT",  out vkCmdSetProvokingVertexModeEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetLineRasterizationModeEXT",  out vkCmdSetLineRasterizationModeEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetLineStippleEnableEXT",  out vkCmdSetLineStippleEnableEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetDepthClipNegativeOneToOneEXT",  out vkCmdSetDepthClipNegativeOneToOneEXT_ptr);
			NativeLib.LoadFunction("vkCmdSetViewportWScalingEnableNV",  out vkCmdSetViewportWScalingEnableNV_ptr);
			NativeLib.LoadFunction("vkCmdSetViewportSwizzleNV",  out vkCmdSetViewportSwizzleNV_ptr);
			NativeLib.LoadFunction("vkCmdSetCoverageToColorEnableNV",  out vkCmdSetCoverageToColorEnableNV_ptr);
			NativeLib.LoadFunction("vkCmdSetCoverageToColorLocationNV",  out vkCmdSetCoverageToColorLocationNV_ptr);
			NativeLib.LoadFunction("vkCmdSetCoverageModulationModeNV",  out vkCmdSetCoverageModulationModeNV_ptr);
			NativeLib.LoadFunction("vkCmdSetCoverageModulationTableEnableNV",  out vkCmdSetCoverageModulationTableEnableNV_ptr);
			NativeLib.LoadFunction("vkCmdSetCoverageModulationTableNV",  out vkCmdSetCoverageModulationTableNV_ptr);
			NativeLib.LoadFunction("vkCmdSetShadingRateImageEnableNV",  out vkCmdSetShadingRateImageEnableNV_ptr);
			NativeLib.LoadFunction("vkCmdSetRepresentativeFragmentTestEnableNV",  out vkCmdSetRepresentativeFragmentTestEnableNV_ptr);
			NativeLib.LoadFunction("vkCmdSetCoverageReductionModeNV",  out vkCmdSetCoverageReductionModeNV_ptr);
			NativeLib.LoadFunction("vkGetShaderModuleIdentifierEXT",  out vkGetShaderModuleIdentifierEXT_ptr);
			NativeLib.LoadFunction("vkGetShaderModuleCreateInfoIdentifierEXT",  out vkGetShaderModuleCreateInfoIdentifierEXT_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceOpticalFlowImageFormatsNV",  out vkGetPhysicalDeviceOpticalFlowImageFormatsNV_ptr);
			NativeLib.LoadFunction("vkCreateOpticalFlowSessionNV",  out vkCreateOpticalFlowSessionNV_ptr);
			NativeLib.LoadFunction("vkDestroyOpticalFlowSessionNV",  out vkDestroyOpticalFlowSessionNV_ptr);
			NativeLib.LoadFunction("vkBindOpticalFlowSessionImageNV",  out vkBindOpticalFlowSessionImageNV_ptr);
			NativeLib.LoadFunction("vkCmdOpticalFlowExecuteNV",  out vkCmdOpticalFlowExecuteNV_ptr);
			NativeLib.LoadFunction("vkCreateShadersEXT",  out vkCreateShadersEXT_ptr);
			NativeLib.LoadFunction("vkDestroyShaderEXT",  out vkDestroyShaderEXT_ptr);
			NativeLib.LoadFunction("vkGetShaderBinaryDataEXT",  out vkGetShaderBinaryDataEXT_ptr);
			NativeLib.LoadFunction("vkCmdBindShadersEXT",  out vkCmdBindShadersEXT_ptr);
			NativeLib.LoadFunction("vkGetFramebufferTilePropertiesQCOM",  out vkGetFramebufferTilePropertiesQCOM_ptr);
			NativeLib.LoadFunction("vkGetDynamicRenderingTilePropertiesQCOM",  out vkGetDynamicRenderingTilePropertiesQCOM_ptr);
			NativeLib.LoadFunction("vkCreateSemaphoreSciSyncPoolNV",  out vkCreateSemaphoreSciSyncPoolNV_ptr);
			NativeLib.LoadFunction("vkDestroySemaphoreSciSyncPoolNV",  out vkDestroySemaphoreSciSyncPoolNV_ptr);
			NativeLib.LoadFunction("vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR",  out vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_ptr);
			NativeLib.LoadFunction("vkCmdSetAttachmentFeedbackLoopEnableEXT",  out vkCmdSetAttachmentFeedbackLoopEnableEXT_ptr);
			NativeLib.LoadFunction("vkGetScreenBufferPropertiesQNX",  out vkGetScreenBufferPropertiesQNX_ptr);
		}
	}
}
