﻿namespace thumbnail.forms
{
    partial class frm_ListaDocumentosOrden
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
            this.bindingsource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_re_clasificaciondocumentos_documentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_clasificaciondocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_clasificaciondocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrazabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobligatorio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamanio_Caracteres_Trazables = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMascara_Trazable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingsource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingsource
            // 
            this.bindingsource.DataSource = typeof(thumbnail.data_members.pa_ObtenerDocumentosporTramiteyOrigenResult);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_re_clasificaciondocumentos_documentos,
            this.colid_clasificaciondocumento,
            this.colDescripcion_clasificaciondocumento,
            this.colid_documento,
            this.colNombre,
            this.colTrazabilidad,
            this.colobligatorio,
            this.colorden,
            this.colTamanio_Caracteres_Trazables,
            this.colMascara_Trazable});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView1.GroupFormat = "[#image]{1} {2}";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDescripcion_clasificaciondocumento, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid_re_clasificaciondocumentos_documentos
            // 
            this.colid_re_clasificaciondocumentos_documentos.FieldName = "id_re_clasificaciondocumentos_documentos";
            this.colid_re_clasificaciondocumentos_documentos.Name = "colid_re_clasificaciondocumentos_documentos";
            // 
            // colid_clasificaciondocumento
            // 
            this.colid_clasificaciondocumento.FieldName = "id_clasificaciondocumento";
            this.colid_clasificaciondocumento.Name = "colid_clasificaciondocumento";
            // 
            // colDescripcion_clasificaciondocumento
            // 
            this.colDescripcion_clasificaciondocumento.Caption = "Clasificación de documento";
            this.colDescripcion_clasificaciondocumento.FieldName = "Descripcion_clasificaciondocumento";
            this.colDescripcion_clasificaciondocumento.Name = "colDescripcion_clasificaciondocumento";
            this.colDescripcion_clasificaciondocumento.Visible = true;
            this.colDescripcion_clasificaciondocumento.VisibleIndex = 0;
            // 
            // colid_documento
            // 
            this.colid_documento.FieldName = "id_documento";
            this.colid_documento.Name = "colid_documento";
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Documento";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            this.colNombre.Width = 166;
            // 
            // colTrazabilidad
            // 
            this.colTrazabilidad.Caption = "Requiere trazabilidad";
            this.colTrazabilidad.FieldName = "Trazabilidad";
            this.colTrazabilidad.Name = "colTrazabilidad";
            this.colTrazabilidad.Visible = true;
            this.colTrazabilidad.VisibleIndex = 1;
            this.colTrazabilidad.Width = 110;
            // 
            // colobligatorio
            // 
            this.colobligatorio.Caption = "Es obligatorio";
            this.colobligatorio.FieldName = "obligatorio";
            this.colobligatorio.Name = "colobligatorio";
            this.colobligatorio.Visible = true;
            this.colobligatorio.VisibleIndex = 2;
            this.colobligatorio.Width = 73;
            // 
            // colorden
            // 
            this.colorden.FieldName = "orden";
            this.colorden.Name = "colorden";
            // 
            // colTamanio_Caracteres_Trazables
            // 
            this.colTamanio_Caracteres_Trazables.Caption = "Tamaño de caractéres trazables";
            this.colTamanio_Caracteres_Trazables.FieldName = "Tamanio_Caracteres_Trazables";
            this.colTamanio_Caracteres_Trazables.Name = "colTamanio_Caracteres_Trazables";
            this.colTamanio_Caracteres_Trazables.Visible = true;
            this.colTamanio_Caracteres_Trazables.VisibleIndex = 3;
            this.colTamanio_Caracteres_Trazables.Width = 163;
            // 
            // colMascara_Trazable
            // 
            this.colMascara_Trazable.Caption = "Máscara trazable";
            this.colMascara_Trazable.FieldName = "Mascara_Trazable";
            this.colMascara_Trazable.Name = "colMascara_Trazable";
            this.colMascara_Trazable.Visible = true;
            this.colMascara_Trazable.VisibleIndex = 4;
            this.colMascara_Trazable.Width = 203;
            // 
            // pa_ObtenerDocumentosporTramiteyOrigenResultGridControl
            // 
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.DataSource = this.bindingsource;
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.Location = new System.Drawing.Point(0, 0);
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.MainView = this.gridView1;
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.Name = "pa_ObtenerDocumentosporTramiteyOrigenResultGridControl";
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.Size = new System.Drawing.Size(733, 237);
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.TabIndex = 1;
            this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frm_ListaDocumentosOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 237);
            this.Controls.Add(this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_ListaDocumentosOrden";
            this.Text = "Lista de documentos a enlazar";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.frm_ListaDocumentosOrden_Activated);
            this.Deactivate += new System.EventHandler(this.frm_ListaDocumentosOrden_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ListaDocumentosOrden_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingsource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_ObtenerDocumentosporTramiteyOrigenResultGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingsource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_re_clasificaciondocumentos_documentos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_clasificaciondocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_clasificaciondocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTrazabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colobligatorio;
        private DevExpress.XtraGrid.Columns.GridColumn colorden;
        private DevExpress.XtraGrid.Columns.GridColumn colTamanio_Caracteres_Trazables;
        private DevExpress.XtraGrid.Columns.GridColumn colMascara_Trazable;
        private DevExpress.XtraGrid.GridControl pa_ObtenerDocumentosporTramiteyOrigenResultGridControl;
    }
}