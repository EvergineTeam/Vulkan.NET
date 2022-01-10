# Vulkan.NET
This repository contains low-level bindings for Vulkan used in Evergine for .NET Core and .NET 5.0.
This binding is generated from vk.xml file included in the KhronosRegistry folder.

[![Build status](https://waveengineteam.visualstudio.com/Evergine/_apis/build/status/Bindings/Evergine.Bindings.Vulkan)](https://waveengineteam.visualstudio.com/Evergine/_build/latest?definitionId=58)
[![Nuget](https://img.shields.io/nuget/v/Evergine.Bindings.Vulkan?logo=nuget)](https://www.nuget.org/packages/Evergine.Bindings.Vulkan)
[![Update_and_Generate_NuGet](https://github.com/EvergineTeam/Vulkan.NET/actions/workflows/download_latest_spect_generate_nuget.yml/badge.svg)](https://github.com/Evergine/Vulkan.NET/actions/workflows/download_latest_spect_generate_nuget.yml)

## Features

- Vulkan 1.0, 1.1, 1.2
- All Vulkan Extensions as Vulkan RayTracing
- Raw low level binding using usafe c# code.

## Draw Triangle Rasterization
Test based on https://vulkan-tutorial.com/

![alt Draw Triangle Rasterization](https://github.com/EvergineTeam/Vulkan.NET/blob/master/RasterizationTest.png)

## Draw Triangle Raytracing (KHR)
Test based on https://github.com/maierfelix/VK_KHR_ray_tracing

**Build Requirements**
 - [NVIDIA Vulkan Beta Driver](https://developer.nvidia.com/vulkan-driver) (Tested with [442.98](https://developer.nvidia.com/vulkan-beta-44298-windows-10))
 - [Vulkan SDK >= 1.2.135.0](https://vulkan.lunarg.com/sdk/home)

![alt Draw Triangle Raytracing](https://github.com/EvergineTeam/Vulkan.NET/blob/master/RaytracingTest.png)

## Related Work

- [vk](https://github.com/mellinoe/vk)

