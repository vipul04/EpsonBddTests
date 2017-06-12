using NUnit.Framework;
using Selenium.Automation.PageObjects.PageFactory;
using TechTalk.SpecFlow;

namespace Selenium.Automation.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            Pages.Homepage.GoTo();
            Assert.IsTrue(Pages.Homepage.IsAt());
        }
    }
}
