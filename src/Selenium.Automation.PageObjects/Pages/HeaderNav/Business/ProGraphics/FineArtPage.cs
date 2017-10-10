using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.ProGraphics
{
    public class FineArtPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Fine Art"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/professional-graphics/fine-art"; }
        }

        protected override string PageTitle
        {
            get { return "Fine Art - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
