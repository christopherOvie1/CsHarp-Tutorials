using Auto.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Auto.PageObjects
{
    [Binding]
    class AddressPage : Hook
    {
        private static By AddressProccedToCheckoutButton = By.CssSelector("#center_column > form > p > button > span");
        private static By userAddressField = By.Id("address_delivery");
       // IWebElement userAddressField => driver.FindElement(By.Id("address_delivery"));
       // IWebElement AddressProccedToCheckoutButton => driver.FindElement(By.CssSelector("#center_column > form > p > button > span"));

        public string CheckDeliveryAddressIsAccurate()
        {
            return driver.FindElement(userAddressField).Text;
        }
        public void Click_AddressProccedToCheckoutButton()
        {
            driver.FindElement(AddressProccedToCheckoutButton).Click();
           // AddressProccedToCheckoutButton.Click();
        }
        public string CheckAddressText(string name= "Davin Riches",
            string addressLine1= "Flat 203, cross court",
            string addressLine2 = "Chicago, Illinois 24378", 
            string country="United States",
            string phoneNumber= "07535679125")
        {
            StringBuilder addressBlock = new StringBuilder();
            addressBlock.AppendLine("YOUR DELIVERY ADDRESS");
            addressBlock.AppendLine(name);
            addressBlock.AppendLine(addressLine1);
            addressBlock.AppendLine(addressLine2);
            addressBlock.AppendLine(country);
            addressBlock.AppendLine(phoneNumber.ToString());
            addressBlock.Append("Update");
            return addressBlock.ToString();


        }





    }
}

