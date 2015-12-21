using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace WIN14_Project.Features
{
    [Binding]
    public class ConfirmOrderSteps
    {
        IWebDriver driver = null;

        [Given(@"I stand on checkout page")]
        public void GivenIStandOnCheckoutPage()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:2110/Html/ConfirmOrder.html");
        }
        
        [When(@"I press Confirm order")]
        public void WhenIPressConfirmOrder()
        {
            driver.FindElement(By.Id("btnConfirm")).Click();
        }
        
        [Then(@"Show Thank You message")]
        public void ThenShowThankYouMessage()
        {
            Assert.True(driver.Title == "Confirm Order", "Order Confirmed");
        }
    }
}
