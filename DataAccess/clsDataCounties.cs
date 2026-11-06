using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DataAccess
{
    public static class clsDataCounties
    {
        public static eResult FillAllCountries(DataTable dtCountries)
        {
            string query = "Select * from Countries";
            return clsDataHelper.LoadTable(query, dtCountries);
        }
        public static eResult GetCountryID(string country, out int ID)
        {
            ID = -1;
            string query = "SELECT ID FROM Countries WHERE Name = @CountryName";

            eResult Result = clsDataHelper.ExecuteScalar(query, cmd => cmd.Parameters.AddWithValue("@CountryName", country), out object obj);
            
            if (Result == eResult.Success)
                ID = Convert.ToInt32(obj);

            return Result;
        }
    }
}
