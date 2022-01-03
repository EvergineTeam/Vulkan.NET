using System.Windows.Forms;
using Evergine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        const uint WIDTH = 800;
        const uint HEIGHT = 600;       

        private Form window;

        private void InitWindow()
        {
            window = new Form();
            window.Text = "Vulkan Triangle Raytracing (KHR)";
            window.Size = new System.Drawing.Size((int)WIDTH, (int)HEIGHT);
            window.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            window.Show();
        }

        private void InitVulkan()
        {
            this.CreateInstance();

            this.SetupDebugMessenger();

            this.CreateSurface();

            this.PickPhysicalDevice();

            this.CreateLogicalDevice();

            this.CreateSwapChain();

            this.CreateCommandPool();          

            // Begin Raytracing

            this.InitRayTracing();

            this.CreateBottomLevelAS();

            this.CreateTopLevelAS();

            this.CreateOffscreenBuffer();

            this.CreateRTDescriptorSetLayout();

            this.CreateRTDescriptorSet();

            this.CreateRTPipelineLayout();

            this.CreateRTPipeline();

            this.CreateShaderBindingTable();

            // End Raytracing

            this.CreateCommandBuffers();

            this.CreateSemaphores();
        }

        private void MainLoop()
        {
            bool isClosing = false;
            window.FormClosing += (s, e) =>
            {
                isClosing = true;
            };

            while (!isClosing)
            {
                Application.DoEvents();

                this.DrawFrame();
            }

            Helpers.CheckErrors(VulkanNative.vkDeviceWaitIdle(this.device));
        }

        private void CleanUp()
        {
            VulkanNative.vkDestroySemaphore(this.device, this.renderFinishedSemaphore, null);
            VulkanNative.vkDestroySemaphore(this.device, this.imageAvailableSemaphore, null);

            VulkanNative.vkDestroyCommandPool(this.device, this.commandPool, null);

            VulkanNative.vkDestroyAccelerationStructureKHR(this.device, this.bottomLevelAS, null);

            VulkanNative.vkDestroyAccelerationStructureKHR(this.device, this.topLevelAS, null);

            VulkanNative.vkDestroyDescriptorSetLayout(this.device, this.descriptorSetLayout, null);

            VulkanNative.vkDestroyDescriptorPool(this.device, this.descriptorPool, null);

            VulkanNative.vkDestroyPipeline(this.device, this.pipeline, null);

            VulkanNative.vkDestroyPipelineLayout(this.device, this.pipelineLayout, null);

            VulkanNative.vkDestroySwapchainKHR(this.device, this.swapChain, null);

            VulkanNative.vkDestroyDevice(this.device, null);

            this.DestroyDebugMessenger();

            VulkanNative.vkDestroySurfaceKHR(this.instance, this.surface, null);

            VulkanNative.vkDestroyInstance(this.instance, null);

            this.window.Dispose();
            this.window.Close();
        }

        public void Run()
        {
            this.InitWindow();

            this.InitVulkan();

            this.MainLoop();

            this.CleanUp();
        }   
    }
}
