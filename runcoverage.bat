call "%VS140COMNTOOLS%"\\vsvars32.bat
msbuild Blackjack.sln /p:Configuration=Debug /m /nologo /verbosity:quiet
Dependencies\OpenCover.4.6.519\tools\OpenCover.Console.exe "-target:dependencies\nunit-console\nunit3-console.exe" "-targetargs:BlackjackTests\bin\Debug\BlackjackTests.dll" "-searchdirs:Blackjack\bin\Debug\" -register:path32 -showunvisited
Dependencies\ReportGenerator.2.4.5.0\tools\ReportGenerator.exe "-reports:results.xml" "-targetdir:report"
start chrome report/index.htm
