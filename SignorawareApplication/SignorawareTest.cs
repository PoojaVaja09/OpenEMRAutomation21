using AutomationWrapper.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SignorawareApplication.Pages;
using SignorawareApplication.Utilities;
using System.Threading;

namespace SignorawareApplication
{
    public class SignorawareTest: WebdriverWrapper
    {
        
        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "AddToCartTestData")]
        public void AddToCartTest(string sortBy)
        {
            
            DashBoardPage dashBoardPage = new DashBoardPage(driver);
            dashBoardPage.ClickOnFlask();

            FlaskPage flaskPage = new FlaskPage(driver);
            flaskPage.sortByValue(sortBy);
            Thread.Sleep(5000);
            flaskPage.clickOnFirstFlask();

            ProductPage productPage = new ProductPage(driver);
            productPage.ClickOnAddToCart();


            IWebElement addedItem = productPage.GetAddedItem();
            Assert.IsTrue(addedItem.Displayed);
        }

        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "SignInTestData")]
        public void SignInTest(string email,string expectederrormsg)
        {
            DashBoardPage dashBoardPage = new DashBoardPage(driver);
            dashBoardPage.ClickOnSignIn();

            SignInPage signInPage = new SignInPage(driver);
            signInPage.SendEmail(email);
            signInPage.ClickOnSignIn();

            string actualErrorMsg = signInPage.GetErrorMsg();

            Assert.IsTrue(actualErrorMsg.Contains(expectederrormsg));
            

        }
    }
}