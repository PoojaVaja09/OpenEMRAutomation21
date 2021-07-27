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
        private By patientClientLocator = By.XPath("//div[text()='Patient/Client']");
        private By patientLocator = By.XPath("//div[text()='Patients']");
        private By aboutLocator = By.XPath("//div[contains(text(),'About')]");


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

        public void clickOnPatientClient()
        {
            driver.FindElement(patientClientLocator).Click();
        }

        public void clickOnPatient()
        {
            driver.FindElement(patientLocator).Click();
        }

        public void ClickOnAbout()
        {
            driver.FindElement(aboutLocator).Click();
        }

    }
}
