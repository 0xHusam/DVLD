using BaseCRUD;
using Business.GlobalData;
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
using WindowsForms.Forms.frm_Application.ManageDrivingLicense;

namespace WindowsForms.Forms.frm_Drivers
{
    public partial class frmdrivers : frmBaseCRUD
    {
        public frmdrivers()
        {
            InitializeComponent();
        }

        private void frmdrivers_Load(object sender, EventArgs e)
        {
            View = clsdtDrivers.dtDrivers.DefaultView;
            dgv.ContextMenuStrip = cms;
            dgv.MultiSelect = false;
        }

        private void shToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = Convert.ToInt32(dgv.SelectedRows[0].Cells["DriverID"].Value);
            clsdtLicenses.dtLicenses.DefaultView.RowFilter = "DriverID = " + DriverID;
            DataTable SelectedDT = clsdtLicenses.dtLicenses.DefaultView.ToTable();
            clsdtLicenses.dtLicenses.DefaultView.RowFilter = string.Empty;
            frmManageDrivingLicense frm = new frmManageDrivingLicense(SelectedDT.DefaultView);
            frm.Show();
        }
    }
}
