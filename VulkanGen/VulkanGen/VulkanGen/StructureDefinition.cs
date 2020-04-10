using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public class StructureDefinition
    {
        public string Name;
        public bool IsReturnedOnly;
        public List<Member> Members = new List<Member>();

        public static StructureDefinition FromXML(XElement elem)
        {
            StructureDefinition s = new StructureDefinition();
            s.Name = elem.Attribute("name").Value;
            s.IsReturnedOnly = elem.Attribute("returnedonly")?.Value == "true";

            var members = elem.Elements("member");
            foreach (var m in members)
            {
                s.Members.Add(Member.FromXML(m));
            }

            return s;
        }
    }

    public class Member
    {
        public string Name;
        public string Type;
        public int PointerLevel;
        public bool IsOptional;
        public bool IsNoautovalidity;
        public string Comment;
        public int ElementCount;
        public string ConstantValue;
        public string Value;

        public static Member FromXML(XElement elem)
        {
            Member m = new Member();
            m.Name = elem.Element("name").Value;
            m.Type = elem.Element("type").Value;
            m.Comment = elem.Element("comment")?.Value;
            m.IsOptional = elem.Attribute("optional")?.Value == "true";
            m.IsNoautovalidity = elem.Attribute("noautovalidity")?.Value == "true";

            m.Value = elem.Value;
            if (elem.Value.Contains($"{m.Type}**") || elem.Value.Contains($"{m.Type}* const*"))
            {
                m.PointerLevel = 2;
            }
            else if (elem.Value.Contains($"{m.Type}*"))
            {
                m.PointerLevel = 1;
            }

            m.ConstantValue = elem.Element("enum")?.Value;

            if (m.ConstantValue == null)
            {
                Match match = Regex.Match(m.Value, $@"{m.Name}\[(\d+)\](\[(\d+)\])?");
                if (match.Captures.Count > 0)
                {
                    if (match.Groups[2].Value != string.Empty)
                    {
                        string valueString1 = match.Groups[1].Value;
                        string valueString2 = match.Groups[3].Value;
                        m.ElementCount = int.Parse(valueString1) * int.Parse(valueString2);
                    }
                    else
                    {
                        string valueString = match.Groups[1].Value;
                        m.ElementCount = int.Parse(valueString);
                    }
                }
            }

            return m;
        }
    }
}
