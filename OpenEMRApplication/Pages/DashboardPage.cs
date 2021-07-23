using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication.Pages
{
    class DashboardPage
    {
        private By calenderLocator = By.XPath("//span[text()='Calendar']");


        private IWebDriver driver;
        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void waitForPresenceOfCalender()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait.Message = "Calendar text is not there";
            wait.Until(x => x.FindElement(calenderLocator));
        }

        public string getTitle()
        {
            return driver.Title.Trim();
        }
    }
}
