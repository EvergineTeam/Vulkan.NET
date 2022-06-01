// Copyright © Plain Concepts S.L.U. All rights reserved. Use is subject to license terms.

using System;
#if !NET5_0_OR_GREATER
using System.Runtime.InteropServices;
#endif

namespace Evergine.Bindings.Vulkan
{
    internal static class OperatingSystemHelper
    {
        public static bool IsOSPlatform(PlatformType platform)
        {
#if NET5_0_OR_GREATER
            switch (platform)
            {
                case PlatformType.Windows:
                    return OperatingSystem.IsWindows();
                case PlatformType.Linux:
                    return OperatingSystem.IsLinux();
                case PlatformType.Android:
                    return OperatingSystem.IsAndroid();
                case PlatformType.MacOS:
                    return OperatingSystem.IsMacOS();
                case PlatformType.iOS:
                    return OperatingSystem.IsIOS();
                default:
                    return false;
            }
#else
            OSPlatform osPlatform;
            switch (platform)
            {
                case PlatformType.Windows:
                    osPlatform = OSPlatform.Windows;
                    break;
                case PlatformType.Linux:
                case PlatformType.Android:
                    osPlatform = OSPlatform.Linux;
                    break;
                case PlatformType.MacOS:
                case PlatformType.iOS:
                    osPlatform = OSPlatform.OSX;
                    break;
            }

            bool matching = RuntimeInformation.IsOSPlatform(osPlatform);
            if (matching && platform == PlatformType.Android)
            {
                matching = RuntimeInformation.OSDescription.Contains("Unix");
            }
            else if (matching && platform == PlatformType.iOS)
            {
                matching = RuntimeInformation.OSDescription.Contains("Darwin");
            }

            return matching;
#endif
        }

        public static PlatformType GetCurrentPlatfom()
        {
            if (IsOSPlatform(PlatformType.Windows))
            {
                return PlatformType.Windows;
            }
            else if (IsOSPlatform(PlatformType.Android))
            {
                return PlatformType.Android;
            }
            else if (IsOSPlatform(PlatformType.Linux))
            {
                return PlatformType.Linux;
            }
            else if (IsOSPlatform(PlatformType.iOS))
            {
                return PlatformType.iOS;
            }
            else if (IsOSPlatform(PlatformType.MacOS))
            {
                return PlatformType.MacOS;
            }

            return PlatformType.Undefined;
        }

        /// <summary>
        /// Specifies the platform type.
        /// </summary>
        internal enum PlatformType
        {
            /// <summary>
            /// Undefined platform.
            /// </summary>
            Undefined,

            /// <summary>
            /// Microsoft Windows platform.
            /// </summary>
            Windows,

            /// <summary>
            /// Google Android Platform.
            /// </summary>
            Android,

            /// <summary>
            /// Apple iOS platform.
            /// </summary>
            iOS,

            /// <summary>
            /// Linux platform.
            /// </summary>
            Linux,

            /// <summary>
            /// Apple MacOS platform.
            /// </summary>
            MacOS,

            /// <summary>
            /// Universal Windows App
            /// </summary>
            UWP,

            /// <summary>
            /// Web platform.
            /// </summary>
            Web,
        }
    }
}
