<#
.SYNOPSIS
	Evergine bindings NuGet Packages generator script, (c) 2024 Evergine Team
.DESCRIPTION
	This script generates NuGet packages for the low-level Vulkan bindings used in Evergine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script> -version 2021.11.17.1-local
.LINK
	https://evergine.com/
#>

param (
	[Parameter(mandatory=$true)][string]$version,
	[string]$outputFolderBase = "nupkgs",
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release",
	[string]$vulkanBindingsCsprojPath = "VulkanGen\Evergine.Bindings.Vulkan\Evergine.Bindings.Vulkan.csproj"
)

# Utility functions
function LogDebug($line)
{ Write-Host "##[debug] $line" -Foreground Blue -Background Black
}

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Version.............: $version"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "Output folder.......: $outputFolderBase"
LogDebug "#######################################"

# Create output folder
$outputFolder = Join-Path $outputFolderBase $version
New-Item -ItemType Directory -Force -Path $outputFolder
$absoluteOutputFolder = Resolve-Path $outputFolder

$symbols = false
if($buildConfiguration -eq "Debug")
{
	$symbols = true
}

# Generate packages
LogDebug "START packaging process"
dotnet pack "$vulkanBindingsCsprojPath" -v:$buildVerbosity -p:Configuration=$buildConfiguration -p:PackageOutputPath="$absoluteOutputFolder" -p:IncludeSymbols=$symbols -p:Version=$version
if($?)
{
   LogDebug "END packaging process"
}
else
{
	LogDebug "ERROR; dotnet pack failed"
   	exit -1
}

