using AutomationWrapper.Base;
using IkeaApplication.Pages;
using IkeaApplication.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Threading;

namespace IkeaApplication
{
    public class IkeaTest: WebdriverWrapper
    {
        

        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "InvalidMobileNumberTestData")]
        public void InvalidMobileNumberTest(string mobilenumber,string expectederrormessage)
        {
            
            DashBoardPage dashBoardPage = new DashBoardPage(driver);
            dashBoardPage.ClickOnProfile();
            
            AccountPage accountPage = new AccountPage(driver);
            accountPage.ClickOnSignIn();
            
            SignInPage signInPage = new SignInPage(driver);
            signInPage.SendMobileNumber(mobilenumber);
            signInPage.ClickOnContinue();

            string errorMeg = signInPage.GetErrorMsg();
            Assert.AreEqual(expectederrormessage, errorMeg);

        }

        


        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "AddToCartTestData")]
        public void AddToCartTest(string quantity,string pincode,string expectederroemsg)
        {
            DashBoardPage dashBoardPage = new DashBoardPage(driver);
            dashBoardPage.ClickOnProducts();

            ProductsPage productsPage = new ProductsPage(driver);
            productsPage.ClickOnNewLowerPrice();
            
            LowerPricePage lowerPricePage = new LowerPricePage(driver);
            lowerPricePage.SwitchToLowPriceWinClifirstProduct();

            SelectedProductPage selectedProductPage = new SelectedProductPage(driver);
            selectedProductPage.ClickOnAddToCart();
            selectedProductPage.ClickOnContinueBag();

            ShoppingCartPage shoppingCartPage = new ShoppingCartPage(driver);
            shoppingCartPage.SelectQuntityByText(quantity);
            shoppingCartPage.ClickOnHomeDelivery();
            shoppingCartPage.SendPinCode(pincode);
            shoppingCartPage.ClickOnProceed();

            string actualErrorMsg = shoppingCartPage.GetErrorMsg();
            Assert.AreEqual(expectederroemsg, actualErrorMsg);

        }
    }
}