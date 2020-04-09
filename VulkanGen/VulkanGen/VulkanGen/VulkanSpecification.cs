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
        public List<CommandDefinition> Commands = new List<CommandDefinition>();
        public List<FeatureDefinition> Versions = new List<FeatureDefinition>();

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

            // Commands
            var commands = registry.Element("commands").Elements("command");
            foreach (var command in commands)
            {
                spec.Commands.Add(CommandDefinition.FromXML(command));
            }

            return spec;
        }
    }
}
