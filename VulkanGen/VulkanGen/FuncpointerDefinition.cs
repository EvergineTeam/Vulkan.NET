using System.Collections.Generic;
using System.Xml.Linq;

namespace VulkanGen
{
    public class FuncpointerDefinition
    {
        public string Name;
        public string Type;
        public List<Parameter> Parameters = new List<Parameter>();

        public static FuncpointerDefinition FromXML(XElement elem)
        {
            FuncpointerDefinition funcpointer = new FuncpointerDefinition();

            var proto = elem.Element("proto");
            funcpointer.Name = proto.Element("name").Value;

            var protoTypeElem = proto.Element("type");
            funcpointer.Type = protoTypeElem.Value;
            if (protoTypeElem.NextNode is XText protoNextText && protoNextText.Value.Contains("*"))
            {
                funcpointer.Type += "*";
            }

            foreach (var paramElem in elem.Elements("param"))
            {
                Parameter p = new Parameter();

                var typeElem = paramElem.Element("type");
                p.Type = typeElem.Value;
                if (typeElem.NextNode is XText nextText && nextText.Value.Contains("*"))
                {
                    p.Type += "*";
                }

                p.Name = paramElem.Element("name").Value;
                funcpointer.Parameters.Add(p);
            }

            return funcpointer;
        }
    }

    public class Parameter
    {
        public string Type;
        public string Name;
    }
}
