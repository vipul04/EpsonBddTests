using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.About
{
    public class InsightsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Inisghts"; }
        }

        protected override string RelativeUrl
        {
            get { return "/insights?articletype=forbusinessblogarticle"; }
        }

        protected override string PageTitle
        {
            get { return "Epson News, Newsroom, Press Articles, Blog Posts, Case studies - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
