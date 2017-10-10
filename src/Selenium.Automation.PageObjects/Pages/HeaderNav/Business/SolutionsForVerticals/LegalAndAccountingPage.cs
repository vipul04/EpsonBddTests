using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class LegalAndAccountingPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Legal and Accounting"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/legal-accounting"; }
        }

        protected override string PageTitle
        {
            get { return "Overview - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
