using Selenium.Automation.PageObjects.Model;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Selenium.Automation.Spec.StepDefinitions
{
    [Binding]
    public class CustomTransforms
    {
        [StepArgumentTransformation]
        public ContactUsConfiguration ContactUsConfigurationTransform(Table contactUsConfiguration)
        {
            return contactUsConfiguration.CreateInstance<ContactUsConfiguration>();
        }
    }
}
