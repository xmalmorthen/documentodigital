using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using thumbnail.data_members;

namespace thumbnail.forms
{
    public partial class ca_documentos : Form
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
            dxValidationProvider.RemoveControlError(lookUpEdit1);
            dxValidationProvider.RemoveControlError(lookUpEdit2);

            dxValidationProvider_mascara.RemoveControlError(textEdit1);
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
            btn_Limpiar.Enabled = ( Form_Mode == form_mode.agregar ) ? true : false;
            //cancelar
            btn_cancelar.Enabled = ( Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar ) ? true : false;
            //guardar
            btn_guardar.Enabled = ( Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar ) ? true : false;
            //eliminar
            btn_eliminar.Enabled = Form_Mode == form_mode.normal ? true : false;

            descripcionTextEdit.Enabled = (Form_Mode == form_mode.agregar) ? true : false;
            lookUpEdit1.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            lookUpEdit2.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            spinEdit1.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            spinEdit2.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            checkEdit3.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            checkEdit2.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            spinEdit3.Enabled = false;
            spinEdit4.Enabled = false;
            textEdit1.Enabled = false;
            descripcionMemoEdit.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;

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
        private List<data_members.ca_documentos> lista;
        private data_members.ca_documentos catalogo;

        public ca_documentos()
        {
            InitializeComponent();
        }

        private void actualiza_lista() {
            try
            {
                lista = Program.Bd_Exp_Transportes.GetTable<data_members.ca_documentos>().ToList();
                bindingsource.DataSource = lista;
            }
            catch (Exception)
            {
            }
        }

        private void actualiza_lista_formatos() {
            bindingSource_ca_formatos.DataSource = Program.Bd_Exp_Transportes.GetTable<data_members.ca_formatos>().ToList();
        }

        struct struct_estado
        {
            private int _id;
            public int id { get { return _id; } set { _id = value; } }
            
            private string _descripcion;
            public string descripcion { get { return _descripcion; } set { _descripcion = value; } }

            
        }
        private void obten_estado() {
            List<struct_estado> estados = new List<struct_estado>();

            struct_estado estado = new struct_estado();
            estado.id = 1;
            estado.descripcion = "Original";
            estados.Add(estado);            
            estado = new struct_estado();
            estado.id = 2;
            estado.descripcion = "Copia";
            estados.Add(estado);

            bindingSource_estados.DataSource = estados;
        }

        private void ca_template_Load(object sender, EventArgs e)
        {
            try 
	        {                
                actualiza_lista_formatos();
                obten_estado();
                actualiza_lista();
	        }
	        catch (Exception)
	        {		
		        throw;
	        }            
            Form_Mode = form_mode.normal;
        }

        //limpiar controles
        private void limpiar_controles()
        {
            try 
	        {
                bindingsource.CancelEdit();
                bindingsource.AddNew();                
                lookUpEdit1.EditValue = null;
                lookUpEdit2.EditValue = null;
                spinEdit1.Value = 1;
                spinEdit2.Value = 1;
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
            Form_Mode = form_mode.agregar;
            ((data_members.ca_documentos)bindingsource.Current).No_Caras = 1;
            ((data_members.ca_documentos)bindingsource.Current).No_Hojas = 1;
            ((data_members.ca_documentos)bindingsource.Current).Tiempo_Resguardo = 1;
            ((data_members.ca_documentos)bindingsource.Current).Tamanio_Caracteres_Trazables = 1;
            descripcionTextEdit.Focus();
        }

        //boton editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Form_Mode = form_mode.editar;
            catalogo = (data_members.ca_documentos)bindingsource.Current;
            inicializacontroles();
        }

        private void inicializacontroles()
        {
            checkEdit3_CheckedChanged (null,null);
            checkEdit2_CheckedChanged(null, null);
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            catalogo = null;
            bindingsource.CancelEdit();
            Form_Mode = form_mode.normal;
        }

