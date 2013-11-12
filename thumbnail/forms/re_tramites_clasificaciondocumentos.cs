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
    public partial class re_tramites_clasificaciondocumentos : Form
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
            dxValidationProvider.RemoveControlError(lookUpEdit);
        }

        //funcion para 
        private void enabledisablecontrols()
        {
        }

        //lista con contenido de los registros
        private List<data_members.ca_tramites> lista_tramites;
        private List<data_members.pa_ClasificacionDocumentosNoEnlazadosporTramiteResult> lista_clasificaciondocumentos;
        private List<data_members.pa_ClasificacionDocumentosporTramiteResult> documentosclasificados;
        private data_members.re_tramites_clasificaciondocumentos catalogo;

        public re_tramites_clasificaciondocumentos()
        {
            InitializeComponent();
        }

        private void actualiza_lista_tramites()
        {
            try
            {
                lista_tramites = Program.Bd_Expedientes_Digitales.GetTable<data_members.ca_tramites>().ToList();
                bindingsource_ca_tramites.DataSource = lista_tramites;
                tlp_noregistros.Visible = (bindingsource.Count == 0);
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void actualiza_lista_clasificaciondocumentos(int? id_tramite)
        {
            try
            {
                lista_clasificaciondocumentos = Program.Bd_Expedientes_Digitales.pa_ClasificacionDocumentosNoEnlazadosporTramite(id_tramite).ToList();
                bindingsource_ca_clasificaciondocumentos.DataSource = lista_clasificaciondocumentos;
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void actualiza_re_tramites_clasificaciondocumentos(int? id_tramite)
        {
            try
            {
                documentosclasificados = Program.Bd_Expedientes_Digitales.pa_ClasificacionDocumentosporTramite(id_tramite).ToList();
                bindingsource.DataSource = documentosclasificados;

                txt_buscarcampotrazable.Text = "";
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void re_expedientes_campostrazables_Load(object sender, EventArgs e)
        {
            actualiza_lista_tramites();
            Form_Mode = form_mode.agregar;
        }

        //limpiar controles
        private void limpiar_controles()
        {
            try 
	        {
                lookUpEdit.EditValue = null;
                txt_buscarcampotrazable.Text = "";
	        }
	        catch (Exception err)
	        {
                scanndoc.classes.errorlogs.seterror(err);
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
                List<scanndoc.data_members.ca_tramites> valores = (from query in lista_tramites
                                                                    where query.Descripcion.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
                                                                    select query).ToList();
                bindingsource_ca_tramites.DataSource = valores;
                datagridview.Update();

                if (valores.Count == 0)
                    actualiza_re_tramites_clasificaciondocumentos(0);
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
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

            actualiza_lista_tramites();

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
                    data_members.re_tramites_clasificaciondocumentos item = new data_members.re_tramites_clasificaciondocumentos();

                    item.id_tramie = (bindingsource_ca_tramites.Current as data_members.ca_tramites).id;
                    item.id_clasificaciondocumento = (int)lookUpEdit.EditValue;

                    Program.Bd_Expedientes_Digitales.re_tramites_clasificaciondocumentos.InsertOnSubmit(item);
                    Program.Bd_Expedientes_Digitales.SubmitChanges();

                    limpiar_controles();
                    MessageBox.Show("Registro agregado con éxito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
	        {
                scanndoc.classes.errorlogs.seterror(e);
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
                actualiza_lista_clasificaciondocumentos((bindingsource_ca_tramites.Current as data_members.ca_tramites).id);
                actualiza_re_tramites_clasificaciondocumentos((bindingsource_ca_tramites.Current as data_members.ca_tramites).id);
            }
            catch (Exception)
            {
                actualiza_re_tramites_clasificaciondocumentos(0);
            }
        }
        
        //buscar en grid de detalle
        private void txt_buscarcampotrazable_EditValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            try
            {
                List<scanndoc.data_members.pa_ClasificacionDocumentosporTramiteResult> valores = (from query in documentosclasificados
                                                                                                   where query.Descripcion.ToString().ToLower().Contains(txt_buscarcampotrazable.Text.ToString().ToLower())
                                                                                                   select query).ToList();
                bindingsource.DataSource = valores;
                dataGridView2.Update();
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;    
        }
        
        //boton eliminar en grid
        private void btn_EliminarCampo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            if (MessageBox.Show(this, "Eliminar clasificación de documentos", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
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
                int id = (bindingsource.Current as data_members.pa_ClasificacionDocumentosporTramiteResult).id;
                data_members.re_tramites_clasificaciondocumentos item = Program.Bd_Expedientes_Digitales.re_tramites_clasificaciondocumentos.SingleOrDefault(query => query.id == id);

                if (item != null)
                {
                    Program.Bd_Expedientes_Digitales.re_tramites_clasificaciondocumentos.DeleteOnSubmit(item);
                    Program.Bd_Expedientes_Digitales.SubmitChanges();
                    MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
            bindingsource_CurrentItemChanged(null, null);
        }
        
    }
}
