using NUnit.Framework;
using Selenium.Automation.PageObjects.PageFactory;
using System;
using TechTalk.SpecFlow;

namespace Selenium.Automation.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            Pages.Homepage.GoTo();
            Assert.IsTrue(Pages.Homepage.IsAt());
            Pages.Homepage.AcceptCookies();
        }

        [When(@"I select the link ""(.*)""")]
        [Given(@"I select the link ""(.*)""")]
         public void WhenISelectTheLink(string linkText)
        {
            if(linkText != "")
            {
                Pages.Homepage.SelectLinkText(linkText);
            }
            
        }

        [Then(@"the page URL should end with ""(.*)""")]
        public void ThenThePageURLShouldEndWith(string expectedUrlSuffix)
        {
            Assert.IsTrue(Pages.Homepage.CheckUrl(expectedUrlSuffix));
        }

        [Then(@"the title of the page should be ""(.*)""")]
        public void ThenTheTitleOfThePageShouldBe(string expectedTitle)
        {
            Assert.IsTrue(Pages.Homepage.CheckPageTitle(expectedTitle));
        }

        [Given(@"I select the search icon")]
        public void GivenISelectTheSearchIcon()
        {
            Pages.Header.SelectSearchIcon();
        }

        [Then(@"I should be on the All ""(.*)"" page")]
        public void ThenIShouldBeOnTheAllPage(string pageName)
        {
            switch (pageName)
            {
                case "Printers":
                    Assert.IsTrue(Pages.PrintersProdPage.CheckRelativeURL());
                    break;
                case "Projectors":
                    Assert.IsTrue(Pages.ProjectorsProdPage.CheckRelativeURL());
                    break;
                case "Scanners":
                    Assert.IsTrue(Pages.ScannersProdPage.CheckRelativeURL());
                    break;
                case "Ink":
                    Assert.IsTrue(Pages.InkAndSuppliesPage.IsAt());
                    break;
                case "Paper":
                    Assert.IsTrue(Pages.PaperFinderPage.IsAt());
                    break;
                case "Retail":
                    Assert.IsTrue(Pages.RetailPage.IsAt());
                    break;
                case "Visualisers":
                    Assert.IsTrue(Pages.VisualisersPage.IsAt());
                    break;
                case "Smart Eyewear":
                    Assert.IsTrue(Pages.SmartEyewearPage.IsAt());
                    break;
                default:
                    throw new Exception("Please select a valid page");
                    break;
            }
        }


        [Then(@"I should be on the ""(.*)"" page")]
        public void ThenIShouldBeOnThePage(string pageName)
        {
            switch (pageName)
            {
                case "Education":
                    Assert.IsTrue(Pages.EducationPage.IsAt());
                    break;
                case "Corporate":
                    Assert.IsTrue(Pages.CorporatePage.IsAt());
                    break;
                case "Healthcare":
                    //Assert.IsTrue(Pages.HealthcarePage.IsAt());
                    Assert.IsTrue(Pages.HealthcarePage.CheckRelativeURL());
                    break;
                case "Public Sector":
                    Assert.IsTrue(Pages.PublicSectorPage.IsAt());
                    break;
                case "Finance":
                    //Assert.IsTrue(Pages.FinancePage.IsAt());
                    Assert.IsTrue(Pages.FinancePage.CheckRelativeURL());
                    break;
                case "Legal & Accounting":
                    Assert.IsTrue(Pages.LegalAndAccountingPage.IsAt());
                    break;
                case "Retail & Hospitality":
                    Assert.IsTrue(Pages.RetailAndHospitalityPage.IsAt());
                    break;
                case "Transport":
                    Assert.IsTrue(Pages.TransportPage.IsAt());
                    break;
                case "Professional Graphics":
                    Assert.IsTrue(Pages.ProfessionalGraphicsPage.IsAt());
                    break;
                case "Meeting Solutions":
                    Assert.IsTrue(Pages.MeetingSolutionsPage.IsAt());
                    break;
                case "Resources":
                    Assert.IsTrue(Pages.ResourcesPage.IsAt());
                    break;
                case "Make the Switch":
                    Assert.IsTrue(Pages.MakeTheSwitchPage.IsAt());
                    break;
                case "Desktop Printers":
                    //Assert.IsTrue(Pages.DesktopPrintersPage.IsAt());
                    Assert.IsTrue(Pages.DesktopPrintersPage.CheckRelativeURL());
                    break;
                case "Workgroup Printers":
                    Assert.IsTrue(Pages.WorkgroupPrintersPage.IsAt());
                    break;
                case "Department Printers":
                    Assert.IsTrue(Pages.DepartmentPrintersPage.IsAt());
                    break;
                case "Replaceable Ink Pack System":
                    Assert.IsTrue(Pages.ReplaceableInkPackSystemPage.IsAt());
                    break;
                case "Large Format Printers":
                    //Assert.IsTrue(Pages.LargeFormatPrintersPage.IsAt());
                    Assert.IsTrue(Pages.LargeFormatPrintersPage.CheckRelativeURL());
                    break;
                case "Label Makers":
                    //Assert.IsTrue(Pages.LabelMakersPage.IsAt());
                    Assert.IsTrue(Pages.LabelMakersPage.CheckRelativeURL());
                    break;
                case "Colour Label Printers":
                    Assert.IsTrue(Pages.ColourLabelPrintersPage.IsAt());
                    break;
                case "Dot Matrix Printers":
                    //Assert.IsTrue(Pages.DotMatrixPrintersPage.IsAt());
                    Assert.IsTrue(Pages.DotMatrixPrintersPage.CheckRelativeURL());
                    break;
                case "Mobile Projectors":
                    //Assert.IsTrue(Pages.MobileProjectorsPage.IsAt());
                    Assert.IsTrue(Pages.MobileProjectorsPage.CheckRelativeURL());
                    break;
                case "Ultra Mobile Projectors":
                    //Assert.IsTrue(Pages.UltraMobileProjectorsPage.IsAt());
                    Assert.IsTrue(Pages.UltraMobileProjectorsPage.CheckRelativeURL());
                    break;
                case "Short Distance Projectors":
                    //Assert.IsTrue(Pages.ShortDistanceProjectorsPage.IsAt());
                    Assert.IsTrue(Pages.ShortDistanceProjectorsPage.CheckRelativeURL());
                    break;
                case "Ultra Short Distance Projectors":
                    //Assert.IsTrue(Pages.UltraShortDistanceProjectorsPage.IsAt());
                    Assert.IsTrue(Pages.UltraShortDistanceProjectorsPage.CheckRelativeURL());
                    break;
                case "Installation Projectors":
                    Assert.IsTrue(Pages.InstallationProjectorsPage.IsAt());
                    break;
                case "All in one Projectors":
                    //Assert.IsTrue(Pages.AllInOneProjectorsPage.IsAt());
                    Assert.IsTrue(Pages.AllInOneProjectorsPage.CheckRelativeURL());
                    break;
                case "Education Projectors":
                    Assert.IsTrue(Pages.EducationProjectorsPage.IsAt());
                    break;
                case "Laser Projectors":
                    Assert.IsTrue(Pages.LaserProjectorsPage.IsAt());
                    break;
                case "Genuine Lamps":
                    Assert.IsTrue(Pages.GenuineLampsPage.IsAt());
                    break;
                case "Business Scanners":
                    Assert.IsTrue(Pages.BusinessScannersPage.IsAt());
                    break;
                case "Portable Scanners":
                    Assert.IsTrue(Pages.PortableScannersPage.IsAt());
                    break;
                case "Flatbed Scanners":
                    Assert.IsTrue(Pages.FlatbedScannersPage.IsAt());
                    break;
                case "Sheetfed Scanners":
                    Assert.IsTrue(Pages.SheetfedScannersPage.IsAt());
                    break;
                case "Graphics Scanners":
                    //Assert.IsTrue(Pages.GraphicsScannersPage.IsAt());
                    Assert.IsTrue(Pages.GraphicsScannersPage.CheckRelativeURL());
                    break;
                case "A3 Format Scanners":
                    //Assert.IsTrue(Pages.A3FormatScannersPage.IsAt());
                    Assert.IsTrue(Pages.A3FormatScannersPage.CheckRelativeURL());
                    break;
                case "Signage":
                    Assert.IsTrue(Pages.SignagePage.IsAt());
                    break;
                case "Textile":
                    Assert.IsTrue(Pages.TextilePage.IsAt());
                    break;
                case "Interior Décor":
                    Assert.IsTrue(Pages.InteriorDecorPage.IsAt());
                    break;
                case "Labelling":
                    Assert.IsTrue(Pages.LabellingPage.IsAt());
                    break;
                case "Commercial Equipment":
                    Assert.IsTrue(Pages.CommercialEquipmentPage.IsAt());
                    break;
                case "Professional Photography":
                    Assert.IsTrue(Pages.ProfessionalPhotographyPage.IsAt());
                    break;
                case "Fine Art":
                    Assert.IsTrue(Pages.FineArtPage.IsAt());
                    break;
                case "Pre-Press":
                    Assert.IsTrue(Pages.PrePressPage.IsAt());
                    break;
                case "Technical Design":
                    Assert.IsTrue(Pages.TechnicalDesignPage.IsAt());
                    break;
                case "Robots":
                    //Assert.IsTrue(Pages.RobotsPage.IsAt());
                    Assert.IsTrue(Pages.RobotsPage.CheckRelativeURL());
                    break;
                case "Digital Label Press":
                    Assert.IsTrue(Pages.DigitalLabelPressPage.IsAt());
                    break;
                case "Discproducers":
                    Assert.IsTrue(Pages.DiscproducerPage.IsAt());
                    break;
                case "Smart Headsets":
                    //Assert.IsTrue(Pages.SmartHeadsetsPage.IsAt());
                    Assert.IsTrue(Pages.SmartHeadsetsPage.CheckRelativeURL());
                    break;
                case "Apps":
                    Assert.IsTrue(Pages.AppsPage.IsAt());
                    break;
                case "Managed Print Services":
                    Assert.IsTrue(Pages.ManagedPrintServicesPage.IsAt());
                    break;
                case "Print365":
                    Assert.IsTrue(Pages.Print365Page.IsAt());
                    break;
                case "Document Capture":
                    Assert.IsTrue(Pages.DocumentCapturePage.IsAt());
                    break;
                case "Software for Projectors":
                    Assert.IsTrue(Pages.SoftwareForProjectorsPage.IsAt());
                    break;
                case "Moverio ISV Developers":
                    Assert.IsTrue(Pages.MoverioISVDevelopersPage.IsAt());
                    break;
                case "POS Printers ISV Developers":
                    Assert.IsTrue(Pages.POSPrintersISVDevelopersPage.IsAt());
                    break;
                case "LabelWorks TCO Calculator":
                    Assert.IsTrue(Pages.LabelWorksTCOCalculatorPage.IsAt());
                    break;
                case "Epson Print Admin Savings Calculator":
                    Assert.IsTrue(Pages.EpsonPrintAdminSavingsCalculatorPage.IsAt());
                    break;
                case "CO2 & Electricity Calculator":
                    Assert.IsTrue(Pages.CO2ElectricityCalculatorPage.IsAt());
                    break;
                case "WFP Calculator":
                    Assert.IsTrue(Pages.WFPCalculatorPage.IsAt());
                    break;
                case "Projector TCO Calculator":
                    Assert.IsTrue(Pages.ProjectorTCOCalculatorPage.IsAt());
                    break;
                case "Throw Distance Calculator":
                    Assert.IsTrue(Pages.ThrowDistanceCalculatorPage.IsAt());
                    break;
                case "Lens Distance Calculator":
                    Assert.IsTrue(Pages.LensDistanceCalculatorPage.IsAt());
                    break;
                case "Projection Screen Size Calculator":
                    Assert.IsTrue(Pages.ProjectionScreenSizeCalculatorPage.IsAt());
                    break;
                case "EcoTank Savings Calculator":
                    Assert.IsTrue(Pages.EcoTankSavingsCalculatorPage.IsAt());
                    break;
                case "Home & Photo":
                    Assert.IsTrue(Pages.HomeAndPhotoPage.IsAt());
                    break;
                case "Home Cinema":
                    Assert.IsTrue(Pages.HomeCinemaPage.IsAt());
                    break;
                case "Home Office":
                    Assert.IsTrue(Pages.HomeOfficePage.IsAt());
                    break;
                case "Gaming":
                    Assert.IsTrue(Pages.GamingPage.IsAt());
                    break;
                case "EcoTank":
                    Assert.IsTrue(Pages.EcoTankPage.IsAt());
                    break;
                case "Printers":
                    //Assert.IsTrue(Pages.PrintersPage.IsAt());
                    Assert.IsTrue(Pages.PrintersPage.CheckRelativeURL());
                    break;
                case "Projectors":
                    Assert.IsTrue(Pages.ProjectorsPage.IsAt());
                    break;
                case "Scanners":
                    //Assert.IsTrue(Pages.ScannersPage.IsAt());
                    Assert.IsTrue(Pages.ScannersPage.CheckRelativeURL());
                    break;
                case "Wearables":
                    //Assert.IsTrue(Pages.WearablesPage.IsAt());
                    Assert.IsTrue(Pages.WearablesPage.CheckRelativeURL());
                    break;
                case "Smart Glasses":
                    //Assert.IsTrue(Pages.SmartGlassesPage.IsAt());
                    Assert.IsTrue(Pages.SmartGlassesPage.CheckRelativeURL());
                    break;
                case "Ink Finder":
                    Assert.IsTrue(Pages.InkAndSuppliesPage.IsAt());
                    break;
                case "Paper Finder":
                    Assert.IsTrue(Pages.PaperFinderPage.IsAt());
                    break;
                case "Epson Connect":
                    Assert.IsTrue(Pages.EpsonConnectPage.IsAt());
                    break;
                case "Ink":
                    Assert.IsTrue(Pages.InkAndSuppliesPage.IsAt());
                    break;


                case "Store":
                    Assert.IsTrue(Pages.StorePage.IsAt());
                    break;
                case "Support":
                    Assert.IsTrue(Pages.SupportPage.IsAt());
                    break;
                case "About Epson":
                    Assert.IsTrue(Pages.AboutEpsonPage.IsAt());
                    break;
                case "Sponsorship":
                    Assert.IsTrue(Pages.SponsorshipPage.IsAt());
                    break;
                case "Careers":
                    Assert.IsTrue(Pages.CareersPage.IsAt());
                    break;
                case "Insights":
                    //Assert.IsTrue(Pages.InsightsPage.IsAt());
                    Assert.IsTrue(Pages.InsightsPage.CheckRelativeURL());
                    break;
                case "Newsroom":
                    //Assert.IsTrue(Pages.NewsroomPage.IsAt());
                    Assert.IsTrue(Pages.NewsroomPage.CheckRelativeURL());
                    break;
                case "Case Studies":
                    //Assert.IsTrue(Pages.CaseStudiesPage.IsAt());
                    Assert.IsTrue(Pages.CaseStudiesPage.CheckRelativeURL());
                    break;
                case "Environment":
                    Assert.IsTrue(Pages.EnvironmentPage.IsAt());
                    break;
                case "Events":
                    Assert.IsTrue(Pages.EventsPage.IsAt());
                    break;
                case "Product Registration":
                    Assert.IsTrue(Pages.ProductRegistrationPage.IsAt());
                    break;
                case "Order return":
                    Assert.IsTrue(Pages.OrderReturnPage.IsAt());
                    break;
                case "Warranty Check":
                    //Assert.IsTrue(Pages.WarrantyCheckPage.IsAt());
                    Assert.IsTrue(Pages.WarrantyCheckPage.CheckRelativeURL());
                    break;
                case "CoverPlus registration":
                    //Assert.IsTrue(Pages.CoverPlusRegistrationPage.IsAt());
                    Assert.IsTrue(Pages.CoverPlusRegistrationPage.CheckRelativeURL());
                    break;
                case "Contact Us":
                    Assert.IsTrue(Pages.ContactUsPage.IsAt());
                    break;
                case "Find a dealer":
                    Assert.IsTrue(Pages.FindADealerPage.IsAt());
                    break;
                case "Promotions":
                    Assert.IsTrue(Pages.PromotionsPage.IsAt());
                    break;
                case "Terms of sales":
                    //Assert.IsTrue(Pages.TermsOfSalesPage.IsAt());
                    Assert.IsTrue(Pages.TermsOfSalesPage.CheckRelativeURL());
                    break;
                case "Terms of use":
                    //Assert.IsTrue(Pages.TermsOfUsePage.IsAt());
                    Assert.IsTrue(Pages.TermsOfUsePage.CheckRelativeURL());
                    break;
                case "Privacy Policy":
                    //Assert.IsTrue(Pages.PrivacyPolicyPage.IsAt());
                    Assert.IsTrue(Pages.PrivacyPolicyPage.CheckRelativeURL());
                    break;
                case "Cookie Information":
                    //Assert.IsTrue(Pages.CookieInformationPage.IsAt());
                    Assert.IsTrue(Pages.CookieInformationPage.CheckRelativeURL());
                    break;
                case "Seller's identification":
                    //Assert.IsTrue(Pages.SellersIdentificationPage.IsAt());
                    Assert.IsTrue(Pages.SellersIdentificationPage.CheckRelativeURL());
                    break;
                case "Modern Slavery Act Statement":
                    Assert.IsTrue(Pages.ModernSlaveryActStatementPage.IsAt());
                    break;
                case "Epson Partner Portal":
                    Assert.IsTrue(Pages.EpsonPartnerPortalPage.IsAt());
                    break;
                case "Global":
                    Assert.IsTrue(Pages.GlobalPage.IsAt());
                    break;
                case "Executive Team":
                    Assert.IsTrue(Pages.ExecutiveTeamPage.IsAt());
                    break;
                case "icon-misc-socialfacebook":
                    Assert.IsTrue(Pages.EpsonFacebookPage.IsAt());
                    break;
                case "icon-misc-socialyoutube":
                    Assert.IsTrue(Pages.EpsonYouTubePage.IsAt());
                    break;
                case "icon-misc-socialtwitter":
                    Assert.IsTrue(Pages.EpsonTwitterPage.IsAt());
                    break;
                case "icon-social-instagram":
                    Assert.IsTrue(Pages.EpsonInstagramPage.IsAt());
                    break;
                case "Email Sign Up - Epson":
                    Assert.IsTrue(Pages.EmailSignUpPage.IsAt());
                    break;

                case "Find your product":
                    Assert.IsTrue(Pages.FindYourProductPage.IsAt());
                    break;
                case "Ink & Supplies":
                    Assert.IsTrue(Pages.InkAndSuppliesPage.IsAt());
                    break;
                case "Drivers & Support":
                    Assert.IsTrue(Pages.DriversAndSupportPage.IsAt());
                    break;
                default:
                    throw new Exception("Please select a valid page");
                    break;
            }
        }

    }
}
