using Business.GlobalData;
using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsManger
{
    public static class clsApplicationManager
    {
        public static eResult GetApplicationTypes(DataTable dataTable)
        {
            return clsDataApplication.GetApplicationTypes(dataTable);
        }

        public static eResult UpdateApplicationType(int ID, string ApplicationType, int Fees)
        {
            return clsDataApplication.UpdateApplicationType(ID, ApplicationType, Fees);
        }

        public static eResult GetTestTypes(DataTable dataTable)
        {
            return clsDataApplication.GetTestTypes(dataTable);
        }

        public static eResult UpdateTestType(int ID, string TestType, int Fees)
        {
            return clsDataApplication.UpdateTestTypes(ID, TestType, Fees);
        }

        public static eResult GetLicenseTable(DataTable dataTable)
        {
            return clsDataApplication.GetLicenseTypes(dataTable);
        }

        public static eResult GetLicenseByID(int ID, out clsLicenseType license)
        {
            return clsDataApplication.GetLicenseByID(ID, out license);
        }

        public static eResult GetLicenseServiceFee(out int Fee, eLicenseServices service)
        {
            return clsDataApplication.GetLicenseServiceFee(out Fee, service);
        }
        public static eResult InsertLicenseServiceOrder(int PersonID, int UserID, int ServiceID, int LicenseID, int Amount, string ServiceDescripation)
        {
            return clsDataApplication.InsertLicenseServiceOrder(PersonID, UserID, ServiceID, LicenseID, Amount, ServiceDescripation);
        }

        static string[] arrLicenseServices = { "Issue Local", "Renew", "Issue Internationa", "Replace For Lost", "Replace For Damaged",
            "Release Detained", "Retake Test" };

        static string[] arrLicenseTypes = { "Small Motorcycle License", "Heavy Motorcycle License", "Ordinary Driving License",
            "Commercial Driving License", "Agricultural Vehicles License", "Small and Medium Bus License", "Trucks and Heavy Vehicles License" };
        public static string GenerateServiceDescription(eLicenseServices licenseService, eLicenseTypes licenseType)
        {
            return arrLicenseServices[(int)licenseService - 1] + " " + arrLicenseTypes[(int)licenseType - 9];
        }
        public static string GenerateServiceDescription(eLicenseServices licenseService, string licenseType)
        {
            return arrLicenseServices[(int)licenseService - 1] + " " + licenseType;
        }
        public static string GenerateTestDescription(eTestTypes testTypes)
        {
            string[] arrTestTypes = { "Vision Test", "Written Test", "Practical Street Test" };
            return arrTestTypes[(int)testTypes - 1];
        }

        public static eResult GetManageIssueLocalLicenseTable(DataTable dataTable)
        {
            return clsDataApplication.GetManageIssueLocalLicenseTable(dataTable);
        }

        public static eResult CancelIssueLocalLicense(int ID)
        {
            return clsManagerHelper.Operation<int>(ID, clsDataApplication.CancelIssueLocalLicense, clsdtIssueLocalLicenses.Cansel);
        }

        public static eResult GetTestType(int ID, out clsTestType testType)
        {
            return clsDataApplication.GetTestType(ID, out testType);
        }

        public static eResult InsertTakeTest(int PersonID, int OrderID, int TestTypeID, int UserID, int Amount, string Notes, string ServiceDescription)
        {
            eResult result = clsDataApplication.InsertTakeTest(PersonID, OrderID, TestTypeID, UserID, Amount, Notes, ServiceDescription); ;

            if (result == eResult.Success)
                clsdtIssueLocalLicenses.IncresePassedTests(OrderID);

            return result;
        }

        public static eResult IssueNewLocalLicense(int OrderID, int Restrictions)
        {
            eResult result = clsDataLicenses.IssueNewLocalLicense(OrderID, Restrictions, "Issue New Local License", out clsLicense NewLicense);

            if (result == eResult.Success)
            {
                clsdtIssueLocalLicenses.Complate(OrderID);
                clsdtLicenses.AddRow(NewLicense);
            }

            return result;
        }

        public static eResult GetLicensesTable(DataTable dataTable)
        {
            return clsDataLicenses.GetLicensesTable(dataTable);
        }

        public static eResult Getlicense(int ID, out clsLicense license)
        {
            return clsDataLicenses.GetLicense(ID, out license);
        }

        public static eResult GetDrivers(DataTable dataTable)
        {
            return clsDataApplication.GetDrivers(dataTable);
        }

        public static eResult GetPayments(DataTable dataTable)
        {
            return clsDataApplication.GetPayments(dataTable);
        }
        public static eResult GetService(int ID, out clsServiceType serviceType)
        {
            return clsDataApplication.GetService(ID, out serviceType);
        }
        public static eResult IssueInternationalLicense(int LicenseID, int UserID, string  licenseType, out clsLicense license)
        {
            eResult result = clsDataLicenses.IssueInternationalLicense(LicenseID, GenerateServiceDescription(eLicenseServices.IssueInternational, licenseType), UserID, out license);
           
            if (result == eResult.Success)
                clsdtLicenses.AddRow(license);

            return result;
        }

        public static eResult RenewLicense(int LicenseID, int UserID, string licenseType, out clsLicense license)
        {
            eResult result = clsDataLicenses.RenewLicense(LicenseID, GenerateServiceDescription(eLicenseServices.IssueInternational, licenseType), UserID, out license);

            if (result == eResult.Success)
            {
                clsdtLicenses.AddRow(license);
                clsdtLicenses.Expire(LicenseID);
            }

            return result;
        }

        //public static eResult ReplaceLostLicense(clsLicense license)
        //{

        //}

        //public static eResult ReplaceDamgedLicense(clsLicense license)
        //{

        //}

        //public static eResult DetainLicense(clsLicense license)
        //{

        //}

        //public static eResult ReleaseDetainedLicense(clsLicense license)
        //{

        //}

        public static eResult SaveLicense(int LicenseID, int UserID, string licenseType, eLicenseServices service, out clsLicense license)
        {
            switch (service)
            {
                case eLicenseServices.IssueInternational:
                    return IssueInternationalLicense(LicenseID, UserID, licenseType, out license);

                case eLicenseServices.RenewLicense:
                    return RenewLicense(LicenseID, UserID, licenseType, out license);

            //    case eLicenseServices.ReplaceForLostLicense:
            //        return;

            //    case eLicenseServices.ReplaceForDamagedLicense:
            //        return;

            //    case eLicenseServices.DetainDrivingLicense:
            //        return;

            //    case eLicenseServices.ReleaseDetainedLicense:
            //        return;
            }

            license = null;
            return eResult.Error;
        }
    }
}
