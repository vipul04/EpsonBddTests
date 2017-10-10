using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessScanners
{
    public class BusinessScannersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Business Scanners"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/business-scanner-range"; }
        }

        protected override string PageTitle
        {
            get { return "Epson's Business Scanner Range - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
