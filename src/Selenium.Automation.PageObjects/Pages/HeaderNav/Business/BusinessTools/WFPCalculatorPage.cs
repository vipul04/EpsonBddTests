using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessTools
{
    public class WFPCalculatorPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "WFP Calculatore"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/workforce-pro/savings-calculator"; }
        }

        protected override string PageTitle
        {
            get { return "WorkForce Pro Printer Comparison Cost Calculator - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
