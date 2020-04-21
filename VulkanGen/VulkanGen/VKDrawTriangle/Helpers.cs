using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveEngine.Bindings.Vulkan;

namespace VKDrawTriangle
{
    public static class Helpers
    {
        public static uint Version(uint major, uint minor, uint patch)
        {
            return (major << 22) | (minor << 12) | patch;
        }

        public unsafe static byte* ToPointer(this string text)
        {
            return (byte*)System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(text);
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
