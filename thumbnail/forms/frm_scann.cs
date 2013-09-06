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
    public partial class frm_scann : Form
    {
        #region enumss, propertys, variables, etc

        //enumeracion para el estado del formulario
        public enum form_mode
        {
            Add,
            Edit
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
                delete_validation_sumary();
            }
        }

        private void delete_validation_sumary()
        {

        }

        //funcion para 
        private void enabledisablecontrols()
        {
            /*
             * botonera
             */       
            //nuevo
            btn_nuevo.Enabled = (Form_Mode == form_mode.Edit) ? true : false;
            //editar
            //btn_editar.Enabled = (Form_Mode == form_mode.Add) ? true : false;

            //guardar
            //btn_guardar.Enabled = (Form_Mode == form_mode.Add) ? true : false;
            //limpiar
            btn_limpiar.Enabled = (Form_Mode == form_mode.Add) ? true : false;

            lookUpEdit_Tramites.Enabled = (Form_Mode == form_mode.Add) ? true : false;

            /*
             * si el modo es edicion se liga el datapropertyname del campo valor trazable
             * para que al obtener los registros de la base de datos se presenten en el grid
             * si el formulario esta en modo agregar no se enlaza a nada.
             */ 
            if (Form_Mode == form_mode.Add) {
                col_valor_trazable.DataPropertyName =  null;
            } else {
                col_valor_trazable.DataPropertyName =  "valor_trazable";
            }

        }

        //lista de imagenes global
        private ImageList thumbnainlist = new ImageList();
        
        //lista de imagenes por cejilla
        private ImageList thumbnainlistusuario = new ImageList();
        private ImageList thumbnainlistinterno = new ImageList();
        private ImageList thumbnainlistexterno = new ImageList();
        private ImageList thumbnainlistproveedor = new ImageList();

        //listview de thumbnails
        private ListView lstvwdocumentosescaneados;
        private ListView lstvwdocumentosenlazados;

        //property para indicar el control que esta arrastrando un componente
        private ListView dragging { get; set; }

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
        public frm_scann()
        {
            InitializeComponent();
            Inicializa();
        }

        //funcion de configuraciones iniciales
        private void Inicializa()
        {
            Form_Mode = form_mode.Add; //inicializar por default el formulario en modo add

            populate_lookUpEdit_Tramites(); //popular combo de tramites
            selectdefaultitem_lookUpEdit_Tramites(); //seleccionar tramite por default
                        
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

            tbctrl_SelectedIndexChanged(tbctrl, null);

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
            this.lookUpEdit_Tramites.Focus(); //establecer el foco al combo de tramites al iniciar el form
        }

        #region botonera superior

        //guardar tramite
        private tramite_model tramite;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            tramite = new tramite_model();

            if (!this.colectar_campostrazables()) return;
            if (!this.colectar_archivosdigital()) return;

            tramite.trazabilidad = new List<trazabilidad_tramite>(sources_trazabilidad);
            tramite.imagenes_digital = new List<digital>(sources_digital);

            if (Form_Mode == form_mode.Add)
            {
                this.Cursor = Cursors.WaitCursor;
                tlp_proc.Visible = true;

                Application.DoEvents();

                crearexpediente();

                Application.DoEvents();

                tlp_proc.Visible = false;
                this.Cursor = Cursors.Default;

                MessageBox.Show("Trámite guardado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                tlp_proc.Visible = true;

                Application.DoEvents();

                editarexpediente();

                Application.DoEvents();

                tlp_proc.Visible = false;
                this.Cursor = Cursors.Default;

                MessageBox.Show("Trámite modificado con éxito", "Modificaco", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tramite = null;
        }

        private void editarexpediente()
        {
            throw new NotImplementedException();
        }

        private void crearexpediente()
        {
            try
            {
                //inicializacion de valores
                tramite.id_re_expediente_tramite = lookUpEdit_Tramites_selected.id_re_expedientes_tramites;
                tramite.nota = "";
                tramite.fecha_hora_bloqueo = DateTime.Now;
                tramite.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "desbloqueado").id;

                int id_ma_digital = match_ma_digital();

                match_de_digital_campostrazables(id_ma_digital);

                match_de_digital(id_ma_digital);

                Program.Bd_Exp_Transportes.SubmitChanges();

                Form_Mode = form_mode.Edit; //al guardar se cambia a modo edición
            }
            catch (Exception)
            {                
            }                
        }

        private void match_de_digital(int id_ma_digital)
        {
            List<data_members.de_digital> listainsertar = new List<data_members.de_digital>();
            foreach (digital item in tramite.imagenes_digital)
            {
                data_members.de_digital de_digital = new data_members.de_digital();
                de_digital.id_ma_digital = id_ma_digital;

                byte[] file_byte_thumbnail = procesa_imagen.toByteArray(item.thumbnail);
                System.Data.Linq.Binary file_binary_thumbnail = new System.Data.Linq.Binary(file_byte_thumbnail);
                de_digital.thumbnail = file_binary_thumbnail;
                file_byte_thumbnail = null;
                file_binary_thumbnail = null;

                de_digital.id_re_clasificaciondocumento_documento = item.id_re_clasificaciondocumento_documento;

                byte[] file_byte_imagen = procesa_imagen.toByteArray(item.imagen);
                System.Data.Linq.Binary file_binary_imagen = new System.Data.Linq.Binary(file_byte_imagen);
                de_digital.imagen = file_binary_imagen;
                file_byte_imagen = null;
                file_binary_imagen = null;

                de_digital.valor_trazable = item.valor_trazable;                
                de_digital.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "activo").id;
                
                listainsertar.Add(de_digital);
                
                de_digital = null;
            }
            Program.Bd_Exp_Transportes.de_digital.InsertAllOnSubmit(listainsertar);
        }

        private void match_de_digital_campostrazables(int id_ma_digital)
        {
            List<data_members.de_digital_campostrazables> listainsertar = new List<data_members.de_digital_campostrazables>();
            foreach (trazabilidad_tramite item in tramite.trazabilidad)
	        {
                data_members.de_digital_campostrazables de_digital_campostrazables = new data_members.de_digital_campostrazables();
                de_digital_campostrazables.id_ma_digital = id_ma_digital;
                de_digital_campostrazables.id_re_expediente_campotrazable = item.id_re_expediente_campotrazable;
                de_digital_campostrazables.valor_trazable = item.valor_trazable;
                de_digital_campostrazables.id_estatus = Program.Bd_Exp_Transportes.ca_estatus.SingleOrDefault(query => query.Descripcion.ToString().ToLower() == "activo").id;
                listainsertar.Add(de_digital_campostrazables);
                de_digital_campostrazables = null;
	        }
            Program.Bd_Exp_Transportes.de_digital_campostrazables.InsertAllOnSubmit(listainsertar);
        }

        private int match_ma_digital()
        {
            data_members.ma_digital ma_digital = new data_members.ma_digital();
            ma_digital.id_re_expediente_tramite = tramite.id_re_expediente_tramite;
            data_members.pa_obtener_fechahoraResult fechahora = Program.Bd_Exp_Transportes.pa_obtener_fechahora() as pa_obtener_fechahoraResult;
            ma_digital.nota = tramite.nota;
            ma_digital.fecha_hora_bloqueo = tramite.fecha_hora_bloqueo;
            ma_digital.id_estatus = tramite.id_estatus;

            Program.Bd_Exp_Transportes.ma_digital.InsertOnSubmit(ma_digital);
            Program.Bd_Exp_Transportes.SubmitChanges();
            return ma_digital.id;
        }

        List<trazabilidad_tramite> sources_trazabilidad = new List<trazabilidad_tramite>();
        private Boolean colectar_campostrazables()
        {
            Boolean result = true;
            sources_trazabilidad.Clear();
            foreach (DataGridViewRow row in dataGridView_CamposTrazables.Rows)
            {
                if (row.ErrorText.Length != 0)
                {
                    MessageBox.Show("Se encontraron errores en las máscaras de trazabilidad del expediente, imposible procesar, favor de revisar", "Error en valores trazables", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView_CamposTrazables.Focus();
                    result = false;
                    break;
                }                

                trazabilidad_tramite source_trazabilidad = new trazabilidad_tramite();
                source_trazabilidad.id_re_expediente_campotrazable = int.Parse(row.Cells["id_re_expedientes_campostrazables"].Value.ToString());
                try
                {
                    source_trazabilidad.valor_trazable = row.Cells["col_valor_trazable"].Value.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Se encontraron campos trazables sin valor, imposible procesar, favor de revisar", "Error en valores trazables", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                    source_trazabilidad.valor_trazable = null;
                    break;                    
                }                
                sources_trazabilidad.Add(source_trazabilidad);                
                source_trazabilidad = null;
            }
            return result;
        }

        private Boolean colectar_archivosdigital() {
            if (sources_digital.Count() == 0) {
                MessageBox.Show("No se encontraron documentos enlazados, favor de revisar", "Documentos digitales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
            return true;
        }


        //limpiar tramite
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma limpiar el formato", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                limpia_controles_digitales();              
                Inicializa();
                limpia_contenido_grid_campostrazables();
                lookUpEdit_Tramites.Focus();
            }
        }

        private void limpia_contenido_grid_campostrazables()
        {
            foreach (DataGridViewRow row in dataGridView_CamposTrazables.Rows)
            {
                row.Cells["col_valor_trazable"].Value = "";
                row.ErrorText = "";
            }
        }

        //cerrar
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //configurar scanner
        private void btn_config_scann_Click(object sender, EventArgs e)
        {
            Int32 lvRet;
            Boolean lvUserCancel = false;
            lvRet = this.KDImage.ScannerSelect(ref lvUserCancel);
            if (lvRet != 0)
            {
                throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
            }
        }
        #endregion botonera superior

        #region lookUpEdit_Tramites


        private List<data_members.vw_ListaTramitesActivos> lista_tramites = new List<vw_ListaTramitesActivos>();
        private void populate_lookUpEdit_Tramites()
        {
            lista_tramites = Program.Bd_Exp_Transportes.vw_ListaTramitesActivos.ToList(); //obtener la lista de tramites y vincularla al bindingsource
            this.BindingSource_ListaTramites.DataSource = lista_tramites;
            this.lookUpEdit_Tramites.Properties.DataSource = this.BindingSource_ListaTramites; //asignar datasourse al combo
        }

        //seleccionar tramite por default
        private void selectdefaultitem_lookUpEdit_Tramites()
        {
            /*
             * selecciona el tramite a partir de la tabla de configuraciones,
             * el id correspondiente a la fila de la tabla de configuraciones se obtiene 
             * del valor Config_IdTramiteporDefault del archivo de configuraciones general del proyecto
             */
            thumbnail.data_members.tbl_configuraciones Configs = Program.Bd_Exp_Transportes.tbl_configuraciones.SingleOrDefault(c => c.id == Settings.Default.Config_IdTramiteporDefault);
            this.lookUpEdit_Tramites.EditValue = int.Parse(Configs.Valor); //establecer el tramite a seleccionar
        }

        //combo de tramites al cambiar item
        private thumbnail.data_members.vw_ListaTramitesActivos lookUpEdit_Tramites_selected;
        private void lookUpEdit_Tramites_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id_tramite = (int)lookUpEdit_Tramites.EditValue;

                lookUpEdit_Tramites_selected = lista_tramites.SingleOrDefault(query => query.id_tramite == id_tramite);
                populate_dataGridView_campostrazables();
                limpia_control_de_enlazados();
            }
            catch (Exception)
            {                
            }            
        }

        private void lookUpEdit_Tramites_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (lstvwdocumentosenlazados.Items.Count != 0)
                {
                    if (MessageBox.Show("Al cambiar el trámite se perderán los cambios realizados actualmente", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        /*
                         * seleccionar todos los items, para posteriormente llamar al metodo
                         * que mueve los elementos al otro control
                         */ 
                        foreach (ListViewItem item in lstvwdocumentosenlazados.Items)
                        {
                            item.Selected = true;
                        }
                        tsmnuitemlstvwenlacedesenlazar_Click(null, null);
                        sources_digital.Clear();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        //combo de tramites al desplegar la lista
        private void lookUpEdit_Tramites_QueryPopUp(object sender, CancelEventArgs e)
        {
            //this.populate_lookUpEdit_Tramites(); //popular combo
        }

        #endregion lookUpEdit_Tramites

        #region dataGridView_campostrazables
        //popular grid
        private void populate_dataGridView_campostrazables()
        {
            /* obtener campos trazables ejecutando procedimiento almacenado mandando como parametro
             * el id de expediente obtenido de los datos de la seleccion del combo de tramites
             */
            this.BindingSource_CamposTrazables.DataSource = Program.Bd_Exp_Transportes.pa_CampostrazablesActivosporExpediente(lookUpEdit_Tramites_selected.id_expediente);
            this.dataGridView_CamposTrazables.DataSource = this.BindingSource_CamposTrazables;

            this.formatear_celda_principal(); //dar formato a la fila del campo principal
        }

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

        //cuando entra a la fila del grid de campos trazables
        private void dataGridView_CamposTrazables_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * Establecer el maximo de caracteres en el campo valor trazable
             */
            string value = this.dataGridView_CamposTrazables["tamanioCaracteresDataGridViewTextBoxColumn", e.RowIndex].Value.ToString();

            int number;
            bool result = Int32.TryParse(value, out number);
            if (result)
            {
                col_valor_trazable.MaxInputLength = number;
            }

        }
        #endregion dataGridView_campostrazables

        #region botonera de inferior de thumbnails
        private void btn_scanear_Click(object sender, EventArgs e)
        {
            Int32 lvRet;
            Boolean lvUserCancel = false;
            lvRet = KDImage.ScannerAcquireMultiPages(ref lvUserCancel, -1);
            if (lvRet != 0)
            {
                MessageBox.Show("Error: " + KDImage.GetErrorMsg(lvRet));
            }
        }

        private void ofdabrirarchivo_FileOk(object sender, CancelEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();
        }

        private void btn_abririmagen_Click(object sender, EventArgs e)
        {
            if (ofdabrirarchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in ofdabrirarchivo.FileNames)
                {
                    generatethumbnailimage(file);
                }
                Application.DoEvents();

                tlp_proc.Visible = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_limpiarcontroles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma limpiar las listas", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.limpia_controles_digitales();
            }
        }

        private void limpia_controles_digitales() {
            try
            {
                thumbnainlist.Images.Clear();
                lstvwdocumentosescaneados.Clear();
                //File.Delete(pathfiletodelete);
            }
            catch (Exception)
            {
            }
            this.limpia_control_de_enlazados();
        }

        private void limpia_control_de_enlazados() {
            try
            {
                lstvwdocumentosenlazados.Clear();
                sources_digital.Clear();
            }
            catch (Exception)
            {
            }
        }

        #endregion botonera de inferior de thumbnails

        #region tabcontrol

        //asignador de lista de imagen al cambiar el tab
        private void tbctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((TabControl)sender).SelectedIndex)
            {
                case 0:
                    thumbnainlist = thumbnainlistusuario;
                    lstvwdocumentosescaneados = tab0_lstvwdocumentosescaneados;
                    lstvwdocumentosenlazados = tab0_lstvwdocumentosenlazados;
                    break;
                case 1:
                    thumbnainlist = thumbnainlistinterno;
                    lstvwdocumentosescaneados = tab1_lstvwdocumentosescaneados;
                    lstvwdocumentosenlazados = tab1_lstvwdocumentosenlazados;
                    break;
                case 2:
                    thumbnainlist = thumbnainlistexterno;
                    lstvwdocumentosescaneados = tab2_lstvwdocumentosescaneados;
                    lstvwdocumentosenlazados = tab2_lstvwdocumentosenlazados;
                    break;
                case 3:
                    thumbnainlist = thumbnainlistproveedor;
                    lstvwdocumentosescaneados = tab3_lstvwdocumentosescaneados;
                    lstvwdocumentosenlazados = tab3_lstvwdocumentosenlazados;                    
                    break;
            }
            this.lstvwdocumentosescaneados.View = View.LargeIcon;
            this.lstvwdocumentosescaneados.LargeImageList = this.thumbnainlist;
            this.lstvwdocumentosenlazados.View = View.LargeIcon;
            this.lstvwdocumentosenlazados.LargeImageList = this.thumbnainlist;

            this.lstvwdocumentosescaneados.Refresh();
            this.lstvwdocumentosenlazados.Refresh();
        }
        
        #endregion tabcontrol

        //permite establecer el cambio de color al control en donde se va arrastrar un objeto
        private void changedropcolor(System.Windows.Forms.ListView obj, string state)
        {
            Color color = Color.WhiteSmoke;
            switch (state)
            {
                case "droping":
                    color = Color.Silver;
                    break;
            }
            obj.BackColor = color;
            obj.Refresh();
        }

        #region lstvwdocumentosescaneados drag and drop

        private void lstvwdocumentosescaneados_ItemDrag(object sender, ItemDragEventArgs e)
        {
            dragging = lstvwdocumentosescaneados;
            changedropcolor(lstvwdocumentosenlazados, "droping");
            lstvwdocumentosescaneados.DoDragDrop(lstvwdocumentosescaneados.SelectedItems, DragDropEffects.Move);            
        }

        private void lstvwdocumentosescaneados_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))e.Effect = e.AllowedEffect;            
        }

        private void lstvwdocumentosescaneados_DragDrop(object sender, DragEventArgs e)
        {
            changedropcolor(lstvwdocumentosescaneados, "droped");
            changedropcolor(lstvwdocumentosenlazados, "droped");

            if (dragging.Name == lstvwdocumentosescaneados.Name) return;

            if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    desenlazaitems((ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)));
                }
                else
                {
                    foreach (ListViewItem current in (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)))
                    {
                        current.Remove();
                        lstvwdocumentosescaneados.Items.Add((ListViewItem)current);
                    }
                }
            }
        }
        
        #endregion  #region lstvwdocumentosescaneados drag and drop

        #region lstvwdocumentosenlazados drag and drop
        
        private void lstvwdocumentosenlazados_ItemDrag(object sender, ItemDragEventArgs e)
        {
            dragging = lstvwdocumentosenlazados;
            changedropcolor(lstvwdocumentosescaneados, "droping");
            lstvwdocumentosenlazados.DoDragDrop(lstvwdocumentosenlazados.SelectedItems, DragDropEffects.Move);
        }

        private void lstvwdocumentosenlazados_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))e.Effect = e.AllowedEffect;
        }

        private void lstvwdocumentosenlazados_DragDrop(object sender, DragEventArgs e)
        {
            changedropcolor(lstvwdocumentosenlazados, "droped");
            changedropcolor(lstvwdocumentosescaneados, "droped");

            if (dragging.Name == lstvwdocumentosenlazados.Name) return;

            if (e.Data.GetDataPresent(typeof(ListView.SelectedListViewItemCollection)))
            {
                if (e.Effect == DragDropEffects.Move)
                {                    
                    enlazaitems((ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)));
                }
            }
        }

        public List<thumbnail.models.digital> sources_digital = new List<thumbnail.models.digital>();
        public thumbnail.models.digital source_digital = new thumbnail.models.digital(); //instancia a modelo principal para el guardado de la información
        frm_hook frm = new frm_hook(); //inicializar formulario
        private bool hocking()
        {
            int tramite = lookUpEdit_Tramites_selected.id_tramite; //obtener el id del tramite a partir del combo de tramites
            int origen = Convert.ToInt32(tbctrl.SelectedTab.Tag.ToString()); //obtener el origen a partir del tab seleccionado

            frm.inicializa(tramite, origen, sources_digital);

            DialogResult result = frm.ShowDialog(this); //mostrar forlulario

            //int idx = lstvwdocumentosescaneados.SelectedItems[0].ImageIndex;
            if (result == DialogResult.OK)
            {
                source_digital.id_re_clasificaciondocumento_documento = frm.source.id_re_clasificaciondocumento_documento; //se asigna el id del documento retornado de la forma al colector principal
                source_digital.valor_trazable = frm.source.valor_trazable; //se asigna el valor trazable retornado de la forma al colector principal
                source_digital.clasificaciondocumento = frm.source.clasificaciondocumento; //se asigna la clasificacion de documento retornado de la forma al colector principal
                source_digital.documento = frm.source.documento; //se asigna el nombre de documento retornado de la forma al colector principal

                addlistviewgroup(); //agregar grupo

                return true;
            }
            else if (result == DialogResult.Cancel)
            {
                return false;
            }
            return false;
        }

        //funcion que agrega grupos al control de lista [lstvwdocumentosenlazados]
        private void addlistviewgroup()
        {
            ListViewGroup grupo = new ListViewGroup();
            grupo.Name = source_digital.clasificaciondocumento; //obtener el nombre del grupo a partir de su clasificacion de documento
            grupo.Header = source_digital.clasificaciondocumento + " [ " + source_digital.documento + " ] [ " + source_digital.valor_trazable + " ]"; //concatenar la clasificacion de documentos con el nombre del documento
            grupo.HeaderAlignment = HorizontalAlignment.Left;

            Boolean existe = false;
            foreach (ListViewGroup _grupo in lstvwdocumentosenlazados.Groups)
            {
                if (_grupo.Name == grupo.Name)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                lstvwdocumentosenlazados.Groups.Add(grupo); //agregar grupo
            }
        }

        private void removelistviewgroup(ListViewItem item)
        {
            try
            {
                ListViewGroup grupo = item.Group;
                
                item.Group = null;

                if (lstvwdocumentosenlazados.Groups[grupo.Name].Items.Count == 0) {
                    lstvwdocumentosenlazados.Groups.Remove(grupo);                
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion lstvwdocumentosenlazados drag and drop

        //habilita o deshabilita opciones del menu de las imagenes de documentos escaneados 
        private void cntmnuListViewScann_Opening(object sender, CancelEventArgs e)
        {
            int numItemsSelects = lstvwdocumentosescaneados.SelectedItems.Count;

            e.Cancel = (numItemsSelects == 0 ? true : false);

            tsmnuitemlstvwscannabrir.Visible = (numItemsSelects == 1 ? true : false);
            tsmnuitemlstvwscanneliminar.Visible = (numItemsSelects >= 1 ? true : false);
            tsmnuitemlstvwscannenlazarsubmnuseleccionado.Visible = (numItemsSelects == 1 ? true : false);
            tsmnuitemlstvwscannenlazarsubmnutodo.Visible = true;
            //tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar.Visible = (numItemsSelects >= 1 ? true : false);
            tsmnuitemlstvwscannseltodo.Visible = true;
            tsmnuitemlstvwscannrotarderecha.Visible = (numItemsSelects >= 1 ? true : false);
            tsmnuitemlstvwscannrotarizquierda.Visible = (numItemsSelects >= 1 ? true : false);
        }

        //habilita o deshabilita opciones del menu de las imagenes de documentos enlazados
        private void cntmnuListViewEnlace_Opening(object sender, CancelEventArgs e)
        {
            int numItemsSelects = lstvwdocumentosenlazados.SelectedItems.Count;

            e.Cancel = (numItemsSelects == 0 ? true : false);

            tsmnuitemlstvwenlaceabrir.Visible = (numItemsSelects == 1 ? true : false);
            //tsmnuitemlstvwenlaceeliminar.Visible = (numItemsSelects >= 1 ? true : false);
            tsmnuitemlstvwenlacedesenlazar.Visible = (numItemsSelects >= 1 ? true : false);
            //tsmnuitemlstvwenlacedesenlazartodo.Visible = true;
            tsmnuitemlstvwenlacegirarderecha.Visible = (numItemsSelects >= 1 ? true : false);
            tsmnuitemlstvwenlacegirarizquierda.Visible = (numItemsSelects >= 1 ? true : false);
        }

        //funcion generica para la rotacion de imagenes
        private void rotateimage(System.Windows.Forms.ListView obj, RotateFlipType rotacion)
        {
            foreach (ListViewItem item in obj.SelectedItems)
            {
                //rotar imagen del la lista de imagenes
                int idx = item.ImageIndex;
                Image img = item.ImageList.Images[idx];
                img.RotateFlip(rotacion);
                this.thumbnainlist.Images[idx] = img;

                string path_filename = ( (tagstruct) item.Tag ).path_image.ToString();
                
                double rotateangle = 0;
                switch (rotacion)
	            {
		            case RotateFlipType.Rotate90FlipNone:
                        rotateangle = 90;
                        break;
                    case RotateFlipType.Rotate90FlipXY:
                        rotateangle = -90;
                        break;
	            }

                int lvRet = KDImage.FileOpen(path_filename, KDImageEditor.TxPictureType.ptAutoDetect, 1);
                if (lvRet != 0)
                {
                    throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
                }

                lvRet = KDImage.Rotate(rotateangle);
                if (lvRet != 0)
                {
                    throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
                }

                lvRet = KDImage.FileSave(path_filename, KDImageEditor.TxPictureType.ptAutoDetect);
                if (lvRet != 0)
                {
                    throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
                }
                
            }
            obj.Refresh();
        }

        #region menu documentos escaneados
//rotar a la derecha
        private void tsmnuitemlstvwscannrotarderecha_Click(object sender, EventArgs e)
        {
            rotateimage(this.lstvwdocumentosescaneados, RotateFlipType.Rotate90FlipNone);
        }

//rotar a la izquierda
        private void tsmnuitemlstvwscannrotarizquierda_Click(object sender, EventArgs e)
        {
            rotateimage(this.lstvwdocumentosescaneados, RotateFlipType.Rotate90FlipXY);
        }

        private void enlazaitems(System.Windows.Forms.ListView.SelectedListViewItemCollection Collection) {
            if (!hocking()) return;
            foreach (ListViewItem item in Collection)
            {
                thumbnail.models.digital source = new thumbnail.models.digital();

                if (Form_Mode == form_mode.Add)
                {
                    source = new thumbnail.models.digital();

                    Image img = Image.FromFile(((tagstruct)item.Tag).path_image.ToString());
                    source.imagen = img; //asignar imagen al colector principal
                    source.thumbnail = ((ListViewItem)item).ImageList.Images[((ListViewItem)item).ImageIndex];
                    //img.Dispose();
                    source.id_re_clasificaciondocumento_documento = source_digital.id_re_clasificaciondocumento_documento;
                    source.valor_trazable = source_digital.valor_trazable;
                    source.clasificaciondocumento = source_digital.clasificaciondocumento;
                    source.documento = source_digital.documento;
                    source.guid = ((tagstruct)item.Tag).guid.ToString();
                }
                else if (Form_Mode == form_mode.Edit)
                {
                    source = sources_digital.FirstOrDefault(c => c.guid == ((tagstruct)item.Tag).guid.ToString());
                    source.id_re_clasificaciondocumento_documento = source_digital.id_re_clasificaciondocumento_documento;
                    source.valor_trazable = source_digital.valor_trazable;
                    source.clasificaciondocumento = source_digital.clasificaciondocumento;
                    source.documento = source_digital.documento;
                    source.enlazado = true;
                }

                item.Remove();

                lstvwdocumentosenlazados.Items.Add((ListViewItem)item.Clone());

                int idxgroup = 0;
                foreach (ListViewGroup grupo in lstvwdocumentosenlazados.Groups)
                {
                    if (grupo.Name == source.clasificaciondocumento)
                    {
                        break;
                    }
                    idxgroup++;
                }

                lstvwdocumentosenlazados.Items[lstvwdocumentosenlazados.Items.Count - 1].Group = lstvwdocumentosenlazados.Groups[idxgroup];

                if (Form_Mode == form_mode.Add)
                {
                    sources_digital.Add(source);
                }
                source = null;
            }
        }

//boton de enlazar
        private void tsmnuitemlstvwscannenlazar_Click(object sender, EventArgs e)
        {
            enlazaitems(lstvwdocumentosescaneados.SelectedItems);
            cntmnuListViewScann.Hide();
            try
            {
                lstvwdocumentosescaneados.Items[0].Selected = true;
            }
            catch (Exception)
            {
            }
        }

//boton submenu enlazar/todo
        private void tsmnuitemlstvwscannenlazarsubmnutodo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvwdocumentosescaneados.Items)
                item.Selected = true;
            enlazaitems(lstvwdocumentosescaneados.SelectedItems);
        }

//boton submenu enlazar/duplicar y enlazar
        private void tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvwdocumentosescaneados.SelectedItems)
            {
                lstvwdocumentosenlazados.Items.Add((ListViewItem)item.Clone());
            }
        }

