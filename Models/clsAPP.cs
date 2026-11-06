using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{   
    public enum ePermissions
    {
        Applications = 1,
        People = 2,
        Drivers = 4,
        Users = 8,
        Payments = 16
    }
    public enum eResult
    {
        Success,
        NotFound,
        Error
    }

    public enum eLicenseServices
    {
        IssueLocalLicense = 1,
        RenewLicense,
        ReplaceForLostLicense,
        ReplaceForDamagedLicense,
        ReleaseDetainedLicense,
        IssueInternational,
        DetainDrivingLicense
    }

    public enum eTestTypes
    {
        VisionTest = 1,
        WrittenTest,
        StreetTest,
    }

    public enum eLicenseTypes
    {
        SmallMotorcycleLicense = 9,
        HeavyMotorcycleLicense,
        OrdinaryDrivingLicense,
        CommercialDrivingLicense,
        AgriculturalVehiclesLicense,
        SmallandMediumBusLicense,
        TrucksandHeavyVehiclesLicense
    }

    public class clsTestType
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Fee { get; set; }

        public clsTestType(int ID, string Type, int Fee)
        {
            this.ID = ID;
            this.Type = Type;
            this.Fee = Fee;
        }
    }

    public class clsLicenseType
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int AgeRestrication { get; set; }
        public int Fee { get; set; }
        public int Duration { get; set; }

        public clsLicenseType(int ID, string Type, string Description, int Age, int Fee, int Duration)
        {
            this.ID = ID;
            this.Type = Type;
            this.Description = Description;
            this.AgeRestrication = Age;
            this.Fee = Fee;
            this.Duration = Duration;
        }


    }

    public class clsLicense
    {
        public int LicenseID { get; set; }
        public int VisonNumber { get; set; }
        public string LicenseType { get; set; }
        public string CreationDate { get; set; }
        public string ExpireDate { get; set; }
        public string LicenseStatus { get; set; }
        public string IsInterNational { get; set; }
        public string IsResereved { get; set; }
        public int DriverID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string Restrictions { get; set; }
        public string PicturePath { get; set; }

        public clsLicense(int LicenseID, int VisonNumber, string LicenseType, string CreationDate, string ExpireDate, string LicenseStatus,
            string IsInterNational, string IsResereved, int DriverID, string Name, char Gender, string Restrictions, string PicturePath)
        {
            this.LicenseID = LicenseID;
            this.VisonNumber = VisonNumber;
            this.LicenseType = LicenseType;
            this.CreationDate = CreationDate;
            this.ExpireDate = ExpireDate;
            this.LicenseStatus = LicenseStatus;
            this.IsInterNational = IsInterNational;
            this.IsResereved = IsResereved;
            this.DriverID = DriverID;
            this.Name = Name;
            this.Gender = Gender;
            this.Restrictions = Restrictions;
            this.PicturePath = PicturePath;
            //pbPicture
        }
    }
    public class clsServiceType
    {
        public int ID { get; set; }
        public string ServiceType { get; set; }
        public int Fee { get; set; }

        public clsServiceType(int ID, string ServiceType, int Fee)
        {
            this.ID = ID;
            this.ServiceType = ServiceType;
            this.Fee = Fee;
        }
    }
    
}
