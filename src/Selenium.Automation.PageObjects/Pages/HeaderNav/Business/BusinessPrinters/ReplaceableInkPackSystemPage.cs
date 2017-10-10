using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessPrinters
{
    public class ReplaceableInkPackSystemPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Replaceable Ink Tank System"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/workforce-pro-rips"; }
        }

        protected override string PageTitle
        {
            get { return "WorkForce Pro RIPS - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
