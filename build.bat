@ECHO OFF

CLS

REM Solution NuGet Packages
".nuget\nuget.exe" install ".nuget\packages.config" -OutputDirectory "packages" -ExcludeVersion -Source "https://nuget.org/api/v2/"

SET TARGET="Developer"
IF NOT [%1]==[] (SET TARGET="%1")

REM Run the FAKE build script
"packages\FAKE\tools\FAKE.exe" ".build\build.fsx" "target=%TARGET%" "logfile=build-log.xml"

EXIT /b %errorlevel%