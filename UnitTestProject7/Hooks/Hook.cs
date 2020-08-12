
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Auto.Hooks
{
    [Binding]
    public class Hook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static IWebDriver driver;
        [BeforeFeature]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver(FilePath.FilePath.drivers);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           driver.Manage().Timeouts().PageLoad= TimeSpan.FromSeconds(10);
            driver.Manage().Cookies.DeleteCookieNamed("automationpractice.com");
        }

     /*   [AfterFeature]
        public static void AfterScenario()
        {
            driver.Close();   
        }*/
    }
}
