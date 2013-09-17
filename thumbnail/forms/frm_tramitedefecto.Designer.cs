namespace scanndoc.forms
{
    partial class frm_tramitedefecto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tramitedefecto));
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idexpedienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciontramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionclasificaciontramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionExpedienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclasificaciontramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionBrevetramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcanceInicialtramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcanceFinaltramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestatustramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionestatustramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idreexpedientestramitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipobloqueoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionbloqueoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohorasbloqueoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodiasbloqueoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pbfind = new System.Windows.Forms.PictureBox();
            this.txt_buscar = new DevExpress.XtraEditors.TextEdit();
            this.tlp_proc = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_buscar.Properties)).BeginInit();
            this.tlp_proc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview.AutoGenerateColumns = false;
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccion,
            this.idexpedienteDataGridViewTextBoxColumn,
            this.nombretramiteDataGridViewTextBoxColumn,
            this.descripciontramiteDataGridViewTextBoxColumn,
            this.descripcionclasificaciontramiteDataGridViewTextBoxColumn,
            this.descripcionExpedienteDataGridViewTextBoxColumn,
            this.idclasificaciontramiteDataGridViewTextBoxColumn,
            this.idtramiteDataGridViewTextBoxColumn,
            this.descripcionBrevetramiteDataGridViewTextBoxColumn,
            this.alcanceInicialtramiteDataGridViewTextBoxColumn,
            this.alcanceFinaltramiteDataGridViewTextBoxColumn,
            this.idestatustramiteDataGridViewTextBoxColumn,
            this.descripcionestatustramiteDataGridViewTextBoxColumn,
            this.idreexpedientestramitesDataGridViewTextBoxColumn,
            this.idtipobloqueoDataGridViewTextBoxColumn,
            this.descripcionbloqueoDataGridViewTextBoxColumn,
            this.nohorasbloqueoDataGridViewTextBoxColumn,
            this.nodiasbloqueoDataGridViewTextBoxColumn});
            this.datagridview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datagridview.DataSource = this.BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.datagridview.EnableHeadersVisualStyles = false;
            this.datagridview.Location = new System.Drawing.Point(0, 74);
            this.datagridview.MultiSelect = false;
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview.Size = new System.Drawing.Size(910, 263);
            this.datagridview.TabIndex = 1;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellClick);
            // 
            // seleccion
            // 
            this.seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.seleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seleccion.HeaderText = "";
            this.seleccion.Name = "seleccion";
            this.seleccion.ReadOnly = true;
            this.seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.seleccion.Width = 40;
            // 
            // idexpedienteDataGridViewTextBoxColumn
            // 
            this.idexpedienteDataGridViewTextBoxColumn.DataPropertyName = "id_expediente";
            this.idexpedienteDataGridViewTextBoxColumn.HeaderText = "id_expediente";
            this.idexpedienteDataGridViewTextBoxColumn.Name = "idexpedienteDataGridViewTextBoxColumn";
            this.idexpedienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idexpedienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombretramiteDataGridViewTextBoxColumn
            // 
            this.nombretramiteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_tramite";
            this.nombretramiteDataGridViewTextBoxColumn.HeaderText = "Trámite";
            this.nombretramiteDataGridViewTextBoxColumn.Name = "nombretramiteDataGridViewTextBoxColumn";
            this.nombretramiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripciontramiteDataGridViewTextBoxColumn
            // 
            this.descripciontramiteDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_tramite";
            this.descripciontramiteDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripciontramiteDataGridViewTextBoxColumn.Name = "descripciontramiteDataGridViewTextBoxColumn";
            this.descripciontramiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionclasificaciontramiteDataGridViewTextBoxColumn
            // 
            this.descripcionclasificaciontramiteDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_clasificaciontramite";
            this.descripcionclasificaciontramiteDataGridViewTextBoxColumn.HeaderText = "Clasificación de trámite";
            this.descripcionclasificaciontramiteDataGridViewTextBoxColumn.Name = "descripcionclasificaciontramiteDataGridViewTextBoxColumn";
            this.descripcionclasificaciontramiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionExpedienteDataGridViewTextBoxColumn
            // 
            this.descripcionExpedienteDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Expediente";
            this.descripcionExpedienteDataGridViewTextBoxColumn.HeaderText = "Expediente";
            this.descripcionExpedienteDataGridViewTextBoxColumn.Name = "descripcionExpedienteDataGridViewTextBoxColumn";
            this.descripcionExpedienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idclasificaciontramiteDataGridViewTextBoxColumn
            // 
            this.idclasificaciontramiteDataGridViewTextBoxColumn.DataPropertyName = "id_clasificaciontramite";
            this.idclasificaciontramiteDataGridViewTextBoxColumn.HeaderText = "id_clasificaciontramite";
            this.idclasificaciontramiteDataGridViewTextBoxColumn.Name = "idclasificaciontramiteDataGridViewTextBoxColumn";
            this.idclasificaciontramiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclasificaciontramiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idtramiteDataGridViewTextBoxColumn
            // 
            this.idtramiteDataGridViewTextBoxColumn.DataPropertyName = "id_tramite";
            this.idtramiteDataGridViewTextBoxColumn.HeaderText = "id_tramite";
            this.idtramiteDataGridViewTextBoxColumn.Name = "idtramiteDataGridViewTextBoxColumn";
            this.idtramiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtramiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionBrevetramiteDataGridViewTextBoxColumn
            // 
            this.descripcionBrevetramiteDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Breve_tramite";
            this.descripcionBrevetramiteDataGridViewTextBoxColumn.HeaderText = "Descripcion_Breve_tramite";
            this.descripcionBrevetramiteDataGridViewTextBoxColumn.Name = "descripcionBrevetramiteDataGridViewTextBoxColumn";
            this.descripcionBrevetramiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionBrevetramiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // alcanceInicialtramiteDataGridViewTextBoxColumn
            // 
            this.alcanceInicialtramiteDataGridViewTextBoxColumn.DataPropertyName = "Alcance_Inicial_tramite";
            this.alcanceInicialtramiteDataGridViewTextBoxColumn.HeaderText = "Alcance_Inicial_tramite";
            this.alcanceInicialtramiteDataGridViewTextBoxColumn.Name = "alcanceInicialtramiteDataGridViewTextBoxColumn";
            this.alcanceInicialtramiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.alcanceInicialtramiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // alcanceFinaltramiteDataGridViewTextBoxColumn
            // 
            this.alcanceFinaltramiteDataGridViewTextBoxColumn.DataPropertyName = "Alcance_Final_tramite";
            this.alcanceFinaltramiteDataGridViewTextBoxColumn.HeaderText = "Alcance_Final_tramite";
            this.alcanceFinaltramiteDataGridViewTextBoxColumn.Name = "alcanceFinaltramiteDataGridViewTextBoxColumn";
            this.alcanceFinaltramiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.alcanceFinaltramiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idestatustramiteDataGridViewTextBoxColumn
            // 
            this.idestatustramiteDataGridViewTextBoxColumn.DataPropertyName = "id_estatus_tramite";
            this.idestatustramiteDataGridViewTextBoxColumn.HeaderText = "id_estatus_tramite";
            this.idestatustramiteDataGridViewTextBoxColumn.Name = "idestatustramiteDataGridViewTextBoxColumn";
            this.idestatustramiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idestatustramiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionestatustramiteDataGridViewTextBoxColumn
            // 
            this.descripcionestatustramiteDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_estatus_tramite";
            this.descripcionestatustramiteDataGridViewTextBoxColumn.HeaderText = "Descripcion_estatus_tramite";
            this.descripcionestatustramiteDataGridViewTextBoxColumn.Name = "descripcionestatustramiteDataGridViewTextBoxColumn";
            this.descripcionestatustramiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionestatustramiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idreexpedientestramitesDataGridViewTextBoxColumn
            // 
            this.idreexpedientestramitesDataGridViewTextBoxColumn.DataPropertyName = "id_re_expedientes_tramites";
            this.idreexpedientestramitesDataGridViewTextBoxColumn.HeaderText = "id_re_expedientes_tramites";
            this.idreexpedientestramitesDataGridViewTextBoxColumn.Name = "idreexpedientestramitesDataGridViewTextBoxColumn";
            this.idreexpedientestramitesDataGridViewTextBoxColumn.ReadOnly = true;
            this.idreexpedientestramitesDataGridViewTextBoxColumn.Visible = false;
            // 
            // idtipobloqueoDataGridViewTextBoxColumn
            // 
            this.idtipobloqueoDataGridViewTextBoxColumn.DataPropertyName = "id_tipobloqueo";
            this.idtipobloqueoDataGridViewTextBoxColumn.HeaderText = "id_tipobloqueo";
            this.idtipobloqueoDataGridViewTextBoxColumn.Name = "idtipobloqueoDataGridViewTextBoxColumn";
            this.idtipobloqueoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtipobloqueoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionbloqueoDataGridViewTextBoxColumn
            // 
            this.descripcionbloqueoDataGridViewTextBoxColumn.DataPropertyName = "descripcion_bloqueo";
            this.descripcionbloqueoDataGridViewTextBoxColumn.HeaderText = "descripcion_bloqueo";
            this.descripcionbloqueoDataGridViewTextBoxColumn.Name = "descripcionbloqueoDataGridViewTextBoxColumn";
            this.descripcionbloqueoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionbloqueoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nohorasbloqueoDataGridViewTextBoxColumn
            // 
            this.nohorasbloqueoDataGridViewTextBoxColumn.DataPropertyName = "no_horas_bloqueo";
            this.nohorasbloqueoDataGridViewTextBoxColumn.HeaderText = "no_horas_bloqueo";
            this.nohorasbloqueoDataGridViewTextBoxColumn.Name = "nohorasbloqueoDataGridViewTextBoxColumn";
            this.nohorasbloqueoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nohorasbloqueoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nodiasbloqueoDataGridViewTextBoxColumn
            // 
            this.nodiasbloqueoDataGridViewTextBoxColumn.DataPropertyName = "no_dias_bloqueo";
            this.nodiasbloqueoDataGridViewTextBoxColumn.HeaderText = "no_dias_bloqueo";
            this.nodiasbloqueoDataGridViewTextBoxColumn.Name = "nodiasbloqueoDataGridViewTextBoxColumn";
            this.nodiasbloqueoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nodiasbloqueoDataGridViewTextBoxColumn.Visible = false;
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(scanndoc.data_members.vw_ListaTramitesActivos);
            // 
            // BindingNavigator
            // 
            this.BindingNavigator.AddNewItem = null;
            this.BindingNavigator.BindingSource = this.BindingSource;
            this.BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigator.DeleteItem = null;
            this.BindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.BindingNavigator.Location = new System.Drawing.Point(0, 340);
            this.BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigator.Size = new System.Drawing.Size(910, 25);
            this.BindingNavigator.TabIndex = 3;
            this.BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aceptar.AutoSize = true;
            this.btn_aceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Image = global::scanndoc.Icons48x48.close;
            this.btn_aceptar.Location = new System.Drawing.Point(844, 6);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(54, 54);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 787;
            this.lineShape2.X2 = 1139;
            this.lineShape2.Y1 = 62;
            this.lineShape2.Y2 = 62;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(910, 365);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // pbfind
            // 
            this.pbfind.BackColor = System.Drawing.Color.Transparent;
            this.pbfind.Image = global::scanndoc.Icons16x16.zoom;
            this.pbfind.Location = new System.Drawing.Point(350, 50);
            this.pbfind.Name = "pbfind";
            this.pbfind.Size = new System.Drawing.Size(16, 16);
            this.pbfind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbfind.TabIndex = 18;
            this.pbfind.TabStop = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(0, 48);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_buscar.Properties.Appearance.Options.UseBackColor = true;
            this.txt_buscar.Properties.Appearance.Options.UseFont = true;
            this.txt_buscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_buscar.Size = new System.Drawing.Size(368, 20);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.Tag = "0";
            this.txt_buscar.EditValueChanged += new System.EventHandler(this.txt_buscar_EditValueChanged);
            // 
            // tlp_proc
            // 
            this.tlp_proc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_proc.BackColor = System.Drawing.Color.DimGray;
            this.tlp_proc.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_proc.ColumnCount = 2;
            this.tlp_proc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_proc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_proc.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_proc.Controls.Add(this.label2, 1, 0);
            this.tlp_proc.Location = new System.Drawing.Point(703, 303);
            this.tlp_proc.Name = "tlp_proc";
            this.tlp_proc.RowCount = 1;
            this.tlp_proc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_proc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlp_proc.Size = new System.Drawing.Size(195, 50);
            this.tlp_proc.TabIndex = 23;
            this.tlp_proc.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::scanndoc.Icons48x48.clock;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label2.Size = new System.Drawing.Size(145, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Favor de esperar";
            // 
            // frm_tramitedefecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 365);
            this.Controls.Add(this.tlp_proc);
            this.Controls.Add(this.pbfind);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.BindingNavigator);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frm_tramitedefecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trámite por defecto";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_tramitedefecto_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_buscar.Properties)).EndInit();
            this.tlp_proc.ResumeLayout(false);
            this.tlp_proc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.BindingNavigator BindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btn_aceptar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox pbfind;
        private DevExpress.XtraEditors.TextEdit txt_buscar;
        private System.Windows.Forms.TableLayoutPanel tlp_proc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idexpedienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciontramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionclasificaciontramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionExpedienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclasificaciontramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionBrevetramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcanceInicialtramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcanceFinaltramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestatustramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionestatustramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreexpedientestramitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipobloqueoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionbloqueoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohorasbloqueoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodiasbloqueoDataGridViewTextBoxColumn;
    }
}