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
    public partial class ca_expedientes : Form
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
            }
        }

        //funcion para 
        private void enabledisablecontrols()
        {
            /*
             * botonera
             */
            //agregar
            btn_Agregar.Enabled = Form_Mode == form_mode.normal ? true : false;
            //limpiar
            btn_Limpiar.Enabled = ( Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar ) ? true : false;
            //cancelar
            btn_cancelar.Enabled = ( Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar ) ? true : false;
            //guardar
            btn_guardar.Enabled = ( Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar ) ? true : false;
            //eliminar
            btn_eliminar.Enabled = Form_Mode == form_mode.normal ? true : false;

            //limpiar controles
            limpiar_controles();

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
        private List<data_members.ca_expedientes> lista = Program.Bd_Exp_Transportes.GetTable<data_members.ca_expedientes>().ToList();
        private data_members.ca_expedientes catalogo;

        public ca_expedientes()
        {
            InitializeComponent();
        }

        private void ca_template_Load(object sender, EventArgs e)
        {
            try 
	        {	        
		        bindingsource.DataSource = lista; //asignar el source al binding            
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
/*
 * implementar la limpieza de controles
 */ 		
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
            limpiar_controles();
            //mandar foco al primer control
/*
* implementar aqui el focus
*/
        }

        //boton editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Form_Mode = form_mode.editar;
            catalogo = (data_members.ca_expedientes)bindingsource.Current;
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            catalogo = null;
            Form_Mode = form_mode.normal;
        }

        //boton de limpiar
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar_controles(); //limpiar controles
        }

        //boton de eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Eliminar registro","Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes) {
                Form_Mode = form_mode.eliminar;
                eliminar_registro();
                Form_Mode = form_mode.normal;            
            }            
        }

        //boton de guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //mandar a diferente flujo dependiendo el modo de la forma
            switch (Form_Mode)
            {
                case form_mode.agregar:
                    Form_Mode = form_mode.guardando;
                    agregar_registro();
                    Form_Mode = form_mode.guardado;
                    break;
                case form_mode.editar:
                    editar_registro();
                    break;
            }
            Form_Mode = form_mode.normal;
        }

        //boton cerrar
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
#endregion botonera        

        private void agregar_registro()
        {
            try 
	        {
                if (bindingsource.DataSource != null) {
                    Program.Bd_Exp_Transportes.ca_expedientes.InsertOnSubmit(catalogo);
                    Program.Bd_Exp_Transportes.SubmitChanges();
	            }
            }
            catch (Exception)
	        {		
		        throw;
	        }
        }

        private void editar_registro()
        {
            try 
	        {
                if (bindingsource.DataSource != null) {
                        Program.Bd_Exp_Transportes.SubmitChanges();
	            }
            }
            catch (Exception)
	        {		
		        throw;
	        }            
        }

                
        private void eliminar_registro()
        {
 	        throw new NotImplementedException();
        }

    }
}
