using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using thumbnail.classes;
using System.Collections;
using thumbnail.models;

namespace thumbnail.forms
{
    public partial class frm_abrir_tramite : Form
    {
        Boolean valid = false;

        public frm_abrir_tramite()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valid)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private bool valida()
        {
            dxValidationProvider.RemoveControlError(txt);
            dxValidationProvider.Validate(); //lanzar validacion
            if (dxValidationProvider.GetInvalidControls().Count() != 0) return false;

            return true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {          
            try
            {
                if (!valida()) return;

                match_registros();

                if (tramites == null || tramites.Count == 0)
                {
                    MessageBox.Show("No se encontró trámite para ese valor trazable", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tramites.Count > 1)
                {
                    MessageBox.Show("Se encontró más de un trámite para ese valor trazable", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Se encontró un trámite para ese valor trazable", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception)
            {                
            }
        }

        List<data_members.pa_ReferenciaExpedientesporValorTrazableResult> tramites;
        private void match_registros()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                tlp_proc.Visible = true;

                Application.DoEvents();

                tramites = new List<data_members.pa_ReferenciaExpedientesporValorTrazableResult>(Program.Bd_Exp_Transportes.pa_ReferenciaExpedientesporValorTrazable(txt.Text.ToString().ToLower()));
            }
            catch (Exception)
            {
            }
            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }
        
    }
}
