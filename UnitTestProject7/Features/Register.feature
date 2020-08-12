Feature: Register A new user Test
    As a visitor  to the website
   I want to create an account 
   So that I can access products services

Scenario: To Check that visitor is able to create an account
	Given I Navigate To Website
	When I click sign in
	Then I am on 'Login - My Store' Page
	When I enter email that is not registered
	And I click on create account button
	#Then I am on Create an account page
	#And i choose title
	#When I fill in the personal information  field
	#	| Firstname | Firstname | Password |
	#	| pet       | gas       | todayo9  |
	#And I also enter "DateOfBirth"
	#When I fill in Address section
	#	| Company | Address(Line1) | Address(Line2) | City     | State    | Postal Code | Country | Additionalinformation | Homephone   | Mobilephone | AssignedAddress |
	#	| xyz ltd | 5a             | Green Ave      | New York | new york | 10003       | USA     |                       | 07654325677 | 07654323656 |                 |
	#	Then a new account will be created for me