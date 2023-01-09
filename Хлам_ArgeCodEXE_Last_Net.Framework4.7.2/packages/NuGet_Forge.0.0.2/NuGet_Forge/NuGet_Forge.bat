@echo off
if "%cd%" EQU "C:\Program Files\Notepad++" (
	cd C:\D\Git_Hub\HowTo_NuGet\NuGet_Forge
)
echo %cd%
call :menu.init
:m_hgbdfksgsd
	echo ##################################
	call :menu.Choice1
	echo ##################################
	choice /c ews
	call :menu.Choice%ErrorLevel% do
goto :m_hgbdfksgsd

PAUSE
CLS
EXIT

:menu.init
	set menu.id=1
	set menu.APIKey=oy2atcx23nwyapsxmuqq4waa3vubhiseza2uxln4pt2x7q
exit /b 0
rem w - upp
:menu.Choice1
	rem 0.
	if "%1" EQU "" (
		if %menu.id% EQU 0 (echo * 0. Exit)
		if %menu.id% NEQ 0 (echo 0. Exit)
	)else (if %menu.id% EQU 0 Exit)
	rem 1.
	if "%1" EQU "" (
		if %menu.id% EQU 1 (echo * nuget spec)
		if %menu.id% NEQ 1 (echo nuget spec)
	)else (if %menu.id% EQU 1 nuget spec)
	rem 2.
	if "%1" EQU "" (
		if %menu.id% EQU 2 (echo * notepad Package.nuspec)
		if %menu.id% NEQ 2 (echo notepad Package.nuspec)
	)else (if %menu.id% EQU 2 notepad Package.nuspec)
	rem 3.
	if "%1" EQU "" (
		if %menu.id% EQU 3 (echo * nuget pack)
		if %menu.id% NEQ 3 (echo nuget pack)
	)else (if %menu.id% EQU 3 nuget pack)
	rem 4.
	if "%1" EQU "" (
		if %menu.id% EQU 4 (echo * nuget delete /?)
		if %menu.id% NEQ 4 (echo nuget delete /?)
	)else (if %menu.id% EQU 4 nuget delete /?)
	rem 5.
	if "%1" NEQ "" (
		if %menu.id% EQU 5 (
			Set /p packageID= .packageID=
			Set /p packageVersion= .packageVersion=
		)
	)
	if "%1" EQU "" (
		if %menu.id% EQU 5 echo * nuget delete ^<packageID^> ^<packageVersion^> -apikey [...] -Source [...]
		if %menu.id% NEQ 5 echo nuget delete ^<packageID^> ^<packageVersion^> -apikey [...] -Source [...]
	)else (if %menu.id% EQU 5 nuget delete %PackageID% %packageVersion% -Source https://www.nuget.org/ -apikey %menu.APIKey%)
	::)else (if %menu.id% EQU 5 nuget delete -apikey oy2a42l6o4oyrf2onb5agpcnybjdndmevkqootw2luis4q)
	::-apikey
exit /b 0
rem s - doun
:menu.Choice2
	set /a menu.id= %menu.id%-1
exit /b 0
rem e - DO
:menu.Choice3
	set /a menu.id= %menu.id%+1
exit /b 0