Feature: Navigate to the About nav menu pages
  As a user
  I should be able to navigate from the Epson home page to the About navigation menu pages
  So that I can view all that the site has to offer


  Scenario Outline: Home Page navigation to About nav menu pages
    Given I am on the homepage
    When I select the link "About"
    And I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link         |
      | About Epson  |
      | Sponsorship  |
      | Careers      |
      | Insights     |
      | Newsroom     |
      | Case Studies |
      | Environment  |
      | Events       |
