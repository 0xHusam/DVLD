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
    public static class clsdtPeople
    {
        public static DataTable dtPeople = new DataTable();

        public static void Initialize()
        {
            dtPeople.Columns.Add(new DataColumn("PersonID", typeof(int)) { Caption = "ID" });
            dtPeople.Columns.Add(new DataColumn("NationalID", typeof(string)) { Caption = "National ID" });
            dtPeople.Columns.Add(new DataColumn("FirstName", typeof(string)) { Caption = "First Name" });
            dtPeople.Columns.Add(new DataColumn("SecondName", typeof(string)) { Caption = "Second Name" });
            dtPeople.Columns.Add(new DataColumn("ThirdName", typeof(string)) { Caption = "Third Name" });
            dtPeople.Columns.Add(new DataColumn("LastName", typeof(string)) { Caption = "Last Name" });
            dtPeople.Columns.Add(new DataColumn("DateOfBirth", typeof(DateTime)) { Caption = "Date of Birth" });
            dtPeople.Columns.Add(new DataColumn("Gender", typeof(char)) { Caption = "_" });
            dtPeople.Columns.Add(new DataColumn("GenderText", typeof(string)) { Caption = "Gender", Expression = "iif(Gender = 'M', 'Male', 'Female')" });
            dtPeople.Columns.Add(new DataColumn("Address", typeof(string)) { Caption = "Address" });
            dtPeople.Columns.Add(new DataColumn("Phone", typeof(string)) { Caption = "Phone" });
            dtPeople.Columns.Add(new DataColumn("Email", typeof(string)) { Caption = "Email" });
            dtPeople.Columns.Add(new DataColumn("CountryID", typeof(int)) { Caption = "_" });

            clsTables.Tables.Relations.Add
            (
                "PeopleCountries",
                clsdtCountries.dtCountries.Columns["ID"],
                clsdtPeople.dtPeople.Columns["CountryID"]
            );

            dtPeople.Columns.Add(new DataColumn("Country", typeof(string)) { Caption = "Country", Expression = "Parent(PeopleCountries).Name" });
            dtPeople.Columns.Add(new DataColumn("PicturePath", typeof(string)) { Caption = "Picture Path" });

            dtPeople.PrimaryKey = new DataColumn[] { dtPeople.Columns["PersonID"] };
            dtPeople.TableName = "People";
        }

        public static eResult FillDtPeople()
        {
            return clsPersonManager.FillAllPeople(dtPeople);
        }

        internal static void AddRow(Models.clsPerson person)
        {
            DataRow row = dtPeople.NewRow();
            row["PersonID"] = person.PersonID;
            row["NationalID"] = person.NationalID;
            row["FirstName"] = person.FirstName;
            row["SecondName"] = person.SecondName;
            row["ThirdName"] = person.ThirdName;
            row["LastName"] = person.LastName;
            row["DateOfBirth"] = person.DateOfBirth;
            row["Gender"] = person.Gender;
            row["Address"] = person.Address;
            row["Phone"] = person.Phone;
            row["Email"] = person.Email;
            row["CountryID"] = person.CountryID;
            row["PicturePath"] = person.PicturePath;
            dtPeople.Rows.Add(row);
        }

        internal static void UpdateRow(Models.clsPerson person)
        {
            DataRow row = dtPeople.Rows.Find(person.PersonID);
            if (row != null)
            {
                row["NationalID"] = person.NationalID;
                row["FirstName"] = person.FirstName;
                row["SecondName"] = person.SecondName;
                row["ThirdName"] = person.ThirdName;
                row["LastName"] = person.LastName;
                row["DateOfBirth"] = person.DateOfBirth;
                row["Gender"] = person.Gender;
                row["Address"] = person.Address;
                row["Phone"] = person.Phone;
                row["Email"] = person.Email;
                row["CountryID"] = person.CountryID;
                row["PicturePath"] = person.PicturePath;
            }
        }

        internal static void DeleteRow(int ID)
        {
            DataRow row = dtPeople.Rows.Find(ID);
            if (row != null)
            {
                dtPeople.Rows.Remove(row);
            }
        }
    }
}
