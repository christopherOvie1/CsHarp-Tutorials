using Auto.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace Auto.PageObjects
{

    [Binding]
    class HomePage : Hook
    {
        private static By SearchTextBoxButton = By.Name("search_query");
        private static By SearchIconButton = By.CssSelector("#searchbox > button");
        
       

        public void ClickSearchTextField()
        {
            
            driver.FindElement(SearchTextBoxButton);
        }
        public void LoginSearchPage(string Clothing)
        {
            
            driver.FindElement(SearchIconButton).SendKeys(Clothing);          
        }
       public void ClickSearchIconButton()
        {
           // SearchIconButton.Click();
            driver.FindElement(SearchIconButton).Click();
        }
    }
}
