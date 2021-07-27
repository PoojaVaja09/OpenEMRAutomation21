using NUnit.Framework;
using OpenEMRApplication.Base;
using OpenEMRApplication.Pages;
using OpenEMRApplication.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication
{
    class AboutTest: WebdriverWrapper
    {
        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "VersionNumberTestData")]
        public void VersionNumberTest(string username,string password,string language,string expectedVersion)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername("admin");
            login.EnterPassword("pass");
            login.selectLanguageByText("English (Standard)");
            login.clickOnSubmit();
            //DashboardPage
            DashboardPage dashboard = new DashboardPage(driver);
            dashboard.ClickOnAbout();

            //AboutPage
            AboutPage about = new AboutPage(driver);
            about.SwitchToMSCFrame("msc");

            string actualVersion = about.GetActualVersion();

            Assert.AreEqual(expectedVersion, actualVersion);
            driver.SwitchTo().DefaultContent();
        }   
    }
}
