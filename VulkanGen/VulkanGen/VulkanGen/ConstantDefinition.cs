using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public enum ConstantType
    {
        None,
        UInt32,
        UInt64,
        Float32,
    }

    public class ConstantDefinition
    {
        public string Name;
        public string Value;
        public string Alias;
        public ConstantType Type;
        public string Comment;

        public static ConstantType ParseType(string value)
        {
            if (value.EndsWith("f"))
                return ConstantType.Float32;
            else if (value.EndsWith("ULL)"))
            {
                return ConstantType.UInt64;
            }
            else
            {
                return ConstantType.UInt32;
            }
        }

        public static ConstantDefinition FromXML(XElement elem)
        {
            ConstantDefinition constant = new ConstantDefinition();
            constant.Name = elem.Attribute("name").Value;
            constant.Comment = elem.Attribute("comment")?.Value;
            constant.Alias = elem.Attribute("alias")?.Value;

            if (constant.Alias == null)
            {
                constant.Value = elem.Attribute("value").Value;
                constant.Type = ParseType(constant.Value);
            }

            return constant;
        }

        public static object NormalizeValue(string value)
        {
            return value.Replace("ULL", "UL");
        }
    }
}
