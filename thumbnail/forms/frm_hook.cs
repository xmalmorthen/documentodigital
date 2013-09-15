using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scanndoc.data_members;
using scanndoc.models;

namespace scanndoc.forms
{
    public partial class frm_hook : Form
    {
        // propertys
        int Tramite { get; set; }
        int Origen { get; set; }

        public scanndoc.models.digital source = new scanndoc.models.digital(); //instancia a modelo principal para el guardado de la información
        public List<scanndoc.models.digital> sources = new List<scanndoc.models.digital>();

        //constructor
        public frm_hook()
        {
            InitializeComponent();            
        }
        //sobrecarga de constructor
        public frm_hook(int tramite, int origen, List<scanndoc.models.digital> _sources)
        {
            InitializeComponent();
            this.inicializa(tramite, origen, _sources);
        }

        //funcion para inicializar variables
        public void inicializa(int tramite, int origen, List<scanndoc.models.digital> _sources) {
            formactivo = false;

            Tramite = tramite; //inicializar property tramite a partir de parametro
            Origen = origen; //inicializar property origen a partir de parametro
            sources = _sources;
            this.populate_lookUpEdit_ClasificacionDocumento(); //popular combo
            
            this.lookUpEdit_ClasificacionDocumento.EditValue = null; //establecer el tramite a seleccionar
            actualizainfomascara("", 0, "");
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
        List<pa_ObtenerDocumentosporTramiteyOrigenResult> ListaDocumentos = new List<pa_ObtenerDocumentosporTramiteyOrigenResult>();
        private void populate_lookUpEdit_ClasificacionDocumento()
        {
            ListaDocumentos = Program.Bd_Exp_Transportes.pa_ObtenerDocumentosporTramiteyOrigen(Tramite, Origen).ToList(); //obtener la lista de documentos por tramite y origen
            foreach (digital item in sources)
            {
                ListaDocumentos.RemoveAll(query => query.id_re_clasificaciondocumentos_documentos != item.id_re_clasificaciondocumento_documento && query.Descripcion_clasificaciondocumento == item.clasificaciondocumento);
            }

            this.bindingsource.DataSource = ListaDocumentos;
            this.lookUpEdit_ClasificacionDocumento.Properties.DataSource = this.bindingsource; //asignar datasourse al combo
        }

        //acualizar datos para la introducción de mascaras
        private void actualizainfomascara(string mascara, int numcaracteres, string clasificaciondocumento)
        {
            lblmascampotrazable.Text = mascara;

            txtvalortrazable.Text = "";

            if (!string.IsNullOrEmpty(clasificaciondocumento))
            {
                List<scanndoc.models.digital> _source = (from query in sources
                                                          where query.clasificaciondocumento == clasificaciondocumento
                                                          && query.enlazado == true
                                                          select query).ToList();
                if (_source.Count > 0)
                {
                    txtvalortrazable.Text = _source[0].valor_trazable;
                    txtvalortrazable.Enabled = true;
                }
            }

            txtvalortrazable.Properties.Mask.EditMask = mascara;
            txtvalortrazable.Properties.MaxLength = numcaracteres;
        }

        //al seleccionar item del combo
        private void lookUpEditCamposTrazables_EditValueChanged(object sender, EventArgs e)
        {
            if (!formactivo) return;

            dxValidationProvider_lookUpEdit_ClasificacionDocumento.RemoveControlError(lookUpEdit_ClasificacionDocumento);
            dxValidationProvider_Valor.RemoveControlError(txtvalortrazable);
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
            object _id_re_clasificaciondocumento_documento = view.GetRowCellValue(view.FocusedRowHandle, "id_re_clasificaciondocumentos_documentos");
            
            if (_id_documento == null) return;

            txtvalortrazable.Text = ""; //limpiar caja de texto de valor trazable
            Boolean trazabilidad = Boolean.Parse(string.Format("{0}", _Trazabilidad));
            txtvalortrazable.Enabled = trazabilidad; // habilitar o deshabilitar caja de texto de valor trasable segun se requiera su trazabilidad
            lblmascampotrazable.Text = ""; //limpiar label de muestra de mascara trazable
            
            string clasificaciondocumento = (string)_clasificaciondocumento;
            source.clasificaciondocumento = clasificaciondocumento; //asignar la clasificacion a variable colectora
            
            string documento = (string)_documento;            
            source.documento = documento; //asignar el nombre del documento a variable colectora

            int id_re_clasificaciondocumento_documento = int.Parse(string.Format("{0}", _id_re_clasificaciondocumento_documento));
            source.id_re_clasificaciondocumento_documento = id_re_clasificaciondocumento_documento;

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

        private Boolean formactivo;
        private void frm_hook_Load(object sender, EventArgs e)
        {            
            this.Paint += frm_hook_Paint;
        }

        private void frm_hook_Paint(object sender, PaintEventArgs e)
        {
            formactivo = true;
            this.Paint -= frm_hook_Paint;
        }
                
    }
}
