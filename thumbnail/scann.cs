﻿using System;
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
        Bd_Exp_TransportesDataContext bd = new Bd_Exp_TransportesDataContext();

        expediente_model expediente = new expediente_model();

        public enum __formmode
        {
            Add,
            Edit,
            Delete
        }

        private __formmode _formmode;
        public __formmode formmode { get { return _formmode; } set { _formmode = value; } }

        private int idcampotrazableselected { get; set; }

        private ImageList thumbnainlist = new ImageList();
        
        private ImageList thumbnainlistusuario = new ImageList();
        private ImageList thumbnainlistinterno = new ImageList();
        private ImageList thumbnainlistexterno = new ImageList();
        private ImageList thumbnainlistproveedor = new ImageList();

        private ListView lstvwdocumentosescaneados;
        private ListView lstvwdocumentosenlazados;

        private ListView dragging { get; set; }

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
        
        public scann()
        {
            InitializeComponent();

//populate combo de tramites
            lookUpEditTramites.Properties.DataSource = bd.vw_Tramites_Activos;
            lookUpEditTramites.ItemIndex = 0; //seleccionar el primero por defecto            
//populate combo de campos trazables
            populatelookUpEditCamposTrazables();
//binding datagridview
            bindingSource3.DataSource = expediente.expedientetrazable;

            dataGridViewcampostrazables.AutoGenerateColumns = false;
            dataGridViewcampostrazables.DataSource = bindingSource3;
            dataGridViewcampostrazables.AllowUserToAddRows = false;
            dataGridViewcampostrazables.AllowUserToDeleteRows = false;
            dataGridViewcampostrazables.AllowUserToOrderColumns = false;
            dataGridViewcampostrazables.AllowUserToResizeColumns = true;
            dataGridViewcampostrazables.ShowCellErrors = false;
            dataGridViewcampostrazables.ShowEditingIcon = false;
            dataGridViewcampostrazables.ShowRowErrors = false;

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

            tbllytpnlinfopbimage.Image = imglsttabs.Images[((TabControl)sender).TabPages[((TabControl)sender).SelectedIndex].ImageIndex];
            tbllytpnlinfolbl.Text = ((TabControl)sender).TabPages[((TabControl)sender).SelectedIndex].Tag.ToString();
        }

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
                    foreach (ListViewItem current in (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)))
                    {
                        try
                        {
                            lstvwdocumentosescaneados.Items.Remove(lstvwdocumentosescaneados.SelectedItems[0]);
                        }
                        catch (Exception) { }
                        
                        lstvwdocumentosenlazados.Items.Add((ListViewItem)current.Clone());
                       // lstvwdocumentosenlazados.Items[lstvwdocumentosenlazados.Items.Count-1].Group = lstvwdocumentosenlazados.Groups[0];                                             
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
#endregion lstvwdocumentosenlazados drag and drop


/*
 * habilita o deshabilita opciones del menu de las imagenes de documentos escaneados 
 */
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

/*
 * habilita o deshabilita opciones del menu de las imagenes de documentos enlazados
 */
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

        private void deletethumbnailandimage(ListView obj) {
            foreach (ListViewItem item in obj.SelectedItems)
            {
                string pathfiletodelete = item.Tag.ToString();
                int idx = item.ImageIndex;
                thumbnainlist.Images.RemoveAt(idx);
                item.Remove();
                File.Delete(pathfiletodelete);
            }
            obj.Refresh();
        }

/*
 * metodo para generar thumbnail de imagen
 */
        private void generatethumbnailimage(string file)
        {
            Image img = Image.FromFile(file);
            thumbnainlist.Images.Add(classes.thumbnail.getThumbnaiImage(thumbnainlist.ImageSize.Width, img));

            this.lstvwdocumentosescaneados.Items.Add("", (int)thumbnainlist.Images.Count - 1);
            this.lstvwdocumentosescaneados.Items[lstvwdocumentosescaneados.Items.Count - 1].Tag = file.ToString();
        }

#region botonera listviews documentos escaneados y documentos enlazados
//boton de abrir archivos
        private void pbopenfile_Click(object sender, EventArgs e)
        {
            if (ofdabrirarchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                foreach (string file in ofdabrirarchivo.FileNames )
                {
                    generatethumbnailimage(file);    
                }
            }
        }

//boton de escanear documentos        
        private void pbmnuscann_Click(object sender, EventArgs e)
        {
            Int32 lvRet;
            Boolean lvUserCancel = false;
            lvRet = KDImage.ScannerAcquireMultiPages(ref lvUserCancel, -1);
            if (lvRet != 0) {
                MessageBox.Show("Error: " + KDImage.GetErrorMsg(lvRet));
            }
        }

//boton de limpiar listviews
        private void pbmnulimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma limpiar las listas", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                thumbnainlist.Images.Clear();
                lstvwdocumentosescaneados.Clear();
                lstvwdocumentosenlazados.Clear();
                //File.Delete(pathfiletodelete);
            }
        }
