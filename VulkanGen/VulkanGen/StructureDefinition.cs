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

        public static int GetSizeInBytes(StructureDefinition s, VulkanVersion vulkanVersion)
        {
            int size = 0;
            foreach(var member in s.Members)
            {
                int multiply = 1;
                if (member.ElementCount > 0)
                {
                    multiply = member.ElementCount;
                }

                size += Member.GetSizeInBytes(member, vulkanVersion) * multiply;
            }

            return size;
        }
    }

    public class Member
    {
        public string Name;
        public string Type;
        public string Api;
        public int PointerLevel;
        public bool IsOptional;
        public bool IsNoautovalidity;
        public string Comment;
        public int ElementCount;
        public string ConstantValue;
        public string Value;
        public int? ExplicityLayoutValue;

        public static Member FromXML(XElement elem)
        {
            Member m = new Member();
            m.Name = elem.Element("name").Value;
            m.Type = elem.Element("type").Value;
            m.Api = elem.Attribute("api")?.Value;
            m.Comment = elem.Element("comment")?.Value;
            m.IsOptional = elem.Attribute("optional")?.Value == "true";
            m.IsNoautovalidity = elem.Attribute("noautovalidity")?.Value == "true";

            m.Value = elem.Value;

            Match layouts = Regex.Match(m.Value, $@":(\d+)");
            if (layouts.Groups.Count > 1)
            {
                m.ExplicityLayoutValue = int.Parse(layouts.Groups[1].Value);
            }

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

        public static int GetSizeInBytes(Member m, VulkanVersion vulkanVersion)
        {
            if (m.ExplicityLayoutValue.HasValue)
            {
                return m.ExplicityLayoutValue.Value / 8;
            }
            else
            {
                switch (m.Type)
                {
                    case "int8_t":
                    case "int8_t*":
                    case "uint8_t":
                    case "char":
                    case "uint8_t*":
                    case "char*":
                        return 1;
                    case "uint16_t":
                    case "uint16_t*":
                    case "int16_t":
                    case "int16_t*":
                        return 2;
                    case "uint32_t":
                    case "DWORD":
                    case "uint32_t*":
                    case "int32_t":
                    case "int32_t*":
                    case "size_t":
                    case "float":
                    case "float*":
                        return 4;
                    case "uint64_t":
                    case "uint64_t*":
                    case "int64_t":
                    case "int64_t*":
                    case "double":
                    case "double*":
                    case "void":
                        return 8;
                    case "VkBool32":
                        return 4;
                    case "VkExtent2D":
                    case "VkOffset2D":
                        return 8;
                    case "VkRect2D":
                        return 16;
                    default:
                        var @struct = vulkanVersion.Structs.Find(s => s.Name == m.Type);

                        if (@struct != null) // structs
                        {
                            return StructureDefinition.GetSizeInBytes(@struct, vulkanVersion);
                        }
                        else
                        {
                            return 4; // enums
                        }
                }
            }
        }
    }
}
