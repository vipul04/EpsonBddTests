using Selenium.Automation.PageObjects.PageFactory;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Spec.StepDefinitions
{
    [Binding]
    public class FindYourProductSteps
    {
        [Given(@"I search for product ""(.*)""")]
        public void GivenISearchFor(string searchTerm)
        {
            Pages.FindYourProductPage.EnterProductSearch(searchTerm);
        }
    }
}
