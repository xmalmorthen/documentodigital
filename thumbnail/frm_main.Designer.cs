namespace thumbnail
{
    partial class frm_main
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
            this.mnustrip_menuprincipal = new System.Windows.Forms.MenuStrip();
            this.tlp_proc = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.creaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camposTrazablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clasificaciñonDeTramitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tramitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clasificaciónDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroYSeguimientoDeTramiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blquearDesbloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.preferenciasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustrip_menuprincipal.SuspendLayout();
            this.tlp_proc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnustrip_menuprincipal
            // 
            this.mnustrip_menuprincipal.AllowItemReorder = true;
            this.mnustrip_menuprincipal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mnustrip_menuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaciónToolStripMenuItem,
            this.papelToolStripMenuItem,
            this.administraciònToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.ventanasToolStripMenuItem});
            this.mnustrip_menuprincipal.Location = new System.Drawing.Point(0, 0);
            this.mnustrip_menuprincipal.MdiWindowListItem = this.ventanasToolStripMenuItem;
            this.mnustrip_menuprincipal.Name = "mnustrip_menuprincipal";
            this.mnustrip_menuprincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnustrip_menuprincipal.Size = new System.Drawing.Size(1008, 28);
            this.mnustrip_menuprincipal.TabIndex = 0;
            // 
            // tlp_proc
            // 
            this.tlp_proc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_proc.BackColor = System.Drawing.Color.Transparent;
            this.tlp_proc.ColumnCount = 2;
            this.tlp_proc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_proc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_proc.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_proc.Controls.Add(this.label1, 1, 0);
            this.tlp_proc.Location = new System.Drawing.Point(801, 668);
            this.tlp_proc.Name = "tlp_proc";
            this.tlp_proc.RowCount = 1;
            this.tlp_proc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_proc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_proc.Size = new System.Drawing.Size(195, 50);
            this.tlp_proc.TabIndex = 1;
            this.tlp_proc.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(48, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(145, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favor de esperar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::thumbnail.Icons48x48.clock;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // creaciónToolStripMenuItem
            // 
            this.creaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expedientesToolStripMenuItem,
            this.camposTrazablesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clasificaciñonDeTramitesToolStripMenuItem,
            this.tramitesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.clasificaciónDeDocumentosToolStripMenuItem,
            this.documentosToolStripMenuItem});
            this.creaciónToolStripMenuItem.Image = global::thumbnail.Properties.Resources.notepad;
            this.creaciónToolStripMenuItem.Name = "creaciónToolStripMenuItem";
            this.creaciónToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.creaciónToolStripMenuItem.Text = "Creación";
            // 
            // expedientesToolStripMenuItem
            // 
            this.expedientesToolStripMenuItem.Name = "expedientesToolStripMenuItem";
            this.expedientesToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.expedientesToolStripMenuItem.Text = "Expedientes";
            // 
            // camposTrazablesToolStripMenuItem
            // 
            this.camposTrazablesToolStripMenuItem.Name = "camposTrazablesToolStripMenuItem";
            this.camposTrazablesToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.camposTrazablesToolStripMenuItem.Text = "Campos trazables";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(265, 6);
            // 
            // clasificaciñonDeTramitesToolStripMenuItem
            // 
            this.clasificaciñonDeTramitesToolStripMenuItem.Name = "clasificaciñonDeTramitesToolStripMenuItem";
            this.clasificaciñonDeTramitesToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.clasificaciñonDeTramitesToolStripMenuItem.Text = "Clasificaciñon de trámites";
            // 
            // tramitesToolStripMenuItem
            // 
            this.tramitesToolStripMenuItem.Name = "tramitesToolStripMenuItem";
            this.tramitesToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.tramitesToolStripMenuItem.Text = "Trámites";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(265, 6);
            // 
            // clasificaciónDeDocumentosToolStripMenuItem
            // 
            this.clasificaciónDeDocumentosToolStripMenuItem.Name = "clasificaciónDeDocumentosToolStripMenuItem";
            this.clasificaciónDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.clasificaciónDeDocumentosToolStripMenuItem.Text = "Clasificación de documentos";
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // papelToolStripMenuItem
            // 
            this.papelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroYSeguimientoDeTramiteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.deshacerToolStripMenuItem,
            this.blquearDesbloquearToolStripMenuItem});
            this.papelToolStripMenuItem.Image = global::thumbnail.Icons16x16.hook;
            this.papelToolStripMenuItem.Name = "papelToolStripMenuItem";
            this.papelToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.papelToolStripMenuItem.Text = "@Papel";
            // 
            // registroYSeguimientoDeTramiteToolStripMenuItem
            // 
            this.registroYSeguimientoDeTramiteToolStripMenuItem.Name = "registroYSeguimientoDeTramiteToolStripMenuItem";
            this.registroYSeguimientoDeTramiteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.registroYSeguimientoDeTramiteToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
            this.registroYSeguimientoDeTramiteToolStripMenuItem.Text = "Registro y seguimiento";
            this.registroYSeguimientoDeTramiteToolStripMenuItem.Click += new System.EventHandler(this.registroYSeguimientoDeTramiteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(280, 6);
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
            this.deshacerToolStripMenuItem.Text = "Deshacer registro";
            // 
            // blquearDesbloquearToolStripMenuItem
            // 
            this.blquearDesbloquearToolStripMenuItem.Name = "blquearDesbloquearToolStripMenuItem";
            this.blquearDesbloquearToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
            this.blquearDesbloquearToolStripMenuItem.Text = "Blquear/Desbloquear";
            // 
            // administraciònToolStripMenuItem
            // 
            this.administraciònToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.toolStripMenuItem5,
            this.preferenciasToolStripMenuItem1});
            this.administraciònToolStripMenuItem.Image = global::thumbnail.Icons16x16.gestion;
            this.administraciònToolStripMenuItem.Name = "administraciònToolStripMenuItem";
            this.administraciònToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.administraciònToolStripMenuItem.Text = "Administración";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Image = global::thumbnail.Icons16x16.view;
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::thumbnail.Icons16x16.users;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(155, 6);
            // 
            // preferenciasToolStripMenuItem1
            // 
            this.preferenciasToolStripMenuItem1.Image = global::thumbnail.Icons16x16.wrench_plus;
            this.preferenciasToolStripMenuItem1.Name = "preferenciasToolStripMenuItem1";
            this.preferenciasToolStripMenuItem1.Size = new System.Drawing.Size(158, 24);
            this.preferenciasToolStripMenuItem1.Text = "Preferencias";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.acercaDeToolStripMenuItem.Image = global::thumbnail.Icons16x16.info;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Image = global::thumbnail.Icons16x16.app_window;
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tlp_proc);
            this.Controls.Add(this.mnustrip_menuprincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnustrip_menuprincipal;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trámite digital";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnustrip_menuprincipal.ResumeLayout(false);
            this.mnustrip_menuprincipal.PerformLayout();
            this.tlp_proc.ResumeLayout(false);
            this.tlp_proc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnustrip_menuprincipal;
        private System.Windows.Forms.ToolStripMenuItem creaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camposTrazablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clasificaciñonDeTramitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tramitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clasificaciónDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroYSeguimientoDeTramiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blquearDesbloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlp_proc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}