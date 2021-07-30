using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaApplication.Pages
{
    class DashBoardPage
    {
        private By profileLocator = By.XPath("//a[@title='My Profile']//span[@class='hnf-btn__inner']");
        private By productsLocator = By.LinkText("Products");
        private By okLocator = By.XPath("//button[text()='Ok']");


        private IWebDriver driver;

        public DashBoardPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ClickOnProfile()
        {
            driver.FindElement(profileLocator).Click();
        }

        public void ClickOnProducts()
        {
            driver.FindElement(okLocator).Click();
            driver.FindElement(productsLocator).Click();
        }
    }
}
