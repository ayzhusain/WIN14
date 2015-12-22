using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace WIN14_Project.Features
{
    [Binding]
    public class TrackOrderSteps
    {
        IWebDriver driver = null;

        [Given(@"You have ordernumber/id")]
        public void GivenYouHaveOrdernumberId()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:2110/html/TrackOrder.html");
        }
        
        [When(@"You enter ordernumber/id")]
        public void WhenYouEnterOrdernumberId()
        {
            driver.FindElement(By.Id("orderid")).SendKeys("1337");
            driver.FindElement(By.Id("btnConfirm")).Click();
        }
        
        [Then(@"You get location of order/package")]
        public void ThenYouGetLocationOfOrderPackage()
        {
            Assert.True(driver.Title == "Track Order", "Track Order");
        }
    }
}
