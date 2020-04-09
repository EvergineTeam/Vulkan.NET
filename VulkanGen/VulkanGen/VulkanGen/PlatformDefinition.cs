using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public class PlatformDefinition
    {
        public string Name;
        public string Protect;
        public string Comment;

        public static PlatformDefinition FromXML(XElement elem)
        {
            PlatformDefinition platform = new PlatformDefinition();
            platform.Name = elem.Attribute("name").Value;
            platform.Protect = elem.Attribute("protect").Value;
            platform.Comment = elem.Attribute("comment").Value;

            return platform;
        }
    }
}
