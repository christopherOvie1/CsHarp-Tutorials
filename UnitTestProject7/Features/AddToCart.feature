Feature: AddToCart

Scenario: When I add an item then the application should add it to my list of items
	Given I have logged in as "Davin Riches"
	When I search for the following item having
		| Title                 | Price  | Discription |
		| Printed Chiffon Dress | $16.40 | Image       |
		
