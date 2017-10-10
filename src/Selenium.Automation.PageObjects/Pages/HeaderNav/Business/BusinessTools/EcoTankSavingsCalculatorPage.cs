using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessTools
{
    public class EcoTankSavingsCalculatorPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "EcoTank Savings Calculator"; }
        }

        protected override string RelativeUrl
        {
            get { return "/for-home/ecotank-calculator"; }
        }

        protected override string PageTitle
        {
            get { return "Compare the Epson EcoTank printers against the top 20 best-selling printers - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
