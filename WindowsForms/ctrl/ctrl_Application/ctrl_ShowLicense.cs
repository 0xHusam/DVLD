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

namespace WindowsForms.ctrl.ctrl_Application
{
    public partial class ctrl_ShowLicense : UserControl
    {
        public clsLicenseType licenseType = null;
        public ctrl_ShowLicense()
        {
            InitializeComponent();

        }

        public void LoadLicense(clsLicenseType license)
        {
            licenseType = license;

            lblID.Text = license.ID.ToString();
            lblType.Text = license.Type;
            lblDescripation.Text = license.Description;
            lblAgeRestrication.Text = license.AgeRestrication.ToString();
            lblDuration.Text = license.Duration.ToString();
            lblFee.Text = license.Fee.ToString();
        }
    }
}
