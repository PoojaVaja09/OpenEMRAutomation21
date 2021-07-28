using AutomationWrapper.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoApplication.Utilities
{
    class TestCaseSourceUtils
    {

        public static object[] ValidCredentialTestData()
        {
            object[] main = ExcelUtils.GetSheetIntoTwoDimObjectArray(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\MagentoApplication\MagentoData.xlsx", "ValidCredentialTest");
            return main;
        }

        public static object[] InvalidCredentialTestData()
        {
            object[] main = ExcelUtils.GetSheetIntoTwoDimObjectArray(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\MagentoApplication\MagentoData.xlsx", "InvalidCredentialTest");
            return main;
        }
    }
}
