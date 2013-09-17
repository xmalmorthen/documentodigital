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
using scanndoc.Properties;

namespace scanndoc.forms
{
    public partial class frm_bloquear_desbloquear_tramite : Form
    {
        public frm_bloquear_desbloquear_tramite()
        {
            InitializeComponent();
        }

        List<data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult> tramites;
        private void match_registros()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                tlp_proc.Visible = true;

                Application.DoEvents();

                tramites = new List<data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult>(Program.Bd_Exp_Transportes.pa_ReferenciaExpedientesparaBloquearDesbloquear());

                BindingSource.DataSource = tramites;

                formatear_celda();
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_aceptar_Click(null, null);
        }

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma bloquear el trámite","Bloquear", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                bloquear_desbloquear(0);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_desbloquear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma desbloquear el trámite", "Bloquear", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                bloquear_desbloquear(1);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int Id_Ma_Digital = (BindingSource.Current as data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult).id;
            string tramite = (BindingSource.Current as data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult).tramite;
            string valor_trazable = (BindingSource.Current as data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult).valor_trazable;

            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();
            
            frm_deshacer_tramite_view frm;
            frm = new frm_deshacer_tramite_view(Id_Ma_Digital, valor_trazable, tramite);

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
            
            frm.btn_deshacer.Visible = false;
            
