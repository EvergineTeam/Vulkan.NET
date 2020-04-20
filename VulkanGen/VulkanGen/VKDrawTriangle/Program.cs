using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKDrawTriangle
{
    class Program
    {
        static Form window;
        static VulkanRenderer renderer;

        static void Main(string[] args)
        {
            window = new Form();
            window.Text = "VK drawing a triangle";
            window.Size = new System.Drawing.Size(800, 600);
            window.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            window.Show();

            renderer = new VulkanRenderer();
            renderer.InitVulkan(window.Handle, window.Width, window.Height);

            bool isClosing = false;
            window.FormClosing += (s, e) =>
            {
                isClosing = true;
            };

            while (!isClosing)
            {
                renderer.DrawFrame();
                System.Windows.Forms.Application.DoEvents();
            }

            renderer.CleanUp();
        }

    }
}
