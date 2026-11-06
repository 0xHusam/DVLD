using Business;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ctrlAddUpdateUser : UserControl
    {
        private clsUser _User = null;
        public ctrlAddUpdateUser()
        {
            InitializeComponent();
        }

        private void FillChkPermissions()
        {
            if ((_User.Permissions & (int)ePermissions.Applications) == (int)ePermissions.Applications)
                chkApp.Checked = true;

            if ((_User.Permissions & (int)ePermissions.People) == (int)ePermissions.People)
                chkPeople.Checked = true;

            if ((_User.Permissions & (int)ePermissions.Drivers) == (int)ePermissions.Drivers)
                chkDrivers.Checked = true;

            if ((_User.Permissions & (int)ePermissions.Users) == (int)ePermissions.Users)
                chkUsers.Checked = true;

            if ((_User.Permissions & (int)ePermissions.Payments) == (int)ePermissions.Payments)
                chkPayments.Checked = true;
        }

        public void LoadUser(clsUser user)
        {
            _User = user;
            ctrlAddUpdatePerson1.LoadPerson(_User);
            lblUserID.Text = user.UserID.ToString();
            txtUsername.Text = user.UserName;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            chkIsActive.Checked = user.IsActive;

            FillChkPermissions();
        }
        private void ctrlFindPerson1_FindPerson(Models.clsPerson obj)
        {
            if (_User?.PersonID == obj.PersonID) return;

            if (clsUserManager.IsPersonExistByID(obj.PersonID) == eResult.Success)
            {
                errorProvider1.SetError(ctrlFindPerson1, "Find Another Person!");
                return;
            }
            else
                errorProvider1.SetError(ctrlFindPerson1, "");

            ctrlAddUpdatePerson1.LoadPerson(obj);
        }

        private bool CheckRequiredFields()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtUsername, "UserName is required.");
            }

            if (txtPassword.Visible && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtPassword, "Password is required.");
            }

            return isValid;
        }

        private int GetPermissions()
        {
            int Permissions = 0;

            if (chkApp.Checked)
                Permissions |= (int)ePermissions.Applications;

            if (chkPeople.Checked)
                Permissions |= (int)ePermissions.People;

            if (chkDrivers.Checked)
                Permissions |= (int)ePermissions.Drivers;

            if (chkUsers.Checked)
                Permissions |= (int)ePermissions.Users;

            if (chkPayments.Checked)
                Permissions |= (int)ePermissions.Payments;

            return Permissions;
        }

        public clsUser GetUser()
        {
            clsPerson person = ctrlAddUpdatePerson1.GetPerson();
            if (!CheckRequiredFields() || person == null) return null;

            int userId = (_User == null) ? -1 : _User.UserID;
            return new clsUser(userId, GetPermissions(), txtUsername.Text, txtPassword.Text, chkIsActive.Checked, person);
        }

        public void SetLblID(int ID)
        {
            lblUserID.Text = ID.ToString();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == _User?.UserName) return;

            if (clsUserManager.IsExist(txtUsername.Text) == eResult.Success)
                errorProvider1.SetError(txtUsername, "This UserName already exists.");
            else
                errorProvider1.SetError(txtUsername, "");
        }
        private void SetErorProvider_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "");
            }
        }
    }
}
