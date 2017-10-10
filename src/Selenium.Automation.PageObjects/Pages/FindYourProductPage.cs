using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class FindYourProductPage : BasePage
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
            get { return "Product finder - Epson"; }
        }

        #endregion

        #region Elements

        [FindsBy(How = How.CssSelector, Using = ".input-wrap.l-relative>input")]
        private IWebElement searchField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn-form.btn-grey")]
        private IWebElement findProdSearchBtn { get; set; }

        #endregion

        #region Public Methods

        public void EnterProductSearch(string searchTerm)
        {
            searchField.SendKeys(searchTerm);
            findProdSearchBtn.Click();
        }

        #endregion
    }
}
