using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scanndoc.classes;
using System.Collections;
using scanndoc.models;

namespace scanndoc.forms
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

        private string connectionstring(string usuario, string contrasenia) {
            return "Data Source=xmalmorthen.dyndns.org;Initial Catalog=Bd_Exp_Transportes;Persist Security Info=True;User ID=..Bd_Exp_Transportes_" + usuario + "..;Password=" + contrasenia;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {          
            try
            {
                if (!valida()) return;

                try 
	            {	        
		            Program.Bd_Exp_Transportes = new data_members.Bd_Exp_TransportesDataContext(
                                connectionstring(
                                    txt_usuario.Text.ToString().ToLower(),
                                    convert_md5.generate(txt_contrasenia.Text)
                                )
                    );
	            }
	            catch (Exception)
	            {
		            MessageBox.Show("Usuario y/o contraseña no válidos", "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
	            }
                               
                scanndoc.data_members.ca_usuarios usuario = Program.Bd_Exp_Transportes.ca_usuarios.SingleOrDefault(c => c.usuario.ToString().ToLower() == txt_usuario.Text.ToString().ToLower());
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

        private bool Parse_data_user(scanndoc.data_members.ca_usuarios usuario)
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

        private void frm_login_Load(object sender, EventArgs e)
        {
            //string user = Program.Bd_Exp_Transportes.ExecuteQuery<string>("SELECT USER").First();
        }
    }
}
