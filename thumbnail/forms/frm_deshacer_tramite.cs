using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scanndoc.classes;
using System.Collections;
using scanndoc.models;

namespace scanndoc.forms
{
    public partial class frm_deshacer_tramite : Form
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
            btn_ver.Enabled = (Form_Mode == form_mode.contenidobusqueda) ? true : false;
            //bloquear
            btn_bloquear.Enabled = (Form_Mode == form_mode.contenidobusqueda) ? true : false;
            pa_ReferenciaExpedientesporValorTrazableResultBindingNavigator.Enabled = (Form_Mode == form_mode.contenidobusqueda) ? true : false;
            dataGridView.Enabled = (Form_Mode == form_mode.contenidobusqueda) ? true : false;
        }

        public frm_deshacer_tramite()
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
                    MessageBox.Show("No se encontró trámite", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Form_Mode = form_mode.contenidobusqueda;
                    dataGridView.Focus();
                }                
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }
        }

        List<data_members.pa_ReferenciaExpedientesporValorTrazableparaDeshacerResult> tramites;
        private void match_registros()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                tlp_proc.Visible = true;

                Application.DoEvents();

                tramites = new List<data_members.pa_ReferenciaExpedientesporValorTrazableparaDeshacerResult>(Program.Bd_Exp_Transportes.pa_ReferenciaExpedientesporValorTrazableparaDeshacer(txt.Text.ToString().ToLower()));

                pa_ReferenciaExpedientesporValorTrazableResultBindingSource.DataSource = tramites;
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
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

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma deshacer el trámite","Deshacer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                deshacertramite();
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int Id_Ma_Digital = (pa_ReferenciaExpedientesporValorTrazableResultBindingSource.Current as data_members.pa_ReferenciaExpedientesporValorTrazableparaDeshacerResult).id_ma_digital;
            string tramite = (pa_ReferenciaExpedientesporValorTrazableResultBindingSource.Current as data_members.pa_ReferenciaExpedientesporValorTrazableparaDeshacerResult).tramite;

            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();
            
            frm_deshacer_tramite_view frm;
            frm = new frm_deshacer_tramite_view(Id_Ma_Digital, txt.Text, tramite);

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;

            DialogResult result = frm.ShowDialog(this);
            switch (result)
            {
                case DialogResult.Yes:
                    deshacertramite();      
                break;
            }
        }

        private void deshacertramite() { 
            try
            {
                int Id_Ma_Digital = (pa_ReferenciaExpedientesporValorTrazableResultBindingSource.Current as data_members.pa_ReferenciaExpedientesporValorTrazableparaDeshacerResult).id_ma_digital;
                data_members.ma_digital registro = Program.Bd_Exp_Transportes.ma_digital.Single(query => query.id == Id_Ma_Digital);
                registro.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "desechado").id;
                Program.Bd_Exp_Transportes.SubmitChanges();
                MessageBox.Show("Trámite deshecho", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_limpiar_Click(null, null);
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_aceptar_Click(null, null);
        }

        private void txt_EditValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btn_buscar;
        }

        private void dataGridView_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btn_ver;
        }
    }
}
