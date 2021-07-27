using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication.Utilities
{
    class TestCaseSourceUtils
    {
            //admin,pass,English (Indian),OpenEMR
            //physician,physician,English (Indian),OpenEMR
            //receptionist,receptionist,English (Indian),OpenEMR

            public static object[] ValidCredentialData()
            {

                object[] temp1 = new object[4];
                temp1[0] = "admin";
                temp1[1] = "pass";
                temp1[2] = "English (Indian)";
                temp1[3] = "OpenEMR";

                object[] temp2 = new object[4];
                temp2[0] = "physician";
                temp2[1] = "physician";
                temp2[2] = "English (Indian)";
                temp2[3] = "OpenEMR";

                object[] temp3 = new object[4];
                temp3[0] = "receptionist";
                temp3[1] = "receptionist";
                temp3[2] = "English (Indian)";
                temp3[3] = "OpenEMR";

                object[] main = new object[3];
                main[0] = temp1;
                main[1] = temp2;
                main[2] = temp3;

                return main;
            }
        
        public static object[] InvalidCredentialData()
        {
            object[] main = ExcelUtils.GetSheetIntoTwoDimObjectArray(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\OpenEMRApplication\TestData\OpenEMRData.xlsx", "ValidCredentialTest");
            return main;
        }

        public static object[] AddPatientTestData()
        {
            object[] main = ExcelUtils.GetSheetIntoTwoDimObjectArray(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\OpenEMRApplication\TestData\OpenEMRData.xlsx", "AddPatientTest");
            return main;
        }

        public static object[] VersionNumberTestData()
        {
            object[] main = ExcelUtils.GetSheetIntoTwoDimObjectArray(@"D:\Sollers\Azure Full Stack June 2021\SDET Track\SeleniumWebdriverConcept\OpenEMRApplication\OpenEMRApplication\TestData\OpenEMRData.xlsx", "VersionNumberTest");
            return main;
        }
    }
}
