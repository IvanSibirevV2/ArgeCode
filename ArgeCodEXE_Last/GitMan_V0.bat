::���ᬠ�ਢ��� ����������� ⮣� �� 
::����誠 ����� ���� ᫮���� 祬 ���� ����� � ���஡�⭨����
::GitMan - GuiGit ����� 䠩���
::git config - ���㬠��
@echo off
cd %~dp0
echo %cd%
call :menu_03268
PAUSE
exit /b
:: �� ᮧ����� ���� ����� ��������. �㭪樨 ���� ���� 㭨���쭮� ���
:: �������� �� 㭨���쭮� ��� � �������� ������ ��᫥���饩 ��६�����
:: �ᮡ������ ॠ����樨
:: 1) ��५�筮� ����
:: 2) ����������筠� ॠ������ � 2 �㭪樨
:: 3) �������� ��६���� ��������� ᮧ���� ����� ������ ������� ����
:: 4) �� �ࠢ��쭮� �࣠����樨 ���� ���⪠ ���稪� � �����䨪��� ����
rem e - DO =  ;%ErrorLevel%==1
rem w - upp ;%ErrorLevel%==2
rem s - doun ;%ErrorLevel%==3
rem Show Menu
:menu_03268
	if not defined menu_03268.id set menu_03268.id=1
	::##################################
	call :menu_03268.Choice
	::##################################
	choice /c ews
	if %ErrorLevel% EQU 1 (call :menu_03268.Choice Do)
	if %ErrorLevel% EQU 2 (
		set /a menu_03268.id= %menu_03268.id%-1
		set %ErrorLevel%=0
	)
	if %ErrorLevel% EQU 3 (
		set /a menu_03268.id= %menu_03268.id%+1
		set %ErrorLevel%=0
	)
	if defined :menu_03268.IsDestruction goto :menu_03268.destruction
	goto :menu_03268
	:menu_03268.destruction
	set menu_03268.id=
	set menu_03268.counter=
	set :menu_03268.IsDestruction=
exit /b
::::::::::::::::::::::::::::::::::::::::::::::::::
rem �㭪�� ���� ����뢠�� �.
:menu_03268.Choice
	set menu_03268.counter=-1
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		::�뢮� �� �࠭ ᨬ���� * ��� ���室� �� ᫥������ ��ப�, �᫨ �㭪� ���� ��࠭
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		::�뢮� �������� �㭪� ����
		echo %menu_03268.counter%. Exit
	)else (
	::�믮������ �㭪樮����, ����������� ��� �㭪� ����
		if %menu_03268.id% EQU %menu_03268.counter% (
			::������� ��室 �� ����
			set :menu_03268.IsDestruction = Ok
			call :menu_03268.destruction
			TIMEOUT /T 10
			::����ᨢ�� ��室 ����� �� ��������� ��ப�
			Exit
		)
	)
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. ScriptGit+add.+commit+push
	)else (if %menu_03268.id% EQU %menu_03268.counter% (
		git add .
		git status
		git commit
		git log -3
		echo git log .......
		git push
		TIMEOUT /T 5
		Exit
	))	
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. git init - ������� ९����਩
	)else (if %menu_03268.id% EQU %menu_03268.counter% (git init))
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%.  RD /s/q .git - ������� ����� ���� ������ Git
	)else (if %menu_03268.id% EQU %menu_03268.counter% (RD /s/q .git))
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. git log - �뢥�� �� �࠭ ᯨ᮪ �����⮢ 
	)else (if %menu_03268.id% EQU %menu_03268.counter% (git log))
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. git status - ��ᬮ���� ������
	)else (if %menu_03268.id% EQU %menu_03268.counter% (git status))
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. git add . - �������� �� � ������
	)else (if %menu_03268.id% EQU %menu_03268.counter% (git add .))	
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. git commit - ᤥ���� ������
	)else (if %menu_03268.id% EQU %menu_03268.counter% (git commit))
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. git commit --all - ᤥ���� ������, ᤥ��� ������
	)else (if %menu_03268.id% EQU %menu_03268.counter% (git commit --all))
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. git push --all - ��᫠�� �� 業�ࠫ�� ९����਩
	)else (if %menu_03268.id% EQU %menu_03268.counter% (git push --all))
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. cmd
	)else (if %menu_03268.id% EQU %menu_03268.counter% (cmd))
	:::::::::::::::::::::::::::::::::::::::::::::::::::
	set /a menu_03268.counter= %menu_03268.counter%+1
	if "%1" EQU "" (
		if %menu_03268.id% EQU %menu_03268.counter% (<nul set /p strTemp=*)
		echo %menu_03268.counter%. git help
	)else (if %menu_03268.id% EQU %menu_03268.counter% (git help))	
	:::::::::::::::::::::::::::::::::::::::::::::::::::
exit /b 0