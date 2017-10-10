using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class EducationPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Education"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/education"; }
        }

        protected override string PageTitle
        {
            get { return "Inspirational Technology for Education Collaboration, Administration & Organisation - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
