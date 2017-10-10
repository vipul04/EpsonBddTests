using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.SolutionsForHome
{
    public class HomeOfficePage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Home Office"; }
        }

        protected override string RelativeUrl
        {
            get { return "/for-home/home-office"; }
        }

        protected override string PageTitle
        {
            get { return "Workforce Pro printer range - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
