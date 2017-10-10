using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class TransportPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Transport"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/transport"; }
        }

        protected override string PageTitle
        {
            get { return "SOLUTIONS FOR TRANSPORT - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
