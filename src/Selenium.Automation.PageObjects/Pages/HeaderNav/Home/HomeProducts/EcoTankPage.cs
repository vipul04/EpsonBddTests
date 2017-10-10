using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.HomeProducts
{
    public class EcoTankPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "EcoTank"; }
        }

        protected override string RelativeUrl
        {
            get { return "/for-home/ecotank"; }
        }

        protected override string PageTitle
        {
            get { return "EcoTank printers - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
