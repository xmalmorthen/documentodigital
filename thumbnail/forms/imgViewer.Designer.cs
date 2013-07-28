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
            this.tbllytpnlmnutbusuario = new System.Windows.Forms.TableLayoutPanel();
            this.pbrotarizquierda = new System.Windows.Forms.PictureBox();
            this.pbrotarderecha = new System.Windows.Forms.PictureBox();
            this.pbreset = new System.Windows.Forms.PictureBox();
            this.pbeliminar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pboriginsize = new System.Windows.Forms.PictureBox();
            this.pbzoomout = new System.Windows.Forms.PictureBox();
            this.pbfit = new System.Windows.Forms.PictureBox();
            this.pbzoomin = new System.Windows.Forms.PictureBox();
            this.ttimageviewer = new System.Windows.Forms.ToolTip(this.components);
            this.pbcerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KDImage = new AxKDImageEditor.AxKDImage();
            this.zoomSlider = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.tbllytpnlmnutbusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbrotarizquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrotarderecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbeliminar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboriginsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbzoomout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbzoomin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KDImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbllytpnlmnutbusuario
            // 
            this.tbllytpnlmnutbusuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllytpnlmnutbusuario.BackColor = System.Drawing.Color.Gainsboro;
            this.tbllytpnlmnutbusuario.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbllytpnlmnutbusuario.ColumnCount = 4;
            this.tbllytpnlmnutbusuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbllytpnlmnutbusuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbllytpnlmnutbusuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbllytpnlmnutbusuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbllytpnlmnutbusuario.Controls.Add(this.pbrotarizquierda, 0, 0);
            this.tbllytpnlmnutbusuario.Controls.Add(this.pbrotarderecha, 0, 0);
            this.tbllytpnlmnutbusuario.Controls.Add(this.pbreset, 2, 0);
            this.tbllytpnlmnutbusuario.Controls.Add(this.pbeliminar, 3, 0);
            this.tbllytpnlmnutbusuario.Location = new System.Drawing.Point(9, 9);
            this.tbllytpnlmnutbusuario.Margin = new System.Windows.Forms.Padding(0);
            this.tbllytpnlmnutbusuario.Name = "tbllytpnlmnutbusuario";
            this.tbllytpnlmnutbusuario.RowCount = 1;
            this.tbllytpnlmnutbusuario.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbllytpnlmnutbusuario.Size = new System.Drawing.Size(497, 79);
            this.tbllytpnlmnutbusuario.TabIndex = 11;
            // 
            // pbrotarizquierda
            // 
            this.pbrotarizquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbrotarizquierda.Image = global::thumbnail.Properties.Resources.rotateizq;
            this.pbrotarizquierda.Location = new System.Drawing.Point(71, 6);
            this.pbrotarizquierda.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.pbrotarizquierda.Name = "pbrotarizquierda";
            this.pbrotarizquierda.Size = new System.Drawing.Size(64, 64);
            this.pbrotarizquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbrotarizquierda.TabIndex = 9;
            this.pbrotarizquierda.TabStop = false;
            this.ttimageviewer.SetToolTip(this.pbrotarizquierda, "Rotar a la izquierda");
            this.pbrotarizquierda.Click += new System.EventHandler(this.pbrotarizquierda_Click);
            // 
            // pbrotarderecha
            // 
            this.pbrotarderecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbrotarderecha.Image = global::thumbnail.Properties.Resources.rotateder;
            this.pbrotarderecha.Location = new System.Drawing.Point(6, 6);
            this.pbrotarderecha.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.pbrotarderecha.Name = "pbrotarderecha";
            this.pbrotarderecha.Size = new System.Drawing.Size(64, 64);
            this.pbrotarderecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbrotarderecha.TabIndex = 10;
            this.pbrotarderecha.TabStop = false;
            this.ttimageviewer.SetToolTip(this.pbrotarderecha, "Rotar a la derecha");
            this.pbrotarderecha.Click += new System.EventHandler(this.pbrotarderecha_Click);
            // 
            // pbreset
            // 
            this.pbreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbreset.Image = global::thumbnail.Properties.Resources.reset;
            this.pbreset.Location = new System.Drawing.Point(176, 6);
            this.pbreset.Margin = new System.Windows.Forms.Padding(35, 5, 35, 5);
            this.pbreset.Name = "pbreset";
            this.pbreset.Size = new System.Drawing.Size(64, 64);
            this.pbreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbreset.TabIndex = 13;
            this.pbreset.TabStop = false;
            this.ttimageviewer.SetToolTip(this.pbreset, "Restaurar imagen");
            this.pbreset.Click += new System.EventHandler(this.pbreset_Click);
            // 
            // pbeliminar
            // 
            this.pbeliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbeliminar.Image = global::thumbnail.Properties.Resources.delete;
            this.pbeliminar.Location = new System.Drawing.Point(426, 6);
            this.pbeliminar.Margin = new System.Windows.Forms.Padding(150, 5, 35, 5);
            this.pbeliminar.Name = "pbeliminar";
            this.pbeliminar.Size = new System.Drawing.Size(64, 64);
            this.pbeliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbeliminar.TabIndex = 12;
            this.pbeliminar.TabStop = false;
            this.ttimageviewer.SetToolTip(this.pbeliminar, "Eliminar imagen");
            this.pbeliminar.Click += new System.EventHandler(this.pbeliminar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.zoomSlider, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pboriginsize, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbzoomout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbfit, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pbzoomin, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 91);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(85, 341);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // pboriginsize
            // 
            this.pboriginsize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboriginsize.Image = global::thumbnail.Properties.Resources.zoomorigin;
            this.pboriginsize.Location = new System.Drawing.Point(11, 186);
            this.pboriginsize.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pboriginsize.Name = "pboriginsize";
            this.pboriginsize.Size = new System.Drawing.Size(64, 64);
            this.pboriginsize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboriginsize.TabIndex = 12;
            this.pboriginsize.TabStop = false;
            this.ttimageviewer.SetToolTip(this.pboriginsize, "Mostar en tamaño real");
            this.pboriginsize.Click += new System.EventHandler(this.pboriginsize_Click);
            // 
            // pbzoomout
            // 
            this.pbzoomout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbzoomout.Image = global::thumbnail.Properties.Resources.zoomout;
            this.pbzoomout.Location = new System.Drawing.Point(11, 36);
            this.pbzoomout.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pbzoomout.Name = "pbzoomout";
            this.pbzoomout.Size = new System.Drawing.Size(64, 64);
            this.pbzoomout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbzoomout.TabIndex = 9;
            this.pbzoomout.TabStop = false;
            this.ttimageviewer.SetToolTip(this.pbzoomout, "Disminuir amplliación");
            this.pbzoomout.Click += new System.EventHandler(this.pbzoomout_Click);
            // 
            // pbfit
            // 
            this.pbfit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbfit.Image = global::thumbnail.Properties.Resources.fit;
            this.pbfit.Location = new System.Drawing.Point(11, 261);
            this.pbfit.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pbfit.Name = "pbfit";
            this.pbfit.Size = new System.Drawing.Size(64, 64);
            this.pbfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfit.TabIndex = 11;
            this.pbfit.TabStop = false;
            this.ttimageviewer.SetToolTip(this.pbfit, "Auto ajustar a la ventana");
            this.pbfit.Click += new System.EventHandler(this.pbfit_Click);
            // 
            // pbzoomin
            // 
            this.pbzoomin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbzoomin.Image = global::thumbnail.Properties.Resources.zoomin;
            this.pbzoomin.Location = new System.Drawing.Point(11, 111);
            this.pbzoomin.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pbzoomin.Name = "pbzoomin";
            this.pbzoomin.Size = new System.Drawing.Size(64, 64);
            this.pbzoomin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbzoomin.TabIndex = 10;
            this.pbzoomin.TabStop = false;
            this.ttimageviewer.SetToolTip(this.pbzoomin, "Aumentar amplliación");
            this.pbzoomin.Click += new System.EventHandler(this.pbzoomin_Click);
            // 
            // pbcerrar
            // 
            this.pbcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbcerrar.Image = global::thumbnail.Properties.Resources.close;
            this.pbcerrar.Location = new System.Drawing.Point(705, 14);
            this.pbcerrar.Margin = new System.Windows.Forms.Padding(5);
            this.pbcerrar.Name = "pbcerrar";
            this.pbcerrar.Size = new System.Drawing.Size(70, 64);
            this.pbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcerrar.TabIndex = 15;
            this.pbcerrar.TabStop = false;
            this.ttimageviewer.SetToolTip(this.pbcerrar, "Cerrar visualizador");
            this.pbcerrar.Click += new System.EventHandler(this.pbcerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KDImage);
            this.panel1.Location = new System.Drawing.Point(98, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 471);
            this.panel1.TabIndex = 32;
            // 
            // KDImage
            // 
            this.KDImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KDImage.Enabled = true;
            this.KDImage.Location = new System.Drawing.Point(0, 0);
            this.KDImage.Name = "KDImage";
            this.KDImage.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("KDImage.OcxState")));
            this.KDImage.Size = new System.Drawing.Size(675, 469);
            this.KDImage.TabIndex = 32;
            this.KDImage.Tag = "0";
            // 
            // zoomSlider
            // 
            this.zoomSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomSlider.Location = new System.Drawing.Point(4, 4);
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Properties.LargeChange = 20;
            this.zoomSlider.Properties.Maximum = 100;
            this.zoomSlider.Properties.Middle = 5;
            this.zoomSlider.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.zoomSlider.Properties.ShowValueToolTip = true;
            this.zoomSlider.Properties.SmallChange = 10;
            this.zoomSlider.Size = new System.Drawing.Size(78, 23);
            this.zoomSlider.TabIndex = 33;
            this.zoomSlider.ValueChanged += new System.EventHandler(this.zoomSlider_ValueChanged);
            // 
            // frmimgViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbcerrar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tbllytpnlmnutbusuario);
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
            this.tbllytpnlmnutbusuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbrotarizquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrotarderecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbeliminar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboriginsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbzoomout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbzoomin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KDImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbllytpnlmnutbusuario;
        private System.Windows.Forms.PictureBox pbrotarderecha;
        private System.Windows.Forms.PictureBox pbrotarizquierda;
        private System.Windows.Forms.PictureBox pbreset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pboriginsize;
        private System.Windows.Forms.PictureBox pbfit;
        private System.Windows.Forms.PictureBox pbzoomin;
        private System.Windows.Forms.PictureBox pbzoomout;
        private System.Windows.Forms.PictureBox pbcerrar;
        private System.Windows.Forms.ToolTip ttimageviewer;
        private System.Windows.Forms.PictureBox pbeliminar;
        private System.Windows.Forms.Panel panel1;
        internal AxKDImageEditor.AxKDImage KDImage;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomSlider;

    }
}