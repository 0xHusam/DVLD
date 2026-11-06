using BaseCRUD;
using Business.ModelsManger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Forms.frm_Application.frm_ApplicationTypes;

namespace WindowsForms.Forms.frm_Application
{
    public partial class frmApplicationTypes : frmBaseCRUD
    {
        public frmApplicationTypes()
        {
            InitializeComponent();
            dgv.ContextMenuStrip = cms;
            FiltersVisibility = false;
            dgv.MultiSelect = false;

            DataTable dtApplicationTypes = new DataTable();
            clsApplicationManager.GetApplicationTypes(dtApplicationTypes);
            View = dtApplicationTypes.DefaultView;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            string ApplicationType = dgv.SelectedRows[0].Cells[1].Value.ToString();
            int Fees = Convert.ToInt32(dgv.SelectedRows[0].Cells[2].Value);

            frmUpdateApplicationType frm = new frmUpdateApplicationType(ID, ApplicationType, Fees);

            frm.UpdatedApplicationType += (string UApplicationType, int UFees) =>
            {
                switch (clsApplicationManager.UpdateApplicationType(ID, UApplicationType, UFees))
                {
                    case Models.eResult.Success:
                    dgv.SelectedRows[0].Cells[1].Value = UApplicationType;
                    dgv.SelectedRows[0].Cells[2].Value = UFees;
                    MessageBox.Show("Updatet Successfuly :)");
                    break;

                    case Models.eResult.NotFound:
                        MessageBox.Show("Not Found :(");
                        break;

                    case Models.eResult.Error:
                        MessageBox.Show("Faild To Update :(");
                        break;
                }

                    
            };

            frm.ShowDialog();


        }
    }
}
