using AutomationWrapper.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignorawareApplication.Utilities
{
    class TestCaseSourceUtils
    {
        public static object[] AddToCartTestData()
        {
            object[] main = ExcelUtils.GetSheetIntoTwoDimObjectArray(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\SignorawareApplication\TestData\SignorawareData.xlsx", "AddToCartTest");
            return main;
        }

        public static object[] SignInTestData()
        {
            object[] main = ExcelUtils.GetSheetIntoTwoDimObjectArray(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\SignorawareApplication\TestData\SignorawareData.xlsx", "SignInTest");
            return main;
        }

    }
}
