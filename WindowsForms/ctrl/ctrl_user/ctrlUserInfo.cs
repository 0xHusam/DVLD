using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        public void ShowInfo(clsUser user)
        {
            ctrlPersonInfo1.ShowInfo(user);

            lblUserID.Text = user.UserID.ToString();
            lblUserName.Text = user.UserName;
            lblIsActive.Text = user.IsActive ? "Yes" : "No";
        }


    }
}
