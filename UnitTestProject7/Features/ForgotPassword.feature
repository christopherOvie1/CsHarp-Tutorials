Feature: ForgotPassword
As a user  of the website 
I want to check i can receive a forgot password link
So that i can log in 

Background:
	Given I Navigate To Website
	When I click sign in
	Then I am on 'Login - My Store' Page

Scenario: As a user of the platform I want to check if I can receive a password link

When I click forget password link
###When User click on forget password link
And user clicks on retreive password button
#And I log into forgot password page
