using System;

namespace VulkanGen
{
    class Program
    {
        static void Main(string[] args)
        {
            string vkFile = "..\\..\\..\\..\\..\\..\\KhronosRegistry\\vk.xml";

            var spec = VulkanSpecification.FromFile(vkFile);
        }
    }
}
