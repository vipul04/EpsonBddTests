using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Automation.Drivers;
using System;
using System.Threading;
using System.Linq;
using OpenQA.Selenium.Interactions;

namespace Selenium.Automation.Common.Selenium.Base
{
    public abstract class BasePage
    {
        #region Properties

        protected abstract string PageName { get; }

        protected abstract string RelativeUrl { get; }

        protected abstract string PageTitle { get; }

        protected string Url
        {
            get { return "/" + RelativeUrl; }
        }

        #endregion

        #region Public Methods

        public virtual void GoTo()
        {
            try
            {
                SeleniumDriver.GoTo(Url);
            }
            catch (UriFormatException)
            {
            }
        }

        public bool IsAt()
        {
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            WaitForPageToLoad();
            return SeleniumDriver.Instance.Title.Contains(PageTitle);
        }

        public bool CheckRelativeURL()
        {
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            WaitForPageToLoad();
            return SeleniumDriver.Instance.Url.Contains(RelativeUrl);
        }

        public bool CheckUrl(string expectedUrlSuffix)
        {
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            string actualUrl = SeleniumDriver.Instance.Url;

            return actualUrl.Contains(expectedUrlSuffix);
        }

        public void WaitForPageToLoad()
        {
            var counter = 10;

            if (!SeleniumDriver.Instance.Title.Contains(PageTitle) && counter > 0)
            {
                Thread.Sleep(1000);
                counter--;
            }
        }

        public void WaitForElement(string linkText)
        {
            var wait = new WebDriverWait(SeleniumDriver.WebDriver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(linkText)));
        }

        public void WaitForElementToDisplayed(string linkText)
        {
            var counter = 10;
            var linkTextDisplayed = SeleniumDriver.Instance.FindElement(By.LinkText(linkText)).Displayed;
            while (!linkTextDisplayed && counter > 0)
            {
                linkTextDisplayed = SeleniumDriver.Instance.FindElement(By.LinkText(linkText)).Displayed;
                counter--;
            }
        }

        public void WaitForElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(SeleniumDriver.WebDriver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public void SelectLinkText(string linkText)
        {
           // try
           // {
                WaitForElement(linkText);
                IWebElement link = SeleniumDriver.WebDriver.FindElement(By.LinkText(linkText));
                link.Click();
            //}
            //catch (Exception e)
            //{
            //    WaitForElement(linkText);
            //    IWebElement link = SeleniumDriver.WebDriver.FindElement(By.LinkText(linkText));
            //    IJavaScriptExecutor jse = (IJavaScriptExecutor)SeleniumDriver.WebDriver;
            //    jse.ExecuteScript("argumenyouts[0].scrollIntoView(false);", link);
            //    link.Click();
            //}
        }

        public bool CheckPageTitle(string expectedTitle)
        {
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            WaitForPageToLoad();
            string actualPageTitle = SeleniumDriver.Instance.Title;
            return actualPageTitle.Equals(expectedTitle);
        }

        public void AcceptCookies()
        {
            SeleniumDriver.Instance.FindElement(By.LinkText("Accept")).Click();
        }

        #endregion
    }
}
