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
            thumbnail.data_members.Bd_Exp_TransportesDataContext db = new data_members.Bd_Exp_TransportesDataContext();

            thumbnail.data_members.ca_usuarios usuario = db.ca_usuarios.SingleOrDefault(c => c.usuario == txt_usuario.Text);

            if (!convert_md5.verifyMd5Hash(txt_contrasenia.Text, usuario.contrasenia))
            {
                MessageBox.Show("Usuario y/o contraseña no válidos", "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                valid = true;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
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
