using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.AppsServicesForBusiness
{
    public class POSPrintersISVDevelopersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "POS Printers ISV Developers"; }
        }

        protected override string RelativeUrl
        {
            get { return "/isv"; }
        }

        protected override string PageTitle
        {
            get { return "ISV Overview - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
