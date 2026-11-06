using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class clsDataUser
    {
        private static clsUser MapReaderToUser(SqlDataReader reader)
        {
            clsPerson person = clsDataPerson.MapReaderToPerson(reader);

            int userID = Convert.ToInt32(reader["UserID"]);
            int Permissions = Convert.ToInt32(reader["Permissions"]);
            string userName = reader["UserName"].ToString();
            string password = reader["Password"].ToString();
            bool isActive = Convert.ToBoolean(reader["IsActive"]);

            return new clsUser(userID, Permissions, userName, password, isActive, person);
        }

        private static void Parameters(SqlCommand command, clsUser user)
        {
            command.Parameters.AddWithValue("@Permissions", user.Permissions);
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@PersonID", user.PersonID);
        }
        public static eResult FillAllUsers(DataTable dtUsers)
        {
            string query = "Select * from Users";
            return clsDataHelper.LoadTable(query, dtUsers);
        }

        public static eResult FindByUserName(string username, out clsUser user)
        {
            string query = "Select * from MasterUsers Where UserName = @UserName";
            return clsDataHelper.LoadEntity(query, cmd => cmd.Parameters.AddWithValue("@UserName", username), MapReaderToUser, out user);
        }

        public static eResult FindByID(int UserID, out clsUser user)
        {
            string query = "Select * from MasterUsers Where UserID = @UserID";
            return clsDataHelper.LoadEntity(query, cmd => cmd.Parameters.AddWithValue("@UserID", UserID), MapReaderToUser, out user);
        }

        public static eResult Insert(clsUser user)
        {
            string query = @"INSERT INTO Users (Permissions, UserName, Password, IsActive, PersonID) 
                           VALUES (@Permissions, @UserName, @Password, @IsActive, @PersonID) 
                           SELECT SCOPE_IDENTITY()";

            eResult result = clsDataHelper.InsertEntity(query, cmd => Parameters(cmd, user), out int DbNewID);

            if (result == eResult.Success)
                user.UserID = DbNewID;

            return result;
        }
        public static eResult Update(clsUser user)
        {
            eResult result = clsDataPerson.Update(user);
            if (result != eResult.Success) return result;

            string query = @"UPDATE Users SET Permissions = @Permissions, UserName = @UserName,
                IsActive = @IsActive, PersonID = @PersonID WHERE ID = @UserID";
            return clsDataHelper.ExecuteNonQuery
                (
                query,
                cmd => 
                {
                    Parameters(cmd, user);
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);
                },
                out _
                );
        }

        public static eResult InActive(int ID)
        {
            string query = "Update Users set IsActive = 0 Where ID = @UserID";
            return clsDataHelper.ExecuteNonQuery(query, cmd => cmd.Parameters.AddWithValue("@UserID", ID), out _);
        }

        public static eResult Active(int ID)
        {
            string query = "Update Users set IsActive = 1 Where ID = @UserID";
            return clsDataHelper.ExecuteNonQuery(query, cmd => cmd.Parameters.AddWithValue("@UserID", ID), out _);
        }

        public static eResult DeleteByID(int ID)
        {
            string query = "delete users where ID = @UserID";
            return clsDataHelper.ExecuteNonQuery(query, cmd => cmd.Parameters.AddWithValue("@UserID", ID), out _);
        }
        public static eResult IsExist(int UserID)
        {
            string query = "select Found=1 from Users where ID = @UserID";
            return clsDataHelper.ExecuteScalar(query, cmd => cmd.Parameters.AddWithValue("@UserID", UserID), out _);
        }

        public static eResult IsExist(string UserName)
        {
            string query = "select Found=1 from Users where UserName = @UserName";
            return clsDataHelper.ExecuteScalar(query, cmd => cmd.Parameters.AddWithValue("@UserName", UserName), out _);
        }

        public static eResult ChangePassword(int userID, string NewPassword)
        {
            string query = "UPDATE Users SET Password = @Password WHERE ID = @UserID";
            return clsDataHelper.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@Password", NewPassword);
                cmd.Parameters.AddWithValue("@UserID", userID);
            }
            , out _
            );
        }

        public static eResult IsPersonExistByID(int ID)
        {
            string Query = "select 1 from users where PersonID = @ID";
            return clsDataHelper.ExecuteScalar(Query, cmd => cmd.Parameters.AddWithValue("@ID", ID), out _);

        }

    }
    
}
