using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using thumbnail.Properties;
using System.Configuration;
using thumbnail.data_members;
using DevExpress.XtraEditors;
using thumbnail.models;
using DevExpress.XtraGrid.Views.Grid;
using thumbnail.classes;
using System.Collections;
using System.Xml;

namespace thumbnail.forms
{
    public partial class frm_deshacer_tramite_view : Form
    {
        #region enumss, propertys, variables, etc

        //enumeracion para el estado del formulario
        public enum form_mode
        {
            Normal,
            Deshecho            
        }

        //property para el control del estado del formulario
        private form_mode _formmode;
        public form_mode Form_Mode
        {
            get { return _formmode; }
            set
            {
                _formmode = value;
                enabledisablecontrols();
            }
        }

        //funcion para 
        private void enabledisablecontrols()
        {
            /*
             * botonera
             */       
            //nuevo
            btn_deshacer.Enabled = (Form_Mode == form_mode.Normal) ? true : false;

            col_valor_trazable.DataPropertyName =  "valor_trazable";
        }

        //lista de imagenes global
        private ImageList thumbnainlist = new ImageList();
        
        //lista de imagenes por cejilla
        private ImageList thumbnainlistusuario = new ImageList();
        private ImageList thumbnainlistinterno = new ImageList();
        private ImageList thumbnainlistexterno = new ImageList();
        private ImageList thumbnainlistproveedor = new ImageList();

        //listview de thumbnails
        private ListView lstvwdocumentosenlazados;

        //propertys para la obtencion automatica del nombre de archivo a generar al escanear
        string swapdirectory
        {
            get
            {
                if (!Directory.Exists(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, Settings.Default.PathRepoImgs)))
                {
                    Directory.CreateDirectory(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, Settings.Default.PathRepoImgs));
                }
                return Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, Settings.Default.PathRepoImgs);
            }
        }

        public string scannfilename { 
                                      get {
                                          return swapdirectory + @"\" + Settings.Default.ScannFileName + Guid.NewGuid().ToString();
                                          }
                                    }

        #endregion enumss, propertys, variables, etc

        //contructor de clase
        public frm_deshacer_tramite_view()
        {
            InitializeComponent();
            Inicializa();
        }

        int id_ma_digital { get; set; }

        public frm_deshacer_tramite_view(int Id_Ma_Digital, string valortrazable, string tramite)
        {
            InitializeComponent();
            Inicializa();
            id_ma_digital = Id_Ma_Digital;

            txt_tramite.Text = tramite;
            this.Text = "Deshacer tramite - " + tramite + "[ " + valortrazable + " ]";
            try
            {
                this.Cursor = Cursors.WaitCursor;
                tlp_proc.Visible = true;

                Application.DoEvents();

                obtenerregistrosaeditar();

                Application.DoEvents();

                tlp_proc.Visible = false;
                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //funcion de configuraciones iniciales
        private void Inicializa()
        {
            Form_Mode = form_mode.Normal; //inicializar por default el formulario en modo add

            //lista de imagenes usuario
            this.thumbnainlistusuario.ImageSize = Settings.Default.ThumbNailSize;
            this.thumbnainlistusuario.ColorDepth = Settings.Default.ThumbNailColorDepth;
            //lista de imagenes interno
            this.thumbnainlistinterno.ImageSize = Settings.Default.ThumbNailSize;
            this.thumbnainlistinterno.ColorDepth = Settings.Default.ThumbNailColorDepth;
            //lista de imagenes externo
            this.thumbnainlistexterno.ImageSize = Settings.Default.ThumbNailSize;
            this.thumbnainlistexterno.ColorDepth = Settings.Default.ThumbNailColorDepth;
            //lista de imagenes proveedor
            this.thumbnainlistproveedor.ImageSize = Settings.Default.ThumbNailSize;
            this.thumbnainlistproveedor.ColorDepth = Settings.Default.ThumbNailColorDepth;
            //lista de imagen generic
            this.thumbnainlist.ImageSize = Settings.Default.ThumbNailSize;
            this.thumbnainlist.ColorDepth = Settings.Default.ThumbNailColorDepth;

            dataGridView_CamposTrazables.Cursor = Cursors.Arrow;
            dataGridView_CamposTrazables.ReadOnly = true;
            
            this.Paint += frm_scann_Paint;
        }

        /*
         * utilizado para que se vea el pintado de la celda, si no hacemos esto al iniciar
         * la forma no aparece iluminada la fila de campo principal en el grid de campos trazables
         */ 
        void frm_scann_Paint(object sender, PaintEventArgs e)
        {
            this.formatear_celda_principal(); //dar formato a la fila del campo principal
            this.Paint -= frm_scann_Paint;
        }

        //load de form
        private void scann_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        //cerrar
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

#region dataGridView_campostrazables
        private void formatear_celda_principal()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Settings.Default.CampoPrincipal_RowColorGrid;
            style.ForeColor = Color.Black;

            foreach (DataGridViewRow row in dataGridView_CamposTrazables.Rows)
            {
                if (Boolean.Parse(row.Cells["esprincipalDataGridViewCheckBoxColumn"].Value.ToString()) == true)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style = style;
                    }
                    break;
                }
            }
        }
