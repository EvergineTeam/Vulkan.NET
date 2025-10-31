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