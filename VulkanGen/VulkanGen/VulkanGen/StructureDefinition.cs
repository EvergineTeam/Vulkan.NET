using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulkanGen
{
    public class StructureDefinition
    {
        public string Name;
        public List<Member> Members = new List<Member>();
    }

    public class Member
    {
        public string Name;
        public string Type;
        public bool IsOptional;
        public string Comment;
    }
}
