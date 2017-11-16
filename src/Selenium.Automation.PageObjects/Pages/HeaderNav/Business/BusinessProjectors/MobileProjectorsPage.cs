using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessProjectors
{
    public class MobileProjectorsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Mobile Projectors"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/projectors/mobile"; }
        }

        protected override string PageTitle
        {
            get { return "Epson Mobile Projectors - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
