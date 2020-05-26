using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public class TagDefinition
    {
        public string Name;
        public string Author;
        public string Contact;

        public static TagDefinition FromXML(XElement elem)
        {
            TagDefinition tag = new TagDefinition();
            tag.Name = elem.Attribute("name").Value;
            tag.Author = elem.Attribute("author").Value;
            tag.Contact = elem.Attribute("contact").Value;

            return tag;
        }
    }
}
