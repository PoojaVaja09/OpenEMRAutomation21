using NUnit.Framework;
using OpenEMRApplication.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication.Base
{
    class WebdriverWrapper
    {

        protected IWebDriver driver;

        [SetUp]
        public void Initialization()
        {
            string browser = JsonUtils.GetValue(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\OpenEMRApplication\TestData\data.json", "browser");

            switch (browser.ToLower())
            {
                case "ff":
             
                    driver = new FirefoxDriver();
                    break;
                case "ie":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }
            
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = JsonUtils.GetValue(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\OpenEMRApplication\TestData\data.json", "url");
        }

        [TearDown]
        public void EndBrowser()
        {
            driver.Quit();
        }
    }
}
