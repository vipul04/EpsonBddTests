using Selenium.Automation.PageObjects.PageFactory;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Spec.StepDefinitions
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"I go to ""(.*)"" search page")]
        public void GivenIGoToSearchPage(string searchPage)
        {
            Pages.Header.SelectSearchIcon();
            Pages.Header.SelectLinkText(searchPage);
        }

    }
}
