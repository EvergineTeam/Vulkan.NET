using System;
using System.Runtime.InteropServices;

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
            if (OperatingSystem.IsWindows())
            {
                return "vulkan-1.dll";
            }
            else if (OperatingSystem.IsAndroid())
            {
                return "libvulkan.so";
            }
            else if (OperatingSystem.IsLinux())
            {
                return "libvulkan.so.1";
            }
            else if (OperatingSystem.IsMacOS())
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
