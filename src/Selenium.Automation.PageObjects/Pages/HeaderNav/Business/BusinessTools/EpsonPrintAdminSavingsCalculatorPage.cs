using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessTools
{
    public class EpsonPrintAdminSavingsCalculatorPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Epson Print Admin Savings Calculator"; }
        }

        protected override string RelativeUrl
        {
            get { return "/epa-calculator"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Print Admin Savings Calculator - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
