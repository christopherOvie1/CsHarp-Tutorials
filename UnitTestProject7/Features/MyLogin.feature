@SmokeTest
Feature: Login Feature Test
  In order to access my account
    As a user of the website
   I want to log into the website

Background:
	Given I Navigate To Website
	When I click sign in
	Then I am on 'Login - My Store' Page

Scenario Outline: To test user is able to login successfully
	# And I login with email "davin.riches@gmail.com" and password "Today01"
	When I log in with correct <EmailAddress> and <Password>
	Then I checked  <User> is logged in successfully

	Examples:
		| EmailAddress           | Password | User         |
		| davin.riches@gmail.com | Today01  | davin riches |

#|escosolo7@gmail.com       | Ikeama78 |
#Examples:
#  | EmailAddress           | Password |
#  | davin.riches@gmail.com | Today01   |
#  | escosolo7@gmail.com    | Ikeama78  | Emeka Onourha |
Scenario Outline: To test that user is unable to login if invalid credentials are entered
	When I try to log in with incorrect  <Email> or incorrect <Passswd>
	Then I should see error <Message>
	

	Examples:
		| Email                  | Passswd | Message                |
		| davin.riches@gmail.com | Today2  | Password is required. |

#  | esco@yahmail.com         | Ikeama78 | Authentication failed. |
# | christodibo@yaho         | To7@     | Invalid password.      |
Scenario Outline: To test that user is unable to login when the one or both field are blank
	When I try to log in with blank  <MyemailAddress> or <Mypasssword>
	#Then I validate  <errorMesssage>

	Examples:
		| MyemailAddress         | Mypasssword | errorMesssage         |
		| davin.riches@gmail.com |             | Password is required. |
#   |                        |             | An email address required. |
#   |                        |             | An email address required. |