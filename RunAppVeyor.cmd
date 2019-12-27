@echo off
rem ***************************************************************************
rem * Build Script for Debug Run
rem ***************************************************************************
rem powershell .\Tools\Resources\build.ps1 -Target AppVeyor -Verbosity Diagnostic
powershell .\Tools\Resources\build.ps1 -Target AppVeyor -Script Run.cake
rem pause