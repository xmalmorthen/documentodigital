using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using thumbnail.forms;
using thumbnail.Properties;
using System.Configuration;
using thumbnail.data_members;
using DevExpress.XtraEditors;
using thumbnail.models;
using DevExpress.XtraGrid.Views.Grid;

namespace thumbnail
{
    public partial class scann : Form
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

        thumbnail.data_members.Bd_Exp_TransportesDataContext Bd_Exp_Transportes;

        private BindingSource BindingSource_ListaTramites;
        private BindingSource BindingSource_CamposTrazables;
        #endregion enumss, propertys, variables, etc

        //contructor de clase
        public scann()
        {
            InitializeComponent();
            Inicializa();
        }

        //funcion de configuraciones iniciales
        private void Inicializa()
        {
            Form_Mode = formmode.Add; //inicializar por default el formulario en modo add

            Bd_Exp_Transportes = new thumbnail.data_members.Bd_Exp_TransportesDataContext(); //instanciar variable base de datos
            
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
        }


        //load de form
        private void scann_Load(object sender, EventArgs e)
        {
            this.lookUpEdit_Tramites.Focus(); //establecer el foco al combo de tramites al iniciar el form
        }

        #region botonera superior
        //guardar tramite
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            /* if (expedientemode == __formmode.Add) crearexpediente();
             else editarexpediente();*/
        }

        //limpiar tramite
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            /* if (MessageBox.Show("Confirma limpiar el formato", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
             {
                 //bindingSource3.Clear();
                 lstvwdocumentosescaneados.Items.Clear();
                 lstvwdocumentosenlazados.Items.Clear();
                 thumbnainlist.Images.Clear();

                 expediente.expedientedocumentodigital.Clear();
                 expediente.expedientetrazable.Clear();

                 Inicializa();
             }*/
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
            this.BindingSource_ListaTramites.DataSource = this.Bd_Exp_Transportes.vw_ListaTramitesActivos.ToList(); //obtener la lista de tramites y vincularla al bindingsource
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
            thumbnail.data_members.tbl_configuraciones Configs = Bd_Exp_Transportes.tbl_configuraciones.SingleOrDefault(c => c.id == Settings.Default.Config_IdTramiteporDefault);
            this.lookUpEdit_Tramites.EditValue = int.Parse(Configs.Valor); //establecer el tramite a seleccionar
        }

        //combo de tramites al cambiar item
        private thumbnail.data_members.vw_ListaTramitesActivos lookUpEdit_Tramites_selected;
        private void lookUpEdit_Tramites_EditValueChanged(object sender, EventArgs e)
        {
            this.lookUpEdit_Tramites_selected = ((LookUpEdit)sender).Properties.GetDataSourceRowByKeyValue(((LookUpEdit)sender).EditValue) as thumbnail.data_members.vw_ListaTramitesActivos; //asignar la seleccion del combo
            populate_dataGridView_campostrazables();
        }

        //combo de tramites al desplegar la lista
        private void lookUpEdit_Tramites_QueryPopUp(object sender, CancelEventArgs e)
        {
            this.populate_lookUpEdit_Tramites(); //popular combo
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
            this.BindingSource_CamposTrazables.DataSource = this.Bd_Exp_Transportes.pa_CampostrazablesActivosporExpediente(lookUpEdit_Tramites_selected.id_expediente);
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

        private void btn_abririmagen_Click(object sender, EventArgs e)
        {
            if (ofdabrirarchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in ofdabrirarchivo.FileNames)
                {
                    generatethumbnailimage(file);
                }
            }
        }

        private void btn_limpiarcontroles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma limpiar las listas", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                thumbnainlist.Images.Clear();
                lstvwdocumentosescaneados.Clear();
                lstvwdocumentosenlazados.Clear();
                //File.Delete(pathfiletodelete);
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
                            lstvwdocumentosenlazados.Items.Remove(lstvwdocumentosenlazados.SelectedItems[0]);
                        }
                        catch (Exception) { }
                        lstvwdocumentosescaneados.Items.Add((ListViewItem)current.Clone());                        
                    }
                    this.removelistviewgroup();
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
                        Image img = Image.FromFile(current.Tag.ToString());
                        source.imagen = img; //asignar imagen al colector principal
                        img.Dispose();

                        //asignar fecha al colector principal
                        thumbnail.data_members.pa_obtener_fechaResult fecha_server = Bd_Exp_Transportes.pa_obtener_fecha().SingleOrDefault();
                        source.fecha = fecha_server.Fecha;
                        fecha_server = null;
                        //asignar hora al colector principal
                        thumbnail.data_members.pa_obtener_horaResult hora_server = Bd_Exp_Transportes.pa_obtener_hora().SingleOrDefault();
                        source.hora = hora_server.Hora;
                        hora_server = null;

                        source.idtramite = lookUpEdit_Tramites_selected.id_tramite; //asignar id tramite al colector principal;

                        try
                        {
                            lstvwdocumentosescaneados.Items.Remove(lstvwdocumentosescaneados.SelectedItems[0]);
                        }
                        catch (Exception) { }
                        
                        lstvwdocumentosenlazados.Items.Add((ListViewItem)current.Clone());

                        int idxgroup = 0;
                        foreach (ListViewGroup grupo in lstvwdocumentosenlazados.Groups)
                        {
                            if (grupo.Name == source.clasificaciondocumento) {
                                break;
                            }
                            idxgroup++;
                        }

                        lstvwdocumentosenlazados.Items[lstvwdocumentosenlazados.Items.Count - 1].Group = lstvwdocumentosenlazados.Groups[idxgroup];

                        sources.Add(source);
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

        public List<thumbnail.models.digital> sources = new List<thumbnail.models.digital>();
        public thumbnail.models.digital source = new thumbnail.models.digital(); //instancia a modelo principal para el guardado de la información
        private bool hocking()
        {
            int tramite = lookUpEdit_Tramites_selected.id_tramite; //obtener el id del tramite a partir del combo de tramites
            int origen = tbctrl.SelectedIndex + 1; //obtener el origen a partir del tab seleccionado

            frmhook frm = new frmhook(tramite,origen,sources); //inicializar formulario

            DialogResult result = frm.ShowDialog(this); //mostrar forlulario

            //int idx = lstvwdocumentosescaneados.SelectedItems[0].ImageIndex;
            if (result == DialogResult.OK)
            {
                source.id_documento = frm.source.id_documento; //se asigna el id del documento retornado de la forma al colector principal
                source.valor_trazable = frm.source.valor_trazable; //se asigna el valor trazable retornado de la forma al colector principal
                source.clasificaciondocumento = frm.source.clasificaciondocumento; //se asigna la clasificacion de documento retornado de la forma al colector principal
                source.documento = frm.source.documento; //se asigna el nombre de documento retornado de la forma al colector principal

                addlistviewgroup(); //agregar grupo

                frm.Dispose();
                return true;
            }
            else if (result == DialogResult.Cancel)
            {
                frm.Dispose();
                return false;
            }
            return false;
        }

        //funcion que agrega grupos al control de lista [lstvwdocumentosenlazados]
        private void addlistviewgroup()
        {
            ListViewGroup grupo = new ListViewGroup();
            grupo.Name = source.clasificaciondocumento; //obtener el nombre del grupo a partir de su clasificacion de documento
            grupo.Header = source.clasificaciondocumento + " [ " + source.documento + " ]"; //concatenar la clasificacion de documentos con el nombre del documento
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

        private void removelistviewgroup()
        {
            foreach (ListViewGroup grupo in lstvwdocumentosenlazados.Groups)
            {
                if (grupo.Items.Count == 0) {
                    lstvwdocumentosenlazados.Groups.Remove(grupo);
                }
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
            tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar.Visible = (numItemsSelects >= 1 ? true : false);
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
            tsmnuitemlstvwenlaceeliminar.Visible = (numItemsSelects >= 1 ? true : false);
            tsmnuitemlstvwenlacedesenlazar.Visible = (numItemsSelects == 1 ? true : false);
            tsmnuitemlstvwenlacedesenlazartodo.Visible = true;
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

                string path_filename = item.Tag.ToString();
                
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
            foreach (ListViewItem item in lstvwdocumentosescaneados.SelectedItems)
            {
                lstvwdocumentosenlazados.Items.Add((ListViewItem)item.Clone());
                item.Remove();

                cntmnuListViewScann.Hide();
            }
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
            {
                lstvwdocumentosenlazados.Items.Add((ListViewItem)item.Clone());
                item.Remove();
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
            frmimgViewer testDialog = new frmimgViewer(lstvwdocumentosescaneados.SelectedItems[0].Tag.ToString());

            DialogResult result = testDialog.ShowDialog(this);

            int idx = lstvwdocumentosescaneados.SelectedItems[0].ImageIndex;
            if (result == DialogResult.Yes)
            {
                Image img = Image.FromFile(lstvwdocumentosescaneados.SelectedItems[0].Tag.ToString());
                thumbnainlist.Images[idx] = classes.thumbnail.getThumbnaiImage(thumbnainlist.ImageSize.Width, img);
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
                lstvwdocumentosescaneados.Items.Add((ListViewItem)item.Clone());
                item.Remove();
                cntmnuListViewEnlace.Hide();
            }
        }

//boton abrir
        private void tsmnuitemlstvwenlaceabrir_Click(object sender, EventArgs e)
        {
            frmimgViewer testDialog = new frmimgViewer(lstvwdocumentosenlazados.SelectedItems[0].Tag.ToString());

            DialogResult result = testDialog.ShowDialog(this);

            int idx = lstvwdocumentosenlazados.SelectedItems[0].ImageIndex;
            if (result == DialogResult.Yes)
            {
                Image img = Image.FromFile(lstvwdocumentosenlazados.SelectedItems[0].Tag.ToString());
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
                string pathfiletodelete = item.Tag.ToString();
                int idx = item.ImageIndex;
                thumbnainlist.Images.RemoveAt(idx);
                item.Remove();
                //File.Delete(pathfiletodelete);
            }
            obj.Refresh();
        }

        //metodo para generar thumbnail de imagen
        private void generatethumbnailimage(string file)
        {
            Image img = Image.FromFile(file);
            thumbnainlist.Images.Add(classes.thumbnail.getThumbnaiImage(thumbnainlist.ImageSize.Width, img));

            this.lstvwdocumentosescaneados.Items.Add("", (int)thumbnainlist.Images.Count - 1);
            this.lstvwdocumentosescaneados.Items[lstvwdocumentosescaneados.Items.Count - 1].Tag = file.ToString();
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

    }
}
