using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaApplication.Pages
{
    class SelectedProductPage
    {
        private By addToCartLocator = By.XPath("//span[text()='Add to shopping cart']");
        private By continueBagLocator = By.LinkText("Continue to bag");

        private IWebDriver driver;

        public SelectedProductPage(IWebDriver driver)
        {
            this.driver = driver;

        }


        public void ClickOnAddToCart()
        {
            driver.FindElement(addToCartLocator).Click();
        }

        public void ClickOnContinueBag()
        {
            driver.FindElement(continueBagLocator).Click();
        }
    }
}
