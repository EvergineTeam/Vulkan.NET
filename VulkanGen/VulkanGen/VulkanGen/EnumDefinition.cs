using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public enum EnumType
    {
        Enum,
        Bitmask,
    }

    public class EnumDefinition
    {
        public string Name;
        public EnumType Type;
        public List<EnumValue> Values = new List<EnumValue>();

        public static EnumDefinition FromXML(XElement elem)
        {
            EnumDefinition enums = new EnumDefinition();
            enums.Name = elem.Attribute("name").Value;
            enums.Type = elem.Attribute("type").Value == "enum" ? EnumType.Enum : EnumType.Bitmask;
            var values = elem.Elements("enum");
            foreach (var v in values)
            {
                enums.Values.Add(EnumValue.FromXML(v));
            }

            return enums;
        }
    }

    public class EnumValue
    {
        public string Name;
        public string Alias;
        public int Value;
        public string Comment;

        internal static EnumValue FromXML(XElement elem)
        {
            EnumValue enumValue = new EnumValue();
            enumValue.Name = elem.Attribute("name").Value;
            enumValue.Comment = elem.Attribute("comment")?.Value;
            enumValue.Alias = elem.Attribute("alias")?.Value;

            string valueString = elem.Attribute("value")?.Value;
            if (valueString != null)
            {
                if (valueString.StartsWith("0x"))
                {
                    valueString = valueString.Substring(2);
                    enumValue.Value = int.Parse(valueString, System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    enumValue.Value = int.Parse(valueString);
                }
            }
            else if(enumValue.Alias == null)
            {
                string bitpos = elem.Attribute("bitpos").Value;
                enumValue.Value = 1 << int.Parse(bitpos);
            }

            return enumValue;
        }
    }
}
