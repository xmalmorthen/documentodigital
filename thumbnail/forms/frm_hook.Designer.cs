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
            this.bindingsource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEditClasificacionDocumentoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_re_clasificaciondocumentos_documentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_clasificaciondocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_clasificaciondocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrazabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobligatorio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dxValidationProvider_lookUpEdit_ClasificacionDocumento = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxValidationProvider_Valor = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtvalortrazable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ClasificacionDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingsource)).BeginInit();
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
            this.txtvalortrazable.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtvalortrazable.Properties.Mask.BeepOnError = true;
            this.txtvalortrazable.Properties.Mask.EditMask = "9999-9999";
            this.txtvalortrazable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtvalortrazable.Size = new System.Drawing.Size(678, 30);
            this.txtvalortrazable.TabIndex = 1;
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
            this.lblmascampotrazable.Location = new System.Drawing.Point(175, 79);
            this.lblmascampotrazable.Name = "lblmascampotrazable";
            this.lblmascampotrazable.Size = new System.Drawing.Size(514, 16);
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
            this.lookUpEdit_ClasificacionDocumento.Properties.DataSource = this.bindingsource;
            this.lookUpEdit_ClasificacionDocumento.Properties.DisplayMember = "Nombre";
            this.lookUpEdit_ClasificacionDocumento.Properties.ImmediatePopup = true;
            this.lookUpEdit_ClasificacionDocumento.Properties.LookAndFeel.SkinName = "VS2010";
            this.lookUpEdit_ClasificacionDocumento.Properties.NullText = "";
            this.lookUpEdit_ClasificacionDocumento.Properties.PopupFormSize = new System.Drawing.Size(700, 0);
            this.lookUpEdit_ClasificacionDocumento.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.lookUpEdit_ClasificacionDocumento.Properties.ValueMember = "id_documento";
            this.lookUpEdit_ClasificacionDocumento.Properties.View = this.lookUpEditClasificacionDocumentoView;
            this.lookUpEdit_ClasificacionDocumento.Size = new System.Drawing.Size(678, 30);
            this.lookUpEdit_ClasificacionDocumento.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Debe indicar el documento a vincular";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider_lookUpEdit_ClasificacionDocumento.SetValidationRule(this.lookUpEdit_ClasificacionDocumento, conditionValidationRule2);
            this.lookUpEdit_ClasificacionDocumento.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lookUpEditCamposTrazables_QueryPopUp);
            this.lookUpEdit_ClasificacionDocumento.EditValueChanged += new System.EventHandler(this.lookUpEditCamposTrazables_EditValueChanged);
            // 
            // bindingsource
            // 
            this.bindingsource.DataSource = typeof(thumbnail.data_members.pa_ObtenerDocumentosporTramiteyOrigenResult);
            // 
            // lookUpEditClasificacionDocumentoView
            // 
            this.lookUpEditClasificacionDocumentoView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lookUpEditClasificacionDocumentoView.Appearance.HeaderPanel.Options.UseFont = true;
            this.lookUpEditClasificacionDocumentoView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lookUpEditClasificacionDocumentoView.Appearance.Row.Options.UseFont = true;
            this.lookUpEditClasificacionDocumentoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_re_clasificaciondocumentos_documentos,
            this.colid_clasificaciondocumento,
            this.colDescripcion_clasificaciondocumento,
            this.colid_documento,
            this.colNombre,
            this.colTrazabilidad,
            this.colobligatorio,
            this.colorden});
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
            this.colDescripcion_clasificaciondocumento.FieldName = "Descripcion_clasificaciondocumento";
            this.colDescripcion_clasificaciondocumento.Name = "colDescripcion_clasificaciondocumento";
            this.colDescripcion_clasificaciondocumento.Visible = true;
            this.colDescripcion_clasificaciondocumento.VisibleIndex = 2;
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
            // colTrazabilidad
            // 
            this.colTrazabilidad.Caption = "Requiere trazabilidad";
            this.colTrazabilidad.FieldName = "Trazabilidad";
            this.colTrazabilidad.Name = "colTrazabilidad";
            this.colTrazabilidad.Visible = true;
            this.colTrazabilidad.VisibleIndex = 1;
            // 
            // colobligatorio
            // 
            this.colobligatorio.Caption = "Es obligatorio";
            this.colobligatorio.FieldName = "obligatorio";
            this.colobligatorio.Name = "colobligatorio";
            this.colobligatorio.Visible = true;
            this.colobligatorio.VisibleIndex = 2;
            // 
            // colorden
            // 
            this.colorden.FieldName = "orden";
            this.colorden.Name = "colorden";
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
            this.btn_aceptar.Location = new System.Drawing.Point(566, 153);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(54, 54);
            this.btn_aceptar.TabIndex = 2;
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
            this.btn_cancelar.Location = new System.Drawing.Point(635, 153);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(54, 54);
            this.btn_cancelar.TabIndex = 3;
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
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(702, 216);
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
            this.Load += new System.EventHandler(this.frm_hook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtvalortrazable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_ClasificacionDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingsource)).EndInit();
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
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider_Valor;
        private System.Windows.Forms.BindingSource bindingsource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_re_clasificaciondocumentos_documentos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_clasificaciondocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_clasificaciondocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_documento;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTrazabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colobligatorio;
        private DevExpress.XtraGrid.Columns.GridColumn colorden;
    }
}