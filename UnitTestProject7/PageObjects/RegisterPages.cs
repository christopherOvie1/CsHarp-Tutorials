using Auto.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Auto.PageObjects
{
    [Binding]
    class RegisterPages : Hook
    {
      
        private static By emailField = By.Id("email_create");


        public void Click_EmailTAdd()
        {


            //
            // driver.FindElement(EmailTextField).SendKeys();

            //var actualEmail = Guid.NewGuid().ToString().Substring(3, 5) + $"@msn.com";
            //EmailTextField.SendKeys(EmailTextField);

            var actualEmail = Guid.NewGuid().ToString().Substring(3, 5) + $"@msn.com";
             driver.FindElement(emailField).SendKeys(actualEmail);


        }
    }
}
