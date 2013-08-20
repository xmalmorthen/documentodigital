namespace thumbnail.forms
{
    partial class frmimgViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmimgViewer));
            this.ttimageviewer = new System.Windows.Forms.ToolTip(this.components);
            this.btn_reestablecer = new System.Windows.Forms.Button();
            this.btn_rotarizquierda = new System.Windows.Forms.Button();
            this.btn_rotarderecha = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KDImage = new AxKDImageEditor.AxKDImage();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.zoomSlider = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.btn_ajuste = new System.Windows.Forms.Button();
            this.btn_tamaniooriginal = new System.Windows.Forms.Button();
            this.btn_zommmenos = new System.Windows.Forms.Button();
            this.btn_zoommas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KDImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reestablecer
            // 
            this.btn_reestablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reestablecer.AutoSize = true;
            this.btn_reestablecer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reestablecer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_reestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reestablecer.FlatAppearance.BorderSize = 0;
            this.btn_reestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_reestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reestablecer.Image = global::thumbnail.Icons48x48.reset;
            this.btn_reestablecer.Location = new System.Drawing.Point(421, 7);
            this.btn_reestablecer.Name = "btn_reestablecer";
            this.btn_reestablecer.Size = new System.Drawing.Size(54, 54);
            this.btn_reestablecer.TabIndex = 8;
            this.ttimageviewer.SetToolTip(this.btn_reestablecer, "Reestablecer imagen");
            this.btn_reestablecer.UseVisualStyleBackColor = false;
            this.btn_reestablecer.Click += new System.EventHandler(this.btn_reestablecer_Click);
            // 
            // btn_rotarizquierda
            // 
            this.btn_rotarizquierda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rotarizquierda.AutoSize = true;
            this.btn_rotarizquierda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_rotarizquierda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_rotarizquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rotarizquierda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rotarizquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotarizquierda.Image = global::thumbnail.Icons48x48.rotateizq;
            this.btn_rotarizquierda.Location = new System.Drawing.Point(289, 7);
            this.btn_rotarizquierda.Name = "btn_rotarizquierda";
            this.btn_rotarizquierda.Size = new System.Drawing.Size(56, 56);
            this.btn_rotarizquierda.TabIndex = 7;
            this.ttimageviewer.SetToolTip(this.btn_rotarizquierda, "Rotar a la izquierda");
            this.btn_rotarizquierda.UseVisualStyleBackColor = false;
            this.btn_rotarizquierda.Click += new System.EventHandler(this.btn_rotarizquierda_Click);
            // 
            // btn_rotarderecha
            // 
            this.btn_rotarderecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rotarderecha.AutoSize = true;
            this.btn_rotarderecha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_rotarderecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_rotarderecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rotarderecha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rotarderecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotarderecha.Image = global::thumbnail.Icons48x48.rotateder;
            this.btn_rotarderecha.Location = new System.Drawing.Point(229, 7);
            this.btn_rotarderecha.Name = "btn_rotarderecha";
            this.btn_rotarderecha.Size = new System.Drawing.Size(56, 56);
            this.btn_rotarderecha.TabIndex = 6;
            this.ttimageviewer.SetToolTip(this.btn_rotarderecha, "Rotar a la derecha");
            this.btn_rotarderecha.UseVisualStyleBackColor = false;
            this.btn_rotarderecha.Click += new System.EventHandler(this.btn_rotarderecha_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_borrar.AutoSize = true;
            this.btn_borrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_borrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Image = global::thumbnail.Icons48x48.delete;
            this.btn_borrar.Location = new System.Drawing.Point(572, 7);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(54, 54);
            this.btn_borrar.TabIndex = 9;
            this.ttimageviewer.SetToolTip(this.btn_borrar, "Eliminar imagen");
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.AutoSize = true;
            this.btn_cerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Image = global::thumbnail.Icons48x48.close;
            this.btn_cerrar.Location = new System.Drawing.Point(718, 7);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(54, 54);
            this.btn_cerrar.TabIndex = 10;
            this.ttimageviewer.SetToolTip(this.btn_cerrar, "Cerrar visualizador");
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KDImage);
            this.panel1.Location = new System.Drawing.Point(10, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 476);
            this.panel1.TabIndex = 32;
            // 
            // KDImage
            // 
            this.KDImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KDImage.Enabled = true;
            this.KDImage.Location = new System.Drawing.Point(0, 0);
            this.KDImage.Name = "KDImage";
            this.KDImage.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("KDImage.OcxState")));
            this.KDImage.Size = new System.Drawing.Size(763, 474);
            this.KDImage.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(784, 566);
            this.shapeContainer1.TabIndex = 51;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 290;
            this.lineShape1.X2 = 786;
            this.lineShape1.Y1 = 69;
            this.lineShape1.Y2 = 69;
            // 
            // zoomSlider
            // 
            this.zoomSlider.EditValue = null;
            this.zoomSlider.Location = new System.Drawing.Point(10, 55);
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Properties.LargeChange = 20;
            this.zoomSlider.Properties.Maximum = 100;
            this.zoomSlider.Properties.Middle = 5;
            this.zoomSlider.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.zoomSlider.Properties.ShowValueToolTip = true;
            this.zoomSlider.Properties.SmallChange = 10;
            this.zoomSlider.Size = new System.Drawing.Size(170, 23);
            this.zoomSlider.TabIndex = 1;
            this.zoomSlider.EditValueChanged += new System.EventHandler(this.zoomSlider_ValueChanged);
            // 
            // btn_ajuste
            // 
            this.btn_ajuste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajuste.AutoSize = true;
            this.btn_ajuste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ajuste.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ajuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajuste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ajuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajuste.Image = global::thumbnail.Icons32x32.fit;
            this.btn_ajuste.Location = new System.Drawing.Point(140, 7);
            this.btn_ajuste.Name = "btn_ajuste";
            this.btn_ajuste.Size = new System.Drawing.Size(40, 40);
            this.btn_ajuste.TabIndex = 5;
            this.btn_ajuste.UseVisualStyleBackColor = false;
            this.btn_ajuste.Click += new System.EventHandler(this.btn_ajuste_Click);
            // 
            // btn_tamaniooriginal
            // 
            this.btn_tamaniooriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tamaniooriginal.AutoSize = true;
            this.btn_tamaniooriginal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_tamaniooriginal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tamaniooriginal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tamaniooriginal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tamaniooriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tamaniooriginal.Image = global::thumbnail.Icons32x32.zoomorigin;
            this.btn_tamaniooriginal.Location = new System.Drawing.Point(96, 7);
            this.btn_tamaniooriginal.Name = "btn_tamaniooriginal";
            this.btn_tamaniooriginal.Size = new System.Drawing.Size(40, 40);
            this.btn_tamaniooriginal.TabIndex = 4;
            this.btn_tamaniooriginal.UseVisualStyleBackColor = false;
            this.btn_tamaniooriginal.Click += new System.EventHandler(this.btn_tamaniooriginal_Click);
            // 
            // btn_zommmenos
            // 
            this.btn_zommmenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zommmenos.AutoSize = true;
            this.btn_zommmenos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_zommmenos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_zommmenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_zommmenos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_zommmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zommmenos.Image = global::thumbnail.Icons32x32.zoomout;
            this.btn_zommmenos.Location = new System.Drawing.Point(8, 7);
            this.btn_zommmenos.Name = "btn_zommmenos";
            this.btn_zommmenos.Size = new System.Drawing.Size(40, 40);
            this.btn_zommmenos.TabIndex = 2;
            this.btn_zommmenos.UseVisualStyleBackColor = false;
            this.btn_zommmenos.Click += new System.EventHandler(this.btn_zommmenos_Click);
            // 
            // btn_zoommas
            // 
            this.btn_zoommas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zoommas.AutoSize = true;
            this.btn_zoommas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_zoommas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_zoommas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_zoommas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_zoommas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zoommas.Image = global::thumbnail.Icons32x32.zoomin;
            this.btn_zoommas.Location = new System.Drawing.Point(52, 7);
            this.btn_zoommas.Name = "btn_zoommas";
            this.btn_zoommas.Size = new System.Drawing.Size(40, 40);
            this.btn_zoommas.TabIndex = 3;
            this.btn_zoommas.UseVisualStyleBackColor = false;
            this.btn_zoommas.Click += new System.EventHandler(this.btn_zoommas_Click);
            // 
            // frmimgViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.btn_ajuste);
            this.Controls.Add(this.btn_tamaniooriginal);
            this.Controls.Add(this.btn_zommmenos);
            this.Controls.Add(this.zoomSlider);
            this.Controls.Add(this.btn_reestablecer);
            this.Controls.Add(this.btn_rotarizquierda);
            this.Controls.Add(this.btn_rotarderecha);
            this.Controls.Add(this.btn_zoommas);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmimgViewer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizador de Imagen";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KDImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttimageviewer;
        private System.Windows.Forms.Panel panel1;
        private AxKDImageEditor.AxKDImage KDImage;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_zoommas;
        private System.Windows.Forms.Button btn_rotarderecha;
        private System.Windows.Forms.Button btn_rotarizquierda;
        private System.Windows.Forms.Button btn_reestablecer;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomSlider;
        private System.Windows.Forms.Button btn_zommmenos;
        private System.Windows.Forms.Button btn_tamaniooriginal;
        private System.Windows.Forms.Button btn_ajuste;

    }
}