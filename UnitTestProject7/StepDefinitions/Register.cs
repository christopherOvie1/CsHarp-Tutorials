using Auto.Hooks;
using Auto.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Auto.StepDefinitions
{
    [Binding]
    class Register : Hook

    {
        RegisterPages registerPages;
       
        public Register()
        {
            registerPages = new RegisterPages();
        }

        //[Given(@"I log into my account page using email that is not in use")]
        //public void GivenILogIntoMyAccountPageUsingEmailThatIsNotInUse()
        //{
        //    registerPages.TypeEmail();
        //}
        [When(@"I enter email that is not registered")]
        public void WhenIEnterEmailThatIsNotRegistered()
        {
            registerPages.Click_EmailTAdd();
        }

        [When(@"I click on create account button")]
        public void WhenIClickOnCreateAccountButton()
        {
           // registerPages.Click_EmailTAdd();
        }

    }
}
