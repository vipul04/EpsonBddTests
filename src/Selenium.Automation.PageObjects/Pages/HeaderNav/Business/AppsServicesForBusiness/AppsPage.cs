using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.AppsServicesForBusiness
{
    public class AppsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Apps"; }
        }

        protected override string RelativeUrl
        {
            get { return "/apps"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Apps and Software - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
