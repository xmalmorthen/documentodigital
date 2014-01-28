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
    public partial class re_expedientes_tramites : Form
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
        private List<data_members.ca_expedientes> lista_expedientes;
        private List<data_members.pa_TramitesNoEnlazadosporExpedienteResult> lista_tramites;
        private List<data_members.pa_TramitesporExpedienteResult> tramitesclasificados;
        private data_members.re_expedientes_tramites catalogo;

        public re_expedientes_tramites()
        {
            InitializeComponent();
        }

        private void actualiza_lista_expedientes()
        {
            try
            {
                lista_expedientes = Program.Bd_Expedientes_Digitales.GetTable<data_members.ca_expedientes>().ToList();
                bindingsource_ca_expedientes.DataSource = lista_expedientes;
                tlp_noregistros.Visible = (bindingsource_ca_expedientes.Count == 0);
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void actualiza_lista_tramites(int? id_expediente)
        {
            try
            {
                lista_tramites = Program.Bd_Expedientes_Digitales.pa_TramitesNoEnlazadosporExpediente(id_expediente).ToList();
                bindingsource_ca_tramites.DataSource = lista_tramites;
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void actualiza_re_expedientes_tramites(int? id_expediente)
        {
            try
            {
                tramitesclasificados = Program.Bd_Expedientes_Digitales.pa_TramitesporExpediente(id_expediente).ToList();
                bindingsource.DataSource = tramitesclasificados;

                txt_buscarcampotrazable.Text = "";
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void re_expedientes_tramites_Load(object sender, EventArgs e)
        {
            actualiza_lista_expedientes();
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
                List<scanndoc.data_members.ca_expedientes> valores = (from query in lista_expedientes
                                                                    where query.Descripcion.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
                                                                    select query).ToList();
                bindingsource_ca_expedientes.DataSource = valores;
                datagridview.Update();

                if (valores.Count == 0)
                    actualiza_re_expedientes_tramites(0);
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
                    data_members.re_expedientes_tramites item = new data_members.re_expedientes_tramites();

                    item.id_expediente = (bindingsource_ca_expedientes.Current as data_members.ca_expedientes).id;
                    item.id_tramite = (int)lookUpEdit.EditValue;

                    Program.Bd_Expedientes_Digitales.re_expedientes_tramites.InsertOnSubmit(item);
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
                actualiza_lista_tramites((bindingsource_ca_expedientes.Current as data_members.ca_expedientes).id);
                actualiza_re_expedientes_tramites((bindingsource_ca_expedientes.Current as data_members.ca_expedientes).id);
            }
            catch (Exception)
            {
                actualiza_re_expedientes_tramites(0);
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
                List<scanndoc.data_members.pa_TramitesporExpedienteResult> valores = (from query in tramitesclasificados
                                                                                      where query.Nombre.ToString().ToLower().Contains(txt_buscarcampotrazable.Text.ToString().ToLower())
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

            if (MessageBox.Show(this, "Eliminar relación del trámite con el expediente", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
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
                int id = (bindingsource.Current as data_members.pa_TramitesporExpedienteResult).id;
                data_members.re_expedientes_tramites item = Program.Bd_Expedientes_Digitales.re_expedientes_tramites.SingleOrDefault(query => query.id == id);

                if (item != null)
                {
                    Program.Bd_Expedientes_Digitales.re_expedientes_tramites.DeleteOnSubmit(item);
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
