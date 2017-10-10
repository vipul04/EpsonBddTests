using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.SolutionsForHome
{
    public class GamingPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Gaming"; }
        }

        protected override string RelativeUrl
        {
            get { return "/for-home/gaming"; }
        }

        protected override string PageTitle
        {
            get { return "Powerful gaming offerings - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
