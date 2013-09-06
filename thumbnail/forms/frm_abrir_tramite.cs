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

        //enumeracion para el estado del formulario
        public enum form_mode
        {
            normal,
            contenidobusqueda
        }

        //property para el control del estado del formulario
        private form_mode _formmode;
        public form_mode Form_Mode
        {
            get { return _formmode; }
            set
            {
                _formmode = value;
                enabledisablecontrols();
                delete_validation_sumary();
            }
        }

        private void delete_validation_sumary()
        {
            dxValidationProvider.RemoveControlError(txt);
        }

        //funcion para 
        private void enabledisablecontrols()
        {
            /*
             * botonera
             */
            //aceptar
            btn_aceptar.Enabled = (Form_Mode == form_mode.contenidobusqueda) ? true : false;
            //cancelar
            //btn_cancelar.Enabled = (Form_Mode == form_mode.contenidobusqueda) ? true : false;

            pa_ReferenciaExpedientesporValorTrazableResultBindingNavigator.Enabled = (Form_Mode == form_mode.contenidobusqueda) ? true : false;
            dataGridView.Enabled = (Form_Mode == form_mode.contenidobusqueda) ? true : false;
        }

        public frm_abrir_tramite()
        {
            InitializeComponent();
            Form_Mode = form_mode.normal;
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
            delete_validation_sumary();
            dxValidationProvider.Validate(); //lanzar validacion
            if (dxValidationProvider.GetInvalidControls().Count() != 0) return false;

            return true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {          
            try
            {
                if (!valida()) return;

                match_registros();

                if (tramites == null || tramites.Count == 0)
                {
                    MessageBox.Show("No se encontró trámite para ese valor trazable", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tramites.Count == 1)
                {
                    btn_aceptar_Click(null, null);
                } 
                else
                {
                    Form_Mode = form_mode.contenidobusqueda;
                    dataGridView.Focus();
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

                pa_ReferenciaExpedientesporValorTrazableResultBindingSource.DataSource = tramites;
            }
            catch (Exception)
            {
            }
            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            valid = true;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            pa_ReferenciaExpedientesporValorTrazableResultBindingSource.DataSource = null;
            Form_Mode = form_mode.normal;
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_aceptar_Click(null, null);
        }
        
    }
}
