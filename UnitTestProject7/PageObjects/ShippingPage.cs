using Auto.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Auto.PageObjects
{
    [Binding]
    class ShippingPage : Hook
    {
        IWebElement shippingProceedToCheckoutButton => driver.FindElement(By.CssSelector("#form > p > button > span"));
        IWebElement termsOfServiceButton => driver.FindElement(By.CssSelector("#cgv"));
        IWebElement shippingText => driver.FindElement(By.CssSelector("#carrier_area > h1"));

        public string Get_ShipppingText()
        {
            return shippingText.Text;
        }

        public void Click_termsOfServiceButton()
        {
            termsOfServiceButton.Click();

        }
        public void Click_shippingProceedToCheckoutButton()
        {
            shippingProceedToCheckoutButton.Click();
        }
    }
}