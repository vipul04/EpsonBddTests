@echo off

echo ::: Generating Pickles test results report
..\..\..\packages\Pickles.CommandLine.2.17.0\tools\pickles.exe --feature-directory="..\..\..\src\Selenium.Automation.Spec\Features" --output-directory="..\..\..\TestReports" --lr="..\..\..\TestResult.xml" --trfmt=nunit3 --df=html

