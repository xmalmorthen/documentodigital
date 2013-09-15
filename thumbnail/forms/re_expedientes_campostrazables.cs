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
    public partial class re_expedientes_campostrazables : Form
    {
        //enumeracion para el control del estado de la forma
        public enum form_mode
        {
            normal,
            agregar,
            editar,
            eliminar,
            guardando,
            guardado
        }

        //property para el manejo del estado de la forma
        private form_mode _frm_mode;
        public form_mode Form_Mode
        {
            get { return _frm_mode; }
            set
            {
                _frm_mode = value;
                enabledisablecontrols();
                delete_validation_sumary();
            }
        }

        private void delete_validation_sumary()
        {
            dxValidationProvider.RemoveControlError(lookUpEdit_CamposTrazables);
        }

        //funcion para 
        private void enabledisablecontrols()
        {
        }

        //lista con contenido de los registros
        private List<data_members.ca_expedientes> lista_expedientes;
        private List<data_members.pa_CampostrazablesNoEnlazadosporExpedienteResult> lista_campostrazables;
        private List<data_members.pa_CampostrazablesporExpedienteResult> campostrazables;
        private data_members.re_expedientes_campostrazables catalogo;

        public re_expedientes_campostrazables()
        {
            InitializeComponent();
        }

        private void actualiza_lista_expedientes() {
            try
            {
                lista_expedientes = Program.Bd_Exp_Transportes.GetTable<data_members.ca_expedientes>().ToList();
                bindingsource_ca_expedientes.DataSource = lista_expedientes;
            }
            catch (Exception)
            {
            }
        }

        private void actualiza_lista_campostrazables(int? id_expediente)
        {
            try
            {
                lista_campostrazables = Program.Bd_Exp_Transportes.pa_CampostrazablesNoEnlazadosporExpediente(id_expediente).ToList();
                bindingSource_campostrazables.DataSource = lista_campostrazables;
            }
            catch (Exception)
            {
            }
        }

        private void actualiza_re_expedientes_campostrazables(int ?id_expediente) {
            try
            {
                campostrazables = Program.Bd_Exp_Transportes.pa_CampostrazablesporExpediente(id_expediente).ToList();
                bindingsource.DataSource = campostrazables;

                txt_buscarcampotrazable.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void re_expedientes_campostrazables_Load(object sender, EventArgs e)
        {
            try 
	        {
                actualiza_lista_expedientes();
	        }
	        catch (Exception)
	        {		
		        throw;
	        }            
            Form_Mode = form_mode.agregar;
            timer.Enabled = true;
        }

        //limpiar controles
        private void limpiar_controles()
        {
            try 
	        {
                bindingsource.CancelEdit();
                bindingsource.AddNew();
                (bindingsource.Current as data_members.re_expedientes_campostrazables).id_estatus = 1;
                lookUpEdit_CamposTrazables.EditValue = 0;
                checkEdit1.Checked = false;
                checkEdit2.Checked = true;
                txt_buscarcampotrazable.Text = "";
	        }
	        catch (Exception)
	        {
		        throw;
	        }
        }

#region botonera
        //boton de agregar
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            agregar_registro();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;            
        }
      
        //boton cerrar
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
#endregion botonera        

        //caja de texto de busqueda
        private void txt_buscar_EditValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            try
            {
                List<scanndoc.data_members.ca_expedientes> valores = (from query in lista_expedientes
                                                                    where query.Descripcion.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
                                                                    select query).ToList();
                bindingsource_ca_expedientes.DataSource = valores;
                datagridview.Update();

                if (valores.Count == 0)
                {
                    timer.Enabled = false;
                    actualiza_re_expedientes_campostrazables(0);
                }
                else {
                    if (!timer.Enabled) timer.Enabled = true;
                }
            }
            catch (Exception)
            {
            }

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;            
        }

        //boton de refrescar lista
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            actualiza_lista_expedientes();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        //agregar
        private void agregar_registro()
        {
            try 
	        {
                if (valida()) {
                    data_members.re_expedientes_campostrazables item = new data_members.re_expedientes_campostrazables();

                    item.id_expediente = (bindingsource_ca_expedientes.Current as data_members.ca_expedientes).id;
                    item.id_campotrazable = (int)lookUpEdit_CamposTrazables.EditValue;

                    if (checkEdit2.Checked)
                    {
                        item.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "activo").id;
                    }
                    else
                    {
                        if (MessageBox.Show(this, "Esta a punto de agregar un campo trazable inactivo, confirma la acción", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            item.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "inactivo").id;
                        }
                        else
                        {
                            return;
                        }
                    }

                    if (!valida_esprincipal())
                    {
                        item.es_principal = checkEdit1.Checked;
                    }
                    else 
                    {
                        MessageBox.Show(this, "Ya se encuentra un campo trazable principal, favor de revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Program.Bd_Exp_Transportes.re_expedientes_campostrazables.InsertOnSubmit(item);
                    Program.Bd_Exp_Transportes.SubmitChanges();

                    checkEdit1.Checked = false;
                    checkEdit2.Checked = true;
                    txt_buscarcampotrazable.Text = "";

                    MessageBox.Show("Registro agregado con éxito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
	        {		
		        throw;
	        }
            lookUpEdit_CamposTrazables.EditValue = null;
            bindingsource_CurrentItemChanged(null, null);            
        }

        private bool valida_esprincipal()
        {
            if (checkEdit1.Checked)
            {
                data_members.re_expedientes_campostrazables item = Program.Bd_Exp_Transportes.re_expedientes_campostrazables.SingleOrDefault(query => query.es_principal == true && query.id_expediente == (bindingsource_ca_expedientes.Current as data_members.ca_expedientes).id);
                if (item != null)
                {
                    return true;
                }
            }
            return false;
        }

        private bool valida()
        {
            delete_validation_sumary();
            dxValidationProvider.Validate(); //lanzar validacion
            if (dxValidationProvider.GetInvalidControls().Count() != 0) return false;
            return true;
        }

        public struct oldspositions
        {
            public int oldbindingsource_ca_expedientes_position;
            public int rowgrid;
        };
        public oldspositions positions; //variable global para los tag de los items
        private void bindingsource_CurrentItemChanged(object sender, EventArgs e)
        {   
            try
            {
                actualiza_lista_campostrazables((bindingsource_ca_expedientes.Current as data_members.ca_expedientes).id);
                actualiza_re_expedientes_campostrazables((bindingsource_ca_expedientes.Current as data_members.ca_expedientes).id);
            }
            catch (Exception)
            {
                actualiza_re_expedientes_campostrazables(0);
            }
        }

        private Boolean valida_existe_campoprincipal()
        {
            foreach (DataGridViewRow row in dataGridViewCamposTrazables.Rows)
            {
                if ((Boolean)row.Cells["esprincipalDataGridViewCheckBoxColumn"].Value == true)
                    return true;
            }
            return false;
        }

        //buscar en grid de campos trazables
        private void txt_buscarcampotrazable_EditValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            try
            {
                List<scanndoc.data_members.pa_CampostrazablesporExpedienteResult> valores = (from query in campostrazables
                                                                                              where query.Nombre.ToString().ToLower().Contains(txt_buscarcampotrazable.Text.ToString().ToLower())
                                                                                              select query).ToList();
                bindingsource.DataSource = valores;
                dataGridViewCamposTrazables.Update();

                if (!string.IsNullOrEmpty(txt_buscarcampotrazable.Text))
                {
                    timer.Enabled = false;
                }
                else {
                    if (!timer.Enabled) timer.Enabled = true;
                }

            }
            catch (Exception)
            {
            }

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;    
        }
        
        //boton eliminar en grid
        private void btn_EliminarCampoTrazable_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            if (MessageBox.Show(this, "Eliminar campo trazable", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                eliminar_registro();    
            }

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
            
        }

        private void eliminar_registro()
        {
            try
            {
                int id = (bindingsource.Current as data_members.pa_CampostrazablesporExpedienteResult).id_re_expedientes_campostrazables;
                data_members.re_expedientes_campostrazables item = Program.Bd_Exp_Transportes.re_expedientes_campostrazables.SingleOrDefault(query => query.id == id);

                if (item != null)
                {
                    Program.Bd_Exp_Transportes.re_expedientes_campostrazables.DeleteOnSubmit(item);
                    Program.Bd_Exp_Transportes.SubmitChanges();
                    MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "El campo trazable está en uso", "Imposible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bindingsource_CurrentItemChanged(null, null);
        }
        
        private void dataGridViewCamposTrazables_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCamposTrazables.IsCurrentCellInEditMode)
            {
                try
                {
                    Boolean newvalue_esprincipal = (Boolean)dataGridViewCamposTrazables.Rows[e.RowIndex].Cells["esprincipalDataGridViewCheckBoxColumn"].Value;
                    int newvalue_avtivo = dataGridViewCamposTrazables.Rows[e.RowIndex].Cells["estatus"].Value == null ? 0 : 1;

                    int id_re_expedientes_campostrazables = (bindingsource.Current as data_members.pa_CampostrazablesporExpedienteResult).id_re_expedientes_campostrazables;

                    data_members.re_expedientes_campostrazables item = Program.Bd_Exp_Transportes.re_expedientes_campostrazables.SingleOrDefault(
                        query => query.id == id_re_expedientes_campostrazables);

                    if (newvalue_esprincipal == false)
                        item.es_principal = false;
                    else
                    {
                        if (!valida_esprincipal_engrid(e.RowIndex))
                        {
                            item.es_principal = true;
                        }
                        else {
                            dataGridViewCamposTrazables.Rows[e.RowIndex].Cells["esprincipalDataGridViewCheckBoxColumn"].Value = false;
                        }                        
                    }
                    if (newvalue_avtivo == 0)
                        item.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "inactivo").id;
                    else
                        item.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "activo").id;
                    Program.Bd_Exp_Transportes.SubmitChanges();
                }
                catch (Exception)
                {
                }
            }
        }

        private bool valida_esprincipal_engrid(int ignore_row)
        {
            data_members.re_expedientes_campostrazables item = Program.Bd_Exp_Transportes.re_expedientes_campostrazables.SingleOrDefault(query => query.es_principal == true && query.id_expediente == (bindingsource_ca_expedientes.Current as data_members.ca_expedientes).id);
            if (item != null)
            {
                MessageBox.Show(this, "Ya se encuentra un campo trazable principal, favor de revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            try
            {
                Boolean result = valida_existe_campoprincipal();
                if (datagridview.Enabled != result)
                {
                    datagridview.Enabled = result;
                    bindingNavigator_ca_expedientes.Enabled = result;
                    btn_refrescar.Enabled = result;
                    txt_buscar.Enabled = result;
                    btn_cerrar.Enabled = result;
                    tlp_warning.Visible = !result;
                }
            }
            catch (Exception)
            {
            }
            timer.Enabled = true;
        }

        private void re_expedientes_campostrazables_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
       
    }
}
