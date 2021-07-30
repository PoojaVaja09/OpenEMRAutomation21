using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignorawareApplication.Pages
{
    class FlaskPage
    {
        private By sortByLocator = By.Id("sorter");
        private By firstFlaskLocator = By.XPath("(//div[@class='column main']//div[@class='product-item-image'])[1]");



        private IWebDriver driver;

        public FlaskPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void sortByValue(string value)
        {
            SelectElement selectSortBy = new SelectElement(driver.FindElement(sortByLocator));
            selectSortBy.SelectByValue(value);
        }

        public void clickOnFirstFlask()
        {
            driver.FindElement(firstFlaskLocator).Click();
        }
    }
}
