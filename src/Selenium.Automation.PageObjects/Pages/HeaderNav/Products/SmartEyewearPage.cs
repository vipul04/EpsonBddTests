using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Products
{
    public class SmartEyewearPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Smart Eyewear"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/see-through-mobile-viewer"; }
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
