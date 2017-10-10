Feature: Navigate to the Product nav menu pages 
  As a user
  I should be able to navigate from the Epson home page to the Product navigation menu pages
  So that I can view all that the site has to offer


  Scenario Outline: Home Page navigation to Products nav menu pages
    Given I am on the homepage
    When I select the link "Products"
    And I select the link "<Link>"
	Then I should be on the All "<Link>" page

    Examples:
      | Link          |
      | Printers      |
      | Projectors    |
      | Scanners      |
      | Retail        |
      | Visualisers   |
      | Smart Eyewear |
      | Ink           |
      | Paper         |
