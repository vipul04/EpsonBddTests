using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessProjectors
{
    public class AllInOneProjectorsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "All in one projectors"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/projectors/all-in-one"; }
        }

        protected override string PageTitle
        {
            get { return "Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
