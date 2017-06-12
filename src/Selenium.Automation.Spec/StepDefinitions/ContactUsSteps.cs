using NUnit.Framework;
using Selenium.Automation.PageObjects.Model;
using Selenium.Automation.PageObjects.PageFactory;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Spec.StepDefinitions
{
    [Binding]
    public  class ContactUsSteps
    {
        [When(@"I enter the following information")]
        public void WhenIEnterTheFollowingInformation(ContactUsConfiguration contactUsConfiguration)
        {
            Pages.ContactUsPage.FillInContactForm(contactUsConfiguration);
        }

        [Then(@"I should be able to submit")]
        public void ThenIShouldBeAbleToSubmit()
        {
            Assert.IsTrue(Pages.ContactUsPage.CanSubmit());
        }
    }
}
