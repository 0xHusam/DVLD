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

namespace WindowsForms.Forms.frm_Application.LicensingServiceOrders
{
    public partial class frmTakeTests : Form
    {
        private clsTestType testType = null;
        private int PersonID;
        private int OrderID;
        public frmTakeTests(Models.eTestTypes eTest, int PersonID, int OrderID)
        {
            InitializeComponent();
            clsApplicationManager.GetTestType((int)eTest, out testType);
            lblTestID.Text = testType.ID.ToString();
            lblTestType.Text = testType.Type;
            lblTestFee.Text = testType.Fee.ToString();

            this.PersonID = PersonID;
            this.OrderID = OrderID;
            lblPersonID.Text = PersonID.ToString();
            lblOrderID.Text = OrderID.ToString();
            lblDate.Text = DateTime.Today.ToString("yyyy-MMMM-dd");
            lblCreatedByUser.Text = frmMain.LoginUser.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsApplicationManager.InsertTakeTest
                (
                PersonID,
                OrderID,
                testType.ID,
                frmMain.LoginUser.UserID,
                testType.Fee,
                txtNotes.Text,
                clsApplicationManager.GenerateTestDescription((eTestTypes)testType.ID)
                ) == eResult.Success)
                    {
                        MessageBox.Show("Test Compleate Successfuly :)");
                    }
            else
                    {
                        MessageBox.Show("Test Failed To Add :(");
                    }

            this.Close();
        }
    }
}
