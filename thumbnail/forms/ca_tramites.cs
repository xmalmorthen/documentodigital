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
    public partial class ca_tramites : Form
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
            dxValidationProvider.RemoveControlError(descripcionTextEdit);
        }

        //funcion para 
        private void enabledisablecontrols()
        {
            /*
             * botonera
             */
            //agregar
            btn_Agregar.Enabled = Form_Mode == form_mode.normal ? true : false;
            //editar
            btn_Editar.Enabled = Form_Mode == form_mode.normal ? true : false;
            //limpiar
            btn_Limpiar.Enabled = ( Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar ) ? true : false;
            //cancelar
            btn_cancelar.Enabled = ( Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar ) ? true : false;
            //guardar
            btn_guardar.Enabled = ( Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar ) ? true : false;
            //eliminar
            btn_eliminar.Enabled = Form_Mode == form_mode.normal ? true : false;
            
            checkEdit1.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            lookUpEdit_ClasificacionDocumento.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            descripcionTextEdit.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            textEdit1.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            textEdit3.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            textEdit4.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            descripcionMemoEdit.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            btn_plus.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;

            //limpiar controles
            if (Form_Mode == form_mode.agregar ) limpiar_controles();

            /*
             * grid de datos
             */ 
            //buscar
            txt_buscar.Enabled = Form_Mode == form_mode.normal ? true : false;
            //refrescar
            btn_refrescar.Enabled = Form_Mode == form_mode.normal ? true : false;
            //grid de datos
            datagridview.Enabled = Form_Mode == form_mode.normal ? true : false;
            //navigator
            bindingnavigator.Enabled = Form_Mode == form_mode.normal ? true : false;
        }

        //lista con contenido de los registros
        private List<data_members.ca_tramites> lista;
        private data_members.ca_tramites catalogo;

        public ca_tramites()
        {
            InitializeComponent();
        }

        private void actualiza_lista() {
            try
            {
                scanndoc.models.RefreshDataBase.UpdateContent();

                lista = Program.Bd_Expedientes_Digitales.GetTable<data_members.ca_tramites>().ToList();
                bindingsource.DataSource = lista;
                tlp_noregistros.Visible = (bindingsource.Count == 0);
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }
        }

        private void obten_clasificacion_de_tramites() {
            try
            {
                lookUpEdit_ClasificacionDocumento.Properties.DataSource = Program.Bd_Expedientes_Digitales.GetTable<data_members.ca_clasificaciontramites>().ToList();
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }
        }

        private void ca_template_Load(object sender, EventArgs e)
        {
            actualiza_lista();
            obten_clasificacion_de_tramites();
            Form_Mode = form_mode.normal;
        }

        //limpiar controles
        private void limpiar_controles()
        {
            try 
	        {
                bindingsource.CancelEdit();
                bindingsource.AddNew();
                (bindingsource.Current as data_members.ca_tramites).id_estatus = 1;
                lookUpEdit_ClasificacionDocumento.EditValue = 0;
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
            bindingsource.AddNew();

            Form_Mode = form_mode.agregar;

            //limpiar_controles();
            lookUpEdit_ClasificacionDocumento.Focus();
        }

        //boton editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Form_Mode = form_mode.editar;
            catalogo = (data_members.ca_tramites)bindingsource.Current;
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            catalogo = null;
            bindingsource.CancelEdit();
            Form_Mode = form_mode.normal;

            actualiza_lista();
        }

        //boton de limpiar
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar_controles(); //limpiar controles
            lookUpEdit_ClasificacionDocumento.Focus();
        }

        //boton de eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Eliminar registro","Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes) {
                Form_Mode = form_mode.eliminar;
                eliminar_registro();
                Form_Mode = form_mode.normal;
                actualiza_lista();
            }            
        }

        //boton de guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //mandar a diferente flujo dependiendo el modo de la forma
            switch (Form_Mode)
            {
                case form_mode.agregar:
                    agregar_registro();
                    break;
                case form_mode.editar:
                    editar_registro();
                    break;
            }
            txt_buscar.EditValueChanged -= new EventHandler(txt_buscar_EditValueChanged);
            txt_buscar.Text = "";
            txt_buscar.EditValueChanged += new EventHandler(txt_buscar_EditValueChanged);
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
                List<scanndoc.data_members.ca_tramites> valores = (from query in lista
                                                                    where query.Nombre.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
                                                                    select query).ToList();
                bindingsource.DataSource = valores;
                datagridview.Update();
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

            actualiza_lista();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        //agregar
        private void agregar_registro()
        {
            try 
	        {
                if (bindingsource.DataSource != null) {
                    catalogo = (data_members.ca_tramites)bindingsource.Current;
                    catalogo.id_ClasificacionTramite = (int)lookUpEdit_ClasificacionDocumento.EditValue;

                    if (valida())
                    {
                        if (!buscar_si_existe())
                        {
                            Program.Bd_Expedientes_Digitales.ca_tramites.InsertOnSubmit(catalogo);
                            Program.Bd_Expedientes_Digitales.SubmitChanges();
                            Form_Mode = form_mode.normal;
                            actualiza_lista();
                            MessageBox.Show("Registro agregado con éxito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            descripcionTextEdit.SelectAll();
                            descripcionTextEdit.Focus();
                        }
                    }
	            }
            }
            catch (Exception err)
	        {
                scanndoc.classes.errorlogs.seterror(err);
	        }            
        }

        private bool valida()
        {
            dxValidationProvider.RemoveControlError(descripcionTextEdit);
            dxValidationProvider.Validate(); //lanzar validacion
            if (dxValidationProvider.GetInvalidControls().Count() != 0) return false;
            return true;
        }

        private bool buscar_si_existe()
        {
            try
            {
                data_members.ca_tramites filtro = Program.Bd_Expedientes_Digitales.ca_tramites.SingleOrDefault(query => query.Nombre.ToString().ToLower() == catalogo.Nombre.ToString().ToLower());
                if (filtro != null)
                {
                    MessageBox.Show("El registro ya se encuentra", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                return false;
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }
            return true;
        }

        //editar
        private void editar_registro()
        {
            if (bindingsource.DataSource != null) {
                try 
	            {
                    if (valida())
                    {
                        //if (!buscar_si_existe())
                        //{
                            Program.Bd_Expedientes_Digitales.SubmitChanges();
                            Form_Mode = form_mode.normal;
                            actualiza_lista();
                            MessageBox.Show("Registro modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                    }
	            }
                catch (Exception err)
                {
                    scanndoc.classes.errorlogs.seterror(err);
                }
            }            
        }
                
        //eliminar
        private void eliminar_registro()
        {
            try
            {
                if (bindingsource.DataSource != null)
                {
                    catalogo = (data_members.ca_tramites)bindingsource.Current;
                    Program.Bd_Expedientes_Digitales.ca_tramites.DeleteOnSubmit(catalogo);
                    Program.Bd_Expedientes_Digitales.SubmitChanges();
                    MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }
        }

        private void bindingsource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (bindingsource.Count > 0)
                {
                    if ((bindingsource.Current as data_members.ca_tramites).ca_estatus != null)
                    {
                        if ((bindingsource.Current as data_members.ca_tramites).ca_estatus.Descripcion.ToString().ToUpper() == "ACTIVO")
                        {
                            checkEdit1.Checked = true;
                        }
                        else
                        {
                            checkEdit1.Checked = false;
                        }
                    }
                    if (bindingsource.Current != null)
                    {
                        lookUpEdit_ClasificacionDocumento.EditValue = (bindingsource.Current as data_members.ca_tramites).id_ClasificacionTramite;
                    }
                }
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            scanndoc.forms.ca_clasificaciontramites frm = new forms.ca_clasificaciontramites(true);

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                obten_clasificacion_de_tramites();
                selecciona_ultima_clasificacion();
            }

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void selecciona_ultima_clasificacion()
        {
            try
            {
                lookUpEdit_ClasificacionDocumento.EditValue = Program.Bd_Expedientes_Digitales.ca_clasificaciontramites.OrderByDescending(p => p.id).FirstOrDefault().id;
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }
        }
    }
}
