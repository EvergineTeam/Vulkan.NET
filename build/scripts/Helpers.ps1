<#
.SYNOPSIS
	Evergine shared helper functions, (c) 2025 Evergine Team
.DESCRIPTION
	This script contains helper functions shared across different Evergine build and packaging scripts.
	These functions provide consistent logging, variable display, and common file operations.
.EXAMPLE
	. scripts/common/Helpers.ps1
	LogDebug "Starting process"
	$outputPath = CreateOutputFolder "nupkgs"
.LINK
	https://evergine.com/
#>

# Utility function for consistent debug logging
function LogDebug($line) {
    Write-Host "##[debug] $line" -ForegroundColor Blue -BackgroundColor Black
}

# Display script variables in a consistent format
function ShowVariables($parameters) {
    LogDebug "############## VARIABLES ##############"
    foreach ($param in $parameters.GetEnumerator()) {
        $paddedKey = $param.Key + (' ' * [Math]::Max(0, 20 - $param.Key.Length))
        $message = "${paddedKey}: $($param.Value)"
        LogDebug $message
    }
    LogDebug "#######################################"
}

# Create output folder and return absolute path
function CreateOutputFolder($outputFolderBase) {
    try {
        $null = New-Item -ItemType Directory -Force -Path $outputFolderBase -ErrorAction Stop
        Resolve-Path $outputFolderBase -ErrorAction Stop
    }
    catch {
        throw "Failed to create or resolve output folder: $outputFolderBase. Error: $($_.Exception.Message)"
    }
}

# Display script variables in a legacy format (for backward compatibility)
function ShowVariablesLegacy($version, $buildConfiguration, $buildVerbosity, $outputFolderBase) {
    LogDebug "############## VARIABLES ##############"
    LogDebug "Version.............: $version"
    LogDebug "Build configuration.: $buildConfiguration"
    LogDebug "Build verbosity.....: $buildVerbosity"
    LogDebug "Output folder.......: $outputFolderBase"
    LogDebug "#######################################"
}

# Calculate version from revision using date-based format
function Get-VersionFromRevision($revision) {
    if ([string]::IsNullOrWhiteSpace($revision)) {
        throw "Revision parameter cannot be null or empty"
    }
    return "$(Get-Date -Format "yyyy.M.d").$revision"
}

# Validate version format using NuGet semantic versioning rules
function Test-VersionFormat($version) {
    if ([string]::IsNullOrWhiteSpace($version)) {
        return $false
    }
    # NuGet semantic versioning pattern
    # See: https://docs.microsoft.com/en-us/nuget/concepts/package-versioning
    return $version -match '^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)(?:\.(0|[1-9]\d*))?(?:-([a-zA-Z0-9](?:[a-zA-Z0-9\-]*[a-zA-Z0-9])?)(?:\.([a-zA-Z0-9](?:[a-zA-Z0-9\-]*[a-zA-Z0-9])?))*)?$'
}

# Resolve version from Version, Revision, and optional VersionSuffix parameters
function Resolve-Version($version, $revision, $versionSuffix = "") {
    # Validate parameters
    if ([string]::IsNullOrEmpty($version) -and [string]::IsNullOrEmpty($revision)) {
        throw "Either Version or Revision parameter must be provided"
    }
    
    if (![string]::IsNullOrEmpty($version) -and ![string]::IsNullOrEmpty($revision)) {
        throw "Cannot specify both Version and Revision parameters"
    }
    
    # Calculate version if revision is provided
    if (![string]::IsNullOrEmpty($revision)) {
        $resolvedVersion = Get-VersionFromRevision $revision
    }
    else {
        $resolvedVersion = $version
    }
    
    # Validate version format (before applying suffix)
    if (-not (Test-VersionFormat $resolvedVersion)) {
        throw "Invalid version format: '$resolvedVersion'. Version must follow semantic versioning (e.g., '1.0.0', '1.0.0-alpha', '1.0.0.123')."
    }
    
    # Apply version suffix if provided
    if (-not [string]::IsNullOrWhiteSpace($versionSuffix)) {
        # Remove leading dash from suffix if present to avoid double dashes
        $cleanSuffix = $versionSuffix.TrimStart('-')
        # Always append with dash separator for clean, consistent versioning
        $resolvedVersion = "$resolvedVersion-$cleanSuffix"
    }
    
    return $resolvedVersion
}