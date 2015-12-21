using System;
using TechTalk.SpecFlow;

namespace WIN14_Project.Features
{
    [Binding]
    public class TrackOrderSteps
    {
        [Given(@"You have ordernumber/id")]
        public void GivenYouHaveOrdernumberId()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"You enter ordernumber/id")]
        public void WhenYouEnterOrdernumberId()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"You get location of order/package")]
        public void ThenYouGetLocationOfOrderPackage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
