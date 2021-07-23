using NUnit.Framework;
using OpenEMRApplication.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace OpenEMRApplication
{
    class LoginTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Initialization()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";
        }

        [TearDown]
        public void EndBrowser()
        {
            driver.Quit();
        }


        [Test]
        public void InvalidCredentialTest()
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername("admin123");
            login.EnterPassword("pass");
            login.selectLanguageByText("English (Standard)");
            login.clickOnSubmit();

            string actualValue = login.getErrorMessage();
            Assert.AreEqual("Invalid username or password", actualValue);
        }

        [Test]
        public void ValidCredentialTest()
        {

            LoginPage login = new LoginPage(driver);
            login.EnterUsername("admin");
            login.EnterPassword("pass");
            login.selectLanguageByText("English (Standard)");
            login.clickOnSubmit();

            DashboardPage dashboard = new DashboardPage(driver);
            dashboard.waitForPresenceOfCalender();


            string actualValue = dashboard.getTitle();
            Assert.AreEqual("OpenEMR", actualValue);


        }
    }
}
