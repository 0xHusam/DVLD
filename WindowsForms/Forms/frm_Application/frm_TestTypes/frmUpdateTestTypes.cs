using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Forms.frm_Application;
using static System.Windows.Forms.DataGrid;

namespace WindowsForms.Forms.frm_Application
{
    public partial class frmUpdateTestType : Form
    {

        public event Action<string, int> UpdatedTestType;
        public frmUpdateTestType(int ID, string TestType, int Fees)
        {
            InitializeComponent();
            lblID.Text = ID.ToString();
            txtTestType.Text = TestType;
            nudFees.Value = Fees;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string TestType = txtTestType.Text;
            int Fees = Convert.ToInt32(nudFees.Value);

            UpdatedTestType?.Invoke(TestType, Fees);
            this.Close();
        }
    }
}
