using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using thumbnail.forms;

namespace thumbnail
{
    static class Program
    {
        public static thumbnail.data_members.Bd_Exp_TransportesDataContext Bd_Exp_Transportes;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frm_main());

            //Bd_Exp_Transportes = new data_members.Bd_Exp_TransportesDataContext();

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
