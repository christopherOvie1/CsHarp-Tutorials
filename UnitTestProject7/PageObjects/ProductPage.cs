using Auto.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Auto.PageObjects
{
    [Binding]
    class ProductPage : Hook
    {
        IWebElement SHOPPINGCARTSUMMARYMessage => driver.FindElement(By.CssSelector("#summary_products_quantity"));
        IWebElement AddToClickButton => driver.FindElement(By.CssSelector("#add_to_cart > button > span"));
        IWebElement ProccedToCheckoutButton => driver.FindElement(By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > a > span"));
        IWebElement SummaryPageProccedToCheckoutButton => driver.FindElement(By.CssSelector("#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium > span"));
        IWebElement ProductAddedToCartMessage => driver.FindElement(By.CssSelector("h2:nth-child(2)"));
        public void Click_AddToClickButton()
        {
            AddToClickButton.Click();
        }
        public string Verify_ProductAddedToCartMessage()
        {
            return ProductAddedToCartMessage.Text;
        }
        public void Click_ProccedToCheckoutButton()
        {
            ProccedToCheckoutButton.Click();
        }
        public bool GetTextSHOPPINGCARTSUMMARYMessage()
        {
            return SHOPPINGCARTSUMMARYMessage.Displayed;
        }
        public string ValidateLoginLoginMyStore()
        {
            return driver.Title;
        }
        public void Click_SummaryPageProccedToCheckoutButton()
        {
            SummaryPageProccedToCheckoutButton.Click();
        }
    }
}
