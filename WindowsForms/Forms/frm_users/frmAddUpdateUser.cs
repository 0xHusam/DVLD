using Business;
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
    public partial class frmAddUpdateUser : Form
    {
        public delegate void UserSavedEventHandler(clsUser user);
        public event UserSavedEventHandler UserSaved;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            this.Text = "Add IssueLocalLicense User";
        }

        public frmAddUpdateUser(clsUser user)
        {
            InitializeComponent();
            ctrlAddUpdateUser1.LoadUser(user);
            this.Text = "Update User";
        }

        private void brnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsUser user = ctrlAddUpdateUser1.GetUser();

            if (user != null && clsUserManager.Save(user) == eResult.Success)
            {
                UserSaved?.Invoke(user);
                ctrlAddUpdateUser1.SetLblID(user.UserID);
                MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save user. Please check the details and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