//boton de eliminar
        private void tsmnuitemlstvwscanneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma el borrado", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                deletethumbnailandimage(lstvwdocumentosescaneados);
            }            
        }

//boton seleccionar todo
        private void tsmnuitemlstvwscannseltodo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvwdocumentosescaneados.Items)
            {
                item.Selected = true;
            }
        }

//boton abrir
        private void tsmnuitemlstvwscannabrir_Click(object sender, EventArgs e)
        {
            frmimgViewer testDialog = new frmimgViewer( ( (tagstruct) lstvwdocumentosescaneados.SelectedItems[0].Tag ).path_image.ToString() );

            DialogResult result = testDialog.ShowDialog(this);

            int idx = lstvwdocumentosescaneados.SelectedItems[0].ImageIndex;
            if (result == DialogResult.Yes)
            {
                Image img = Image.FromFile( ( (tagstruct) lstvwdocumentosescaneados.SelectedItems[0].Tag ).path_image.ToString() );
                thumbnainlist.Images[idx] = classes.thumbnail.getThumbnaiImage(thumbnainlist.ImageSize.Width, img);
                lstvwdocumentosescaneados.Refresh();
            }
            else if (result == DialogResult.OK) {
                deletethumbnailandimage(lstvwdocumentosescaneados);
            }

            testDialog.Dispose();
        }
        #endregion menu documentos escaneados

        #region menu documentos enlazados
