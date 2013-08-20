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
        public enum formmode
        {
            Add,
            Edit
        }

        //property para el control del estado del formulario
        private formmode _formmode;
        public formmode Form_Mode { get { return _formmode; } set { _formmode = value; } }

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

        private BindingSource BindingSource_ListaTramites;
        private BindingSource BindingSource_CamposTrazables;

        private tramite_model tramite = new tramite_model();

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
            Form_Mode = formmode.Add; //inicializar por default el formulario en modo add

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

            tramite.imagenes_digital.Clear();
            tramite.trazabilidad.Clear();
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
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!this.colectar_campostrazables()) return;
            if (!this.colectar_archivosdigital()) return;

            tramite.trazabilidad = sources_trazabilidad;

            /* if (expedientemode == __formmode.Add) crearexpediente();
             else editarexpediente();*/
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
                    break;
                    source_trazabilidad.valor_trazable = null;
                }                
                source_trazabilidad.fecha = obtener.fecha();
                source_trazabilidad.hora = obtener.hora();
                sources_trazabilidad.Add(source_trazabilidad);
                source_trazabilidad = null;
            }
            return result;
        }

        private Boolean colectar_archivosdigital() {
            tramite.imagenes_digital.Clear();
            if (sources_digital.Count() == 0) {
                MessageBox.Show("No se encontraron documentos enlazados, favor de revisar", "Documentos digitales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            tramite.imagenes_digital = sources_digital;
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

        private void populate_lookUpEdit_Tramites()
        {
            this.BindingSource_ListaTramites = new BindingSource(); //instanciar
            this.BindingSource_ListaTramites.DataSource = Program.Bd_Exp_Transportes.vw_ListaTramitesActivos.ToList(); //obtener la lista de tramites y vincularla al bindingsource
            this.lookUpEdit_Tramites.Properties.DataSource = this.BindingSource_ListaTramites; //asignar datasourse al combo
            this.lookUpEdit_Tramites.Properties.DisplayMember = "Nombre_tramite"; //establecer el campo a mostrar en combo
            this.lookUpEdit_Tramites.Properties.ValueMember = "id_tramite"; //establecer valor a manejar en combo
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
            this.lookUpEdit_Tramites_selected = ((LookUpEdit)sender).Properties.GetDataSourceRowByKeyValue(((LookUpEdit)sender).EditValue) as thumbnail.data_members.vw_ListaTramitesActivos; //asignar la seleccion del combo
            populate_dataGridView_campostrazables();
            limpia_control_de_enlazados();
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
            this.BindingSource_CamposTrazables = new BindingSource(); //instanciar
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
                    foreach (ListViewItem current in (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)))
                    {
                        try
                        {
                            sources_digital.Remove(sources_digital.FirstOrDefault(c => c.guid == ((tagstrunct)current.Tag).guid.ToString()));

                            this.removelistviewgroup(current); //eliminar grupo en caso de que este vacío
                            lstvwdocumentosenlazados.Items.Remove(lstvwdocumentosenlazados.SelectedItems[0]);
                        }
                        catch (Exception) { }
                        lstvwdocumentosescaneados.Items.Add((ListViewItem)current.Clone());                        
                    }                    
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
                if (!hocking()) return;

                if (e.Effect == DragDropEffects.Move)
                {
                    foreach (ListViewItem current in (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)))
                    {
                        thumbnail.models.digital source = new thumbnail.models.digital();

                        Image img = Image.FromFile(  ( (tagstrunct) current.Tag ).path_image.ToString()  );
                        source.imagen = img; //asignar imagen al colector principal
                        img.Dispose();
                        source.id_re_clasificaciondocumento_documento = source_digital.id_re_clasificaciondocumento_documento;
                        source.valor_trazable = source_digital.valor_trazable;
                        source.clasificaciondocumento = source_digital.clasificaciondocumento;
                        source.documento = source_digital.documento;
                        source.guid = ((tagstrunct)current.Tag).guid.ToString();
                        source.fecha = obtener.fecha(); //asignar fecha al colector principal
                        source.hora = obtener.hora();//asignar hora al colector principal

                        try
                        {
                            lstvwdocumentosescaneados.Items.Remove(lstvwdocumentosescaneados.SelectedItems[0]);
                        }
                        catch (Exception) { }
                        
                        lstvwdocumentosenlazados.Items.Add((ListViewItem)current.Clone());

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

                        sources_digital.Add(source);
                        source = null;
                    }
                }
                else
                {
                    foreach (ListViewItem current in (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)))
                    {
                        current.Remove();
                        lstvwdocumentosenlazados.Items.Add((ListViewItem)current);
                    }
                }
            }
        }

        public List<thumbnail.models.digital> sources_digital = new List<thumbnail.models.digital>();
        public thumbnail.models.digital source_digital = new thumbnail.models.digital(); //instancia a modelo principal para el guardado de la información
        frm_hook frm = new frm_hook(); //inicializar formulario
        private bool hocking()
        {
            int tramite = lookUpEdit_Tramites_selected.id_tramite; //obtener el id del tramite a partir del combo de tramites
            int origen = tbctrl.SelectedIndex + 1; //obtener el origen a partir del tab seleccionado

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
            grupo.Header = source_digital.clasificaciondocumento + " [ " + source_digital.documento + " ]"; //concatenar la clasificacion de documentos con el nombre del documento
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

                string path_filename = ( (tagstrunct) item.Tag ).path_image.ToString();
                
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

//boton de enlazar
        private void tsmnuitemlstvwscannenlazar_Click(object sender, EventArgs e)
        {
            if (!hocking()) return;

            foreach (ListViewItem item in lstvwdocumentosescaneados.SelectedItems)
            {
                thumbnail.models.digital source = new thumbnail.models.digital();

                Image img = Image.FromFile(((tagstrunct)item.Tag).path_image.ToString());
                source.imagen = img; //asignar imagen al colector principal
                img.Dispose();
                source.id_re_clasificaciondocumento_documento = source_digital.id_re_clasificaciondocumento_documento;
                source.valor_trazable = source_digital.valor_trazable;
                source.clasificaciondocumento = source_digital.clasificaciondocumento;
                source.documento = source_digital.documento;
                source.guid = ((tagstrunct)item.Tag).guid.ToString();
                source.fecha = obtener.fecha(); //asignar fecha al colector principal
                source.hora = obtener.hora();//asignar hora al colector principal

                item.Remove();

                lstvwdocumentosenlazados.Items.Add((ListViewItem)item.Clone());
                
                int idxgroup = 0;
                foreach (ListViewGroup grupo in lstvwdocumentosenlazados.Groups)
                {
                    if (grupo.Name == source_digital.clasificaciondocumento)
                    {
                        break;
                    }
                    idxgroup++;
                }

                lstvwdocumentosenlazados.Items[lstvwdocumentosenlazados.Items.Count - 1].Group = lstvwdocumentosenlazados.Groups[idxgroup];

                sources_digital.Add(source);                
            }
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
            if (!hocking()) return;

            foreach (ListViewItem item in lstvwdocumentosescaneados.Items)
            {
                thumbnail.models.digital source = new thumbnail.models.digital();

                Image img = Image.FromFile(((tagstrunct)item.Tag).path_image.ToString());
                source.imagen = img; //asignar imagen al colector principal
                img.Dispose();
                source.id_re_clasificaciondocumento_documento = source_digital.id_re_clasificaciondocumento_documento;
                source.valor_trazable = source_digital.valor_trazable;
                source.clasificaciondocumento = source_digital.clasificaciondocumento;
                source.documento = source_digital.documento;
                source.guid = ((tagstrunct)item.Tag).guid.ToString();
                source.fecha = obtener.fecha(); //asignar fecha al colector principal
                source.hora = obtener.hora();//asignar hora al colector principal

                item.Remove();

                lstvwdocumentosenlazados.Items.Add((ListViewItem)item.Clone());

                int idxgroup = 0;
                foreach (ListViewGroup grupo in lstvwdocumentosenlazados.Groups)
                {
                    if (grupo.Name == source_digital.clasificaciondocumento)
                    {
                        break;
                    }
                    idxgroup++;
                }

                lstvwdocumentosenlazados.Items[lstvwdocumentosenlazados.Items.Count - 1].Group = lstvwdocumentosenlazados.Groups[idxgroup];

                sources_digital.Add(source);
            }
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
            frmimgViewer testDialog = new frmimgViewer( ( (tagstrunct) lstvwdocumentosescaneados.SelectedItems[0].Tag ).path_image.ToString() );

            DialogResult result = testDialog.ShowDialog(this);

            int idx = lstvwdocumentosescaneados.SelectedItems[0].ImageIndex;
            if (result == DialogResult.Yes)
            {
                Image img = Image.FromFile( ( (tagstrunct) lstvwdocumentosescaneados.SelectedItems[0].Tag ).path_image.ToString() );
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

//boton desenlazar
        private void tsmnuitemlstvwenlacedesenlazar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvwdocumentosenlazados.SelectedItems)
            {
                try
                {
                    sources_digital.Remove(sources_digital.FirstOrDefault(c => c.guid == ((tagstrunct)item.Tag).guid.ToString()));

                    this.removelistviewgroup(item);
                    lstvwdocumentosenlazados.Items.Remove(item);
                }
                catch (Exception)
                {
                }
                lstvwdocumentosescaneados.Items.Add((ListViewItem)item.Clone());
            }
            cntmnuListViewEnlace.Hide();
            
        }

//boton abrir
        private void tsmnuitemlstvwenlaceabrir_Click(object sender, EventArgs e)
        {
            frmimgViewer testDialog = new frmimgViewer(((tagstrunct)lstvwdocumentosenlazados.SelectedItems[0].Tag).path_image.ToString() );

            DialogResult result = testDialog.ShowDialog(this);

            int idx = lstvwdocumentosenlazados.SelectedItems[0].ImageIndex;
            if (result == DialogResult.Yes)
            {
                Image img = Image.FromFile(((tagstrunct)lstvwdocumentosenlazados.SelectedItems[0].Tag).path_image.ToString());
                thumbnainlist.Images[idx] = classes.thumbnail.getThumbnaiImage(thumbnainlist.ImageSize.Width, img);
                lstvwdocumentosenlazados.Refresh();
            }
            else if (result == DialogResult.OK)
            {
                deletethumbnailandimage(lstvwdocumentosenlazados);
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
                string pathfiletodelete =  ((tagstrunct)item.Tag).path_image.ToString();
                int idx = item.ImageIndex;
                thumbnainlist.Images.RemoveAt(idx);
                item.Remove();
                //File.Delete(pathfiletodelete);
            }
            obj.Refresh();
        }

        //estructura para la informacion en tag
        public struct tagstrunct
        {
            public string path_image;
            public string guid;
        };
        public tagstrunct tag; //variable global para los tag de los items
        
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
                    
                    /*TextEdit txt_validator = new TextEdit();
                    txt_validator.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                    txt_validator.Properties.Mask.EditMask = mascara;
                    txt_validator.Properties.ValidateOnEnterKey = true;
                    txt_validator.InvalidValue += txt_validator_InvalidValue;
                    txt_validator.Validating += txt_validator_Validating;
                    txt_validator.Properties.Mask.IgnoreMaskBlank = false;

                    txt_validator.Properties.BeginInit();
                    txt_validator.Properties.BeginUpdate();
                    txt_validator.Text = e.FormattedValue.ToString();
                    txt_validator.Properties.EndUpdate();
                    txt_validator.Properties.EndInit();

                    //txt_validator.Properties.va
                    */

                    

                    //dataGridView_CamposTrazables.Rows[e.RowIndex].ErrorText = "El valor trazable no cumple los criterios de mascara, favor de revisar";
                    //e.Cancel = true;
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

    }
}
