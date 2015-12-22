using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace WIN14_Project
{
    [Binding]
    public class FeedbackSteps
    {
        IWebDriver driver = null;
        [Given(@"You have received product")]
        public void GivenYouHaveReceivedProduct()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:2110/Html/feedbackpage.html");
        }
        
        [When(@"You fill in product satisfiction form")]
        public void WhenYouFillInProductSatisfictionForm()
        {
            driver.FindElement(By.Name("name")).SendKeys("sohail");
            driver.FindElement(By.Name("orderid")).SendKeys("1337");
            driver.FindElement(By.Name("customerService")).SendKeys("Skit service");
            driver.FindElement(By.Name("customerMessage")).SendKeys("Skit produkt");
            driver.FindElement(By.Name("customerTips")).SendKeys("Lägg ner....");
            driver.FindElement(By.Id("login-button")).Click();
        }
        
        [Then(@"Press send and Show result")]
        public void ThenPressSendAndShowResult()
        {
            Assert.True(driver.Title == "Logged in", "Logged in");
        }
    }
}
