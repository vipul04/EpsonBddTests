Feature: Navigate to the Business nav menu pages
  As a user
  I should be able to navigate from the Epson home page to the Business navigation menu pages
  So that I can view all that the site has to offer


  Scenario Outline: Home Page navigation to Business - Solutions for Verticals pages
    Given I am on the homepage
    When I select the link "Business"
    And I select the link "Solutions for Verticals"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page
    Examples:
      | Link                  | 
      | Education             | 
      | Corporate             | 
      | Healthcare            | 
      | Public Sector         | 
      | Finance               | 
      | Legal & Accounting    | 
      | Retail & Hospitality  | 
      | Transport             | 
      | Professional Graphics | 
      | Meeting Solutions     | 
      | Resources             | 


  Scenario Outline: Epson Home Page navigation to Business - Business Printers pages
    Given I am on the homepage
    When I select the link "Business"
    And I select the link "Business Printers"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link                        | 
      | Make the Switch             | 
      | Desktop Printers            |
      | Workgroup Printers          |
      | Department Printers         |
      | Replaceable Ink Pack System |
      | Large Format Printers       |
      | Label Makers                |
      | Colour Label Printers       |
      | Dot Matrix Printers         |


  Scenario Outline: Epson Home Page navigation to Business - Business Projectors pages
    Given I am on the homepage
    When I select the link "Business"
    And I select the link "Business Projectors"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link                            |
      | Mobile Projectors               |
      | Ultra Mobile Projectors         |
      | Short Distance Projectors       |
      | Ultra Short Distance Projectors |
      | Installation Projectors         |
      | All in one Projectors           |
      | Education Projectors            |
      | Laser Projectors                |
      | Genuine Lamps                   |


  Scenario Outline: Epson Home Page navigation to Business - Business Scanners pages
    Given I am on the homepage
    When I select the link "Business"
    And I select the link "Business Scanners"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page
    Examples:
      | Link              |
     #| Business Scanners | Selenium finds the Business scanners in first level rather than 2nd level icon
      | Portable Scanners  |
      | Flatbed Scanners   |
      | Sheetfed Scanners  |
      | Graphics Scanners  |
      | A3 Format Scanners |


  Scenario Outline: Epson Home Page navigation to Business - ProGraphics pages
    Given I am on the homepage
    When I select the link "Business"
    And I select the link "ProGraphics"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link                     |
      | Signage                  |
      | Textile                  |
      | Interior Décor           |
      | Labelling                |
      | Commercial Equipment     |
      | Professional Photography |
      | Fine Art                 |
      | Pre-Press                |
      | Technical Design         |


  Scenario Outline: Epson Home Page navigation to Business - Industrial pages
    Given I am on the homepage
    When I select the link "Business"
    And I select the link "Industrial"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link                  |
      | Robots                |
      | Digital Label Press   |
      | Colour Label Printers |
      | Large Format Printers |
      | Discproducers         |
      | Smart Headsets        |


  Scenario Outline: Epson Home Page navigation to Business - Apps & Services for Businesses pages
    Given I am on the homepage
    When I select the link "Business"
    And I select the link "Apps & Services for Business"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link                        |
      | Apps                        |
      | Managed Print Services      |
      | Print365                    |
      | Document Capture            |
      | Software for Projectors     |
      | Moverio ISV Developers      |
      | POS Printers ISV Developers |

  Scenario Outline: Epson Home Page navigation to Business - Business Tools pages
    Given I am on the homepage
    When I select the link "Business"
    And I select the link "Business Tools"
    And I select the link "<Link>"
    Then I should be on the "<Link>" page

    Examples:
      | Link                                 |
      | LabelWorks TCO Calculator            |
      | Epson Print Admin Savings Calculator |
      | CO2 & Electricity Calculator         |
      | WFP Calculator                       |
      | Projector TCO Calculator             |
      | Throw Distance Calculator            |
      | Lens Distance Calculator             |
      | Projection Screen Size Calculator    |
      | EcoTank Savings Calculator           |