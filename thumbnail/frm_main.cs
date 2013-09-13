using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using thumbnail.data_members;
using thumbnail.models;

namespace thumbnail
{
    public partial class frm_main : Form
    {
        List<pa_Permsos_ModulosResult> modulos;

        public frm_main()
        {
            InitializeComponent();
        }

        public void Inicializa()
        {
            configura_opciones_de_menu();
        }

        private void cambiaropcionesmenu(ToolStripItemCollection colOpcionesMenu)
        {
            // recorrer el submenú
            foreach (ToolStripItem itmOpcion in colOpcionesMenu)
            {
                itmOpcion.Visible = true;

                // si es una opción de menú normal...
                if (itmOpcion.GetType() == typeof(ToolStripMenuItem))
                {
                    string[] tags;
                    try
                    {
                        tags = ((string)itmOpcion.Tag).Split(',');
                    }
                    catch (Exception)
                    {
                        tags = null;
                    }

                    Boolean encontrado;
                    if (tags != null)
                    {
                        encontrado = modulos.Find(c => c.id_menu == int.Parse(tags[0]) && c.id_submenu == int.Parse(tags[1])) == null ? false : true;
                        if (!encontrado) itmOpcion.Visible = false;
                    }

                    if (((ToolStripMenuItem)itmOpcion).DropDownItems.Count > 0)
                    {
                        this.cambiaropcionesmenu(((ToolStripMenuItem)itmOpcion).DropDownItems);
                    }
                }
            }
        }

        private void configura_opciones_de_menu()
        {
            modulos = Program.Bd_Exp_Transportes.pa_Permsos_Modulos(Usuario.Logeado.id).ToList();

            // recorrer las opciones del menú
            foreach (ToolStripMenuItem mnuitOpcion in this.mnustrip_menuprincipal.Items)
            {
                mnuitOpcion.Visible = true;

                string[] tags;
                try
                {
                    tags = ((string)mnuitOpcion.Tag).Split(',');                    
                }
                catch (Exception)
                {
                    tags = null;
                }

                Boolean encontrado = true;
                if (tags != null)
                {
                    encontrado = modulos.Find(c => c.id_menu == int.Parse(tags[0])) == null ? false : true;
                    if (!encontrado) mnuitOpcion.Visible = false;
                }

                if ((encontrado == true) && (mnuitOpcion.DropDownItems.Count > 0))
                {
                    this.cambiaropcionesmenu(mnuitOpcion.DropDownItems);
                }
            }
            this.mnustrip_menuprincipal.Refresh();
        }

        private void registroYSeguimientoDeTramiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.frm_scann scann = new forms.frm_scann(modulos.Find(c => c.Modulo.ToString().ToLower() == "blquear/desbloquear") == null ? false : true);

            scann.MdiParent = this;
            scann.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void expedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.ca_expedientes frm = new forms.ca_expedientes();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void camposTrazablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.ca_campostrazables frm = new forms.ca_campostrazables();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void clasificaciñonDeTramitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.ca_clasificaciontramites frm = new forms.ca_clasificaciontramites();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void tramitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.ca_tramites frm = new forms.ca_tramites();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void asignarCamposTrazablesAUnExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.re_expedientes_campostrazables frm = new forms.re_expedientes_campostrazables();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;            
        }

        private void clasificaciónDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.ca_clasificaciondocumentos frm = new forms.ca_clasificaciondocumentos();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
            
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.ca_documentos frm = new forms.ca_documentos();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void clasificarDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.re_clasificaciondocumentos_documentos frm = new forms.re_clasificaciondocumentos_documentos();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
            
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.re_tramites_clasificaciondocumentos frm = new forms.re_tramites_clasificaciondocumentos();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.ca_usuarios frm = new forms.ca_usuarios();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;           
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.ca_roles frm = new forms.ca_roles();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
            
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            thumbnail.forms.frm_deshacer_tramite frm = new forms.frm_deshacer_tramite();
            frm.MdiParent = this;
            frm.Show();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

    }
}
