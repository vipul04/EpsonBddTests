using Selenium.Automation.Drivers;
using Selenium.Automation.Drivers.Configuration;

namespace Selenium.Automation.PageObjects
{
    public class TestBase
    {
        public static void TestSetup()
        {
            SeleniumDriver.LocalBrowser = ApplicationSettings.GetLocalBrowser;
            SeleniumDriver.BaseUrl = ApplicationSettings.GetEnvironmentBaseUrl();

            if (SeleniumDriver.WebDriver == null)
            {
                SeleniumDriver.CreateDriver();
            }
        }

        public static void TearDown()
        {
            SeleniumDriver.Close();
        }
    }
}
