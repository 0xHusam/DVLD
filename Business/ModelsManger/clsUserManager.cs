
using Business.GlobalData;
using Business.ModelsManger;
using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class clsUserManager
    {
        public static eResult FillAllUsers(DataTable dt)
        {
            return DataAccess.clsDataUser.FillAllUsers(dt);
        }
        public static eResult FindFindByUserName(string username, out clsUser user)
        {
            return DataAccess.clsDataUser.FindByUserName(username, out user);
        }
        public static eResult FindByID(int ID, out clsUser user)
        {
            return DataAccess.clsDataUser.FindByID(ID, out user);
        }

        private static eResult Insert(Models.clsUser user)
        {
            return clsManagerHelper.Operation<clsUser>(user, clsDataUser.Insert, clsdtUsers.AddRow);
        }

        private static eResult Update(Models.clsUser user)
        {
            return clsManagerHelper.Operation<clsUser>(user, clsDataUser.Update, clsdtUsers.UpdateRow);
        }

        public static eResult Save(Models.clsUser user)
        {
            if (user.UserID == -1) return Insert(user);

            return Update(user);
        }
        public static eResult Inactive(int ID)
        {
           return clsManagerHelper.Operation<int>(ID, clsDataUser.InActive, clsdtUsers.InActive);
        }

        public static eResult Active(int ID)
        {
            return clsManagerHelper.Operation<int>(ID, clsDataUser.Active, clsdtUsers.Active);
        }

        public static eResult IsExist(int userID)
        {
            return clsDataUser.IsExist(userID);
        }

        public static eResult IsExist(string UserName)
        {
            return clsDataUser.IsExist(UserName);
        }

        public static eResult ChangePassword(clsUser user, string Password, string newPassword)
        {
            if (user.Password == Password)
                return clsDataUser.ChangePassword(user.UserID, newPassword);

            return eResult.NotFound;
        }

        public static eResult Login(string UserName, string Password, out clsUser User)
        {
            User = default;

            eResult result = FindFindByUserName(UserName, out clsUser DBUser);
            if (result == eResult.Success)
            {
                if (DBUser.Password == Password)
                {
                    User = DBUser;
                    return eResult.Success;
                }

                return eResult.NotFound;
            }

            return eResult.Error;
        }

        public static eResult IsPersonExistByID(int ID)
        {
            return clsDataUser.IsPersonExistByID(ID);
        }

        public static eResult DeleteByID(int ID)
        {
            return clsManagerHelper.Operation<int>(ID, opr => clsDataUser.DeleteByID(opr), Ropr => clsdtUsers.DeleteRow(Ropr));
        }

    }
}
