using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.CustomerService
{
    public class FindADealerPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Find a dealer"; }
        }

        protected override string RelativeUrl
        {
            get { return "/gb/en/dealersearch/"; }
        }

        protected override string PageTitle
        {
            get { return "Dealer search - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
