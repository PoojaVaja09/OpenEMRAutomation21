using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication.Pages
{
    class PatientFinderPage
    {
        private By addPatientButtonLocator = By.Id("create_patient_btn1");


        private IWebDriver driver;

            public PatientFinderPage(IWebDriver driver)
            {
                this.driver = driver;

            }


        public void switchToFinFrame(string finFrame)
        {
            driver.SwitchTo().Frame(finFrame);
        }

        public void clickOnAddPatientButton()
        {
            driver.FindElement(addPatientButtonLocator).Click();
        }

        public void switchToDefaultFrame()
        {
            driver.SwitchTo().DefaultContent();
        }


    }
}
