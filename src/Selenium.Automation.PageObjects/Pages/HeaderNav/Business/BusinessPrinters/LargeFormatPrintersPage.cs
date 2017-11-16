using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessPrinters
{
    public class LargeFormatPrintersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Large Format Printers"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/printers/large-format-printers"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Large-Format Printers - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
