namespace thumbnail.forms
{
    partial class frm_hook
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.txtvalortrazable = new DevExpress.XtraEditors.TextEdit();
            this.lblmascampotrazable = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_ClasificacionDocumento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.lookUpEditClasificacionDocumentoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObligatorio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_clasificaciondocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrazabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamanio_Caracteres_Trazables = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMascara_Trazable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_re_tramites_re_clasificaciondocumentos_documentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tramite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTramite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ClasificacionTramite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclasificaciontramite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_clasificaciondocumento_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_clasificaciondocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_Formato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_formato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo_Hojas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo_Caras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResguardo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiempo_Resguardo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPolitica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_estatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dxValidationProvider_lookUpEdit_ClasificacionDocumento = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxValidationProvider_Valor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtvalortrazable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ClasificacionDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClasificacionDocumentoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider_lookUpEdit_ClasificacionDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider_Valor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvalortrazable
            // 
            this.txtvalortrazable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvalortrazable.Enabled = false;
            this.txtvalortrazable.Location = new System.Drawing.Point(12, 97);
            this.txtvalortrazable.Name = "txtvalortrazable";
            this.txtvalortrazable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtvalortrazable.Properties.Appearance.Options.UseFont = true;
            this.txtvalortrazable.Properties.Mask.BeepOnError = true;
            this.txtvalortrazable.Properties.Mask.EditMask = "9999-9999";
            this.txtvalortrazable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtvalortrazable.Size = new System.Drawing.Size(576, 30);
            this.txtvalortrazable.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Debe especificar el valor trazable";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider_Valor.SetValidationRule(this.txtvalortrazable, conditionValidationRule1);
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
            // lookUpEdit_ClasificacionDocumento
            // 
            this.lookUpEdit_ClasificacionDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEdit_ClasificacionDocumento.Location = new System.Drawing.Point(12, 36);
            this.lookUpEdit_ClasificacionDocumento.Name = "lookUpEdit_ClasificacionDocumento";
            this.lookUpEdit_ClasificacionDocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_ClasificacionDocumento.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_ClasificacionDocumento.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lookUpEdit_ClasificacionDocumento.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEdit_ClasificacionDocumento.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpEdit_ClasificacionDocumento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpEdit_ClasificacionDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_ClasificacionDocumento.Properties.DisplayMember = "Nombre";
            this.lookUpEdit_ClasificacionDocumento.Properties.ImmediatePopup = true;
            this.lookUpEdit_ClasificacionDocumento.Properties.LookAndFeel.SkinName = "VS2010";
            this.lookUpEdit_ClasificacionDocumento.Properties.NullText = "";
            this.lookUpEdit_ClasificacionDocumento.Properties.ValueMember = "id_documento";
            this.lookUpEdit_ClasificacionDocumento.Properties.View = this.lookUpEditClasificacionDocumentoView;
            this.lookUpEdit_ClasificacionDocumento.Size = new System.Drawing.Size(576, 30);
            this.lookUpEdit_ClasificacionDocumento.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Debe indicar el documento a vincular";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider_lookUpEdit_ClasificacionDocumento.SetValidationRule(this.lookUpEdit_ClasificacionDocumento, conditionValidationRule2);
            this.lookUpEdit_ClasificacionDocumento.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lookUpEditCamposTrazables_QueryPopUp);
            this.lookUpEdit_ClasificacionDocumento.EditValueChanged += new System.EventHandler(this.lookUpEditCamposTrazables_EditValueChanged);
            // 
            // lookUpEditClasificacionDocumentoView
            // 
            this.lookUpEditClasificacionDocumentoView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lookUpEditClasificacionDocumentoView.Appearance.HeaderPanel.Options.UseFont = true;
            this.lookUpEditClasificacionDocumentoView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lookUpEditClasificacionDocumentoView.Appearance.Row.Options.UseFont = true;
            this.lookUpEditClasificacionDocumentoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_documento,
            this.colNombre,
            this.colObligatorio,
            this.colDescripcion_clasificaciondocumento,
            this.colTrazabilidad,
            this.colTamanio_Caracteres_Trazables,
            this.colMascara_Trazable,
            this.colid_re_tramites_re_clasificaciondocumentos_documentos,
            this.colid_tramite,
            this.colTramite,
            this.colid_ClasificacionTramite,
            this.colclasificaciontramite,
            this.colre_clasificaciondocumento_documento,
            this.colid_origen,
            this.colOrigen,
            this.colOrden,
            this.colid_clasificaciondocumento,
            this.colid_Formato,
            this.colDescripcion_formato,
            this.colNo_Hojas,
            this.colNo_Caras,
            this.colEstado,
            this.colDescripcion_Estado,
            this.colResguardo,
            this.colTiempo_Resguardo,
            this.colPolitica,
            this.colid_estatus,
            this.colDescripcion_estatus});
            this.lookUpEditClasificacionDocumentoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lookUpEditClasificacionDocumentoView.GroupCount = 1;
            this.lookUpEditClasificacionDocumentoView.GroupFormat = "[#image]{1} {2}";
            this.lookUpEditClasificacionDocumentoView.Name = "lookUpEditClasificacionDocumentoView";
            this.lookUpEditClasificacionDocumentoView.OptionsBehavior.AutoExpandAllGroups = true;
            this.lookUpEditClasificacionDocumentoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lookUpEditClasificacionDocumentoView.OptionsView.ShowGroupPanel = false;
            this.lookUpEditClasificacionDocumentoView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDescripcion_clasificaciondocumento, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // 
            // colObligatorio
            // 
            this.colObligatorio.Caption = "Es obligatorio";
            this.colObligatorio.FieldName = "Obligatorio";
            this.colObligatorio.Name = "colObligatorio";
            this.colObligatorio.Visible = true;
            this.colObligatorio.VisibleIndex = 4;
            // 
            // colDescripcion_clasificaciondocumento
            // 
            this.colDescripcion_clasificaciondocumento.Caption = "Clasificación de documento";
            this.colDescripcion_clasificaciondocumento.FieldName = "Descripcion_clasificaciondocumento";
            this.colDescripcion_clasificaciondocumento.Name = "colDescripcion_clasificaciondocumento";
            this.colDescripcion_clasificaciondocumento.Visible = true;
            this.colDescripcion_clasificaciondocumento.VisibleIndex = 1;
            // 
            // colTrazabilidad
            // 
            this.colTrazabilidad.Caption = "Requiere trazabilidad";
            this.colTrazabilidad.FieldName = "Trazabilidad";
            this.colTrazabilidad.Name = "colTrazabilidad";
            this.colTrazabilidad.Visible = true;
            this.colTrazabilidad.VisibleIndex = 1;
            // 
            // colTamanio_Caracteres_Trazables
            // 
            this.colTamanio_Caracteres_Trazables.Caption = "Tamaño de caractéres trazables";
            this.colTamanio_Caracteres_Trazables.FieldName = "Tamanio_Caracteres_Trazables";
            this.colTamanio_Caracteres_Trazables.Name = "colTamanio_Caracteres_Trazables";
            this.colTamanio_Caracteres_Trazables.Visible = true;
            this.colTamanio_Caracteres_Trazables.VisibleIndex = 2;
            // 
            // colMascara_Trazable
            // 
            this.colMascara_Trazable.Caption = "Mascara trazable";
            this.colMascara_Trazable.FieldName = "Mascara_Trazable";
            this.colMascara_Trazable.Name = "colMascara_Trazable";
            this.colMascara_Trazable.Visible = true;
            this.colMascara_Trazable.VisibleIndex = 3;
            // 
            // colid_re_tramites_re_clasificaciondocumentos_documentos
            // 
            this.colid_re_tramites_re_clasificaciondocumentos_documentos.FieldName = "id_re_tramites_re_clasificaciondocumentos_documentos";
            this.colid_re_tramites_re_clasificaciondocumentos_documentos.Name = "colid_re_tramites_re_clasificaciondocumentos_documentos";
            // 
            // colid_tramite
            // 
            this.colid_tramite.FieldName = "id_tramite";
            this.colid_tramite.Name = "colid_tramite";
            // 
            // colTramite
            // 
            this.colTramite.FieldName = "Tramite";
            this.colTramite.Name = "colTramite";
            // 
            // colid_ClasificacionTramite
            // 
            this.colid_ClasificacionTramite.FieldName = "id_ClasificacionTramite";
            this.colid_ClasificacionTramite.Name = "colid_ClasificacionTramite";
            // 
            // colclasificaciontramite
            // 
            this.colclasificaciontramite.FieldName = "clasificaciontramite";
            this.colclasificaciontramite.Name = "colclasificaciontramite";
            // 
            // colre_clasificaciondocumento_documento
            // 
            this.colre_clasificaciondocumento_documento.FieldName = "re_clasificaciondocumento_documento";
            this.colre_clasificaciondocumento_documento.Name = "colre_clasificaciondocumento_documento";
            // 
            // colid_origen
            // 
            this.colid_origen.FieldName = "id_origen";
            this.colid_origen.Name = "colid_origen";
            // 
            // colOrigen
            // 
            this.colOrigen.FieldName = "Origen";
            this.colOrigen.Name = "colOrigen";
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            // 
            // colid_clasificaciondocumento
            // 
            this.colid_clasificaciondocumento.FieldName = "id_clasificaciondocumento";
            this.colid_clasificaciondocumento.Name = "colid_clasificaciondocumento";
            // 
            // colid_Formato
            // 
            this.colid_Formato.FieldName = "id_Formato";
            this.colid_Formato.Name = "colid_Formato";
            // 
            // colDescripcion_formato
            // 
            this.colDescripcion_formato.FieldName = "Descripcion_formato";
            this.colDescripcion_formato.Name = "colDescripcion_formato";
            // 
            // colNo_Hojas
            // 
            this.colNo_Hojas.FieldName = "No_Hojas";
            this.colNo_Hojas.Name = "colNo_Hojas";
            // 
            // colNo_Caras
            // 
            this.colNo_Caras.FieldName = "No_Caras";
            this.colNo_Caras.Name = "colNo_Caras";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colDescripcion_Estado
            // 
            this.colDescripcion_Estado.FieldName = "Descripcion_Estado";
            this.colDescripcion_Estado.Name = "colDescripcion_Estado";
            // 
            // colResguardo
            // 
            this.colResguardo.FieldName = "Resguardo";
            this.colResguardo.Name = "colResguardo";
            // 
            // colTiempo_Resguardo
            // 
            this.colTiempo_Resguardo.FieldName = "Tiempo_Resguardo";
            this.colTiempo_Resguardo.Name = "colTiempo_Resguardo";
            // 
            // colPolitica
            // 
            this.colPolitica.FieldName = "Politica";
            this.colPolitica.Name = "colPolitica";
            // 
            // colid_estatus
            // 
            this.colid_estatus.FieldName = "id_estatus";
            this.colid_estatus.Name = "colid_estatus";
            // 
            // colDescripcion_estatus
            // 
            this.colDescripcion_estatus.FieldName = "Descripcion_estatus";
            this.colDescripcion_estatus.Name = "colDescripcion_estatus";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aceptar.AutoSize = true;
            this.btn_aceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Image = global::thumbnail.Icons48x48.checkbox_checked;
            this.btn_aceptar.Location = new System.Drawing.Point(464, 139);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(54, 54);
            this.btn_aceptar.TabIndex = 45;
            this.toolTip.SetToolTip(this.btn_aceptar, "Vincular documento");
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::thumbnail.Icons48x48.close;
            this.btn_cancelar.Location = new System.Drawing.Point(533, 139);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(54, 54);
            this.btn_cancelar.TabIndex = 46;
            this.toolTip.SetToolTip(this.btn_cancelar, "Cancelar vinculación de documento");
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dxValidationProvider_lookUpEdit_ClasificacionDocumento
            // 
            this.dxValidationProvider_lookUpEdit_ClasificacionDocumento.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // dxValidationProvider_Valor
            // 
            this.dxValidationProvider_Valor.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // frm_hook
            // 
            this.AcceptButton = this.btn_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(600, 202);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblmascampotrazable);
            this.Controls.Add(this.txtvalortrazable);
            this.Controls.Add(this.lookUpEdit_ClasificacionDocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_hook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vinculación de imagenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmhook_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtvalortrazable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ClasificacionDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClasificacionDocumentoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider_lookUpEdit_ClasificacionDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider_Valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtvalortrazable;
        private DevExpress.XtraEditors.LabelControl lblmascampotrazable;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit lookUpEdit_ClasificacionDocumento;
        private System.Windows.Forms.ToolTip toolTip;
        private DevExpress.XtraGrid.Views.Grid.GridView lookUpEditClasificacionDocumentoView;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider_lookUpEdit_ClasificacionDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colObligatorio;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_clasificaciondocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colTrazabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colTamanio_Caracteres_Trazables;
        private DevExpress.XtraGrid.Columns.GridColumn colMascara_Trazable;
        private DevExpress.XtraGrid.Columns.GridColumn colid_re_tramites_re_clasificaciondocumentos_documentos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tramite;
        private DevExpress.XtraGrid.Columns.GridColumn colTramite;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ClasificacionTramite;
        private DevExpress.XtraGrid.Columns.GridColumn colclasificaciontramite;
        private DevExpress.XtraGrid.Columns.GridColumn colre_clasificaciondocumento_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_origen;
        private DevExpress.XtraGrid.Columns.GridColumn colOrigen;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colid_clasificaciondocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Formato;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_formato;
        private DevExpress.XtraGrid.Columns.GridColumn colNo_Hojas;
        private DevExpress.XtraGrid.Columns.GridColumn colNo_Caras;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colResguardo;
        private DevExpress.XtraGrid.Columns.GridColumn colTiempo_Resguardo;
        private DevExpress.XtraGrid.Columns.GridColumn colPolitica;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_estatus;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider_Valor;
    }
}