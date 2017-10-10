using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.ProGraphics
{
    public class CommercialEquipmentPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Commercial Equipment"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/professional-graphics/commercial-equipment"; }
        }

        protected override string PageTitle
        {
            get { return "SureLab D-Series - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
