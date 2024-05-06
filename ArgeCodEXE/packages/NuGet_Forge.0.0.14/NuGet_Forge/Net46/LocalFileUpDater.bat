@echo off
cd %~dp0
echo %cd%
set NuGetPatch=%~dp0
cd ../../../../
echo %cd%
cd ArgeCode/bin/Debug/
echo %cd%
del %NuGetPatch%ArgeCode.dll
del %NuGetPatch%ArgeCode.pdb
copy ArgeCode.dll %NuGetPatch%ArgeCode.dll
copy ArgeCode.pdb %NuGetPatch%ArgeCode.pdb
cd NuGetPatch

exit /b