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

namespace WindowsForms.Forms.frm_Application.LicensingServiceOrders
{
    public partial class frmIssueLocalLicense : Form
    {
        int OrderID;
        public frmIssueLocalLicense(int OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
            clsApplicationManager.GetLicenseServiceFee(out int Fee, Models.eLicenseServices.IssueLocalLicense);
            lblFee.Text = Fee.ToString();
            lblCreatedByUser.Text = frmMain.LoginUser.UserName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetRestrictionsFromChkBoxes()
        {
            int Restrictions = 0;

            if (chkCorrectiveLenses.Checked)
                Restrictions = Restrictions | 1;

            if (chkHearingAid.Checked)
                Restrictions = Restrictions | 2;

            if (chkAutomaticTransmission.Checked)
                Restrictions = Restrictions | 4;

            if (chkSpecialVehicleEquipment.Checked)
                Restrictions = Restrictions | 8;

            if (chkDaytimeDrivingOnly.Checked)
                Restrictions = Restrictions | 16;

            if (chkProstheticLimbs.Checked)
                Restrictions = Restrictions | 32;

            return Restrictions;
        }


        private void btnSate_Click(object sender, EventArgs e)
        {
            if(clsApplicationManager.IssueNewLocalLicense(OrderID, GetRestrictionsFromChkBoxes()) == Models.eResult.Success)
            {
                MessageBox.Show("مبرووووك الرخصة");
            }
            else
            {
                MessageBox.Show("There Are An Eror! :(");
            }

            this.Close();
        }
    }
}
