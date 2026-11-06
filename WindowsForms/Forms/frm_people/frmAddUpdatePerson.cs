using Business;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void PersonSavedEventHandler(clsPerson person);
        public event PersonSavedEventHandler PersonSaved;

        public frmAddUpdatePerson(clsPerson person)
        {
            InitializeComponent();
            ctrlAddUpdatePerson1.LoadPerson(person);
            this.Text = "Update Person";
        }

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            this.Text = "Add IssueLocalLicense Person";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsPerson person = ctrlAddUpdatePerson1.GetPerson();

            if (person != null && clsPersonManager.Save(person) == eResult.Success)
            {
                PersonSaved?.Invoke(person);
                ctrlAddUpdatePerson1.SetLblID(person.PersonID);
                MessageBox.Show("Person saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save person. Please check the details and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
