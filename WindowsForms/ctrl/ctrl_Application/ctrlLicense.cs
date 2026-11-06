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
using WindowsForms.Helpers;

namespace WindowsForms.ctrl.ctrl_Application
{
    public partial class ctrlLicense : UserControl
    {
        clsLicense _license = null;
        public ctrlLicense()
        {
            InitializeComponent();
        }

        private void FillControls()
        {
            lblLicenseID.Text = _license.LicenseID.ToString();
            lblVirsionNumber.Text = _license.VisonNumber.ToString();
            lblLicenseType.Text = _license.LicenseType;
            lblCreationDate.Text = _license.CreationDate;
            lblExpireDate.Text = _license.ExpireDate;
            lblLicenseStatus.Text = _license.LicenseStatus;
            lblInternational.Text = _license.IsInterNational;
            lblReserved.Text = _license.IsResereved;
            lblDriverID.Text = _license.DriverID.ToString();
            lblName.Text = _license.Name;
            lblGender.Text = _license.Gender.ToString();
            lblRestrictions.Text = _license.Restrictions;
            pbPicture.Image = clsPersonHelper.GetPersonImage(_license.Gender, _license.PicturePath);

        }

        public void loadLicense(clsLicense license)
        {
            _license = license;
            FillControls();
        }
    }
}
