using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public class VulkanSpecification
    {
        public List<PlatformDefinition> Platforms = new List<PlatformDefinition>();
        public List<TagDefinition> Tags = new List<TagDefinition>();
        public List<ConstantDefinition> Consntants = new List<ConstantDefinition>();
        public List<TypedefDefinition> TypeDefs = new List<TypedefDefinition>();
        public List<EnumDefinition> Enums = new List<EnumDefinition>();
        public List<StructureDefinition> Structs = new List<StructureDefinition>();
        public List<StructureDefinition> Unions = new List<StructureDefinition>();
        public List<HandleDefinition> Handles = new List<HandleDefinition>();
        public List<CommandDefinition> Commands = new List<CommandDefinition>();
        public List<FeatureDefinition> Versions = new List<FeatureDefinition>();
        public List<ExtensionDefinition> Extensions = new List<ExtensionDefinition>();

        public static VulkanSpecification FromFile(string xmlFile)
        {
            XDocument file = XDocument.Load(xmlFile);
            VulkanSpecification spec = new VulkanSpecification();

            var registry = file.Element("registry");

            // Platforms
            var platforms = registry.Element("platforms").Elements("platform");
            foreach (var platform in platforms)
            {
                spec.Platforms.Add(PlatformDefinition.FromXML(platform));
            }

            // Tags
            var tags = registry.Element("tags").Elements("tag");
            foreach (var tag in tags)
            {
                spec.Tags.Add(TagDefinition.FromXML(tag));
            }

            // Constants
            var constants = (registry.Elements("enums").Where(e => e.Attribute("name").Value == "API Constants")).Elements("enum");
            foreach (var c in constants)
            {
                spec.Consntants.Add(ConstantDefinition.FromXML(c));
            }

            // Enums
            var enums = registry.Elements("enums").Where(e => e.Attribute("type")?.Value == "enum" || e.Attribute("type")?.Value == "bitmask");
            foreach (var e in enums)
            {
                spec.Enums.Add(EnumDefinition.FromXML(e));
            }

            // Structs
            var types = registry.Elements("types");
            var structs = types.Elements("type").Where(s => s.Attribute("category")?.Value == "struct");
            foreach (var s in structs)
            {
                spec.Structs.Add(StructureDefinition.FromXML(s));
            }

            // Unions
            var unions = types.Elements("type").Where(u => u.Attribute("category")?.Value == "union");
            foreach (var u in unions)
            {
                spec.Unions.Add(StructureDefinition.FromXML(u));
            }

            // TypeDef
            var typeDefs = types.Elements("type").Where(t => t.Value.Contains("typedef") &&  t.Attribute("category")?.Value == "bitmask");
            foreach (var type in typeDefs)
            {
                spec.TypeDefs.Add(TypedefDefinition.FromXML(type));
            }

            // Handles
            var handles = types.Elements("type").Where(h => h.Attribute("category")?.Value == "handle");
            foreach (var h in handles)
            {
                spec.Handles.Add(HandleDefinition.FromXML(h));
            }

            // Commands
            var commands = registry.Element("commands").Elements("command");
            foreach (var command in commands)
            {
                spec.Commands.Add(CommandDefinition.FromXML(command));
            }

            // Features


            // Extensions
            var extensions = registry.Element("extensions").Elements("extension");
            foreach (var extension in extensions)
            {
                spec.Extensions.Add(ExtensionDefinition.FromXML(extension));
            }

            return spec;
        }
    }
}
