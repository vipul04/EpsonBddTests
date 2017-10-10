using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.Terms
{
    public class TermsOfSalesPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Terms of use"; }
        }

        protected override string RelativeUrl
        {
            get { return "/terms-of-use#terms-and-conditions"; }
        }

        protected override string PageTitle
        {
            get { return "Terms of Use - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
