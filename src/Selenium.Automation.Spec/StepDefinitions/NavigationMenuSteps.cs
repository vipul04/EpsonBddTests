using TechTalk.SpecFlow;
using Selenium.Automation.PageObjects.PageFactory;
using TechTalk.SpecFlow.Assist;

namespace Selenium.Automation.Spec.StepDefinitions
{
    [Binding]
    public sealed class NavigationMenuSteps
    {
        [Then(@"I should see the following menu items")]
        public void ThenIShouldSeeTheFollowingMenuItems(Table expectedResults)
        {
            expectedResults.CompareToSet(Pages.Navigation.GetMenuItems());
        }
    }
}
