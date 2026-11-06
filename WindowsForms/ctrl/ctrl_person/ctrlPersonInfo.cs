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
using WindowsForms.Helpers;

namespace WindowsForms
{
    public partial class ctrlPersonInfo : UserControl
    {
        private int _OriginNameLocationX;
        public ctrlPersonInfo()
        {
            InitializeComponent();
            _OriginNameLocationX = lblname.Location.X;
        }
        private clsPerson _person;
        public void ShowInfo(clsPerson person)
        {
            this._person = person;
            lblPersonID.Text = _person.PersonID.ToString();

            lblname.Text = _person.GetFullName();
            int NameLocationX = _OriginNameLocationX - lblname.Size.Width / 2;
            lblname.Location = new Point(NameLocationX, lblname.Location.Y);

            lblNationalNO.Text = _person.NationalID.ToString();
            lblGendor.Text = clsPersonHelper.GetGendor(_person.Gender);
            pbGendor.Image = clsPersonHelper.GetGendorImage(_person.Gender);
            
            lblAdress.Text = _person.Address;
            lblDateOfBirth.Text = _person.DateOfBirth.ToShortDateString();
            lblEmail.Text = _person.Email;

            lblPhone.Text = _person.Phone;
            lblCountry.Text = _person.Country;
            pbPersonImage.Image = clsPersonHelper.GetPersonImage(_person);
        }
    }
}
