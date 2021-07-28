using AutomationWrapper.Base;
using NUnit.Framework;
using OpenEMRApplication.Pages;
using OpenEMRApplication.Utilities;
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

        [Test, TestCaseSource(typeof(TestCaseSourceUtils), "AddPatientTestData")]
        public void AddPatientTest(string username, string password, string language, string firstname, string lastname, string DOB, string gender,string expectedPatientName)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.selectLanguageByText(language);
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
            searchOrAddPatient.sendPatientFName(firstname);
            searchOrAddPatient.sendPatientLName(lastname);
            searchOrAddPatient.sendPatientDOB(DOB);
            searchOrAddPatient.selectGender(gender);
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
             Assert.AreEqual(expectedPatientName, actualValueOfAddedPatient);

        }
    }
}

