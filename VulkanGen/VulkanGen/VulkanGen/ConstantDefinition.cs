using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulkanGen
{
    public enum ConstantType
    {
        UInt32,
        UInt64,
        Float32,
    }

    public class ConstantDefinition
    {
        public string Name;
        public string Value;
        public ConstantType type;
        public string Comment;

        private ConstantType ParseType(string value)
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
    }
}
