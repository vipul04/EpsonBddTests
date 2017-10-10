using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.Legal
{
    public class ModernSlaveryActStatementPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Modern Slavery Act Statement"; }
        }

        protected override string RelativeUrl
        {
            get { return "/legal/modern-slavery-act-statement"; }
        }

        protected override string PageTitle
        {
            get { return "Modern Slavery Act - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
