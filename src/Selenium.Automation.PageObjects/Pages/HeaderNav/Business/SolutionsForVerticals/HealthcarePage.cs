using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class HealthcarePage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Healthcare"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/business-solutions-for-healthcare"; }
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
