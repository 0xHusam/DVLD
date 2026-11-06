using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.GlobalData
{
    public static class clsdtLicenses
    {
        public static DataTable dtLicenses = new DataTable();

        public static void Initialize()
        {
            dtLicenses.Columns.Add(new DataColumn("ID", typeof(int)) { Caption = "ID"});
            dtLicenses.Columns.Add(new DataColumn("VersionNumber", typeof(int)) { Caption = "Version Number" });
            dtLicenses.Columns.Add(new DataColumn("DriverID", typeof(int)) { Caption = "Driver ID" });
            dtLicenses.Columns.Add(new DataColumn("Name", typeof(string)) { Caption = "Name" });
            dtLicenses.Columns.Add(new DataColumn("Gender", typeof(char)) { Caption = "Gender" });
            dtLicenses.Columns.Add(new DataColumn("LicenseType", typeof(string)) { Caption = "License Type" }); 
            dtLicenses.Columns.Add(new DataColumn("CreationDate", typeof(DateTime)) { Caption = "Creation Date" });
            dtLicenses.Columns.Add(new DataColumn("ExpireDate", typeof(DateTime)) { Caption = "Expire Date" });
            dtLicenses.Columns.Add(new DataColumn("Status", typeof(string)) { Caption = "Status" });
            dtLicenses.Columns.Add(new DataColumn("IsInternational", typeof(string)) { Caption = "Is International" });
            dtLicenses.Columns.Add(new DataColumn("IsReserved", typeof(string)) { Caption = "Is Reserved" });
            dtLicenses.Columns.Add(new DataColumn("Restrictions", typeof(string)) { Caption = "Restrictions" });
            dtLicenses.Columns.Add(new DataColumn("PicturePath", typeof(string)) { Caption = "Picture Path" });

            dtLicenses.PrimaryKey = new DataColumn[] { dtLicenses.Columns["ID"] };
        }

        public static eResult FillDtLicenses ()
        {
            return clsDataLicenses.GetLicensesTable(dtLicenses);
        }

        public static void AddRow(clsLicense license)
        {
            DataRow row = dtLicenses.NewRow();
            row["ID"] = license.LicenseID;
            row["VersionNumber"] = license.VisonNumber;
            row["DriverID"] = license.DriverID;
            row["Name"] = license.Name;
            row["Gender"] = license.Gender;
            row["LicenseType"] = license.LicenseType;
            row["CreationDate"] = license.CreationDate;
            row["ExpireDate"] = license.ExpireDate;
            row["Status"] = license.LicenseStatus;
            row["IsInternational"] = license.IsInterNational;
            row["IsReserved"] = license.IsResereved;
            row["Restrictions"] = license.Restrictions;
            row["PicturePath"] = license.PicturePath;
            dtLicenses.Rows.Add(row);
        }

        public static void Expire(int ID)
        {
            DataRow row = dtLicenses.Rows.Find(ID);
            row["Status"] = "Expired";
        }
    }
}
