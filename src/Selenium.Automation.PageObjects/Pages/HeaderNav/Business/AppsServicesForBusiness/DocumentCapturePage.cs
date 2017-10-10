using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.AppsServicesForBusiness
{
    public class DocumentCapturePage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Document Capture"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/business-scanner-range/document-management"; }
        }

        protected override string PageTitle
        {
            get { return "Document Capture Suite - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
