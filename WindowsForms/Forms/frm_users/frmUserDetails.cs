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
    public partial class frmUserDetails : Form
    {
        private clsUser User;
        public frmUserDetails(clsUser user)
        {
            User = user;
            InitializeComponent();
            ctrlUserDetails1.ShowInfo(User);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(User);
            frm.UserSaved += ctrlUserDetails1.ShowInfo;
            frm.ShowDialog();
        }
    }
}
