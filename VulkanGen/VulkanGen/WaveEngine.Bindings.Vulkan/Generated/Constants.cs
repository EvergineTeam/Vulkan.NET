namespace WaveEngine.Bindings.Vulkan
{
	public static partial class VulkanNative
	{
		public const uint VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256;
		public const uint VK_UUID_SIZE = 16;
		public const uint VK_LUID_SIZE = 8;
		public const uint VK_LUID_SIZE_KHR = VK_LUID_SIZE;
		public const uint VK_MAX_EXTENSION_NAME_SIZE = 256;
		public const uint VK_MAX_DESCRIPTION_SIZE = 256;
		public const uint VK_MAX_MEMORY_TYPES = 32;
		public const uint VK_MAX_MEMORY_HEAPS = 16;
		public const float VK_LOD_CLAMP_NONE = 1000.0f;
		public const uint VK_REMAINING_MIP_LEVELS = (~0U);
		public const uint VK_REMAINING_ARRAY_LAYERS = (~0U);
		public const ulong VK_WHOLE_SIZE = (~0UL);
		public const uint VK_ATTACHMENT_UNUSED = (~0U);
		public const uint VK_TRUE = 1;
		public const uint VK_FALSE = 0;
		public const uint VK_QUEUE_FAMILY_IGNORED = (~0U);
		public const uint VK_QUEUE_FAMILY_EXTERNAL = (~0U-1);
		public const uint VK_QUEUE_FAMILY_EXTERNAL_KHR = VK_QUEUE_FAMILY_EXTERNAL;
		public const uint VK_QUEUE_FAMILY_FOREIGN_EXT = (~0U-2);
		public const uint VK_SUBPASS_EXTERNAL = (~0U);
		public const uint VK_MAX_DEVICE_GROUP_SIZE = 32;
		public const uint VK_MAX_DEVICE_GROUP_SIZE_KHR = VK_MAX_DEVICE_GROUP_SIZE;
		public const uint VK_MAX_DRIVER_NAME_SIZE = 256;
		public const uint VK_MAX_DRIVER_NAME_SIZE_KHR = VK_MAX_DRIVER_NAME_SIZE;
		public const uint VK_MAX_DRIVER_INFO_SIZE = 256;
		public const uint VK_MAX_DRIVER_INFO_SIZE_KHR = VK_MAX_DRIVER_INFO_SIZE;
		public const uint VK_SHADER_UNUSED_KHR = (~0U);
		public const uint VK_SHADER_UNUSED_NV = VK_SHADER_UNUSED_KHR;
	}
}
