using Selenium.Automation.Drivers;
using System;
using System.Threading;

namespace Selenium.Automation.Common.Selenium.Base
{
    public abstract class BasePage
    {
        #region Properties

        protected abstract string PageName { get; }

        protected abstract string RelativeUrl { get; }

        protected abstract string PageTitle { get; }

        protected string Url
        {
            get { return "/" + RelativeUrl; }
        }

        #endregion

        #region Public Methods

        public virtual void GoTo()
        {
            try
            {
                SeleniumDriver.GoTo(Url);
            }
            catch (UriFormatException)
            {
            }
        }

        public bool IsAt()
        {
            WaitForPageToLoad();
            return SeleniumDriver.Instance.Title.Contains(PageTitle);
        }

        public void WaitForPageToLoad()
        {
            var counter = 10;

            if (!SeleniumDriver.Instance.Title.Contains(PageTitle) && counter > 0)
            {
                Thread.Sleep(1000);
                counter--;
            }
        }

        #endregion
    }
}
