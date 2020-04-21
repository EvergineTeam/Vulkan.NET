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
                return "vkObject";
            }
            else if (name == "event")
            {
                return "vkEvent";
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

        public static string ConvertToCSharpType(string type, int pointerlevel, VulkanSpecification spec)
        {
            string memberType = type;

            if (type.StartsWith("PFN") || IsIntPtr(memberType))
                return "IntPtr";

            string result = ConvertBasicTypes(memberType);
            if (result == string.Empty)
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
                        if (typeDef.Requires != null)
                        {
                            result = typeDef.Requires;
                        }
                        else
                        {
                            spec.BaseTypes.TryGetValue(typeDef.Type, out baseType);
                            if (baseType != null)
                            {
                                result = ConvertBasicTypes(baseType);
                            }
                        }
                    }
                    else
                    {
                        result = memberType;
                    }
                }
            }

            if (pointerlevel > 0)
            {
                for (int i = 0; i < pointerlevel; i++)
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
                case "int8_t*":
                    return "sbyte*";
                case "uint8_t":
                case "char":
                    return "byte";
                case "uint8_t*":
                case "char*":
                    return "byte*";
                case "uint16_t":
                    return "ushort";
                case "uint16_t*":
                    return "ushort*";
                case "int16_t":
                    return "short";
                case "int16_t*":
                    return "int16*";
                case "uint32_t":
                case "DWORD":
                    return "uint";
                case "uint32_t*":
                    return "uint*";
                case "uint64_t":
                    return "ulong";
                case "uint64_t*":
                    return "ulong*";
                case "int32_t":
                    return "int";
                case "int32_t*":
                    return "int*";
                case "int64_t":
                    return "long";
                case "int64_t*":
                    return "long*";
                case "size_t":
                    return "UIntPtr";
                case "float":
                    return "float";
                case "float*":
                    return "float*";
                case "double":
                    return "double";
                case "double*":
                    return "double*";
                case "void":
                    return "void";
                case "VkBool32":
                    return "VkBool32";
                case "VkExtent2D":
                    return "VkExtent2D";
                case "VkOffset2D":
                    return "VkOffset2D";
                case "VkRect2D":
                    return "VkRect2D";
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
                case "VisualID":
                case "wl_display":
                case "wl_surface":
                case "Display":
                    return true;
                default:
                    return false;
            }
        }
    }
}