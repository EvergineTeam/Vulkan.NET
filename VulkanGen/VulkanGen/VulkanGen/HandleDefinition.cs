using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public class HandleDefinition
    {
        public string Name;
        public bool Dispatchable;
        public string Parent;
        public string Alias;

        internal static HandleDefinition FromXML(XElement elem)
        {
            HandleDefinition handle = new HandleDefinition();
            handle.Alias = elem.Attribute("alias")?.Value;

            if (handle.Alias != null)
            {
                handle.Name = elem.Attribute("name").Value;
            }
            else
            {
                handle.Name = elem.Element("name").Value;
                handle.Dispatchable = elem.Element("type")?.Value == "VK_DEFINE_HANDLE";
                handle.Parent = elem.Attribute("parent")?.Value;
            }

            return handle;
        }
    }
}
