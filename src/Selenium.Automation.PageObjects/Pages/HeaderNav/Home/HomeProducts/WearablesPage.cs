﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Home.HomeProducts
{
    public class WearablesPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Wearables"; }
        }

        protected override string RelativeUrl
        {
            get { return "/products/wearable-technology"; }
        }

        protected override string PageTitle
        {
            get { return ""; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
