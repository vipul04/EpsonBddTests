using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessProjectors
{
    public class InstallationProjectorsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Installations Projectors"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/installation-projectors"; }
        }

        protected override string PageTitle
        {
            get { return "Pro AV - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
