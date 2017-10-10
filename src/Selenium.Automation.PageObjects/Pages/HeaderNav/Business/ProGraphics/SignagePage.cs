using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.ProGraphics
{
    public class SignagePage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Signage"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/professional-graphics/signage-pos"; }
        }

        protected override string PageTitle
        {
            get { return "SureColor SC-S Series - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
