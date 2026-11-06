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

namespace WindowsForms
{

    public partial class frmPeopleCRUD : BaseCRUD.frmBaseCRUD
    {
        public frmPeopleCRUD()
        {
            InitializeComponent();
        }
        private void frmPeople_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1280, 720);
            View = clsdtPeople.dtPeople.DefaultView;
            dgv.ContextMenuStrip = cms;
        }

        private void Details_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgv.SelectedRows[0].Cells["PersonID"].Value);
            clsPersonManager.FindByID(PersonID, out clsPerson person);

            frmPersonDetails frm = new frmPersonDetails(person);
            frm.ShowDialog();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgv.SelectedRows[0].Cells["PersonID"].Value);
            clsPersonManager.FindByID(PersonID, out clsPerson person);

            frmAddUpdatePerson frm = new frmAddUpdatePerson(person);
            frm.ShowDialog();
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
            }
            else if (dgv.SelectedRows.Count == 1)
            {
                cms.Items["tsmiShowDetails"].Enabled = true;
                cms.Items["tsmiDelete"].Enabled = true;
                cms.Items["tsmiUpdate"].Enabled = true;
                cms.Items["tsmiSendEmail"].Enabled = true;
                cms.Items["tsmiAddNew"].Enabled = true;
            }
            else
            {
                cms.Items["tsmiShowDetails"].Enabled = false;
                cms.Items["tsmiDelete"].Enabled = true;
                cms.Items["tsmiUpdate"].Enabled = false;
                cms.Items["tsmiSendEmail"].Enabled = true;
                cms.Items["tsmiAddNew"].Enabled = true;
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete\nthe selected person({dgv.SelectedRows.Count})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    int PersonID = Convert.ToInt32(row.Cells["PersonID"].Value);
                    eResult DeleteResult = clsPersonManager.Delete(PersonID);

                    if (DeleteResult != eResult.Success)
                        MessageBox.Show($"Failed to delete person with ID: {PersonID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
