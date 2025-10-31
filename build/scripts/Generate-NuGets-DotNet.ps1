<#
.SYNOPSIS
	Evergine NuGet Packages generator script, (c) 2025 Evergine Team
.DESCRIPTION
	This script generates NuGet packages for Evergine projects using dotnet pack.
	Supports both single and multiple project scenarios with flexible versioning.
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.PARAMETER Version
	Direct version string to use for packages (used by add-ons)
.PARAMETER Revision
	Revision number to append to date-based version (used by bindings)
.PARAMETER Projects
	Array of .csproj paths to pack. For single project, can be a string.
.PARAMETER OutputFolderBase
	Base folder for NuGet package output
.PARAMETER BuildVerbosity
	dotnet verbosity level
.PARAMETER BuildConfiguration
	Build configuration (Release, Debug, etc.)
.PARAMETER IncludeSymbols
	Whether to include debug symbols in packages
.PARAMETER SymbolsFormat
	Symbol package format: 'snupkg' (modern, default) or 'symbols.nupkg' (legacy)
.PARAMETER HelpersPath
	Path to the Helpers.ps1 file. Defaults to Helpers.ps1 in the same directory as this script.
.EXAMPLE
	# Binding style (date-based version with revision)
	.\Generate-NuGets-DotNet.ps1 -Revision 123 -Projects "SampleBinding\Evergine.Bindings.Sample\Evergine.Bindings.Sample.csproj"
.EXAMPLE
	# Add-on style (direct version)
	.\Generate-NuGets-DotNet.ps1 -Version "3.4.22.288-local" -Projects @("Source\Evergine.SampleAddon\Evergine.SampleAddon.csproj", "Source\Evergine.SampleAddon.Editor\Evergine.SampleAddon.Editor.csproj")
.EXAMPLE
	# Using custom helpers path
	.\Generate-NuGets-DotNet.ps1 -Revision 123 -Projects "test.csproj" -HelpersPath "C:\Scripts\MyHelpers.ps1"
.EXAMPLE
	# Using legacy symbol format
	.\Generate-NuGets-DotNet.ps1 -Version "1.0.0" -Projects "test.csproj" -SymbolsFormat "symbols.nupkg"
.LINK
	https://evergine.com/
#>

param (
    [string]$Version,
    [string]$Revision,
    [Parameter(Mandatory = $true)]$Projects,
    [string]$OutputFolderBase = "nupkgs",
    [string]$BuildVerbosity = "normal",
    [string]$BuildConfiguration = "Release",
    [bool]$IncludeSymbols = $false,
    [ValidateSet("snupkg", "symbols.nupkg")]
    [string]$SymbolsFormat = "snupkg",
    [string]$HelpersPath = "$PSScriptRoot\Helpers.ps1"
)

# Import shared helper functions
if (Test-Path $HelpersPath) {
    . $HelpersPath
}
else {
    throw "Helpers file not found at: $HelpersPath. Please ensure Helpers.ps1 is available or specify correct path with -HelpersPath parameter."
}

# Parameter validation
if ([string]::IsNullOrEmpty($Version) -and [string]::IsNullOrEmpty($Revision)) {
    throw "Either -Version or -Revision parameter must be provided"
}

if (![string]::IsNullOrEmpty($Version) -and ![string]::IsNullOrEmpty($Revision)) {
    throw "Cannot specify both -Version and -Revision parameters"
}

if ($Projects -eq $null -or $Projects.Count -eq 0 -or ($Projects -is [array] -and $Projects.Length -eq 0)) {
    throw "Projects parameter cannot be empty"
}

# Convert Projects to array if it's a single string
if ($Projects -is [string]) {
    $Projects = @($Projects)
}

# Calculate version
if (![string]::IsNullOrEmpty($Revision)) {
    $Version = "$(Get-Date -Format "yyyy.M.d").$Revision"
}

# Validate version format (NuGet semantic versioning)
# See: https://docs.microsoft.com/en-us/nuget/concepts/package-versioning
if ($Version -notmatch '^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)(?:\.(0|[1-9]\d*))?(?:-([a-zA-Z0-9](?:[a-zA-Z0-9\-]*[a-zA-Z0-9])?)(?:\.([a-zA-Z0-9](?:[a-zA-Z0-9\-]*[a-zA-Z0-9])?))*)?$') {
    throw "Invalid version format: '$Version'. NuGet version must follow semantic versioning (e.g., '1.0.0', '1.0.0-alpha', '1.0.0.123')."
}

# Show variables
$parameters = @{
    "Version"            = $Version
    "Projects"           = ($Projects -join ", ")
    "BuildConfiguration" = $BuildConfiguration
    "BuildVerbosity"     = $BuildVerbosity
    "OutputFolderBase"   = $OutputFolderBase
    "IncludeSymbols"     = $IncludeSymbols
    "SymbolsFormat"      = $SymbolsFormat
}

ShowVariables $parameters

# Create output folder
$absoluteOutputFolder = CreateOutputFolder $OutputFolderBase

# Generate packages
LogDebug "START packaging process"

foreach ($projectPath in $Projects) {
    LogDebug "Processing project: $projectPath"
	
    if (!(Test-Path $projectPath)) {
        throw "Project file not found: $projectPath"
    }
	
    LogDebug "Packing $projectPath with dotnet"
    
    # Build dotnet pack command with appropriate symbol format
    $packArgs = @(
        "pack", $projectPath,
        "--verbosity", $BuildVerbosity,
        "--configuration", $BuildConfiguration,
        "--output", $absoluteOutputFolder,
        "-p:PackageVersion=$Version"
    )
    
    if ($IncludeSymbols) {
        if ($SymbolsFormat -eq "snupkg") {
            $packArgs += "-p:IncludeSymbols=true"
            $packArgs += "-p:SymbolPackageFormat=snupkg"
        }
        else {
            $packArgs += "-p:IncludeSymbols=true"
        }
    }
    else {
        $packArgs += "-p:IncludeSymbols=false"
    }
    
    & dotnet @packArgs
	
    if ($LASTEXITCODE -ne 0) {
        throw "dotnet pack failed for $projectPath"
    }
}

LogDebug "END packaging process"
LogDebug "NuGet packages generated in: $absoluteOutputFolder"