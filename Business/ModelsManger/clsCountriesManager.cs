using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsManger
{
    public static class clsCountriesManager
    {
        public static eResult FillAllCountries(DataTable dt)
        {
            return clsDataCounties.FillAllCountries(dt);
        }
        public static eResult GetCountryID(string Country, out int ID)
        {
            return clsDataCounties.GetCountryID(Country, out ID);
        }
    }
}
