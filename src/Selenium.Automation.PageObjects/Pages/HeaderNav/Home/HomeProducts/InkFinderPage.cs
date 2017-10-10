using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.HomeProducts
{
    public class InkFinderPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Ink Finder"; }
        }

        protected override string RelativeUrl
        {
            get { return "/consumables"; }
        }

        protected override string PageTitle
        {
            get { return "Printer Ink Cartridges, Toner, Printer Ribbons, Label Maker Cartridges - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
