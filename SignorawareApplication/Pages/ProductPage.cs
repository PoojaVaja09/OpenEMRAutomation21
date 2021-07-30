using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignorawareApplication.Pages
{
    class ProductPage
    {
        private By addToCartLocator = By.XPath("//span[text()='Add to Cart']");
        private By addedItemLocator = By.XPath("//div[@data-bind='html: $parent.prepareMessageForHtml(message.text)']");

        private IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ClickOnAddToCart()
        {
            driver.FindElement(addToCartLocator).Click();

        }

        public IWebElement GetAddedItem()
        {
            return driver.FindElement(addedItemLocator);
        }
    }
}
