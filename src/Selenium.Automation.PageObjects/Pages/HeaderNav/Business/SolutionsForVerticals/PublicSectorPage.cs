using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class PublicSectorPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Public Sector"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/public-sector"; }
        }

        protected override string PageTitle
        {
            get { return "Solutions for the Public Sector - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
