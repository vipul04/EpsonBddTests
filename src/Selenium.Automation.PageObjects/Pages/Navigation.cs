using OpenQA.Selenium;
using Selenium.Automation.Common.Selenium.Base;
using Selenium.Automation.Drivers;
using Selenium.Automation.PageObjects.Model;
using System.Collections.Generic;

namespace Selenium.Automation.PageObjects.Pages
{
    public class Navigation : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Navigation"; }
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

        #endregion

        #region Public Methods

        public List<NavigationMenu> GetMenuItems()
        {
            var navigationMenu = new NavigationMenu();
            var actualNavigationMenuItems = SeleniumDriver.Instance.FindElements(By.ClassName("navigation__menu__item"));

            var actualNavigationMenuItemsList = new List<NavigationMenu>();
            foreach (var actualNavigationMenuItem in actualNavigationMenuItems)
            {
                navigationMenu.MenuItem = actualNavigationMenuItem.Text;
                actualNavigationMenuItemsList.Add(navigationMenu);
                navigationMenu = new NavigationMenu();
            }

            return actualNavigationMenuItemsList;
        }

        #endregion
    }
}
