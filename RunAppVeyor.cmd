@echo off
rem ***************************************************************************
rem * Build Script for AppVeyor Run
rem ***************************************************************************
rem powershell .\Tools\Resources\build.ps1 -Target AppVeyor -Verbosity Diagnostic
type Tools\GlobalSettings\Addins.cake
powershell .\Tools\Resources\build.ps1 -Target AppVeyor -Script RunNuGet.cake
rem powershell .\Tools\Resources\build.ps1 -Target AppVeyor -Script RunNuGet.cake -Verbosity Diagnostic
