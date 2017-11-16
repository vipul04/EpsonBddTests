Feature: Navigate to the Home nav menu pages
  As a user
  I should be able to navigate from the Epson home page to the Home navigation menu pages
  So that I can view all that the site has to offer

  @test
  Scenario Outline: Home Page navigation to Home - Solutions for Home pages
    Given I am on the homepage
    When I select the link "Home"
    And I select the link "Solutions for Home"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link         |
      | Home & Photo |
      | Home Cinema  |
      | Home Office  |
      | Gaming       |

  Scenario Outline: Home Page navigation to Home - Home products
    Given I am on the homepage
    When I select the link "Home"
    And I select the link "Home Products"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link          |
      | EcoTank       |
      | Printers      |
      | Projectors    |
      | Scanners      |
      | Wearables     |
      | Smart Glasses |
      | Ink Finder    |
      | Paper Finder  |

@test
  Scenario Outline: Home Page navigation to Home - Apps & Services for Home pages
    Given I am on the homepage
    When I select the link "Home"
    And I select the link "Apps & Services for Home"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link          |
      | Apps          |
      | Epson Connect |