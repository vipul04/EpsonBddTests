using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Products
{
    public class ProjectorsProdPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Projectors"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/projectors"; }
        }

        protected override string PageTitle
        {
            get { return ""; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
