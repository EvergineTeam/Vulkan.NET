using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WaveEngine.Bindings.Vulkan;

namespace KHRRTXHelloTriangle
{
    public unsafe partial class HelloTriangle
    {
        private const int EXIT_FAILURE = 1;
        private const int VK_NULL_HANDLE = 0;

        private VkPhysicalDeviceRayTracingPropertiesKHR rayTracingProperties;

        private VkAccelerationStructureKHR bottomLevelAS;
        private ulong bottomLevelASHandle = 0;
        private VkAccelerationStructureKHR topLevelAS;

        private VkImage offscreenBuffer;
        private VkImageView offscreenBufferView;
        private VkDeviceMemory offscreenBufferMemory;

        private VkDescriptorSetLayout descriptorSetLayout;
        private VkDescriptorPool descriptorPool;
        private VkDescriptorSet descriptorSet;

        private VkPipelineLayout pipelineLayout;
        private VkPipeline pipeline;

        private AccelerationMemory shaderBindingTable;
        private uint shaderBindingTableSize = 0;
        private uint shaderBindingTableGroupCount = 3;

        private void InitRayTracing()
        {
            this.rayTracingProperties = default;
            rayTracingProperties.sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_KHR;
            rayTracingProperties.pNext = null;

            VkPhysicalDeviceProperties2 deviceProperties2 = default;
            deviceProperties2.sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2;
            fixed (VkPhysicalDeviceRayTracingPropertiesKHR* rayTracingPropertiesPtr = &this.rayTracingProperties)
            {
                deviceProperties2.pNext = rayTracingPropertiesPtr;
                VulkanNative.vkGetPhysicalDeviceProperties2(physicalDevice, &deviceProperties2);
            }
        }

        public struct AccelerationMemory
        {
            public VkBuffer buffer;
            public VkDeviceMemory memory;
            public ulong memoryAddress;
            public IntPtr mappedPointer;
        }

        public uint FindMemoryType(uint typeFilter, VkMemoryPropertyFlags properties)
        {
            VkPhysicalDeviceMemoryProperties memProperties;
            VulkanNative.vkGetPhysicalDeviceMemoryProperties(physicalDevice, &memProperties);
            for (int ii = 0; ii < memProperties.memoryTypeCount; ii++)
            {
                if (((typeFilter & (1 << ii)) != 0)
                    && (memProperties.GetMemoryType((uint)ii).propertyFlags & properties) == properties)
                {
                    return (uint)ii;
                }
            }
            throw new Exception("failed to find suitable memory type!");
        }

        private VkMemoryRequirements GetAccelerationStructureMemoryRequirements(VkAccelerationStructureKHR acceleration, VkAccelerationStructureMemoryRequirementsTypeKHR type)
        {
            VkMemoryRequirements2 memoryRequirements2 = default;
            memoryRequirements2.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2;

            VkAccelerationStructureMemoryRequirementsInfoKHR accelerationMemoryRequirements = default;
            accelerationMemoryRequirements.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_KHR;
            accelerationMemoryRequirements.pNext = null;
            accelerationMemoryRequirements.type = type;
            accelerationMemoryRequirements.buildType = VkAccelerationStructureBuildTypeKHR.VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR;
            accelerationMemoryRequirements.accelerationStructure = acceleration;
            VulkanNative.vkGetAccelerationStructureMemoryRequirementsKHR(device, &accelerationMemoryRequirements, &memoryRequirements2);

            return memoryRequirements2.memoryRequirements;
        }

        private ulong GetBufferAddress(VkBuffer buffer)
        {
            VkBufferDeviceAddressInfo bufferAddressInfo = default; // TODO VkBufferDeviceAddressInfoKHR
            bufferAddressInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO;
            bufferAddressInfo.pNext = null;
            bufferAddressInfo.buffer = buffer;

            return VulkanNative.vkGetBufferDeviceAddress(device, &bufferAddressInfo); // TODO vkGetBufferDeviceAddressKHR
        }

        private AccelerationMemory CreateAccelerationScratchBuffer(VkAccelerationStructureKHR acceleration, VkAccelerationStructureMemoryRequirementsTypeKHR type)
        {
            AccelerationMemory outValue = default;

            VkMemoryRequirements asRequirements = this.GetAccelerationStructureMemoryRequirements(acceleration, type);

            VkBufferCreateInfo bufferInfo = default;
            bufferInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO;
            bufferInfo.pNext = null;
            bufferInfo.size = asRequirements.size;
            bufferInfo.usage = VkBufferUsageFlags.VK_BUFFER_USAGE_RAY_TRACING_BIT_KHR | VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT;
            bufferInfo.sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE;
            bufferInfo.queueFamilyIndexCount = 0;
            bufferInfo.pQueueFamilyIndices = null;
            Helpers.CheckErrors(VulkanNative.vkCreateBuffer(device, &bufferInfo, null, &outValue.buffer));

            VkMemoryRequirements bufRequirements = default;
            VulkanNative.vkGetBufferMemoryRequirements(device, outValue.buffer, &bufRequirements);

            // buffer requirements can differ to AS requirements, so we max them
            ulong alloctionSize = asRequirements.size > bufRequirements.size ? asRequirements.size : bufRequirements.size;
            // combine AS and buf mem types
            uint allocationMemoryBits = bufRequirements.memoryTypeBits | asRequirements.memoryTypeBits;

            VkMemoryAllocateFlagsInfo memAllocFlagsInfo = default;
            memAllocFlagsInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO;
            memAllocFlagsInfo.pNext = null;
            memAllocFlagsInfo.flags = VkMemoryAllocateFlags.VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT; // TODO Remove _KHR
            memAllocFlagsInfo.deviceMask = 0;

            VkMemoryAllocateInfo memAllocInfo = default;
            memAllocInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;
            memAllocInfo.pNext = &memAllocFlagsInfo;
            memAllocInfo.allocationSize = alloctionSize;
            memAllocInfo.memoryTypeIndex = this.FindMemoryType(allocationMemoryBits, VkMemoryPropertyFlags.VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT);
            Helpers.CheckErrors(VulkanNative.vkAllocateMemory(device, &memAllocInfo, null, &outValue.memory));

            Helpers.CheckErrors(VulkanNative.vkBindBufferMemory(device, outValue.buffer, outValue.memory, 0));

            outValue.memoryAddress = this.GetBufferAddress(outValue.buffer);

            return outValue;
        }

