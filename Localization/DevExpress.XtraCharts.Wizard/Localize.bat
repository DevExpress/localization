Rem This batch file calls the Localiser.exe utility by Anton Mironov, which synchronize resx files in the DevExpess.XtraCharts.Wizard project and in localization project.
Rem It is recommended to execute this batch file every time when something is changed in the DevExpess.XtraCharts.Wizard project end localization for this folder already exists.
Rem Also it is recommended to execute this file after brunch.

Rem CHANGE THE VERSION TO the PREVIOUS !!!
Rem (only in the next line)
SET BaseVersion=2015.2

ECHO off
TITLE Localizing DevExpress.XtraCharts.Wizard
MODE CON COLS=100 LINES=50
ECHO Bath file path: %~dp0
SET BatPath=%~dp0

Rem  To allow executing this bat file as Administrator set current directory to this bat's path (for Administrator it is C:\Windows\System32)
CD /d %BatPath% 
ECHO Current directory: %CD%


SET LocalizerRelativePath=..\Localizer\bin\Release
Rem Getting full path --
PUSHD %LocalizerRelativePath%
SET Localizer=%CD%\Localizer.exe
POPD
Rem --------------------

SET BaseProjectFileRelativePath=..\..\..\%BaseVersion%\Win\DevExpress.XtraCharts\DevExpress.XtraCharts.Wizard
PUSHD %BaseProjectFileRelativePath%
SET BaseProjectFile=%CD%\DevExpress.XtraCharts.Wizard.csproj
POPD

SET CurrentProjectFileRelativePath=..\..\Win\DevExpress.XtraCharts\DevExpress.XtraCharts.Wizard
PUSHD %CurrentProjectFileRelativePath%
SET CurrentProjectFile=%CD%\DevExpress.XtraCharts.Wizard.csproj
POPD

SET BaseLocalizationDirectoryRelativePath=..\..\..\%BaseVersion%\Localization\DevExpress.XtraCharts.Wizard
PUSHD %BaseLocalizationDirectoryRelativePath%
SET BaseLocalizationDirectory=%CD%
POPD

SET CurrentLocalizationDirectoryRelativePath=..\..\Localization\DevExpress.XtraCharts.Wizard
PUSHD %CurrentLocalizationDirectoryRelativePath%
SET CurrentLocalizationDirectory=%CD%
POPD

SET LogPathRelativePath=..\..\Logs\
PUSHD %LogPathRelativePath%
SET LogPath=%CD%
POPD


IF NOT EXIST %Localizer% GOTO :LocaliserProgrammNotFound 

:LocaliserProgrammFound
IF NOT EXIST %BaseProjectFile% GOTO :BaseProjectFileNotFound 

:BaseProjectFileFound
IF NOT EXIST %CurrentProjectFile% GOTO :CurrentProjectFileNotFound 

:CurrentProjectFileFound
IF NOT EXIST %BaseLocalizationDirectory% GOTO :BaseLocalizationDirectoryNotFound 

:BaseLocalizationDirectoryFound
IF NOT EXIST %CurrentLocalizationDirectory% GOTO :CurrentLocalizationDirectoryNotFound d

:CurrentLocalizationDirectoryFound
IF DEFINED HasErrors (
	ECHO Some necessary files have not been found. Execution has terminated.
	PAUSE
	EXIT /b
)

REM Main ----
ECHO Locilizing process in progress. Please wait...
IF NOT EXIST %LogPath% ECHO The '%LogPath%' directory has not found and it will be created.
IF NOT EXIST %LogPath% MD %LogPath%
%Localizer% %BaseProjectFile% %BaseLocalizationDirectory% %CurrentProjectFile% %CurrentLocalizationDirectory% -notWait >> %LogPath%\LocalizingXtraChartsWizardLog.txt
ECHO Execution of the bath file is complited.
PAUSE
EXIT /b
REM ----------

REM Error reporters
:LocaliserProgrammNotFound
ECHO The '%Localizer%' file has not found. 
ECHO You must get the Localizer project and build it in the 'Release' configuration.
SET HasErrors=true
GOTO :LocaliserProgrammFound

:BaseProjectFileNotFound
ECHO The '%BaseProjectFile%' file has not found.
SET HasErrors=true
GOTO :BaseProjectFileFound

:CurrentProjectFileNotFound
ECHO The '%CurrentProjectFile%' file has not found.
SET HasErrors=true
GOTO :CurrentProjectFileFound

:CurrentLocalizationDirectoryNotFound
ECHO The '%CurrentLocalizationDirectory%' file has not found.
SET HasErrors=true
GOTO :CurrentLocalizationDirectoryFound

:BaseLocalizationDirectoryNotFound
ECHO The '%BaseLocalizationDirectory%' directory has not found.
SET HasErrors=true
GOTO :BaseLocalizationDirectoryFound