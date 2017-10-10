using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class CorporatePage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Corporate"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/corporate"; }
        }

        protected override string PageTitle
        {
            get { return "Smart business solutions by Epson - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
