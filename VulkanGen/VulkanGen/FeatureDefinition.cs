using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public class FeatureDefinition
    {
        public string Api;
        public string Name;
        public string Number;
        public string Comment;

        public List<EnumFeature> Enums = new List<EnumFeature>();
        public List<ConstantFeature> Constants = new List<ConstantFeature>();
        public List<string> Types = new List<string>();
        public List<string> Commands = new List<string>();

        public static FeatureDefinition FromXML(XElement elem)
        {
            FeatureDefinition feature = new FeatureDefinition();
            feature.Name = elem.Attribute("name").Value;
            feature.Number = elem.Attribute("number").Value;
            feature.Api = elem.Attribute("api").Value;
            feature.Comment = elem.Attribute("comment")?.Value;

            var requires = elem.Elements("require");
            foreach (var require in requires)
            {
                var enums = require.Elements("enum");
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
                            int extNumber = int.Parse(e.Attribute("extnumber").Value);
                            int offset = int.Parse(offsetString);
                            int direction = 1;
                            if (e.Attribute("dir")?.Value == "-")
                            {
                                direction = -1;
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

                        feature.Enums.Add(new EnumFeature() { Extends = extends, Name = enumName, Value = valueString, Alias = alias });
                    }
                    else
                    {
                        ConstantFeature constant = new ConstantFeature();
                        constant.Name = enumName;
                        constant.Alias = e.Attribute("alias")?.Value;
                        constant.Value = e.Attribute("value")?.Value;

                        feature.Constants.Add(constant);
                    }
                }

                var types = require.Elements("type");
                foreach (var t in types)
                {
                    string name = t.Attribute("name").Value;
                    feature.Types.Add(name);
                }

                var commands = require.Elements("command");
                foreach (var command in commands)
                {
                    string name = command.Attribute("name").Value;
                    feature.Commands.Add(name);
                }
            }

            return feature;
        }

        public class EnumFeature
        {
            public string Name;
            public string Extends;
            public string Value;
            public string Alias;
        }

        public class ConstantFeature

        {
            public string Name;
            public string Value;
            public string Alias;
        }
    }
}
