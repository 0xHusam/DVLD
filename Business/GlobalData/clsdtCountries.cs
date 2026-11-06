using Business.ModelsManger;
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
    public static class clsdtCountries
    {
        public static DataTable dtCountries = new DataTable();

        public static void Initialize()
        {
            DataColumn col = new DataColumn("ID", typeof(int)) { Caption = "ID"};
            dtCountries.Columns.Add(col);

            col = new DataColumn("Name", typeof(string)) { Caption = "Country" };
            dtCountries.Columns.Add(col);

            dtCountries.PrimaryKey = new DataColumn[] { dtCountries.Columns["ID"] };
            dtCountries.TableName = "Countries";
        }

        public static eResult FillDtCountries()
        {
            return clsCountriesManager.FillAllCountries(dtCountries);
        }
    }
}
