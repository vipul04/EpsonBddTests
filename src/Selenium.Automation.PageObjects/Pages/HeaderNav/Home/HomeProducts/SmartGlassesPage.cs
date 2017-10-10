using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.HomeProducts
{
    public class SmartGlassesPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Smart Glasses"; }
        }

        protected override string RelativeUrl
        {
            get { return "/search/products?filter=mobileviewer&search=bt-3"; }
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
