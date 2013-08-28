using thumbnail.data_members;
namespace thumbnail.forms
{
    partial class frm_scann
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_scann));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cntmnuListViewEnlace = new System.Windows.Forms.ContextMenuStrip();
            this.tsmnuitemlstvwenlaceabrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwenlaceeliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwenlaceseparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuitemlstvwenlacedesenlazar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwenlacedesenlazarseleccionado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwenlacedesenlazartodo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuitemlstvwenlacegirarderecha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwenlacegirarizquierda = new System.Windows.Forms.ToolStripMenuItem();
            this.cntmnuListViewScann = new System.Windows.Forms.ContextMenuStrip();
            this.tsmnuitemlstvwscannabrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwscanneliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwscannseparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuitemlstvwscannenlazar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwscannenlazarsubmnuseleccionado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuitemlstvwscannenlazarsubmnutodo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwscannseparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuitemlstvwscannseltodo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwscannrotarderecha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuitemlstvwscannrotarizquierda = new System.Windows.Forms.ToolStripMenuItem();
            this.imglsttabs = new System.Windows.Forms.ImageList();
            this.tooltipBtnMnuOptions = new System.Windows.Forms.ToolTip();
            this.btn_limpiarcontroles = new System.Windows.Forms.Button();
            this.btn_abririmagen = new System.Windows.Forms.Button();
            this.btn_scanear = new System.Windows.Forms.Button();
            this.tab2_pblbldocumentosescaneados = new System.Windows.Forms.PictureBox();
            this.tab2_pblbldocumentosenlazados = new System.Windows.Forms.PictureBox();
            this.tab3_pblbldocumentosescaneados = new System.Windows.Forms.PictureBox();
            this.tab3_pblbldocumentosenlazados = new System.Windows.Forms.PictureBox();
            this.btn_config_scann = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.tab0_pblbldocumentosescaneados = new System.Windows.Forms.PictureBox();
            this.tab0_pblbldocumentosenlazados = new System.Windows.Forms.PictureBox();
            this.tab1_pblbldocumentosenlazados = new System.Windows.Forms.PictureBox();
            this.tab1_pblbldocumentosescaneados = new System.Windows.Forms.PictureBox();
            this.ofdabrirarchivo = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpEdit_Tramites = new DevExpress.XtraEditors.LookUpEdit();
            this.KDImage = new AxKDImageEditor.AxKDImage();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dataGridView_CamposTrazables = new System.Windows.Forms.DataGridView();
            this.idcampotrazableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanioCaracteresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esprincipalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_valor_trazable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_re_expedientes_campostrazables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paCampostrazablesActivosporExpedienteResultBindingSource = new System.Windows.Forms.BindingSource();
            this.tbctrl = new System.Windows.Forms.TabControl();
            this.tabpgeUsuario = new System.Windows.Forms.TabPage();
            this.tab0_tbllytpnldocumentos = new System.Windows.Forms.TableLayoutPanel();
            this.tab0_lstvwdocumentosenlazados = new System.Windows.Forms.ListView();
            this.tab0_lstvwdocumentosescaneados = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab0_lbldocumentosenlazados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab0_lbldocumentosescaneados = new System.Windows.Forms.Label();
            this.tabpgeInterno = new System.Windows.Forms.TabPage();
            this.tab1_tbllytpnldocumentos = new System.Windows.Forms.TableLayoutPanel();
            this.tab1_lstvwdocumentosenlazados = new System.Windows.Forms.ListView();
            this.tab1_lstvwdocumentosescaneados = new System.Windows.Forms.ListView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tab1_lbldocumentosenlazados = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tab1_lbldocumentosescaneados = new System.Windows.Forms.Label();
            this.tabPgeExterno = new System.Windows.Forms.TabPage();
            this.tab2_tbllytpnldocumentos = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tab2_lbldocumentosescaneados = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tab2_lbldocumentosenlazados = new System.Windows.Forms.Label();
            this.tab2_lstvwdocumentosenlazados = new System.Windows.Forms.ListView();
            this.tab2_lstvwdocumentosescaneados = new System.Windows.Forms.ListView();
            this.tabpgeProveedor = new System.Windows.Forms.TabPage();
            this.tab3_tbllytpnldocumentos = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tab3_lbldocumentosescaneados = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tab3_lbldocumentosenlazados = new System.Windows.Forms.Label();
            this.tab3_lstvwdocumentosenlazados = new System.Windows.Forms.ListView();
            this.tab3_lstvwdocumentosescaneados = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tlp_proc = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cntmnuListViewEnlace.SuspendLayout();
            this.cntmnuListViewScann.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_pblbldocumentosescaneados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_pblbldocumentosenlazados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pblbldocumentosescaneados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pblbldocumentosenlazados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab0_pblbldocumentosescaneados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab0_pblbldocumentosenlazados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_pblbldocumentosenlazados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_pblbldocumentosescaneados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Tramites.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KDImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CamposTrazables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCampostrazablesActivosporExpedienteResultBindingSource)).BeginInit();
            this.tbctrl.SuspendLayout();
            this.tabpgeUsuario.SuspendLayout();
            this.tab0_tbllytpnldocumentos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabpgeInterno.SuspendLayout();
            this.tab1_tbllytpnldocumentos.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabPgeExterno.SuspendLayout();
            this.tab2_tbllytpnldocumentos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabpgeProveedor.SuspendLayout();
            this.tab3_tbllytpnldocumentos.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tlp_proc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cntmnuListViewEnlace
            // 
            this.cntmnuListViewEnlace.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cntmnuListViewEnlace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuitemlstvwenlaceabrir,
            this.tsmnuitemlstvwenlaceeliminar,
            this.tsmnuitemlstvwenlaceseparator1,
            this.tsmnuitemlstvwenlacedesenlazar,
            this.toolStripSeparator1,
            this.tsmnuitemlstvwenlacegirarderecha,
            this.tsmnuitemlstvwenlacegirarizquierda});
            this.cntmnuListViewEnlace.Name = "cntmnuListView";
            this.cntmnuListViewEnlace.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cntmnuListViewEnlace.Size = new System.Drawing.Size(212, 146);
            this.cntmnuListViewEnlace.Opening += new System.ComponentModel.CancelEventHandler(this.cntmnuListViewEnlace_Opening);
            // 
            // tsmnuitemlstvwenlaceabrir
            // 
            this.tsmnuitemlstvwenlaceabrir.Image = global::thumbnail.Icons16x16.view;
            this.tsmnuitemlstvwenlaceabrir.Name = "tsmnuitemlstvwenlaceabrir";
            this.tsmnuitemlstvwenlaceabrir.Size = new System.Drawing.Size(211, 26);
            this.tsmnuitemlstvwenlaceabrir.Text = "Abrir";
            this.tsmnuitemlstvwenlaceabrir.Click += new System.EventHandler(this.tsmnuitemlstvwenlaceabrir_Click);
            // 
            // tsmnuitemlstvwenlaceeliminar
            // 
            this.tsmnuitemlstvwenlaceeliminar.Image = global::thumbnail.Icons16x16.trash;
            this.tsmnuitemlstvwenlaceeliminar.Name = "tsmnuitemlstvwenlaceeliminar";
            this.tsmnuitemlstvwenlaceeliminar.Size = new System.Drawing.Size(211, 26);
            this.tsmnuitemlstvwenlaceeliminar.Text = "Eliminar";
            this.tsmnuitemlstvwenlaceeliminar.Visible = false;
            this.tsmnuitemlstvwenlaceeliminar.Click += new System.EventHandler(this.tsmnuitemlstvwenlaceeliminar_Click);
            // 
            // tsmnuitemlstvwenlaceseparator1
            // 
            this.tsmnuitemlstvwenlaceseparator1.Name = "tsmnuitemlstvwenlaceseparator1";
            this.tsmnuitemlstvwenlaceseparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // tsmnuitemlstvwenlacedesenlazar
            // 
            this.tsmnuitemlstvwenlacedesenlazar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuitemlstvwenlacedesenlazarseleccionado,
            this.tsmnuitemlstvwenlacedesenlazartodo});
            this.tsmnuitemlstvwenlacedesenlazar.Image = global::thumbnail.Icons16x16.desenlazar;
            this.tsmnuitemlstvwenlacedesenlazar.Name = "tsmnuitemlstvwenlacedesenlazar";
            this.tsmnuitemlstvwenlacedesenlazar.Size = new System.Drawing.Size(211, 26);
            this.tsmnuitemlstvwenlacedesenlazar.Text = "Desenlazar";
            this.tsmnuitemlstvwenlacedesenlazar.Click += new System.EventHandler(this.tsmnuitemlstvwenlacedesenlazar_Click);
            // 
            // tsmnuitemlstvwenlacedesenlazarseleccionado
            // 
            this.tsmnuitemlstvwenlacedesenlazarseleccionado.Name = "tsmnuitemlstvwenlacedesenlazarseleccionado";
            this.tsmnuitemlstvwenlacedesenlazarseleccionado.Size = new System.Drawing.Size(179, 26);
            this.tsmnuitemlstvwenlacedesenlazarseleccionado.Text = "Seleccionado";
            this.tsmnuitemlstvwenlacedesenlazarseleccionado.Visible = false;
            this.tsmnuitemlstvwenlacedesenlazarseleccionado.Click += new System.EventHandler(this.tsmnuitemlstvwenlacedesenlazar_Click);
            // 
            // tsmnuitemlstvwenlacedesenlazartodo
            // 
            this.tsmnuitemlstvwenlacedesenlazartodo.Name = "tsmnuitemlstvwenlacedesenlazartodo";
            this.tsmnuitemlstvwenlacedesenlazartodo.Size = new System.Drawing.Size(179, 26);
            this.tsmnuitemlstvwenlacedesenlazartodo.Text = "Todo el enlace";
            this.tsmnuitemlstvwenlacedesenlazartodo.Visible = false;
            this.tsmnuitemlstvwenlacedesenlazartodo.Click += new System.EventHandler(this.tsmnuitemlstvwenlacedesenlazartodo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // tsmnuitemlstvwenlacegirarderecha
            // 
            this.tsmnuitemlstvwenlacegirarderecha.Image = ((System.Drawing.Image)(resources.GetObject("tsmnuitemlstvwenlacegirarderecha.Image")));
            this.tsmnuitemlstvwenlacegirarderecha.Name = "tsmnuitemlstvwenlacegirarderecha";
            this.tsmnuitemlstvwenlacegirarderecha.Size = new System.Drawing.Size(211, 26);
            this.tsmnuitemlstvwenlacegirarderecha.Text = "Girar a la derecha";
            this.tsmnuitemlstvwenlacegirarderecha.Click += new System.EventHandler(this.tsmnuitemlstvwenlacegirarderecha_Click);
            // 
            // tsmnuitemlstvwenlacegirarizquierda
            // 
            this.tsmnuitemlstvwenlacegirarizquierda.Image = ((System.Drawing.Image)(resources.GetObject("tsmnuitemlstvwenlacegirarizquierda.Image")));
            this.tsmnuitemlstvwenlacegirarizquierda.Name = "tsmnuitemlstvwenlacegirarizquierda";
            this.tsmnuitemlstvwenlacegirarizquierda.Size = new System.Drawing.Size(211, 26);
            this.tsmnuitemlstvwenlacegirarizquierda.Text = "Girar a la izquierda";
            this.tsmnuitemlstvwenlacegirarizquierda.Click += new System.EventHandler(this.tsmnuitemlstvwenlacegirarizquierda_Click);
            // 
            // cntmnuListViewScann
            // 
            this.cntmnuListViewScann.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cntmnuListViewScann.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuitemlstvwscannabrir,
            this.tsmnuitemlstvwscanneliminar,
            this.tsmnuitemlstvwscannseparator1,
            this.tsmnuitemlstvwscannenlazar,
            this.tsmnuitemlstvwscannseparator2,
            this.tsmnuitemlstvwscannseltodo,
            this.tsmnuitemlstvwscannrotarderecha,
            this.tsmnuitemlstvwscannrotarizquierda});
            this.cntmnuListViewScann.Name = "cntmnuListView";
            this.cntmnuListViewScann.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cntmnuListViewScann.Size = new System.Drawing.Size(286, 172);
            this.cntmnuListViewScann.Opening += new System.ComponentModel.CancelEventHandler(this.cntmnuListViewScann_Opening);
            // 
            // tsmnuitemlstvwscannabrir
            // 
            this.tsmnuitemlstvwscannabrir.Image = global::thumbnail.Icons16x16.view;
            this.tsmnuitemlstvwscannabrir.Name = "tsmnuitemlstvwscannabrir";
            this.tsmnuitemlstvwscannabrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmnuitemlstvwscannabrir.Size = new System.Drawing.Size(285, 26);
            this.tsmnuitemlstvwscannabrir.Text = "Abrir";
            this.tsmnuitemlstvwscannabrir.Click += new System.EventHandler(this.tsmnuitemlstvwscannabrir_Click);
            // 
            // tsmnuitemlstvwscanneliminar
            // 
            this.tsmnuitemlstvwscanneliminar.Image = global::thumbnail.Icons16x16.trash;
            this.tsmnuitemlstvwscanneliminar.Name = "tsmnuitemlstvwscanneliminar";
            this.tsmnuitemlstvwscanneliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsmnuitemlstvwscanneliminar.Size = new System.Drawing.Size(285, 26);
            this.tsmnuitemlstvwscanneliminar.Text = "Eliminar";
            this.tsmnuitemlstvwscanneliminar.Click += new System.EventHandler(this.tsmnuitemlstvwscanneliminar_Click);
            // 
            // tsmnuitemlstvwscannseparator1
            // 
            this.tsmnuitemlstvwscannseparator1.Name = "tsmnuitemlstvwscannseparator1";
            this.tsmnuitemlstvwscannseparator1.Size = new System.Drawing.Size(282, 6);
            // 
            // tsmnuitemlstvwscannenlazar
            // 
            this.tsmnuitemlstvwscannenlazar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuitemlstvwscannenlazarsubmnuseleccionado,
            this.toolStripSeparator2,
            this.tsmnuitemlstvwscannenlazarsubmnutodo,
            this.tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar});
            this.tsmnuitemlstvwscannenlazar.Image = ((System.Drawing.Image)(resources.GetObject("tsmnuitemlstvwscannenlazar.Image")));
            this.tsmnuitemlstvwscannenlazar.Name = "tsmnuitemlstvwscannenlazar";
            this.tsmnuitemlstvwscannenlazar.Size = new System.Drawing.Size(285, 26);
            this.tsmnuitemlstvwscannenlazar.Text = "Enlazar";
            this.tsmnuitemlstvwscannenlazar.Click += new System.EventHandler(this.tsmnuitemlstvwscannenlazar_Click);
            // 
            // tsmnuitemlstvwscannenlazarsubmnuseleccionado
            // 
            this.tsmnuitemlstvwscannenlazarsubmnuseleccionado.Name = "tsmnuitemlstvwscannenlazarsubmnuseleccionado";
            this.tsmnuitemlstvwscannenlazarsubmnuseleccionado.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.tsmnuitemlstvwscannenlazarsubmnuseleccionado.Size = new System.Drawing.Size(256, 26);
            this.tsmnuitemlstvwscannenlazarsubmnuseleccionado.Text = "Seleccionado";
            this.tsmnuitemlstvwscannenlazarsubmnuseleccionado.Click += new System.EventHandler(this.tsmnuitemlstvwscannenlazar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(253, 6);
            // 
            // tsmnuitemlstvwscannenlazarsubmnutodo
            // 
            this.tsmnuitemlstvwscannenlazarsubmnutodo.Name = "tsmnuitemlstvwscannenlazarsubmnutodo";
            this.tsmnuitemlstvwscannenlazarsubmnutodo.Size = new System.Drawing.Size(256, 26);
            this.tsmnuitemlstvwscannenlazarsubmnutodo.Text = "Todo";
            this.tsmnuitemlstvwscannenlazarsubmnutodo.Click += new System.EventHandler(this.tsmnuitemlstvwscannenlazarsubmnutodo_Click);
            // 
            // tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar
            // 
            this.tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar.Name = "tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar";
            this.tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar.Size = new System.Drawing.Size(256, 26);
            this.tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar.Text = "Duplicar y Enlazar";
            this.tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar.Visible = false;
            this.tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar.Click += new System.EventHandler(this.tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar_Click);
            // 
            // tsmnuitemlstvwscannseparator2
            // 
            this.tsmnuitemlstvwscannseparator2.Name = "tsmnuitemlstvwscannseparator2";
            this.tsmnuitemlstvwscannseparator2.Size = new System.Drawing.Size(282, 6);
            // 
            // tsmnuitemlstvwscannseltodo
            // 
            this.tsmnuitemlstvwscannseltodo.Name = "tsmnuitemlstvwscannseltodo";
            this.tsmnuitemlstvwscannseltodo.Size = new System.Drawing.Size(285, 26);
            this.tsmnuitemlstvwscannseltodo.Text = "Seleccionar Todo";
            this.tsmnuitemlstvwscannseltodo.Click += new System.EventHandler(this.tsmnuitemlstvwscannseltodo_Click);
            // 
            // tsmnuitemlstvwscannrotarderecha
            // 
            this.tsmnuitemlstvwscannrotarderecha.Image = ((System.Drawing.Image)(resources.GetObject("tsmnuitemlstvwscannrotarderecha.Image")));
            this.tsmnuitemlstvwscannrotarderecha.Name = "tsmnuitemlstvwscannrotarderecha";
            this.tsmnuitemlstvwscannrotarderecha.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.tsmnuitemlstvwscannrotarderecha.Size = new System.Drawing.Size(285, 26);
            this.tsmnuitemlstvwscannrotarderecha.Text = "Girar a la derecha";
            this.tsmnuitemlstvwscannrotarderecha.Click += new System.EventHandler(this.tsmnuitemlstvwscannrotarderecha_Click);
            // 
            // tsmnuitemlstvwscannrotarizquierda
            // 
            this.tsmnuitemlstvwscannrotarizquierda.Image = ((System.Drawing.Image)(resources.GetObject("tsmnuitemlstvwscannrotarizquierda.Image")));
            this.tsmnuitemlstvwscannrotarizquierda.Name = "tsmnuitemlstvwscannrotarizquierda";
            this.tsmnuitemlstvwscannrotarizquierda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.tsmnuitemlstvwscannrotarizquierda.Size = new System.Drawing.Size(285, 26);
            this.tsmnuitemlstvwscannrotarizquierda.Text = "Girar a la izquierda";
            this.tsmnuitemlstvwscannrotarizquierda.Click += new System.EventHandler(this.tsmnuitemlstvwscannrotarizquierda_Click);
            // 
            // imglsttabs
            // 
            this.imglsttabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglsttabs.ImageStream")));
            this.imglsttabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imglsttabs.Images.SetKeyName(0, "users.png");
            this.imglsttabs.Images.SetKeyName(1, "interno.png");
            this.imglsttabs.Images.SetKeyName(2, "externo.png");
            this.imglsttabs.Images.SetKeyName(3, "proveedor.png");
            // 
            // btn_limpiarcontroles
            // 
            this.btn_limpiarcontroles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiarcontroles.AutoSize = true;
            this.btn_limpiarcontroles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiarcontroles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_limpiarcontroles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarcontroles.FlatAppearance.BorderSize = 0;
            this.btn_limpiarcontroles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_limpiarcontroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarcontroles.Image = global::thumbnail.Icons48x48.clear_get;
            this.btn_limpiarcontroles.Location = new System.Drawing.Point(946, 275);
            this.btn_limpiarcontroles.Name = "btn_limpiarcontroles";
            this.btn_limpiarcontroles.Size = new System.Drawing.Size(54, 54);
            this.btn_limpiarcontroles.TabIndex = 5;
            this.tooltipBtnMnuOptions.SetToolTip(this.btn_limpiarcontroles, "Limpiar documentos");
            this.btn_limpiarcontroles.UseVisualStyleBackColor = false;
            this.btn_limpiarcontroles.Click += new System.EventHandler(this.btn_limpiarcontroles_Click);
            // 
            // btn_abririmagen
            // 
            this.btn_abririmagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_abririmagen.AutoSize = true;
            this.btn_abririmagen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_abririmagen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_abririmagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_abririmagen.FlatAppearance.BorderSize = 0;
            this.btn_abririmagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_abririmagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abririmagen.Image = global::thumbnail.Icons48x48.folder_open;
            this.btn_abririmagen.Location = new System.Drawing.Point(815, 275);
            this.btn_abririmagen.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btn_abririmagen.Name = "btn_abririmagen";
            this.btn_abririmagen.Size = new System.Drawing.Size(54, 54);
            this.btn_abririmagen.TabIndex = 4;
            this.tooltipBtnMnuOptions.SetToolTip(this.btn_abririmagen, "Obtener de archivo");
            this.btn_abririmagen.UseVisualStyleBackColor = false;
            this.btn_abririmagen.Click += new System.EventHandler(this.btn_abririmagen_Click);
            // 
            // btn_scanear
            // 
            this.btn_scanear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scanear.AutoSize = true;
            this.btn_scanear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_scanear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_scanear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_scanear.FlatAppearance.BorderSize = 0;
            this.btn_scanear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_scanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scanear.Image = global::thumbnail.Icons48x48.get;
            this.btn_scanear.Location = new System.Drawing.Point(743, 275);
            this.btn_scanear.Name = "btn_scanear";
            this.btn_scanear.Size = new System.Drawing.Size(54, 54);
            this.btn_scanear.TabIndex = 3;
            this.tooltipBtnMnuOptions.SetToolTip(this.btn_scanear, "Obtener de escaner");
            this.btn_scanear.UseVisualStyleBackColor = false;
            this.btn_scanear.Click += new System.EventHandler(this.btn_scanear_Click);
            // 
            // tab2_pblbldocumentosescaneados
            // 
            this.tab2_pblbldocumentosescaneados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab2_pblbldocumentosescaneados.Image = ((System.Drawing.Image)(resources.GetObject("tab2_pblbldocumentosescaneados.Image")));
            this.tab2_pblbldocumentosescaneados.Location = new System.Drawing.Point(0, 0);
            this.tab2_pblbldocumentosescaneados.Margin = new System.Windows.Forms.Padding(0);
            this.tab2_pblbldocumentosescaneados.Name = "tab2_pblbldocumentosescaneados";
            this.tab2_pblbldocumentosescaneados.Size = new System.Drawing.Size(21, 24);
            this.tab2_pblbldocumentosescaneados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab2_pblbldocumentosescaneados.TabIndex = 10;
            this.tab2_pblbldocumentosescaneados.TabStop = false;
            this.tooltipBtnMnuOptions.SetToolTip(this.tab2_pblbldocumentosescaneados, "Escanear documentos");
            // 
            // tab2_pblbldocumentosenlazados
            // 
            this.tab2_pblbldocumentosenlazados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab2_pblbldocumentosenlazados.Image = ((System.Drawing.Image)(resources.GetObject("tab2_pblbldocumentosenlazados.Image")));
            this.tab2_pblbldocumentosenlazados.Location = new System.Drawing.Point(5, 0);
            this.tab2_pblbldocumentosenlazados.Margin = new System.Windows.Forms.Padding(0);
            this.tab2_pblbldocumentosenlazados.Name = "tab2_pblbldocumentosenlazados";
            this.tab2_pblbldocumentosenlazados.Size = new System.Drawing.Size(23, 24);
            this.tab2_pblbldocumentosenlazados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab2_pblbldocumentosenlazados.TabIndex = 10;
            this.tab2_pblbldocumentosenlazados.TabStop = false;
            this.tooltipBtnMnuOptions.SetToolTip(this.tab2_pblbldocumentosenlazados, "Escanear documentos");
            // 
            // tab3_pblbldocumentosescaneados
            // 
            this.tab3_pblbldocumentosescaneados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab3_pblbldocumentosescaneados.Image = ((System.Drawing.Image)(resources.GetObject("tab3_pblbldocumentosescaneados.Image")));
            this.tab3_pblbldocumentosescaneados.Location = new System.Drawing.Point(0, 0);
            this.tab3_pblbldocumentosescaneados.Margin = new System.Windows.Forms.Padding(0);
            this.tab3_pblbldocumentosescaneados.Name = "tab3_pblbldocumentosescaneados";
            this.tab3_pblbldocumentosescaneados.Size = new System.Drawing.Size(21, 24);
            this.tab3_pblbldocumentosescaneados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab3_pblbldocumentosescaneados.TabIndex = 10;
            this.tab3_pblbldocumentosescaneados.TabStop = false;
            this.tooltipBtnMnuOptions.SetToolTip(this.tab3_pblbldocumentosescaneados, "Escanear documentos");
            // 
            // tab3_pblbldocumentosenlazados
            // 
            this.tab3_pblbldocumentosenlazados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab3_pblbldocumentosenlazados.Image = ((System.Drawing.Image)(resources.GetObject("tab3_pblbldocumentosenlazados.Image")));
            this.tab3_pblbldocumentosenlazados.Location = new System.Drawing.Point(5, 0);
            this.tab3_pblbldocumentosenlazados.Margin = new System.Windows.Forms.Padding(0);
            this.tab3_pblbldocumentosenlazados.Name = "tab3_pblbldocumentosenlazados";
            this.tab3_pblbldocumentosenlazados.Size = new System.Drawing.Size(23, 24);
            this.tab3_pblbldocumentosenlazados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab3_pblbldocumentosenlazados.TabIndex = 10;
            this.tab3_pblbldocumentosenlazados.TabStop = false;
            this.tooltipBtnMnuOptions.SetToolTip(this.tab3_pblbldocumentosenlazados, "Escanear documentos");
            // 
            // btn_config_scann
            // 
            this.btn_config_scann.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_config_scann.AutoSize = true;
            this.btn_config_scann.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_config_scann.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_config_scann.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config_scann.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_config_scann.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config_scann.Image = global::thumbnail.Icons16x16.scanner;
            this.btn_config_scann.Location = new System.Drawing.Point(713, 275);
            this.btn_config_scann.Name = "btn_config_scann";
            this.btn_config_scann.Size = new System.Drawing.Size(24, 24);
            this.btn_config_scann.TabIndex = 8;
            this.tooltipBtnMnuOptions.SetToolTip(this.btn_config_scann, "Seleccionar scanner");
            this.btn_config_scann.UseVisualStyleBackColor = false;
            this.btn_config_scann.Click += new System.EventHandler(this.btn_config_scann_Click);
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
            this.btn_cerrar.Location = new System.Drawing.Point(946, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(54, 54);
            this.btn_cerrar.TabIndex = 9;
            this.tooltipBtnMnuOptions.SetToolTip(this.btn_cerrar, "Cerrar sistema");
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.AutoSize = true;
            this.btn_limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_limpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Image = global::thumbnail.Icons48x48.clear;
            this.btn_limpiar.Location = new System.Drawing.Point(874, 3);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(54, 54);
            this.btn_limpiar.TabIndex = 7;
            this.tooltipBtnMnuOptions.SetToolTip(this.btn_limpiar, "Limpiar formato");
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Image = global::thumbnail.Icons48x48.save;
            this.btn_guardar.Location = new System.Drawing.Point(802, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 54);
            this.btn_guardar.TabIndex = 6;
            this.tooltipBtnMnuOptions.SetToolTip(this.btn_guardar, "Guardar tramite");
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // tab0_pblbldocumentosescaneados
            // 
            this.tab0_pblbldocumentosescaneados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab0_pblbldocumentosescaneados.Image = ((System.Drawing.Image)(resources.GetObject("tab0_pblbldocumentosescaneados.Image")));
            this.tab0_pblbldocumentosescaneados.Location = new System.Drawing.Point(0, 0);
            this.tab0_pblbldocumentosescaneados.Margin = new System.Windows.Forms.Padding(0);
            this.tab0_pblbldocumentosescaneados.Name = "tab0_pblbldocumentosescaneados";
            this.tab0_pblbldocumentosescaneados.Size = new System.Drawing.Size(21, 24);
            this.tab0_pblbldocumentosescaneados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab0_pblbldocumentosescaneados.TabIndex = 16;
            this.tab0_pblbldocumentosescaneados.TabStop = false;
            this.tooltipBtnMnuOptions.SetToolTip(this.tab0_pblbldocumentosescaneados, "Escanear documentos");
            // 
            // tab0_pblbldocumentosenlazados
            // 
            this.tab0_pblbldocumentosenlazados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab0_pblbldocumentosenlazados.Image = ((System.Drawing.Image)(resources.GetObject("tab0_pblbldocumentosenlazados.Image")));
            this.tab0_pblbldocumentosenlazados.Location = new System.Drawing.Point(5, 0);
            this.tab0_pblbldocumentosenlazados.Margin = new System.Windows.Forms.Padding(0);
            this.tab0_pblbldocumentosenlazados.Name = "tab0_pblbldocumentosenlazados";
            this.tab0_pblbldocumentosenlazados.Size = new System.Drawing.Size(23, 24);
            this.tab0_pblbldocumentosenlazados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab0_pblbldocumentosenlazados.TabIndex = 19;
            this.tab0_pblbldocumentosenlazados.TabStop = false;
            this.tooltipBtnMnuOptions.SetToolTip(this.tab0_pblbldocumentosenlazados, "Escanear documentos");
            // 
            // tab1_pblbldocumentosenlazados
            // 
            this.tab1_pblbldocumentosenlazados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab1_pblbldocumentosenlazados.Image = ((System.Drawing.Image)(resources.GetObject("tab1_pblbldocumentosenlazados.Image")));
            this.tab1_pblbldocumentosenlazados.Location = new System.Drawing.Point(5, 0);
            this.tab1_pblbldocumentosenlazados.Margin = new System.Windows.Forms.Padding(0);
            this.tab1_pblbldocumentosenlazados.Name = "tab1_pblbldocumentosenlazados";
            this.tab1_pblbldocumentosenlazados.Size = new System.Drawing.Size(23, 24);
            this.tab1_pblbldocumentosenlazados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab1_pblbldocumentosenlazados.TabIndex = 19;
            this.tab1_pblbldocumentosenlazados.TabStop = false;
            this.tooltipBtnMnuOptions.SetToolTip(this.tab1_pblbldocumentosenlazados, "Escanear documentos");
            // 
            // tab1_pblbldocumentosescaneados
            // 
            this.tab1_pblbldocumentosescaneados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tab1_pblbldocumentosescaneados.Image = ((System.Drawing.Image)(resources.GetObject("tab1_pblbldocumentosescaneados.Image")));
            this.tab1_pblbldocumentosescaneados.Location = new System.Drawing.Point(0, 0);
            this.tab1_pblbldocumentosescaneados.Margin = new System.Windows.Forms.Padding(0);
            this.tab1_pblbldocumentosescaneados.Name = "tab1_pblbldocumentosescaneados";
            this.tab1_pblbldocumentosescaneados.Size = new System.Drawing.Size(21, 24);
            this.tab1_pblbldocumentosescaneados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tab1_pblbldocumentosescaneados.TabIndex = 16;
            this.tab1_pblbldocumentosescaneados.TabStop = false;
            this.tooltipBtnMnuOptions.SetToolTip(this.tab1_pblbldocumentosescaneados, "Escanear documentos");
            // 
            // ofdabrirarchivo
            // 
            this.ofdabrirarchivo.Filter = resources.GetString("ofdabrirarchivo.Filter");
            this.ofdabrirarchivo.FilterIndex = 6;
            this.ofdabrirarchivo.Multiselect = true;
            this.ofdabrirarchivo.SupportMultiDottedExtensions = true;
            this.ofdabrirarchivo.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdabrirarchivo_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Trámite";
            // 
            // lookUpEdit_Tramites
            // 
            this.lookUpEdit_Tramites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEdit_Tramites.Location = new System.Drawing.Point(12, 33);
            this.lookUpEdit_Tramites.Name = "lookUpEdit_Tramites";
            this.lookUpEdit_Tramites.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_Tramites.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_Tramites.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lookUpEdit_Tramites.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEdit_Tramites.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit_Tramites.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookUpEdit_Tramites.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpEdit_Tramites.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpEdit_Tramites.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Tramites.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_tramite", "id_tramite", 110, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_tramite", "Trámite", 168, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_clasificaciontramite", "id_clasificaciontramite", 227, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion_clasificaciontramite", "Clasificación del trámite", 320, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_expediente", "id_expediente", 158, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion_Expediente", "Expediente", 239, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit_Tramites.Properties.ImmediatePopup = true;
            this.lookUpEdit_Tramites.Properties.LookAndFeel.SkinName = "VS2010";
            this.lookUpEdit_Tramites.Properties.NullText = "";
            this.lookUpEdit_Tramites.Size = new System.Drawing.Size(490, 30);
            this.lookUpEdit_Tramites.TabIndex = 0;
            this.lookUpEdit_Tramites.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lookUpEdit_Tramites_QueryPopUp);
            this.lookUpEdit_Tramites.EditValueChanged += new System.EventHandler(this.lookUpEdit_Tramites_EditValueChanged);
            this.lookUpEdit_Tramites.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.lookUpEdit_Tramites_EditValueChanging);
            // 
            // KDImage
            // 
            this.KDImage.Enabled = true;
            this.KDImage.Location = new System.Drawing.Point(280, 5);
            this.KDImage.Name = "KDImage";
            this.KDImage.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("KDImage.OcxState")));
            this.KDImage.Size = new System.Drawing.Size(75, 23);
            this.KDImage.TabIndex = 43;
            this.KDImage.Visible = false;
            this.KDImage.OnScannerPageAcquired += new AxKDImageEditor.IKDImageEvents_OnScannerPageAcquiredEventHandler(this.KDImage_OnScannerPageAcquired);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1008, 730);
            this.shapeContainer1.TabIndex = 51;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -3;
            this.lineShape2.X2 = 660;
            this.lineShape2.Y1 = 280;
            this.lineShape2.Y2 = 280;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 761;
            this.lineShape1.X2 = 1009;
            this.lineShape1.Y1 = 60;
            this.lineShape1.Y2 = 60;
            // 
            // dataGridView_CamposTrazables
            // 
            this.dataGridView_CamposTrazables.AllowUserToAddRows = false;
            this.dataGridView_CamposTrazables.AllowUserToDeleteRows = false;
            this.dataGridView_CamposTrazables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_CamposTrazables.AutoGenerateColumns = false;
            this.dataGridView_CamposTrazables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CamposTrazables.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_CamposTrazables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CamposTrazables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_CamposTrazables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcampotrazableDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.tamanioCaracteresDataGridViewTextBoxColumn,
            this.idestatusDataGridViewTextBoxColumn,
            this.mascaraDataGridViewTextBoxColumn,
            this.esprincipalDataGridViewCheckBoxColumn,
            this.col_valor_trazable,
            this.id_re_expedientes_campostrazables});
            this.dataGridView_CamposTrazables.DataSource = this.paCampostrazablesActivosporExpedienteResultBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_CamposTrazables.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_CamposTrazables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_CamposTrazables.EnableHeadersVisualStyles = false;
            this.dataGridView_CamposTrazables.Location = new System.Drawing.Point(12, 101);
            this.dataGridView_CamposTrazables.MultiSelect = false;
            this.dataGridView_CamposTrazables.Name = "dataGridView_CamposTrazables";
            this.dataGridView_CamposTrazables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CamposTrazables.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_CamposTrazables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_CamposTrazables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_CamposTrazables.Size = new System.Drawing.Size(988, 164);
            this.dataGridView_CamposTrazables.TabIndex = 1;
            this.dataGridView_CamposTrazables.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CamposTrazables_CellValidating);
            this.dataGridView_CamposTrazables.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CamposTrazables_RowEnter);
            // 
            // idcampotrazableDataGridViewTextBoxColumn
            // 
            this.idcampotrazableDataGridViewTextBoxColumn.DataPropertyName = "id_campotrazable";
            this.idcampotrazableDataGridViewTextBoxColumn.HeaderText = "id_campotrazable";
            this.idcampotrazableDataGridViewTextBoxColumn.Name = "idcampotrazableDataGridViewTextBoxColumn";
            this.idcampotrazableDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Campo";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamanioCaracteresDataGridViewTextBoxColumn
            // 
            this.tamanioCaracteresDataGridViewTextBoxColumn.DataPropertyName = "Tamanio_Caracteres";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tamanioCaracteresDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tamanioCaracteresDataGridViewTextBoxColumn.HeaderText = "Tamaño de caracteres";
            this.tamanioCaracteresDataGridViewTextBoxColumn.Name = "tamanioCaracteresDataGridViewTextBoxColumn";
            this.tamanioCaracteresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idestatusDataGridViewTextBoxColumn
            // 
            this.idestatusDataGridViewTextBoxColumn.DataPropertyName = "id_estatus";
            this.idestatusDataGridViewTextBoxColumn.HeaderText = "id_estatus";
            this.idestatusDataGridViewTextBoxColumn.Name = "idestatusDataGridViewTextBoxColumn";
            this.idestatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // mascaraDataGridViewTextBoxColumn
            // 
            this.mascaraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mascaraDataGridViewTextBoxColumn.DataPropertyName = "Mascara";
            this.mascaraDataGridViewTextBoxColumn.HeaderText = "Mascara";
            this.mascaraDataGridViewTextBoxColumn.Name = "mascaraDataGridViewTextBoxColumn";
            this.mascaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // esprincipalDataGridViewCheckBoxColumn
            // 
            this.esprincipalDataGridViewCheckBoxColumn.DataPropertyName = "es_principal";
            this.esprincipalDataGridViewCheckBoxColumn.HeaderText = "Es principal";
            this.esprincipalDataGridViewCheckBoxColumn.Name = "esprincipalDataGridViewCheckBoxColumn";
            this.esprincipalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // col_valor_trazable
            // 
            this.col_valor_trazable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_valor_trazable.HeaderText = "Valor Trazable";
            this.col_valor_trazable.Name = "col_valor_trazable";
            this.col_valor_trazable.ToolTipText = "Introdúzca el valor de la trazabilidad";
            // 
            // id_re_expedientes_campostrazables
            // 
            this.id_re_expedientes_campostrazables.DataPropertyName = "id_re_expedientes_campostrazables";
            this.id_re_expedientes_campostrazables.HeaderText = "id_re_expedientes_campostrazables";
            this.id_re_expedientes_campostrazables.Name = "id_re_expedientes_campostrazables";
            this.id_re_expedientes_campostrazables.ReadOnly = true;
            this.id_re_expedientes_campostrazables.Visible = false;
            // 
            // paCampostrazablesActivosporExpedienteResultBindingSource
            // 
            this.paCampostrazablesActivosporExpedienteResultBindingSource.DataSource = typeof(thumbnail.data_members.pa_CampostrazablesActivosporExpedienteResult);
            // 
            // tbctrl
            // 
            this.tbctrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrl.Controls.Add(this.tabpgeUsuario);
            this.tbctrl.Controls.Add(this.tabpgeInterno);
            this.tbctrl.Controls.Add(this.tabPgeExterno);
            this.tbctrl.Controls.Add(this.tabpgeProveedor);
            this.tbctrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbctrl.ImageList = this.imglsttabs;
            this.tbctrl.Location = new System.Drawing.Point(12, 293);
            this.tbctrl.Multiline = true;
            this.tbctrl.Name = "tbctrl";
            this.tbctrl.SelectedIndex = 0;
            this.tbctrl.Size = new System.Drawing.Size(988, 434);
            this.tbctrl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbctrl.TabIndex = 2;
            this.tbctrl.Tag = "";
            this.tbctrl.SelectedIndexChanged += new System.EventHandler(this.tbctrl_SelectedIndexChanged);
            // 
            // tabpgeUsuario
            // 
            this.tabpgeUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabpgeUsuario.Controls.Add(this.tab0_tbllytpnldocumentos);
            this.tabpgeUsuario.ImageIndex = 0;
            this.tabpgeUsuario.Location = new System.Drawing.Point(4, 39);
            this.tabpgeUsuario.Name = "tabpgeUsuario";
            this.tabpgeUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgeUsuario.Size = new System.Drawing.Size(980, 391);
            this.tabpgeUsuario.TabIndex = 0;
            this.tabpgeUsuario.Tag = "Documentos de usuario";
            this.tabpgeUsuario.Text = "Usuario";
            // 
            // tab0_tbllytpnldocumentos
            // 
            this.tab0_tbllytpnldocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab0_tbllytpnldocumentos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab0_tbllytpnldocumentos.ColumnCount = 2;
            this.tab0_tbllytpnldocumentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab0_tbllytpnldocumentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab0_tbllytpnldocumentos.Controls.Add(this.tab0_lstvwdocumentosenlazados, 1, 1);
            this.tab0_tbllytpnldocumentos.Controls.Add(this.tab0_lstvwdocumentosescaneados, 0, 1);
            this.tab0_tbllytpnldocumentos.Controls.Add(this.panel2, 1, 0);
            this.tab0_tbllytpnldocumentos.Controls.Add(this.panel1, 0, 0);
            this.tab0_tbllytpnldocumentos.Location = new System.Drawing.Point(6, 6);
            this.tab0_tbllytpnldocumentos.Name = "tab0_tbllytpnldocumentos";
            this.tab0_tbllytpnldocumentos.RowCount = 2;
            this.tab0_tbllytpnldocumentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tab0_tbllytpnldocumentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tab0_tbllytpnldocumentos.Size = new System.Drawing.Size(967, 382);
            this.tab0_tbllytpnldocumentos.TabIndex = 19;
            // 
            // tab0_lstvwdocumentosenlazados
            // 
            this.tab0_lstvwdocumentosenlazados.AllowDrop = true;
            this.tab0_lstvwdocumentosenlazados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab0_lstvwdocumentosenlazados.BackgroundImageTiled = true;
            this.tab0_lstvwdocumentosenlazados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab0_lstvwdocumentosenlazados.ContextMenuStrip = this.cntmnuListViewEnlace;
            this.tab0_lstvwdocumentosenlazados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab0_lstvwdocumentosenlazados.Location = new System.Drawing.Point(486, 25);
            this.tab0_lstvwdocumentosenlazados.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tab0_lstvwdocumentosenlazados.Name = "tab0_lstvwdocumentosenlazados";
            this.tab0_lstvwdocumentosenlazados.Size = new System.Drawing.Size(481, 357);
            this.tab0_lstvwdocumentosenlazados.TabIndex = 1;
            this.tab0_lstvwdocumentosenlazados.Tag = "0";
            this.tab0_lstvwdocumentosenlazados.UseCompatibleStateImageBehavior = false;
            this.tab0_lstvwdocumentosenlazados.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstvwdocumentosenlazados_ItemDrag);
            this.tab0_lstvwdocumentosenlazados.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosenlazados_DragDrop);
            this.tab0_lstvwdocumentosenlazados.DragOver += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosenlazados_DragOver);
            // 
            // tab0_lstvwdocumentosescaneados
            // 
            this.tab0_lstvwdocumentosescaneados.AllowDrop = true;
            this.tab0_lstvwdocumentosescaneados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab0_lstvwdocumentosescaneados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab0_lstvwdocumentosescaneados.ContextMenuStrip = this.cntmnuListViewScann;
            this.tab0_lstvwdocumentosescaneados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab0_lstvwdocumentosescaneados.Location = new System.Drawing.Point(0, 25);
            this.tab0_lstvwdocumentosescaneados.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tab0_lstvwdocumentosescaneados.Name = "tab0_lstvwdocumentosescaneados";
            this.tab0_lstvwdocumentosescaneados.Size = new System.Drawing.Size(480, 357);
            this.tab0_lstvwdocumentosescaneados.TabIndex = 0;
            this.tab0_lstvwdocumentosescaneados.Tag = "0";
            this.tab0_lstvwdocumentosescaneados.UseCompatibleStateImageBehavior = false;
            this.tab0_lstvwdocumentosescaneados.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstvwdocumentosescaneados_ItemDrag);
            this.tab0_lstvwdocumentosescaneados.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosescaneados_DragDrop);
            this.tab0_lstvwdocumentosescaneados.DragOver += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosescaneados_DragOver);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tab0_pblbldocumentosenlazados);
            this.panel2.Controls.Add(this.tab0_lbldocumentosenlazados);
            this.panel2.Location = new System.Drawing.Point(483, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 25);
            this.panel2.TabIndex = 1;
            // 
            // tab0_lbldocumentosenlazados
            // 
            this.tab0_lbldocumentosenlazados.AutoSize = true;
            this.tab0_lbldocumentosenlazados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab0_lbldocumentosenlazados.Location = new System.Drawing.Point(27, 7);
            this.tab0_lbldocumentosenlazados.Margin = new System.Windows.Forms.Padding(0);
            this.tab0_lbldocumentosenlazados.Name = "tab0_lbldocumentosenlazados";
            this.tab0_lbldocumentosenlazados.Size = new System.Drawing.Size(179, 20);
            this.tab0_lbldocumentosenlazados.TabIndex = 18;
            this.tab0_lbldocumentosenlazados.Text = "Documentos Enlazados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tab0_pblbldocumentosescaneados);
            this.panel1.Controls.Add(this.tab0_lbldocumentosescaneados);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 25);
            this.panel1.TabIndex = 0;
            // 
            // tab0_lbldocumentosescaneados
            // 
            this.tab0_lbldocumentosescaneados.AutoSize = true;
            this.tab0_lbldocumentosescaneados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab0_lbldocumentosescaneados.Location = new System.Drawing.Point(20, 7);
            this.tab0_lbldocumentosescaneados.Margin = new System.Windows.Forms.Padding(0);
            this.tab0_lbldocumentosescaneados.Name = "tab0_lbldocumentosescaneados";
            this.tab0_lbldocumentosescaneados.Size = new System.Drawing.Size(193, 20);
            this.tab0_lbldocumentosescaneados.TabIndex = 15;
            this.tab0_lbldocumentosescaneados.Text = "Documentos Escaneados";
            // 
            // tabpgeInterno
            // 
            this.tabpgeInterno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabpgeInterno.Controls.Add(this.tab1_tbllytpnldocumentos);
            this.tabpgeInterno.ImageIndex = 1;
            this.tabpgeInterno.Location = new System.Drawing.Point(4, 39);
            this.tabpgeInterno.Name = "tabpgeInterno";
            this.tabpgeInterno.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgeInterno.Size = new System.Drawing.Size(980, 391);
            this.tabpgeInterno.TabIndex = 1;
            this.tabpgeInterno.Tag = "Documentos internos";
            this.tabpgeInterno.Text = "Interno";
            // 
            // tab1_tbllytpnldocumentos
            // 
            this.tab1_tbllytpnldocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1_tbllytpnldocumentos.ColumnCount = 2;
            this.tab1_tbllytpnldocumentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab1_tbllytpnldocumentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab1_tbllytpnldocumentos.Controls.Add(this.tab1_lstvwdocumentosenlazados, 1, 1);
            this.tab1_tbllytpnldocumentos.Controls.Add(this.tab1_lstvwdocumentosescaneados, 0, 1);
            this.tab1_tbllytpnldocumentos.Controls.Add(this.panel7, 1, 0);
            this.tab1_tbllytpnldocumentos.Controls.Add(this.panel8, 0, 0);
            this.tab1_tbllytpnldocumentos.Location = new System.Drawing.Point(6, 6);
            this.tab1_tbllytpnldocumentos.Name = "tab1_tbllytpnldocumentos";
            this.tab1_tbllytpnldocumentos.RowCount = 2;
            this.tab1_tbllytpnldocumentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tab1_tbllytpnldocumentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tab1_tbllytpnldocumentos.Size = new System.Drawing.Size(967, 382);
            this.tab1_tbllytpnldocumentos.TabIndex = 21;
            // 
            // tab1_lstvwdocumentosenlazados
            // 
            this.tab1_lstvwdocumentosenlazados.AllowDrop = true;
            this.tab1_lstvwdocumentosenlazados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab1_lstvwdocumentosenlazados.BackgroundImageTiled = true;
            this.tab1_lstvwdocumentosenlazados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab1_lstvwdocumentosenlazados.ContextMenuStrip = this.cntmnuListViewEnlace;
            this.tab1_lstvwdocumentosenlazados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1_lstvwdocumentosenlazados.Location = new System.Drawing.Point(486, 25);
            this.tab1_lstvwdocumentosenlazados.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tab1_lstvwdocumentosenlazados.Name = "tab1_lstvwdocumentosenlazados";
            this.tab1_lstvwdocumentosenlazados.Size = new System.Drawing.Size(481, 357);
            this.tab1_lstvwdocumentosenlazados.TabIndex = 19;
            this.tab1_lstvwdocumentosenlazados.Tag = "0";
            this.tab1_lstvwdocumentosenlazados.UseCompatibleStateImageBehavior = false;
            this.tab1_lstvwdocumentosenlazados.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstvwdocumentosenlazados_ItemDrag);
            this.tab1_lstvwdocumentosenlazados.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosenlazados_DragDrop);
            this.tab1_lstvwdocumentosenlazados.DragOver += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosenlazados_DragOver);
            // 
            // tab1_lstvwdocumentosescaneados
            // 
            this.tab1_lstvwdocumentosescaneados.AllowDrop = true;
            this.tab1_lstvwdocumentosescaneados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab1_lstvwdocumentosescaneados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab1_lstvwdocumentosescaneados.ContextMenuStrip = this.cntmnuListViewScann;
            this.tab1_lstvwdocumentosescaneados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1_lstvwdocumentosescaneados.Location = new System.Drawing.Point(0, 25);
            this.tab1_lstvwdocumentosescaneados.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tab1_lstvwdocumentosescaneados.Name = "tab1_lstvwdocumentosescaneados";
            this.tab1_lstvwdocumentosescaneados.Size = new System.Drawing.Size(480, 357);
            this.tab1_lstvwdocumentosescaneados.TabIndex = 16;
            this.tab1_lstvwdocumentosescaneados.Tag = "0";
            this.tab1_lstvwdocumentosescaneados.UseCompatibleStateImageBehavior = false;
            this.tab1_lstvwdocumentosescaneados.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstvwdocumentosescaneados_ItemDrag);
            this.tab1_lstvwdocumentosescaneados.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosescaneados_DragDrop);
            this.tab1_lstvwdocumentosescaneados.DragOver += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosescaneados_DragOver);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tab1_pblbldocumentosenlazados);
            this.panel7.Controls.Add(this.tab1_lbldocumentosenlazados);
            this.panel7.Location = new System.Drawing.Point(483, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(209, 25);
            this.panel7.TabIndex = 1;
            // 
            // tab1_lbldocumentosenlazados
            // 
            this.tab1_lbldocumentosenlazados.AutoSize = true;
            this.tab1_lbldocumentosenlazados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1_lbldocumentosenlazados.Location = new System.Drawing.Point(27, 7);
            this.tab1_lbldocumentosenlazados.Margin = new System.Windows.Forms.Padding(0);
            this.tab1_lbldocumentosenlazados.Name = "tab1_lbldocumentosenlazados";
            this.tab1_lbldocumentosenlazados.Size = new System.Drawing.Size(179, 20);
            this.tab1_lbldocumentosenlazados.TabIndex = 18;
            this.tab1_lbldocumentosenlazados.Text = "Documentos Enlazados";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tab1_pblbldocumentosescaneados);
            this.panel8.Controls.Add(this.tab1_lbldocumentosescaneados);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(219, 25);
            this.panel8.TabIndex = 0;
            // 
            // tab1_lbldocumentosescaneados
            // 
            this.tab1_lbldocumentosescaneados.AutoSize = true;
            this.tab1_lbldocumentosescaneados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1_lbldocumentosescaneados.Location = new System.Drawing.Point(20, 7);
            this.tab1_lbldocumentosescaneados.Margin = new System.Windows.Forms.Padding(0);
            this.tab1_lbldocumentosescaneados.Name = "tab1_lbldocumentosescaneados";
            this.tab1_lbldocumentosescaneados.Size = new System.Drawing.Size(193, 20);
            this.tab1_lbldocumentosescaneados.TabIndex = 15;
            this.tab1_lbldocumentosescaneados.Text = "Documentos Escaneados";
            // 
            // tabPgeExterno
            // 
            this.tabPgeExterno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPgeExterno.Controls.Add(this.tab2_tbllytpnldocumentos);
            this.tabPgeExterno.ImageIndex = 2;
            this.tabPgeExterno.Location = new System.Drawing.Point(4, 39);
            this.tabPgeExterno.Name = "tabPgeExterno";
            this.tabPgeExterno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgeExterno.Size = new System.Drawing.Size(980, 391);
            this.tabPgeExterno.TabIndex = 2;
            this.tabPgeExterno.Tag = "Documentos externos";
            this.tabPgeExterno.Text = "Externo";
            // 
            // tab2_tbllytpnldocumentos
            // 
            this.tab2_tbllytpnldocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2_tbllytpnldocumentos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab2_tbllytpnldocumentos.ColumnCount = 2;
            this.tab2_tbllytpnldocumentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab2_tbllytpnldocumentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab2_tbllytpnldocumentos.Controls.Add(this.panel3, 0, 0);
            this.tab2_tbllytpnldocumentos.Controls.Add(this.panel4, 1, 0);
            this.tab2_tbllytpnldocumentos.Controls.Add(this.tab2_lstvwdocumentosenlazados, 1, 1);
            this.tab2_tbllytpnldocumentos.Controls.Add(this.tab2_lstvwdocumentosescaneados, 0, 1);
            this.tab2_tbllytpnldocumentos.Location = new System.Drawing.Point(6, 6);
            this.tab2_tbllytpnldocumentos.Margin = new System.Windows.Forms.Padding(5);
            this.tab2_tbllytpnldocumentos.Name = "tab2_tbllytpnldocumentos";
            this.tab2_tbllytpnldocumentos.RowCount = 2;
            this.tab2_tbllytpnldocumentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tab2_tbllytpnldocumentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tab2_tbllytpnldocumentos.Size = new System.Drawing.Size(967, 382);
            this.tab2_tbllytpnldocumentos.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tab2_pblbldocumentosescaneados);
            this.panel3.Controls.Add(this.tab2_lbldocumentosescaneados);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 25);
            this.panel3.TabIndex = 6;
            // 
            // tab2_lbldocumentosescaneados
            // 
            this.tab2_lbldocumentosescaneados.AutoSize = true;
            this.tab2_lbldocumentosescaneados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2_lbldocumentosescaneados.Location = new System.Drawing.Point(20, 7);
            this.tab2_lbldocumentosescaneados.Margin = new System.Windows.Forms.Padding(0);
            this.tab2_lbldocumentosescaneados.Name = "tab2_lbldocumentosescaneados";
            this.tab2_lbldocumentosescaneados.Size = new System.Drawing.Size(193, 20);
            this.tab2_lbldocumentosescaneados.TabIndex = 6;
            this.tab2_lbldocumentosescaneados.Text = "Documentos Escaneados";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tab2_pblbldocumentosenlazados);
            this.panel4.Controls.Add(this.tab2_lbldocumentosenlazados);
            this.panel4.Location = new System.Drawing.Point(483, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 25);
            this.panel4.TabIndex = 0;
            // 
            // tab2_lbldocumentosenlazados
            // 
            this.tab2_lbldocumentosenlazados.AutoSize = true;
            this.tab2_lbldocumentosenlazados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2_lbldocumentosenlazados.Location = new System.Drawing.Point(27, 7);
            this.tab2_lbldocumentosenlazados.Margin = new System.Windows.Forms.Padding(0);
            this.tab2_lbldocumentosenlazados.Name = "tab2_lbldocumentosenlazados";
            this.tab2_lbldocumentosenlazados.Size = new System.Drawing.Size(179, 20);
            this.tab2_lbldocumentosenlazados.TabIndex = 6;
            this.tab2_lbldocumentosenlazados.Text = "Documentos Enlazados";
            // 
            // tab2_lstvwdocumentosenlazados
            // 
            this.tab2_lstvwdocumentosenlazados.AllowDrop = true;
            this.tab2_lstvwdocumentosenlazados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab2_lstvwdocumentosenlazados.BackgroundImageTiled = true;
            this.tab2_lstvwdocumentosenlazados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab2_lstvwdocumentosenlazados.ContextMenuStrip = this.cntmnuListViewEnlace;
            this.tab2_lstvwdocumentosenlazados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab2_lstvwdocumentosenlazados.Location = new System.Drawing.Point(486, 25);
            this.tab2_lstvwdocumentosenlazados.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tab2_lstvwdocumentosenlazados.Name = "tab2_lstvwdocumentosenlazados";
            this.tab2_lstvwdocumentosenlazados.Size = new System.Drawing.Size(481, 357);
            this.tab2_lstvwdocumentosenlazados.TabIndex = 5;
            this.tab2_lstvwdocumentosenlazados.UseCompatibleStateImageBehavior = false;
            this.tab2_lstvwdocumentosenlazados.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstvwdocumentosenlazados_ItemDrag);
            this.tab2_lstvwdocumentosenlazados.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosenlazados_DragDrop);
            this.tab2_lstvwdocumentosenlazados.DragOver += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosenlazados_DragOver);
            // 
            // tab2_lstvwdocumentosescaneados
            // 
            this.tab2_lstvwdocumentosescaneados.AllowDrop = true;
            this.tab2_lstvwdocumentosescaneados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab2_lstvwdocumentosescaneados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab2_lstvwdocumentosescaneados.ContextMenuStrip = this.cntmnuListViewScann;
            this.tab2_lstvwdocumentosescaneados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab2_lstvwdocumentosescaneados.Location = new System.Drawing.Point(0, 25);
            this.tab2_lstvwdocumentosescaneados.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tab2_lstvwdocumentosescaneados.Name = "tab2_lstvwdocumentosescaneados";
            this.tab2_lstvwdocumentosescaneados.Size = new System.Drawing.Size(480, 357);
            this.tab2_lstvwdocumentosescaneados.TabIndex = 4;
            this.tab2_lstvwdocumentosescaneados.UseCompatibleStateImageBehavior = false;
            this.tab2_lstvwdocumentosescaneados.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstvwdocumentosescaneados_ItemDrag);
            this.tab2_lstvwdocumentosescaneados.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosescaneados_DragDrop);
            this.tab2_lstvwdocumentosescaneados.DragOver += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosescaneados_DragOver);
            // 
            // tabpgeProveedor
            // 
            this.tabpgeProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabpgeProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabpgeProveedor.Controls.Add(this.tab3_tbllytpnldocumentos);
            this.tabpgeProveedor.ImageIndex = 3;
            this.tabpgeProveedor.Location = new System.Drawing.Point(4, 39);
            this.tabpgeProveedor.Name = "tabpgeProveedor";
            this.tabpgeProveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgeProveedor.Size = new System.Drawing.Size(980, 391);
            this.tabpgeProveedor.TabIndex = 3;
            this.tabpgeProveedor.Tag = "Documentos de proveedor";
            this.tabpgeProveedor.Text = "Proveedor";
            // 
            // tab3_tbllytpnldocumentos
            // 
            this.tab3_tbllytpnldocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab3_tbllytpnldocumentos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab3_tbllytpnldocumentos.ColumnCount = 2;
            this.tab3_tbllytpnldocumentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab3_tbllytpnldocumentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab3_tbllytpnldocumentos.Controls.Add(this.panel5, 0, 0);
            this.tab3_tbllytpnldocumentos.Controls.Add(this.panel6, 1, 0);
            this.tab3_tbllytpnldocumentos.Controls.Add(this.tab3_lstvwdocumentosenlazados, 1, 1);
            this.tab3_tbllytpnldocumentos.Controls.Add(this.tab3_lstvwdocumentosescaneados, 0, 1);
            this.tab3_tbllytpnldocumentos.Location = new System.Drawing.Point(6, 6);
            this.tab3_tbllytpnldocumentos.Margin = new System.Windows.Forms.Padding(5);
            this.tab3_tbllytpnldocumentos.Name = "tab3_tbllytpnldocumentos";
            this.tab3_tbllytpnldocumentos.RowCount = 2;
            this.tab3_tbllytpnldocumentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tab3_tbllytpnldocumentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tab3_tbllytpnldocumentos.Size = new System.Drawing.Size(967, 382);
            this.tab3_tbllytpnldocumentos.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tab3_pblbldocumentosescaneados);
            this.panel5.Controls.Add(this.tab3_lbldocumentosescaneados);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 25);
            this.panel5.TabIndex = 6;
            // 
            // tab3_lbldocumentosescaneados
            // 
            this.tab3_lbldocumentosescaneados.AutoSize = true;
            this.tab3_lbldocumentosescaneados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3_lbldocumentosescaneados.Location = new System.Drawing.Point(20, 7);
            this.tab3_lbldocumentosescaneados.Margin = new System.Windows.Forms.Padding(0);
            this.tab3_lbldocumentosescaneados.Name = "tab3_lbldocumentosescaneados";
            this.tab3_lbldocumentosescaneados.Size = new System.Drawing.Size(193, 20);
            this.tab3_lbldocumentosescaneados.TabIndex = 6;
            this.tab3_lbldocumentosescaneados.Text = "Documentos Escaneados";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tab3_pblbldocumentosenlazados);
            this.panel6.Controls.Add(this.tab3_lbldocumentosenlazados);
            this.panel6.Location = new System.Drawing.Point(483, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 25);
            this.panel6.TabIndex = 0;
            // 
            // tab3_lbldocumentosenlazados
            // 
            this.tab3_lbldocumentosenlazados.AutoSize = true;
            this.tab3_lbldocumentosenlazados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3_lbldocumentosenlazados.Location = new System.Drawing.Point(27, 7);
            this.tab3_lbldocumentosenlazados.Margin = new System.Windows.Forms.Padding(0);
            this.tab3_lbldocumentosenlazados.Name = "tab3_lbldocumentosenlazados";
            this.tab3_lbldocumentosenlazados.Size = new System.Drawing.Size(179, 20);
            this.tab3_lbldocumentosenlazados.TabIndex = 6;
            this.tab3_lbldocumentosenlazados.Text = "Documentos Enlazados";
            // 
            // tab3_lstvwdocumentosenlazados
            // 
            this.tab3_lstvwdocumentosenlazados.AllowDrop = true;
            this.tab3_lstvwdocumentosenlazados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab3_lstvwdocumentosenlazados.BackgroundImageTiled = true;
            this.tab3_lstvwdocumentosenlazados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab3_lstvwdocumentosenlazados.ContextMenuStrip = this.cntmnuListViewEnlace;
            this.tab3_lstvwdocumentosenlazados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab3_lstvwdocumentosenlazados.Location = new System.Drawing.Point(486, 25);
            this.tab3_lstvwdocumentosenlazados.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tab3_lstvwdocumentosenlazados.Name = "tab3_lstvwdocumentosenlazados";
            this.tab3_lstvwdocumentosenlazados.Size = new System.Drawing.Size(481, 357);
            this.tab3_lstvwdocumentosenlazados.TabIndex = 5;
            this.tab3_lstvwdocumentosenlazados.UseCompatibleStateImageBehavior = false;
            this.tab3_lstvwdocumentosenlazados.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstvwdocumentosenlazados_ItemDrag);
            this.tab3_lstvwdocumentosenlazados.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosenlazados_DragDrop);
            this.tab3_lstvwdocumentosenlazados.DragOver += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosenlazados_DragOver);
            // 
            // tab3_lstvwdocumentosescaneados
            // 
            this.tab3_lstvwdocumentosescaneados.AllowDrop = true;
            this.tab3_lstvwdocumentosescaneados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab3_lstvwdocumentosescaneados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab3_lstvwdocumentosescaneados.ContextMenuStrip = this.cntmnuListViewScann;
            this.tab3_lstvwdocumentosescaneados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab3_lstvwdocumentosescaneados.Location = new System.Drawing.Point(0, 25);
            this.tab3_lstvwdocumentosescaneados.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tab3_lstvwdocumentosescaneados.Name = "tab3_lstvwdocumentosescaneados";
            this.tab3_lstvwdocumentosescaneados.Size = new System.Drawing.Size(480, 357);
            this.tab3_lstvwdocumentosescaneados.TabIndex = 4;
            this.tab3_lstvwdocumentosescaneados.UseCompatibleStateImageBehavior = false;
            this.tab3_lstvwdocumentosescaneados.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstvwdocumentosescaneados_ItemDrag);
            this.tab3_lstvwdocumentosescaneados.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosescaneados_DragDrop);
            this.tab3_lstvwdocumentosescaneados.DragOver += new System.Windows.Forms.DragEventHandler(this.lstvwdocumentosescaneados_DragOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "Campos trazables";
            // 
            // tlp_proc
            // 
            this.tlp_proc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_proc.BackColor = System.Drawing.Color.Transparent;
            this.tlp_proc.ColumnCount = 2;
            this.tlp_proc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_proc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_proc.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_proc.Controls.Add(this.label3, 1, 0);
            this.tlp_proc.Location = new System.Drawing.Point(804, 675);
            this.tlp_proc.Name = "tlp_proc";
            this.tlp_proc.RowCount = 1;
            this.tlp_proc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_proc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_proc.Size = new System.Drawing.Size(199, 50);
            this.tlp_proc.TabIndex = 58;
            this.tlp_proc.Visible = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(48, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label3.Size = new System.Drawing.Size(145, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Favor de esperar";
            // 
            // frm_scann
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.btn_config_scann);
            this.Controls.Add(this.tlp_proc);
            this.Controls.Add(this.btn_limpiarcontroles);
            this.Controls.Add(this.btn_abririmagen);
            this.Controls.Add(this.btn_scanear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbctrl);
            this.Controls.Add(this.dataGridView_CamposTrazables);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lookUpEdit_Tramites);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KDImage);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frm_scann";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escaneo de Documentos";
            this.Load += new System.EventHandler(this.scann_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_scann_Paint);
            this.cntmnuListViewEnlace.ResumeLayout(false);
            this.cntmnuListViewScann.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab2_pblbldocumentosescaneados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_pblbldocumentosenlazados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pblbldocumentosescaneados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab3_pblbldocumentosenlazados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab0_pblbldocumentosescaneados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab0_pblbldocumentosenlazados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_pblbldocumentosenlazados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_pblbldocumentosescaneados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Tramites.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KDImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CamposTrazables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCampostrazablesActivosporExpedienteResultBindingSource)).EndInit();
            this.tbctrl.ResumeLayout(false);
            this.tabpgeUsuario.ResumeLayout(false);
            this.tab0_tbllytpnldocumentos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabpgeInterno.ResumeLayout(false);
            this.tab1_tbllytpnldocumentos.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPgeExterno.ResumeLayout(false);
            this.tab2_tbllytpnldocumentos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabpgeProveedor.ResumeLayout(false);
            this.tab3_tbllytpnldocumentos.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tlp_proc.ResumeLayout(false);
            this.tlp_proc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cntmnuListViewScann;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwscannrotarderecha;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwscannrotarizquierda;
        private System.Windows.Forms.ToolStripSeparator tsmnuitemlstvwscannseparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwscanneliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwscannabrir;
        private System.Windows.Forms.ToolStripSeparator tsmnuitemlstvwscannseparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwscannenlazar;
        private System.Windows.Forms.ToolTip tooltipBtnMnuOptions;
        private System.Windows.Forms.ImageList imglsttabs;
        private System.Windows.Forms.ContextMenuStrip cntmnuListViewEnlace;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwenlaceabrir;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwenlaceeliminar;
        private System.Windows.Forms.ToolStripSeparator tsmnuitemlstvwenlaceseparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwenlacegirarderecha;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwenlacegirarizquierda;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwenlacedesenlazar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwscannenlazarsubmnutodo;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwscannenlazarsubmnuduplicaryenlazar;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwscannenlazarsubmnuseleccionado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwscannseltodo;
        private System.Windows.Forms.OpenFileDialog ofdabrirarchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwenlacedesenlazarseleccionado;
        private System.Windows.Forms.ToolStripMenuItem tsmnuitemlstvwenlacedesenlazartodo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_Tramites;
        private System.Windows.Forms.BindingSource vwTramitesActivosBindingSource;
        private System.Windows.Forms.BindingSource vwCamposTrazablesBindingSource;
        private AxKDImageEditor.AxKDImage KDImage;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_config_scann;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridView dataGridView_CamposTrazables;
        private System.Windows.Forms.TabControl tbctrl;
        private System.Windows.Forms.TabPage tabpgeUsuario;
        private System.Windows.Forms.TabPage tabpgeInterno;
        private System.Windows.Forms.TabPage tabPgeExterno;
        private System.Windows.Forms.TableLayoutPanel tab2_tbllytpnldocumentos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tab2_lbldocumentosescaneados;
        private System.Windows.Forms.PictureBox tab2_pblbldocumentosescaneados;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tab2_lbldocumentosenlazados;
        private System.Windows.Forms.PictureBox tab2_pblbldocumentosenlazados;
        private System.Windows.Forms.ListView tab2_lstvwdocumentosenlazados;
        private System.Windows.Forms.ListView tab2_lstvwdocumentosescaneados;
        private System.Windows.Forms.TabPage tabpgeProveedor;
        private System.Windows.Forms.TableLayoutPanel tab3_tbllytpnldocumentos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label tab3_lbldocumentosescaneados;
        private System.Windows.Forms.PictureBox tab3_pblbldocumentosescaneados;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label tab3_lbldocumentosenlazados;
        private System.Windows.Forms.PictureBox tab3_pblbldocumentosenlazados;
        private System.Windows.Forms.ListView tab3_lstvwdocumentosenlazados;
        private System.Windows.Forms.ListView tab3_lstvwdocumentosescaneados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource paCampostrazablesActivosporExpedienteResultBindingSource;
        private System.Windows.Forms.Button btn_limpiarcontroles;
        private System.Windows.Forms.Button btn_abririmagen;
        private System.Windows.Forms.Button btn_scanear;
        private System.Windows.Forms.TableLayoutPanel tab0_tbllytpnldocumentos;
        private System.Windows.Forms.ListView tab0_lstvwdocumentosenlazados;
        private System.Windows.Forms.ListView tab0_lstvwdocumentosescaneados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox tab0_pblbldocumentosenlazados;
        private System.Windows.Forms.Label tab0_lbldocumentosenlazados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox tab0_pblbldocumentosescaneados;
        private System.Windows.Forms.Label tab0_lbldocumentosescaneados;
        private System.Windows.Forms.TableLayoutPanel tab1_tbllytpnldocumentos;
        private System.Windows.Forms.ListView tab1_lstvwdocumentosenlazados;
        private System.Windows.Forms.ListView tab1_lstvwdocumentosescaneados;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox tab1_pblbldocumentosenlazados;
        private System.Windows.Forms.Label tab1_lbldocumentosenlazados;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox tab1_pblbldocumentosescaneados;
        private System.Windows.Forms.Label tab1_lbldocumentosescaneados;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TableLayoutPanel tlp_proc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcampotrazableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanioCaracteresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esprincipalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor_trazable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_re_expedientes_campostrazables;




    }
}