            DialogResult result = frm.ShowDialog(this);
            switch (result)
            {
                case DialogResult.Yes:
                    bloquear_desbloquear(0);      
                break;
                case DialogResult.No:
                    bloquear_desbloquear(1);
                break;
            }
        }

        private void bloquear_desbloquear(int accion)
        { 
            try
            {
                int Id_Ma_Digital = (BindingSource.Current as data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult).id;
                data_members.ma_digital registro = Program.Bd_Exp_Transportes.ma_digital.Single(query => query.id == Id_Ma_Digital);

                if (accion == 0)
                {
                    registro.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "bloqueado").id;
                    registro.fecha_hora_bloqueo = Program.Bd_Exp_Transportes.ExecuteQuery<DateTime>("SELECT GETDATE()").First();
                    Program.Bd_Exp_Transportes.SubmitChanges();
                    MessageBox.Show("Trámite bloqueado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    registro.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "desbloqueado").id;
                    registro.fecha_hora_bloqueo = null;
                    Program.Bd_Exp_Transportes.SubmitChanges();
                    MessageBox.Show("Trámite desbloqueado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                match_registros();
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void formatear_celda()
        {
            DataGridViewCellStyle styleblock = new DataGridViewCellStyle();
            styleblock.BackColor = Settings.Default.CampoBloqueado_RowColorGrid;
            styleblock.ForeColor = Color.Black;

            DataGridViewCellStyle styleunblock = new DataGridViewCellStyle();
            styleunblock.BackColor = Settings.Default.CampoDesbloqueado_RowColorGrid;
            styleunblock.ForeColor = Color.Black;

            DataGridViewCellStyle styleschedule = new DataGridViewCellStyle();
            styleschedule.BackColor = Settings.Default.CampoPlanBloqueo_RowColorGrid;
            styleschedule.ForeColor = Color.Black;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["estatusDataGridViewTextBoxColumn"].Value.ToString().ToLower() == "bloqueado")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style = styleblock;
                    }
                }
                else if (row.Cells["estatusDataGridViewTextBoxColumn"].Value.ToString().ToLower() == "desbloqueado")
                {
                    if (row.Cells["fechahorabloqueoDataGridViewTextBoxColumn"].Value != null)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Style = styleschedule;
                        }
                    }
                    else
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Style = styleunblock;
                        }
                    }
                }
            }
        }

        private void bloquear_desbloquear_tramite_Paint(object sender, PaintEventArgs e)
        {
            this.Paint -= bloquear_desbloquear_tramite_Paint;
            match_registros();
        }

        private void bloquear_desbloquear_tramite_Load(object sender, EventArgs e)
        {
            rectangleShape1.BackColor = Settings.Default.CampoBloqueado_RowColorGrid;
            rectangleShape2.BackColor = Settings.Default.CampoDesbloqueado_RowColorGrid;
            rectangleShape3.BackColor = Settings.Default.CampoPlanBloqueo_RowColorGrid;
        }

        string estatus = null;
        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            estatus = ( BindingSource.Current as data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult).estatus.ToString().ToLower();

            btn_bloquear.Visible = estatus == "desbloqueado" ? true : false;
            btn_desbloquear.Visible = estatus == "bloqueado" ? true : false;

            if (estatus == "desbloqueado")
            {
                Boolean conplan = (BindingSource.Current as data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult).fecha_hora_bloqueo == null ? false : true;
                btn_eliminaplan.Visible = conplan;
                btn_planbloqueo.Visible = !conplan;
            }
            else {
                btn_eliminaplan.Visible = false;
                btn_planbloqueo.Visible = false;
            }
        }

        private void cntmnu_Opening(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(estatus))
            {
                opcmnubloquear.Visible = estatus == "desbloqueado" ? true : false;
                opcmnudesbloquear.Visible = estatus == "bloqueado" ? true : false;

                if (estatus == "desbloqueado")
                {
                    Boolean conplan = (BindingSource.Current as data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult).fecha_hora_bloqueo == null ? false : true;
                    opcmnueliminarplan.Visible = conplan;
                    opcmnuplanbloqueo.Visible = !conplan;
                }
                else
                {
                    opcmnueliminarplan.Visible = false;
                    opcmnuplanbloqueo.Visible = false;
                    toolStripMenuItem1.Visible = false;
                }
            }
            else {
                opcmnubloquear.Visible = false;
                opcmnudesbloquear.Visible = false;
                toolStripMenuItem1.Visible = false;
                opcmnuplanbloqueo.Visible = false;
                opcmnueliminarplan.Visible = false;
            }
        }

        private void txt_buscar_EditValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            try
            {
                List<scanndoc.data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult> valores = (from query in tramites
                                                                                 where query.valor_trazable.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
                                                                                 select query).ToList();
                BindingSource.DataSource = valores;
                dataGridView.Update();
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }

            formatear_celda();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;        
        }

        private void btn_planbloqueo_Click(object sender, EventArgs e)
        {
            frm_tramiteplanbloqueo frm = new frm_tramiteplanbloqueo();
            
            DialogResult result = frm.ShowDialog(this);

            switch (result)
            {
                case DialogResult.OK:
                    estableceplan(calculafechahorabloqueo(Convert.ToInt32(frm.spinEdit_dias.Value), Convert.ToInt32(frm.spinEdit_horas.Value)));
                break;
                case DialogResult.Yes:
                    estableceplan((DateTime)frm.dateEdit.EditValue);
                break;
            }

        }

        private DateTime calculafechahorabloqueo(int no_dias_bloqueo, int no_horas_bloqueo)
        {
            DateTime fechahora = DateTime.Now;
            try
            {
                fechahora = Program.Bd_Exp_Transportes.ExecuteQuery<DateTime>("SELECT GETDATE()").First();

                fechahora = fechahora.AddDays(Convert.ToDouble(no_dias_bloqueo));
                fechahora = fechahora.AddHours(Convert.ToDouble(no_horas_bloqueo));
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }

            return fechahora;
        }

        private void estableceplan(DateTime fechabloqueo) {
            try
            {
                int Id_Ma_Digital = (BindingSource.Current as data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult).id;
                data_members.ma_digital registro = Program.Bd_Exp_Transportes.ma_digital.Single(query => query.id == Id_Ma_Digital);

                registro.fecha_hora_bloqueo = fechabloqueo;
                Program.Bd_Exp_Transportes.SubmitChanges();
                MessageBox.Show("Plan de bloqueo establecido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                match_registros();
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void btn_eliminaplan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma eliminar el plan de bloqueo", "Eliminar plan de bloqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                eliminarplandebloqueo();
            }
        }

        private void eliminarplandebloqueo()
        {
            try
            {
                int Id_Ma_Digital = (BindingSource.Current as data_members.pa_ReferenciaExpedientesparaBloquearDesbloquearResult).id;
                data_members.ma_digital registro = Program.Bd_Exp_Transportes.ma_digital.Single(query => query.id == Id_Ma_Digital);

                registro.fecha_hora_bloqueo = null;
                Program.Bd_Exp_Transportes.SubmitChanges();
                MessageBox.Show("Plan de bloqueo eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                match_registros();
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }
    }
}
