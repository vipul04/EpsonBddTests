using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.AppsServicesForBusiness
{
    public class ManagedPrintServicesPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Managed Print Services"; }
        }

        protected override string RelativeUrl
        {
            get { return "/managed-print-services"; }
        }

        protected override string PageTitle
        {
            get { return "Managed Print Services - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
