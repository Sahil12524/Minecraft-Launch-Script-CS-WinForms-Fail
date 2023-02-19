@echo off
::Minecraft Launch Script "restart.bat" made by SAHIL BHANDARI.
title restart
color 0a
tasklist /fi "ImageName eq Minecraft.Windows.exe" /fo csv 2>NUL | find /I "minecraft.windows.exe">NUL
if "%ERRORLEVEL%"=="1" goto FAIL
:RESTART ::This is the start of the script.
taskkill /F /IM "Minecraft.Windows.exe"
taskkill /F /IM "StartMenuExperienceHost.exe"
explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App
timeout 04 /nobreak
taskkill /F /IM "RuntimeBroker.exe"
taskkill /F /IM "SearchHost.exe"
goto EXIT
:FAIL ::The blk where the script encounters an error.
color 04
echo ERROR: 
echo 1. The Minecraft was not running, hence not restarted. 
echo 2. Make sure that Minecraft is installed Correctly.
echo 3. Or if the game was closed forcefully by mistakely please restart the launcher and press the 'Reset Clip Service' button to avoid windows store problems.
pause
goto EXIT
:EXIT ::Exit blk to terminate the script.
exit