using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace WIN14_Project
{
    [Binding]
    public class SearchSteps
    {


        IWebDriver driver = null;

        [Given(@"You are at product page")]
        public void GivenYouAreAtProductPage()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:2110/html/startPage.html");
        }

        [When(@"You search for product")]
        public void WhenYouSearchForProduct()
        {
            driver.FindElement(By.Id("search")).SendKeys("Tandpetare");
            driver.FindElement(By.Id("searchButton")).Click();
        }

        [Then(@"See product")]
        public void ThenSeeProduct()
        {
            driver.FindElement(By.Id("clickThis")).Click();
        }
    }
}
