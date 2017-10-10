using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessPrinters
{
    public class DepartmentPrintersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Department Printers"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/workforce-enterprise"; }
        }

        protected override string PageTitle
        {
            get { return "High Speed Enterprise Multi-Function Printer - WF-C20590 - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
