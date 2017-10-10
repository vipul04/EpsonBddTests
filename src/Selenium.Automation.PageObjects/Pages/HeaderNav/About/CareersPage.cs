using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.About
{
    public class CareersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Careers"; }
        }

        protected override string RelativeUrl
        {
            get { return "/careers"; }
        }

        protected override string PageTitle
        {
            get { return "Careers at Epson - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
