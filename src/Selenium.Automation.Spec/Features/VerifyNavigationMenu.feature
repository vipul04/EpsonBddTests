Feature: Verify Navigation Menu
	As a user
	I want to see the navigation menu
	So that I can go on the correct page

Scenario: Verify Navigation Menu Items
	Given I am on the homepage
	Then I should see the following menu items
		| Menu Item  |
		| ABOUT      |
		| WORK       |
		| SERVICES   |
		| PARTNERS   |
		| INDUSTRIES |
		| INSIGHTS   |
		| CAREERS    |
