namespace thumbnail.forms
{
    partial class frmhook
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.txtvalortrazable = new DevExpress.XtraEditors.TextEdit();
            this.lblmascampotrazable = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditClasificacionDocumento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.pbcancelar = new System.Windows.Forms.PictureBox();
            this.pbaceptar = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lookUpEditClasificacionDocumentoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.paObtenerDocumentosporTramiteyOrigenResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid_tramite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_clasificaciondocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclasificaciondocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObligatorio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colformato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnohojas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnocaras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrazabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamanio_Caracteres_Trazables = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMascara_Trazable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtvalortrazable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClasificacionDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClasificacionDocumentoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paObtenerDocumentosporTramiteyOrigenResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvalortrazable
            // 
            this.txtvalortrazable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvalortrazable.Location = new System.Drawing.Point(12, 97);
            this.txtvalortrazable.Name = "txtvalortrazable";
            this.txtvalortrazable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtvalortrazable.Properties.Appearance.Options.UseFont = true;
            this.txtvalortrazable.Properties.Mask.BeepOnError = true;
            this.txtvalortrazable.Properties.Mask.EditMask = "9999-9999";
            this.txtvalortrazable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtvalortrazable.Size = new System.Drawing.Size(576, 30);
            this.txtvalortrazable.TabIndex = 3;
            conditionValidationRule3.CaseSensitive = true;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Valor requerido";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.txtvalortrazable, conditionValidationRule3);
            this.txtvalortrazable.Click += new System.EventHandler(this.txtvalortrazable_Click);
            // 
            // lblmascampotrazable
            // 
            this.lblmascampotrazable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmascampotrazable.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblmascampotrazable.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblmascampotrazable.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblmascampotrazable.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblmascampotrazable.Location = new System.Drawing.Point(433, 85);
            this.lblmascampotrazable.Name = "lblmascampotrazable";
            this.lblmascampotrazable.Size = new System.Drawing.Size(154, 10);
            this.lblmascampotrazable.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Location = new System.Drawing.Point(12, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 23);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Documento";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Location = new System.Drawing.Point(12, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 23);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Valor";
            // 
            // lookUpEditClasificacionDocumento
            // 
            this.lookUpEditClasificacionDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditClasificacionDocumento.Location = new System.Drawing.Point(12, 36);
            this.lookUpEditClasificacionDocumento.Name = "lookUpEditClasificacionDocumento";
            this.lookUpEditClasificacionDocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lookUpEditClasificacionDocumento.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditClasificacionDocumento.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lookUpEditClasificacionDocumento.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEditClasificacionDocumento.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpEditClasificacionDocumento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpEditClasificacionDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditClasificacionDocumento.Properties.DataSource = this.paObtenerDocumentosporTramiteyOrigenResultBindingSource;
            this.lookUpEditClasificacionDocumento.Properties.DisplayMember = "documento";
            this.lookUpEditClasificacionDocumento.Properties.ImmediatePopup = true;
            this.lookUpEditClasificacionDocumento.Properties.LookAndFeel.SkinName = "VS2010";
            this.lookUpEditClasificacionDocumento.Properties.NullText = "";
            this.lookUpEditClasificacionDocumento.Properties.ValueMember = "id_documento";
            this.lookUpEditClasificacionDocumento.Properties.View = this.lookUpEditClasificacionDocumentoView;
            this.lookUpEditClasificacionDocumento.Size = new System.Drawing.Size(576, 30);
            this.lookUpEditClasificacionDocumento.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Debe indicar el tipo de documento a enlazar";
            this.dxValidationProvider.SetValidationRule(this.lookUpEditClasificacionDocumento, conditionValidationRule1);
            this.lookUpEditClasificacionDocumento.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lookUpEditCamposTrazables_QueryPopUp);
            this.lookUpEditClasificacionDocumento.EditValueChanged += new System.EventHandler(this.lookUpEditCamposTrazables_EditValueChanged);
            // 
            // pbcancelar
            // 
            this.pbcancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbcancelar.Image = global::thumbnail.Properties.Resources.close;
            this.pbcancelar.Location = new System.Drawing.Point(554, 133);
            this.pbcancelar.Name = "pbcancelar";
            this.pbcancelar.Size = new System.Drawing.Size(33, 33);
            this.pbcancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcancelar.TabIndex = 23;
            this.pbcancelar.TabStop = false;
            this.toolTip.SetToolTip(this.pbcancelar, "Cancelar vinculación");
            this.pbcancelar.Click += new System.EventHandler(this.pbcancelar_Click);
            // 
            // pbaceptar
            // 
            this.pbaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbaceptar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbaceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbaceptar.Image = global::thumbnail.Properties.Resources.checkmark;
            this.pbaceptar.Location = new System.Drawing.Point(515, 133);
            this.pbaceptar.Name = "pbaceptar";
            this.pbaceptar.Size = new System.Drawing.Size(33, 33);
            this.pbaceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbaceptar.TabIndex = 22;
            this.pbaceptar.TabStop = false;
            this.toolTip.SetToolTip(this.pbaceptar, "Vincular imagenes");
            this.pbaceptar.Click += new System.EventHandler(this.pbaceptar_Click);
            // 
            // lookUpEditClasificacionDocumentoView
            // 
            this.lookUpEditClasificacionDocumentoView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditClasificacionDocumentoView.Appearance.HeaderPanel.Options.UseFont = true;
            this.lookUpEditClasificacionDocumentoView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditClasificacionDocumentoView.Appearance.Row.Options.UseFont = true;
            this.lookUpEditClasificacionDocumentoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_tramite,
            this.colid_clasificaciondocumento,
            this.colclasificaciondocumento,
            this.colid_origen,
            this.colOrden,
            this.colObligatorio,
            this.colid_documento,
            this.coldocumento,
            this.colformato,
            this.colnohojas,
            this.colnocaras,
            this.colestado,
            this.colTrazabilidad,
            this.colTamanio_Caracteres_Trazables,
            this.colMascara_Trazable});
            this.lookUpEditClasificacionDocumentoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lookUpEditClasificacionDocumentoView.GroupCount = 1;
            this.lookUpEditClasificacionDocumentoView.GroupFormat = "[#image]{1} {2}";
            this.lookUpEditClasificacionDocumentoView.Name = "lookUpEditClasificacionDocumentoView";
            this.lookUpEditClasificacionDocumentoView.OptionsBehavior.AutoExpandAllGroups = true;
            this.lookUpEditClasificacionDocumentoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lookUpEditClasificacionDocumentoView.OptionsView.ShowGroupPanel = false;
            this.lookUpEditClasificacionDocumentoView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colclasificaciondocumento, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // paObtenerDocumentosporTramiteyOrigenResultBindingSource
            // 
            this.paObtenerDocumentosporTramiteyOrigenResultBindingSource.DataSource = typeof(thumbnail.data_members.pa_ObtenerDocumentosporTramiteyOrigenResult);
            // 
            // colid_tramite
            // 
            this.colid_tramite.FieldName = "id_tramite";
            this.colid_tramite.Name = "colid_tramite";
            this.colid_tramite.OptionsColumn.AllowEdit = false;
            // 
            // colid_clasificaciondocumento
            // 
            this.colid_clasificaciondocumento.FieldName = "id_clasificaciondocumento";
            this.colid_clasificaciondocumento.Name = "colid_clasificaciondocumento";
            this.colid_clasificaciondocumento.OptionsColumn.AllowEdit = false;
            // 
            // colclasificaciondocumento
            // 
            this.colclasificaciondocumento.Caption = "Clasificacion de documento";
            this.colclasificaciondocumento.FieldName = "clasificaciondocumento";
            this.colclasificaciondocumento.Name = "colclasificaciondocumento";
            this.colclasificaciondocumento.OptionsColumn.AllowEdit = false;
            this.colclasificaciondocumento.Visible = true;
            this.colclasificaciondocumento.VisibleIndex = 2;
            // 
            // colid_origen
            // 
            this.colid_origen.FieldName = "id_origen";
            this.colid_origen.Name = "colid_origen";
            this.colid_origen.OptionsColumn.AllowEdit = false;
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            this.colOrden.OptionsColumn.AllowEdit = false;
            // 
            // colObligatorio
            // 
            this.colObligatorio.Caption = "Es obligatorio";
            this.colObligatorio.FieldName = "Obligatorio";
            this.colObligatorio.Name = "colObligatorio";
            this.colObligatorio.OptionsColumn.AllowEdit = false;
            this.colObligatorio.Visible = true;
            this.colObligatorio.VisibleIndex = 1;
            // 
            // colid_documento
            // 
            this.colid_documento.FieldName = "id_documento";
            this.colid_documento.Name = "colid_documento";
            this.colid_documento.OptionsColumn.AllowEdit = false;
            // 
            // coldocumento
            // 
            this.coldocumento.Caption = "Documento";
            this.coldocumento.FieldName = "documento";
            this.coldocumento.Name = "coldocumento";
            this.coldocumento.OptionsColumn.AllowEdit = false;
            this.coldocumento.Visible = true;
            this.coldocumento.VisibleIndex = 0;
            // 
            // colformato
            // 
            this.colformato.Caption = "Formato";
            this.colformato.FieldName = "formato";
            this.colformato.Name = "colformato";
            this.colformato.OptionsColumn.AllowEdit = false;
            this.colformato.Visible = true;
            this.colformato.VisibleIndex = 5;
            // 
            // colnohojas
            // 
            this.colnohojas.Caption = "No. hojas";
            this.colnohojas.FieldName = "nohojas";
            this.colnohojas.Name = "colnohojas";
            this.colnohojas.OptionsColumn.AllowEdit = false;
            this.colnohojas.Visible = true;
            this.colnohojas.VisibleIndex = 6;
            // 
            // colnocaras
            // 
            this.colnocaras.Caption = "No. caras";
            this.colnocaras.FieldName = "nocaras";
            this.colnocaras.Name = "colnocaras";
            this.colnocaras.OptionsColumn.AllowEdit = false;
            this.colnocaras.Visible = true;
            this.colnocaras.VisibleIndex = 7;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado del documento";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 8;
            // 
            // colTrazabilidad
            // 
            this.colTrazabilidad.Caption = "Requiere trazabilidad";
            this.colTrazabilidad.FieldName = "Trazabilidad";
            this.colTrazabilidad.Name = "colTrazabilidad";
            this.colTrazabilidad.OptionsColumn.AllowEdit = false;
            this.colTrazabilidad.Visible = true;
            this.colTrazabilidad.VisibleIndex = 2;
            // 
            // colTamanio_Caracteres_Trazables
            // 
            this.colTamanio_Caracteres_Trazables.Caption = "Tamaño de caracteres trazables";
            this.colTamanio_Caracteres_Trazables.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTamanio_Caracteres_Trazables.FieldName = "Tamanio_Caracteres_Trazables";
            this.colTamanio_Caracteres_Trazables.Name = "colTamanio_Caracteres_Trazables";
            this.colTamanio_Caracteres_Trazables.OptionsColumn.AllowEdit = false;
            this.colTamanio_Caracteres_Trazables.Visible = true;
            this.colTamanio_Caracteres_Trazables.VisibleIndex = 3;
            // 
            // colMascara_Trazable
            // 
            this.colMascara_Trazable.Caption = "Mascara trazable";
            this.colMascara_Trazable.FieldName = "Mascara_Trazable";
            this.colMascara_Trazable.Name = "colMascara_Trazable";
            this.colMascara_Trazable.OptionsColumn.AllowEdit = false;
            this.colMascara_Trazable.Visible = true;
            this.colMascara_Trazable.VisibleIndex = 4;
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // frmhook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 172);
            this.Controls.Add(this.pbcancelar);
            this.Controls.Add(this.pbaceptar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblmascampotrazable);
            this.Controls.Add(this.txtvalortrazable);
            this.Controls.Add(this.lookUpEditClasificacionDocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmhook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vinculación de imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.txtvalortrazable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClasificacionDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClasificacionDocumentoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paObtenerDocumentosporTramiteyOrigenResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtvalortrazable;
        private DevExpress.XtraEditors.LabelControl lblmascampotrazable;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit lookUpEditClasificacionDocumento;
        private System.Windows.Forms.PictureBox pbcancelar;
        private System.Windows.Forms.PictureBox pbaceptar;
        private System.Windows.Forms.ToolTip toolTip;
        private DevExpress.XtraGrid.Views.Grid.GridView lookUpEditClasificacionDocumentoView;
        private System.Windows.Forms.BindingSource paObtenerDocumentosporTramiteyOrigenResultBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tramite;
        private DevExpress.XtraGrid.Columns.GridColumn colid_clasificaciondocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colclasificaciondocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_origen;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colObligatorio;
        private DevExpress.XtraGrid.Columns.GridColumn colid_documento;
        private DevExpress.XtraGrid.Columns.GridColumn coldocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colformato;
        private DevExpress.XtraGrid.Columns.GridColumn colnohojas;
        private DevExpress.XtraGrid.Columns.GridColumn colnocaras;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colTrazabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colTamanio_Caracteres_Trazables;
        private DevExpress.XtraGrid.Columns.GridColumn colMascara_Trazable;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}