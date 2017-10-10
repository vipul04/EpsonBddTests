using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessScanners
{
    public class GraphicsScannersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Graphic Scanners"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/scanners/graphic"; }
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