#endregion dataGridView_campostrazables

#region tabcontrol
        //asignador de lista de imagen al cambiar el tab
        private void tbctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((TabControl)sender).SelectedIndex)
            {
                case 0:
                    thumbnainlist = thumbnainlistusuario;
                    lstvwdocumentosenlazados = tab0_lstvwdocumentosenlazados;
                    break;
                case 1:
                    thumbnainlist = thumbnainlistinterno;
                    lstvwdocumentosenlazados = tab1_lstvwdocumentosenlazados;
                    break;
                case 2:
                    thumbnainlist = thumbnainlistexterno;
                    lstvwdocumentosenlazados = tab2_lstvwdocumentosenlazados;
                    break;
                case 3:
                    thumbnainlist = thumbnainlistproveedor;
                    lstvwdocumentosenlazados = tab3_lstvwdocumentosenlazados;                    
                    break;
            }
            this.lstvwdocumentosenlazados.View = View.LargeIcon;
            this.lstvwdocumentosenlazados.LargeImageList = this.thumbnainlist;

            this.lstvwdocumentosenlazados.Refresh();
        }       
#endregion tabcontrol

        public List<thumbnail.models.digital> sources_digital = new List<thumbnail.models.digital>();
        public thumbnail.models.digital source_digital = new thumbnail.models.digital(); //instancia a modelo principal para el guardado de la información
        
