using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;


namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessPrinters
{
    public class LabelMakersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Label Makers"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/printers/label-maker"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Label Makers - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
