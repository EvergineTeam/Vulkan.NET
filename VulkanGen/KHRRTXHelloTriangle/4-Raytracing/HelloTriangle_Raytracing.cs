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

        private VkPhysicalDeviceRayTracingPipelinePropertiesKHR rayTracingPipelineProperties;
        private VkPhysicalDeviceAccelerationStructureFeaturesKHR rayTracingAccelerationFeatures;

        private VkAccelerationStructureKHR bottomLevelAS;
        private ulong bottomLevelASHandle = 0;
        private VkAccelerationStructureKHR topLevelAS;
        private ulong topLevelASHandle = 0;

        private VkImage offscreenBuffer;
        private VkImageView offscreenBufferView;
        private VkDeviceMemory offscreenBufferMemory;

        private VkDescriptorSetLayout descriptorSetLayout;
        private VkDescriptorPool descriptorPool;
        private VkDescriptorSet descriptorSet;

        private VkPipelineLayout pipelineLayout;
        private VkPipeline pipeline;

        private AccelerationMemory SBTRayGenBuffer;
        private AccelerationMemory SBTRayHitBuffer;
        private AccelerationMemory SBTRayMissBuffer;

        private uint SBTGroupCount = 3;
        private uint SBTHandleSize = 0;
        private uint SBTHandleAlignment = 0;
        private uint SBTHandleSizeAligned = 0;
        private uint SBTSize = 0;

        private void InitRayTracing()
        {
            // acquire RT properties
            rayTracingPipelineProperties.sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR;
            VkPhysicalDeviceProperties2 deviceProperties2 = default;
            deviceProperties2.sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2;
            fixed (VkPhysicalDeviceRayTracingPipelinePropertiesKHR* rayTracingPipelinePropertiesPtr = &this.rayTracingPipelineProperties)
            {
                deviceProperties2.pNext = rayTracingPipelinePropertiesPtr;
                VulkanNative.vkGetPhysicalDeviceProperties2(physicalDevice, &deviceProperties2);
            }

            // acquire RT AS features
            rayTracingAccelerationFeatures.sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR;
            VkPhysicalDeviceFeatures2 deviceFeatures2 = default;
            deviceFeatures2.sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2;
            fixed (VkPhysicalDeviceAccelerationStructureFeaturesKHR* rayTracingAccelerationFeaturesPtr = &rayTracingAccelerationFeatures)
            {
                deviceFeatures2.pNext = rayTracingAccelerationFeaturesPtr;
                VulkanNative.vkGetPhysicalDeviceFeatures2(physicalDevice, &deviceFeatures2);
            }
        }

        public struct AccelerationMemory
        {
            public VkBuffer buffer;
            public VkDeviceMemory memory;
            public ulong deviceAddress;
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

        private ulong GetBufferDeviceAddress(VkBuffer buffer)
        {
            VkBufferDeviceAddressInfo bufferAddressInfo = default; // TODO VkBufferDeviceAddressInfoKHR
            bufferAddressInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO;
            bufferAddressInfo.buffer = buffer;

            return VulkanNative.vkGetBufferDeviceAddress(device, &bufferAddressInfo); // TODO vkGetBufferDeviceAddressKHR
        }

        AccelerationMemory CreateMappedBuffer<T>(T[] srcData, uint bufferSize, VkBufferUsageFlags usageFlags)
        {
            AccelerationMemory outValue = default;

            VkBufferCreateInfo bufferInfo = default;
            bufferInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO;
            bufferInfo.size = bufferSize;
            bufferInfo.usage = usageFlags;
            Helpers.CheckErrors(VulkanNative.vkCreateBuffer(device, &bufferInfo, null, &outValue.buffer));

            VkMemoryRequirements memoryRequirements = default;
            VulkanNative.vkGetBufferMemoryRequirements(device, outValue.buffer, &memoryRequirements);

            VkMemoryAllocateFlagsInfo memoryAllocateFlagsInfo = default;
            memoryAllocateFlagsInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO;
            memoryAllocateFlagsInfo.flags = VkMemoryAllocateFlags.VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT; // TODO VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR

            VkMemoryAllocateInfo memoryAllocateInfo = default;
            memoryAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;
            memoryAllocateInfo.pNext = &memoryAllocateFlagsInfo;
            memoryAllocateInfo.allocationSize = memoryRequirements.size;
            memoryAllocateInfo.memoryTypeIndex = this.FindMemoryType(memoryRequirements.memoryTypeBits, VkMemoryPropertyFlags.VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | VkMemoryPropertyFlags.VK_MEMORY_PROPERTY_HOST_COHERENT_BIT);
            Helpers.CheckErrors(VulkanNative.vkAllocateMemory(device, &memoryAllocateInfo, null, &outValue.memory));
            Helpers.CheckErrors(VulkanNative.vkBindBufferMemory(device, outValue.buffer, outValue.memory, 0));

            outValue.deviceAddress = this.GetBufferDeviceAddress(outValue.buffer);

            GCHandle gcHandle = GCHandle.Alloc(srcData, GCHandleType.Pinned);
            IntPtr srcDataPtr = gcHandle.AddrOfPinnedObject();
            IntPtr dstData;
            Helpers.CheckErrors(VulkanNative.vkMapMemory(device, outValue.memory, 0, bufferSize, 0, (void**)&dstData));
            if (srcDataPtr != IntPtr.Zero)
            {
                Unsafe.CopyBlock((void*)dstData, (void*)srcDataPtr, bufferSize);
            }
            VulkanNative.vkUnmapMemory(device, outValue.memory);
            gcHandle.Free();

            return outValue;
        }

        private AccelerationMemory CreateAccelerationBuffer(uint bufferSize, VkBufferUsageFlags usageFlags)
        {
            AccelerationMemory outValue = default;

            VkBufferCreateInfo bufferInfo = default;
            bufferInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO;
            bufferInfo.size = bufferSize;
            bufferInfo.usage = usageFlags;
            Helpers.CheckErrors(VulkanNative.vkCreateBuffer(device, &bufferInfo, null, &outValue.buffer));

            VkMemoryRequirements memoryRequirements = default;
            VulkanNative.vkGetBufferMemoryRequirements(device, outValue.buffer, &memoryRequirements);

            VkMemoryAllocateFlagsInfo memoryAllocateFlagsInfo = default;
            memoryAllocateFlagsInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO;
            memoryAllocateFlagsInfo.flags = VkMemoryAllocateFlags.VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT; // TODO Remove _KHR

            VkMemoryAllocateInfo memoryAllocateInfo = default;
            memoryAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;
            memoryAllocateInfo.pNext = &memoryAllocateFlagsInfo;
            memoryAllocateInfo.allocationSize = memoryRequirements.size;
            memoryAllocateInfo.memoryTypeIndex = this.FindMemoryType(memoryRequirements.memoryTypeBits, VkMemoryPropertyFlags.VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT);
            Helpers.CheckErrors(VulkanNative.vkAllocateMemory(device, &memoryAllocateInfo, null, &outValue.memory));

            Helpers.CheckErrors(VulkanNative.vkBindBufferMemory(device, outValue.buffer, outValue.memory, 0));

            outValue.deviceAddress = this.GetBufferDeviceAddress(outValue.buffer);

            return outValue;
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

        private uint AlignTo(uint value, uint alignment)
        {
            return (value + alignment - 1) & ~(alignment - 1);
        }

        private void CreateBottomLevelAS()
        {
            // clang-format off
            float[] vertices = {
                +1.0f, +1.0f, +0.0f,
                -1.0f, +1.0f, +0.0f,
                +0.0f, -1.0f, +0.0f
            };
            uint[] indices = { 0, 1, 2 };
            // clang-format on

            Debug.WriteLine("Creating Bottom-Level Acceleration Structure..");

            AccelerationMemory vertexBuffer = this.CreateMappedBuffer(vertices,
                                                                      (uint)(vertices.Length * sizeof(float) * 3),
                                                                      VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT |
                                                                      VkBufferUsageFlags.VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR);

            AccelerationMemory indexBuffer = this.CreateMappedBuffer(indices,
                                                                     (uint)(sizeof(uint) * indices.Length),
                                                                     VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT |
                                                                     VkBufferUsageFlags.VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR);

            VkDeviceOrHostAddressConstKHR vertexBufferDeviceAddress = default;
            vertexBufferDeviceAddress.deviceAddress = vertexBuffer.deviceAddress;

            VkDeviceOrHostAddressConstKHR indexBufferDeviceAddress = default;
            indexBufferDeviceAddress.deviceAddress = indexBuffer.deviceAddress;

            VkAccelerationStructureGeometryKHR asGeometryInfo = default;
            asGeometryInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR;
            asGeometryInfo.flags = VkGeometryFlagsKHR.VK_GEOMETRY_OPAQUE_BIT_KHR;
            asGeometryInfo.geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_TRIANGLES_KHR;
            asGeometryInfo.geometry.triangles.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR;
            asGeometryInfo.geometry.triangles.vertexData = vertexBufferDeviceAddress;
            asGeometryInfo.geometry.triangles.indexData = indexBufferDeviceAddress;
            asGeometryInfo.geometry.triangles.vertexFormat = VkFormat.VK_FORMAT_R32G32B32_SFLOAT;
            asGeometryInfo.geometry.triangles.maxVertex = (uint)vertices.Length / 3;
            asGeometryInfo.geometry.triangles.vertexStride = sizeof(float) * 3;
            asGeometryInfo.geometry.triangles.indexType = VkIndexType.VK_INDEX_TYPE_UINT32;

            VkAccelerationStructureBuildGeometryInfoKHR asBuildSizeGeometryInfo = default;
            asBuildSizeGeometryInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR;
            asBuildSizeGeometryInfo.type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR;
            asBuildSizeGeometryInfo.flags = VkBuildAccelerationStructureFlagsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR;
            asBuildSizeGeometryInfo.geometryCount = 1;
            asBuildSizeGeometryInfo.pGeometries = &asGeometryInfo;

            // aquire size to build acceleration structure
            uint primitiveCount = (uint)(vertices.Length / 3);
            VkAccelerationStructureBuildSizesInfoKHR asBuildSizesInfo = default;
            asBuildSizesInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR;
            VulkanNative.vkGetAccelerationStructureBuildSizesKHR(
                device, VkAccelerationStructureBuildTypeKHR.VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR, &asBuildSizeGeometryInfo,
                &primitiveCount, &asBuildSizesInfo);

            // reserve memory to hold the acceleration structure
            AccelerationMemory bottomLevelASMemory =
                CreateAccelerationBuffer((uint)asBuildSizesInfo.accelerationStructureSize,
                                         VkBufferUsageFlags.VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR |
                                             VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT);

            VkAccelerationStructureCreateInfoKHR accelerationStructureInfo = default;
            accelerationStructureInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR;
            accelerationStructureInfo.buffer = bottomLevelASMemory.buffer;
            accelerationStructureInfo.size = asBuildSizesInfo.accelerationStructureSize;
            accelerationStructureInfo.type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR;

            fixed (VkAccelerationStructureKHR* bottomLevelASPtr = &bottomLevelAS)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateAccelerationStructureKHR(device, &accelerationStructureInfo, null, bottomLevelASPtr));
            }

            // reserve memory to build acceleration structure
            AccelerationMemory scratchMemory = this.CreateAccelerationBuffer(
                (uint)asBuildSizesInfo.buildScratchSize,
                VkBufferUsageFlags.VK_BUFFER_USAGE_STORAGE_BUFFER_BIT | VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT);

            VkAccelerationStructureBuildGeometryInfoKHR asBuildGeometryInfo = default;
            asBuildGeometryInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR;
            asBuildGeometryInfo.type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR;
            asBuildGeometryInfo.flags = VkBuildAccelerationStructureFlagsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR;
            asBuildGeometryInfo.mode = VkBuildAccelerationStructureModeKHR.VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR;
            asBuildGeometryInfo.dstAccelerationStructure = bottomLevelAS;
            asBuildGeometryInfo.geometryCount = 1;
            asBuildGeometryInfo.pGeometries = &asGeometryInfo;
            asBuildGeometryInfo.scratchData.deviceAddress = scratchMemory.deviceAddress;

            VkAccelerationStructureBuildRangeInfoKHR asBuildRangeInfo = default;
            asBuildRangeInfo.primitiveCount = primitiveCount;
            asBuildRangeInfo.primitiveOffset = 0;
            asBuildRangeInfo.firstVertex = 0;
            asBuildRangeInfo.transformOffset = 0;
            VkAccelerationStructureBuildRangeInfoKHR*[] asBuildRangeInfos = new VkAccelerationStructureBuildRangeInfoKHR*[] { &asBuildRangeInfo };

            VkCommandBuffer commandBuffer;

            VkCommandBufferAllocateInfo commandBufferAllocateInfo = default;
            commandBufferAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO;
            commandBufferAllocateInfo.commandPool = commandPool;
            commandBufferAllocateInfo.level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY;
            commandBufferAllocateInfo.commandBufferCount = 1;

            Helpers.CheckErrors(VulkanNative.vkAllocateCommandBuffers(device, &commandBufferAllocateInfo, &commandBuffer));

            VkCommandBufferBeginInfo commandBufferBeginInfo = default;
            commandBufferBeginInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO;
            commandBufferBeginInfo.flags = VkCommandBufferUsageFlags.VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT;

            Helpers.CheckErrors(VulkanNative.vkBeginCommandBuffer(commandBuffer, &commandBufferBeginInfo));

            // build the bottom-level acceleration structure
            fixed (VkAccelerationStructureBuildRangeInfoKHR** asBuildRangeInfosPtr = &asBuildRangeInfos[0])
            {
                VulkanNative.vkCmdBuildAccelerationStructuresKHR(commandBuffer, 1, &asBuildGeometryInfo, asBuildRangeInfosPtr);
            }

            Helpers.CheckErrors(VulkanNative.vkEndCommandBuffer(commandBuffer));

            VkSubmitInfo submitInfo = default;
            submitInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO;
            submitInfo.commandBufferCount = 1;
            submitInfo.pCommandBuffers = &commandBuffer;

            VkFence fence = VK_NULL_HANDLE;

            VkFenceCreateInfo fenceInfo = default;
            fenceInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_CREATE_INFO;

            Helpers.CheckErrors(VulkanNative.vkCreateFence(device, &fenceInfo, null, &fence));
            Helpers.CheckErrors(VulkanNative.vkQueueSubmit(this.graphicsQueue, 1, &submitInfo, fence));
            Helpers.CheckErrors(VulkanNative.vkWaitForFences(device, 1, &fence, true, UInt64.MaxValue));

            VulkanNative.vkDestroyFence(device, fence, null);
            VulkanNative.vkFreeCommandBuffers(device, commandPool, 1, &commandBuffer);

            // Get bottom level acceleration structure handle for use in top level instances
            VkAccelerationStructureDeviceAddressInfoKHR asDeviceAddressInfo = default;
            asDeviceAddressInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR;
            asDeviceAddressInfo.accelerationStructure = bottomLevelAS;
            bottomLevelASHandle = VulkanNative.vkGetAccelerationStructureDeviceAddressKHR(device, &asDeviceAddressInfo);

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

            // clang-format off
            VkTransformMatrixKHR instanceTransform = new VkTransformMatrixKHR()
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
            };
            // clang-format on

            VkAccelerationStructureInstanceKHR instance = default;
            instance.transform = instanceTransform;
            instance.instanceCustomIndex = 0;
            instance.mask = 0xFF;
            instance.instanceShaderBindingTableRecordOffset = 0;
            instance.flags = VkGeometryInstanceFlagsKHR.VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR;
            instance.accelerationStructureReference = bottomLevelASHandle;
            VkAccelerationStructureInstanceKHR[] instances = { instance };

            AccelerationMemory instanceBuffer = CreateMappedBuffer(
                instances, (uint)sizeof(VkAccelerationStructureInstanceKHR),
                VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT |
                 VkBufferUsageFlags.VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR);

            VkDeviceOrHostAddressConstKHR instanceDataDeviceAddress = default;
            instanceDataDeviceAddress.deviceAddress = instanceBuffer.deviceAddress;

            VkAccelerationStructureGeometryKHR asGeometryInfo = default;
            asGeometryInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR;
            asGeometryInfo.flags = VkGeometryFlagsKHR.VK_GEOMETRY_OPAQUE_BIT_KHR;
            asGeometryInfo.geometryType = VkGeometryTypeKHR.VK_GEOMETRY_TYPE_INSTANCES_KHR;
            asGeometryInfo.geometry.instances.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR;
            asGeometryInfo.geometry.instances.arrayOfPointers = false;
            asGeometryInfo.geometry.instances.data = instanceDataDeviceAddress;

            VkAccelerationStructureBuildGeometryInfoKHR asBuildSizeGeometryInfo = default;
            asBuildSizeGeometryInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR;
            asBuildSizeGeometryInfo.type = VkAccelerationStructureTypeKHR. VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR;
            asBuildSizeGeometryInfo.flags = VkBuildAccelerationStructureFlagsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR;
            asBuildSizeGeometryInfo.geometryCount = 1;
            asBuildSizeGeometryInfo.pGeometries = &asGeometryInfo;

            // aquire size to build acceleration structure
            uint primitiveCount = 1;
            VkAccelerationStructureBuildSizesInfoKHR asBuildSizesInfo = default;
            asBuildSizesInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR;
            VulkanNative.vkGetAccelerationStructureBuildSizesKHR(
                device, VkAccelerationStructureBuildTypeKHR.VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR, &asBuildSizeGeometryInfo,
                &primitiveCount, &asBuildSizesInfo);

            // reserve memory to hold the acceleration structure
            AccelerationMemory topLevelASMemory =
                CreateAccelerationBuffer((uint)asBuildSizesInfo.accelerationStructureSize,
                                         VkBufferUsageFlags.VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR |
                                             VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT);

            VkAccelerationStructureCreateInfoKHR accelerationStructureInfo = default;
            accelerationStructureInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR;
            accelerationStructureInfo.buffer = topLevelASMemory.buffer;
            accelerationStructureInfo.size = asBuildSizesInfo.accelerationStructureSize;
            accelerationStructureInfo.type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR;

            fixed (VkAccelerationStructureKHR* topLevelASPtr = &topLevelAS)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateAccelerationStructureKHR(device, &accelerationStructureInfo,null, topLevelASPtr));
            }

            // reserve memory to build acceleration structure
            AccelerationMemory scratchMemory = this.CreateAccelerationBuffer(
                (uint)asBuildSizesInfo.buildScratchSize,
                VkBufferUsageFlags.VK_BUFFER_USAGE_STORAGE_BUFFER_BIT | VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT);

            VkAccelerationStructureBuildGeometryInfoKHR asBuildGeometryInfo = default;
            asBuildGeometryInfo.sType =
                VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR;
            asBuildGeometryInfo.type = VkAccelerationStructureTypeKHR.VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR;
            asBuildGeometryInfo.flags = VkBuildAccelerationStructureFlagsKHR.VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR;
            asBuildGeometryInfo.mode = VkBuildAccelerationStructureModeKHR.VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR;
            asBuildGeometryInfo.dstAccelerationStructure = topLevelAS;
            asBuildGeometryInfo.geometryCount = 1;
            asBuildGeometryInfo.pGeometries = &asGeometryInfo;
            asBuildGeometryInfo.scratchData.deviceAddress = scratchMemory.deviceAddress;

            VkAccelerationStructureBuildRangeInfoKHR asBuildRangeInfo = default;
            asBuildRangeInfo.primitiveCount = primitiveCount;
            asBuildRangeInfo.primitiveOffset = 0;
            asBuildRangeInfo.firstVertex = 0;
            asBuildRangeInfo.transformOffset = 0;
            VkAccelerationStructureBuildRangeInfoKHR*[] asBuildRangeInfos = {
            &asBuildRangeInfo};

            VkCommandBuffer commandBuffer;

            VkCommandBufferAllocateInfo commandBufferAllocateInfo = default;
            commandBufferAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO;
            commandBufferAllocateInfo.commandPool = commandPool;
            commandBufferAllocateInfo.level = VkCommandBufferLevel.VK_COMMAND_BUFFER_LEVEL_PRIMARY;
            commandBufferAllocateInfo.commandBufferCount = 1;

            Helpers.CheckErrors(VulkanNative.
                vkAllocateCommandBuffers(device, &commandBufferAllocateInfo, &commandBuffer));

            VkCommandBufferBeginInfo commandBufferBeginInfo = default;
            commandBufferBeginInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO;
            commandBufferBeginInfo.flags = VkCommandBufferUsageFlags.VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT;

            Helpers.CheckErrors(VulkanNative.vkBeginCommandBuffer(commandBuffer, &commandBufferBeginInfo));

            // build the top-level acceleration structure
            fixed (VkAccelerationStructureBuildRangeInfoKHR** asBuildRangeInfosPtr = &asBuildRangeInfos[0])
            {
                VulkanNative.vkCmdBuildAccelerationStructuresKHR(commandBuffer, 1, &asBuildGeometryInfo, asBuildRangeInfosPtr);
            }

            Helpers.CheckErrors(VulkanNative.vkEndCommandBuffer(commandBuffer));

            VkSubmitInfo submitInfo = default;
            submitInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_SUBMIT_INFO;
            submitInfo.commandBufferCount = 1;
            submitInfo.pCommandBuffers = &commandBuffer;

            VkFence fence = VK_NULL_HANDLE;

            VkFenceCreateInfo fenceInfo = default;
            fenceInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_CREATE_INFO;

            Helpers.CheckErrors(VulkanNative.vkCreateFence(device, &fenceInfo, null, &fence));
            Helpers.CheckErrors(VulkanNative.vkQueueSubmit(this.graphicsQueue, 1, &submitInfo, fence));
            Helpers.CheckErrors(VulkanNative.vkWaitForFences(device, 1, &fence, true, UInt64.MaxValue));

            VulkanNative.vkDestroyFence(device, fence, null);
            VulkanNative.vkFreeCommandBuffers(device, commandPool, 1, &commandBuffer);

            // Get top level acceleration structure handle
            VkAccelerationStructureDeviceAddressInfoKHR deviceAddressInfo = default;
            deviceAddressInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR;
            deviceAddressInfo.accelerationStructure = topLevelAS;
            topLevelASHandle = VulkanNative.vkGetAccelerationStructureDeviceAddressKHR(device, &deviceAddressInfo);

            // make sure bottom AS handle is valid
            if (bottomLevelASHandle == 0)
            {
                Debug.WriteLine("Invalid Handle to TLAS");
                throw new Exception("Invalid Handle to TLAS");
            }
        }

        private void CreateOffscreenBuffer()
        {
            Debug.WriteLine("Creating Offsceen Buffer..");

            VkImageCreateInfo imageInfo = default;
            imageInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO;
            imageInfo.imageType = VkImageType.VK_IMAGE_TYPE_2D;
            imageInfo.format = this.swapChainImageFormat;
            imageInfo.extent = new VkExtent3D { width = this.swapChainExtent.width, height = this.swapChainExtent.height, depth = 1 };
            imageInfo.mipLevels = 1;
            imageInfo.arrayLayers = 1;
            imageInfo.samples = VkSampleCountFlags.VK_SAMPLE_COUNT_1_BIT;
            imageInfo.usage = VkImageUsageFlags.VK_IMAGE_USAGE_STORAGE_BIT | VkImageUsageFlags.VK_IMAGE_USAGE_TRANSFER_SRC_BIT;

            fixed (VkImage* offscreenBufferPtr = &offscreenBuffer)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateImage(device, &imageInfo, null, offscreenBufferPtr));
            }

            VkMemoryRequirements memoryRequirements = default;
            VulkanNative.vkGetImageMemoryRequirements(device, offscreenBuffer, &memoryRequirements);

            VkMemoryAllocateInfo memoryAllocateInfo = default;
            memoryAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO;
            memoryAllocateInfo.allocationSize = memoryRequirements.size;
            memoryAllocateInfo.memoryTypeIndex = this.FindMemoryType(memoryRequirements.memoryTypeBits, VkMemoryPropertyFlags.VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT);

            fixed (VkDeviceMemory* offscreenBufferMemoryPtr = &this.offscreenBufferMemory)
            {
                Helpers.CheckErrors(VulkanNative.vkAllocateMemory(device, &memoryAllocateInfo, null, offscreenBufferMemoryPtr));
            }

            Helpers.CheckErrors(VulkanNative.vkBindImageMemory(device, offscreenBuffer, offscreenBufferMemory, 0));

            VkImageViewCreateInfo imageViewInfo = default;
            imageViewInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO;
            imageViewInfo.viewType = VkImageViewType.VK_IMAGE_VIEW_TYPE_2D;
            imageViewInfo.format = this.swapChainImageFormat;
            imageViewInfo.subresourceRange = default;
            imageViewInfo.subresourceRange.aspectMask = VkImageAspectFlags.VK_IMAGE_ASPECT_COLOR_BIT;
            imageViewInfo.subresourceRange.baseMipLevel = 0;
            imageViewInfo.subresourceRange.levelCount = 1;
            imageViewInfo.subresourceRange.baseArrayLayer = 0;
            imageViewInfo.subresourceRange.layerCount = 1;
            imageViewInfo.image = offscreenBuffer;
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
            descriptorPoolInfo.maxSets = 1;
            descriptorPoolInfo.poolSizeCount = 2;
            descriptorPoolInfo.pPoolSizes = poolSizes;

            fixed (VkDescriptorPool* descriptorPoolPtr = &this.descriptorPool)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateDescriptorPool(device, &descriptorPoolInfo, null, descriptorPoolPtr));
            }

            VkDescriptorSetAllocateInfo descriptorSetAllocateInfo = default;
            descriptorSetAllocateInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO;
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
            pipelineLayoutInfo.setLayoutCount = 1;
            fixed (VkDescriptorSetLayout* descriptorSetLayoutPtr = &descriptorSetLayout)
            {
                pipelineLayoutInfo.pSetLayouts = descriptorSetLayoutPtr;
            }

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
            rayGenGroup.type = VkRayTracingShaderGroupTypeKHR.VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR;
            rayGenGroup.generalShader = 0;
            rayGenGroup.closestHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayGenGroup.anyHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayGenGroup.intersectionShader = VulkanNative.VK_SHADER_UNUSED_KHR;

            VkRayTracingShaderGroupCreateInfoKHR rayHitGroup = default;
            rayHitGroup.sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR;
            rayHitGroup.type = VkRayTracingShaderGroupTypeKHR.VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR;
            rayHitGroup.generalShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayHitGroup.closestHitShader = 1;
            rayHitGroup.anyHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayHitGroup.intersectionShader = VulkanNative.VK_SHADER_UNUSED_KHR;

            VkRayTracingShaderGroupCreateInfoKHR rayMissGroup = default;
            rayMissGroup.sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR;
            rayMissGroup.type = VkRayTracingShaderGroupTypeKHR.VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR;
            rayMissGroup.generalShader = 2;
            rayMissGroup.closestHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayMissGroup.anyHitShader = VulkanNative.VK_SHADER_UNUSED_KHR;
            rayMissGroup.intersectionShader = VulkanNative.VK_SHADER_UNUSED_KHR;

            VkRayTracingShaderGroupCreateInfoKHR* shaderGroups = stackalloc VkRayTracingShaderGroupCreateInfoKHR[] { rayGenGroup, rayHitGroup, rayMissGroup };

            VkRayTracingPipelineCreateInfoKHR pipelineInfo = default;
            pipelineInfo.sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR;
            pipelineInfo.stageCount = 3;
            pipelineInfo.pStages = shaderStages;
            pipelineInfo.groupCount = 3;
            pipelineInfo.pGroups = shaderGroups;
            pipelineInfo.maxPipelineRayRecursionDepth = 1;            
            pipelineInfo.layout = pipelineLayout;

            fixed (VkPipeline* pipelinePtr = &pipeline)
            {
                Helpers.CheckErrors(VulkanNative.vkCreateRayTracingPipelinesKHR(device, 0, 0, 1, &pipelineInfo, null, pipelinePtr));
            }
        }

        private void CreateShaderBindingTable()
        {
            /*Debug.WriteLine("Creating Shader Binding Table..");

            AccelerationMemory newShaderBindingTable = default;
            shaderBindingTableSize = shaderBindingTableGroupCount * rayTracingPipelineProperties.shaderGroupHandleSize;

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

            this.shaderBindingTable = newShaderBindingTable;*/

            Debug.WriteLine("Creating Shader Binding Table..");

            SBTHandleSize = rayTracingPipelineProperties.shaderGroupHandleSize;
            SBTHandleAlignment = rayTracingPipelineProperties.shaderGroupHandleAlignment;
            SBTHandleSizeAligned = this.AlignTo(SBTHandleSize, SBTHandleAlignment);
            SBTSize = SBTGroupCount * SBTHandleSizeAligned;

            ushort[] sbtResults = new ushort[SBTSize];

            Helpers.CheckErrors(VulkanNative.vkGetRayTracingShaderGroupHandlesKHR(device, pipeline, 0, SBTGroupCount, new UIntPtr(SBTSize), sbtResults));

            // create 3 separate buffers for each ray type
            SBTRayGenBuffer = this.CreateMappedBuffer(sbtResults, SBTHandleSize,
                                                  VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR |
                                                     VkBufferUsageFlags. VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT);

            SBTRayMissBuffer = this.CreateMappedBuffer(sbtResults + SBTHandleSizeAligned, SBTHandleSize,
                                    VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR |
                                       VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT);
            SBTRayHitBuffer = this.CreateMappedBuffer(sbtResults + SBTHandleSizeAligned * 2, SBTHandleSize,
                                   VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR |
                                       VkBufferUsageFlags.VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT);


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
                size = SBTHandleSize
            };

            VkStridedBufferRegionKHR rayMissSBT = new VkStridedBufferRegionKHR
            {
                buffer = shaderBindingTable.buffer,
                offset = 2 * rayTracingPipelineProperties.shaderGroupHandleSize,
                stride = 0,
                size = SBTHandleSize
            }
            ;
            VkStridedBufferRegionKHR rayHitSBT = new VkStridedBufferRegionKHR()
            {
                buffer = shaderBindingTable.buffer,
                offset = 1 * rayTracingPipelineProperties.shaderGroupHandleSize,
                stride = 0,
                size = SBTHandleSize
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