        //boton de limpiar
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar_controles(); //limpiar controles
            descripcionTextEdit.Focus();
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
                List<thumbnail.data_members.ca_documentos> valores = (from query in lista
                                                                           where query.Nombre.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
                                                                           select query).ToList();
                bindingsource.DataSource = valores;
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
                    catalogo = (data_members.ca_documentos)bindingsource.Current;                    
                    if (valida())
                    {
                        asignavalores();
                        if (!buscar_si_existe())
                        {
                            Program.Bd_Exp_Transportes.ca_documentos.InsertOnSubmit(catalogo);
                            Program.Bd_Exp_Transportes.SubmitChanges();
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
            catch (Exception)
	        {		
		        throw;
	        }
        }

        private void asignavalores()
        {
            catalogo.id_Formato = (int)lookUpEdit1.EditValue;
            catalogo.Estado = Convert.ToInt16((int)lookUpEdit2.EditValue);

            if (!checkEdit3.Checked)
            {
                catalogo.Tiempo_Resguardo = null;
            }
            else {
                catalogo.Tiempo_Resguardo = Convert.ToInt16((int)spinEdit3.Value == 0 ? 1 : (int)spinEdit3.Value);
            }

            if (!checkEdit2.Checked)
            {
                catalogo.Tamanio_Caracteres_Trazables = null;
                catalogo.Mascara_Trazable = "";
            }
            else 
            {
                catalogo.Tamanio_Caracteres_Trazables = Convert.ToInt16((int)spinEdit4.Value == 0 ? 1 : (int)spinEdit3.Value);
                catalogo.Mascara_Trazable = textEdit1.Text;
            }
        }

        private bool valida()
        {
            bool isvalid = true;

            delete_validation_sumary();

            dxValidationProvider.Validate(); //lanzar validacion
            if (dxValidationProvider.GetInvalidControls().Count() != 0) isvalid = false;

            if (checkEdit2.Checked)
            {
                dxValidationProvider_mascara.Validate();
                if (dxValidationProvider_mascara.GetInvalidControls().Count() != 0) isvalid = false;
            }

            return isvalid;
        }

        private bool buscar_si_existe()
        {
            data_members.ca_documentos filtro = Program.Bd_Exp_Transportes.ca_documentos.SingleOrDefault(query => query.Nombre.ToString().ToLower() == catalogo.Nombre.ToString().ToLower());
            if (filtro != null)
            {
                MessageBox.Show("El registro ya se encuentra", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //editar
        private void editar_registro()
        {
            if (bindingsource.DataSource != null) {
                try 
	            {
                    if (valida())
                    {
                        asignavalores();
                        Program.Bd_Exp_Transportes.SubmitChanges();
                        Form_Mode = form_mode.normal;
                        actualiza_lista();
                        MessageBox.Show("Registro modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
	            }
                catch (Exception)
                {
                    throw;
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
                    catalogo = (data_members.ca_documentos)bindingsource.Current;
                    Program.Bd_Exp_Transportes.ca_documentos.DeleteOnSubmit(catalogo);
                    Program.Bd_Exp_Transportes.SubmitChanges();
                    MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bindingsource_CurrentItemChanged(object sender, EventArgs e)
        {
            if ( Form_Mode == form_mode.normal) {
                try
                {
                    lookUpEdit1.EditValue = ((data_members.ca_documentos)bindingsource.Current).id_Formato;
                    lookUpEdit2.EditValue = (int)((data_members.ca_documentos)bindingsource.Current).Estado;
                }
                catch (Exception)
                {
                }
            }
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (Form_Mode != form_mode.normal)
            {
                spinEdit3.Enabled = checkEdit3.Checked;
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (Form_Mode != form_mode.normal)
            {
                spinEdit4.Enabled = checkEdit2.Checked;
                textEdit1.Enabled = checkEdit2.Checked;
            }
        }
    }
}
