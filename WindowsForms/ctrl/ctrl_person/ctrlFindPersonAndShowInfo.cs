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

namespace WindowsForms.ctrl.ctrl_person
{
    public partial class ctrlFindPersonAndShowInfo : UserControl
    {
        public clsPerson Person = null;
        public ctrlFindPersonAndShowInfo()
        {
            InitializeComponent();
        }

        private void OnFindPerson(clsPerson person)
        {
            ctrlPersonInfo1.ShowInfo(person);
            Person = person;
        }
    }
}
