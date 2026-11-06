using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.GlobalData
{
    public static class clsTables
    {
        public static DataSet Tables = new DataSet("Tables");

        public static void Initialize()
        {
            Tables.Tables.Add(clsdtCountries.dtCountries);
            Tables.Tables.Add(clsdtPeople.dtPeople);
            Tables.Tables.Add(clsdtUsers.dtUsers);

            clsdtCountries.Initialize();
            clsdtPeople.Initialize();
            clsdtUsers.Initialize();
            clsdtIssueLocalLicenses.Initialize();
            clsdtLicenses.Initialize();
            clsdtDrivers.Initialize();
            clsdtPayment.Initialize();
            FillAllTables();
        }

        private static void FillAllTables()
        {
            clsdtCountries.FillDtCountries();
            clsdtPeople.FillDtPeople();
            clsdtUsers.FillDtUsers();
            clsdtIssueLocalLicenses.FillDtIssueLocalLicenses();
            clsdtLicenses.FillDtLicenses();
            clsdtDrivers.FillDtDrivers();
        }
    }
}
