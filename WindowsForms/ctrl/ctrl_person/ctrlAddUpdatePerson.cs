using Business;
using Business.GlobalData;
using Business.ModelsManger;
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
using WindowsForms.Helpers;
using WindowsForms.Properties;

namespace WindowsForms
{
    public partial class ctrlAddUpdatePerson : UserControl
    {
        private void HandelOptionalTextBox(TextBox textBox, string txt)
        {
            if ( !string.IsNullOrWhiteSpace(txt))
            {
                textBox.Text = txt;
                textBox.ForeColor = Color.Black;
            }
            else
            {
                textBox.Text = "(Optional)";
                textBox.ForeColor = Color.Gray;
            }
        }
        private void FillControlsFromPerson(clsPerson person)
        {
            if (File.Exists(person.PicturePath))
            {
                pbPersonImage.ImageLocation = person.PicturePath;
                pbPersonImage.Load();
                lnkRemove.Visible = true;
            }
            lblPersonID.Text = person.PersonID.ToString();
            txtNationalID.Text = person.NationalID.ToString();
            txtFirstName.Text = person.FirstName;
            HandelOptionalTextBox(txtSecondName, person.SecondName);
            HandelOptionalTextBox(txtThirdName, person.ThirdName);
            txtLastName.Text = person.LastName;
            dtbDateOfBirth.Value = person.DateOfBirth;
            rbFemale.Checked = person.Gender == 'F';
            rbMale
                .Checked = person.Gender == 'M';
            txtAddress.Text = person.Address;
            txtPhone.Text = person.Phone;
            HandelOptionalTextBox(txtEmail, person.Email);
            cbCountries.SelectedValue = person.CountryID;
        }
        private clsPerson _Person = null;
        public ctrlAddUpdatePerson()
        {
            InitializeComponent();

        }

        public void LoadPerson(clsPerson person)
        {
            _Person = person;


            FillControlsFromPerson(person);
        }

        private void PreparecbCountries()
        {
            cbCountries.DataSource = clsdtCountries.dtCountries;
            cbCountries.DisplayMember = "Name";
            cbCountries.ValueMember = "ID";
            cbCountries.SelectedValue = (_Person == null)? 150 : _Person.CountryID;
        }

        private void ctrlAddUpdatePersonInfo_Load(object sender, EventArgs e)
        {
            if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            {
                return;
            }

            try
            {
                PreparecbCountries();
        }
            catch
            { }

            dtbDateOfBirth.MaxDate = DateTime.Now;
        }

        private void Optional_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.ForeColor == Color.Gray)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }

        private void Optional_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length == 0)
            {
                textBox.Text = "(Optional)";
                textBox.ForeColor = Color.Gray;
            }
        }

        private void rbGendor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbGendor = (RadioButton)sender;

            if (rbGendor.Checked)
            {
                Image image = clsPersonHelper.GetGendorImage(rbFemale.Checked);
                pbGendor.Image = image;

                if (string.IsNullOrWhiteSpace(pbPersonImage.ImageLocation))
                    pbPersonImage.Image = image;
            }
        }

        private void lnkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select a Person Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = openFileDialog.FileName;
                pbPersonImage.Load();

                lnkRemove.Visible = true;
            }
        }

        private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = string.Empty;
            pbPersonImage.Image = clsPersonHelper.GetGendorImage(rbFemale.Checked);
            lnkRemove.Visible = false;
        }

        private void txtNationalID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalID.Text) || txtNationalID.Text == _Person?.NationalID.ToString())
                return;

            if ( clsPersonManager.IsExistByNationalID( Convert.ToInt32( txtNationalID.Text.Trim() ) ) == eResult.Success )
                errorProvider1.SetError(txtNationalID, "This National ID already exists.");
            else
                errorProvider1.SetError(txtNationalID, "");
        }

        private bool CheckRequiredFields()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtNationalID, "National ID is required.");
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtFirstName, "First Name is required.");
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtLastName, "Last Name is required.");
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtAddress, "Address is required.");
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtPhone, "Phone is required.");
            }

            return isValid;
        }

        public clsPerson GetPerson()
        {
            if (!CheckRequiredFields())
                return null;

            return new clsPerson
                (
                (_Person != null)? _Person.PersonID : -1,
                Convert.ToInt32(txtNationalID.Text.Trim()),
                txtFirstName.Text.Trim(),
                txtSecondName.ForeColor == Color.Gray ? string.Empty : txtSecondName.Text.Trim(),
                txtThirdName.ForeColor == Color.Gray ? string.Empty : txtThirdName.Text.Trim(),
                txtLastName.Text.Trim(),
                dtbDateOfBirth.Value,
                (rbFemale.Checked) ? 'F' : 'M',
                txtAddress.Text.Trim(),
                txtPhone.Text.Trim(),
                txtEmail.ForeColor == Color.Gray ? string.Empty : txtEmail.Text.Trim(),
                cbCountries.SelectedItem.ToString(),
                Convert.ToInt32(cbCountries.SelectedValue),
                pbPersonImage.ImageLocation
            );
            
        }

        public void SetLblID(int ID)
        {
            lblPersonID.Text = ID.ToString();
        }

        private void SetErorProvider_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if ( !string.IsNullOrWhiteSpace(textBox.Text) )
            {
                errorProvider1.SetError(textBox, "");
            }
        }
    }
}
