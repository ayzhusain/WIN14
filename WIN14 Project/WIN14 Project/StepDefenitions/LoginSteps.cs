using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace WIN14_Project.Features
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver driver = null;

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:2110/ayaz_folder/index.html");
        }

        [When(@"I input my user name and password")]
        public void WhenIInputMyUserNameAndPassword()
        {
            driver.FindElement(By.Name("login")).SendKeys("sohail");
            driver.FindElement(By.Name("password")).SendKeys("password");
            driver.FindElement(By.Id("login-button")).Click();
        }

        [Then(@"I should get confirmation")]
        public void ThenIShouldGetConfirmation()
        {
            Assert.True(driver.Title == "Login", "Logged In");
        }
    }

}
