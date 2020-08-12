using Auto.Hooks;
using Auto.PageObjects;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Auto.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auto.StepDefinitions
{
    [Binding]
    public class LoginSteps: Hook
    {
        //RegisterPages registerPages = new RegisterPages();
        LoginPages loginPages = new LoginPages();
        [When(@"I click sign in")]
        public void WhenIClickSignIn()
        {
            loginPages.IClickSignIink();
        }
        [When(@"I log in with correct (.*) and (.*)")]
        public void WhenILogInWithCorrectAnd(string EmailAddress,string Password)
        {
            loginPages.LoginAfterEnteringCorrectEmailAddressAndPassword(EmailAddress, Password);

            loginPages.IClickSignIink();
            }
        [When(@"I login with email ""(.*)"" and password ""(.*)""")]
      
        public void ThenIVerifyThatIAmLogInSuccessfully()
        {

        }

        [Then(@"I checked  (.*) is logged in successfully")]
        public void ThenICheckedIsLoggedInSuccessfully(string p0)
        {
            loginPages.CheckAccountNameIsCorrect();
            Assert.AreEqual("Davin Riches", loginPages.CheckAccountNameIsCorrect());    
        }

        [Then(@"I am on '(.*)' Page")]
        public void ThenIAmOnPage(string title)
        {
            MyWebDriverWait.WaitForPageTitle(title);
        }
        [When(@"I try to log in with incorrect  (.*) or incorrect (.*)")]
        public void WhenITryToLogInWithIncorrectOrIncorrect(string Email, string Passswd)
        {
            loginPages.AttemptLoginWithIncorrectEmailAndPassword(Email, Passswd);
        }
        [Then(@"I should see error (.*)")]
        public void ThenIShouldSeeError(string Message)
        {
         string d= loginPages.Validate_ErrorMesssage();
            Console.WriteLine("The error found is "+d);
            Assert.AreEqual("Authentication failed.",loginPages.Validate_ErrorMesssage());
        }
        [When(@"I click forget password link")]
        public void WhenIClickForgetPasswordLink()
        {
            loginPages.Click_forgotPasswordLink();
        }

        [When(@"user clicks on retreive password button")]
        public void WhenUserClicksOnRetreivePasswordButton()
        {
            loginPages.Click_retrieveforgetPassword();
        }

        //[Given(@"I enter email that is not registered")]
        //public void GivenIEnterEmailThatIsNotRegistered()
        //{
        //    // registerPages.TypeEmail();
        //    loginPages.Click_EmailTAdd();
        //}

        //[When(@"I enter email that is not registered")]
        //public void WhenIEnterEmailThatIsNotRegistered()
        //{
        //    //((JavascriptExecutor)driver).ExecuteScript("scroll(0,200);");
        //    // loginPages.Click_EmailTAdd();
        //// registerPages.Click_EmailTAdd();
        //}


    }

}
