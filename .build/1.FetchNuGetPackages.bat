rmdir ..\Packages\ /s /q
..\.nuget\nuget.exe install "..\.nuget\packages.config" -ConfigFile "..\.nuget\NuGet.config" -OutputDirectory "..\packages" -ExcludeVersion -Source "https://nuget.org/api/v2/"

PAUSE