using Auto.Hooks;
using OpenQA.Selenium;

using TechTalk.SpecFlow;

namespace Auto.PageObjects
{

    [Binding]
    class ForgotPasswordPage : Hook
    {
        private static By forgetPassword = By.CssSelector("#login_form > div > p.lost_password.form-group > a");
      //  private static By retrieveforgetPassword = By.CssSelector("#form_forgotpassword > fieldset > p > button > span");
        public void Click_forgotPasswordLink()
        {
            driver.FindElement(forgetPassword).Click();
        }

       // public void Click_retrieveforgetPassword()
        //{
        //    driver.FindElement(retrieveforgetPassword).Click();

        //}
    }
}