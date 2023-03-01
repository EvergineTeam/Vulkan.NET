using System;

namespace Evergine.Bindings.Vulkan
{
	public unsafe delegate void PFN_vkInternalAllocationNotification(
		void* pUserData,
		UIntPtr size,
		VkInternalAllocationType allocationType,
		VkSystemAllocationScope allocationScope);

	public unsafe delegate void PFN_vkInternalFreeNotification(
		void* pUserData,
		UIntPtr size,
		VkInternalAllocationType allocationType,
		VkSystemAllocationScope allocationScope);

	public unsafe delegate void* PFN_vkReallocationFunction(
		void* pUserData,
		void* pOriginal,
		UIntPtr size,
		UIntPtr alignment,
		VkSystemAllocationScope allocationScope);

	public unsafe delegate void* PFN_vkAllocationFunction(
		void* pUserData,
		UIntPtr size,
		UIntPtr alignment,
		VkSystemAllocationScope allocationScope);

	public unsafe delegate void PFN_vkFreeFunction(
		void* pUserData,
		void* pMemory);

	public unsafe delegate void PFN_vkVoidFunction();

	public unsafe delegate VkBool32 PFN_vkDebugReportCallbackEXT(
		uint flags,
		VkDebugReportObjectTypeEXT objectType,
		ulong vkObject,
		UIntPtr location,
		int messageCode,
		byte* pLayerPrefix,
		byte* pMessage,
		void* pUserData);

	public unsafe delegate VkBool32 PFN_vkDebugUtilsMessengerCallbackEXT(
		VkDebugUtilsMessageSeverityFlagsEXT messageSeverity,
		uint messageTypes,
		VkDebugUtilsMessengerCallbackDataEXT* pCallbackData,
		void* pUserData);

	public unsafe delegate void PFN_vkFaultCallbackFunction(
		VkBool32 unrecordedFaults,
		uint faultCount,
		VkFaultData* pFaults);

	public unsafe delegate void PFN_vkDeviceMemoryReportCallbackEXT(
		VkDeviceMemoryReportCallbackDataEXT* pCallbackData,
		void* pUserData);

	public unsafe delegate PFN_vkVoidFunction PFN_vkGetInstanceProcAddrLUNARG(
		VkInstance instance,
		byte* pName);

}
