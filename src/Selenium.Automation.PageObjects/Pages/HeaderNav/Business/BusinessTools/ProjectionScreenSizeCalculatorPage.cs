using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessTools
{
    public class ProjectionScreenSizeCalculatorPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Projection Screen Size Calculator"; }
        }

        protected override string RelativeUrl
        {
            get { return "/display-size-matters#ideal-sreen"; }
        }

        protected override string PageTitle
        {
            get { return "Display size matters - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
