using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessProjectors
{
    public class LaserProjectorsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Laser Projectors"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/business-projectors"; }
        }

        protected override string PageTitle
        {
            get { return "Business Projectors - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
