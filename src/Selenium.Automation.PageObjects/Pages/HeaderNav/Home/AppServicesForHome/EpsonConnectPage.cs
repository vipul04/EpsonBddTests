using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.AppServicesForHome
{
    public class EpsonConnectPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Epson Connect"; }
        }

        protected override string RelativeUrl
        {
            get { return "/for-home/epson-connect"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Connect - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
