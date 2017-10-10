using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessScanners
{
    public class SheetfedScannersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Sheetfed Scanners"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/business-scanner-range/sheetfed-scanners"; }
        }

        protected override string PageTitle
        {
            get { return "Sheetfed Scanners - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
