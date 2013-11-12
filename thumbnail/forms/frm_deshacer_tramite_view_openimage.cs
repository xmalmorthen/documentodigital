using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scanndoc.Properties;
using scanndoc.classes;

namespace scanndoc.forms
{
    public partial class frm_deshacer_tramite_view_openimage : Form
    {
        public string pathimageoriginal { get; set; }

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

        public string scannfilename
        {
            get
            {
                return swapdirectory + @"\" + Settings.Default.ScannFileName + Guid.NewGuid().ToString();
            }
        }

        public frm_deshacer_tramite_view_openimage(string path)
        {
            InitializeComponent();
            pathimageoriginal = path;
            this.initialize();
        }

        public frm_deshacer_tramite_view_openimage(int id_ma_digital_edit, int id, int id_re_clasificaciondocumento_documento)
        {
            InitializeComponent();

            string pathfilename = scannfilename + ".jpg";

            try
            {
                data_members.de_digital imagendigitalregistrada = Program.Bd_Expedientes_Digitales.de_digital.SingleOrDefault(
                query => query.id_ma_digital == id_ma_digital_edit &&
                         query.id == id &&
                         query.id_re_clasificaciondocumento_documento == id_re_clasificaciondocumento_documento);

                if (imagendigitalregistrada != null)
                {
                    byte[] blob = imagendigitalregistrada.imagen.ToArray();
                    FileStream fs = new FileStream(pathfilename, FileMode.Create);
                    fs.Write(blob, 0, blob.Length);
                    fs.Close();
                    fs = null;                    
                }

                pathimageoriginal = pathfilename;
                this.initialize();
            }
            catch (Exception e)
            {                
                scanndoc.classes.errorlogs.seterror(e);
            }            
        }


        private void initialize() {            
            int lvRet = KDImage.FileOpen(pathimageoriginal, KDImageEditor.TxPictureType.ptAutoDetect, 1);
            if (lvRet != 0)
            {
                throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
            }

            zoomSlider.Properties.Minimum = (int)KDImage.Zoom;
            zoomSlider.Properties.Maximum = 300;
            zoomSlider.Value = zoomSlider.Properties.Minimum;
        }
                
#region botonera lateral izquierda
        //boton ajustar a pantalla
        private void btn_ajuste_Click(object sender, EventArgs e)
        {
            KDImage.ZoomToFit(KDImageEditor.TxFitMode.fmFitToPage);
            zoomSlider.Value = (int)KDImage.Zoom;
        }

        //boton zoom mas
        private void btn_zoommas_Click(object sender, EventArgs e)
        {
            try
            {
                zoomSlider.Value = zoomSlider.Value + 30;
            }
            catch (Exception)
            {
                zoomSlider.Value = zoomSlider.Properties.Maximum;
            }
        }

        //boton tamaño real
        private void btn_tamaniooriginal_Click(object sender, EventArgs e)
        {
            KDImage.Zoom = 100;
            zoomSlider.Value = 100;
        }

        //boton zoom menos
        private void btn_zommmenos_Click(object sender, EventArgs e)
        {
            try
            {
                zoomSlider.Value = zoomSlider.Value - 30;
            }
            catch (Exception)
            {
                zoomSlider.Value = zoomSlider.Properties.Minimum;
            }
        }
        
        private void zoomSlider_ValueChanged(object sender, EventArgs e)
        {
            KDImage.ZoomToPoint((sender as ZoomTrackBarControl).Value, -1, -1);
        }

#endregion botonera lateral izquierda

//boton cerrar
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void frmimgViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}
