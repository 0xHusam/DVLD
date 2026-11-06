using BaseCRUD;
using Business.GlobalData;
using Business.ModelsManger;
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

namespace WindowsForms.Forms.frm_Application.ManageDrivingLicense
{
    public partial class frmManageDrivingLicense : frmBaseCRUD
    {
        public frmManageDrivingLicense(DataView view = null)
        {
            InitializeComponent();

            if (view == null)
                View = clsdtLicenses.dtLicenses.DefaultView;

            else
                View = view;
        }



        private void frmManageDrivingLicense_Load(object sender, EventArgs e)
        {
            dgv.BackgroundColor = Color.Black;
            dgv.ContextMenuStrip = cms;
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
            clsApplicationManager.Getlicense(ID, out clsLicense license);
            frmShowLicense frm = new frmShowLicense(license);
            frm.Show();

        }
    }
}
