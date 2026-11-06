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
    public partial class frmAddLocalOrder : Form
    {
        public frmAddLocalOrder()
        {
            InitializeComponent();
        }
        int ServiceFee;
        private void frmAddLocalOrder_Load(object sender, EventArgs e)
        {
            DataTable dtLicenseTypes = new DataTable();
            clsApplicationManager.GetLicenseTable(dtLicenseTypes);

            cbLicenseTypes.DisplayMember = "Type";
            cbLicenseTypes.ValueMember = "ID";
            cbLicenseTypes.DataSource = dtLicenseTypes;

            lblCrytedBy.Text = frmMain.LoginUser.UserName;
            clsApplicationManager.GetLicenseServiceFee(out ServiceFee, eLicenseServices.IssueLocalLicense);
            lblServiceFee.Text = ServiceFee.ToString();
        }

        private void cbLicenseTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cbLicenseTypes.SelectedValue);
            clsApplicationManager.GetLicenseByID(ID, out clsLicenseType licenseType);
            ctrl_ShowLicense1.LoadLicense(licenseType);
        }

        private void btnCansel_MouseEnter(object sender, EventArgs e)
        {
            btnCansel.BackColor = Color.Red;
        }

        private void btnCansel_MouseLeave(object sender, EventArgs e)
        {
            btnCansel.BackColor = Color.White;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlFindPersonAndShowInfo1.Person == null)
            { 
                MessageBox.Show("You Must Choice A Person!");
                return;
            }
            clsPerson person = ctrlFindPersonAndShowInfo1.Person;
            DateTime PersonDate = person.DateOfBirth;
            int RestrictionAge = ctrl_ShowLicense1.licenseType.AgeRestrication;
            DateTime RestrictionDate = DateTime.Today.AddYears( -RestrictionAge );

            if (PersonDate > RestrictionDate)
            {
                MessageBox.Show("Person Age Is Under The Ligal Age!");
                return;
            }

            clsLicenseType licenseType = ctrl_ShowLicense1.licenseType;
            eLicenseTypes eLicenseType = (eLicenseTypes)licenseType.ID;

            eResult result = clsApplicationManager.InsertLicenseServiceOrder
                (
                person.PersonID,
                frmMain.LoginUser.PersonID,
                Convert.ToInt32(eLicenseServices.IssueLocalLicense),
                licenseType.ID,
                ServiceFee,
                clsApplicationManager.GenerateServiceDescription(eLicenseServices.IssueLocalLicense, eLicenseType)
                );

            if (result == eResult.Success)
            {
                MessageBox.Show("Order Just Have Added Successfuly :)");
                clsdtIssueLocalLicenses.FillDtIssueLocalLicenses();
            }
            else
            {
                MessageBox.Show("Error!\nMake sure you are not working on a previous request.");
            }
        }
    }
}
