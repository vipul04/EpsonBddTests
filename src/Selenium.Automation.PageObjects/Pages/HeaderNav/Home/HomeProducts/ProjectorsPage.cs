using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.HomeProducts
{
    public class ProjectorsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Projectors"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/projectors/home-cinema"; }
        }

        protected override string PageTitle
        {
            get { return "Epson home cinema - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
