echo "Hai portato avanti la versione ?"
pause
cd ..
copy .\README.md .\bin\readme.txt
.\nuget\NuGet.exe pack .\nuget\ApexNetSentry.nuspec -basepath bin -o .\nuget\