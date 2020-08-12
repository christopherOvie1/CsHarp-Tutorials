using Auto.Hooks;
using Auto.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Auto.StepDefinitions
{
    [Binding]
    public class CommonStepDefinitions :Hook
    {

        CommonStepDefinitions commonStepDefinitions = new CommonStepDefinitions();
      //  [Then(@"I am on '(.*)' Page")]
        //public void ThenIAmOnPage(string title)
        //{
        //    MyWebDriverWait.WaitForPageTitle(title);

        //}

    }
}
