using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.CustomerService
{
    public class OrderReturnPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Order Returns"; }
        }

        protected override string RelativeUrl
        {
            get { return "/returns"; }
        }

        protected override string PageTitle
        {
            get { return "Returns - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
