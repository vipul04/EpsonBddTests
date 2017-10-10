using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.Industrial
{
    public class SmartHeadsetsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Smart Headsets"; }
        }

        protected override string RelativeUrl
        {
            get { return "/search/products?filter=mobileviewer&search=pro"; }
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
