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
    public partial class frmPersonDetails : Form
    {
        private clsPerson _person;
        public frmPersonDetails(clsPerson person)
        {
            InitializeComponent();
            _person = person;
            ctrlPersonInfo1.ShowInfo(person);
        }

        private void lnkUpdatePerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_person);
            frm.PersonSaved += ctrlPersonInfo1.ShowInfo;
            frm.ShowDialog();
        }
    }
}
