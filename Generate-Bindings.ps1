<#
.SYNOPSIS
	Evergine bindings generator script, (c) 2024 Evergine Team
.DESCRIPTION
	This script generates Vulkan bindings used in Evergine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script>
.LINK
	https://evergine.com/
#>

param (
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release",
	[string]$vulkanGenCsprojPath = "VulkanGen\VulkanGen\VulkanGen.csproj"
)

# Utility functions
function LogDebug($line)
{ Write-Host "##[debug] $line" -Foreground Blue -Background Black
}

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "#######################################"

# Compile generator
LogDebug "START generator build process"
dotnet publish -v:$buildVerbosity -p:Configuration=$buildConfiguration $vulkanGenCsprojPath
if($?)
{
   LogDebug "END generator build process"
}
else
{
	LogDebug "ERROR; Generator build failed"
   	exit -1
}

# Run generator
LogDebug "START binding generator process"
pushd .\VulkanGen\VulkanGen\bin\Release\net8.0\
.\publish\VulkanGen.exe
if($?)
{
   LogDebug "END binding generator process"
}
else
{
	LogDebug "ERROR; Binding Generation failed"
   	exit -1
}
popd
