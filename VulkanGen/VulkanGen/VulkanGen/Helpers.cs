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

        public static string ValidatedName(string name)
        {
            if (name == "object")
            {
                return "VkObject";
            }

            return name;
        }

        public static uint GetTypeSize(string type)
        {
            if (type == "char" || type == "uint8_t")
                return 1;
            else if (type == "uint16_t" || type == "int16_t")
                return 2;

            // uint32_t, uint64_t, int32_t, int64_t, int64_t*, size_t, DWORD
            return 4;
        }

        public static string ConvertToCSharpType(Member member, VulkanSpecification spec)
        {
            string memberType = member.Type;

            if (member.Type.StartsWith("PFN") || IsIntPtr(memberType))
                return "IntPtr";

            string result = ConvertBasicTypes(memberType);
            if (result == string.Empty)
            {
                if (member.PointerLevel > 0)
                {
                    result = "IntPtr";
                }
                else
                {
                    if (spec.Alias.TryGetValue(memberType, out string alias))
                    {
                        memberType = alias;
                    }

                    spec.BaseTypes.TryGetValue(memberType, out string baseType);
                    if (baseType != null)
                    {
                        result = ConvertBasicTypes(baseType);
                    }
                    else
                    {
                        var typeDef = spec.TypeDefs.Find(t => t.Name == memberType);
                        if (typeDef != null)
                        {
                            spec.BaseTypes.TryGetValue(typeDef.Type, out baseType);
                            if (baseType != null)
                            {
                                result = ConvertBasicTypes(baseType);
                            }
                        }
                        else
                        {
                            result = memberType;
                        }
                    }
                }
            }

            if (member.PointerLevel > 0)
            {
                for (int i = 0; i < member.PointerLevel; i++)
                {
                    result += "*";
                }
            }

            return result;
        }

        public static string ConvertBasicTypes(string type)
        {
            switch (type)
            {
                case "int8_t":
                    return "sbyte";
                case "uint8_t":
                case "char":
                    return "byte";
                case "uint16_t":
                    return "ushort";
                case "int16_t":
                    return "short";
                case "uint32_t":
                case "DWORD":
                    return "uint";
                case "uint64_t":
                    return "ulong";
                case "int32_t":
                    return "int";
                case "int64_t":
                    return "long";
                case "size_t":
                    return "UIntPtr";
                case "float":
                    return "float";
                case "double":
                    return "double";
                case "void":
                    return "void";
                default:
                    return string.Empty;
            }
        }

        public static bool IsIntPtr(string type)
        {
            switch (type)
            {
                case "HINSTANCE":
                case "HWND":
                case "Window":
                case "xcb_connection_t":
                case "xcb_window_t":
                case "xcb_visualid_t":
                case "zx_handle_t":
                case "GgpStreamDescriptor":
                case "HANDLE":
                case "LPCWSTR":
                case "HMONITOR":
                case "GgpFrameToken":
                case "CAMetalLayer":
                case "AHardwareBuffer":
                case "ANativeWindow":
                case "RROutput":
                case "SECURITY_ATTRIBUTES":
                    return true;
                default:
                    return false;
            }
        }
    }
}