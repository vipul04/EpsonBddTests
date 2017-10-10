using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.FooterNav.CustomerService
{
    public class WarrantyCheckPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Warranty Check"; }
        }

        protected override string RelativeUrl
        {
            get { return "/support#check_warranty"; }
        }

        protected override string PageTitle
        {
            get { return "Drivers, Technical Support, Downloads, FAQs & Troubleshooting - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
