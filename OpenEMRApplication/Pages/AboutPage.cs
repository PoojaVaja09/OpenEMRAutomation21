using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication.Pages
{
    class AboutPage
    {
        private By versionLocator = By.XPath("//h4[contains(text(),'Version Number: v6.0.0 (1)')]");




        private IWebDriver driver;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void SwitchToMSCFrame(string mscFrame)
        {
            driver.SwitchTo().Frame(mscFrame);
        }

        public string GetActualVersion()
        {
            return driver.FindElement(versionLocator).Text;
        }


    }
}
