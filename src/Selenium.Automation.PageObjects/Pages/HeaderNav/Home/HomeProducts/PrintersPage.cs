using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.HomeProducts
{
    public class PrintersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Printers"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/printers/inkjet-printers/consumer"; }
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
