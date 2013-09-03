using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using thumbnail.data_members;
using thumbnail.classes;

namespace thumbnail.forms
{
    public partial class ca_roles : Form
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
            dxValidationProvider.RemoveControlError(textEdit);
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

            textEdit.Enabled = (Form_Mode == form_mode.agregar ) ? true : false;
            dataGridView1.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;

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
        private List<data_members.ca_roles> lista;
        private List<data_members.pa_ModulosporIdRolResult> modulos;
        private data_members.ca_roles rol;
        public ca_roles()
        {
            InitializeComponent();
        }

        private void actualiza_lista() {
            try
            {
                lista = Program.Bd_Exp_Transportes.GetTable<data_members.ca_roles>().ToList();
                bindingsource.DataSource = lista;
            }
            catch (Exception)
            {
            }
        }

        private void obten_modulos(int ?id_rol) { 
            try
            {
                modulos = Program.Bd_Exp_Transportes.pa_ModulosporIdRol(id_rol).ToList();
                modulosBindingSource.DataSource = modulos;
            }
            catch (Exception)
            {
            }       
        }


        private void ca_template_Load(object sender, EventArgs e)
        {
            try 
	        {
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
            bindingsource.AddNew();          
            Form_Mode = form_mode.agregar;

            //limpiar_controles();
            textEdit.Focus();
        }

        //boton editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Form_Mode = form_mode.editar;
            rol = (data_members.ca_roles)bindingsource.Current;
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            rol = null;
            bindingsource.CancelEdit();
            Form_Mode = form_mode.normal;
            bindingsource_CurrentItemChanged(null, null);
        }

        //boton de limpiar
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar_controles(); //limpiar controles
            textEdit.Focus();
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
                List<thumbnail.data_members.ca_roles> valores = (from query in lista
                                                                 where query.Descripcion.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
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
                    rol = (data_members.ca_roles)bindingsource.Current;
                    if (valida())
                    {
                        if (!buscar_si_existe())
                        {
                            List<data_members.pa_ModulosporIdRolResult> modulosclon = new List<pa_ModulosporIdRolResult>(modulos);
                            Program.Bd_Exp_Transportes.ca_roles.InsertOnSubmit(rol);
                            Program.Bd_Exp_Transportes.SubmitChanges();
                            Form_Mode = form_mode.normal;
                            actualiza_lista();

                            int id_rol = lista.SingleOrDefault(query => query.Descripcion == rol.Descripcion).id;
                            guarda_modulos(id_rol, modulosclon);

                            modulosclon = null;

                            MessageBox.Show("Registro agregado con éxito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            textEdit.SelectAll();
                            textEdit.Focus();
                        }
                    }
	            }
            }
            catch (Exception)
	        {		
		        throw;
	        }
            bindingsource_CurrentItemChanged(null, null);
        }

        private void guarda_modulos(int id_rol, List<data_members.pa_ModulosporIdRolResult> modulosclon)
        {
            List<data_members.re_roles_modulos> detalles = new List<re_roles_modulos>();

            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

            foreach (data_members.pa_ModulosporIdRolResult item in modulosclon)
            {
                if (item.ENLAZADO == 1) {
                    data_members.re_roles_modulos detalle = new re_roles_modulos();

                    detalle.id_rol = id_rol;
                    detalle.id_modulo = item.ID;

                    detalles.Add(detalle);

                    detalle = null; 
                }
            }

            if (detalles.Count > 0)
            {
                Program.Bd_Exp_Transportes.re_roles_modulos.InsertAllOnSubmit(detalles);
                Program.Bd_Exp_Transportes.SubmitChanges();
            }
        }

        private bool valida()
        {
            delete_validation_sumary();
            dxValidationProvider.Validate(); //lanzar validacion
            if (dxValidationProvider.GetInvalidControls().Count() != 0) return false;
            return true;
        }

        private bool buscar_si_existe()
        {
            data_members.ca_roles filtro = Program.Bd_Exp_Transportes.ca_roles.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == rol.Descripcion.ToString().ToLower());
            if ( filtro != null ) {
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
                        List<data_members.pa_ModulosporIdRolResult> rolesclon = new List<pa_ModulosporIdRolResult>(modulos);
                        edita_modulos(rol.id, rolesclon);

                        Program.Bd_Exp_Transportes.SubmitChanges();
                        Form_Mode = form_mode.normal;
                        actualiza_lista();
                        
                        rolesclon = null;

                        MessageBox.Show("Registro modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
	            }
                catch (Exception)
                {
                    throw;
                }
                bindingsource_CurrentItemChanged(null, null);
            }            
        }

        private void edita_modulos(int id_rol, List<data_members.pa_ModulosporIdRolResult> rolesclon)
        {
            List<data_members.re_roles_modulos> deleteitems = new List<re_roles_modulos>();
            List<data_members.re_roles_modulos> additems = new List<re_roles_modulos>();

            foreach (data_members.pa_ModulosporIdRolResult item in rolesclon)
            {
                data_members.re_roles_modulos select = (from query in Program.Bd_Exp_Transportes.re_roles_modulos
                                                        where query.id_rol == id_rol && query.id_modulo == item.ID
                                                        select query).SingleOrDefault();

                if (item.ENLAZADO == 0) 
                {
                    if (select != null)
                    {
                        deleteitems.Add(select);
                    }

                    select = null;
                } 
                else
                {
                    if (select == null)
                    {
                        data_members.re_roles_modulos detalle = new re_roles_modulos();

                        detalle.id_rol = id_rol;
                        detalle.id_modulo = item.ID;

                        additems.Add(detalle);

                        detalle = null;
                    }
                }
            }

            if (deleteitems.Count > 0)
            {
                Program.Bd_Exp_Transportes.re_roles_modulos.DeleteAllOnSubmit(deleteitems);
            }
            if (additems.Count > 0)
            {
                Program.Bd_Exp_Transportes.re_roles_modulos.InsertAllOnSubmit(additems);
            }
            
        }
                
        //eliminar
        private void eliminar_registro()
        {
            try
            {
                if (bindingsource.DataSource != null)
                {
                    rol = (data_members.ca_roles)bindingsource.Current;

                    //eliminar modulos
                    elimina_modulos(rol.id);

                    //eliminar rol
                    Program.Bd_Exp_Transportes.ca_roles.DeleteOnSubmit(rol);
                    
                    Program.Bd_Exp_Transportes.SubmitChanges();

                    MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No es posible borrar. El rol se encuentra vinculado a algún usuario", "Imposible borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void elimina_modulos(int id_modulo)
        {
            IEnumerable<data_members.re_roles_modulos> detalles = (from query in Program.Bd_Exp_Transportes.re_roles_modulos
                                                                   where (query.id_rol == id_modulo)
                                                                   select query).ToList();
            Program.Bd_Exp_Transportes.re_roles_modulos.DeleteAllOnSubmit(detalles);
        }

        private void bindingsource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (Form_Mode == form_mode.normal)
            {
                obten_modulos(((data_members.ca_roles)bindingsource.Current).id);
            }
        }
    }
}