#endregion botonera listviews documentos escaneados y documentos enlazados        

        private void pbbtnscannerselector_Click(object sender, EventArgs e)
        {
            Int32 lvRet;
            Boolean lvUserCancel = false;
            lvRet = KDImage.ScannerSelect(ref lvUserCancel);
            if (lvRet != 0) {
                throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
            }
        }

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


        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            vw_Tramites_Activos row = ((LookUpEdit)sender).Properties.GetDataSourceRowByKeyValue(((LookUpEdit)sender).EditValue) as vw_Tramites_Activos;

            campostrazables qwe = new campostrazables();
            


        }

        private void populatelookUpEditCamposTrazables(){
            List<vw_Campos_Trazables> data = new List <vw_Campos_Trazables>();
            data = bd.vw_Campos_Trazables.ToList();

            foreach (models.de_expedientestrazables item in expediente.expedientetrazable)
            {
                data.RemoveAll(x => x.id == item.id_campotrazable);
            }

            lookUpEditCamposTrazables.Properties.DataSource = data;
        }

        private void clearfrmcampostrazables(){
            formmode = __formmode.Add;

            lookUpEditCamposTrazables.Visible = true;
            lookUpEditCamposTrazables.Properties.ForceInitialize();
            lookUpEditCamposTrazables.EditValue = null;
            lookUpEditCamposTrazables.Properties.DataSource = null;
            textEditcampotrazable.Visible = false;
            lblmascampotrazable.Text = "";
            txtvalortrazable.Text = "";
            txtvalortrazable.Enabled = false;
            txtvalortrazable.Properties.Mask.EditMask = "";
            checkEditcampoprincipal.Checked = false;

            dxValidationProvider1.RemoveControlError(lookUpEditCamposTrazables);
            dxValidationProvider1.RemoveControlError(txtvalortrazable);
            dxValidationProvider2.RemoveControlError(txtvalortrazable);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!validatealldatascampostrazables()) return;

            if (formmode == __formmode.Add)
            {
                thumbnail.models.de_expedientestrazables detalle = new thumbnail.models.de_expedientestrazables();
                detalle.es_principal = checkEditcampoprincipal.Checked;
                detalle.fecha_creacion = DateTime.Now;
                vw_Campos_Trazables row = lookUpEditCamposTrazables.Properties.GetDataSourceRowByKeyValue(lookUpEditCamposTrazables.EditValue) as vw_Campos_Trazables;
                detalle.id_campotrazable = row.id;
                detalle.campotrazable = row.Nombre;
                detalle.mask = txtvalortrazable.Properties.Mask.EditMask;
                detalle.numcaracteres = txtvalortrazable.Properties.MaxLength;
                detalle.valor_trazable = txtvalortrazable.Text;

                if (detalle.es_principal)
                {
                    validatecampoprincipal();
                }

                bindingSource3.Add(detalle);

                clearfrmcampostrazables();
            }
            else if (formmode == __formmode.Edit) {

                foreach (thumbnail.models.de_expedientestrazables item in expediente.expedientetrazable)
	            {
                    if (item.id_campotrazable == idcampotrazableselected) {
                        if (checkEditcampoprincipal.Checked) validatecampoprincipal();
                        item.valor_trazable = txtvalortrazable.Text;
                        item.es_principal = checkEditcampoprincipal.Checked;
                        break;
                    }
	            }

                bindingSource3.DataSource = expediente.expedientetrazable;
                dataGridViewcampostrazables.DataSource = bindingSource3;
                dataGridViewcampostrazables.Refresh();
            }
        }

        private Boolean validatealldatascampostrazables()
        {
            if (formmode == __formmode.Add)
            {
                dxValidationProvider1.Validate();
                if (dxValidationProvider1.GetInvalidControls().Count() != 0) return false;
            }
            else 
            {
                dxValidationProvider2.Validate();
                if (dxValidationProvider2.GetInvalidControls().Count() != 0) return false;
            }

            return true;
        }

        private void validatecampoprincipal()
        {
            foreach (models.de_expedientestrazables item in expediente.expedientetrazable)
            {
                item.es_principal = false;
            }
        }

        private void lookUpEditCamposTrazables_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                vw_Campos_Trazables row = ((LookUpEdit)sender).Properties.GetDataSourceRowByKeyValue(((LookUpEdit)sender).EditValue) as vw_Campos_Trazables;
                actualizainfomascara(row.Mascara.ToString(), (int)row.Tamanio_Caracteres);
            }
            catch (Exception)
            {
            }
            
        }

        private void actualizainfomascara(string mascara, int numcaracteres)
        {
            lblmascampotrazable.Text = mascara;
            txtvalortrazable.Text = "";
            txtvalortrazable.Enabled = true;
            txtvalortrazable.Properties.Mask.EditMask = mascara;
            txtvalortrazable.Properties.MaxLength = numcaracteres;
        }

        private void lookUpEditCamposTrazables_QueryPopUp(object sender, CancelEventArgs e)
        {
            //populate combo de campos trazables
            populatelookUpEditCamposTrazables();
        }

        private void dataGridViewcampostrazables_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //string cellValue = dataGridViewcampostrazables["columnName", rowindex].Value.ToString();

            
        }

        private void dataGridViewcampostrazables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        /*    int data = (int)dataGridViewcampostrazables.Rows[e.RowIndex].Cells["campotext"].Value;
            lookUpEditCamposTrazables.EditValue = lookUpEditCamposTrazables.Properties.GetKeyValueByDisplayValue(data);*/
            try
            {
                formmode = __formmode.Edit;

                idcampotrazableselected = (int)dataGridViewcampostrazables.Rows[e.RowIndex].Cells["colcampo"].Value;


                lookUpEditCamposTrazables.Visible = false;
                textEditcampotrazable.Visible = true;
                textEditcampotrazable.Text = dataGridViewcampostrazables.Rows[e.RowIndex].Cells["campotext"].Value.ToString();

                actualizainfomascara(dataGridViewcampostrazables.Rows[e.RowIndex].Cells["colmask"].Value.ToString(), (int)dataGridViewcampostrazables.Rows[e.RowIndex].Cells["collong"].Value);
                txtvalortrazable.Text = dataGridViewcampostrazables.Rows[e.RowIndex].Cells["colValor"].Value.ToString();
                txtvalortrazable.Focus();

                checkEditcampoprincipal.Checked = (Boolean)dataGridViewcampostrazables.Rows[e.RowIndex].Cells["colCampoPrincipal"].Value;
            }
            catch (Exception)
            {
            }
        }

        private void scann_Load(object sender, EventArgs e)
        {
            lookUpEditTramites.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            clearfrmcampostrazables();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma borrar el campo trazable seleccionado", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSource3.RemoveAt(dataGridViewcampostrazables.SelectedRows[0].Index);
                clearfrmcampostrazables();
            }
        }

        private void txtvalortrazable_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtvalortrazable_Click(object sender, EventArgs e)
        {
            txtvalortrazable.SelectAll();
        }

    }
}
