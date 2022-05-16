// Copyright © Plain Concepts S.L.U. All rights reserved. Use is subject to license terms.

using System;
#if !NET5_0_OR_GREATER
using System.Runtime.InteropServices;
#endif

namespace Evergine.Bindings.Vulkan
{
    internal static class OperatingSystemHelper
    {
        public static bool IsOSPlatform(OS platform)
        {
#if NET5_0_OR_GREATER
            switch (platform)
            {
                case OS.Windows:
                    return OperatingSystem.IsWindows();
                case OS.Linux:
                    return OperatingSystem.IsLinux();
                case OS.Android:
                    return OperatingSystem.IsAndroid();
                case OS.MacOS:
                    return OperatingSystem.IsMacOS();
                case OS.iOS:
                    return OperatingSystem.IsIOS();
                default:
                    return false;
            }
#else
            OSPlatform osPlatform;
            switch (platform)
            {
                case OS.Windows:
                    osPlatform = OSPlatform.Windows;
                    break;
                case OS.Linux:
                case OS.Android:
                    osPlatform = OSPlatform.Linux;
                    break;
                case OS.MacOS:
                case OS.iOS:
                    osPlatform = OSPlatform.OSX;
                    break;
            }

            bool matching = RuntimeInformation.IsOSPlatform(osPlatform);
            if (matching && platform == OS.Android)
            {
                matching = RuntimeInformation.OSDescription.Contains("Unix");
            }
            else if (matching && platform == OS.iOS)
            {
                matching = RuntimeInformation.OSDescription.Contains("Darwin");
            }

            return matching;
#endif
        }

        public static OS GetCurrentPlatfom()
        {
            if (IsOSPlatform(OS.Windows))
            {
                return OS.Windows;
            }
            else if (IsOSPlatform(OS.Android))
            {
                return OS.Android;
            }
            else if (IsOSPlatform(OS.Linux))
            {
                return OS.Linux;
            }
            else if (IsOSPlatform(OS.iOS))
            {
                return OS.iOS;
            }
            else if (IsOSPlatform(OS.MacOS))
            {
                return OS.MacOS;
            }

            return OS.Unknown;
        }


        /// <summary>
        /// Operating system enum.
        /// </summary>
        internal enum OS
        {
            /// <summary>
            /// unknown platform
            /// </summary>
            Unknown,

            /// <summary>
            /// Windows platform.
            /// </summary>
            Windows,

            /// <summary>
            /// OSX platform.
            /// </summary>
            Linux,

            /// <summary>
            /// Android platform.
            /// </summary>
            Android,

            /// <summary>
            /// MacOS platform.
            /// </summary>
            MacOS,

            /// <summary>
            /// iOS platform.
            /// </summary>
            iOS,
        }
    }
}
