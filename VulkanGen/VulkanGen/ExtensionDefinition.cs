using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public class ExtensionDefinition
    {
        public string Name;
        public int Number;
        public string Type;
        public string[] Requires;
        public string Author;
        public string Contact;
        public string Platform;
        public string Supported;
        public bool IsProvisional;
        public int SortOrder;
        public string Comment;

        public List<EnumExtension> Enums = new List<EnumExtension>();
        public List<ConstantExtension> Constants = new List<ConstantExtension>();
        public List<string> Types = new List<string>();
        public List<string> Commands = new List<string>();

        public static ExtensionDefinition FromXML(XElement elem)
        {
            ExtensionDefinition extension = new ExtensionDefinition();
            extension.Name = elem.Attribute("name").Value;
            extension.Number = int.Parse(elem.Attribute("number").Value);
            extension.Type = elem.Attribute("type")?.Value;
            extension.Requires = elem.Attribute("requires")?.Value.Split(',');
            extension.Author = elem.Attribute("author")?.Value;
            extension.Contact = elem.Attribute("contact")?.Value;
            extension.Platform = elem.Attribute("platform")?.Value;
            extension.Supported = elem.Attribute("supported")?.Value;
            extension.IsProvisional = elem.Attribute("provisional")?.Value == "true";
            extension.Comment = elem.Attribute("comment")?.Value;
            string sortString = elem.Attribute("sortorder")?.Value;
            if (sortString != null)
            {
                extension.SortOrder = int.Parse(sortString);
            }

            var requires = elem.Element("require");
            if (requires != null)
            {
                var enums = requires.Elements("enum");
                foreach (var e in enums)
                {
                    string enumName = e.Attribute("name").Value;
                    string extends = e.Attribute("extends")?.Value;
                    if (extends != null)
                    {
                        string valueString;
                        string alias = null;
                        string offsetString = e.Attribute("offset")?.Value;
                        if (offsetString != null)
                        {
                            int offset = int.Parse(offsetString);
                            int direction = 1;
                            if (e.Attribute("dir")?.Value == "-")
                            {
                                direction = -1;
                            }

                            string extstring = e.Attribute("extnumber")?.Value;
                            int extNumber = extension.Number;
                            if (extstring != null)
                            {
                                extNumber = int.Parse(extstring);
                            }

                            int value = direction * (1000000000 + (extNumber - 1) * 1000 + offset);
                            valueString = value.ToString();
                        }
                        else
                        {
                            string bitPosString = e.Attribute("bitpos")?.Value;
                            if (bitPosString != null)
                            {
                                int shift = int.Parse(bitPosString);
                                valueString = (1 << shift).ToString();
                            }
                            else
                            {
                                alias = e.Attribute("alias")?.Value;
                                valueString = e.Attribute("value")?.Value;
                            }
                        }

                        extension.Enums.Add(new EnumExtension() { Extends = extends, Name = enumName, Value = valueString, Alias = alias });
                    }
                    else
                    {
                        ConstantExtension constant = new ConstantExtension();
                        constant.Name = enumName;
                        constant.Alias = e.Attribute("alias")?.Value;
                        string rawValue = e.Attribute("value")?.Value;
                        if (rawValue != null)
                            constant.Value = FilterString(rawValue);

                        extension.Constants.Add(constant);
                    }
                }

                var types = requires.Elements("type");
                foreach (var t in types)
                {
                    string name = t.Attribute("name").Value;
                    extension.Types.Add(name);
                }

                var commands = requires.Elements("command");
                foreach (var command in commands)
                {
                    string name = command.Attribute("name").Value;
                    extension.Commands.Add(name);
                }
            }

            return extension;
        }

        private static string FilterString(string value)
        {
            return value.Replace("&quot;", "");
        }
    }

    public class EnumExtension
    {
        public string Name;
        public string Extends;
        public string Value;
        public string Alias;
    }

    public class ConstantExtension
    {
        public string Name;
        public string Value;
        public string Alias;
    }
}
