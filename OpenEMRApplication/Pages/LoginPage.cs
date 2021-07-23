using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication.Pages
{
    class LoginPage
    {
        private By usernameLocator=By.CssSelector("#authUser");
        private By passwordLocator = By.Id("clearPass");
        private By submitLocator = By.XPath("//button[@type='submit']");
        private By languageLocator = By.Name("languageChoice");
        private By errorLocator = By.XPath("//div[contains(text(),'Invalid username or password')]");


        private IWebDriver driver;

            public LoginPage(IWebDriver driver)
            {
                 this.driver = driver;

            }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordLocator).SendKeys(password);
        }

        public void selectLanguageByText(string language)
        {
            SelectElement select = new SelectElement(driver.FindElement(languageLocator));
            select.SelectByText(language);
        }

        public void clickOnSubmit()
        {
            driver.FindElement(submitLocator).Click();
        }

        public string getErrorMessage()
        {
            return driver.FindElement(errorLocator).Text.Trim();
        }
    }
}
