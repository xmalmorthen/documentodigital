﻿using System;
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

            thumbnail.forms.frm_scann scann = new forms.frm_scann();
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
    }
}
