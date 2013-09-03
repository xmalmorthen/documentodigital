using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using thumbnail.classes;
using System.Collections;
using thumbnail.models;

namespace thumbnail.forms
{
    public partial class frm_login : Form
    {
        Boolean valid = false;

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {          
            try
            {
                if (!valida()) return;
                thumbnail.data_members.ca_usuarios usuario = Program.Bd_Exp_Transportes.ca_usuarios.SingleOrDefault(c => c.usuario.ToString().ToLower() == txt_usuario.Text.ToString().ToLower());
                if (!convert_md5.verifyMd5Hash(txt_contrasenia.Text, usuario.contrasenia))
                {
                    MessageBox.Show("Usuario y/o contraseña no válidos", "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Parse_data_user(usuario))
                    {
                        valid = true;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario y/o contraseña no válidos", "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool valida()
        {
            dxValidationProvider.RemoveControlError(txt_usuario);
            dxValidationProvider.RemoveControlError(txt_contrasenia);
            dxValidationProvider.Validate(); //lanzar validacion
            if (dxValidationProvider.GetInvalidControls().Count() != 0) return false;

            return true;
        }

        private bool Parse_data_user(thumbnail.data_members.ca_usuarios usuario)
        {
            try 
	        {
                Usuario.Logeado = usuario;
	        }
	        catch (Exception)
	        {
                return false;
	        }
            
            return true;
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valid) {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            } else {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
