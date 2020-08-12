using Auto.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Utilities
{
  public  class WebDriverFunctions:Hook
    {
public static void  WebDriverSelect(By locator, string text)
        {
            SelectElement element = new SelectElement(driver.FindElement(locator));
            element.SelectByText(text);
        }
    }
}
