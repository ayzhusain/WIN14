using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace WIN14_Project.StepDefenitions
{
    [Binding]
    public class ProductDetailsSteps
    {
        IWebDriver driver = null;

        [Given(@"You have choosen your product")]
        public void GivenYouHaveChoosenYourProduct()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:2110/html/ProductDetail.html");
        }

        [When(@"You have clicked on the product")]
        public void WhenYouHaveClickedOnTheProduct()
        {
            driver.FindElement(By.Id("productId")).SendKeys("1");
        }

        [Then(@"Show product information")]
        public void ThenShowProductInformation()
        {
            driver.FindElement(By.Name("productName")).SendKeys("Fill Murry");
            driver.FindElement(By.Name("productDescription")).SendKeys("Din Produkt");
        }
    }
}