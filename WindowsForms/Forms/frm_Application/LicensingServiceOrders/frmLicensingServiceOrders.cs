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
using WindowsForms.Forms.frm_Application.LicensingServiceOrders;

namespace WindowsForms.Forms.frm_Application
{
    public partial class frmLicensingServiceOrders : frmBaseCRUD
    {
        public frmLicensingServiceOrders()
        {
            InitializeComponent();
            dgv.ContextMenuStrip = cms;
        }

        private void frmLicensingServiceOrders_Load(object sender, EventArgs e)
        {
            View = clsdtIssueLocalLicenses.dtIssueLocalLicenses.DefaultView;

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
            clsApplicationManager.CancelIssueLocalLicense(ID);
        }

        private void cms_Opening(object sender, CancelEventArgs e)
        {
            cms.Items["tsmiCancel"].Visible = false;
            cms.Items["tsmiSechduleTest"].Visible = false;
            tsmiSechduleTest.Enabled = true;
            tsmiVisonTest.Visible = false;
            tsmiwritenTest.Visible = false;
            tsmiStreatTest.Visible = false;
            tsmiissueLicense.Visible = false;
            if (dgv.SelectedRows.Count == 1)
            {
                cms.Items["tsmiCancel"].Visible = true;
                cms.Items["tsmiSechduleTest"].Visible = true;
                tsmiVisonTest.Visible = true;
                tsmiwritenTest.Visible = true;
                tsmiStreatTest.Visible = true;
                tsmiVisonTest.Enabled = true;
                tsmiwritenTest.Enabled = false;
                tsmiStreatTest.Enabled = false;
                tsmiissueLicense.Visible = false;
                if (int.TryParse(dgv.SelectedRows[0].Cells["PassedTests"].Value.ToString(), out int PassedTest))
                {

                    switch (PassedTest)
                    {
                        case 1:
                            tsmiVisonTest.Enabled = false;
                            tsmiwritenTest.Enabled = true;
                            break;

                        case 2:
                            tsmiVisonTest.Enabled = false;
                            tsmiStreatTest.Enabled = true;
                            break;

                        case 3:
                            tsmiSechduleTest.Enabled = false;
                            tsmiissueLicense.Visible = (dgv.SelectedRows[0].Cells["Status"].Value.ToString() == "New") ? true : false;
                            break;
                    }
                }
            }
        }

        private void pbAddNew_Click(object sender, EventArgs e)
        {
            frmAddLocalOrder frm = new frmAddLocalOrder(); 
                frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
            int PersonID = Convert.ToInt32(dgv.SelectedRows[0].Cells["PersonID"].Value);
            frmTakeTests frm = new frmTakeTests(Models.eTestTypes.VisionTest, PersonID, OrderID);
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
            int PersonID = Convert.ToInt32(dgv.SelectedRows[0].Cells["PersonID"].Value);
            frmTakeTests frm = new frmTakeTests(Models.eTestTypes.WrittenTest, PersonID, OrderID);
            frm.Show();
        }

        private void driveTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
            int PersonID = Convert.ToInt32(dgv.SelectedRows[0].Cells["PersonID"].Value); 
            frmTakeTests frm = new frmTakeTests(Models.eTestTypes.StreetTest, PersonID, OrderID);
            frm.Show();
        }

        private void tsmiissueLicense_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
            frmIssueLocalLicense frm = new frmIssueLocalLicense(OrderID);
            frm.Show();        }
    }
}
