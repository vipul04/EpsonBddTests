using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages
{
    public class Header : BasePage
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

        [FindsBy(How = How.Id, Using = "qltoggle")]
        private IWebElement searchIcon { get; set; }

        #endregion

        #region Public Methods

        public void SelectSearchIcon()
        {
            searchIcon.Click();
        }

        #endregion
    }
}
