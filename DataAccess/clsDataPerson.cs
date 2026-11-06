 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using Models;
using System.Net;
using System.Security.Policy;

namespace DataAccess
{
    public static class clsDataPerson
    {
        internal static T GetSafeValue<T>(SqlDataReader reader, string ColumnName)
        {
            object value = reader[ColumnName];
            if (value == DBNull.Value) return default(T);

            return (T)value;
        }
        internal static clsPerson MapReaderToPerson(SqlDataReader reader)
        {
            int personID = Convert.ToInt32(reader["PersonID"]);
            int nationalID = Convert.ToInt32(reader["NationalID"]);
            string firstName = reader["FirstName"].ToString();
            string secondName = GetSafeValue<string>(reader, "SecondName");
            string thirdName = GetSafeValue<string>(reader, "ThirdName");
            string lastName = reader["LastName"].ToString();
            DateTime dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
            char gender = Convert.ToChar(reader["Gender"]);
            string Address = reader["Address"].ToString();
            string phone = reader["Phone"].ToString();
            string email = GetSafeValue<string>(reader, "Email");
            string country = reader["Country"].ToString();
            int CountryID = Convert.ToInt32(reader["CountryID"]);
            string imagePath = GetSafeValue<string>(reader, "PicturePath");

            return new clsPerson(
                personID,
                nationalID,
                firstName,
                secondName,
                thirdName,
                lastName,
                dateOfBirth,
                gender,
                Address,
                phone,
                email,
                country,
                CountryID,
                imagePath
            );
        }
        public static eResult FillAllPeople(DataTable dtPeople)
        {
            string query = "SELECT * FROM People";
            return clsDataHelper.LoadTable(query, dtPeople);
        }

        public static eResult FindByID(int personID, out clsPerson person)
        {
            string query = "SELECT * FROM MasterPeople WHERE PersonID = @PersonID";
            return clsDataHelper.LoadEntity<clsPerson>(query, cmd => cmd.Parameters.AddWithValue("@PersonID", personID), MapReaderToPerson, out person);
        }

        public static eResult FindByNationalID(int NationalID, out clsPerson person)
        {
            string query = "SELECT * FROM MasterPeople WHERE NationalID = @NationalID";
            return clsDataHelper.LoadEntity<clsPerson>(query, cmd => cmd.Parameters.AddWithValue("@NationalID", NationalID), MapReaderToPerson, out person);
        }
        
        private static void ParametersAddWithValueChkNull(SqlCommand command, string Parameter, string Value)
        {
            if (string.IsNullOrEmpty(Value))
                command.Parameters.AddWithValue(Parameter, DBNull.Value);
            else
                command.Parameters.AddWithValue(Parameter, Value);
        }
        private static void Parameters(SqlCommand command, clsPerson person)
        {
            command.Parameters.AddWithValue("@NationalID", person.NationalID);
            command.Parameters.AddWithValue("@FirstName", person.FirstName);
            command.Parameters.AddWithValue("@LastName", person.LastName);
            command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
            command.Parameters.AddWithValue("@Gender", person.Gender);
            command.Parameters.AddWithValue("@Phone", person.Phone);
            command.Parameters.AddWithValue("@CountryID", person.CountryID);

            ParametersAddWithValueChkNull(command, "@SecondName", person.SecondName);
            ParametersAddWithValueChkNull(command, "@ThirdName", person.ThirdName);
            ParametersAddWithValueChkNull(command, "@Address", person.Address);
            ParametersAddWithValueChkNull(command, "@Email", person.Email);
            ParametersAddWithValueChkNull(command, "@PicturePath", person.PicturePath);
        }

        public static eResult Insert(clsPerson person)
        {
            string query = @"INSERT INTO People (NationalID, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryID, PicturePath)
                           VALUES (@NationalID, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @CountryID, @PicturePath)
                           Select SCOPE_IDENTITY()";

            eResult result = clsDataHelper.InsertEntity(query, cmd => Parameters(cmd, person), out int DbNewID);

            if (result == eResult.Success)
                person.PersonID = DbNewID;

            return result;
        }

        public static eResult Update(clsPerson person)
        {
            string query = @"UPDATE People 
                             SET NationalID = @NationalID, FirstName = @FirstName, SecondName = @SecondName, 
                             ThirdName = @ThirdName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, 
                             Address = @Address, Phone = @Phone, Email = @Email, CountryID = @CountryID, PicturePath = @PicturePath 
                             WHERE PersonID = @PersonID";
            return clsDataHelper.ExecuteNonQuery(
                query,
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@PersonID", person.PersonID);
                    Parameters(cmd, person);
                },
                out _
                );             
        }

        public static eResult Delete(int PersonID)
        {
            string query = "DELETE FROM People WHERE PersonID = @PersonID";
            return clsDataHelper.ExecuteNonQuery(query, cmd => cmd.Parameters.AddWithValue("@PersonID", PersonID), out _);
        }

        public static eResult IsExistByID(int PersonID)
        {
            string query = "select Found=1 from People where PersonID = @PersonID";
            return clsDataHelper.ExecuteScalar(query, cmd => cmd.Parameters.AddWithValue("@PersonID", PersonID), out _);
        }
        public static eResult IsExistByNationalID(int NationalID)
        {
            string query = "select Found=1 from People where NationalID = @NationalID";
            return clsDataHelper.ExecuteScalar(query, cmd => cmd.Parameters.AddWithValue("@NationalID", NationalID), out _);
        }
        
    }
}
