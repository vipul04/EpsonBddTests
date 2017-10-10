using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.OtherEpsonSites
{
    public class EpsonPartnerPortalPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Epson Partner Portal"; }
        }

        protected override string RelativeUrl
        {
            get { return "/gb/en/portal/account/login?preloginurl=/gb/en"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Portal"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
