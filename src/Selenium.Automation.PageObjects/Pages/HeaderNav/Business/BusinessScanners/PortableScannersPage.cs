using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessScanners
{
    public class PortableScannersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Portable Scanners"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/business-scanner-range/portable-scanners"; }
        }

        protected override string PageTitle
        {
            get { return "Portable business scanner - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
