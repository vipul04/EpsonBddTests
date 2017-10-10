using Selenium.Automation.PageObjects.PageFactory;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Spec.StepDefinitions
{
    [Binding]
    public class ProductSteps
    {
        [Then(@"I should be on the product page for ""(.*)""")]
        public void ThenIShouldBeOnTheProductPageFor(string expectedProductName)
        {
            Assert.AreEqual(expectedProductName, Pages.ProductPage.GetProductName());
        }

    }
}
