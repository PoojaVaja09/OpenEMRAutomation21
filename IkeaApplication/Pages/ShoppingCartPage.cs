using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaApplication.Pages
{
    class ShoppingCartPage
    {
        private By quntityLocator = By.Id("js_qty_10193140");
        private By homeDeliveryLocator = By.XPath("//span[text()='Home delivery']");
        private By pinCodeLocator = By.Id("clickdeliver_postcode");
        private By proceedLocator = By.XPath("//span[text()='Proceed']");
        private By errorMsgLocator = By.XPath("//p[@class='error-helper']");


        private IWebDriver driver;

        public ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void SelectQuntityByText(string quantity)
        {
            SelectElement selectQuntity = new SelectElement(driver.FindElement(By.Id("js_qty_10193140")));
            selectQuntity.SelectByText(quantity);
        }

        public void ClickOnHomeDelivery()
        {
            driver.FindElement(homeDeliveryLocator).Click();
        }

        public void SendPinCode(string pincode)
        {
            driver.FindElement(pinCodeLocator).SendKeys(pincode);
        }

        public void ClickOnProceed()
        {
            driver.FindElement(proceedLocator).Click();
        }

        public string GetErrorMsg()
        {
            return driver.FindElement(errorMsgLocator).Text;
        }
    }
}
