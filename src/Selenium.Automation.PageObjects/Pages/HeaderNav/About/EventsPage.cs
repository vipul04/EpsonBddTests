using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.About
{
    public class EventsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Events"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/resources#lead_nurturing"; }
        }

        protected override string PageTitle
        {
            get { return "Resources - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
