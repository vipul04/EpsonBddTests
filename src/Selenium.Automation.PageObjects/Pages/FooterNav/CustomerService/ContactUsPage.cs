using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.CustomerService
{
    public class ContactUsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Contact Us"; }
        }

        protected override string RelativeUrl
        {
            get { return "/contactus"; }
        }

        protected override string PageTitle
        {
            get { return "Contact Information - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
