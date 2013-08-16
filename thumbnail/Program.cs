using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using thumbnail.forms;

namespace thumbnail
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frm_login login = new frm_login();
            scann frmscann = new scann();

            DialogResult loginresult = login.ShowDialog();
            if (loginresult == DialogResult.OK)
            {                
                frmscann.ShowDialog();
            }
        }
    }
}
