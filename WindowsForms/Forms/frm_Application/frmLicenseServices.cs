using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.ModelsManger;
using Models;
using WindowsForms.Forms.frm_Application.ManageDrivingLicense;

namespace WindowsForms.Forms.frm_Application
{
    public partial class frmLicenseServices : Form
    {
        eLicenseServices ServiceType = new eLicenseServices();
        clsLicense _License = null;
        public frmLicenseServices(eLicenseServices Service)
        {
            InitializeComponent();
            ServiceType = Service;
            clsApplicationManager.GetService((int)Service, out clsServiceType serviceType);
            lblServiceID.Text = serviceType.ID.ToString();
            lblServiceType.Text = serviceType.ServiceType;
            lblFee.Text = serviceType.Fee.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseID.Text))
            {
                errorProvider1.SetError(txtLicenseID, "Enter ID");
                return;
            }

            if (int.TryParse(txtLicenseID.Text, out int ID) == false)
            {
                errorProvider1.SetError(txtLicenseID, "ID Must Be Numbers");
                return;
            }

            if (clsApplicationManager.Getlicense(ID, out clsLicense license) != eResult.Success)
            {
                errorProvider1.SetError(txtLicenseID, "License Not Found, Enter Another ID");
                return;
            }

            errorProvider1.SetError(txtLicenseID, "");
            ctrlLicense1.loadLicense(license);
            _License = license;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_License == null)
            {
                MessageBox.Show("Enter Valid License ID");
                return;
            }
            int LicenseID = _License.LicenseID;
            int UserID = frmMain.LoginUser.UserID;
            
            if (clsApplicationManager.SaveLicense(LicenseID, UserID, _License.LicenseType, ServiceType, out clsLicense DbLicense) == eResult.Success)
            {
                MessageBox.Show("Seccussful :)");
                ctrlLicense1.loadLicense(DbLicense);
                _License = DbLicense;
                txtLicenseID.Text = _License.LicenseID.ToString();
            }

            else
            {
                MessageBox.Show("There Is an Erorr :(", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
