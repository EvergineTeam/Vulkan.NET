using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VulkanGen
{
    public class CommandDefinition
    {
        public Proto Prototype;
        public List<Param> Parameters = new List<Param>();
        public string[] Queues;
        public string RenderPass;
        public string[] CmdBufferLevel;
        public string Pipeline;
        public string[] SuccessCodes;
        public string[] ErrorCodes;
        public string Comment;

        public  static CommandDefinition FromXML(XElement elem)
        {
            CommandDefinition command = new CommandDefinition();

            command.SuccessCodes = elem.Attribute("successcodes")?.Value.Split(',');
            command.ErrorCodes = elem.Attribute("errorcodes")?.Value.Split(',');
            command.Queues = elem.Attribute("queues")?.Value.Split(',');
            command.RenderPass = elem.Attribute("renderpass")?.Value;
            command.Pipeline = elem.Attribute("pipeline")?.Value;
            command.CmdBufferLevel = elem.Attribute("cmdbufferlevel")?.Value.Split(',');
            command.Comment = elem.Attribute("comment")?.Value;

            var proto = elem.Element("proto");

            if (proto != null)
            {
                command.Prototype = new Proto
                {
                    Name = proto.Element("name").Value,
                    Type = proto.Element("type").Value,
                };
            }

            var parameters = elem.Elements("param");
            foreach (var param in parameters)
            {
                command.Parameters.Add(Param.FromXML(param));
            }

            return command;
        }

        public string GetParametersSignature(VulkanSpecification spec, bool useTypes = true)
        {
            StringBuilder signature = new StringBuilder();
            foreach (var p in Parameters)
            {
                // Avoid Vulkan Safety Critical
                if (Helpers.IsVKSC(p.Api))
                {
                    continue;
                }

                string convertedType = Helpers.GetPrettyEnumName(Helpers.ConvertToCSharpType(p.Type, p.PointerLevel, spec));
                string convertedName = Helpers.ValidatedName(p.Name);

                if (useTypes)
                    signature.Append($"{convertedType} ");

                signature.Append($"{convertedName}, ");
            }

            signature.Length -= 2;

            return signature.ToString();
        }
    }

    public class Proto
    {
        public string Type;
        public string Name;
    }

    public class Param
    {
        public string Type;
        public string Name;
        public string Api;
        public int PointerLevel;
        public bool IsOptional;
        public string Externsync;
        public string Len;
        public bool IsNoautovalidity;

        internal static Param FromXML(XElement elem)
        {
            Param p = new Param();
            p.Type = elem.Element("type").Value;
            p.Name = elem.Element("name").Value;
            p.Api = elem.Attribute("api")?.Value;
            p.Externsync = elem.Attribute("externsync")?.Value;
            p.Len = elem.Attribute("len")?.Value;
            p.IsNoautovalidity = elem.Attribute("noautovalidity")?.Value == "true";
            p.IsOptional = elem.Attribute("optional")?.Value == "true";

            if (elem.Value.Contains($"{p.Type}**") || elem.Value.Contains($"{p.Type}* const*"))
            {
                p.PointerLevel = 2;
            }
            else if (elem.Value.Contains($"{p.Type}*"))
            {
                p.PointerLevel = 1;
            }

            return p;
        }
    }
}
