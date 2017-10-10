using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.About
{
    public class EnvironmentPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Environment"; }
        }

        protected override string RelativeUrl
        {
            get { return "/about/environment"; }
        }

        protected override string PageTitle
        {
            get { return "Epson and the Environment - Ink & Product Recycling - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
