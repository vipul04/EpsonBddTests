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
namespace Selenium.Automation.Spec.Features.Footer
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Navigate to the footer links")]
    public partial class NavigateToTheFooterLinksFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FooterNavigation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Navigate to the footer links", "  As a user\r\n  I should be able to navigate from the Epson home page to the pages" +
                    " in the footer\r\n  So that I can view all that the site has to offer", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to footer Customer Service pages")]
        [NUnit.Framework.TestCaseAttribute("Product Registration", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Order return", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Warranty Check", new string[0])]
        [NUnit.Framework.TestCaseAttribute("CoverPlus registration", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Contact Us", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Find a dealer", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Promotions", new string[0])]
        public virtual void EpsonHomePageNavigationToFooterCustomerServicePages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to footer Customer Service pages", exampleTags);
#line 7
  this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
    testRunner.When(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to footer Terms pages")]
        [NUnit.Framework.TestCaseAttribute("Terms of sales", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Terms of use", new string[0])]
        public virtual void EpsonHomePageNavigationToFooterTermsPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to footer Terms pages", exampleTags);
#line 23
  this.ScenarioSetup(scenarioInfo);
#line 24
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
    testRunner.When(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to footer Legal pages")]
        [NUnit.Framework.TestCaseAttribute("Privacy Policy", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Cookie Information", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Seller\'s identification", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Modern Slavery Act Statement", new string[0])]
        public virtual void EpsonHomePageNavigationToFooterLegalPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to footer Legal pages", exampleTags);
#line 34
  this.ScenarioSetup(scenarioInfo);
#line 35
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
    testRunner.When(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to footer Other Epson Sites pages")]
        [NUnit.Framework.TestCaseAttribute("Newsroom", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Epson Partner Portal", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Global", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Executive Team", new string[0])]
        public virtual void EpsonHomePageNavigationToFooterOtherEpsonSitesPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to footer Other Epson Sites pages", exampleTags);
#line 46
  this.ScenarioSetup(scenarioInfo);
#line 47
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
    testRunner.When(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Epson Home Page navigation to footer Social media pages")]
        [NUnit.Framework.TestCaseAttribute("icon-misc-socialfacebook", new string[0])]
        [NUnit.Framework.TestCaseAttribute("icon-misc-socialyoutube", new string[0])]
        [NUnit.Framework.TestCaseAttribute("icon-misc-socialtwitter", new string[0])]
        [NUnit.Framework.TestCaseAttribute("icon-social-instagram", new string[0])]
        public virtual void EpsonHomePageNavigationToFooterSocialMediaPages(string link, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Epson Home Page navigation to footer Social media pages", exampleTags);
#line 59
  this.ScenarioSetup(scenarioInfo);
#line 60
    testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
    testRunner.When(string.Format("I select the link \"{0}\"", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then(string.Format("I should be on the \"{0}\" page", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate from Epson Homepage footer to Email Sign up page")]
        public virtual void NavigateFromEpsonHomepageFooterToEmailSignUpPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate from Epson Homepage footer to Email Sign up page", ((string[])(null)));
#line 72
    this.ScenarioSetup(scenarioInfo);
#line 73
      testRunner.Given("I am on the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
      testRunner.When("I enter \"test@test.com\" into email field and submit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
      testRunner.Then("I should be on the \"Email Sign Up - Epson\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
