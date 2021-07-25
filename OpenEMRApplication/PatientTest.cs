using NUnit.Framework;
using OpenEMRApplication.Base;
using OpenEMRApplication.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication
{
    class PatientTest: WebdriverWrapper
    {
       
        [Test]
        public void AddPatientTest()
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername("admin");
            login.EnterPassword("pass");
            login.selectLanguageByText("English (Indian)");
            login.clickOnSubmit();

            //DashboardPage
            DashboardPage dashboard = new DashboardPage(driver);
            dashboard.clickOnPatientClient();
            dashboard.clickOnPatient();

            //PatientFinderPage
            PatientFinderPage patientFinder = new PatientFinderPage(driver);
            patientFinder.switchToFinFrame("fin");
            patientFinder.clickOnAddPatientButton();
            patientFinder.switchToDefaultFrame();

            //SearchOrAddPatientPage
            SearchOrAddPatientPage searchOrAddPatient = new SearchOrAddPatientPage(driver);
            searchOrAddPatient.switchToPatFrame("pat");
            searchOrAddPatient.sendPatientFName("John");
            searchOrAddPatient.sendPatientLName("Smith");
            searchOrAddPatient.sendPatientDOB("2021-07-19");
            searchOrAddPatient.selectGender("Female");
            searchOrAddPatient.clickOnCreateNewPatientButton();
            searchOrAddPatient.switchToDefaultFrame();

            searchOrAddPatient.switchToModalFrame("modalframe");
            searchOrAddPatient.clickOnConfirmCreateNewPatientButton();
            searchOrAddPatient.switchToDefaultFrame();

            searchOrAddPatient.waitForAlertGetTextAndAccept();
            searchOrAddPatient.checkAndCloseHPopUp();

            //PatientDashboardPage
            PatientDashboardPage patientDashboard = new PatientDashboardPage(driver);
            patientDashboard.switchToPatFrame("pat");

            String actualValueOfAddedPatient = patientDashboard.getAddedPatientText();
             Assert.AreEqual("Medical Record Dashboard - John Smith", actualValueOfAddedPatient);

        }
    }
}

