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
    public partial class frmhook : Form
    {
        Bd_Exp_TransportesDataContext bd = new Bd_Exp_TransportesDataContext();

        int Tramite { get; set; }
        int Origen { get; set; }

        public frmhook(int tramite, int origen)
        {
            InitializeComponent();
            Tramite = tramite;
            Origen = origen;
        }

        private void pbaceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pbcancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelar vinculación de imagenes", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void lookUpEditCamposTrazables_QueryPopUp(object sender, CancelEventArgs e)
        {
            List<pa_ObtenerDocumentosporTramiteyOrigenResult> data = new List<pa_ObtenerDocumentosporTramiteyOrigenResult>();
            data = bd.pa_ObtenerDocumentosporTramiteyOrigen(Tramite, Origen).ToList();
            lookUpEditClasificacionDocumento.Properties.DataSource = data;
        }

        private void actualizainfomascara(string mascara, int numcaracteres)
        {
            lblmascampotrazable.Text = mascara;
            txtvalortrazable.Text = "";
            txtvalortrazable.Enabled = true;
            txtvalortrazable.Properties.Mask.EditMask = mascara;
            txtvalortrazable.Properties.MaxLength = numcaracteres;
        }

        private void lookUpEditCamposTrazables_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = lookUpEditClasificacionDocumento.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
            object _Mascara_Trazable = view.GetRowCellValue(view.FocusedRowHandle, "Mascara_Trazable");
            object _Tamanio_Caracteres_Trazables = view.GetRowCellValue(view.FocusedRowHandle, "Tamanio_Caracteres_Trazables");

            txtvalortrazable.Text = "";
            txtvalortrazable.Enabled = _Mascara_Trazable == null ? false : true;
            lblmascampotrazable.Text = "";
            
            if (_Mascara_Trazable != null)
            {
                string Mascara_Trazable = (string)_Mascara_Trazable;
                int Tamanio_Caracteres_Trazables = int.Parse(string.Format("{0}", _Tamanio_Caracteres_Trazables));

                actualizainfomascara(Mascara_Trazable, Tamanio_Caracteres_Trazables);
            }
        }

        private void txtvalortrazable_Click(object sender, EventArgs e)
        {
            txtvalortrazable.SelectAll();
        }
    }
}
