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
            LoadFunctionPointers();
        }

        private static NativeLibrary LoadNativeLibrary()
        {
            return NativeLibrary.Load(GetVulkanNames());
        }

        private static string[] GetVulkanNames()
        {
            if (OperatingSystem.IsWindows())
            {
                return new[] { "vulkan-1.dll" };
            }
            else if (OperatingSystem.IsAndroid())
            {
                return new[] { "libvulkan.so" };
            }
            else if (OperatingSystem.IsLinux())
            {
                return new[] { "libvulkan.so.1", "libvulkan.so" };
            }
            else if (OperatingSystem.IsMacOS())
            {
                return new[] { "libvulkan.dylib", "libMoltenVK.dylib" };
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }
    }
}
