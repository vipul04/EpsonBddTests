using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.Legal
{
    public class SellersIdentificationPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Seller's Identification"; }
        }

        protected override string RelativeUrl
        {
            get { return "/legal/designation"; }
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
