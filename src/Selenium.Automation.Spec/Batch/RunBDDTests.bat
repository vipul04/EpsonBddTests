@echo off

echo ::: Running BDD tests using NUnit test runner...
..\..\..\packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe "..\..\..\src\Selenium.Automation.Spec\bin\Debug\Selenium.Automation.Spec.dll" --where "cat == test" --result=..\..\..\TestResult.xml