        private void BindAccelerationMemory(VkAccelerationStructureKHR acceleration, VkDeviceMemory memory)
        {
            VkBindAccelerationStructureMemoryInfoKHR accelerationMemoryBindInfo = default;
            accelerationMemoryBindInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_KHR;
            accelerationMemoryBindInfo.pNext = null;
            accelerationMemoryBindInfo.accelerationStructure = acceleration;
            accelerationMemoryBindInfo.memory = memory;
            accelerationMemoryBindInfo.memoryOffset = 0;
            accelerationMemoryBindInfo.deviceIndexCount = 0;
            accelerationMemoryBindInfo.pDeviceIndices = null;

            Helpers.CheckErrors(VulkanNative.vkBindAccelerationStructureMemoryKHR(device, 1, &accelerationMemoryBindInfo));
        }

        AccelerationMemory CreateMappedBuffer<T>(T[] srcData, uint byteLength)
        {
            AccelerationMemory outValue = default;

            VkBufferCreateInfo bufferInfo = default;
            bufferInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO;
            bufferInfo.pNext = null;
            bufferInfo.size = byteLength;
            bufferInfo.usage = VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT;
            bufferInfo.sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE;
            bufferInfo.queueFamilyIndexCount = 0;
            bufferInfo.pQueueFamilyIndices = null;
            Helpers.CheckErrors(VulkanNative.vkCreateBuffer(device, &bufferInfo, null, &outValue.buffer));

            VkMemoryRequirements memoryRequirements = default;
            VulkanNative.vkGetBufferMemoryRequirements(device, outValue.buffer, &memoryRequirements);

            VkMemoryAllocateFlagsInfo memAllocFlagsInfo = default;
            memAllocFlagsInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO;
            memAllocFlagsInfo.pNext = null;
            memAllocFlagsInfo.flags = VkMemoryAllocateFlags.VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT; // TODO VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR
            memAllocFlagsInfo.deviceMask = 0;

            VkMemoryAllocateInfo memAllocInfo = default;
            memAllocInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;
            memAllocInfo.pNext = &memAllocFlagsInfo;
            memAllocInfo.allocationSize = memoryRequirements.size;
            memAllocInfo.memoryTypeIndex = this.FindMemoryType(memoryRequirements.memoryTypeBits, VkMemoryPropertyFlags.VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | VkMemoryPropertyFlags.VK_MEMORY_PROPERTY_HOST_COHERENT_BIT);
            Helpers.CheckErrors(VulkanNative.vkAllocateMemory(device, &memAllocInfo, null, &outValue.memory));

            Helpers.CheckErrors(VulkanNative.vkBindBufferMemory(device, outValue.buffer, outValue.memory, 0));

            outValue.memoryAddress = this.GetBufferAddress(outValue.buffer);

            GCHandle gcHandle = GCHandle.Alloc(srcData, GCHandleType.Pinned);
            IntPtr srcDataPtr = gcHandle.AddrOfPinnedObject();
            IntPtr dstData;
            Helpers.CheckErrors(VulkanNative.vkMapMemory(device, outValue.memory, 0, byteLength, 0, (void**)&dstData));
            if (srcDataPtr != IntPtr.Zero)
            {
                Unsafe.CopyBlock((void*)dstData, (void*)srcDataPtr, byteLength);
            }
            VulkanNative.vkUnmapMemory(device, outValue.memory);
            outValue.mappedPointer = dstData;
            gcHandle.Free();

            return outValue;
        }

        private void CreateBottomLevelAS()
        {
            Debug.WriteLine("Creating Bottom-Level Acceleration Structure..");

            VkAccelerationStructureCreateGeometryTypeInfoKHR accelerationCreateGeometryInfo = default;
            accelerationCreateGeometryInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_GEOMETRY_TYPE_INFO_KHR;
            accelerationCreateGeometryInfo.pNext = null;
            accelerationCreateGeometryInfo.geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_TRIANGLES_KHR;
            accelerationCreateGeometryInfo.maxPrimitiveCount = 128;
            accelerationCreateGeometryInfo.indexType = VkIndexType.VK_INDEX_TYPE_UINT32;
            accelerationCreateGeometryInfo.maxVertexCount = 8;
            accelerationCreateGeometryInfo.vertexFormat = VkFormat.VK_FORMAT_R32G32B32_SFLOAT;
            accelerationCreateGeometryInfo.allowsTransforms = false;

            VkAccelerationStructureCreateInfoKHR accelerationInfo = default;
            accelerationInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR;
            accelerationInfo.pNext = null;
            accelerationInfo.compactedSize = 0;
            accelerationInfo.type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR;
            accelerationInfo.flags = VkBuildAccelerationStructureFlagsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR;
            accelerationInfo.maxGeometryCount = 1;
            accelerationInfo.pGeometryInfos = &accelerationCreateGeometryInfo;
            accelerationInfo.deviceAddress = VK_NULL_HANDLE;

            fixed (VkAccelerationStructureKHR* bottomLevelASPtr = &bottomLevelAS)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateAccelerationStructureKHR(device, &accelerationInfo, null, bottomLevelASPtr));
            }

            AccelerationMemory objectMemory = this.CreateAccelerationScratchBuffer(bottomLevelAS, VkAccelerationStructureMemoryRequirementsTypeKHR.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_KHR);

            this.BindAccelerationMemory(bottomLevelAS, objectMemory.memory);

            AccelerationMemory buildScratchMemory = this.CreateAccelerationScratchBuffer(bottomLevelAS, VkAccelerationStructureMemoryRequirementsTypeKHR.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_KHR);

            // Get bottom level acceleration structure handle for use in top level instances
            VkAccelerationStructureDeviceAddressInfoKHR devAddrInfo = default;
            devAddrInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR;
            devAddrInfo.accelerationStructure = bottomLevelAS;
            bottomLevelASHandle = VulkanNative.vkGetAccelerationStructureDeviceAddressKHR(device, &devAddrInfo);

            // clang-format off
            float[] vertices = {
                +1.0f, +1.0f, +0.0f,
                -1.0f, +1.0f, +0.0f,
                +0.0f, -1.0f, +0.0f
            };
            uint[] indices = { 0, 1, 2 };
            // clang-format on

            AccelerationMemory vertexBuffer = this.CreateMappedBuffer(vertices, (uint)(sizeof(float) * vertices.Length));

