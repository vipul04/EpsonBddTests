Feature: Navigate to Ink, Store & Support nav menu pages
  As a user
  I should be able to navigate from the Epson home page to the Ink, Store & Support navigation menu pages
  So that I can view all that the site has to offer


  Scenario Outline: Home Page navigation to Ink, Store & Support nav menu pages
    Given I am on the homepage
    When I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link    |
      | Ink     |
      | Store   |
      | Support |