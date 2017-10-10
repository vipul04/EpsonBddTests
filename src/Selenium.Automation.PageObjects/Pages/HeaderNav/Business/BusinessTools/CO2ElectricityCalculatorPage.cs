using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessTools
{
    public class CO2ElectricityCalculatorPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "CO2 & Electricity Calculator"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/eco-savings"; }
        }

        protected override string PageTitle
        {
            get { return "CO2 Calculator - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
