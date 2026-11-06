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
using WindowsForms.Forms.frm_Application;
using WindowsForms.Forms.frm_Application.frm_TestTypes;
using WindowsForms.Forms.frm_Application.LicensingServiceOrders;
using WindowsForms.Forms.frm_Application.ManageDrivingLicense;
using WindowsForms.Forms.frm_Drivers;
using WindowsForms.Forms.frm_users.frm_Payments;

namespace WindowsForms
{
    public partial class frmMain : Form
    {
        public static clsUser LoginUser;
        public frmMain(clsUser LoginUser)
        {
            InitializeComponent();
            frmMain.LoginUser = LoginUser;
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmPeopleCRUD()).Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            menuStrip1.Items[5].Image = Helpers.clsPersonHelper.GetPersonImage(LoginUser);

            if ((LoginUser.Permissions & (int)ePermissions.Applications) != (int)ePermissions.Applications)
                AppTsmi.Enabled = false;

            if ((LoginUser.Permissions & (int)ePermissions.People) != (int)ePermissions.People)
                PeopleTsmi.Enabled = false;

            if ((LoginUser.Permissions & (int)ePermissions.Drivers) != (int)ePermissions.Drivers)
                DriversTsmi.Enabled = false;

            if ((LoginUser.Permissions & (int)ePermissions.Users) != (int)ePermissions.Users)
                UsersTsmi.Enabled = false;

            if ((LoginUser.Permissions & (int)ePermissions.Payments) != (int)ePermissions.Payments)
                PaymentTsmi.Enabled = false;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmUsersCRUD()).Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(LoginUser);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(LoginUser);
            frm.ShowDialog();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationTypes frm = new frmApplicationTypes();
            frm.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestTypes frm = new frmTestTypes();
            frm.Show();
        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicensingServiceOrders frm = new frmLicensingServiceOrders();
            frm.Show();

        }

        private void localeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLocalOrder frm = new frmAddLocalOrder();
            frm.Show();
        }

        private void detaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void driveingLicenceServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivingLicense frm = new frmManageDrivingLicense();
            frm.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdrivers frm = new frmdrivers();
            frm.Show();
        }

        private void PaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments();
            frm.Show();
        }

        private void newDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseServices frm = new frmLicenseServices(eLicenseServices.IssueInternational);
            frm.Show();
        }

        private void reNewDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseServices frm = new frmLicenseServices(eLicenseServices.RenewLicense);
            frm.Show();
        }
    }
}
