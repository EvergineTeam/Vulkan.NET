using System;

namespace WaveEngine.Bindings.Vulkan
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
		ulong VkObject,
		UIntPtr location,
		int messageCode,
		char* pLayerPrefix,
		char* pMessage,
		void* pUserData);

	public unsafe delegate VkBool32 PFN_vkDebugUtilsMessengerCallbackEXT(
		VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity,
		uint messageTypes,
		VkDebugUtilsMessengerCallbackDataEXT* pCallbackData,
		void* pUserData);

}
