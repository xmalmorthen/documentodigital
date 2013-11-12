using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using scanndoc.forms;

namespace scanndoc
{
    static class Program
    {
        public static scanndoc.data_members.Bd_Expedientes_DigitalesDataContext Bd_Expedientes_Digitales;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frm_main());

            //Bd_Expedientes_Digitales = new data_members.Bd_Expedientes_DigitalesDataContext();

            frm_login login = new frm_login();
            frm_main main = new frm_main();

            DialogResult loginresult = login.ShowDialog();
            if (loginresult == DialogResult.OK)
            {
                main.Inicializa();
                main.ShowDialog();
            }
            
        }
    }
}
