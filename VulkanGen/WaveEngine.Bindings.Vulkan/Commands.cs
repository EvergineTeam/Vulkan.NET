using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.Vulkan
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
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "vulkan-1.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.OSDescription.Contains("Unix"))
                {
                    // Android
                    return "libvulkan.so";
                }
                else
                {
                    // Desktop Linux
                    return "libvulkan.so.1";
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
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