//rotar a la derecha
        private void tsmnuitemlstvwenlacegirarderecha_Click(object sender, EventArgs e)
        {
            rotateimage(this.lstvwdocumentosenlazados, RotateFlipType.Rotate90FlipNone);
        }
//rotar a la isquierda
        private void tsmnuitemlstvwenlacegirarizquierda_Click(object sender, EventArgs e)
        {
            rotateimage(this.lstvwdocumentosenlazados, RotateFlipType.Rotate90FlipXY);
        }

        private void desenlazaitems(System.Windows.Forms.ListView.SelectedListViewItemCollection Collection)
        {
            foreach (ListViewItem item in Collection)
            {
                try
                {
                    if (Form_Mode == form_mode.Add)
                    {
                        sources_digital.Remove(sources_digital.FirstOrDefault(c => c.guid == ((tagstruct)item.Tag).guid.ToString()));
                    }
                    else if (Form_Mode == form_mode.Edit)
                    {
                        digital source = sources_digital.FirstOrDefault(c => c.guid == ((tagstruct)item.Tag).guid.ToString());
                        source.enlazado = false;
                    }

                    this.removelistviewgroup(item); //eliminar grupo en caso de que este vacío
                    lstvwdocumentosenlazados.Items.Remove(lstvwdocumentosenlazados.SelectedItems[0]);
                }
                catch (Exception) { }
                lstvwdocumentosescaneados.Items.Add((ListViewItem)item.Clone());
            }          
        }

