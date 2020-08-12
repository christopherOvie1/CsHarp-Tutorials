using Auto.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Utilities
{
   public  class MyWebDriverWait : Hook
    {
        
        //  WebDriverWait wait = new WebDriverWait(driver.driver, TimeSpan.FromSeconds(Time));
        // wait.Until(ExpectedConditions.ElementToBeClickable(Password));
        public static void WaitForPageTitle(string title)
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(60));
            wait.Until(x => x.Title.Equals(title));
        }      
            
    }
}
