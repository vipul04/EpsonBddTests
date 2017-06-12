using Selenium.Automation.Drivers;
using Selenium.Automation.PageObjects.Pages;

namespace Selenium.Automation.PageObjects.PageFactory
{
    public static class Pages
    {
        public static T GetPage<T>() where T : new()
        {
            var page = new T();
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(SeleniumDriver.Instance, page);
            return page;
        }

        #region Pages

        public static Homepage Homepage
        {
            get { return GetPage<Homepage>(); }
        }

        public static Navigation Navigation
        {
            get { return GetPage<Navigation>(); }
        }

        public static ContactUsPage ContactUsPage
        {
            get { return GetPage<ContactUsPage>(); }
        }

        #endregion
    }
}
