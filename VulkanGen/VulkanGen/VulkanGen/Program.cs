using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

namespace VulkanGen
{
    class Program
    {
        static void Main(string[] args)
        {
            string vkFile = "..\\..\\..\\..\\..\\..\\KhronosRegistry\\vk.xml";
            string outputPath = "..\\..\\..\\..\\WaveEngine.Bindings.Vulkan\\Generated";

            var vulkanSpec = VulkanSpecification.FromFile(vkFile);

            // Write Constants
            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Constants.cs")))
            {
                file.WriteLine("namespace WaveEngine.Bindings.Vulkan");
                file.WriteLine("{");
                file.WriteLine("\tpublic static partial class Vulkan");
                file.WriteLine("\t{");

                foreach (var constant in vulkanSpec.Consntants)
                {
                    if (constant.Alias != null)
                    {
                        var refConstant = vulkanSpec.Consntants.FirstOrDefault(c => c.Name == constant.Alias);
                        file.WriteLine($"\t\tpublic const {ConstantDefinition.ToCSharp(refConstant.Type)} {constant.Name} = {refConstant.Name};");
                    }
                    else
                    {
                        file.WriteLine($"\t\tpublic const {ConstantDefinition.ToCSharp(constant.Type)} {constant.Name} = {ConstantDefinition.NormalizeValue(constant.Value)};");
                    }
                }

                file.WriteLine("\t}");
                file.WriteLine("}");
            }
        }
    }
}
