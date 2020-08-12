@SmokeTest
Feature: Contact us Test App

Scenario: To test that user can navigate to contact us page
	Given I Navigate To Website
	Then I see a logo
	When I log into contact us page

# Then I verify title of contact us page
Scenario Outline: To test user  receives a confirmation message when user makes a request
	Given I Navigate To Website
	Then I see a logo
	When I log into contact us page
	Then I verify title of contact us page
	And I fill in contact Us details by choosing  subject heading "Customer service"
	And I also entered <Email> and <OrderReference>
	When I log in after  typing  a <Message> of enquiry
	Then I should see  the  message displayed "Your message has been successfully sent to your team."

	Examples:
		| Email                  | OrderReference | Message                |
		| davin.riches@gmail.com | 123            | I want to see my order |

# |escosolo7@gmail.com      |            456 |  How soon can I cancel my order? |
Scenario Outline: To test that  user sees an error message when user do not enter any message
	Given I Navigate To "http://automationpractice.com/index.php?controller=contact"
	#And I fill in contact Us details by choosing  subject heading
	#And I fill in contact Us details by choosing  subject heading "Customer service"
	And I entered <Email> and <OrderReference>
	When I log in after  typing  a <Message> of enquiry
	Then I should see an error message

	Examples:
		| Email                  | OrderReference | Message |
		| davin.riches@gmail.com | 123            |         |
		#| escosolo7@gmail.com    | 456            |         |