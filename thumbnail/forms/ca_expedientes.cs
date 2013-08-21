using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace thumbnail.forms
{
    public partial class ca_expedientes : Form
    {
        //enumeracion para el control del estado de la forma
        public enum form_mode
        {
            agregar,
            editar,
            eliminar,
            guardando,
            guardado
        }

        //property para el manejo del estado de la forma
        private form_mode _frm_mode;
        public form_mode Form_Mode { get { return _frm_mode; } set { _frm_mode = value;
                                                                        switch (value)
                                                                        {
                                                                            case form_mode.agregar:
                                                                                enabledisablecontrols();
                                                                                break;
                                                                            case form_mode.editar:
                                                                            case form_mode.eliminar:
                                                                                enabledisablecontrols();
                                                                                break;
                                                                        }
                                                                   } }

        private void enabledisablecontrols() {
            switch (Form_Mode)
            {
                case form_mode.agregar:
                case form_mode.editar:
                    
                break;
            }
        }

        

        //lista con contenido de los registros
        private List<thumbnail.data_members.ca_expedientes> lista = Program.Bd_Exp_Transportes.GetTable<thumbnail.data_members.ca_expedientes>().ToList();

        //constructor
        public ca_expedientes()
        {
            InitializeComponent();
        }

        //al cargar el formulario
        private void ca_expedientes_Load(object sender, EventArgs e)
        {
            BindingSource.DataSource = lista; //asignar el source al binding            
            Form_Mode = form_mode.editar;


            thumbnail.data_members.ca_expedientes catalogo = new data_members.ca_expedientes;
            catalogo = (data_members.ca_expedientes) BindingSource.Current;

        }

#region botonera
        //boton de agregar
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form_Mode = form_mode.agregar;
            descripcionTextEdit.Text = "";
            descripcionTextEdit.Focus();            
        }
        
        //boton de limpiar
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            BindingSource.CancelEdit();
            datagridview.Focus();
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
                case form_mode.eliminar:
                    eliminar_registro();
                    break;
                default:
                    break;
            }
            Form_Mode = form_mode.editar;
        }

        //boton de eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        //boton cerrar
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion botonera

#region CRUD
        //eliminar
        private void eliminar_registro()
        {
            throw new NotImplementedException();
        }

        //editar
        private void editar_registro()
        {
            Program.Bd_Exp_Transportes.SubmitChanges(); //Actualizar los cambios            
        }

        //agregar
        private void agregar_registro()
        {            
            thumbnail.data_members.ca_expedientes expediente = new data_members.ca_expedientes();
            expediente.Descripcion = descripcionTextEdit.Text;
            expediente.f_act = DateTime.Now;
            expediente.u_act = thumbnail.models.Usuario.Logeado.id;
            BindingSource.Add(expediente);
            Program.Bd_Exp_Transportes.ca_expedientes.InsertOnSubmit(expediente);
            Program.Bd_Exp_Transportes.SubmitChanges();
            Form_Mode = form_mode.guardado;
        }
#endregion CRUD

        //al cambiar el contenido del texto de filtro
        private void txt_buscar_EditValueChanged(object sender, EventArgs e)
        {
            List<thumbnail.data_members.ca_expedientes> valores = (from expediente in lista
											                       where expediente.Descripcion.ToString().Contains(txt_buscar.Text.ToString())
											                       select new thumbnail.data_members.ca_expedientes()
											                       {
                                                                       id = expediente.id,
                                                                       Descripcion = expediente.Descripcion,
                                                                       re_expedientes_campostrazables = expediente.re_expedientes_campostrazables,
                                                                       re_expedientes_tramites = expediente.re_expedientes_tramites,
                                                                       f_act = expediente.f_act,
                                                                       u_act = expediente.u_act
											                       }).ToList();
				  
	        BindingSource.DataSource = valores;
            datagridview.Update();
        }

        //cuando cambia seleccion de registro en el grid
        private void ca_expedientesBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (Form_Mode != form_mode.editar)
            {
                /*
                 * al seleccionar o cambiar de registro en el grid, se llena el formulario de edicion
                 * con la información del mismo seleccionado (funcionalidad del bindingsource) y se cambia a modo edición el formulario
                 */
                Form_Mode = form_mode.editar; //cambiar el modo edicion
            }
            
        }
        
    }
}
