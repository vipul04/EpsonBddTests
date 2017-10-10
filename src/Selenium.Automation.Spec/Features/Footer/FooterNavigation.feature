Feature: Navigate to the footer links
  As a user
  I should be able to navigate from the Epson home page to the pages in the footer
  So that I can view all that the site has to offer


  Scenario Outline: Epson Home Page navigation to footer Customer Service pages
    Given I am on the homepage
    When I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link                   |
      | Product Registration   |
      | Order return           |
      | Warranty Check         |
      | CoverPlus registration |
      | Contact Us             |
      | Find a dealer          |
      | Promotions             |


  Scenario Outline: Epson Home Page navigation to footer Terms pages
    Given I am on the homepage
    When I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link           |
      | Terms of sales |
      | Terms of use   |


  Scenario Outline: Epson Home Page navigation to footer Legal pages
    Given I am on the homepage
    When I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link                         |
      | Privacy Policy               |
      | Cookie Information           |
      | Seller's identification      |
      | Modern Slavery Act Statement |

  Scenario Outline: Epson Home Page navigation to footer Other Epson Sites pages
    Given I am on the homepage
    When I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link                 |
      | Newsroom             |
      | Epson Partner Portal |
      | Global               |
      | Executive Team       |

 
  Scenario Outline: Epson Home Page navigation to footer Social media pages
    Given I am on the homepage
    When I select the link "<Link>"
	Then I should be on the "<Link>" page

    Examples:
      | Link                     |
      | icon-misc-socialfacebook |
      | icon-misc-socialyoutube  |
      | icon-misc-socialtwitter  |
      | icon-social-instagram    |


    Scenario: Navigate from Epson Homepage footer to Email Sign up page
      Given I am on the homepage
      When I enter "test@test.com" into email field and submit
      Then I should be on the "Email Sign Up - Epson" page
