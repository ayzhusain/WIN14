using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace WIN14_Project.StepDefenitions
{
    [Binding]
    public class FeedbackSteps
    {
        IWebDriver driver = null;
        [Given(@"You have recieved the product")]
        public void GivenYouHaveRecievedTheProduct()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("");

        }
        
        [When(@"You fill in the product satisfiction form")]
        public void WhenYouFillInTheProductSatisfictionForm()
        {

        }
        
        [Then(@"Press send / Show result")]
        public void ThenPressSendShowResult()
        {

        }
    }
}
