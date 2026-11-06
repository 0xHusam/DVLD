using BaseCRUD;
using Business;
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
using WindowsForms.Helpers;

namespace WindowsForms
{
    public partial class frmUsersCRUD : frmBaseCRUD
    {
        public frmUsersCRUD()
        {
            InitializeComponent();
        }

        private void frmUsersCRUD_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1280, 720);
            View = clsdtUsers.dtUsers.DefaultView;
            dgv.ContextMenuStrip = cms;
        }

        private int GetID_FromDGV()
        {
            return Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
        }

        private void tsmiActive_Click(object sender, EventArgs e)
        {
            int UserID = GetID_FromDGV();
            clsUserManager.Active(UserID);
        }

        private void tsmiInActive_Click(object sender, EventArgs e)
        {
            int UserID = GetID_FromDGV();
            clsUserManager.Inactive(UserID);
        }

        private void tsmiActiveMode()
        {
            bool Active = (bool)dgv.SelectedRows[0].Cells[8].Value == true;

            if (Active)
            {
                cms.Items["tsmiActive_InActive"].Text = "InActive";
                cms.Items["tsmiActive_InActive"].Click += tsmiInActive_Click;

            }
            else
            { 
            cms.Items["tsmiActive_InActive"].Text = "Active";
            cms.Items["tsmiActive_InActive"].Click += tsmiActive_Click;
            }

        }

        private void cms_Opening(object sender, CancelEventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                cms.Items["tsmiShowDetails"].Enabled = false;
                cms.Items["tsmiDelete"].Enabled = false;
                cms.Items["tsmiUpdate"].Enabled = false;
                cms.Items["tsmiSendEmail"].Enabled = false;
                cms.Items["tsmiAddNew"].Enabled = true;
                cms.Items["tsmiChangePassword"].Enabled = false;
                cms.Items["tsmiActive_InActive"].Visible = false;
            }
            else if (dgv.SelectedRows.Count == 1)
            {
                cms.Items["tsmiShowDetails"].Enabled = true;
                cms.Items["tsmiDelete"].Enabled = true;
                cms.Items["tsmiUpdate"].Enabled = true;
                cms.Items["tsmiSendEmail"].Enabled = true;
                cms.Items["tsmiAddNew"].Enabled = true;
                cms.Items["tsmiChangePassword"].Enabled = true;
                cms.Items["tsmiActive_InActive"].Visible = true;
                tsmiActiveMode();
            }
            else
            {
                cms.Items["tsmiShowDetails"].Enabled = false;
                cms.Items["tsmiDelete"].Enabled = true;
                cms.Items["tsmiUpdate"].Enabled = false;
                cms.Items["tsmiSendEmail"].Enabled = true;
                cms.Items["tsmiAddNew"].Enabled = true;
                cms.Items["tsmiChangePassword"].Enabled = false;
                cms.Items["tsmiActive_InActive"].Visible = false;
            }
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            int UserID = GetID_FromDGV();

            Business.clsUserManager.FindByID(UserID, out Models.clsUser user);

            frmUserDetails frm = new frmUserDetails(user);
            frm.ShowDialog();
        }

        private void tsmiAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            int UserID = GetID_FromDGV();
            clsUserManager.FindByID(UserID, out clsUser user);
            frmAddUpdateUser frm = new frmAddUpdateUser(user);
            frm.ShowDialog();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete\nthe selected U({dgv.SelectedRows.Count})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    int UserID = Convert.ToInt32(row.Cells["ID"].Value);
                    eResult DeleteResult = clsUserManager.DeleteByID(UserID);

                    if (DeleteResult != eResult.Success)
                        MessageBox.Show($"Failed to delete User with ID: {UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            int UserID = GetID_FromDGV();
            clsUserManager.FindByID(UserID, out clsUser user);
            frmChangePassword frm = new frmChangePassword(user);

            frm.ShowDialog();
        }
    }
}
