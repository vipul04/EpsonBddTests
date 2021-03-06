﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Selenium.Automation.Spec.Features.HeaderNavMenu
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Navigate to the Business nav menu pages")]
    public partial class NavigateToTheBusinessNavMenuPagesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BusinessNav.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Navigate to the Business nav menu pages", "  As a user\r\n  I should be able to navigate from the Epson home page to the Busin" +
                    "ess navigation menu pages\r\n  So that I can view all that the site has to offer", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Home Page navigation to Business - Solutions for Business pages")]
        [NUnit.Framework.TestCaseAttribute("Education", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Corporate", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Healthcare", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Public Sector", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Finance", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Legal & Accounting", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Retail & Hospitality", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Transport", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Professional Graphics", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Meeting Solutions", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Resources", new string[0])]
        public virtual void HomePageNavigationToBusiness_SolutionsForBusinessPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Home Page navigation to Business - Solutions for Business pages", exampleTags);
#line 7
  this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
    testRunner.When("I select the link \"Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
    testRunner.And("I select the link \"Solutions for Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.And(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to Business - Business Printers pages")]
        [NUnit.Framework.TestCaseAttribute("Make the Switch", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Desktop Printers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Workgroup Printers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Department Printers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Replaceable Ink Pack System", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Large Format Printers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Label Makers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Colour Label Printers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Dot Matrix Printers", new string[0])]
        public virtual void EpsonHomePageNavigationToBusiness_BusinessPrintersPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to Business - Business Printers pages", exampleTags);
#line 28
  this.ScenarioSetup(scenarioInfo);
#line 29
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
    testRunner.When("I select the link \"Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
    testRunner.And("I select the link \"Business Printers\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.And(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to Business - Business Projectors pages")]
        [NUnit.Framework.TestCaseAttribute("Mobile Projectors", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Ultra Mobile Projectors", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Short Distance Projectors", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Ultra Short Distance Projectors", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Installation Projectors", new string[0])]
        [NUnit.Framework.TestCaseAttribute("All in one Projectors", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Education Projectors", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Laser Projectors", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Genuine Lamps", new string[0])]
        public virtual void EpsonHomePageNavigationToBusiness_BusinessProjectorsPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to Business - Business Projectors pages", exampleTags);
#line 48
  this.ScenarioSetup(scenarioInfo);
#line 49
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
    testRunner.When("I select the link \"Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
    testRunner.And("I select the link \"Business Projectors\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
    testRunner.And(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to Business - Business Scanners pages")]
        [NUnit.Framework.TestCaseAttribute("Portable Scanners", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Flatbed Scanners", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Sheetfed Scanners", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Graphics Scanners", new string[0])]
        [NUnit.Framework.TestCaseAttribute("A3 Format Scanners", new string[0])]
        public virtual void EpsonHomePageNavigationToBusiness_BusinessScannersPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to Business - Business Scanners pages", exampleTags);
#line 68
  this.ScenarioSetup(scenarioInfo);
#line 69
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
    testRunner.When("I select the link \"Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
    testRunner.And("I select the link \"Business Scanners\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
    testRunner.And(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to Business - ProGraphics pages")]
        [NUnit.Framework.TestCaseAttribute("Signage", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Textile", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Interior Décor", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Labelling", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Commercial Equipment", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Professional Photography", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Fine Art", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Pre-Press", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Technical Design", new string[0])]
        public virtual void EpsonHomePageNavigationToBusiness_ProGraphicsPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to Business - ProGraphics pages", exampleTags);
#line 84
  this.ScenarioSetup(scenarioInfo);
#line 85
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 86
    testRunner.When("I select the link \"Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
    testRunner.And("I select the link \"ProGraphics\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
    testRunner.And(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to Business - Industrial pages")]
        [NUnit.Framework.TestCaseAttribute("Robots", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Digital Label Press", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Colour Label Printers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Large Format Printers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Discproducers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Smart Headsets", new string[0])]
        public virtual void EpsonHomePageNavigationToBusiness_IndustrialPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to Business - Industrial pages", exampleTags);
#line 104
  this.ScenarioSetup(scenarioInfo);
#line 105
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
    testRunner.When("I select the link \"Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
    testRunner.And("I select the link \"Industrial\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
    testRunner.And(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to Business - Apps & Services for Businesses pages")]
        [NUnit.Framework.TestCaseAttribute("Apps", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Managed Print Services", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Print365", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Document Capture", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Software for Projectors", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Moverio ISV Developers", new string[0])]
        [NUnit.Framework.TestCaseAttribute("POS Printers ISV Developers", new string[0])]
        public virtual void EpsonHomePageNavigationToBusiness_AppsServicesForBusinessesPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to Business - Apps & Services for Businesses pages", exampleTags);
#line 121
  this.ScenarioSetup(scenarioInfo);
#line 122
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 123
    testRunner.When("I select the link \"Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
    testRunner.And("I select the link \"Apps & Services for Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
    testRunner.And(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to Business - Business Tools pages")]
        [NUnit.Framework.TestCaseAttribute("LabelWorks TCO Calculator", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Epson Print Admin Savings Calculator", new string[0])]
        [NUnit.Framework.TestCaseAttribute("CO2 & Electricity Calculator", new string[0])]
        [NUnit.Framework.TestCaseAttribute("WFP Calculator", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Projector TCO Calculator", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Throw Distance Calculator", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Lens Distance Calculator", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Projection Screen Size Calculator", new string[0])]
        [NUnit.Framework.TestCaseAttribute("EcoTank Savings Calculator", new string[0])]
        public virtual void EpsonHomePageNavigationToBusiness_BusinessToolsPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to Business - Business Tools pages", exampleTags);
#line 138
  this.ScenarioSetup(scenarioInfo);
#line 139
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 140
    testRunner.When("I select the link \"Business\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
    testRunner.And("I select the link \"Business Tools\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
    testRunner.And(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
    testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
