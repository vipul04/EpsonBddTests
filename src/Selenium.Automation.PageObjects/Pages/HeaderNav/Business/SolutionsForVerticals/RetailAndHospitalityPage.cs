using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class RetailAndHospitalityPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Retail and Hospitality"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/retail"; }
        }

        protected override string PageTitle
        {
            get { return "Solutions for retail - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
