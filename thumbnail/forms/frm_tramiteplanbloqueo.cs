using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scanndoc.forms
{
    public partial class frm_tramiteplanbloqueo : Form
    {
        public frm_tramiteplanbloqueo()
        {
            InitializeComponent();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
                checkEdit2.Checked = false;
            panel1.Enabled = checkEdit1.Checked;
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
                checkEdit1.Checked = false;
            panel2.Enabled = checkEdit2.Checked;
        }

        private void frm_tramiteplanbloqueo_Load(object sender, EventArgs e)
        {
            try
            {
                dateEdit.Properties.MinValue = Program.Bd_Exp_Transportes.ExecuteQuery<DateTime>("SELECT GETDATE()").First();
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!checkEdit1.Checked && !checkEdit2.Checked) {
                MessageBox.Show("Debe especificar un plan de bloqueo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (checkEdit1.Checked) {
                if (spinEdit_dias.Value == 0 && spinEdit_horas.Value == 0) {
                    MessageBox.Show("Al menos uno de los campos día(s) u hora(s) debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (checkEdit2.Checked)
            {
                if ( dateEdit.EditValue == null)
                {
                    MessageBox.Show("Debe indicar la fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (checkEdit1.Checked) {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else if (checkEdit2.Checked) {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }

        }
    }
}
