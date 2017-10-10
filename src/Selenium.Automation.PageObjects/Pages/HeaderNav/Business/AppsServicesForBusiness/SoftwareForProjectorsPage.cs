using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.AppsServicesForBusiness
{
    public class SoftwareForProjectorsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Software for Projectors"; }
        }

        protected override string RelativeUrl
        {
            get { return "/epson-projector-software"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Projector Software - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
