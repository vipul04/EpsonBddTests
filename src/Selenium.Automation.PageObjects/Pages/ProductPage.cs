using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class ProductPage : BasePage
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
            get { return ""; }
        }

        #endregion

        #region Elements

        [FindsBy(How = How.CssSelector, Using = ".current")]
        private IWebElement productName { get; set; }

        #endregion

        #region Public Methods

        public string GetProductName()
        {
            return productName.Text;
        }

        #endregion
    }
}
