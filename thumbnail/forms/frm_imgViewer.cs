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
using thumbnail.Properties;
using thumbnail.classes;

namespace thumbnail.forms
{
    public partial class frmimgViewer : Form
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

        public frmimgViewer(string path)
        {
            InitializeComponent();
            pathimageoriginal = path;
            this.initialize();
        }

        public frmimgViewer(int id_ma_digital_edit, int id, int id_re_clasificaciondocumento_documento)
        {
            InitializeComponent();

            btn_borrar.Visible = false;

            string pathfilename = scannfilename + ".jpg";

            try
            {
                data_members.de_digital imagendigitalregistrada = Program.Bd_Exp_Transportes.de_digital.SingleOrDefault(
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
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al intentar obtener la imagen digitál, favor de intentarlo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

#region botonera superior
//boton rotar a la izquierda
        private void btn_rotarizquierda_Click(object sender, EventArgs e)
        {
            int lvRet = KDImage.Rotate(-90);
            if (lvRet != 0)
            {
                throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
            }
        }

//boton rotar a la derecha
        private void btn_rotarderecha_Click(object sender, EventArgs e)
        {
            int lvRet = KDImage.Rotate(90);
            if (lvRet != 0)
            {
                throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
            }
        }

//boton reset
        private void btn_reestablecer_Click(object sender, EventArgs e)
        {
            initialize();
        }
        
//boton guardar
        private void pbsave_Click(object sender, EventArgs e)
        {
            int lvRet = KDImage.FileSave(pathimageoriginal, KDImageEditor.TxPictureType.ptAutoDetect);
            if (lvRet != 0)
            {
                throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
            }
        }

//boton borrar
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma el borrado", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

//boton cerrar
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
#endregion botonera superior

        private void frmimgViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (KDImage.IsPictureChanged)
            {
                switch (MessageBox.Show("Desea guardar los cambios", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.No:
                        this.DialogResult = System.Windows.Forms.DialogResult.No;
                        break;
                    case DialogResult.Yes:
                        int lvRet = KDImage.FileSave(pathimageoriginal, KDImageEditor.TxPictureType.ptAutoDetect);
                        if (lvRet != 0)
                        {
                            throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
                        }
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                        break;
                }
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
