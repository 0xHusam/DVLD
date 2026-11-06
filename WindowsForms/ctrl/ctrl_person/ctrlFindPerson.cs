using Business;
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

namespace WindowsForms
{
    public partial class ctrlFindPerson : UserControl
    {
        public delegate void OnFindPerson(clsPerson person);
        public event OnFindPerson FindPerson;

        private void _OnFindPerson(clsPerson person)
        {
            FindPerson?.Invoke(person);
        }

        private delegate bool WhenKeyPressedHandler(char c);
        private WhenKeyPressedHandler _whenKeyPressed;
        public ctrlFindPerson()
        {
            InitializeComponent();
            cb.SelectedIndex = 0;
        }
        private bool KeyPressIntegers(char c)
        {
            return (char.IsDigit(c) || char.IsControl(c)) ? true : false;
        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedIndex == 0) _whenKeyPressed = KeyPressIntegers;
            else if (cb.SelectedIndex == 1) _whenKeyPressed = null;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_whenKeyPressed != null)
                e.Handled = !_whenKeyPressed(e.KeyChar);
        }

        private void pbFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt.Text)) return;

            clsPerson person = null;

            switch (cb.SelectedIndex)
            {
                case 0:
                    clsPersonManager.FindByID(Convert.ToInt32(txt.Text), out person);
                    break;

                case 1:
                    clsPersonManager.FindByNationalID(Convert.ToInt32(txt.Text), out person);
                    break;
            }

            if (person != null) _OnFindPerson(person);
            else
            {
                MessageBox.Show("Person not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
            }
        }
    }
}
