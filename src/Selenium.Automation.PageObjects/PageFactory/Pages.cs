using Selenium.Automation.Drivers;
using Selenium.Automation.PageObjects.Pages;
using Selenium.Automation.PageObjects.Pages.HeaderNav;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessPrinters;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessProjectors;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessScanners;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Business.ProGraphics;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Business.Industrial;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Business.AppsServicesForBusiness;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Business.BusinessTools;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Home.SolutionsForHome;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Home.HomeProducts;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Home.AppServicesForHome;
using Selenium.Automation.PageObjects.Pages.HeaderNav.Products;
using Selenium.Automation.PageObjects.Pages.HeaderNav.About;
using Selenium.Automation.PageObjects.Pages.FooterNav;
using Selenium.Automation.PageObjects.Pages.FooterNav.CustomerService;
using Selenium.Automation.PageObjects.Pages.FooterNav.Terms;
using Selenium.Automation.PageObjects.Pages.FooterNav.Legal;
using Selenium.Automation.PageObjects.Pages.FooterNav.OtherEpsonSites;
using Selenium.Automation.PageObjects.Pages.FooterNav.SocialMedia;

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

        public static Header Header
        {
            get { return GetPage<Header>(); }
        }

        public static Footer Footer
        {
            get { return GetPage<Footer>(); }
        }

        public static CorporatePage CorporatePage
        {
            get { return GetPage<CorporatePage>(); }
        }

        public static EducationPage EducationPage
        {
            get { return GetPage<EducationPage>(); }
        }

        public static FinancePage FinancePage
        {
            get { return GetPage<FinancePage>(); }
        }

        public static HealthcarePage HealthcarePage
        {
            get { return GetPage<HealthcarePage>(); }
        }

        public static LegalAndAccountingPage LegalAndAccountingPage
        {
            get { return GetPage<LegalAndAccountingPage>(); }
        }

        public static MeetingSolutionsPage MeetingSolutionsPage
        {
            get { return GetPage<MeetingSolutionsPage>(); }
        }

        public static ProfessionalGraphicsPage ProfessionalGraphicsPage
        {
            get { return GetPage<ProfessionalGraphicsPage>(); }
        }

        public static PublicSectorPage PublicSectorPage
        {
            get { return GetPage<PublicSectorPage>(); }
        }

        public static ResourcesPage ResourcesPage
        {
            get { return GetPage<ResourcesPage>(); }
        }

        public static RetailAndHospitalityPage RetailAndHospitalityPage
        {
            get { return GetPage<RetailAndHospitalityPage>(); }
        }

        public static TransportPage TransportPage
        {
            get { return GetPage<TransportPage>(); }
        }

        public static ColourLabelPrintersPage ColourLabelPrintersPage
        {
            get { return GetPage<ColourLabelPrintersPage>(); }
        }

        public static DepartmentPrintersPage DepartmentPrintersPage
        {
            get { return GetPage<DepartmentPrintersPage>(); }
        }

        public static DesktopPrintersPage DesktopPrintersPage
        {
            get { return GetPage<DesktopPrintersPage>(); }
        }

        public static DotMatrixPrintersPage DotMatrixPrintersPage
        {
            get { return GetPage<DotMatrixPrintersPage>(); }
        }

        public static LabelMakersPage LabelMakersPage
        {
            get { return GetPage<LabelMakersPage>(); }
        }

        public static LargeFormatPrintersPage LargeFormatPrintersPage
        {
            get { return GetPage<LargeFormatPrintersPage>(); }
        }

        public static MakeTheSwitchPage MakeTheSwitchPage
        {
            get { return GetPage<MakeTheSwitchPage>(); }
        }

        public static ReplaceableInkPackSystemPage ReplaceableInkPackSystemPage
        {
            get { return GetPage<ReplaceableInkPackSystemPage>(); }
        }

        public static WorkgroupPrintersPage WorkgroupPrintersPage
        {
            get { return GetPage<WorkgroupPrintersPage>(); }
        }

        public static MobileProjectorsPage MobileProjectorsPage
        {
            get { return GetPage<MobileProjectorsPage>(); }
        }

        public static UltraMobileProjectorsPage UltraMobileProjectorsPage
        {
            get { return GetPage<UltraMobileProjectorsPage>(); }
        }

        public static ShortDistanceProjectorsPage ShortDistanceProjectorsPage
        {
            get { return GetPage<ShortDistanceProjectorsPage>(); }
        }

        public static UltraShortDistanceProjectorsPage UltraShortDistanceProjectorsPage
        {
            get { return GetPage<UltraShortDistanceProjectorsPage>(); }
        }

        public static InstallationProjectorsPage InstallationProjectorsPage
        {
            get { return GetPage<InstallationProjectorsPage>(); }
        }

        public static AllInOneProjectorsPage AllInOneProjectorsPage
        {
            get { return GetPage<AllInOneProjectorsPage>(); }
        }

        public static EducationProjectorsPage EducationProjectorsPage
        {
            get { return GetPage<EducationProjectorsPage>(); }
        }

        public static LaserProjectorsPage LaserProjectorsPage
        {
            get { return GetPage<LaserProjectorsPage>(); }
        }

        public static GenuineLampsPage GenuineLampsPage
        {
            get { return GetPage<GenuineLampsPage>(); }
        }

        public static A3FormatScannersPage A3FormatScannersPage
        {
            get { return GetPage<A3FormatScannersPage>(); }
        }

        public static BusinessScannersPage BusinessScannersPage
        {
            get { return GetPage<BusinessScannersPage>(); }
        }

        public static FlatbedScannersPage FlatbedScannersPage
        {
            get { return GetPage<FlatbedScannersPage>(); }
        }

        public static GraphicsScannersPage GraphicsScannersPage
        {
            get { return GetPage<GraphicsScannersPage>(); }
        }

        public static PortableScannersPage PortableScannersPage
        {
            get { return GetPage<PortableScannersPage>(); }
        }

        public static SheetfedScannersPage SheetfedScannersPage
        {
            get { return GetPage<SheetfedScannersPage>(); }
        }

        public static SignagePage SignagePage
        {
            get { return GetPage<SignagePage>(); }
        }

        public static TextilePage TextilePage
        {
            get { return GetPage<TextilePage>(); }
        }

        public static InteriorDecorPage InteriorDecorPage
        {
            get { return GetPage<InteriorDecorPage>(); }
        }

        public static LabellingPage LabellingPage
        {
            get { return GetPage<LabellingPage>(); }
        }

        public static CommercialEquipmentPage CommercialEquipmentPage
        {
            get { return GetPage<CommercialEquipmentPage>(); }
        }

        public static ProfessionalPhotographyPage ProfessionalPhotographyPage
        {
            get { return GetPage<ProfessionalPhotographyPage>(); }
        }

        public static FineArtPage FineArtPage
        {
            get { return GetPage<FineArtPage>(); }
        }

        public static PrePressPage PrePressPage
        {
            get { return GetPage<PrePressPage>(); }
        }

        public static TechnicalDesignPage TechnicalDesignPage
        {
            get { return GetPage<TechnicalDesignPage>(); }
        }

        public static RobotsPage RobotsPage
        {
            get { return GetPage<RobotsPage>(); }
        }

        public static DigitalLabelPressPage DigitalLabelPressPage
        {
            get { return GetPage<DigitalLabelPressPage>(); }
        }

        public static DiscproducerPage DiscproducerPage
        {
            get { return GetPage<DiscproducerPage>(); }
        }

        public static SmartHeadsetsPage SmartHeadsetsPage
        {
            get { return GetPage<SmartHeadsetsPage>(); }
        }

        public static AppsPage AppsPage
        {
            get { return GetPage<AppsPage>(); }
        }

        public static DocumentCapturePage DocumentCapturePage
        {
            get { return GetPage<DocumentCapturePage>(); }
        }

        public static ManagedPrintServicesPage ManagedPrintServicesPage
        {
            get { return GetPage<ManagedPrintServicesPage>(); }
        }

        public static MoverioISVDevelopersPage MoverioISVDevelopersPage
        {
            get { return GetPage<MoverioISVDevelopersPage>(); }
        }

        public static POSPrintersISVDevelopersPage POSPrintersISVDevelopersPage
        {
            get { return GetPage<POSPrintersISVDevelopersPage>(); }
        }

        public static Print365Page Print365Page
        {
            get { return GetPage<Print365Page>(); }
        }

        public static SoftwareForProjectorsPage SoftwareForProjectorsPage
        {
            get { return GetPage<SoftwareForProjectorsPage>(); }
        }

        public static CO2ElectricityCalculatorPage CO2ElectricityCalculatorPage
        {
            get { return GetPage<CO2ElectricityCalculatorPage>(); }
        }

        public static EcoTankSavingsCalculatorPage EcoTankSavingsCalculatorPage
        {
            get { return GetPage<EcoTankSavingsCalculatorPage>(); }
        }

        public static EpsonPrintAdminSavingsCalculatorPage EpsonPrintAdminSavingsCalculatorPage
        {
            get { return GetPage<EpsonPrintAdminSavingsCalculatorPage>(); }
        }

        public static LabelWorksTCOCalculatorPage LabelWorksTCOCalculatorPage
        {
            get { return GetPage<LabelWorksTCOCalculatorPage>(); }
        }

        public static LensDistanceCalculatorPage LensDistanceCalculatorPage
        {
            get { return GetPage<LensDistanceCalculatorPage>(); }
        }

        public static ProjectionScreenSizeCalculatorPage ProjectionScreenSizeCalculatorPage
        {
            get { return GetPage<ProjectionScreenSizeCalculatorPage>(); }
        }

        public static ProjectorTCOCalculatorPage ProjectorTCOCalculatorPage
        {
            get { return GetPage<ProjectorTCOCalculatorPage>(); }
        }

        public static ThrowDistanceCalculatorPage ThrowDistanceCalculatorPage
        {
            get { return GetPage<ThrowDistanceCalculatorPage>(); }
        }

        public static WFPCalculatorPage WFPCalculatorPage
        {
            get { return GetPage<WFPCalculatorPage>(); }
        }

        public static HomeAndPhotoPage HomeAndPhotoPage
        {
            get { return GetPage<HomeAndPhotoPage>(); }
        }

        public static HomeCinemaPage HomeCinemaPage
        {
            get { return GetPage<HomeCinemaPage>(); }
        }

        public static HomeOfficePage HomeOfficePage
        {
            get { return GetPage<HomeOfficePage>(); }
        }

        public static GamingPage GamingPage
        {
            get { return GetPage<GamingPage>(); }
        }

        public static EcoTankPage EcoTankPage
        {
            get { return GetPage<EcoTankPage>(); }
        }

        public static PrintersPage PrintersPage
        {
            get { return GetPage<PrintersPage>(); }
        }

        public static ProjectorsPage ProjectorsPage
        {
            get { return GetPage<ProjectorsPage>(); }
        }

        public static ScannersPage ScannersPage
        {
            get { return GetPage<ScannersPage>(); }
        }

        public static WearablesPage WearablesPage
        {
            get { return GetPage<WearablesPage>(); }
        }

        public static SmartGlassesPage SmartGlassesPage
        {
            get { return GetPage<SmartGlassesPage>(); }
        }

        public static InkFinderPage InkFinderPage
        {
            get { return GetPage<InkFinderPage>(); }
        }

        public static PaperFinderPage PaperFinderPage
        {
            get { return GetPage<PaperFinderPage>(); }
        }

        public static EpsonConnectPage EpsonConnectPage
        {
            get { return GetPage<EpsonConnectPage>(); }
        }

        public static PrintersProdPage PrintersProdPage
        {
            get { return GetPage<PrintersProdPage>(); }
        }

        public static ProjectorsProdPage ProjectorsProdPage
        {
            get { return GetPage<ProjectorsProdPage>(); }
        }

        public static RetailPage RetailPage
        {
            get { return GetPage<RetailPage>(); }
        }

        public static ScannersProdPage ScannersProdPage
        {
            get { return GetPage<ScannersProdPage>(); }
        }

        public static SmartEyewearPage SmartEyewearPage
        {
            get { return GetPage<SmartEyewearPage>(); }
        }

        public static VisualisersPage VisualisersPage
        {
            get { return GetPage<VisualisersPage>(); }
        }

        public static StorePage StorePage
        {
            get { return GetPage<StorePage>(); }
        }

        public static SupportPage SupportPage
        {
            get { return GetPage<SupportPage>(); }
        }

        public static AboutEpsonPage AboutEpsonPage
        {
            get { return GetPage<AboutEpsonPage>(); }
        }

        public static CareersPage CareersPage
        {
            get { return GetPage<CareersPage>(); }
        }

        public static CaseStudiesPage CaseStudiesPage
        {
            get { return GetPage<CaseStudiesPage>(); }
        }

        public static EnvironmentPage EnvironmentPage
        {
            get { return GetPage<EnvironmentPage>(); }
        }

        public static EventsPage EventsPage
        {
            get { return GetPage<EventsPage>(); }
        }

        public static InsightsPage InsightsPage
        {
            get { return GetPage<InsightsPage>(); }
        }

        public static NewsroomPage NewsroomPage
        {
            get { return GetPage<NewsroomPage>(); }
        }

        public static SponsorshipPage SponsorshipPage
        {
            get { return GetPage<SponsorshipPage>(); }
        }

        public static ProductRegistrationPage ProductRegistrationPage
        {
            get { return GetPage<ProductRegistrationPage>(); }
        }

        public static OrderReturnPage OrderReturnPage
        {
            get { return GetPage<OrderReturnPage>(); }
        }

        public static WarrantyCheckPage WarrantyCheckPage
        {
            get { return GetPage<WarrantyCheckPage>(); }
        }

        public static CoverPlusRegistrationPage CoverPlusRegistrationPage
        {
            get { return GetPage<CoverPlusRegistrationPage>(); }
        }

        public static ContactUsPage ContactUsPage
        {
            get { return GetPage<ContactUsPage>(); }
        }

        public static FindADealerPage FindADealerPage
        {
            get { return GetPage<FindADealerPage>(); }
        }

        public static PromotionsPage PromotionsPage
        {
            get { return GetPage<PromotionsPage>(); }
        }

        public static TermsOfUsePage TermsOfUsePage
        {
            get { return GetPage<TermsOfUsePage>(); }
        }

        public static TermsOfSalesPage TermsOfSalesPage
        {
            get { return GetPage<TermsOfSalesPage>(); }
        }

        public static CookieInformationPage CookieInformationPage
        {
            get { return GetPage<CookieInformationPage>(); }
        }

        public static ModernSlaveryActStatementPage ModernSlaveryActStatementPage
        {
            get { return GetPage<ModernSlaveryActStatementPage>(); }
        }

        public static PrivacyPolicyPage PrivacyPolicyPage
        {
            get { return GetPage<PrivacyPolicyPage>(); }
        }

        public static SellersIdentificationPage SellersIdentificationPage
        {
            get { return GetPage<SellersIdentificationPage>(); }
        }

        public static EpsonPartnerPortalPage EpsonPartnerPortalPage
        {
            get { return GetPage<EpsonPartnerPortalPage>(); }
        }

        public static ExecutiveTeamPage ExecutiveTeamPage
        {
            get { return GetPage<ExecutiveTeamPage>(); }
        }

        public static GlobalPage GlobalPage
        {
            get { return GetPage<GlobalPage>(); }
        }

        public static EpsonFacebookPage EpsonFacebookPage
        {
            get { return GetPage<EpsonFacebookPage>(); }
        }

        public static EpsonInstagramPage EpsonInstagramPage
        {
            get { return GetPage<EpsonInstagramPage>(); }
        }

        public static EpsonTwitterPage EpsonTwitterPage
        {
            get { return GetPage<EpsonTwitterPage>(); }
        }

        public static EpsonYouTubePage EpsonYouTubePage
        {
            get { return GetPage<EpsonYouTubePage>(); }
        }

        public static EmailSignUpPage EmailSignUpPage
        {
            get { return GetPage<EmailSignUpPage>(); }
        }

        public static FindYourProductPage FindYourProductPage
        {
            get { return GetPage<FindYourProductPage>(); }
        }

        public static InkAndSuppliesPage InkAndSuppliesPage
        {
            get { return GetPage<InkAndSuppliesPage>(); }
        }

        public static DriversAndSupportPage DriversAndSupportPage
        {
            get { return GetPage<DriversAndSupportPage>(); }
        }

        public static ProductPage ProductPage
        {
            get { return GetPage<ProductPage>(); }
        }

        #endregion
    }
}
