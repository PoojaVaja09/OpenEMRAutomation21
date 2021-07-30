using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IkeaApplication.Pages
{
    class LowerPricePage
    {
        private By firstProductLocator = By.XPath("(//div[@class='range-revamp-product-compact__image-wrapper'])[1]");
        private IWebDriver driver;

        public LowerPricePage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void SwitchToLowPriceWinClifirstProduct()
        {
            ReadOnlyCollection<string> windows = driver.WindowHandles;
            int noOfWindoes = windows.Count;

            foreach (string window in windows)
            {
                driver.SwitchTo().Window(window);
                string title = driver.Title;

                if (title.Equals("New lower price. There's more to paying less. - IKEA"))
                {
                    driver.FindElement(firstProductLocator).Click();
                }
            }
        }
    }
}
