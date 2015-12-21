using System;
using TechTalk.SpecFlow;

namespace WIN14_Project.Features
{
    [Binding]
    public class LoggedInSteps
    {
        [Given(@"That you are logged in")]
        public void GivenThatYouAreLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"You are at the startpage")]
        public void WhenYouAreAtTheStartpage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"See your status")]
        public void ThenSeeYourStatus(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
