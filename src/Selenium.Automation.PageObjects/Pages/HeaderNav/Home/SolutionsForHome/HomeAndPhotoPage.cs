using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.SolutionsForHome
{
    public class HomeAndPhotoPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Home and Photo"; }
        }

        protected override string RelativeUrl
        {
            get { return "/for-home/expression-home-series/"; }
        }

        protected override string PageTitle
        {
            get { return "Expression Wireless Printer Range - WiFi enabled all-in-one printers for home, home office, and photo printing - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
