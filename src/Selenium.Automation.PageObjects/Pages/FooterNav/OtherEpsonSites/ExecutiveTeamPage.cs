using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.OtherEpsonSites
{
    public class ExecutiveTeamPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Executive team"; }
        }

        protected override string RelativeUrl
        {
            get { return "/about/executive-team"; }
        }

        protected override string PageTitle
        {
            get { return "Executive Team Website - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
