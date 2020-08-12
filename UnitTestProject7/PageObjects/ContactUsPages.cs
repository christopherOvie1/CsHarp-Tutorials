using Auto.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Auto.Utilities;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto.PageObjects
{
    [Binding]
    class ContactUsPages :Hook
    {
        private static By messageField = By.Id("message");
        private static By contactUsLink = By.LinkText("Contact us");
        private static By logoButton = By.CssSelector(".logo");
        private static By sendButton = By.Id("submitMessage");
        private static By messageReceivedText = By.CssSelector("#center_column > p");
        private static By emailButton = By.Id("email");
        private static By errorMessageReceivedText = By.CssSelector("#center_column > div > ol > li");
        private static By orderRefButton= By.Id("id_order");

        private static By subjectHeading = By.CssSelector("#id_contact");
      // IWebElement subjectHeading => driver.FindElement(By.CssSelector("#id_contact"));
       // IWebElement emailButton => driver.FindElement(By.Id("email"));
       //IWebElement orderRefButton => driver.FindElement(By.Id("id_order"));
     
       // IWebElement messageReceivedText => driver.FindElement(By.CssSelector("#center_column > p"));
       // IWebElement errorMessageReceivedText => driver.FindElement(By.CssSelector("#center_column > div > ol > li"));

        public void Navigate_To_Website()
        {
            driver.Url = "http://automationpractice.com/index.php";
    
        }
        public  string Verify_HomePageTitle()
        {
         return   driver.Title;
        }
        public void Click_ContactUsLink()
        {
            driver.FindElement(contactUsLink).Click();   
        }
        public string Verify_contactUsPageTitle()
        {
            return driver.Url;
        }
        public bool VerifyLogoBanner()
        {
           return driver.FindElement(logoButton).Displayed;
        
        }

        public void IchoseSubjectHeading(string subheading)
        {
            WebDriverFunctions.WebDriverSelect(subjectHeading, subheading);
            // SelectElement element = new SelectElement(driver.FindElement(subjectHeading));
            //element.SelectByIndex(1);
            //element.SelectByText("Customer service");
        }
       public void EnterEmailndPassword(string Email, string OrderReference)
        {
            driver.FindElement(emailButton).SendKeys(Email);
            driver.FindElement(orderRefButton).SendKeys(OrderReference);
        }
        public void LogInAndConfirmMessageIsReceived(string Message)
        {
            
            driver.FindElement(messageField).SendKeys(Message);

        }
          public void ClickSendButton()
        {
            driver.FindElement(sendButton).Click();
          
        }
        public string MessgeSentConfirmedText()
        {
         
         return   driver.FindElement(messageReceivedText).Text;
        }
        public void NavigateToContactUsPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
      

        public void IalsoEnterEmailAndPassword(string Email, string OrderReference)
        {
            driver.FindElement(emailButton).SendKeys(Email);
            driver.FindElement(orderRefButton).SendKeys(OrderReference);
        }
        public string VerifyErrorMessageReceivedText()
        {
        return driver.FindElement(errorMessageReceivedText).Text;
         
        }
      
    }
}
