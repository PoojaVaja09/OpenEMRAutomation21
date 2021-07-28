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
    class LoginTest:WebdriverWrapper
    {

        [Test]
        public void AcknowledgmentsLicensingCertificationLinkTest()
        {
            LoginPage login = new LoginPage(driver);
            login.ClickOnAcknowledgmentsLicensingCertification();

            login.switchToAcknowledgmentsLicensingCertificationTab();
            AckLicCertPage ack = new AckLicCertPage(driver);
            Assert.IsTrue(ack.GetPageSource().Contains("License information"), "Assertion using page contains License information");

        }

        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "InvalidCredentialTest")]
        // [TestCase("john","john123","Dutch","Invalid username or password")]
        // [TestCase("Peter", "Perter123", "Danish", "Invalid username or password")]
        public void InvalidCredentialTest(string username,string password,string language,string expectedValue)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.selectLanguageByText(language);
            login.clickOnSubmit();

            string actualValue = login.getErrorMessage();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test, Description("Valid Credential Test"), TestCaseSource(typeof(TestCaseSourceUtils),"ValidCredentialData")]
        public void ValidCredentialTest(string username,string password,string language,string expectedValue)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.selectLanguageByText(language);
            login.clickOnSubmit();

            DashboardPage dashboard = new DashboardPage(driver);
            dashboard.waitForPresenceOfCalender();


            string actualValue = dashboard.getTitle();
            Assert.AreEqual(expectedValue, actualValue);


        }

        

    }
}
