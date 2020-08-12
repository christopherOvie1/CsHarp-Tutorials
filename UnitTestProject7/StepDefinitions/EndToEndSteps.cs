using Auto.Hooks;
using Auto.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Auto.StepDefinitions
{
    [Binding]
    public class EndToEndSteps : Hook
    {
        PaymentPage paymentPage = new PaymentPage();
        ShippingPage shippingPage = new ShippingPage();
        LoginPages loginPages = new LoginPages();
        AddressPage addressPage = new AddressPage();
        SearchPage searchPage = new SearchPage();
        HomePage homePage = new HomePage();
        ProductPage productPage = new ProductPage();

        [When(@"user log into search page and searches desired (.*)")]
        public void WhenUserLogIntoSearchPageAndSearchesDesired(string Clothing)
        {

            homePage.ClickSearchTextField();
            Thread.Sleep(5000);
            homePage.LoginSearchPage(Clothing);
            Thread.Sleep(5000);
            homePage.ClickSearchIconButton();
        }

        [Then(@"user confirm I am on search page ""(.*)""")]
        public void ThenUserConfirmIAmOnSearchPage(string p0)
        {
            // string y= searchPage.Verify_SearchPage();
            //  Console.WriteLine("The page on the Search Page is "+y);
            //  Assert.AreEqual("Search - My Store", y,"error message does not display Search page");
            Assert.AreEqual("Search - My Store", driver.Title);
        }
        [Then(@"user choose an item displaying image and title and price")]
        public void ThenUserChooseAnItemDisplayingImageAndTitleAndPrice()
        {
            bool a = searchPage.Verify_ProductImageIsDisplayed();
            Console.WriteLine("I see product display  is " + a);
            Assert.IsTrue(a);

            string b = searchPage.Verify_ProductTitleIsSeen();
            Console.WriteLine("The text for the product is " + b);
            Assert.AreEqual("Faded Short Sleeve T-shirts", b);
            string c = searchPage.Verify_ProductPrice();
            Console.WriteLine("The price of the product is " + c);
            Assert.AreEqual("$16.51", c);
        }
        [Then(@"user log into a page ""(.*)"" showing product boldly displayed")]
        public void ThenUserLogIntoAPageShowingProductBoldlyDisplayed(string p0)
        {
            searchPage.ClickProduct();
            string d = searchPage.Verify_SpecificProductTitle();
            Console.WriteLine("The page title displayed is " + d);
            Assert.AreEqual("Faded Short Sleeve T-shirts - My Store", d);
        }
        [Then(@"I click Add To Cart Button")]
        public void ThenIClickAddToCartButton()
        {
            productPage.Click_AddToClickButton();
        }
        [Then(@"I confirm seeing a message ""(.*)""")]
        public void ThenIConfirmSeeingAMessage(string p0)
        {
            productPage.Verify_ProductAddedToCartMessage();
            // Console.WriteLine("I confirmed seeing " + m);
            // Assert.AreEqual(p0,productPage.Verify_ProductAddedToCartMessage());

            Assert.AreEqual("Product successfully added to your shopping cart", p0);
        }

        [Then(@"I login into Summary page")]
        public void ThenILoginIntoSummaryPage()
        {
            productPage.Click_ProccedToCheckoutButton();
            Thread.Sleep(5000);
            bool u = productPage.GetTextSHOPPINGCARTSUMMARYMessage();
            Console.WriteLine("i  confirm seeing Shopping Cart Summmary is " + u);

            Assert.IsTrue(productPage.GetTextSHOPPINGCARTSUMMARYMessage());
        }
        [Then(@"I log into sign in page")]
        public void ThenILogIntoSignInPage()
        {
            productPage.Click_SummaryPageProccedToCheckoutButton();
        }

        [Then(@"I checked Personal address is accurate")]
        public void ThenICheckedPersonalAddressIsAccurate()
        {
            string actual = addressPage.CheckDeliveryAddressIsAccurate();

            string expected = addressPage.CheckAddressText();
            Assert.AreEqual(expected, actual, "addresses do not match");
            Console.WriteLine(actual);


        }
        [When(@"I log in using correct EmailAddress as ""(.*)"" and Password as ""(.*)""")]
        public void WhenILogInUsingCorrectEmailAddressAsAndPasswordAs(string EmailAddress, string Password)
        {
            loginPages.LoginAfterEnteringCorrectEmailAddressAndPassword(EmailAddress, Password);
        }
        [Then(@"I log into shipping page")]
        public void ThenILogIntoShippingPage()
        {
            addressPage.Click_AddressProccedToCheckoutButton();
            string shippingText = shippingPage.Get_ShipppingText();
            Console.WriteLine(shippingText);
            Assert.AreEqual("SHIPPING", shippingPage.Get_ShipppingText());
            Thread.Sleep(5000);
            //shippingPage.Click_termsOfServiceButton();
            //shippingPage.Click_shippingProceedToCheckoutButton();
        }
        [Then(@"I log into payment page after agreeing terms of reference")]
        public void ThenILogIntoPaymentPageAfterAgreeingTermsOfReference()
        {
            shippingPage.Click_termsOfServiceButton();
            shippingPage.Click_shippingProceedToCheckoutButton();
            string v = paymentPage.Check_pleaseChoosePaymentMethodChoiceText();
            Console.WriteLine("The text seen is " + v);
            Assert.AreEqual("PLEASE CHOOSE YOUR PAYMENT METHOD", paymentPage.Check_pleaseChoosePaymentMethodChoiceText());
            string t = paymentPage.Confirm_TotalPriceText();
            Console.WriteLine(t);
            Assert.AreEqual("$18.51", paymentPage.Confirm_TotalPriceText());
        }

        [Then(@"I choose my payment method")]
        public void ThenIChooseMyPaymentMethod()
        {
            paymentPage.Click_paymentByCheckArrow();
        }
        [Then(@"I confirm my method")]
        public void ThenIConfirmMyMethod()
        {
            paymentPage.Click_confirmMyOderArrow();
        }
        [Then(@"I confirm the completion of my order")]
        public void ThenIConfirmTheCompletionFMyOrder()
        {
            string m = paymentPage.Check_orderConfirmationText();
            Console.WriteLine("The confirmatiom message is :" + m);
            Assert.AreEqual("Your order on My Store is complete.", paymentPage.Check_orderConfirmationText());

        }
        [Then(@"I also confirm what my transaction  include")]
        public void ThenIAlsoConfirmWhatMyTransactionInclude()
        {
            string d = paymentPage.CheckTransactionIncludeMessageIsAccurateText();
            Console.WriteLine("Further transaction message method include :" + d);
        }

        //[When(@"user mouses hover women and clicks on summer dress")]
        //public void WhenUserMousesHoverWomenAndClicksOnSummerDress()
        //{
        //    searchPage.Click_SummerDressLink();
        //}
        [When(@"user mouses hover women and clicks on ""(.*)""")]
        public void WhenUserMousesHoverWomenAndClicksOn(string linkname)
        {
            searchPage.Click_SummerDressLink(linkname);
        }

        //[When(@"user changes the price from \$(.*) to \$(.*)")]
        //public void WhenUserChangesThePriceFromTo(int p0, int p1)
        //{

        //    searchPage.Move_Slider1();
        //}
        [When(@"user moves sliderOne to (.*)")]
        public void WhenUserMovesSliderOneTo(int Amount)
        {
            searchPage.Move_Slider1(Amount);
        }


    }
}
