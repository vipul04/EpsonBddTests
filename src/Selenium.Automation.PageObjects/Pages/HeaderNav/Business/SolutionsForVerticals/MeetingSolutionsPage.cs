using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class MeetingSolutionsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Meeting Solutions"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/meeting-solutions"; }
        }

        protected override string PageTitle
        {
            get { return "Meeting Solutions - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
