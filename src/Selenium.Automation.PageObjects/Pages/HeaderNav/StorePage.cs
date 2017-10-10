using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav
{
    public class StorePage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Store"; }
        }

        protected override string RelativeUrl
        {
            get { return "/store"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Store - the largest range of Epson printers, projectors, scanners, inks, toners - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
