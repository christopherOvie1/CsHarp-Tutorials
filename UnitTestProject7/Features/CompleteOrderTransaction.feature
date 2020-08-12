Feature:  Complete an order transaction
	As a  buyer I want to puchase an item and
	confirm I receive a receipt
Background:
	Given I Navigate To Website
	Then I see a logo
Scenario Outline: VerifyCustomerCompleteTransaction
	
	When user log into search page and searches desired <Clothing>
	#Then user confirm I am on search page "Search - My Store"
	Then I am on 'Search - My Store' Page
	And user choose an item displaying image and title and price
	###Then user selects 
	Then user log into a page "Faded Short Sleeve T-shirts - My Store" showing product boldly displayed
	And  I click Add To Cart Button
	Then I confirm seeing a message "Product successfully added to your shopping cart"
	And I login into Summary page
	And I log into sign in page
	When I log in using correct EmailAddress as "davin.riches@gmail.com" and Password as "Today01"
	Then I checked Personal address is accurate
	And I log into shipping page
	And I log into payment page after agreeing terms of reference
  And I choose my payment method
  And I confirm my method
  Then I confirm the completion of my order
  And I also confirm what my transaction  include

	Examples:
		| Clothing | 
  	    | T-Shirt  | 
	
Scenario: To test that a user is able to change the price of a summer dress to $16-$20
#When user mouses hover women and clicks on "Summer Dresses"
When user mouses hover women and clicks on "Summer Dresses"
#And user changes the price from $16 to $20
And user moves sliderOne to 20


Scenario: VerifyOrderCompleteTransaction

When user enters a "text" on the homepage search box 
And clicks on the search icon
Then I am on 'Search - My Store' Page
When  user hoover over the returned image "Faded Short Sleeve T-shirts"
Then a window is displayed
And  I click Add To Cart Button
 Then ensures a pop up windows appears containing "faded Short Sleeve T-shirts" has been successfully added
Then ensures a pop up box is displayed
When I click on the "proceed to checkout button" on the pop up window
Then Then I am on 'Order - My Store' Page
When I click on proceed to checkout button
Then I am on 'Login - My Store' Page
And 






