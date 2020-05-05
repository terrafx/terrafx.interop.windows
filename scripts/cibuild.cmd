@ECHO OFF
powershell.exe -NoLogo -NoProfile -ExecutionPolicy ByPass -Command "& """%~dp0build.ps1""" -ci %*"
powershell.exe -NoLogo -NoProfile -ExecutionPolicy ByPass -Command "& """%~dp0build.ps1""" -ci -solution """%~dp0..\samples\GuiSamples.sln""" %*"
EXIT /B %ERRORLEVEL%
