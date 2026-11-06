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

namespace WindowsForms.Forms.frm_Application.ManageDrivingLicense
{
    public partial class frmShowLicense : Form
    {
        clsLicense license = null;
        public frmShowLicense(clsLicense license)
        {
            InitializeComponent();
            ctrlLicense1.loadLicense(license);      
        }
    }
}
