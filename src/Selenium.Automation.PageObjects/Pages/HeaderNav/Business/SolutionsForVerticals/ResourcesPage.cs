using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class ResourcesPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Resources"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/resources"; }
        }

        protected override string PageTitle
        {
            get { return "Resources - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
