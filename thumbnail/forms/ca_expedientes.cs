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
        private List<thumbnail.data_members.ca_expedientes> expedientes = Program.Bd_Exp_Transportes.GetTable<thumbnail.data_members.ca_expedientes>().ToList();

        public ca_expedientes()
        {
            InitializeComponent();
        }

        private void ca_expedientes_Load(object sender, EventArgs e)
        {
            ca_expedientesBindingSource.DataSource = expedientes;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            thumbnail.data_members.ca_expedientes expediente = new data_members.ca_expedientes();
            expediente.Descripcion = "prueba";
            expediente.f_act = DateTime.Now;
            expediente.u_act = thumbnail.models.Usuario.Logeado.id;

            ca_expedientesBindingSource.Add(expediente);

            Program.Bd_Exp_Transportes.ca_expedientes.InsertOnSubmit(expediente);
            Program.Bd_Exp_Transportes.SubmitChanges();
        }

        
    }
}
