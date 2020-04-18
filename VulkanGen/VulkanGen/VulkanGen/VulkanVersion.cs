using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulkanGen
{
    public class VulkanVersion
    {
        public List<ConstantDefinition> Constants = new List<ConstantDefinition>();
        public List<FuncpointerDefinition> FuncPointers = new List<FuncpointerDefinition>();
        public List<EnumDefinition> Enums = new List<EnumDefinition>();
        public List<StructureDefinition> Structs = new List<StructureDefinition>();
        public List<StructureDefinition> Unions = new List<StructureDefinition>();
        public List<HandleDefinition> Handles = new List<HandleDefinition>();
        public List<CommandDefinition> Commands = new List<CommandDefinition>();

        public static VulkanVersion FromSpec(VulkanSpecification spec, string versionName, string[] extensions)
        {
            VulkanVersion version = new VulkanVersion();
            version.Constants = spec.Constants;
            version.FuncPointers = spec.FuncPointers;
            version.Handles = spec.Handles;
            version.Unions = spec.Unions;
            version.Structs = spec.Structs;
            version.Enums = spec.Enums;

            for (int i = 0; i < spec.Features.Count; i++)
            {
                FeatureDefinition feature = spec.Features[i];

                // Extend Enums
                foreach (var enumType in feature.Enums)
                {
                    if (enumType.Extends != null  & enumType.Alias == null)
                    {
                        string name = enumType.Extends;
                        var enumDefinition = spec.Enums.Find(c => c.Name == name);

                        EnumValue newValue = new EnumValue();
                        newValue.Name = enumType.Name;
                        newValue.Value = int.Parse(enumType.Value);
                        enumDefinition.Values.Add(newValue);
                    }
                }

                // Add commands
                foreach (var command in feature.Commands)
                {
                    string name = command;
                    if (spec.Alias.TryGetValue(name, out string alias))
                    {
                        name = alias;
                    }

                    var commandDefinition = spec.Commands.Find(c => c.Prototype.Name == name);
                    version.Commands.Add(commandDefinition);
                }

                if (feature.Name == versionName)
                {
                    break;
                }
            }

            return version;
        }
    }
}
