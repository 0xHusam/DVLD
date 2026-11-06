using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class clsUser : clsPerson
    {
        public int UserID { get; set; }
        public int Permissions { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser(int userID, int permissions, string userName, string password, bool isActive, clsPerson person)
            : base(person)
        {
            UserID = userID;
            Permissions = permissions;
            UserName = userName;
            Password = password;
            IsActive = isActive;
        }
    }
}
