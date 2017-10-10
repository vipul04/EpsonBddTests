using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessScanners
{
    public class FlatbedScannersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Flatbed Scanners"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/business-scanner-range/flatbed-scanner"; }
        }

        protected override string PageTitle
        {
            get { return "Flatbed Scanner - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
