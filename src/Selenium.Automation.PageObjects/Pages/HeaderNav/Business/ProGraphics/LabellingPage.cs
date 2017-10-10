using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Common.Selenium.Base;

namespace Selenium.Automation.PageObjects.Pages.HeaderNav.Business.ProGraphics
{
    public class LabellingPage : BasePage
    {
        #region Properties

        protected override string PageName
        {
            get { return "Labelling"; }
        }

        protected override string RelativeUrl
        {
            get { return "/verticals/professional-graphics/packaging-labelling/label-printers"; }
        }

        protected override string PageTitle
        {
            get { return "Labelling on demand - Epson"; }
        }

        #endregion

        #region Elements

        #endregion

        #region Public Methods

        #endregion
    }
}
