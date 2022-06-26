:: Kill All ChromeDriver.exe proccess
tasklist /FI "IMAGENAME eq chromedriver.exe" 2>NUL | find /I /N "chromedriver.exe">NUL
if "%ERRORLEVEL%"=="0" taskkill /F /IM chromedriver.exe /T

:: Copy All OrderedTests To Main Drop Folder (Extract All OrderedTests From Inner Folders To Main Drop Folder)
cd ..
for /d %%d in (*.*) do (
	cd %%d	
	for /R %%f in (*.orderedtest) do copy %%f %~dp0\..\..\..\..\bin
	cd ..
)

rem del \\rotemapl10\X$\QA\Platinum.Builds\Platinum.Touch.UIAutomation\*.*
rem xcopy \\rotemapl07\QA\Platinum.Builds\Platinum.Touch.UIAutomation_20160228.1 \\rotemapl07\QA\Platinum.Builds\Platinum.Touch.UIAutomation