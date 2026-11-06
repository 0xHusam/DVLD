using Business;
using Business.GlobalData;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            clsTables.Initialize();

            Application.Run(new frmLogin());

            //clsUserManager.FindByID(1, out clsUser user);
            //Application.Run(new frmMain(user));

        }
    }
}
