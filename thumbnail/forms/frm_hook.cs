using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using thumbnail.data_members;
using thumbnail.models;

namespace thumbnail.forms
{
    public partial class frm_hook : Form
    {
        thumbnail.data_members.Bd_Exp_TransportesDataContext Bd_Exp_Transportes; //variable base de datos

        // propertys
        int Tramite { get; set; }
        int Origen { get; set; }

        public thumbnail.models.digital source = new thumbnail.models.digital(); //instancia a modelo principal para el guardado de la información
        public List<thumbnail.models.digital> sources = new List<thumbnail.models.digital>();

        BindingSource BindingSource_ClasificacionDocumento; //variable binding para lista de clasificacion de documentos

        //constructor
        public frm_hook()
        {
            InitializeComponent();
            Bd_Exp_Transportes = new thumbnail.data_members.Bd_Exp_TransportesDataContext(); //instancia de base de datos
        }
        //sobrecarga de constructor
        public frm_hook(int tramite, int origen, List<thumbnail.models.digital> _sources)
        {
            InitializeComponent();
            Bd_Exp_Transportes = new thumbnail.data_members.Bd_Exp_TransportesDataContext(); //instancia de base de datos
            this.inicializa(tramite, origen, _sources);
        }

        //funcion para inicializar variables
        public void inicializa(int tramite, int origen, List<thumbnail.models.digital> _sources) {
            Tramite = tramite; //inicializar property tramite a partir de parametro
            Origen = origen; //inicializar property origen a partir de parametro
            sources = _sources;
            this.populate_lookUpEdit_ClasificacionDocumento(); //popular combo
        }

        //validador de formulario
        private bool valida()
        {
            dxValidationProvider_lookUpEdit_ClasificacionDocumento.RemoveControlError(lookUpEdit_ClasificacionDocumento);
            dxValidationProvider_Valor.RemoveControlError(txtvalortrazable);

            dxValidationProvider_lookUpEdit_ClasificacionDocumento.Validate(); //lanzar validacion

            if (txtvalortrazable.Enabled) {
                dxValidationProvider_Valor.Validate();
            }

            if (dxValidationProvider_lookUpEdit_ClasificacionDocumento.GetInvalidControls().Count() != 0 || dxValidationProvider_Valor.GetInvalidControls().Count() != 0) return false;
            
            return true;
        }

        //cuando se muestre la lista del combo
        private void lookUpEditCamposTrazables_QueryPopUp(object sender, CancelEventArgs e)
        {
            //this.populate_lookUpEdit_ClasificacionDocumento(); //popular combo
        }

        //funcion para popular combo de clasificacion de documentos
        private void populate_lookUpEdit_ClasificacionDocumento()
        {
            this.BindingSource_ClasificacionDocumento = new BindingSource(); //instanciar
            this.BindingSource_ClasificacionDocumento.DataSource = this.Bd_Exp_Transportes.pa_ObtenerDocumentosporTramiteyOrigen(Tramite,Origen).ToList(); //obtener la lista de documentos por tramite y origen
            this.lookUpEdit_ClasificacionDocumento.Properties.DataSource = this.BindingSource_ClasificacionDocumento; //asignar datasourse al combo
            this.lookUpEdit_ClasificacionDocumento.Properties.DisplayMember = "Nombre"; //establecer el campo a mostrar en combo
            this.lookUpEdit_ClasificacionDocumento.Properties.ValueMember = "id_documento"; //establecer valor a manejar en combo
        }

        //acualizar datos para la introducción de mascaras
        private void actualizainfomascara(string mascara, int numcaracteres, string clasificaciondocumento)
        {
            lblmascampotrazable.Text = mascara;

            txtvalortrazable.Text = "";
            foreach (thumbnail.models.digital _source in sources)
            {
                if (_source.clasificaciondocumento == clasificaciondocumento) {
                    txtvalortrazable.Text = _source.valor_trazable;
                }
            }
            
            txtvalortrazable.Enabled = true;
            txtvalortrazable.Properties.Mask.EditMask = mascara;
            txtvalortrazable.Properties.MaxLength = numcaracteres;
        }

        //al seleccionar item del combo
        private void lookUpEditCamposTrazables_EditValueChanged(object sender, EventArgs e)
        {
            /*
             * obtener los valores de las columnas a partir del item seleccionado del combo
             */ 
            DevExpress.XtraGrid.Views.Grid.GridView view = lookUpEdit_ClasificacionDocumento.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
            object _Mascara_Trazable = view.GetRowCellValue(view.FocusedRowHandle, "Mascara_Trazable");
            object _Tamanio_Caracteres_Trazables = view.GetRowCellValue(view.FocusedRowHandle, "Tamanio_Caracteres_Trazables");
            object _Trazabilidad = view.GetRowCellValue(view.FocusedRowHandle, "Trazabilidad");
            object _id_documento = view.GetRowCellValue(view.FocusedRowHandle, "id_documento");
            object _clasificaciondocumento = view.GetRowCellValue(view.FocusedRowHandle, "Descripcion_clasificaciondocumento");
            object _documento = view.GetRowCellValue(view.FocusedRowHandle, "Nombre");
            object _id_re_tramites_re_clasificaciondocumentos_documentos = view.GetRowCellValue(view.FocusedRowHandle, "id_re_tramites_re_clasificaciondocumentos_documentos");
            
            if (_id_documento == null) return;

            txtvalortrazable.Text = ""; //limpiar caja de texto de valor trazable
            Boolean trazabilidad = Boolean.Parse(string.Format("{0}", _Trazabilidad));
            txtvalortrazable.Enabled = trazabilidad; // habilitar o deshabilitar caja de texto de valor trasable segun se requiera su trazabilidad
            lblmascampotrazable.Text = ""; //limpiar label de muestra de mascara trazable
            
            int id_documento = int.Parse(string.Format("{0}", _id_documento));
            source.id_documento = id_documento; //asignar el id documento a variable colectora
            
            string clasificaciondocumento = (string)_clasificaciondocumento;
            source.clasificaciondocumento = clasificaciondocumento; //asignar la clasificacion a variable colectora
            
            string documento = (string)_documento;            
            source.documento = documento; //asignar el nombre del documento a variable colectora

            if (trazabilidad)
            {
                string Mascara_Trazable = (string)_Mascara_Trazable;
                int Tamanio_Caracteres_Trazables = int.Parse(string.Format("{0}", _Tamanio_Caracteres_Trazables));

                actualizainfomascara(Mascara_Trazable, Tamanio_Caracteres_Trazables, clasificaciondocumento);
                
                txtvalortrazable.Focus();
            }

        }

        private void txtvalortrazable_Click(object sender, EventArgs e)
        {
            txtvalortrazable.SelectAll();
        }

        private void frmhook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                if (MessageBox.Show("Cancelar vinculación de imagenes", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        //boton aceptar
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!valida()) return; //validar formulario
            source.valor_trazable = txtvalortrazable.Text; //asignar el valor trazable a la variable principal de almacenaje
            this.DialogResult = DialogResult.OK; //cerrar formulario indicando retorno exitoso
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
                
    }
}
