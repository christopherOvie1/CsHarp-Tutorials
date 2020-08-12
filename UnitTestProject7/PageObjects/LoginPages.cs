using Auto.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System.Threading;
using Auto.Utilities;

namespace Auto.PageObjects
{

    [Binding]
    class LoginPages : Hook
    {
        private static By retrieveforgetPassword = By.CssSelector("#form_forgotpassword > fieldset > p > button > span");
        private static By accountNameButton = By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(1) > a > span");
        private static By signInButton = By.CssSelector("#SubmitLogin > span");
        private static By passwordFieldButton = By.Id("passwd");
        private static By emailAddressFieldButton = By.Id("email");
        private static By signInLink = By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a");
     //private static By emailField = By.Id("email_create");
        private static By errorMessageText = By.CssSelector("#center_column > div.alert.alert-danger > ol > li");
        private static By forgotPasswordLink = By.CssSelector("#login_form > div > p.lost_password.form-group > a");
        // IWebElement emailField => driver.FindElement(By.Id("email_create"));
        // IWebElement forgotPasswordLink => driver.FindElement(By.CssSelector("#"));
        // IWebElement errorMessageText => driver.FindElement(By.CssSelector("#"));
        //  private static By signInLink = By.CssSelector("#center_column > div.alert.alert-danger > ol > li");
        // IWebElement signInLink => driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
        //IWebElement errorMessageText => driver.FindElement(By.CssSelector("#center_column > div.alert.alert-danger > ol > li"));
        // IWebElement emailAddressFieldButton => driver.FindElement(By.Id("email"));
        // IWebElement passwordFieldButton => driver.FindElement(By.Id("passwd"));
       // IWebElement signInButton => driver.FindElement(By.CssSelector("#SubmitLogin > span"));
        // IWebElement accountNameButton => driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(1) > a > span"));
        public void IClickSignIink()
        {
            // signInLink.Click();
            driver.FindElement(signInLink).Click();
        }
        public void LoginAfterEnteringCorrectEmailAddressAndPassword(string EmailAddress, string Password)
        {
            // emailAddressFieldButton.SendKeys(EmailAddress);
            // passwordFieldButton.SendKeys(Password);
            //signInButton.Click();
            driver.FindElement(emailAddressFieldButton).SendKeys(EmailAddress);
            driver.FindElement(passwordFieldButton).SendKeys(Password);
            driver.FindElement(signInButton).Click();
        }
        public string CheckAccountNameIsCorrect()
        {
            return driver.FindElement(accountNameButton).Text;
            // return accountNameButton.Text;
        }
        public void AttemptLoginWithIncorrectEmailAndPassword(string Email, string Passswd)
        {
            driver.FindElement(emailAddressFieldButton).SendKeys(Email);
            driver.FindElement(passwordFieldButton).SendKeys(Passswd);
            //driver.FindElement(signInButton).Click
              //emailAddressFieldButton.SendKeys(Email);
            //passwordFieldButton.SendKeys(Passswd);
            //signInButton.Click();
        }
    
        public string Validate_ErrorMesssage()
        {
           
         return   driver.FindElement(errorMessageText).Text;
        }
        public void Click_forgotPasswordLink()
        {
            driver.FindElement(forgotPasswordLink).Click();
           
        }
        public void Click_EmailTAdd()
        {

            // var actualEmail = Guid.NewGuid().ToString().Substring(3, 5) + $"@msn.com";
            // driver.FindElement(emailField).SendKeys(actualEmail);
            //var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //var stringChars = new char[8];
            //var random = new Random();

            //for (int i = 0; i < stringChars.Length; i++)
            //{
            //    stringChars[i] = chars[random.Next(chars.Length)];
            //}

            //var finalString = new String(stringChars);

        }
         public void Click_retrieveforgetPassword()
        {
            driver.FindElement(retrieveforgetPassword).Click();

        }
    }
}
