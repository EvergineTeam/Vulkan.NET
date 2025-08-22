using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VulkanGen
{
    public static class Helpers
    {
        public const string VK_SC = "vulkansc";

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
                case ConstantType.String:
                    return "string";
                default:
                    throw new InvalidOperationException("Invalid value");
            }
        }

        public static string ValidatedName(string name)
        {
            switch (name)
            {
                case "object":
                    return "vkObject";
                case "event":
                    return "vkEvent";
                case "params":
                    return "vkParams";
                default:
                    return name;
            }
        }

        public static string GetPrettyEnumName(string value)
        {
            int start;
            if((start = value.IndexOf("bit", StringComparison.OrdinalIgnoreCase)) != -1)
            {
                return value.Remove(start, 3);
            }

            return value;
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
            {
                return "IntPtr";
            }

            if (type.StartsWith('"'))
            {
                return "string";
            }

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

        public static bool SupportFixed(string type)
        {
            switch (type)
            {
                case "bool":
                case "byte":
                case "short":
                case "int":
                case "long":
                case "char":
                case "sbyte":
                case "ushort":
                case "uint":
                case "ulong":
                case "float":
                case "double":
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsIntPtr(string type)
        {
            switch (type)
            {
                case "Display":
                case "VisualID":
                case "Window":
                case "RROutput":
                case "wl_display":
                case "wl_surface":
                case "HINSTANCE":
                case "HWND":
                case "HMONITOR":
                case "HANDLE":
                case "SECURITY_ATTRIBUTES":
                case "DWORD":
                case "LPCWSTR":
                case "xcb_connection_t":
                case "xcb_visualid_t":
                case "xcb_window_t":
                case "IDirectFB":
                case "IDirectFBSurface":
                case "zx_handle_t":
                case "GgpStreamDescriptor":
                case "GgpFrameToken":
                case "CAMetalLayer":
                case "AHardwareBuffer":
                case "ANativeWindow":
                // NV extension
                case "_screen_context":
                case "_screen_window":
                case "StdVideoH264ProfileIdc":
                case "StdVideoH264PictureParameterSet":
                case "StdVideoH264SequenceParameterSet":
                case "StdVideoDecodeH264PictureInfo":
                case "StdVideoDecodeH264ReferenceInfo":
                case "StdVideoDecodeH264Mvc":
                case "StdVideoH265SequenceParameterSet":
                case "StdVideoH265PictureParameterSet":
                case "StdVideoEncodeAV1DecoderModelInfo":
                case "StdVideoEncodeAV1OperatingPointInfo":
                case "StdVideoEncodeAV1ReferenceInfo":
                case "StdVideoEncodeAV1PictureInfo":
                case "StdVideoDecodeH265PictureInfo":
                case "StdVideoDecodeH265ReferenceInfo":
                case "StdVideoEncodeH264PictureInfo":
                case "StdVideoEncodeH264SliceHeader":
                case "StdVideoH265ProfileIdc":
                case "StdVideoH265VideoParameterSet":
                case "StdVideoEncodeH265PictureInfo":
                case "StdVideoEncodeH265SliceHeader":
                case "StdVideoEncodeH265ReferenceInfo":
                case "StdVideoEncodeH265ReferenceModifications":
                case "StdVideoEncodeH265SliceSegmentHeader":
                case "StdVideoEncodeH264RefMemMgmtCtrlOperations":
                case "StdVideoEncodeH264ReferenceInfo":
                case "StdVideoH264LevelIdc":
                case "StdVideoH265LevelIdc":
                case "StdVideoAV1Profile":
                case "StdVideoAV1Level":
                case "StdVideoAV1SequenceHeader":
                case "StdVideoDecodeAV1PictureInfo":
                case "StdVideoDecodeAV1ReferenceInfo":
                case "NvSciSyncFence":
                case "NvSciSyncObj":
                case "StdVideoEncodeH264ReferenceListsInfo":
                case "StdVideoEncodeH265ReferenceListsInfo":
                case "NvSciSyncAttrList":
                case "NvSciBufAttrList":
                case "NvSciBufObj":
                case "_screen_buffer":
                case "StdVideoVP9Profile":
                case "StdVideoVP9Level":
                case "StdVideoDecodeVP9PictureInfo":
                case "OHNativeWindow":
                //Metal Layer
                case "MTLDevice_id":
                case "MTLCommandQueue_id":
                case "MTLBuffer_id":
                case "MTLTexture_id":
                case "MTLSharedEvent_id":
                case "IOSurfaceRef":
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsVKSC(string api)
        {
            // Check Vulkan Safety Critical
            return !string.IsNullOrEmpty(api) && api.Equals(VK_SC);
        }
    }
}