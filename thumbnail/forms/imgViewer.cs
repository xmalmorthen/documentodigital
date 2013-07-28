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

namespace thumbnail.forms
{
    public partial class frmimgViewer : Form
    {
        private string pathimageoriginal { get; set; }

        public frmimgViewer(string path)
        {
            InitializeComponent();
            pathimageoriginal = path;
            this.initialize();
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
        //boton zoom menos
        private void pbzoomout_Click(object sender, EventArgs e)
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

        //boton zoom mas
        private void pbzoomin_Click(object sender, EventArgs e)
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

        private void zoomSlider_ValueChanged(object sender, EventArgs e)
        {
            KDImage.ZoomToPoint((sender as ZoomTrackBarControl).Value, -1, -1);
        }


//boton tamaño real
        private void pboriginsize_Click(object sender, EventArgs e)
        {
            KDImage.Zoom = 100;
            zoomSlider.Value = 100;
        }

//boton ajustar a pantalla
        private void pbfit_Click(object sender, EventArgs e)
        {
            KDImage.ZoomToFit(KDImageEditor.TxFitMode.fmFitToPage);
            zoomSlider.Value = (int) KDImage.Zoom;
        }

#endregion botonera lateral izquierda

#region botonera superior
        //boton rotar a la izquierda
        private void pbrotarizquierda_Click(object sender, EventArgs e)
        {
            int lvRet = KDImage.Rotate(-90);
            if (lvRet != 0)
            {
                throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
            }
        }

//boton rotar a la derecha
        private void pbrotarderecha_Click(object sender, EventArgs e)
        {
            int lvRet = KDImage.Rotate(90);
            if (lvRet != 0)
            {
                throw new Exception("Error :" + KDImage.GetErrorMsg(lvRet));
            }
        }

//boton reset
        private void pbreset_Click(object sender, EventArgs e)
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
        private void pbeliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma el borrado", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes) {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

//boton cerrar
        private void pbcerrar_Click(object sender, EventArgs e)
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
#endregion botonera superior

    }
}
