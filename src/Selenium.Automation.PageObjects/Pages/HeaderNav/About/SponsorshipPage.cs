using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.About
{
    public class SponsorshipPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Sponsorship"; }
        }

        protected override string RelativeUrl
        {
            get { return "/sponsoring"; }
        }

        protected override string PageTitle
        {
            get { return "Sponsoring - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
