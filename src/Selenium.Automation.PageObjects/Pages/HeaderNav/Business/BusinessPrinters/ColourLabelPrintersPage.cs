using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessPrinters
{
    public class ColourLabelPrintersPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Colour Label Printers"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/professional-graphics/colorworks"; }
        }

        protected override string PageTitle
        {
            get { return "ColorWorks - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
