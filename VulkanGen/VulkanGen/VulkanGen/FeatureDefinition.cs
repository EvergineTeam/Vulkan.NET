using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulkanGen
{
    public class FeatureDefinition
    {
        public string Api;
        public string Name;
        public string Number;
        public string Comment;

        public List<ConstantDefinition> Constants = new List<ConstantDefinition>();
        public List<BaseTypeDefinition> BaseTypes = new List<BaseTypeDefinition>();
        public List<StructureDefinition> Structures = new List<StructureDefinition>();
        //public List<StructureDefinition> Unions = new List<StructureDefinition>();
        public List<HandleDefinition> Handles = new List<HandleDefinition>();
        public List<EnumDefinition> Enums = new List<EnumDefinition>();
        public List<CommandDefinition> Commands = new List<CommandDefinition>();
        // BitmaskTypes
        // Extensions
    }
}
