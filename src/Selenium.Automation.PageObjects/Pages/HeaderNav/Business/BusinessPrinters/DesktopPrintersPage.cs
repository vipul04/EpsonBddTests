using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessPrinters
{
    public class DesktopPrintersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Desktop Printers"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/printers/desktop"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Printers - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
