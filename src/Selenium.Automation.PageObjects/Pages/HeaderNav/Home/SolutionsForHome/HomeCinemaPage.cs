using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.SolutionsForHome
{
    public class HomeCinemaPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Home Cinema"; }
        }

        protected override string RelativeUrl
        {
            get { return "/for-home/home-cinema"; }
        }

        protected override string PageTitle
        {
            get { return "HD Projectors for Home Cinema - Experience Full 1080p HD And 3D - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
