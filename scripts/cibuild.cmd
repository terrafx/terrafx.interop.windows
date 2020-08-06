@ECHO OFF
powershell.exe -NoLogo -NoProfile -ExecutionPolicy ByPass -Command "& """%~dp0build.ps1""" -ci %*"
IF %ERRORLEVEL% NEQ 0 EXIT /B %ERRORLEVEL%
powershell.exe -NoLogo -NoProfile -ExecutionPolicy ByPass -Command "& """%~dp0build.ps1""" -ci -solution """%~dp0..\TerraFX.Interop.Windows.Samples.sln""" %*"
EXIT /B %ERRORLEVEL%
