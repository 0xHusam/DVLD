using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.GlobalData
{
    public static class clsdtUsers
    {
        public static DataTable dtUsers = new DataTable();

        public static void Initialize()
        {
            dtUsers.Columns.Add(new DataColumn("ID", typeof(int)) { Caption = "ID" });
            dtUsers.Columns.Add(new DataColumn("PersonID", typeof(int)) { Caption = "_" });

            clsTables.Tables.Relations.Add
            (
                "UsersPeople",
                clsdtPeople.dtPeople.Columns["PersonID"],
                clsdtUsers.dtUsers.Columns["PersonID"]
            );

            dtUsers.Columns.Add(new DataColumn("FirstName", typeof(string)) { Caption = "First Name", Expression = "Parent(UsersPeople).FirstName" });
            dtUsers.Columns.Add(new DataColumn("SecondName", typeof(string)) { Caption = "Second Name", Expression = "Parent(UsersPeople).SecondName" });
            dtUsers.Columns.Add(new DataColumn("ThirdName", typeof(string)) { Caption = "Third Name", Expression = "Parent(UsersPeople).ThirdName" });
            dtUsers.Columns.Add(new DataColumn("LastName", typeof(string)) { Caption = "Last Name", Expression = "Parent(UsersPeople).LastName" });
            dtUsers.Columns.Add(new DataColumn("UserName", typeof(string)) { Caption = "User Name" });
            dtUsers.Columns.Add(new DataColumn("Permissions", typeof(string)) { Caption = "Permissions" });
            dtUsers.Columns.Add(new DataColumn("IsActive", typeof(bool)) { Caption = "_" });
            dtUsers.Columns.Add(new DataColumn("Active", typeof(string)) { Caption = "Is Active", Expression = "iif(IsActive = true, 'Yes', 'No')" });
            
            dtUsers.PrimaryKey = new DataColumn[] { dtUsers.Columns["ID"] };
                dtUsers.TableName = "Users";
        }

        public static eResult FillDtUsers()
        {
            return clsUserManager.FillAllUsers(dtUsers);
        }

        internal static void AddRow(Models.clsUser user)
        {
            DataRow row = dtUsers.NewRow();
            row["ID"] = user.UserID;
            row["PersonID"] = user.PersonID;
            row["Permissions"] = user.Permissions;
            row["UserName"] = user.UserName;
            row["IsActive"] = user.IsActive;
            dtUsers.Rows.Add(row);
        }

        internal static void UpdateRow(Models.clsUser user)
        {
            DataRow row = dtUsers.Rows.Find(user.UserID);
            if (row != null)
            {
                row["ID"] = user.UserID;
                row["PersonID"] = user.PersonID;
                row["Permissions"] = user.Permissions;
                row["UserName"] = user.UserName;
                row["IsActive"] = user.IsActive;
            }
        }

        internal static void Active(int ID)
        {
            DataRow row = dtUsers.Rows.Find(ID);
            if (row != null)
            {
                
                row["IsActive"] = true;
            }
        }

        internal static void InActive(int ID)
        {
            DataRow row = dtUsers.Rows.Find(ID);
            if (row != null)
            {

                row["IsActive"] = false;
            }
        }

        internal static void DeleteRow(int ID)
        {
            DataRow row = dtUsers.Rows.Find(ID);
            if (row != null)
            {
                dtUsers.Rows.Remove(row);
            }
        }
    }
}
