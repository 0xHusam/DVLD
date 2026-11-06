using Business.ModelsManger;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.GlobalData
{
    public static class clsdtIssueLocalLicenses
    {
        public static DataTable dtIssueLocalLicenses = new DataTable();

        public static void Initialize()
        {
            dtIssueLocalLicenses.Columns.Add(new DataColumn("ID", typeof(int)) { Caption = "ID" });
            dtIssueLocalLicenses.Columns.Add(new DataColumn("OrderDate", typeof(DateTime)) { Caption = "Order Date" });
            dtIssueLocalLicenses.Columns.Add(new DataColumn("PersonID", typeof(int)) { Caption = "Person ID" });
            dtIssueLocalLicenses.Columns.Add(new DataColumn("NationalID", typeof(int)) { Caption = "National ID" });
            dtIssueLocalLicenses.Columns.Add(new DataColumn("LicenseType", typeof(string)) { Caption = "License Type" });
            dtIssueLocalLicenses.Columns.Add(new DataColumn("PassedTests", typeof(int)) { Caption = "Passed Tests" });
            dtIssueLocalLicenses.Columns.Add(new DataColumn("UserName", typeof(string)) { Caption = "User Name" });
            dtIssueLocalLicenses.Columns.Add(new DataColumn("Status", typeof(string)) { Caption = "Status" });

            dtIssueLocalLicenses.PrimaryKey = new DataColumn[] { dtIssueLocalLicenses.Columns["ID"] };
        }

        public static eResult FillDtIssueLocalLicenses()
        {
            return clsApplicationManager.GetManageIssueLocalLicenseTable(dtIssueLocalLicenses);
        }

        public static void Cansel(int ID)
        {
            DataRow row = dtIssueLocalLicenses.Rows.Find(ID);
            if (row != null)
                row["Status"] = "Canceled";
        }
        public static void Complate(int ID)
        {
            DataRow row = dtIssueLocalLicenses.Rows.Find(ID);
            if (row != null)
                row["Status"] = "Complated";
        }

        public static void IncresePassedTests(int ID)
        {
            DataRow row = dtIssueLocalLicenses.Rows.Find(ID);
            if (row != null)
                row["PassedTests"] = (int)row["PassedTests"] + 1;
        }
    }
}
