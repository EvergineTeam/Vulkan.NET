using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulkanGen
{
    public static class Helpers
    {
        public static string ToCSharp(this ConstantType type)
        {
            switch (type)
            {
                case ConstantType.UInt32:
                    return "uint";
                case ConstantType.UInt64:
                    return "ulong";
                case ConstantType.Float32:
                    return "float";
                default:
                    throw new InvalidOperationException("Invalid value");
            }
        }

        public static uint GetTypeSize(string type)
        {
            if (type == "char" || type == "uint8_t")
                return 1;

            // uint32_t, uint64_t, int32_t, int64_t, int64_t*, size_t, DWORD
            return 4;
        }

        public static string ConvertToCSharpType(Member member)
        {
            string result = string.Empty;

            if (member.Type.StartsWith("PFN") || member.Type == "size_t")
                return "IntPtr";

            switch (member.Type)
            {
                case "uint8_t":
                case "char":
                    result = "byte";
                    break;
                case "uint32_t":
                case "DWORD":
                    result = "uint";
                    break;
                case "uint64_t":
                    result = "ulong";
                    break;
                case "int32_t":
                    result = "int";
                    break;
                case "int64_t":
                case "int64_t*":
                    result = "long";
                    break;
                case "size_t":
                    result = "UIntPtr";
                    break;
                case "float":
                    result = "float";
                    break;
                case "void":
                    result = "void";
                    break;
            }

            if (result == string.Empty)
            {
                if (member.PointerLevel > 0)
                {
                    result = "IntPtr";
                }
                else
                {
                    result = member.Type;
                }
            }
            else
            {
                if (member.PointerLevel > 0)
                {
                    for (int i = 0; i < member.PointerLevel; i++)
                    {
                        result += "*";
                    }
                }
            }

            return result;
        }
    }
}
