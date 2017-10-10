using Selenium.Automation.PageObjects.PageFactory;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Spec.StepDefinitions
{
    [Binding]
    public class InkSuppliesSteps
    {
        [Given(@"I search for ink or supplies ""(.*)""")]
        public void GivenISearchForInkOrSupplies(string searchTerm)
        {
            Pages.InkAndSuppliesPage.EnterInkSupplySearch(searchTerm);
        }
    }
}
