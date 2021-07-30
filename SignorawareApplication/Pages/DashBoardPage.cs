using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignorawareApplication.Pages
{
    class DashBoardPage
    {
        private By productRangeLocator = By.XPath("(//span[text()='Product Range'])[1]");
        private By flaskLocator = By.XPath("(//span[text()='Flasks '])[1]");
        private By signInLocator = By.XPath("//a[text()='Sign In']");


        private IWebDriver driver;

        public DashBoardPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ClickOnFlask()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(productRangeLocator)).Build().Perform();
            driver.FindElement(flaskLocator).Click();
        }

        public void ClickOnSignIn()
        {
            driver.FindElement(signInLocator).Click();
        }


    }
}
