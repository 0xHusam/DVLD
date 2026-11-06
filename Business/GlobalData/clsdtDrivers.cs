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
    public static class clsdtDrivers
    {
        public static DataTable dtDrivers = new DataTable();

        public static void Initialize()
        {
            dtDrivers.Columns.Add(new DataColumn("DriverID", typeof(int)) { Caption = "Driver ID" });
            dtDrivers.Columns.Add(new DataColumn("NationalID", typeof(string)) { Caption = "National ID" });
            dtDrivers.Columns.Add(new DataColumn("Name", typeof(string)) { Caption = "Name" });
            dtDrivers.Columns.Add(new DataColumn("DateOfBirth", typeof(DateTime)) { Caption = "Date of Birth" });
            dtDrivers.Columns.Add(new DataColumn("Gender", typeof(char)) { Caption = "_" });
            dtDrivers.Columns.Add(new DataColumn("GenderText", typeof(string)) { Caption = "Gender", Expression = "iif(Gender = 'M', 'Male', 'Female')" });
            
            dtDrivers.PrimaryKey = new DataColumn[] { dtDrivers.Columns["DriverID"] };
            dtDrivers.TableName = "Drivers";
        }

        public static eResult FillDtDrivers()
        {
            return clsApplicationManager.GetDrivers(dtDrivers);
        }
    }
}
