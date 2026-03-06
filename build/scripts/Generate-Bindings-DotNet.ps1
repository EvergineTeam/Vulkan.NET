<#
.SYNOPSIS
	Evergine bindings generator script, (c) 2025 Evergine Team
.DESCRIPTION
	This script generates bindings used in Evergine using a .NET generator
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.PARAMETER BuildVerbosity
	Build verbosity level for dotnet commands
.PARAMETER BuildConfiguration
	Build configuration (Debug/Release)
.PARAMETER GeneratorProject
	Path to the generator .csproj file
.PARAMETER GeneratorName
	Name of the generator (used for display and executable name)
.PARAMETER TargetFramework
	Target framework for the generator (default: net8.0)
.PARAMETER RuntimeIdentifier
	Runtime identifier for the generator (e.g., win-x64)
.EXAMPLE
	.\Generate-Bindings-DotNet.ps1 -GeneratorProject "MyLibGen\MyLibGen\MyLibGen.csproj" -GeneratorName "MyLib"
.LINK
	https://evergine.com/
#>

param (
    [string]$BuildVerbosity = "normal",         # Verbosity for dotnet build/publish (e.g., minimal, normal, detailed)
    [string]$BuildConfiguration = "Release",   # Build configuration (Release/Debug)
    [string]$GeneratorProject = "",            # Path to the generator .csproj file
    [string]$GeneratorName = "",               # Generator name (used for display and executable name)
    [string]$TargetFramework = "net8.0",       # Target framework for the generator (default: net8.0)
    [string]$RuntimeIdentifier = "win-x64",    # Runtime identifier for the generator (e.g., win-x64)
    [switch]$TestMode                           # Load only functions for testing, do not execute main logic
)

# Exported utility functions for unit testing
function LogDebug($line) {
    Write-Host "##[debug] $line" -ForegroundColor Blue -BackgroundColor Black
}

function Get-BuildOutputPath {
    param(
        [string]$GeneratorDir,
        [string]$BuildConfiguration,
        [string]$TargetFramework,
        [string]$RuntimeIdentifier
    )
    $buildPath = "$GeneratorDir\bin\$BuildConfiguration\$TargetFramework"
    if (-not [string]::IsNullOrWhiteSpace($RuntimeIdentifier)) {
        $buildPath += "\$RuntimeIdentifier"
    }
    return $buildPath
}

function Get-ProjectNameFromPath {
    param([string]$ProjectPath)
    # Normalize separators for cross-platform compatibility
    $normalizedPath = $ProjectPath -replace '\\', '/'
    $filename = Split-Path $normalizedPath -Leaf
    return [System.IO.Path]::GetFileNameWithoutExtension($filename)
}

function Test-BindingParameters {
    param(
        [Parameter(Mandatory)] [hashtable]$params
    )
    if ([string]::IsNullOrWhiteSpace($params.GeneratorProject)) { return $false }
    if ([string]::IsNullOrWhiteSpace($params.GeneratorName)) { return $false }
    # Optionally: you could validate other parameters here
    return $true
}

# If in test mode, only load functions and exit
if ($TestMode) {
    return
}

# Validate required parameters
if (-not (Test-BindingParameters @{ GeneratorProject = $GeneratorProject; GeneratorName = $GeneratorName })) {
    Write-Host "ERROR: GeneratorProject and GeneratorName parameters are required" -ForegroundColor Red
    exit 1
}


# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Generator name......: $GeneratorName"
LogDebug "Generator project...: $GeneratorProject"
LogDebug "Build configuration.: $BuildConfiguration"
LogDebug "Build verbosity.....: $BuildVerbosity"
LogDebug "Target framework....: $TargetFramework"
LogDebug "Runtime identifier..: $RuntimeIdentifier"
LogDebug "#######################################"

# Validate generator project exists
if (-not (Test-Path $GeneratorProject)) {
    LogDebug "ERROR: Generator project not found at: $GeneratorProject"
    exit 1
}

# Compile generator
LogDebug "START $GeneratorName generator build process"
dotnet publish -v:$BuildVerbosity -p:Configuration=$BuildConfiguration $GeneratorProject
if ($LASTEXITCODE -eq 0) {
    LogDebug "END $GeneratorName generator build process"
}
else {
    LogDebug "ERROR: $GeneratorName generator build failed"
    exit 1
}

# Run generator
LogDebug "START $GeneratorName binding generator process"

$generatorDir = Split-Path $GeneratorProject -Parent
$projectName = Get-ProjectNameFromPath $GeneratorProject
$buildPath = Get-BuildOutputPath $generatorDir $BuildConfiguration $TargetFramework $RuntimeIdentifier

Push-Location $buildPath
try {
    # Detect platform and set executable path
    if ($IsWindows) {
        $exePath = ".\publish\$projectName.exe"
    }
    else {
        $exePath = "./publish/$projectName"
    }
    & $exePath
    if ($LASTEXITCODE -eq 0) {
        LogDebug "END $GeneratorName binding generator process"
    }
    else {
        LogDebug "ERROR: $GeneratorName binding generation failed"
        exit 1
    }
}
finally {
    Pop-Location
}

LogDebug "$GeneratorName bindings generated successfully!"