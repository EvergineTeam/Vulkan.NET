using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public class ConstantDefinition
    {
        public string Name;
        public string Value;
        public string Alias;
        public string Type;
        public string Comment;

        public static ConstantDefinition FromXML(XElement elem)
        {
            ConstantDefinition constant = new ConstantDefinition();
            constant.Name = elem.Attribute("name").Value;
            constant.Comment = elem.Attribute("comment")?.Value;
            constant.Alias = elem.Attribute("alias")?.Value;

            if (constant.Alias == null)
            {
                constant.Value = elem.Attribute("value").Value;
                constant.Type = elem.Attribute("type").Value;
            }

            return constant;
        }

        public static object NormalizeValue(string value)
        {
            return value.Replace("ULL", "UL");
        }
    }
}
