using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class ProfessionalGraphicsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Professional Graphics"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/professional-graphics"; }
        }

        protected override string PageTitle
        {
            get { return "Professional Graphics - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
