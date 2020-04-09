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
        bitmask,
        Constants,
    }

    public class EnumDefinition
    {
        public string Name;
        public EnumType Type;
        public List<EnumValue> Enums = new List<EnumValue>();

        public EnumDefinition Clone()
        {
            return new EnumDefinition
            {
                Name = Name,
                Type = Type,
                Enums = (from p in Enums select new EnumValue { Name = p.Name, ShortName = p.ShortName, Value = p.Value }).ToList()
            };
        }
    }

    public class EnumValue
    {
        public string Name;
        public string ShortName;
        public string Value;


        public void Initialize(XDocument specDoc, string enumName)
        {
            Name = enumName;
            ShortName = ComputeShortName(enumName);

            ////foreach (var enumElements in specDoc.Root.Elements("enums"))
            ////{
            ////    foreach (var enumElem in enumElements.Elements("enum"))
            ////    {

            ////    }
            ////}
        }

        private string ComputeShortName(string enumName)
        {
            string result = string.Empty;
            string lowername = enumName.ToLower();
            var strings = lowername.Split('_');

            for (int i = 1; i < strings.Length; i++)
            {
                string temp = strings[i];
                result += char.ToUpper(temp[0]) + temp.Substring(1);
            }

            return result;
        }
    }
}
