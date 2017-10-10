using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav
{
    public class SupportPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Support"; }
        }

        protected override string RelativeUrl
        {
            get { return "/support"; }
        }

        protected override string PageTitle
        {
            get { return "Drivers, Technical Support, Downloads, FAQs & Troubleshooting - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
