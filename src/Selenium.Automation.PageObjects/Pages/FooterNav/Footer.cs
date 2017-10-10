using OpenQA.Selenium;
using Selenium.Automation.Common.Selenium.Base;
using Selenium.Automation.Drivers;
using System.Collections.Generic;

namespace Selenium.Automation.PageObjects.Pages
{
    public class Footer : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return ""; }
        }

        protected override string RelativeUrl
        {
            get { return ""; }
        }

        protected override string PageTitle
        {
            get { return ""; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        public void SubmitEmail(string emailAddress)
        {
            SeleniumDriver.WebDriver.FindElement(By.Id("signup")).SendKeys(emailAddress);
            SeleniumDriver.WebDriver.FindElement(By.Id("signup")).SendKeys(Keys.Return);
        }

        #endregion
    }
}
