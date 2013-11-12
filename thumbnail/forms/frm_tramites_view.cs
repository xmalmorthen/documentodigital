using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scanndoc.data_members;

namespace scanndoc.forms
{
    public partial class frm_tramites_view : Form
    {
        private int id_tramite { get; set; }
        public frm_tramites_view(int id_tramite)
        {
            InitializeComponent();
            this.id_tramite = id_tramite;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_tramites_view_Paint(object sender, PaintEventArgs e)
        {
            this.Paint -= frm_tramites_view_Paint;

            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            try
            {
                bindingsource.DataSource = Program.Bd_Expedientes_Digitales.ca_tramites.Single(query => query.id == id_tramite);
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }
            

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }
    }
}
