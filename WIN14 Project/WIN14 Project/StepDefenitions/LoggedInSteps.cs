using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace WIN14_Project.Features
{
    [Binding]
    public class LoggedInSteps
    {
        IWebDriver driver = null;

        [Given(@"That you are logged in")]
        public void GivenThatYouAreLoggedIn()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:2110/Html/startPage.html");
        }
        
        [When(@"You are at the startpage")]
        public void WhenYouAreAtTheStartpage()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:2110/Html/startPage.html");
        }
        
        [Then(@"See your status")]
        public void ThenSeeYourStatus()

        {
            driver.FindElement(By.Name("status")).SendKeys("sohail");
        }
    }
}
