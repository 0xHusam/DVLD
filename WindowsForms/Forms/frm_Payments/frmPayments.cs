using BaseCRUD;
using Business.GlobalData;
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

namespace WindowsForms.Forms.frm_users.frm_Payments
{
    public partial class frmPayments : frmBaseCRUD
    {
        public frmPayments()
        {
            InitializeComponent();
            if(clsdtPayment.FillDtPayment() != Models.eResult.Success)
            {
                MessageBox.Show("!");
            }
            View = clsdtPayment.dtPayment.DefaultView;
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {

        }
    }
}
