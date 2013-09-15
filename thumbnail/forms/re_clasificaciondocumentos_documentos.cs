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
    public partial class re_clasificaciondocumentos_documentos : Form
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
                delete_validation_sumary();
            }
        }

        private void delete_validation_sumary()
        {
            dxValidationProvider.RemoveControlError(lookUpEdit_Documentos);
        }

        //lista con contenido de los registros
        private List<data_members.ca_clasificaciondocumentos> lista_clasificaciondocumentos;
        private List<data_members.ca_origenes> lista_origenes;
        private List<data_members.pa_DocumentosNoEnlazadosporClasificacionDocumentoResult> lista_documentos;
        private List<data_members.pa_DocumentosporClasificacionDocumentoResult> documentos;
        private data_members.re_clasificaciondocumentos_documentos catalogo;

        public re_clasificaciondocumentos_documentos()
        {
            InitializeComponent();
        }

        private void actualiza_lista_clasificaciondocumentos()
        {
            try
            {
                lista_clasificaciondocumentos = Program.Bd_Exp_Transportes.GetTable<data_members.ca_clasificaciondocumentos>().ToList();
                bindingsource_ca_clasificaciondocumentos.DataSource = lista_clasificaciondocumentos;
            }
            catch (Exception)
            {
            }
        }

        private void actualiza_lista_origenes() { 
            try
            {
                lista_origenes = Program.Bd_Exp_Transportes.GetTable<data_members.ca_origenes>().ToList();
                bindingsource_origen.DataSource = lista_origenes;
            }
            catch (Exception)
            {
            }
            
        }


        struct struct_orden
        {
            private short _orden;
            public short orden { get { return _orden; } set { _orden = value; } }
        }
        private void obten_listaorden()
        {
            List<struct_orden> orden = new List<struct_orden>();
            for (short i = 0; i < bindingsource.Count+1; i++)
			{
                struct_orden ord = new struct_orden();
                ord.orden = i;
			    orden.Add (ord); 
			}
            bindingsource_Orden.DataSource = orden;
            colorden.DataSource = bindingsource_Orden;
            colorden.DisplayMember = "orden";
            colorden.ValueMember = "orden";
        }

        private void actualiza_lista_documentos(int? id_clasificaciondocumento)
        {
            try
            {
                lista_documentos = Program.Bd_Exp_Transportes.pa_DocumentosNoEnlazadosporClasificacionDocumento(id_clasificaciondocumento).ToList();
                bindingSource_documentos.DataSource = lista_documentos;
            }
            catch (Exception)
            {
            }
        }

        private void actualiza_re_clasificaciondocumentos_documentos(int? id_clasificaciondocumento)
        {
            try
            {
                documentos = Program.Bd_Exp_Transportes.pa_DocumentosporClasificacionDocumento(id_clasificaciondocumento).ToList();
                bindingsource.DataSource = documentos;
            }
            catch (Exception)
            {
            }
        }

        private void re_clasificaciondocumentos_documentos_Load(object sender, EventArgs e)
        {
            try 
	        {
                actualiza_lista_clasificaciondocumentos();
                actualiza_lista_origenes();
	        }
	        catch (Exception)
	        {		
		        throw;
	        }            
            Form_Mode = form_mode.agregar;
        }

        //limpiar controles
        private void limpiar_controles()
        {
            try 
	        {
                lookUpEdit_Documentos.EditValue = null;
                gridLookUpEdit1.EditValue = null;
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
                List<scanndoc.data_members.ca_clasificaciondocumentos> valores = (from query in lista_clasificaciondocumentos
                                                                    where query.Descripcion.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
                                                                    select query).ToList();
                bindingsource_ca_clasificaciondocumentos.DataSource = valores;
                datagridview.Update();
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

            actualiza_lista_clasificaciondocumentos();

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
                    data_members.re_clasificaciondocumentos_documentos item = new data_members.re_clasificaciondocumentos_documentos();

                    item.id_clasificaciondocumento = (bindingsource_ca_clasificaciondocumentos.Current as data_members.ca_clasificaciondocumentos).id;
                    item.id_documento = (int)lookUpEdit_Documentos.EditValue;
                    item.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "activo").id;
                    item.obligatorio = true;
                    item.id_origen = (int)gridLookUpEdit1.EditValue;

                    try
                    {
                        item.orden = Convert.ToInt16(Program.Bd_Exp_Transportes.re_clasificaciondocumentos_documentos.OrderByDescending(order => order.orden).FirstOrDefault(
                                    query => query.id_clasificaciondocumento == item.id_clasificaciondocumento
                                    && query.id_origen == item.id_origen
                                    ).orden + 1);
                    }
                    catch (Exception)
                    {
                        item.orden = 1;                        
                    }                    
                    
                    Program.Bd_Exp_Transportes.re_clasificaciondocumentos_documentos.InsertOnSubmit(item);
                    Program.Bd_Exp_Transportes.SubmitChanges();

                    limpiar_controles();
                    MessageBox.Show("Registro agregado con éxito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
	        {		
		        throw;
	        }
            bindingsource_CurrentItemChanged(null, null);            
        }

        private bool valida()
        {
            delete_validation_sumary();
            dxValidationProvider.Validate(); //lanzar validacion
            if (dxValidationProvider.GetInvalidControls().Count() != 0) return false;
            return true;
        }
        
        private void bindingsource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                actualiza_lista_documentos((bindingsource_ca_clasificaciondocumentos.Current as data_members.ca_clasificaciondocumentos).id);
                actualiza_re_clasificaciondocumentos_documentos((bindingsource_ca_clasificaciondocumentos.Current as data_members.ca_clasificaciondocumentos).id);
            }
            catch (Exception)
            {
                actualiza_re_clasificaciondocumentos_documentos(0);
            }
        }

        //buscar en grid de campos trazables
        private void txt_buscardocumento_EditValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            try
            {
                List<scanndoc.data_members.pa_DocumentosporClasificacionDocumentoResult> valores = (from query in documentos
                                                                                              where query.Nombre.ToString().ToLower().Contains(txt_buscardocumento.Text.ToString().ToLower())
                                                                                              select query).ToList();
                bindingsource.DataSource = valores;
                dataGridViewCamposTrazables.Update();
            }
            catch (Exception)
            {
            }

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;    
        }
        
        //boton eliminar en grid
        private void btn_EliminarDocumento_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            if (MessageBox.Show(this, "Eliminar documento", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
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
                int id = (bindingsource.Current as data_members.pa_DocumentosporClasificacionDocumentoResult).id_re_clasificaciondocumento_documento;
                data_members.re_clasificaciondocumentos_documentos item = Program.Bd_Exp_Transportes.re_clasificaciondocumentos_documentos.SingleOrDefault(query => query.id == id);

                if (item != null)
                {
                    Program.Bd_Exp_Transportes.pa_ordenaporborrado(item.id);
                    MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "El documento está en uso", "Imposible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bindingsource_CurrentItemChanged(null, null);
        }
        
        private void dataGridViewCamposTrazables_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCamposTrazables.IsCurrentCellInEditMode)
            {
                this.Cursor = Cursors.WaitCursor;
                tlp_proc.Visible = true;

                Application.DoEvents();

                try
                {
                    int new_valorden = int.Parse(dataGridViewCamposTrazables.Rows[e.RowIndex].Cells["colorden"].Value.ToString());
                    int id_re_clasificaciondocumentos_documentos =  (bindingsource.Current as data_members.pa_DocumentosporClasificacionDocumentoResult).id_re_clasificaciondocumento_documento;
                    if (val_ordenantiguo == new_valorden) {
                        data_members.re_clasificaciondocumentos_documentos item = Program.Bd_Exp_Transportes.re_clasificaciondocumentos_documentos.SingleOrDefault(
                            query => query.id == id_re_clasificaciondocumentos_documentos);
                        //activo
                        int newvalue_activo = dataGridViewCamposTrazables.Rows[e.RowIndex].Cells["estatus"].Value == null ? 0 : 1;
                        if (newvalue_activo == 0)
                            item.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "inactivo").id;
                        else
                            item.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "activo").id;

                        //obligatorio
                        Boolean newvalue_obligatorio = Convert.ToBoolean(dataGridViewCamposTrazables.Rows[e.RowIndex].Cells["obligatorio"].Value);
                        item.obligatorio = newvalue_obligatorio;

                        Program.Bd_Exp_Transportes.SubmitChanges();

                        //origen
                        int newvalue_origen = int.Parse(dataGridViewCamposTrazables.Rows[e.RowIndex].Cells["origen"].Value.ToString());
                        if (val_origen != newvalue_origen)
                        {
                            Program.Bd_Exp_Transportes.pa_ordenaporcambiodeorigen(
                                (bindingsource_ca_clasificaciondocumentos.Current as data_members.ca_clasificaciondocumentos).id, 
                                val_origen, 
                                val_ordenantiguo, 
                                newvalue_origen);
                        }                       

                    } else {
                        int id_clasificaciondocumentos = (bindingsource_ca_clasificaciondocumentos.Current as data_members.ca_clasificaciondocumentos).id;
                        if (val_ordenantiguo > new_valorden)
                        {
                            Program.Bd_Exp_Transportes.pa_ordenaporordenmenor(
                                (bindingsource_ca_clasificaciondocumentos.Current as data_members.ca_clasificaciondocumentos).id,
                                val_origen,
                                new_valorden,
                                val_ordenantiguo);
                        }
                        else {
                            Program.Bd_Exp_Transportes.pa_ordenaporordenmayor(
                                (bindingsource_ca_clasificaciondocumentos.Current as data_members.ca_clasificaciondocumentos).id,
                                val_origen,
                                val_ordenantiguo,
                                new_valorden);
                        }   
                    }
                }
                catch (Exception)
                {
                }
                actualiza_re_clasificaciondocumentos_documentos((bindingsource_ca_clasificaciondocumentos.Current as data_members.ca_clasificaciondocumentos).id);

                txt_buscardocumento.Text = "";

                Application.DoEvents();

                tlp_proc.Visible = false;
                this.Cursor = Cursors.Default; 
            }
        }

        private void bindingsource_CurrentItemChanged_1(object sender, EventArgs e)
        {
            obten_listaorden();
        }

        int val_ordenantiguo;
        int ?val_origen;
        private void dataGridViewCamposTrazables_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {            
            try
            {
                val_ordenantiguo = int.Parse(dataGridViewCamposTrazables.Rows[e.RowIndex].Cells["colorden"].Value.ToString());
                val_origen = int.Parse(dataGridViewCamposTrazables.Rows[e.RowIndex].Cells["origen"].Value.ToString());
            }
            catch (Exception)
            {
                val_origen = null;
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            actualiza_re_clasificaciondocumentos_documentos((bindingsource_ca_clasificaciondocumentos.Current as data_members.ca_clasificaciondocumentos).id);

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default; 
        }

    }
}
