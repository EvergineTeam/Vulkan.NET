# Vulkan.NET
This repository contains low-level bindings for Vulkan used in WaveEngine for .NET Core and .NET 5.0.
This binding is generated from vk.xml file included in the KhronosRegistry folder.

[![Build Status](https://waveengineteam.visualstudio.com/Wave.Engine/_apis/build/status/Releases/WaveEngine.Bindings.Vulkan?branchName=master)](https://waveengineteam.visualstudio.com/Wave.Engine/_build?definitionId=58)
[![Nuget](https://img.shields.io/nuget/v/WaveEngine.Bindings.Vulkan?logo=nuget)](https://www.nuget.org/packages/WaveEngine.Bindings.Vulkan)

## Features

- Vulkan 1.0, 1.1, 1.2
- All Vulkan Extensions as Vulkan RayTracing
- Raw low level binding using usafe c# code.

## Draw Triangle Rasterization
Test based on https://vulkan-tutorial.com/

![alt Draw Triangle Rasterization](https://github.com/WaveEngine/Vulkan.NET/blob/master/RasterizationTest.png)

## Draw Triangle Raytracing (KHR)
Test based on https://github.com/maierfelix/VK_KHR_ray_tracing

**Build Requirements**
 - [NVIDIA Vulkan Beta Driver](https://developer.nvidia.com/vulkan-driver) (Tested with [442.98](https://developer.nvidia.com/vulkan-beta-44298-windows-10))
 - [Vulkan SDK >= 1.2.135.0](https://vulkan.lunarg.com/sdk/home)

![alt Draw Triangle Raytracing](https://github.com/WaveEngine/Vulkan.NET/blob/master/RaytracingTest.png)

## Related Work

- [vk](https://github.com/mellinoe/vk)

