using NUnit.Framework;
using Selenium.Automation.PageObjects.PageFactory;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Spec.StepDefinitions
{
    [Binding]
    public class FooterSteps
    {
        [When(@"I enter ""(.*)"" into email field and submit")]
        public void WhenIEnterIntoEmailFieldAndSubmit(string emailAddress)
        {
            Pages.Footer.SubmitEmail(emailAddress);
        }

    }
}