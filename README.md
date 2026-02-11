# Vulkan.NET
This repository contains low-level bindings for Vulkan used in Evergine for .NET 8.0.
This binding is generated from vk.xml file included in the KhronosRegistry:
https://github.com/KhronosGroup/Vulkan-Docs/blob/main/xml/vk.xml.

[![CI](https://github.com/EvergineTeam/Vulkan.NET/actions/workflows/CI.yml/badge.svg)](https://github.com/EvergineTeam/Vulkan.NET/actions/workflows/CI.yml)
[![Monthly update check](https://github.com/EvergineTeam/Vulkan.NET/actions/workflows/monthly_update.yml/badge.svg)](https://github.com/EvergineTeam/Vulkan.NET/actions/workflows/monthly_update.yml)
[![Nuget](https://img.shields.io/nuget/v/Evergine.Bindings.Vulkan?logo=nuget)](https://www.nuget.org/packages/Evergine.Bindings.Vulkan)

## Features

- Vulkan 1.0, 1.1, 1.2, 1.3
- All Vulkan Extensions as Vulkan RayTracing
- Raw low level binding using unsafe c# code.

## Draw Triangle Rasterization
Test based on https://vulkan-tutorial.com/

![alt Draw Triangle Rasterization](https://github.com/EvergineTeam/Vulkan.NET/blob/master/RasterizationTest.png)

## Draw Triangle Raytracing (KHR)
Test based on https://github.com/maierfelix/VK_KHR_ray_tracing

**Build Requirements**
 - [NVIDIA Vulkan Beta Driver](https://developer.nvidia.com/vulkan-driver) (Tested with [442.98](https://developer.nvidia.com/vulkan-beta-44298-windows-10))
 - [Vulkan SDK >= 1.2.135.0](https://vulkan.lunarg.com/sdk/home)

![alt Draw Triangle Raytracing](https://github.com/EvergineTeam/Vulkan.NET/blob/master/RaytracingTest.png)