            AccelerationMemory indexBuffer = this.CreateMappedBuffer(indices, (uint)(sizeof(uint) * indices.Length));

            VkAccelerationStructureGeometryKHR accelerationGeometry = default;
            accelerationGeometry.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR;
            accelerationGeometry.pNext = null;
            accelerationGeometry.flags = VkGeometryFlagsKHR.VK_GEOMETRY_OPAQUE_BIT_KHR;
            accelerationGeometry.geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_TRIANGLES_KHR;
            accelerationGeometry.geometry = default;
            accelerationGeometry.geometry.triangles = default;
            accelerationGeometry.geometry.triangles.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR;
            accelerationGeometry.geometry.triangles.pNext = null;
            accelerationGeometry.geometry.triangles.vertexFormat = VkFormat.VK_FORMAT_R32G32B32_SFLOAT;
            accelerationGeometry.geometry.triangles.vertexData.deviceAddress =
                vertexBuffer.memoryAddress;
            accelerationGeometry.geometry.triangles.vertexStride = 3 * sizeof(float);
            accelerationGeometry.geometry.triangles.indexType = VkIndexType.VK_INDEX_TYPE_UINT32;
            accelerationGeometry.geometry.triangles.indexData.deviceAddress = indexBuffer.memoryAddress;
            accelerationGeometry.geometry.triangles.transformData.deviceAddress = 0;

            VkAccelerationStructureGeometryKHR* ppGeometries = stackalloc VkAccelerationStructureGeometryKHR[] { accelerationGeometry };

            VkAccelerationStructureBuildGeometryInfoKHR accelerationBuildGeometryInfo = default;
            accelerationBuildGeometryInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR;
            accelerationBuildGeometryInfo.pNext = null;
            accelerationBuildGeometryInfo.type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR;
            accelerationBuildGeometryInfo.flags = VkBuildAccelerationStructureFlagsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR;
            accelerationBuildGeometryInfo.update = false;
            accelerationBuildGeometryInfo.srcAccelerationStructure = VK_NULL_HANDLE;
            accelerationBuildGeometryInfo.dstAccelerationStructure = bottomLevelAS;
            accelerationBuildGeometryInfo.geometryArrayOfPointers = false;
            accelerationBuildGeometryInfo.geometryCount = 1;
            accelerationBuildGeometryInfo.ppGeometries = &ppGeometries;
            accelerationBuildGeometryInfo.scratchData.deviceAddress = buildScratchMemory.memoryAddress;

            VkAccelerationStructureBuildOffsetInfoKHR accelerationBuildOffsetInfo = default;
            accelerationBuildOffsetInfo.primitiveCount = 1;
            accelerationBuildOffsetInfo.primitiveOffset = 0x0;
            accelerationBuildOffsetInfo.firstVertex = 0;
            accelerationBuildOffsetInfo.transformOffset = 0x0;

            VkAccelerationStructureBuildOffsetInfoKHR*[] accelerationBuildOffsets = { &accelerationBuildOffsetInfo };

            VkCommandBuffer commandBuffer;

            VkCommandBufferAllocateInfo commandBufferAllocateInfo = default;
            commandBufferAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO;
            commandBufferAllocateInfo.pNext = null;
            commandBufferAllocateInfo.commandPool = commandPool;
            commandBufferAllocateInfo.level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY;
            commandBufferAllocateInfo.commandBufferCount = 1;
            Helpers.CheckErrors(VulkanNative.vkAllocateCommandBuffers(device, &commandBufferAllocateInfo, &commandBuffer));

            VkCommandBufferBeginInfo commandBufferBeginInfo = default;
            commandBufferBeginInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO;
            commandBufferBeginInfo.pNext = null;
            commandBufferBeginInfo.flags = VkCommandBufferUsageFlags.VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT;
            VulkanNative.vkBeginCommandBuffer(commandBuffer, &commandBufferBeginInfo);

            fixed (VkAccelerationStructureBuildOffsetInfoKHR** accelerationBuildOffsetsPtr = &accelerationBuildOffsets[0])
            {
                VulkanNative.vkCmdBuildAccelerationStructureKHR(commandBuffer, 1, &accelerationBuildGeometryInfo, accelerationBuildOffsetsPtr);
            }

            Helpers.CheckErrors(VulkanNative.vkEndCommandBuffer(commandBuffer));

            VkSubmitInfo submitInfo = default;
            submitInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO;
            submitInfo.pNext = null;
            submitInfo.commandBufferCount = 1;
            submitInfo.pCommandBuffers = &commandBuffer;

            VkFence fence = VK_NULL_HANDLE;
            VkFenceCreateInfo fenceInfo = default;
            fenceInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_CREATE_INFO;
            fenceInfo.pNext = null;

            Helpers.CheckErrors(VulkanNative.vkCreateFence(this.device, &fenceInfo, null, &fence));
            Helpers.CheckErrors(VulkanNative.vkQueueSubmit(this.graphicsQueue, 1, &submitInfo, fence));
            Helpers.CheckErrors(VulkanNative.vkWaitForFences(device, 1, &fence, true, ulong.MaxValue));

            VulkanNative.vkDestroyFence(device, fence, null);
            VulkanNative.vkFreeCommandBuffers(this.device, this.commandPool, 1, &commandBuffer);

