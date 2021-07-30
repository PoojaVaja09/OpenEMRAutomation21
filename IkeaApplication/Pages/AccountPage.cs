using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaApplication.Pages
{
    class AccountPage
    {

        private By signInLocator = By.XPath("//a[text()='Sign in']");

        private IWebDriver driver;

        public AccountPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ClickOnSignIn()
        {
            driver.FindElement(signInLocator).Click();
        }
    }
}
