using Selenium.Automation.PageObjects;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Hooks
{
    [Binding]
    public class BeforeAfterScenario
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            TestBase.TestSetup();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TestBase.TearDown();
        }
    }
}
