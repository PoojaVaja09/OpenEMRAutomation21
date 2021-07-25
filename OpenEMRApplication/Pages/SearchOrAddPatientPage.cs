using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication.Pages
{
    class SearchOrAddPatientPage
    {
        private By patientFNameLocator = By.Id("form_fname");
        private By patientLNameLocator = By.Id("form_lname");
        private By patientDOBLocator = By.Id("form_DOB");
        private By genderLocator = By.Id("form_sex");
        private By createNewPatientButton = By.Id("create");
        private By confirmCreateNewPatientButton = By.XPath("//input[@value='Confirm Create New Patient']");
        private By happyBDayPopUpLocator = By.XPath("//div[@class='closeDlgIframe']");



        private IWebDriver driver;

        public SearchOrAddPatientPage(IWebDriver driver)
        {
            this.driver = driver;

        }


        public void switchToPatFrame(string patFrame)
        {
            driver.SwitchTo().Frame(patFrame);

        }

        public void sendPatientFName(string patientFName)
        {
            driver.FindElement(patientFNameLocator).SendKeys(patientFName);
        }

        public void sendPatientLName(string lName)
        {
            driver.FindElement(patientLNameLocator).SendKeys(lName);
        }

        public void sendPatientDOB(string dob)
        {
            driver.FindElement(patientDOBLocator).SendKeys(dob);
        }

        public void selectGender(string gender)
        {
            SelectElement selectGender = new SelectElement(driver.FindElement(genderLocator));
            selectGender.SelectByText(gender);
        }

        public void clickOnCreateNewPatientButton()
        {
            driver.FindElement(createNewPatientButton).Click();
        }

        public void switchToDefaultFrame()
        {
            driver.SwitchTo().DefaultContent();
        }

        public void switchToModalFrame(string modalFrame)
        {
            driver.SwitchTo().Frame(modalFrame);

        }

        public void clickOnConfirmCreateNewPatientButton()
        {
            driver.FindElement(confirmCreateNewPatientButton).Click();
        }

        public string waitForAlertGetTextAndAccept()
        {
            //fluent wait
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.PollingInterval = TimeSpan.FromSeconds(5);
            wait.IgnoreExceptionTypes(typeof(NoAlertPresentException));//ignore no alert exception

            string actualValueOfAlert = wait.Until(x => x.SwitchTo().Alert()).Text;
            Console.WriteLine(actualValueOfAlert);

            wait.Until(x => x.SwitchTo().Alert()).Accept();
            return actualValueOfAlert;
        }

        public void checkAndCloseHPopUp()
        {
            if (driver.FindElements(happyBDayPopUpLocator).Count > 0) // check element present or not
            {
                driver.FindElement(happyBDayPopUpLocator).Click();
            }
        }

        

    }
}
