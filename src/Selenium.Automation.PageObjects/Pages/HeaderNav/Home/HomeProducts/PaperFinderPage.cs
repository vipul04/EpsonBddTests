using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.HomeProducts
{
    public class PaperFinderPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Paper Finder"; }
        }

        protected override string RelativeUrl
        {
            get { return "/for-home/paper-finder"; }
        }

        protected override string PageTitle
        {
            get { return "Paper - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
