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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsForms.Forms.frm_Application.frm_TestTypes
{
    public partial class frmTestTypes : frmBaseCRUD
    {
        public frmTestTypes()
        {
            InitializeComponent();
            dgv.ContextMenuStrip = cms;
            FiltersVisibility = false;
            dgv.MultiSelect = false;

            DataTable dtTestTypes = new DataTable();
            clsApplicationManager.GetTestTypes(dtTestTypes);
            View = dtTestTypes.DefaultView;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            string TestType = dgv.SelectedRows[0].Cells[1].Value.ToString();
            int Fees = Convert.ToInt32(dgv.SelectedRows[0].Cells[2].Value);

            frmUpdateTestType frm = new frmUpdateTestType(ID, TestType, Fees);

            frm.UpdatedTestType += (string UTestType, int UFees) =>
            {
                switch (clsApplicationManager.UpdateTestType(ID, UTestType, UFees))
                {
                    case Models.eResult.Success:
                        dgv.SelectedRows[0].Cells[1].Value = UTestType;
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