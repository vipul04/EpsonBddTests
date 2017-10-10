using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.About
{
    public class AboutEpsonPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "About Epson"; }
        }

        protected override string RelativeUrl
        {
            get { return "/about"; }
        }

        protected override string PageTitle
        {
            get { return "About Epson - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
