using System;
using System.Collections.Generic;
using System.Text;

namespace WaveEngine.Bindings.Vulkan
{
    public partial struct VkClearColorValue
    {
        public unsafe VkClearColorValue(float r, float g, float b, float a = 1.0f) : this()
        {
            float32[0] = r;
            float32[1] = g;
            float32[2] = b;
            float32[3] = a;
        }

        public unsafe VkClearColorValue(int r, int g, int b, int a = 255) : this()
        {
            int32[0] = r;
            int32[1] = g;
            int32[2] = b;
            int32[3] = a;
        }

        public unsafe VkClearColorValue(uint r, uint g, uint b, uint a = 255) : this()
        {
            uint32[0] = r;
            uint32[1] = g;
            uint32[2] = b;
            uint32[3] = a;
        }
    }
}
