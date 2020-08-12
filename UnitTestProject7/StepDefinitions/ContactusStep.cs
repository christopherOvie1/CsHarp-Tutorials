using Auto.PageObjects;
using System;
//using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Auto.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium.Chrome;

namespace Auto.StepDefinitions
{
    [Binding]
   public class ContactusStep: Hook
    {
        ContactUsPages contactUsPages = new ContactUsPages();

        [Given(@"I Navigate To Website")]
        public void GivenINavigateToWebsite()
        {
            contactUsPages.Navigate_To_Website();
            string k = contactUsPages.Verify_HomePageTitle();
            Console.WriteLine("The  title of HomePage is " + k);
            Console.WriteLine("The total length is "+k.Length.ToString("My"));
           // Assert.AreEqual("My Store", k, "The error message displayed is incorrect");
             //Assert.AreEqual("My Store", driver.Title);
            Assert.IsTrue(k.Contains("My Store"));
        }
        //[Given(@"I fill in contact Us details by choosing  subject heading")]
        //[Then(@"I fill in contact Us details by choosing  subject heading")]
        //public void ThenIFillInContactUsDetailsByChoosingSubjectHeading()
        //{
        //    contactUsPages.IchoseSubjectHeading();
        //}
        [When(@"I log into contact us page")]
        public void WhenILogIntoContactUsPage()
        {
            contactUsPages.Click_ContactUsLink();
        }
        [Then(@"I verify title of contact us page")]
        public void ThenIVerifyTitleOfContactUsPage()
        {
      string o=  contactUsPages.Verify_contactUsPageTitle();
            Console.WriteLine("title of page is "+ o);
        }
        [Then(@"I see a logo")]
        public void ThenISeeALogo()
        {
       bool f= contactUsPages.VerifyLogoBanner();
            Console.WriteLine("logo banner displayed is " +f);
            Assert.IsTrue(contactUsPages.VerifyLogoBanner());
        } 
        [Then(@"I also entered (.*) and (.*)")]
        public void ThenIAlsoEnteredAnd(string Email,string OrderReference)
        {
            contactUsPages.EnterEmailndPassword(Email, OrderReference);
        }
        [When(@"I log in after  typing  a (.*) of enquiry")]
        public void WhenILogInAfterTypingAOfEnquiry(string Message)
        {
            contactUsPages.LogInAndConfirmMessageIsReceived(Message);
            contactUsPages.ClickSendButton();
        }
        [Then(@"I should see  the  message displayed ""(.*)""")]
        public void ThenIShouldSeeTheMessageDisplayed(string message)
        {
           string  y= contactUsPages.MessgeSentConfirmedText();
            Console.WriteLine("The message received is " + y);
          Assert.AreEqual("Your message has been successfully sent to our team.", y,"y is  incorrect");
            //Assert.AreEqual("Your message has been successfully sent to our team.", message);
        }
        [Given(@"I Navigate To ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            contactUsPages.NavigateToContactUsPage(url);
        }
        //[Given(@"I fill in contact Us details by choosing  subject heading")]
        //public void GivenIFillInContactUsDetailsByChoosingSubjectHeading()
        //{
        //   // contactUsPages.IchoseSubjectHeading();
        //}
        /*[Given(@"I enter email and order reference  as ""(.*)""  and ""(.*)"" respectively")]
        public void GivenIEnterEmailAndOrderReferenceAsAndRespectively(string email, int orderReference)
        {
            {
                contactUsPages.TypeEmailAndOrderRef(email, orderReference);
                    }*/

            [Given(@"I entered (.*) and (.*)")]
        public void GivenIEnteredAnd(string Email, string OrderReference)
        {
            contactUsPages.IalsoEnterEmailAndPassword(Email, OrderReference);
        }
        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            string errorMessage = contactUsPages.VerifyErrorMessageReceivedText();
            Console.WriteLine("Error Message read is " + errorMessage);
            Assert.AreEqual("The message cannot be blank.", errorMessage,"The error message displayed is incorrect");
        }
        [Then(@"I fill in contact Us details by choosing  subject heading ""(.*)""")]
        public void ThenIFillInContactUsDetailsByChoosingSubjectHeading(string subheading)
        {
            contactUsPages.IchoseSubjectHeading(subheading);
        }


    }
}
