using Business;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pbShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUserManager.Login(txtUserName.Text, txtPassword.Text, out clsUser LoginUser);

            if (LoginUser == null)
            {
                lblErorMessage.Text = "The username or password is incorrect.";
                return;
            }

            else if (LoginUser.IsActive == false)
            {
                lblErorMessage.Text = "This account has been deactivated. Please contact support.";
                return;
            }

            lblErorMessage.Text = "";
            txtUserName.Clear();
            txtPassword.Clear();

            this.Hide();
            frmMain main = new frmMain(LoginUser);
            main.ShowDialog();
            this.Show();
        }
    }
}
