Dependencies\OpenCover.4.6.519\tools\OpenCover.Console.exe "-target:dependencies\nunit-console\nunit3-console.exe" -targetargs:"BlackjackTests\bin\Debug\BlackjackTests.dll --noheader --shadowcopy" "-searchdirs:Blackjack\bin\Debug\" -register:user
Dependencies\ReportGenerator.2.4.5.0\tools\ReportGenerator.exe "-reports:results.xml" "-targetdir:report"
start chrome report/index.htm