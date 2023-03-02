@echo off
cd %~dp0
echo %cd%
del "КакойТоФайл"
copy "КакойТоФайл" "Куда копипастить"
PAUSE
exit /b