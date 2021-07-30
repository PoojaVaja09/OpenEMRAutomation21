using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaApplication.Pages
{
    class SignInPage
    {
        private By emailMobileLocator = By.Id("username");
        private By continueLocator = By.XPath("//span[contains(text(),'Continue')]");
        private By errorMsgLocator = By.XPath("//span[contains(text(),'Please enter a valid email or verified mobile numb')]");


        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void SendMobileNumber(string mobilenumber)
        {
            driver.FindElement(emailMobileLocator).SendKeys(mobilenumber);
        }

        public void ClickOnContinue()
        {
            driver.FindElement(continueLocator).Click();
        }

        public string GetErrorMsg()
        {
            return driver.FindElement(errorMsgLocator).Text;
        }

    }
}
