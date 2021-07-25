using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication.Pages
{
    class PatientDashboardPage
    {
        private By addedPatientTextLocator = By.XPath("//h2[contains(text(),'Medical')]");


        private IWebDriver driver;

        public PatientDashboardPage(IWebDriver driver)
        {
            this.driver = driver;

        }


        public void switchToPatFrame(string patFrame)
        {
            driver.SwitchTo().Frame(patFrame);
        }

        public string getAddedPatientText()
        {
            return driver.FindElement(addedPatientTextLocator).Text;
        }


    }
}
