using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignorawareApplication.Pages
{
    class SignInPage
    {
        private By emailLocator = By.XPath("//input[@id='email']");
        private By signInLocator = By.XPath("//fieldset[@class='fieldset login']//button[@id='send2']");
        private By errorMsgLocator = By.Id("email-error");

        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void SendEmail(string email)
        {
            driver.FindElement(emailLocator).SendKeys(email);
        }

        public void ClickOnSignIn()
        {
            driver.FindElement(signInLocator).Click();
        }

        public string GetErrorMsg()
        {
            return driver.FindElement(errorMsgLocator).Text;
        }
    }
}
