using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IkeaApplication.Pages
{
    class ProductsPage
    {
        private By newLowerPriceLocator = By.LinkText("New lower price");

        private IWebDriver driver;

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ClickOnNewLowerPrice()
        {
            driver.FindElement(newLowerPriceLocator).Click();
            Thread.Sleep(5000);
        }
    }
}