//boton desenlazar
        private void tsmnuitemlstvwenlacedesenlazar_Click(object sender, EventArgs e)
        {
            desenlazaitems(lstvwdocumentosenlazados.SelectedItems);
            cntmnuListViewEnlace.Hide();            
        }

//boton abrir
        private void tsmnuitemlstvwenlaceabrir_Click(object sender, EventArgs e)
        {
            frmimgViewer testDialog;
            if (Form_Mode == form_mode.Add)
            {
                testDialog = new frmimgViewer(((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag).path_image.ToString());
            }
            else {
                tagstruct edittag = ((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag);

                if (edittag.path_image != null)
                {
                    testDialog = new frmimgViewer(edittag.path_image);
                }
                else
                {
                    testDialog = new frmimgViewer(((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag).id_ma_digital_edit,
                                                   ((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag).id,
                                                   ((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag).id_re_clasificaciondocumento_documento);
                    edittag.path_image = testDialog.pathimageoriginal;
                    lstvwdocumentosenlazados.SelectedItems[0].Tag = edittag;
                }
            }

            DialogResult result = testDialog.ShowDialog(this);

            int idx = lstvwdocumentosenlazados.SelectedItems[0].ImageIndex;
            if (result == DialogResult.Yes)
            {
                Image img = null;
                tagstruct sourcetag = ((tagstruct)lstvwdocumentosenlazados.SelectedItems[0].Tag);
                img = Image.FromFile(sourcetag.path_image);
                if (Form_Mode == form_mode.Edit)
                {                    
                    digital source = sources_digital.FirstOrDefault(c => c.guid == sourcetag.guid);
                    source.editado = true;
                }

                thumbnainlist.Images[idx] = classes.thumbnail.getThumbnaiImage(thumbnainlist.ImageSize.Width, img);
                img.Dispose();
                lstvwdocumentosenlazados.Refresh();
            }
            else if (result == DialogResult.OK)
            {
                desenlazaitems(lstvwdocumentosenlazados.SelectedItems);
            }

            testDialog.Dispose();
        }

//boton eliminar
        private void tsmnuitemlstvwenlaceeliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma el borrado", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                deletethumbnailandimage(lstvwdocumentosenlazados);
            }
        }

//boton desenlazar todo el grupo
        private void tsmnuitemlstvwenlacedesenlazartodo_Click(object sender, EventArgs e)
        {

        }
        #endregion menu documentos enlazados

        //elimina el thumbnail
        private void deletethumbnailandimage(ListView obj) {
            foreach (ListViewItem item in obj.SelectedItems)
            {
                string pathfiletodelete =  ((tagstruct)item.Tag).path_image.ToString();
                int idx = item.ImageIndex;
                thumbnainlist.Images.RemoveAt(idx);
                item.Remove();
                //File.Delete(pathfiletodelete);
            }
            obj.Refresh();
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
        public tagstruct tag; //variable global para los tag de los items               

        //metodo para generar thumbnail de imagen
        private void generatethumbnailimage(string file)
        {
            Image img = Image.FromFile(file);
            thumbnainlist.Images.Add(classes.thumbnail.getThumbnaiImage(thumbnainlist.ImageSize.Width, img));

            this.lstvwdocumentosescaneados.Items.Add("", (int)thumbnainlist.Images.Count - 1);
            
            tag.path_image = file.ToString();
            tag.guid =  Guid.NewGuid().ToString();

            this.lstvwdocumentosescaneados.Items[lstvwdocumentosescaneados.Items.Count - 1].Tag = tag;
        }

        //evento de escaneo kdimage
        private void KDImage_OnScannerPageAcquired(object sender, AxKDImageEditor.IKDImageEvents_OnScannerPageAcquiredEvent e)
        {
            Int32 lvRet;
            string pathfilename = scannfilename + ".jpg";
            lvRet = KDImage.FileSave(pathfilename, KDImageEditor.TxPictureType.ptJPEG);
            if (lvRet != 0) {
                KDImage.ScannerStop();
                MessageBox.Show("Error: " + KDImage.GetErrorMsg(lvRet));
            }
            generatethumbnailimage(pathfilename); 
        }

        private void dataGridView_CamposTrazables_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 6) { //si la columna es igual a la de valor trazable
                string mascara = dataGridView_CamposTrazables.Rows[e.RowIndex].Cells["mascaraDataGridViewTextBoxColumn"].Value.ToString();
                int tamaniocaracteres = int.Parse(dataGridView_CamposTrazables.Rows[e.RowIndex].Cells["tamanioCaracteresDataGridViewTextBoxColumn"].Value.ToString()); 

                if (!string.IsNullOrEmpty(mascara))
                {
                    int tamanioreal = e.FormattedValue.ToString().Length;

                    dataGridView_CamposTrazables.Rows[e.RowIndex].ErrorText = "";

                    if( (tamanioreal != 0) && (tamanioreal != tamaniocaracteres) )
                    {
                        dataGridView_CamposTrazables.Rows[e.RowIndex].ErrorText = "El valor trazable no cumple los criterios de longitud de la mascara, favor de revisar";                        
                    }                                        
                }
            }
        }

        void txt_validator_Validating(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        void txt_validator_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {            
            MessageBox.Show("error en mascara");
        }

        int id_ma_digital_edit;
        private void btn_editar_Click(object sender, EventArgs e)
        {           
            frm_abrir_tramite frm = new frm_abrir_tramite();
            DialogResult result = frm.ShowDialog(this);
            id_ma_digital_edit = 0;
            if (result == System.Windows.Forms.DialogResult.OK) {
                id_ma_digital_edit = (frm.pa_ReferenciaExpedientesporValorTrazableResultBindingSource.Current as data_members.pa_ReferenciaExpedientesporValorTrazableResult).id_ma_digital;
                Form_Mode = form_mode.Edit;
            }
            frm.Dispose();

            if (id_ma_digital_edit != 0) 
            {
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

        }

        private void obtenerregistrosaeditar()
        {
            inicializaedicion();
            obtenercampostrazablesaeditar();
            obtenerarchivodigital();
        }

        private void inicializaedicion() {
            sources_digital.Clear();
            thumbnainlist.Images.Clear();
            lstvwdocumentosenlazados.Groups.Clear();
            lstvwdocumentosenlazados.Clear();            
        }

        //estructura para la informacion en tag        
        private void obtenerarchivodigital()
        {
            List<data_members.pa_RegistrosDigitalesRegistradosporId_ma_digitalResult> imagenesdigitalregistradas =
                new List<pa_RegistrosDigitalesRegistradosporId_ma_digitalResult>(Program.Bd_Exp_Transportes.pa_RegistrosDigitalesRegistradosporId_ma_digital(id_ma_digital_edit));

            foreach (data_members.pa_RegistrosDigitalesRegistradosporId_ma_digitalResult current in imagenesdigitalregistradas)
            {
                thumbnail.models.digital source = new thumbnail.models.digital();

                Image img = procesa_imagen.ByteArrayToImage(current.thumbnail.ToArray());
                source.thumbnail = img;
                source.id_re_clasificaciondocumento_documento = current.id_re_clasificaciondocumento_documento;
                source.valor_trazable = current.valor_trazable;
                source.clasificaciondocumento = current.clasificaciondocumento;
                source.documento = current.Documento;
                source.guid = Guid.NewGuid().ToString();
                source.enlazado = true;
                source.editado = false;
                
                thumbnainlist.Images.Add(img);
                this.lstvwdocumentosenlazados.Items.Add("", (int)thumbnainlist.Images.Count - 1);

                tagstruct tagedit = new tagstruct();
                tagedit.guid = source.guid;
                tagedit.id = current.id;
                tagedit.id_ma_digital_edit = id_ma_digital_edit;
                tagedit.id_re_clasificaciondocumento_documento = source.id_re_clasificaciondocumento_documento;

                this.lstvwdocumentosenlazados.Items[lstvwdocumentosenlazados.Items.Count - 1].Tag = tagedit;

                ListViewGroup _grupo = new ListViewGroup();
                _grupo.Name = source.clasificaciondocumento; //obtener el nombre del grupo a partir de su clasificacion de documento
                _grupo.Header = source.clasificaciondocumento + " [ " + source.documento + " ][ " + source.valor_trazable + " ]"; //concatenar la clasificacion de documentos con el nombre del documento
                _grupo.HeaderAlignment = HorizontalAlignment.Left;

                Boolean existe = lstvwdocumentosenlazados.Groups.Contains(_grupo);

                if (!existe) lstvwdocumentosenlazados.Groups.Add(_grupo); //agregar grupo

                lstvwdocumentosenlazados.Items[lstvwdocumentosenlazados.Items.Count - 1].Group = lstvwdocumentosenlazados.Groups[_grupo.Name];

                sources_digital.Add(source);
                source = null;
            }

        }

        private void obtenercampostrazablesaeditar() { 
            /* obtener campos trazables ejecutando procedimiento almacenado mandando como parametro
             * el id de maestro digital
             */
            this.BindingSource_CamposTrazables.DataSource = Program.Bd_Exp_Transportes.pa_CampostrazablesRegistradosporId_ma_digital(id_ma_digital_edit);
            this.dataGridView_CamposTrazables.DataSource = this.BindingSource_CamposTrazables;                        

            this.formatear_celda_principal(); //dar formato a la fila del campo principal
        }



    }
}
