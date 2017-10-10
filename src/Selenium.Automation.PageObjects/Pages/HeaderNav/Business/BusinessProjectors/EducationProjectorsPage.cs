using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessProjectors
{
    public class EducationProjectorsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Education projectors"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/interactive-projectors"; }
        }

        protected override string PageTitle
        {
            get { return "Interactive education - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
