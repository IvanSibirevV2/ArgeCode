::Рассматриваем возможность того что 
::Менюшка может быть сложнее чем просто папка с микробатниками
@echo off
cd %~dp0
echo %cd%
call :menu_03268
PAUSE
exit /b

:menu_03268
setlocal
	set _id=0
	:menu_03268_begin
	set _counter=-1
	cls
	:::::::::::::::::::::::::::::::::::::::::::::::
		set /a _counter= %_counter%+1
		:::::::::::::::::::::::::::::::::::::::::::::::::::
		if "%1" EQU "" ((if %_id% EQU %_counter% (<nul set /p strTemp=*))&(echo Exit)
		)else (if %_id% EQU %_counter% (echo Exit)&(TIMEOUT /T 2)&(Exit))
		:::::::::::::::::::::::::::::::::::::::::::::::
		set /a _counter= %_counter%+1
		if "%1" EQU "" ((if %_id% EQU %_counter% (<nul set /p strTemp=*))&(echo nuget spec)
		)else (if %_id% EQU %_counter% (nuget spec)&(notepad Package.nuspec))
		:::::::::::::::::::::::::::::::::::::::::::::::
		set /a _counter= %_counter%+1
		if "%1" EQU "" ((if %_id% EQU %_counter% (<nul set /p strTemp=*))&(echo notepad Package.nuspec)
		)else (if %_id% EQU %_counter% (notepad Package.nuspec))
		:::::::::::::::::::::::::::::::::::::::::::::::
		set /a _counter= %_counter%+1
		if "%1" EQU "" ((if %_id% EQU %_counter% (<nul set /p strTemp=*))&(echo notepad NuGet_Forge_ReadMe.txt)
		)else (if %_id% EQU %_counter% (notepad NuGet_Forge_ReadMe.txt))
		:::::::::::::::::::::::::::::::::::::::::::::::
		set /a _counter= %_counter%+1
		if "%1" EQU "" ((if %_id% EQU %_counter% (<nul set /p strTemp=*))&(echo nuget pack)
		)else (if %_id% EQU %_counter% (nuget pack)&(TIMEOUT /T 10))
		:::::::::::::::::::::::::::::::::::::::::::::::
		set /a _counter= %_counter%+1
		if "%1" EQU "" ((if %_id% EQU %_counter% (<nul set /p strTemp=*))&(echo nuget delete /?)
		)else (if %_id% EQU %_counter% (echo nuget delete not provided at oll)&(TIMEOUT /T 10))
		:::::::::::::::::::::::::::::::::::::::::::::::
		set /a _counter= %_counter%+1
		if "%1" EQU "" ((if %_id% EQU %_counter% (<nul set /p strTemp=*))&(echo git clone ... for: Sources, Examples, Help)
		)else (if %_id% EQU %_counter% (git clone https://github.com/IvanSibirevV2/HowTo_NuGet.git)&(TIMEOUT /T 10))
	:::::::::::::::::::::::::::::::::::::::::::::::
	if "%1" EQU "Do" (exit /b) else (choice /c ews)
	if %ErrorLevel% EQU 1 ((echo e)&(call :menu_03268_begin Do)&(set %ErrorLevel%=0))
	if %ErrorLevel% EQU 2 ((echo w)&(set /a _id= %_id%-1)&(set %ErrorLevel%=0))
	if %ErrorLevel% EQU 3 ((echo s)&(set /a _id= %_id%+1)&(set %ErrorLevel%=0))
	if %_id% LSS 0 set _id=%_counter%
	if %_id% GTR %_counter% set _id=0
	goto :menu_03268_begin
endlocal
exit /b