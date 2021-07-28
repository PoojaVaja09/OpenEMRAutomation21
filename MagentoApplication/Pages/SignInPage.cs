using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoApplication.Pages
{
    class SignInPage
    {
        private By signInLocator = By.XPath("//span[text()='Sign in']");
        private By usernameLocator = By.Id("email");
        private By passwordLocator = By.Id("pass");
        private By continueButtonLocator = By.XPath("//div[@class='login-form__bottom']//button[@id='send2']");
        private By errorMsgLocator = By.XPath("//div[text()='Invalid login or password.']");


        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ClickOnSignIn()
        {
            driver.FindElement(signInLocator).Click();
        }

        public void SendUsername(string username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
        }

        public void SendPassword(string password)
        {
            driver.FindElement(passwordLocator).SendKeys(password);
        }

        public void ClickOnContinue()
        {
            driver.FindElement(continueButtonLocator).Click();
        }
        public string GetErrorMsg()
        {
            return driver.FindElement(errorMsgLocator).Text;
        }

    }
}
