<#
.SYNOPSIS
	Wave Engine bindings NuGet Packages generator script, (c) 2020 Javier Cantón Ferrero
.DESCRIPTION
	This script generates NuGet packages for the low-level Vulkan bindings used in Wave Engine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script> -version 3.4.22.288-local
.LINK
	https://waveengine.net
#>

param (
    [Parameter(mandatory=$true)][string]$version,	
	[string]$outputFolderBase = "nupkgs",
	[string]$buildVerbosity = "minimal",
	[string]$buildConfiguration = "Release",
	[string]$vulkanBindingsCsprojPath = "VulkanGen\VulkanGen\WaveEngine.Bindings.Vulkan\WaveEngine.Bindings.Vulkan.csproj"
)

# Utility functions
function LogDebug($line) { Write-Host "##[debug] $line" -Foreground Blue -Background Black }

# Locate build tools
$msbuildPath = tools\vswhere.exe -latest -prerelease -products * -requires Microsoft.Component.MSBuild -property installationPath
if(-Not $?) { exit $lastexitcode }
$msbuildPath = Resolve-Path (Join-Path $msbuildPath 'MSBuild\*\Bin\MSBuild.exe')
if (-Not (Test-Path $msbuildPath)) { throw "MSBuild not found." }

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Version.............: $version"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "Output folder.......: $outputFolderBase"
LogDebug "#######################################"

# Create output folder
$outputFolder = Join-Path $outputFolderBase $versionWithSuffix
New-Item -ItemType Directory -Force -Path $outputFolder
$absoluteOutputFolder = Resolve-Path $outputFolder

# Generate packages
LogDebug "START packaging process"
& $msbuildPath /nologo "$vulkanBindingsCsprojPath" /t:restore,build,pack /p:Configuration=$buildConfiguration /v:$buildVerbosity /p:PackageOutputPath="$absoluteOutputFolder" /p:IncludeSymbols=true /p:Version=$version

LogDebug "END packaging process"