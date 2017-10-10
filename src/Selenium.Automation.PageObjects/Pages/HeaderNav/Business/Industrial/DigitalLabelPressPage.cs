using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.Industrial
{
    public class DigitalLabelPressPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Digital Label Press"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/digital-label-presses"; }
        }

        protected override string PageTitle
        {
            get { return "Industrial Label Press: SurePress range - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
