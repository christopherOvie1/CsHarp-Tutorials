using Auto.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Auto.PageObjects
{
    [Binding]
    class PaymentPage : Hook
    {
    IWebElement orderConfirmationText => driver.FindElement(By.CssSelector("#center_column > p.alert.alert-success"));
 IWebElement transactionIncludeMessage => driver.FindElement(By.CssSelector("#center_column > div"));
  IWebElement confirmMyOderArrow => driver.FindElement(By.CssSelector("#cart_navigation > button > span"));
  IWebElement pleaseChoosePaymentMethodChoiceText => driver.FindElement(By.CssSelector("#center_column > h1"));
    IWebElement totalPriceText => driver.FindElement(By.CssSelector("#total_price"));
IWebElement paymentByCheckArrow=> driver.FindElement(By.CssSelector("#HOOK_PAYMENT > div:nth-child(2) > div > p > a"));
        public string Check_pleaseChoosePaymentMethodChoiceText()
        {
          return  pleaseChoosePaymentMethodChoiceText.Text;
        }

        public string Confirm_TotalPriceText()
        {
            return totalPriceText.Text;
        }
        public void Click_paymentByCheckArrow()
        {
            paymentByCheckArrow.Click();
        }
        public void Click_confirmMyOderArrow()
        {
            confirmMyOderArrow.Click();
        }

        public string Check_orderConfirmationText()
        {
          return  orderConfirmationText.Text;
        }
        public string CheckTransactionIncludeMessageIsAccurateText()
        {
            return transactionIncludeMessage.Text;
        }
    }

   
}