            // make sure bottom AS handle is valid
            if (bottomLevelASHandle == 0)
            {
                Debug.WriteLine("Invalid Handle to BLAS");
                throw new Exception("Invalid Handle to BLAS");
            }
        }

        private void CreateTopLevelAS()
        {
            Debug.WriteLine("Creating Top-Level Acceleration Structure..");

            VkAccelerationStructureCreateGeometryTypeInfoKHR accelerationCreateGeometryInfo = default;
            accelerationCreateGeometryInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_GEOMETRY_TYPE_INFO_KHR;
            accelerationCreateGeometryInfo.pNext = null;
            accelerationCreateGeometryInfo.geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_INSTANCES_KHR;
            accelerationCreateGeometryInfo.maxPrimitiveCount = 1;

            VkAccelerationStructureCreateInfoKHR accelerationInfo = default;
            accelerationInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR;
            accelerationInfo.pNext = null;
            accelerationInfo.compactedSize = 0;
            accelerationInfo.type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR;
            accelerationInfo.flags = VkBuildAccelerationStructureFlagsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR;
            accelerationInfo.maxGeometryCount = 1;
            accelerationInfo.pGeometryInfos = &accelerationCreateGeometryInfo;
            accelerationInfo.deviceAddress = VK_NULL_HANDLE;

            fixed (VkAccelerationStructureKHR* topLevelASPtr = &topLevelAS)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateAccelerationStructureKHR(device, &accelerationInfo, null, topLevelASPtr));
            }

            AccelerationMemory objectMemory = this.CreateAccelerationScratchBuffer(topLevelAS, VkAccelerationStructureMemoryRequirementsTypeKHR.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_KHR);

            this.BindAccelerationMemory(topLevelAS, objectMemory.memory);

            AccelerationMemory buildScratchMemory = this.CreateAccelerationScratchBuffer(topLevelAS, VkAccelerationStructureMemoryRequirementsTypeKHR.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_KHR);

            VkAccelerationStructureInstanceKHR[] instances = new VkAccelerationStructureInstanceKHR[]
            {
                new VkAccelerationStructureInstanceKHR()
                {
                    transform = new VkTransformMatrixKHR()
                    {
                        matrix_0 = 1,
                        matrix_1 = 0,
                        matrix_2 = 0,
                        matrix_3 = 0,

                        matrix_4 = 0,
                        matrix_5 = 1,
                        matrix_6 = 0,
                        matrix_7 = 0,

                        matrix_8 = 0,
                        matrix_9 = 0,
                        matrix_10 = 1,
                        matrix_11 = 0,
                    },
                    instanceCustomIndex = 0,
                    mask = 0xff,
                    instanceShaderBindingTableRecordOffset = 0x0,
                    flags = VkGeometryInstanceFlagsKHR.VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR,
                    accelerationStructureReference = bottomLevelASHandle
                }
            };


            AccelerationMemory instanceBuffer = this.CreateMappedBuffer(instances, (uint)(sizeof(VkAccelerationStructureInstanceKHR) * instances.Length));

            VkAccelerationStructureGeometryKHR accelerationGeometry = default;
            accelerationGeometry.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR;
            accelerationGeometry.pNext = null;
            accelerationGeometry.flags = VkGeometryFlagsKHR.VK_GEOMETRY_OPAQUE_BIT_KHR;
            accelerationGeometry.geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_INSTANCES_KHR;
            accelerationGeometry.geometry = default;
            accelerationGeometry.geometry.instances = default;
            accelerationGeometry.geometry.instances.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR;
            accelerationGeometry.geometry.instances.pNext = null;
            accelerationGeometry.geometry.instances.arrayOfPointers = false;
            accelerationGeometry.geometry.instances.data.deviceAddress = instanceBuffer.memoryAddress;

            VkAccelerationStructureGeometryKHR* ppGeometries = stackalloc VkAccelerationStructureGeometryKHR[] { accelerationGeometry };

            VkAccelerationStructureBuildGeometryInfoKHR accelerationBuildGeometryInfo = default;
            accelerationBuildGeometryInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR;
            accelerationBuildGeometryInfo.pNext = null;
            accelerationBuildGeometryInfo.type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR;
            accelerationBuildGeometryInfo.flags = VkBuildAccelerationStructureFlagsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR;
            accelerationBuildGeometryInfo.update = false;
            accelerationBuildGeometryInfo.srcAccelerationStructure = VK_NULL_HANDLE;
            accelerationBuildGeometryInfo.dstAccelerationStructure = topLevelAS;
            accelerationBuildGeometryInfo.geometryArrayOfPointers = false;
            accelerationBuildGeometryInfo.geometryCount = 1;
            accelerationBuildGeometryInfo.ppGeometries = &ppGeometries;
            accelerationBuildGeometryInfo.scratchData.deviceAddress = buildScratchMemory.memoryAddress;

            VkAccelerationStructureBuildOffsetInfoKHR accelerationBuildOffsetInfo = default;
            accelerationBuildOffsetInfo.primitiveCount = 1;
            accelerationBuildOffsetInfo.primitiveOffset = 0x0;
            accelerationBuildOffsetInfo.firstVertex = 0;
            accelerationBuildOffsetInfo.transformOffset = 0x0;

            VkAccelerationStructureBuildOffsetInfoKHR*[] accelerationBuildOffsets = { &accelerationBuildOffsetInfo };

            VkCommandBuffer commandBuffer;

            VkCommandBufferAllocateInfo commandBufferAllocateInfo = default;
            commandBufferAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO;
            commandBufferAllocateInfo.pNext = null;
            commandBufferAllocateInfo.commandPool = commandPool;
            commandBufferAllocateInfo.level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY;
            commandBufferAllocateInfo.commandBufferCount = 1;
            Helpers.CheckErrors(VulkanNative.vkAllocateCommandBuffers(device, &commandBufferAllocateInfo, &commandBuffer));

            VkCommandBufferBeginInfo commandBufferBeginInfo = default;
            commandBufferBeginInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO;
            commandBufferBeginInfo.pNext = null;
            commandBufferBeginInfo.flags = VkCommandBufferUsageFlags.VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT;
            VulkanNative.vkBeginCommandBuffer(commandBuffer, &commandBufferBeginInfo);

            fixed (VkAccelerationStructureBuildOffsetInfoKHR** accelerationBuildOffsetsPtr = &accelerationBuildOffsets[0])
            {
                VulkanNative.vkCmdBuildAccelerationStructureKHR(commandBuffer, 1, &accelerationBuildGeometryInfo, accelerationBuildOffsetsPtr);
            }

            Helpers.CheckErrors(VulkanNative.vkEndCommandBuffer(commandBuffer));

            VkSubmitInfo submitInfo = default;
            submitInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO;
            submitInfo.pNext = null;
            submitInfo.commandBufferCount = 1;
            submitInfo.pCommandBuffers = &commandBuffer;

            VkFence fence = VK_NULL_HANDLE;
            VkFenceCreateInfo fenceInfo = default;
            fenceInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_CREATE_INFO;
            fenceInfo.pNext = null;

            Helpers.CheckErrors(VulkanNative.vkCreateFence(device, &fenceInfo, null, &fence));
            Helpers.CheckErrors(VulkanNative.vkQueueSubmit(this.graphicsQueue, 1, &submitInfo, fence));
            Helpers.CheckErrors(VulkanNative.vkWaitForFences(device, 1, &fence, true, ulong.MaxValue));

            VulkanNative.vkDestroyFence(device, fence, null);
            VulkanNative.vkFreeCommandBuffers(device, commandPool, 1, &commandBuffer);
        }

        private void CreateOffscreenBuffer()
        {
            Debug.WriteLine("Creating Offsceen Buffer..");

            VkImageCreateInfo imageInfo = default;
            imageInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO;
            imageInfo.pNext = null;
            imageInfo.imageType = VkImageType.VK_IMAGE_TYPE_2D;
            imageInfo.format = this.swapChainImageFormat;
            imageInfo.extent = new VkExtent3D { width = this.swapChainExtent.width, height = this.swapChainExtent.height, depth = 1 };
            imageInfo.mipLevels = 1;
            imageInfo.arrayLayers = 1;
            imageInfo.samples = VkSampleCountFlags.VK_SAMPLE_COUNT_1_BIT;
            imageInfo.tiling = VkImageTiling.VK_IMAGE_TILING_OPTIMAL;
            imageInfo.usage = VkImageUsageFlags.VK_IMAGE_USAGE_STORAGE_BIT | VkImageUsageFlags.VK_IMAGE_USAGE_TRANSFER_SRC_BIT;
            imageInfo.sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE;
            imageInfo.queueFamilyIndexCount = 0;
            imageInfo.pQueueFamilyIndices = null;
            imageInfo.initialLayout = VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED;

            fixed (VkImage* offscreenBufferPtr = &offscreenBuffer)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateImage(device, &imageInfo, null, offscreenBufferPtr));
            }

            VkMemoryRequirements memoryRequirements = default;
            VulkanNative.vkGetImageMemoryRequirements(device, offscreenBuffer, &memoryRequirements);

            VkMemoryAllocateInfo memoryAllocateInfo = default;
            memoryAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;
            memoryAllocateInfo.pNext = null;
            memoryAllocateInfo.allocationSize = memoryRequirements.size;
            memoryAllocateInfo.memoryTypeIndex = this.FindMemoryType(memoryRequirements.memoryTypeBits, VkMemoryPropertyFlags.VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT);

            fixed (VkDeviceMemory* offscreenBufferMemoryPtr = &this.offscreenBufferMemory)
            {
                Helpers.CheckErrors(VulkanNative.vkAllocateMemory(device, &memoryAllocateInfo, null, offscreenBufferMemoryPtr));
            }

            Helpers.CheckErrors(VulkanNative.vkBindImageMemory(device, offscreenBuffer, offscreenBufferMemory, 0));

            VkImageViewCreateInfo imageViewInfo = default;
            imageViewInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO;
            imageViewInfo.pNext = null;
            imageViewInfo.viewType = VkImageViewType.VK_IMAGE_VIEW_TYPE_2D;
            imageViewInfo.format = this.swapChainImageFormat;
            imageViewInfo.subresourceRange = default;
            imageViewInfo.subresourceRange.aspectMask = VkImageAspectFlags.VK_IMAGE_ASPECT_COLOR_BIT;
            imageViewInfo.subresourceRange.baseMipLevel = 0;
            imageViewInfo.subresourceRange.levelCount = 1;
            imageViewInfo.subresourceRange.baseArrayLayer = 0;
            imageViewInfo.subresourceRange.layerCount = 1;
            imageViewInfo.image = offscreenBuffer;
            imageViewInfo.flags = 0;
            imageViewInfo.components.r = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_R;
            imageViewInfo.components.g = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_G;
            imageViewInfo.components.b = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_B;
            imageViewInfo.components.a = VkComponentSwizzle.VK_COMPONENT_SWIZZLE_A;

            fixed (VkImageView* offscreenBufferViewPtr = &this.offscreenBufferView)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateImageView(device, &imageViewInfo, null, offscreenBufferViewPtr));
            }
        }

        private void CreateRTDescriptorSetLayout()
        {
            Debug.WriteLine("Creating RT Descriptor Set Layout..");

            VkDescriptorSetLayoutBinding accelerationStructureLayoutBinding = default;
            accelerationStructureLayoutBinding.binding = 0;
            accelerationStructureLayoutBinding.descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR;
            accelerationStructureLayoutBinding.descriptorCount = 1;
            accelerationStructureLayoutBinding.stageFlags = VkShaderStageFlags.VK_SHADER_STAGE_RAYGEN_BIT_KHR;
            accelerationStructureLayoutBinding.pImmutableSamplers = null;

            VkDescriptorSetLayoutBinding storageImageLayoutBinding = default;
            storageImageLayoutBinding.binding = 1;
            storageImageLayoutBinding.descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_STORAGE_IMAGE;
            storageImageLayoutBinding.descriptorCount = 1;
            storageImageLayoutBinding.stageFlags = VkShaderStageFlags.VK_SHADER_STAGE_RAYGEN_BIT_KHR;

            VkDescriptorSetLayoutBinding* bindings = stackalloc VkDescriptorSetLayoutBinding[] { accelerationStructureLayoutBinding, storageImageLayoutBinding };

            VkDescriptorSetLayoutCreateInfo layoutInfo = default;
            layoutInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO;
            layoutInfo.pNext = null;
            layoutInfo.flags = 0;
            layoutInfo.bindingCount = 2;
            layoutInfo.pBindings = bindings;

            fixed (VkDescriptorSetLayout* descriptorSetLayoutPtr = &this.descriptorSetLayout)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateDescriptorSetLayout(device, &layoutInfo, null, descriptorSetLayoutPtr));
            }
        }

        private void CreateRTDescriptorSet()
        {
            Debug.WriteLine("Creating RT Descriptor Set..");

            VkDescriptorPoolSize* poolSizes = stackalloc VkDescriptorPoolSize[]
            {
                new VkDescriptorPoolSize() { type = VkDescriptorType.VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR, descriptorCount = 1 },
                new VkDescriptorPoolSize() { type = VkDescriptorType.VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, descriptorCount = 1 }
            };

            VkDescriptorPoolCreateInfo descriptorPoolInfo = default;
            descriptorPoolInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO;
            descriptorPoolInfo.pNext = null;
            descriptorPoolInfo.flags = 0;
            descriptorPoolInfo.maxSets = 1;
            descriptorPoolInfo.poolSizeCount = 2;
            descriptorPoolInfo.pPoolSizes = poolSizes;

            fixed (VkDescriptorPool* descriptorPoolPtr = &this.descriptorPool)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateDescriptorPool(device, &descriptorPoolInfo, null, descriptorPoolPtr));
            }

            VkDescriptorSetAllocateInfo descriptorSetAllocateInfo = default;
            descriptorSetAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO;
            descriptorSetAllocateInfo.pNext = null;
            descriptorSetAllocateInfo.descriptorPool = descriptorPool;
            descriptorSetAllocateInfo.descriptorSetCount = 1;
            fixed (VkDescriptorSetLayout* descriptorSetLayoutPtr = &descriptorSetLayout)
            {
                descriptorSetAllocateInfo.pSetLayouts = descriptorSetLayoutPtr;
            }

            fixed (VkDescriptorSet* descriptorSetPtr = &descriptorSet)
            {
                Helpers.CheckErrors(VulkanNative.vkAllocateDescriptorSets(device, &descriptorSetAllocateInfo, descriptorSetPtr));
            }

            VkWriteDescriptorSetAccelerationStructureKHR descriptorAccelerationStructureInfo;
            descriptorAccelerationStructureInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR;
            descriptorAccelerationStructureInfo.pNext = null;
            descriptorAccelerationStructureInfo.accelerationStructureCount = 1;
            fixed (VkAccelerationStructureKHR* topLevelASPtr = &topLevelAS)
            {
                descriptorAccelerationStructureInfo.pAccelerationStructures = topLevelASPtr;
            }

            VkWriteDescriptorSet accelerationStructureWrite = default;
            accelerationStructureWrite.sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET;
            accelerationStructureWrite.pNext = &descriptorAccelerationStructureInfo;
            accelerationStructureWrite.dstSet = descriptorSet;
            accelerationStructureWrite.dstBinding = 0;
            accelerationStructureWrite.descriptorCount = 1;
            accelerationStructureWrite.descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR;

            VkDescriptorImageInfo storageImageInfo = default;
            storageImageInfo.sampler = VK_NULL_HANDLE;
            storageImageInfo.imageView = offscreenBufferView;
            storageImageInfo.imageLayout = VkImageLayout.VK_IMAGE_LAYOUT_GENERAL;

            VkWriteDescriptorSet outputImageWrite = default;
            outputImageWrite.sType = VkStructureType.VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET;
            outputImageWrite.pNext = null;
            outputImageWrite.dstSet = descriptorSet;
            outputImageWrite.dstBinding = 1;
            outputImageWrite.descriptorType = VkDescriptorType.VK_DESCRIPTOR_TYPE_STORAGE_IMAGE;
            outputImageWrite.descriptorCount = 1;
            outputImageWrite.pImageInfo = &storageImageInfo;

            VkWriteDescriptorSet* descriptorWrites = stackalloc VkWriteDescriptorSet[] { accelerationStructureWrite, outputImageWrite };

            VulkanNative.vkUpdateDescriptorSets(device, 2, descriptorWrites, 0, null);
        }

        private void CreateRTPipelineLayout()
        {
            Debug.WriteLine("Creating RT Pipeline Layout..");

            VkPipelineLayoutCreateInfo pipelineLayoutInfo = default;
            pipelineLayoutInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO;
            pipelineLayoutInfo.pNext = null;
            pipelineLayoutInfo.flags = 0;
            pipelineLayoutInfo.setLayoutCount = 1;
            fixed (VkDescriptorSetLayout* descriptorSetLayoutPtr = &descriptorSetLayout)
            {
                pipelineLayoutInfo.pSetLayouts = descriptorSetLayoutPtr;
            }
            pipelineLayoutInfo.pushConstantRangeCount = 0;
            pipelineLayoutInfo.pPushConstantRanges = null;

            fixed (VkPipelineLayout* pipelineLayoutPtr = &pipelineLayout)
            {
                Helpers.CheckErrors(VulkanNative.vkCreatePipelineLayout(device, &pipelineLayoutInfo, null, pipelineLayoutPtr));
            }
        }

        private void CreateRTPipeline()
        {
            Debug.WriteLine("Creating RT Pipeline..");

            byte[] rgenShaderSrc = File.ReadAllBytes("Shaders/ray-generation.spv");
            byte[] rchitShaderSrc = File.ReadAllBytes("Shaders/ray-closest-hit.spv");
            byte[] rmissShaderSrc = File.ReadAllBytes("Shaders/ray-miss.spv");

            VkPipelineShaderStageCreateInfo rayGenShaderStageInfo = default;
            rayGenShaderStageInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO;
            rayGenShaderStageInfo.pNext = null;
            rayGenShaderStageInfo.stage = VkShaderStageFlags.VK_SHADER_STAGE_RAYGEN_BIT_KHR;
            rayGenShaderStageInfo.module = CreateShaderModule(rgenShaderSrc);
            rayGenShaderStageInfo.pName = "main".ToPointer();

            VkPipelineShaderStageCreateInfo rayChitShaderStageInfo = default;
            rayChitShaderStageInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO;
            rayChitShaderStageInfo.pNext = null;
            rayChitShaderStageInfo.stage = VkShaderStageFlags.VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR;
            rayChitShaderStageInfo.module = CreateShaderModule(rchitShaderSrc);
            rayChitShaderStageInfo.pName = "main".ToPointer();

            VkPipelineShaderStageCreateInfo rayMissShaderStageInfo = default;
            rayMissShaderStageInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO;
            rayMissShaderStageInfo.pNext = null;
            rayMissShaderStageInfo.stage = VkShaderStageFlags.VK_SHADER_STAGE_MISS_BIT_KHR;
            rayMissShaderStageInfo.module = CreateShaderModule(rmissShaderSrc);
            rayMissShaderStageInfo.pName = "main".ToPointer();

            VkPipelineShaderStageCreateInfo* shaderStages = stackalloc VkPipelineShaderStageCreateInfo[] { rayGenShaderStageInfo, rayChitShaderStageInfo, rayMissShaderStageInfo };

            VkRayTracingShaderGroupCreateInfoKHR rayGenGroup = default;
            rayGenGroup.sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR;
            rayGenGroup.pNext = null;
            rayGenGroup.type = VkRayTracingShaderGroupTypeKHR.VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR;
            rayGenGroup.generalShader = 0;
            rayGenGroup.closestHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayGenGroup.anyHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayGenGroup.intersectionShader = VulkanNative.VK_SHADER_UNUSED_KHR;

            VkRayTracingShaderGroupCreateInfoKHR rayHitGroup = default;
            rayHitGroup.sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR;
            rayHitGroup.pNext = null;
            rayHitGroup.type = VkRayTracingShaderGroupTypeKHR.VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR;
            rayHitGroup.generalShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayHitGroup.closestHitShader = 1;
            rayHitGroup.anyHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayHitGroup.intersectionShader = VulkanNative.VK_SHADER_UNUSED_KHR;

            VkRayTracingShaderGroupCreateInfoKHR rayMissGroup = default;
            rayMissGroup.sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR;
            rayMissGroup.pNext = null;
            rayMissGroup.type = VkRayTracingShaderGroupTypeKHR.VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR;
            rayMissGroup.generalShader = 2;
            rayMissGroup.closestHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayMissGroup.anyHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayMissGroup.intersectionShader = VulkanNative.VK_SHADER_UNUSED_KHR;

            VkRayTracingShaderGroupCreateInfoKHR* shaderGroups = stackalloc VkRayTracingShaderGroupCreateInfoKHR[] { rayGenGroup, rayHitGroup, rayMissGroup };

            VkRayTracingPipelineCreateInfoKHR pipelineInfo = default;
            pipelineInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR;
            pipelineInfo.pNext = null;
            pipelineInfo.flags = 0;
            pipelineInfo.stageCount = 3;
            pipelineInfo.pStages = shaderStages;
            pipelineInfo.groupCount = 3;
            pipelineInfo.pGroups = shaderGroups;
            pipelineInfo.maxRecursionDepth = 1;
            pipelineInfo.libraries = default;
            pipelineInfo.libraries.sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR;
            pipelineInfo.libraries.pNext = null;
            pipelineInfo.libraries.libraryCount = 0;
            pipelineInfo.libraries.pLibraries = null;
            pipelineInfo.pLibraryInterface = null;
            pipelineInfo.layout = pipelineLayout;
            pipelineInfo.basePipelineHandle = VK_NULL_HANDLE;
            pipelineInfo.basePipelineIndex = 0;

            fixed (VkPipeline* pipelinePtr = &pipeline)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateRayTracingPipelinesKHR(device, 0, 1, &pipelineInfo, null, pipelinePtr));
            }
        }

        private void CreateShaderBindingTable()
        {
            Debug.WriteLine("Creating Shader Binding Table..");

            AccelerationMemory newShaderBindingTable = default;
            shaderBindingTableSize = shaderBindingTableGroupCount * rayTracingProperties.shaderGroupHandleSize;

            VkBufferCreateInfo bufferInfo = default;
            bufferInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO;
            bufferInfo.pNext = null;
            bufferInfo.size = shaderBindingTableSize;
            bufferInfo.usage = VkBufferUsageFlags.VK_BUFFER_USAGE_TRANSFER_SRC_BIT;
            bufferInfo.sharingMode = VkSharingMode.VK_SHARING_MODE_EXCLUSIVE;
            bufferInfo.queueFamilyIndexCount = 0;
            bufferInfo.pQueueFamilyIndices = null;
            Helpers.CheckErrors(VulkanNative.vkCreateBuffer(device, &bufferInfo, null, &newShaderBindingTable.buffer));

            VkMemoryRequirements memoryRequirements = default;
            VulkanNative.vkGetBufferMemoryRequirements(device, newShaderBindingTable.buffer, &memoryRequirements);

            VkMemoryAllocateInfo memAllocInfo = default;
            memAllocInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;
            memAllocInfo.pNext = null;
            memAllocInfo.allocationSize = memoryRequirements.size;
            memAllocInfo.memoryTypeIndex = this.FindMemoryType(memoryRequirements.memoryTypeBits, VkMemoryPropertyFlags.VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT);

            Helpers.CheckErrors(VulkanNative.vkAllocateMemory(device, &memAllocInfo, null, &newShaderBindingTable.memory));

            Helpers.CheckErrors(VulkanNative.vkBindBufferMemory(device, newShaderBindingTable.buffer, newShaderBindingTable.memory, 0));

            IntPtr dstData;
            Helpers.CheckErrors(VulkanNative.vkMapMemory(device, newShaderBindingTable.memory, 0, shaderBindingTableSize, 0, (void**)&dstData));

            VulkanNative.vkGetRayTracingShaderGroupHandlesKHR(device, pipeline, 0, shaderBindingTableGroupCount, (UIntPtr)shaderBindingTableSize, (void*)dstData);
            VulkanNative.vkUnmapMemory(device, newShaderBindingTable.memory);

            this.shaderBindingTable = newShaderBindingTable;
        }

        private void InsertCommandImageBarrier(VkCommandBuffer commandBuffer,
                               VkImage image,
                               VkAccessFlags srcAccessMask,
                               VkAccessFlags dstAccessMask,
                               VkImageLayout oldLayout,
                               VkImageLayout newLayout,
                               ref VkImageSubresourceRange subresourceRange)
        {
            VkImageMemoryBarrier imageMemoryBarrier = default;
            imageMemoryBarrier.sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER;
            imageMemoryBarrier.pNext = null;
            imageMemoryBarrier.srcAccessMask = srcAccessMask;
            imageMemoryBarrier.dstAccessMask = dstAccessMask;
            imageMemoryBarrier.oldLayout = oldLayout;
            imageMemoryBarrier.newLayout = newLayout;
            imageMemoryBarrier.srcQueueFamilyIndex = VulkanNative.VK_QUEUE_FAMILY_IGNORED;
            imageMemoryBarrier.dstQueueFamilyIndex = VulkanNative.VK_QUEUE_FAMILY_IGNORED;
            imageMemoryBarrier.image = image;
            imageMemoryBarrier.subresourceRange = subresourceRange;

            VulkanNative.vkCmdPipelineBarrier(commandBuffer, VkPipelineStageFlags.VK_PIPELINE_STAGE_ALL_COMMANDS_BIT, VkPipelineStageFlags.VK_PIPELINE_STAGE_ALL_COMMANDS_BIT, 0, 0, null, 0, null, 1, &imageMemoryBarrier);
        }

        private void CreateCommandBuffers()
        {
            VkImageCopy copyRegion = default;
            copyRegion.srcSubresource = default;
            copyRegion.srcSubresource.aspectMask = VkImageAspectFlags.VK_IMAGE_ASPECT_COLOR_BIT;
            copyRegion.srcSubresource.mipLevel = 0;
            copyRegion.srcSubresource.baseArrayLayer = 0;
            copyRegion.srcSubresource.layerCount = 1;
            copyRegion.dstSubresource.aspectMask = VkImageAspectFlags.VK_IMAGE_ASPECT_COLOR_BIT;
            copyRegion.dstSubresource.mipLevel = 0;
            copyRegion.dstSubresource.baseArrayLayer = 0;
            copyRegion.dstSubresource.layerCount = 1;
            copyRegion.extent = default;
            copyRegion.extent.depth = 1;
            copyRegion.extent.width = this.swapChainExtent.width;
            copyRegion.extent.height = this.swapChainExtent.height;

            VkImageSubresourceRange subresourceRange = default;
            subresourceRange.aspectMask = VkImageAspectFlags.VK_IMAGE_ASPECT_COLOR_BIT;
            subresourceRange.baseMipLevel = 0;
            subresourceRange.levelCount = 1;
            subresourceRange.baseArrayLayer = 0;
            subresourceRange.layerCount = 1;

            // clang-format off
            VkStridedBufferRegionKHR rayGenSBT = new VkStridedBufferRegionKHR()
            {
                buffer = shaderBindingTable.buffer,
                offset = 0,
                stride = 0,
                size = shaderBindingTableSize
            };

            VkStridedBufferRegionKHR rayMissSBT = new VkStridedBufferRegionKHR
            {
                buffer = shaderBindingTable.buffer,
                offset = 2 * rayTracingProperties.shaderGroupHandleSize,
                stride = 0,
                size = shaderBindingTableSize
            }
            ;
            VkStridedBufferRegionKHR rayHitSBT = new VkStridedBufferRegionKHR()
            {
                buffer = shaderBindingTable.buffer,
                offset = 1 * rayTracingProperties.shaderGroupHandleSize,
                stride = 0,
                size = shaderBindingTableSize
            };

            VkStridedBufferRegionKHR rayCallSBT = new VkStridedBufferRegionKHR()
            {
                buffer = VK_NULL_HANDLE,
                offset = 0,
                stride = 0,
                size = 0
            };

            // clang-format on

            VkCommandBufferAllocateInfo commandBufferAllocateInfo = default;
            commandBufferAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO;
            commandBufferAllocateInfo.pNext = null;
            commandBufferAllocateInfo.commandPool = commandPool;
            commandBufferAllocateInfo.level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY;
            commandBufferAllocateInfo.commandBufferCount = (uint)this.swapChainImages.Length;

            this.commandBuffers = new VkCommandBuffer[this.swapChainImages.Length];

            fixed (VkCommandBuffer* commandBuffersPtr = &this.commandBuffers[0])
            {
                Helpers.CheckErrors(VulkanNative.vkAllocateCommandBuffers(device, &commandBufferAllocateInfo, commandBuffersPtr));
            }

            VkCommandBufferBeginInfo commandBufferBeginInfo = default;
            commandBufferBeginInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO;
            commandBufferBeginInfo.pNext = null;
            commandBufferBeginInfo.flags = 0;
            commandBufferBeginInfo.pInheritanceInfo = null;

            for (uint ii = 0; ii < this.commandBuffers.Length; ++ii)
            {
                VkCommandBuffer commandBuffer = commandBuffers[ii];
                VkImage swapchainImage = this.swapChainImages[ii];

                Helpers.CheckErrors(VulkanNative.vkBeginCommandBuffer(commandBuffer, &commandBufferBeginInfo));

                // transition offscreen buffer into shader writeable state
                this.InsertCommandImageBarrier(commandBuffer, offscreenBuffer, 0, VkAccessFlags.VK_ACCESS_SHADER_WRITE_BIT,
                                          VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED,
                                          VkImageLayout.VK_IMAGE_LAYOUT_GENERAL, ref subresourceRange);

                VulkanNative.vkCmdBindPipeline(commandBuffer, VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR, pipeline);
                fixed (VkDescriptorSet* descriptorSetPtr = &this.descriptorSet)
                {
                    VulkanNative.vkCmdBindDescriptorSets(commandBuffer, VkPipelineBindPoint.VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR, pipelineLayout, 0, 1, descriptorSetPtr, 0, null);
                }
                VulkanNative.vkCmdTraceRaysKHR(commandBuffer, &rayGenSBT, &rayMissSBT, &rayHitSBT, &rayCallSBT, this.swapChainExtent.width, this.swapChainExtent.height, 1);

                // transition swapchain image into copy destination state
                this.InsertCommandImageBarrier(commandBuffer, swapchainImage, 0, VkAccessFlags.VK_ACCESS_TRANSFER_WRITE_BIT,
                                          VkImageLayout.VK_IMAGE_LAYOUT_UNDEFINED,
                                          VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL, ref subresourceRange);

                // transition offscreen buffer into copy source state
                this.InsertCommandImageBarrier(commandBuffer, offscreenBuffer, VkAccessFlags.VK_ACCESS_SHADER_WRITE_BIT,
                                          VkAccessFlags.VK_ACCESS_TRANSFER_READ_BIT, VkImageLayout.VK_IMAGE_LAYOUT_GENERAL,
                                          VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL, ref subresourceRange);

                // copy offscreen buffer into swapchain image
                VulkanNative.vkCmdCopyImage(commandBuffer, offscreenBuffer, VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL,
                               swapchainImage, VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL, 1, &copyRegion);

                // transition swapchain image into presentable state
                this.InsertCommandImageBarrier(commandBuffer, swapchainImage, 0, VkAccessFlags.VK_ACCESS_TRANSFER_WRITE_BIT,
                                          VkImageLayout.VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL,
                                          VkImageLayout.VK_IMAGE_LAYOUT_PRESENT_SRC_KHR, ref subresourceRange);

                Helpers.CheckErrors(VulkanNative.vkEndCommandBuffer(commandBuffer));
            };

            /*VkSemaphoreCreateInfo semaphoreInfo = { };
            semaphoreInfo.sType = VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO;
            semaphoreInfo.pNext = nullptr;

            ASSERT_VK_RESULT(vkCreateSemaphore(device, &semaphoreInfo, nullptr, &semaphoreImageAvailable));

            ASSERT_VK_RESULT(
                vkCreateSemaphore(device, &semaphoreInfo, nullptr, &semaphoreRenderingAvailable));*/
        }
    }
}
