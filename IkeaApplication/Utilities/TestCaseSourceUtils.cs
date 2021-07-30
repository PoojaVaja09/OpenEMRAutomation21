using AutomationWrapper.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaApplication.Utilities
{
    class TestCaseSourceUtils
    {

        public static object[] InvalidMobileNumberTestData()
        {
            object[] main = ExcelUtils.GetSheetIntoTwoDimObjectArray(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\IkeaApplication\TestData\IkeaApplicationData.xlsx", "InvalidMobileNumberTest");
            return main;
        }

        public static object[] AddToCartTestData()
        {
            object[] main = ExcelUtils.GetSheetIntoTwoDimObjectArray(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\IkeaApplication\TestData\IkeaApplicationData.xlsx", "AddToCartTest");
            return main;
        }


    }
}
