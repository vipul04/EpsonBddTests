using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Selenium.Automation.Common.Selenium.Base;
using Selenium.Automation.Drivers;
using Selenium.Automation.PageObjects.Model;

namespace Selenium.Automation.PageObjects.Pages
{
    public class ContactUsPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Contact Us"; }
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

        [FindsBy(How = How.CssSelector, Using = ".footer .footer-content:nth-of-type(1) .CTA-banner__callout")]
        private IWebElement ContactUsCTA { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "Company")]
        private IWebElement Company { get; set; }

        [FindsBy(How = How.Id, Using = "Title")]
        private IWebElement Title { get; set; }

        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        private IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "Content")]
        private IWebElement Content { get; set; }

        [FindsBy(How = How.ClassName, Using = "CTA-form__submit")]
        private IWebElement Submit { get; set; }

        #endregion

        #region Public Methods

        public void FillInContactForm(ContactUsConfiguration contactUsConfiguration)
        {
            ContactUsCTA.Click();
            FirstName.SendKeys(contactUsConfiguration.FirstName);
            LastName.SendKeys(contactUsConfiguration.LastName);
            Company.SendKeys(contactUsConfiguration.Company);
            Title.SendKeys(contactUsConfiguration.Title);
            PhoneNumber.SendKeys(contactUsConfiguration.Phone);
            Email.SendKeys(contactUsConfiguration.Email);

            new SelectElement(SeleniumDriver.Instance.FindElement(By.Id("Question"))).SelectByText(contactUsConfiguration.About);

            Content.SendKeys(contactUsConfiguration.Message);
        }

        public bool CanSubmit()
        {
            return Submit.Enabled;
        }

        #endregion
    }
}
