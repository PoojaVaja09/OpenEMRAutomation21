using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoApplication.Pages
{
    class DashboardPage
    {
        private By logOutLocator = By.XPath("//a[text()='Log Out']");



        private IWebDriver driver;

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public string GetLogOutText()
        {
            return driver.FindElement(logOutLocator).Text;
        }
    }
}
