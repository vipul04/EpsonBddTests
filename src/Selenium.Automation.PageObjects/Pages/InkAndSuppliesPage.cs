using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class InkAndSuppliesPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return ""; }
        }

        protected override string RelativeUrl
        {
            get { return ""; }
        }

        protected override string PageTitle
        {
            get { return "Printer Ink Cartridges, Toner, Printer Ribbons, Label Maker Cartridges - Epson"; }
        }

        #endregion

        #region Elements

        [FindsBy(How = How.Name, Using = "search")]
        private IWebElement inkSearchField { get; set; }

        #endregion

        #region Public Methods

        public void EnterInkSupplySearch(string searchTerm)
        {
            inkSearchField.SendKeys(searchTerm);
            WaitForElement(By.CssSelector(".product-result"));
        }

        #endregion
    }
}
