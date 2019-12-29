@echo off
rem ***************************************************************************
rem * Build Script for Debug Run
rem ***************************************************************************
rem powershell .\Tools\Resources\build.ps1 -Target AppVeyor -Verbosity Diagnostic
type Tools\GlobalSettings\Addins.cake
powershell .\Tools\Resources\build.ps1 -Target Print-AppVeyor-Environment-Variables -Script RunNuGet.cake
powershell .\Tools\Resources\build.ps1 -Target AppVeyor -Script RunNuGet.cake -Verbosity Diagnostic
rem pause