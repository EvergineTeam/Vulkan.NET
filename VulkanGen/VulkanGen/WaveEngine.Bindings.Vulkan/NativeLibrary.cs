using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.Vulkan
{
    public abstract class NativeLibrary : IDisposable
    {
        private readonly string libraryName;
        private readonly IntPtr libraryHandle;

        public IntPtr NativeHandle => libraryHandle;

        public NativeLibrary(string libraryName)
        {
            this.libraryName = libraryName;
            libraryHandle = LoadLibrary(this.libraryName);
            if (libraryHandle == IntPtr.Zero)
            {
                throw new InvalidOperationException("Could not load " + libraryName);
            }
        }

        protected abstract IntPtr LoadLibrary(string libraryName);
        protected abstract void FreeLibrary(IntPtr libraryHandle);
        protected abstract IntPtr LoadFunction(string functionName);

        public void LoadFunction<T>(string name, out T field)
        {
            IntPtr funcPtr = LoadFunction(name);
            if (funcPtr != IntPtr.Zero)
            {
                field = Marshal.GetDelegateForFunctionPointer<T>(funcPtr);
            }
            else
            {
                field = default(T);
            }
        }

        public void Dispose()
        {
            FreeLibrary(libraryHandle);
        }


        public static NativeLibrary Load(string libraryName)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return new WindowsNativeLibrary(libraryName);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
                || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return new UnixNativeLibrary(libraryName);
            }
            else
            {
                throw new PlatformNotSupportedException("Cannot load native libraries on this platform: " + RuntimeInformation.OSDescription);
            }
        }

        private class WindowsNativeLibrary : NativeLibrary
        {
            public WindowsNativeLibrary(string libraryName) : base(libraryName)
            {
            }

            protected override IntPtr LoadLibrary(string libraryName)
            {
                return Kernel32.LoadLibrary(libraryName);
            }

            protected override void FreeLibrary(IntPtr libraryHandle)
            {
                Kernel32.FreeLibrary(libraryHandle);
            }

            protected override IntPtr LoadFunction(string functionName)
            {
                Debug.WriteLine("Loading " + functionName);
                return Kernel32.GetProcAddress(NativeHandle, functionName);
            }
        }

        private class UnixNativeLibrary : NativeLibrary
        {
            public UnixNativeLibrary(string libraryName) : base(libraryName)
            {
            }

            protected override IntPtr LoadLibrary(string libraryName)
            {
                Libdl.dlerror();
                IntPtr handle = Libdl.dlopen(libraryName, Libdl.RTLD_NOW);
                if (handle == IntPtr.Zero && !Path.IsPathRooted(libraryName))
                {
                    string baseDir = AppContext.BaseDirectory;
                    if (!string.IsNullOrWhiteSpace(baseDir))
                    {
                        string localPath = Path.Combine(baseDir, libraryName);
                        handle = Libdl.dlopen(localPath, Libdl.RTLD_NOW);
                    }
                }

                return handle;
            }

            protected override void FreeLibrary(IntPtr libraryHandle)
            {
                Libdl.dlclose(libraryHandle);
            }

            protected override IntPtr LoadFunction(string functionName)
            {
                return Libdl.dlsym(NativeHandle, functionName);
            }
        }
    }
}
