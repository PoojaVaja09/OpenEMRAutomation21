using AutomationWrapper.Base;
using MagentoApplication.Pages;
using MagentoApplication.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MagentoApplication
{
    public class LoginTest: WebdriverWrapper
    {
        

        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "ValidCredentialTestData")]
        public void ValidCredentialTest(string username,string password,string expectedText)
        {
            SignInPage signInPage = new SignInPage(driver);
            signInPage.ClickOnSignIn();
            signInPage.SendUsername(username);
            signInPage.SendPassword(password);
            signInPage.ClickOnContinue();

            DashboardPage dashboardPage = new DashboardPage(driver);

            string logoutText = dashboardPage.GetLogOutText();
            Assert.AreEqual(expectedText, logoutText);

        }

        [Test, TestCaseSource(typeof(TestCaseSourceUtils), "InvalidCredentialTestData")]
        public void InvalidCredentialTest(string username,string password,string expectedMsg)
        {
            SignInPage signInPage = new SignInPage(driver);
            signInPage.ClickOnSignIn();
            signInPage.SendUsername(username);
            signInPage.SendPassword(password);
            signInPage.ClickOnContinue();

            string actualErrorMsg = signInPage.GetErrorMsg();
            Assert.AreEqual(expectedMsg, actualErrorMsg);

        }
    }
}