using System;
using System.Runtime.InteropServices;
using static Evergine.Bindings.Vulkan.OperatingSystemHelper;

namespace Evergine.Bindings.Vulkan
{
    public static unsafe partial class VulkanNative
    {
        private const CallingConvention CallConv = CallingConvention.StdCall;

        public static NativeLibrary NativeLib;

        static VulkanNative()
        {
            NativeLib = LoadNativeLibrary();
            LoadFuncionPointers();
        }

        private static NativeLibrary LoadNativeLibrary()
        {
            return NativeLibrary.Load(GetVulkanName());
        }

        private static string GetVulkanName()
        {
            if (IsOSPlatform(OS.Windows))
            {
                return "vulkan-1.dll";
            }
            else if (IsOSPlatform(OS.Android))
            {
                return "libvulkan.so";
            }
            else if (IsOSPlatform(OS.Linux))
            {
                return "libvulkan.so.1";
            }
            else if (IsOSPlatform(OS.MacOS))
            {
                return "libvulkan.dylib";
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }
    }
}
