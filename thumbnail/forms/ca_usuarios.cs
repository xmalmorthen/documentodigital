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
    public partial class ca_usuarios : Form
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
            dxValidationProvider.RemoveControlError(textEdit1);
            dxValidationProvider.RemoveControlError(textEdit3);
            dxValidationProvider.RemoveControlError(textEdit5);

            dxValidationProvider1.RemoveControlError(textEdit2);
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
            textEdit1.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            textEdit2.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            textEdit3.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            textEdit4.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            textEdit5.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            textEdit6.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
            textEdit7.Enabled = (Form_Mode == form_mode.agregar || Form_Mode == form_mode.editar) ? true : false;
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
        private List<data_members.ca_usuarios> lista;
        private List<data_members.pa_RolesporIdUsuarioResult> roles;
        private data_members.ca_usuarios usuario;
        public ca_usuarios()
        {
            InitializeComponent();
        }

        private void actualiza_lista() {
            try
            {
                lista = Program.Bd_Exp_Transportes.GetTable<data_members.ca_usuarios>().ToList();
                bindingsource.DataSource = lista;
            }
            catch (Exception)
            {
            }
        }

        private void obten_roles(int ?id_usuario) { 
            try
            {
                roles = Program.Bd_Exp_Transportes.pa_RolesporIdUsuario(id_usuario).ToList();
                rolesBindingSource.DataSource = roles;
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
                textEdit2.Text = "";
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
            usuario = (data_members.ca_usuarios)bindingsource.Current;
            modificacontraseña = false;
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            usuario = null;
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
                List<thumbnail.data_members.ca_usuarios> valores = (from query in lista
                                                                    where (query.Nombres + " " + query.Apellido1 + " " +query.Apellido2).ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
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
                    usuario = (data_members.ca_usuarios)bindingsource.Current;
                    if (valida())
                    {
                        if (!buscar_si_existe())
                        {
                            List<data_members.pa_RolesporIdUsuarioResult> rolesclon = new List<pa_RolesporIdUsuarioResult>(roles);

                            usuario.contrasenia = convert_md5.generate(usuario.contrasenia);

                            thumbnail.data_members.Bd_Exp_TransportesDataContext Bd = new Bd_Exp_TransportesDataContext();
                            data_members.pa_CreateLoginandUserResult result = Bd.pa_CreateLoginandUser(usuario.usuario, usuario.contrasenia).Single();
                            Bd.Dispose();
                            
                            if (result.StatusCode == 1)
                            {
                                Program.Bd_Exp_Transportes.ca_usuarios.InsertOnSubmit(usuario);
                                Program.Bd_Exp_Transportes.SubmitChanges();
                                Form_Mode = form_mode.normal;
                                actualiza_lista();

                                int id_usuario = lista.SingleOrDefault(query => query.usuario == usuario.usuario).id;
                                guarda_roles(id_usuario, rolesclon);

                                rolesclon = null;
                                MessageBox.Show("Registro agregado con éxito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else 
                            {
                                MessageBox.Show("Falló al intentar registrar el usuario de base de datos, favor de intentarlo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                             
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

        private void guarda_roles(int id_usuario, List<data_members.pa_RolesporIdUsuarioResult> rolesclon)
        {
            List<data_members.re_usuarios_roles_permisos> detalles = new List<re_usuarios_roles_permisos>();

            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

            foreach (data_members.pa_RolesporIdUsuarioResult item in rolesclon)
            {
                if (item.ENLAZADO == 1) {
                    data_members.re_usuarios_roles_permisos detalle = new re_usuarios_roles_permisos();

                    detalle.id_usuario = id_usuario;
                    detalle.id_rol = item.ID;

                    detalles.Add(detalle);

                    detalle = null; 
                }
            }

            if (detalles.Count > 0)
            {
                Program.Bd_Exp_Transportes.re_usuarios_roles_permisos.InsertAllOnSubmit(detalles);
                Program.Bd_Exp_Transportes.SubmitChanges();
            }
        }

        private bool valida()
        {
            delete_validation_sumary();
            dxValidationProvider.Validate(); //lanzar validacion
            if (dxValidationProvider.GetInvalidControls().Count() != 0) return false;

            if (Form_Mode == form_mode.agregar || (Form_Mode == form_mode.editar && modificacontraseña))
            {
                dxValidationProvider1.Validate(); //lanzar validacion
                if (dxValidationProvider1.GetInvalidControls().Count() != 0) return false;
            }

            return true;
        }

        private bool buscar_si_existe()
        {
            data_members.ca_usuarios filtro = Program.Bd_Exp_Transportes.ca_usuarios.SingleOrDefault(query => query.usuario.ToString().ToLower() == usuario.usuario.ToString().ToLower());
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
                        if (modificacontraseña)
                        {
                            usuario.contrasenia = convert_md5.generate(usuario.contrasenia);

                            thumbnail.data_members.Bd_Exp_TransportesDataContext Bd = new Bd_Exp_TransportesDataContext();
                            data_members.pa_ModifyPassUserSQLResult result = Bd.pa_ModifyPassUserSQL(usuario.usuario, usuario.contrasenia).Single();
                            Bd.Dispose();

                            if (result.StatusCode == 0)
                            {
                                MessageBox.Show("Falló al intentar modificar la contraseña del usuario de base de datos, favor de intentarlo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        List<data_members.pa_RolesporIdUsuarioResult> rolesclon = new List<pa_RolesporIdUsuarioResult>(roles);
                        edita_roles(usuario.id, rolesclon);

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

        private void edita_roles(int id_usuario,List<data_members.pa_RolesporIdUsuarioResult> rolesclon)
        {
            List<data_members.re_usuarios_roles_permisos> deleteitems = new List<re_usuarios_roles_permisos>();
            List<data_members.re_usuarios_roles_permisos> additems = new List<re_usuarios_roles_permisos>();
            
            foreach (data_members.pa_RolesporIdUsuarioResult item in rolesclon)
            {
                data_members.re_usuarios_roles_permisos select = (from query in Program.Bd_Exp_Transportes.re_usuarios_roles_permisos
                                                                  where query.id_usuario == id_usuario && query.id_rol == item.ID
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
                        data_members.re_usuarios_roles_permisos detalle = new re_usuarios_roles_permisos();

                        detalle.id_usuario = id_usuario;
                        detalle.id_rol = item.ID;

                        additems.Add(detalle);

                        detalle = null;
                    }
                }
            }

            if (deleteitems.Count > 0)
            {
                Program.Bd_Exp_Transportes.re_usuarios_roles_permisos.DeleteAllOnSubmit(deleteitems);
            }
            if (additems.Count > 0)
            {
                Program.Bd_Exp_Transportes.re_usuarios_roles_permisos.InsertAllOnSubmit(additems);
            }
            
        }
                
        //eliminar
        private void eliminar_registro()
        {
            try
            {
                if (bindingsource.DataSource != null)
                {
                    usuario = (data_members.ca_usuarios)bindingsource.Current;

                    thumbnail.data_members.Bd_Exp_TransportesDataContext Bd = new Bd_Exp_TransportesDataContext();
                    data_members.pa_DeleteUserSQLResult result = Bd.pa_DeleteUserSQL(usuario.usuario).Single();
                    Bd.Dispose();

                    if (result.StatusCode == 1)
                    {

                        //eliminar reoles
                        elimina_roles(usuario.id);

                        //eliminar usuario
                        usuario = (data_members.ca_usuarios)bindingsource.Current;
                        Program.Bd_Exp_Transportes.ca_usuarios.DeleteOnSubmit(usuario);

                        Program.Bd_Exp_Transportes.SubmitChanges();
                        MessageBox.Show("Registro eliminado con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falló al intentar eliminar el usuario de base de datos, favor de intentarlo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void elimina_roles(int id_usuario)
        {
            IEnumerable<data_members.re_usuarios_roles_permisos> detalles = (from query in Program.Bd_Exp_Transportes.re_usuarios_roles_permisos
                                                                             where (query.id_usuario == id_usuario)
                                                                             select query).ToList();
            Program.Bd_Exp_Transportes.re_usuarios_roles_permisos.DeleteAllOnSubmit(detalles);
        }

        private Boolean modificacontraseña;
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            modificacontraseña = true;
        }

        private void textEdit1_Enter(object sender, EventArgs e)
        {
            textEdit1.SelectAll();
        }

        private void textEdit2_Enter(object sender, EventArgs e)
        {
            textEdit2.SelectAll();
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            textEdit1_Enter(sender, e);
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            textEdit2_Enter(sender, e);
        }

        private void bindingsource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (Form_Mode == form_mode.normal)
            {
                obten_roles(((data_members.ca_usuarios)bindingsource.Current).id);
                textEdit2.Text = ((data_members.ca_usuarios)bindingsource.Current).contrasenia;
            }
        }

    }
}
