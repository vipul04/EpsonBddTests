using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace Selenium.Automation.Drivers
{
    public static class SeleniumDriver
    {
        #region Properties

        public static IWebDriver WebDriver;

        public static string LocalBrowser { get; set; }

        public static string BaseUrl { get; set; }

        public static IWebDriver Instance
        {
            get { return WebDriver ?? (WebDriver = CreateDriver()); }
        }

        #endregion

        #region Public Methods

        public static IWebDriver CreateDriver()
        {
            switch (LocalBrowser.ToLower())
            {
                case "chrome":
                    WebDriver = new ChromeDriver();
                    break;
                case "firefox":
                    WebDriver = new FirefoxDriver();
                    break;
                case "ie":
                    WebDriver = new InternetExplorerDriver();
                    break;
                default:
                    WebDriver = new FirefoxDriver();
                    break;
            }

            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            WebDriver.Manage().Window.Maximize();

            return WebDriver;
        }

        public static void Close()
        {
            if (WebDriver == null) return;
            Instance.Quit();
            WebDriver = null;
        }

        public static void GoTo(string url)
        {
            Instance.Url = url != null && url.Trim() == "//" ? BaseUrl : BaseUrl + url;
        }

        #endregion
    }
}