//boton abrir
        private void tsmnuitemlstvwenlaceabrir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            frm_deshacer_tramite_view_openimage testDialog;
            
            tagstruct edittag = ((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag);

            if (edittag.path_image != null)
            {
                testDialog = new frm_deshacer_tramite_view_openimage(edittag.path_image);
            }
            else
            {
                testDialog = new frm_deshacer_tramite_view_openimage(((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag).id_ma_digital_edit,
                                                ((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag).id,
                                                ((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag).id_re_clasificaciondocumento_documento);
                edittag.path_image = testDialog.pathimageoriginal;
                lstvwdocumentosenlazados.SelectedItems[0].Tag = edittag;
            }           

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;

            testDialog.ShowDialog(this);

            testDialog.Dispose();
        }

        //estructura para la informacion en tag
        public struct tagstruct
        {
            public string path_image;
            public string guid;
            public int id;
            public int id_ma_digital_edit;
            public int id_re_clasificaciondocumento_documento;
        };                

        private void obtenerregistrosaeditar()
        {
            obtenercampostrazablesaeditar();
            obtenerarchivodigital();
        }

        //estructura para la informacion en tag        
        private void obtenerarchivodigital()
        {
            List<data_members.pa_RegistrosDigitalesRegistradosporId_ma_digitalResult> imagenesdigitalregistradas =
                new List<pa_RegistrosDigitalesRegistradosporId_ma_digitalResult>(Program.Bd_Exp_Transportes.pa_RegistrosDigitalesRegistradosporId_ma_digital(id_ma_digital));

            foreach (data_members.pa_RegistrosDigitalesRegistradosporId_ma_digitalResult current in imagenesdigitalregistradas)
            {
                thumbnail.models.digital source = new thumbnail.models.digital();

                Image img = procesa_imagen.ByteArrayToImage(current.thumbnail.ToArray());
                source.thumbnail = current.thumbnail.ToArray();
                source.id_re_clasificaciondocumento_documento = current.id_re_clasificaciondocumento_documento;
                source.valor_trazable = current.valor_trazable;
                source.clasificaciondocumento = current.clasificaciondocumento;
                source.documento = current.Documento;
                source.guid = Guid.NewGuid().ToString();
                source.enlazado = true;
                source.editado = false;
                source.aniadido = false;
                source.id_de_digital = current.id;

                switch (current.Origen.ToString().ToLower())
                {                    
                    case "interno":
                        thumbnainlist = thumbnainlistinterno;
                        lstvwdocumentosenlazados = tab1_lstvwdocumentosenlazados;
                    break;
                    case "externo":
                        thumbnainlist = thumbnainlistexterno;
                        lstvwdocumentosenlazados = tab2_lstvwdocumentosenlazados;
                    break;
                    case "usuario":
                        thumbnainlist = thumbnainlistusuario;
                        lstvwdocumentosenlazados = tab0_lstvwdocumentosenlazados;
                    break;
                    case "proveedor":
                        thumbnainlist = thumbnainlistproveedor;
                        lstvwdocumentosenlazados = tab3_lstvwdocumentosenlazados; 
                    break;
                }

                thumbnainlist.Images.Add(img);
                this.lstvwdocumentosenlazados.Items.Add("", (int)thumbnainlist.Images.Count - 1);

                tagstruct tagedit = new tagstruct();
                tagedit.guid = source.guid;
                tagedit.id = current.id;
                tagedit.id_ma_digital_edit = id_ma_digital;
                tagedit.id_re_clasificaciondocumento_documento = source.id_re_clasificaciondocumento_documento;

                this.lstvwdocumentosenlazados.Items[lstvwdocumentosenlazados.Items.Count - 1].Tag = tagedit;

                ListViewGroup _grupo = new ListViewGroup();
                _grupo.Name = source.clasificaciondocumento; //obtener el nombre del grupo a partir de su clasificacion de documento
                _grupo.Header = source.clasificaciondocumento + " [ " + source.documento + " ] " + (!string.IsNullOrEmpty(source.valor_trazable) ? "[ " + source.valor_trazable + " ]" : ""); //concatenar la clasificacion de documentos con el nombre del documento
                _grupo.HeaderAlignment = HorizontalAlignment.Left;

                Boolean existe = lstvwdocumentosenlazados.Groups.Contains(_grupo);

                if (!existe) lstvwdocumentosenlazados.Groups.Add(_grupo); //agregar grupo

                lstvwdocumentosenlazados.Items[lstvwdocumentosenlazados.Items.Count - 1].Group = lstvwdocumentosenlazados.Groups[_grupo.Name];

                sources_digital.Add(source);
                source = null;
            }
            tbctrl_SelectedIndexChanged(tbctrl, null);
        }

        private void obtenercampostrazablesaeditar() { 
            /* obtener campos trazables ejecutando procedimiento almacenado mandando como parametro
             * el id de maestro digital
             */
            List<data_members.pa_CampostrazablesRegistradosporId_ma_digitalResult> listacamposaeditar = Program.Bd_Exp_Transportes.pa_CampostrazablesRegistradosporId_ma_digital(id_ma_digital).ToList();
            this.BindingSource_CamposTrazables.DataSource = listacamposaeditar;
            this.dataGridView_CamposTrazables.DataSource = this.BindingSource_CamposTrazables;
            id_re_expedientes_campostrazables.DataPropertyName = "id_re_expediente_campotrazable";
            this.formatear_celda_principal(); //dar formato a la fila del campo principal
        }

        private void frm_scann_FormClosing(object sender, FormClosingEventArgs e)
        {
            colectar_basura();
        }

        private void colectar_basura()
        {
            foreach (string archivo in Directory.GetFiles(swapdirectory,"*.jpg"))
	        {
		        File.Delete(archivo);
	        }
        }

        Boolean tramitebloqueado = false;
        private void bloqueacontroles()
        {
            //lookUpEdit_Tramites.Enabled
            dataGridView_CamposTrazables.ReadOnly = true;
            btn_deshacer.Enabled = false;

            tab0_lstvwdocumentosenlazados.ContextMenuStrip = null;
            tab1_lstvwdocumentosenlazados.ContextMenuStrip = null;
            tab2_lstvwdocumentosenlazados.ContextMenuStrip = null;
            tab3_lstvwdocumentosenlazados.ContextMenuStrip = null;

            tab0_lstvwdocumentosenlazados.AllowDrop = false;
            tab1_lstvwdocumentosenlazados.AllowDrop = false;
            tab2_lstvwdocumentosenlazados.AllowDrop = false;
            tab3_lstvwdocumentosenlazados.AllowDrop = false;

            lstvwdocumentosenlazados.ContextMenuStrip = null;

            lstvwdocumentosenlazados.AllowDrop = false;

            tramitebloqueado = true;
        }

        private void btn_deshacer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma deshacer el trámite", "Deshacer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
        }

    }
}
