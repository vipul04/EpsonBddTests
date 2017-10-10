using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.Legal
{
    public class CookieInformationPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Cookie Information"; }
        }

        protected override string RelativeUrl
        {
            get { return "/legal/cookiepolicy"; }
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
