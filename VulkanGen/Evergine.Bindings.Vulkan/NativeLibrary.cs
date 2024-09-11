using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using SysNativeLibrary = System.Runtime.InteropServices.NativeLibrary;

namespace Evergine.Bindings.Vulkan
{
    public class NativeLibrary : IDisposable
    {
        private readonly string libraryName;
        private readonly IntPtr libraryHandle;
        internal VkInstance instance;

        public IntPtr NativeHandle => libraryHandle;

        protected NativeLibrary(string libraryName)
        {
            this.libraryName = libraryName;
            libraryHandle = LoadLibrary(this.libraryName);
            if (libraryHandle == IntPtr.Zero)
            {
                throw new InvalidOperationException("Could not load " + libraryName);
            }
        }

        protected IntPtr LoadLibrary(string libraryName)
        {
            if (SysNativeLibrary.TryLoad(libraryName, typeof(NativeLibrary).Assembly, null, out var lib))
            {
                return lib;
            }

            Debug.WriteLine($" ===> Error loading native library {libraryName}");
            return IntPtr.Zero;
        }

        protected void FreeLibrary(IntPtr libraryHandle)
        {
            if (libraryHandle != IntPtr.Zero)
            {
                SysNativeLibrary.Free(libraryHandle);
            }
        }

        public unsafe void LoadFunction<T>(string name, out T field)
        {
            SysNativeLibrary.TryGetExport(libraryHandle, name, out IntPtr funcPtr);
            if (funcPtr == IntPtr.Zero)
            {
                funcPtr = VulkanNative.vkGetInstanceProcAddr(instance, (byte*)Marshal.StringToHGlobalAnsi(name));
            }

            if (funcPtr != IntPtr.Zero)
            {
                field = Marshal.GetDelegateForFunctionPointer<T>(funcPtr);
            }
            else
            {
                field = default(T);
                Debug.WriteLine($" ===> Error loading function {name}");
            }
        }

        public void Dispose()
        {
            FreeLibrary(libraryHandle);
        }

        public static NativeLibrary Load(string libraryName)
        {
            return new NativeLibrary(libraryName);
        }
    }
}
