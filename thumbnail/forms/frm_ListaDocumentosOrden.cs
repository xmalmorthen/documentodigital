using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scanndoc.forms
{
    public partial class frm_listadocumentosorden : Form
    {
        int tramite {get; set;}
        int origen {get; set;}

        public frm_listadocumentosorden()
        {
            InitializeComponent();
        }

        public void inicializa(int Tramite, int Origen) {
            try
            {
                tramite = Tramite;
                origen = Origen;
                this.bindingsource.DataSource = Program.Bd_Exp_Transportes.pa_ObtenerDocumentosporTramiteyOrigen(tramite, origen).ToList(); //obtener la lista de documentos por tramite y origen
                pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.DataSource = bindingsource;
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
            this.Paint += new PaintEventHandler(frm_ListaDocumentosOrden_Paint);
        }

        void frm_ListaDocumentosOrden_Paint(object sender, PaintEventArgs e)
        {            
            this.Paint -= new PaintEventHandler(frm_ListaDocumentosOrden_Paint);
            try
            {
                Point loc = new Point(((Form)this.Owner).ParentForm.Width - (this.Width + 40), ((Form)this.Owner).ParentForm.Height - (this.Height + 40));
                this.Location = loc;
            }
            catch (Exception err)
            {
                /*no debe llevar nada*/
            }

            this.Owner = null;
        }

        private void frm_ListaDocumentosOrden_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void frm_ListaDocumentosOrden_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0.40;
        }

        private void frm_ListaDocumentosOrden_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
