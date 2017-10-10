Feature: Search
	As a user 
	I should be able to navigate to and search the site 
	So that I can find what I require 

Scenario Outline: Navigate to search pages via quick links
	Given I am on the homepage
	And I select the search icon
	When I select the link "<Link>"
	Then I should be on the "<Link>" page

	Examples: 
		| Link              | 
		| Find your product |
		| Ink & Supplies    |
		| Drivers & Support |

Scenario Outline: Navigate to Find your product page and search for product
	Given I am on the homepage
	And I go to "Find your product" search page
	And I search for product "<Product>"
	When I select the link "<Product>"
	Then I should be on the product page for "<Product>"

	Examples: 
		| Product                   | 
		| WorkForce Pro WF-4740DTWF |
		| Moverio BT-200            |


Scenario Outline: Navigate to Find your product page and choose product
	Given I am on the homepage
	And I go to "Find your product" search page
	And I select the link "<ProductType>"
	And I select the link "<ProductCategory>"
	When I select the link "<Product>"
	Then I should be on the product page for "<Product>"

	Examples: 
		| ProductType         | ProductCategory   | Product                        |
		| Projectors          | Mobile Projectors | EB-U32                         | 
		| Scanners            | Graphics Scanner  | Expression 11000XL             | 
		| Discproducer        |                   | Epson Discproducer™ PP-100IIBD | 
		| Wearable Technology |                   | Runsense SF-810V               | 

Scenario Outline: Navigate to Ink & Supplies page and search for product
	Given I am on the homepage
	And I go to "Ink & Supplies" search page
	And I select the link "<ProductType>"
	And I search for ink or supplies "<SearchTerm>"
	When I select the link "<Product>"
	Then I should be on the product page for "<Product>"


	Examples: 
		| ProductType   | SearchTerm                  | Product                                                   |
		| Ink Cartridge | T9132                       | T9132 Cyan Ink Cartridge (200ml)                          |
		| Toner         | Toner Cartridge Cyan        | Toner Cartridge Cyan2.5k                                  |
		| Ribons        | SIDM Black Ribbon Cartridge | Epson SIDM Black Ribbon Cartridge for LX-100 (C13S015047) |
		| Label Makers  | Labelworks                  | LabelWorks LW-300                                         |