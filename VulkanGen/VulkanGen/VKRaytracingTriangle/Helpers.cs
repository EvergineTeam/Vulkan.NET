using System;
using System.Diagnostics;
using WaveEngine.Bindings.Vulkan;

namespace VulkanRaytracing
{
    public unsafe static class Helpers
    {
        public static byte* ToPointer(this string text)
        {
            return (byte*)System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(text);
        }

        public static uint Version(uint major, uint minor, uint patch)
        {
            return (major << 22) | (minor << 12) | patch;
        }

        public static VkMemoryType GetMemoryType(this VkPhysicalDeviceMemoryProperties memoryProperties, uint index)
        {
            return (&memoryProperties.memoryTypes_0)[index];
        }

        public static unsafe string GetString(byte* stringStart)
        {
            int characters = 0;
            while (stringStart[characters] != 0)
            {
                characters++;
            }

            return System.Text.Encoding.UTF8.GetString(stringStart, characters);
        }

        [Conditional("DEBUG")]
        public static void CheckErrors(VkResult result)
        {
            if (result != VkResult.VK_SUCCESS)
            {
                throw new InvalidOperationException(result.ToString());
            }
        }
    }
}
