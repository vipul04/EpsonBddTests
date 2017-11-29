using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class FinancePage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Finance"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/business-solutions-for-finance"; }
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
