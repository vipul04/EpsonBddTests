using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.Legal
{
    public class PrivacyPolicyPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Privacy Policy"; }
        }

        protected override string RelativeUrl
        {
            get { return "/legal/privacy"; }
        }

        protected override string PageTitle
        {
            get { return ""; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
