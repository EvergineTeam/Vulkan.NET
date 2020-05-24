using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WaveEngine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        private VkInstance instance;

        string[] validationLayers = new[] { "VK_LAYER_KHRONOS_validation" };

        string[] extensions = new[]
        {
            "VK_KHR_surface",
            "VK_KHR_win32_surface",
            "VK_EXT_debug_utils",
        };

        private void CreateInstance()
        {
#if DEBUG
            if (!this.CheckValidationLayerSupport())
            {
                throw new Exception("Validation layers requested, but not available!");
            }
#endif
            VkApplicationInfo appInfo = new VkApplicationInfo()
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_APPLICATION_INFO,
                pApplicationName = "Hello Triangle".ToPointer(),
                applicationVersion = Helpers.Version(1, 0, 0),
                pEngineName = "No Engine".ToPointer(),
                engineVersion = Helpers.Version(1, 0, 0),
                apiVersion = Helpers.Version(1, 2, 0),
            };

            VkInstanceCreateInfo createInfo = default;
            createInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO;
            createInfo.pApplicationInfo = &appInfo;

            // Extensions
            this.GetAllInstanceExtensionsAvailables();

            IntPtr* extensionsToBytesArray = stackalloc IntPtr[extensions.Length];
            for (int i = 0; i < extensions.Length; i++)
            {
                extensionsToBytesArray[i] = Marshal.StringToHGlobalAnsi(extensions[i]);
            }
            createInfo.enabledExtensionCount = (uint)extensions.Length;
            createInfo.ppEnabledExtensionNames = (byte**)extensionsToBytesArray;

            // Validation layers
#if DEBUG
            IntPtr* layersToBytesArray = stackalloc IntPtr[validationLayers.Length];
            for (int i = 0; i < validationLayers.Length; i++)
            {
                layersToBytesArray[i] = Marshal.StringToHGlobalAnsi(validationLayers[i]);
            }

            createInfo.enabledLayerCount = (uint)validationLayers.Length;
            createInfo.ppEnabledLayerNames = (byte**)layersToBytesArray;
#else
            createInfo.enabledLayerCount = 0;
            createInfo.pNext = null;
#endif

            fixed (VkInstance* instancePtr = &instance)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateInstance(&createInfo, null, instancePtr));
            }
        }

        private void GetAllInstanceExtensionsAvailables()
        {
            uint extensionCount;
            Helpers.CheckErrors(VulkanNative.vkEnumerateInstanceExtensionProperties(null, &extensionCount, null));
            VkExtensionProperties* extensions = stackalloc VkExtensionProperties[(int)extensionCount];
            Helpers.CheckErrors(VulkanNative.vkEnumerateInstanceExtensionProperties(null, &extensionCount, extensions));

            for (int i = 0; i < extensionCount; i++)
            {
                Debug.WriteLine($"Extension: {Helpers.GetString(extensions[i].extensionName)} version: {extensions[i].specVersion}");
            }

            // Return
            //Extension: VK_KHR_device_group_creation version: 1
            //Extension: VK_KHR_external_fence_capabilities version: 1
            //Extension: VK_KHR_external_memory_capabilities version: 1
            //Extension: VK_KHR_external_semaphore_capabilities version: 1
            //Extension: VK_KHR_get_physical_device_properties2 version: 2
            //Extension: VK_KHR_get_surface_capabilities2 version: 1
            //Extension: VK_KHR_surface version: 25
            //Extension: VK_KHR_surface_protected_capabilities version: 1
            //Extension: VK_KHR_win32_surface version: 6
            //Extension: VK_EXT_debug_report version: 9
            //Extension: VK_EXT_debug_utils version: 2
            //Extension: VK_EXT_swapchain_colorspace version: 4
            //Extension: VK_NV_external_memory_capabilities version: 1
        }
    }
}
