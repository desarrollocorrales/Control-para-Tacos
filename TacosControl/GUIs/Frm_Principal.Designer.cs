namespace TacosControl.GUIs
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.txbExportarVentas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnExportar = new System.Windows.Forms.Button();
            this.tabConsultas = new System.Windows.Forms.TabPage();
            this.pictLoading = new System.Windows.Forms.PictureBox();
            this.gridRecetas = new DevExpress.XtraGrid.GridControl();
            this.recetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvRecetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproductos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinsumos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinsumos1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridInsumos = new DevExpress.XtraGrid.GridControl();
            this.insumosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvInsumos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_insumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrendimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProductos = new DevExpress.XtraGrid.GridControl();
            this.gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbObjetos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbMSSQLPuerto = new System.Windows.Forms.TextBox();
            this.lblAccionMSSQL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarMSSQL = new System.Windows.Forms.Button();
            this.txbMSSQLServidor = new System.Windows.Forms.TextBox();
            this.btnProbarMSSQL = new System.Windows.Forms.Button();
            this.lblMSSQLDatabase = new System.Windows.Forms.Label();
            this.txbMSSQLPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMSSQLBaseDeDatos = new System.Windows.Forms.ComboBox();
            this.txbMSSQLUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.nudPuerto = new System.Windows.Forms.NumericUpDown();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabExportar = new System.Windows.Forms.TabPage();
            this.barProgreso = new System.Windows.Forms.ProgressBar();
            this.lblAccionExportar = new System.Windows.Forms.TextBox();
            this.btnExportarRecetas = new System.Windows.Forms.Button();
            this.btnExportarInsumos = new System.Windows.Forms.Button();
            this.btnExportarProductos = new System.Windows.Forms.Button();
            this.tabCorreo = new System.Windows.Forms.TabPage();
            this.btnGuardarCorreos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txbListCorreos = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudCorreoPuerto = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txbCorreoServer = new System.Windows.Forms.TextBox();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.niTacosControl = new System.Windows.Forms.NotifyIcon(this.components);
            this.timEjecutar = new System.Windows.Forms.Timer(this.components);
            this.bgwTemporizador = new System.ComponentModel.BackgroundWorker();
            this.tbControl.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).BeginInit();
            this.tabExportar.SuspendLayout();
            this.tabCorreo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorreoPuerto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(197, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Control de Tacos \"Los Corrales\"";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabVentas);
            this.tbControl.Controls.Add(this.tabConsultas);
            this.tbControl.Controls.Add(this.tabConfig);
            this.tbControl.Controls.Add(this.tabExportar);
            this.tbControl.Controls.Add(this.tabCorreo);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(0, 40);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(698, 512);
            this.tbControl.TabIndex = 1;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.txbExportarVentas);
            this.tabVentas.Controls.Add(this.label8);
            this.tabVentas.Controls.Add(this.label2);
            this.tabVentas.Controls.Add(this.dtpFecha);
            this.tabVentas.Controls.Add(this.btnExportar);
            this.tabVentas.Location = new System.Drawing.Point(4, 28);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(690, 480);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // txbExportarVentas
            // 
            this.txbExportarVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbExportarVentas.Location = new System.Drawing.Point(8, 79);
            this.txbExportarVentas.Multiline = true;
            this.txbExportarVentas.Name = "txbExportarVentas";
            this.txbExportarVentas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbExportarVentas.Size = new System.Drawing.Size(674, 393);
            this.txbExportarVentas.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Exportar ventas";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFecha.CustomFormat = "dd/MMMM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(205, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(236, 27);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportar.Location = new System.Drawing.Point(447, 46);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(99, 27);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabConsultas
            // 
            this.tabConsultas.Controls.Add(this.pictLoading);
            this.tabConsultas.Controls.Add(this.gridRecetas);
            this.tabConsultas.Controls.Add(this.gridInsumos);
            this.tabConsultas.Controls.Add(this.gridProductos);
            this.tabConsultas.Controls.Add(this.panel1);
            this.tabConsultas.Location = new System.Drawing.Point(4, 28);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultas.Size = new System.Drawing.Size(690, 480);
            this.tabConsultas.TabIndex = 2;
            this.tabConsultas.Text = "Consultas";
            this.tabConsultas.UseVisualStyleBackColor = true;
            // 
            // pictLoading
            // 
            this.pictLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictLoading.Image")));
            this.pictLoading.Location = new System.Drawing.Point(261, 193);
            this.pictLoading.Name = "pictLoading";
            this.pictLoading.Size = new System.Drawing.Size(169, 94);
            this.pictLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictLoading.TabIndex = 7;
            this.pictLoading.TabStop = false;
            this.pictLoading.Visible = false;
            // 
            // gridRecetas
            // 
            this.gridRecetas.DataSource = this.recetasBindingSource;
            this.gridRecetas.Location = new System.Drawing.Point(351, 59);
            this.gridRecetas.MainView = this.gvRecetas;
            this.gridRecetas.Name = "gridRecetas";
            this.gridRecetas.Size = new System.Drawing.Size(333, 284);
            this.gridRecetas.TabIndex = 4;
            this.gridRecetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRecetas});
            this.gridRecetas.Visible = false;
            // 
            // recetasBindingSource
            // 
            this.recetasBindingSource.DataSource = typeof(TacosControl.Entity.recetas);
            // 
            // gvRecetas
            // 
            this.gvRecetas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvRecetas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRecetas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvRecetas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvRecetas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvRecetas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvRecetas.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvRecetas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvRecetas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRecetas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvRecetas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvRecetas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvRecetas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvRecetas.Appearance.Empty.Options.UseBackColor = true;
            this.gvRecetas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvRecetas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvRecetas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvRecetas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRecetas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvRecetas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvRecetas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvRecetas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvRecetas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvRecetas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvRecetas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvRecetas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvRecetas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvRecetas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvRecetas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvRecetas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvRecetas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvRecetas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvRecetas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRecetas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvRecetas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvRecetas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRecetas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvRecetas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvRecetas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvRecetas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvRecetas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvRecetas.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvRecetas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvRecetas.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvRecetas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvRecetas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvRecetas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvRecetas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvRecetas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvRecetas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvRecetas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvRecetas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvRecetas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvRecetas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvRecetas.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvRecetas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvRecetas.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvRecetas.Appearance.GroupRow.Options.UseFont = true;
            this.gvRecetas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvRecetas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvRecetas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvRecetas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRecetas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvRecetas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvRecetas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvRecetas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvRecetas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvRecetas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvRecetas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvRecetas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvRecetas.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvRecetas.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvRecetas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvRecetas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvRecetas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvRecetas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvRecetas.Appearance.Preview.Options.UseBackColor = true;
            this.gvRecetas.Appearance.Preview.Options.UseForeColor = true;
            this.gvRecetas.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvRecetas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvRecetas.Appearance.Row.Options.UseBackColor = true;
            this.gvRecetas.Appearance.Row.Options.UseForeColor = true;
            this.gvRecetas.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvRecetas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvRecetas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvRecetas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvRecetas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvRecetas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvRecetas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvRecetas.Appearance.VertLine.Options.UseBackColor = true;
            this.gvRecetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproductos,
            this.colinsumos,
            this.colcantidad,
            this.colinsumos1});
            this.gvRecetas.GridControl = this.gridRecetas;
            this.gvRecetas.GroupCount = 1;
            this.gvRecetas.Name = "gvRecetas";
            this.gvRecetas.OptionsBehavior.Editable = false;
            this.gvRecetas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRecetas.OptionsView.EnableAppearanceOddRow = true;
            this.gvRecetas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colproductos, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvRecetas.EndGrouping += new System.EventHandler(this.gvRecetas_EndGrouping);
            // 
            // colproductos
            // 
            this.colproductos.Caption = "Producto";
            this.colproductos.FieldName = "productos.producto";
            this.colproductos.Name = "colproductos";
            this.colproductos.Visible = true;
            this.colproductos.VisibleIndex = 0;
            // 
            // colinsumos
            // 
            this.colinsumos.Caption = "Insumo";
            this.colinsumos.FieldName = "insumos.descripcion";
            this.colinsumos.Name = "colinsumos";
            this.colinsumos.Visible = true;
            this.colinsumos.VisibleIndex = 0;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 1;
            // 
            // colinsumos1
            // 
            this.colinsumos1.Caption = "Unidad";
            this.colinsumos1.FieldName = "insumos.unidad";
            this.colinsumos1.Name = "colinsumos1";
            this.colinsumos1.Visible = true;
            this.colinsumos1.VisibleIndex = 2;
            // 
            // gridInsumos
            // 
            this.gridInsumos.DataSource = this.insumosBindingSource;
            this.gridInsumos.Location = new System.Drawing.Point(8, 204);
            this.gridInsumos.MainView = this.gvInsumos;
            this.gridInsumos.Name = "gridInsumos";
            this.gridInsumos.Size = new System.Drawing.Size(333, 139);
            this.gridInsumos.TabIndex = 3;
            this.gridInsumos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInsumos});
            this.gridInsumos.Visible = false;
            // 
            // insumosBindingSource
            // 
            this.insumosBindingSource.DataSource = typeof(TacosControl.Entity.insumos);
            // 
            // gvInsumos
            // 
            this.gvInsumos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInsumos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInsumos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvInsumos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvInsumos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvInsumos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvInsumos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvInsumos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvInsumos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInsumos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvInsumos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvInsumos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvInsumos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvInsumos.Appearance.Empty.Options.UseBackColor = true;
            this.gvInsumos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvInsumos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvInsumos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInsumos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInsumos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvInsumos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvInsumos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvInsumos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvInsumos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvInsumos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvInsumos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvInsumos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvInsumos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvInsumos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvInsumos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvInsumos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvInsumos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvInsumos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvInsumos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvInsumos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvInsumos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInsumos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInsumos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvInsumos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvInsumos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvInsumos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInsumos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInsumos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvInsumos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvInsumos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvInsumos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInsumos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInsumos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvInsumos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvInsumos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvInsumos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvInsumos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvInsumos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvInsumos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInsumos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInsumos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvInsumos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvInsumos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvInsumos.Appearance.GroupRow.Options.UseFont = true;
            this.gvInsumos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvInsumos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInsumos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInsumos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInsumos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvInsumos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvInsumos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvInsumos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvInsumos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvInsumos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvInsumos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvInsumos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvInsumos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvInsumos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvInsumos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvInsumos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvInsumos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvInsumos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvInsumos.Appearance.Preview.Options.UseBackColor = true;
            this.gvInsumos.Appearance.Preview.Options.UseForeColor = true;
            this.gvInsumos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvInsumos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvInsumos.Appearance.Row.Options.UseBackColor = true;
            this.gvInsumos.Appearance.Row.Options.UseForeColor = true;
            this.gvInsumos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvInsumos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvInsumos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvInsumos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvInsumos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInsumos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvInsumos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvInsumos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvInsumos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_insumo,
            this.coldescripcion,
            this.colrendimiento,
            this.colunidad});
            this.gvInsumos.GridControl = this.gridInsumos;
            this.gvInsumos.Name = "gvInsumos";
            this.gvInsumos.OptionsBehavior.Editable = false;
            this.gvInsumos.OptionsCustomization.AllowGroup = false;
            this.gvInsumos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInsumos.OptionsView.EnableAppearanceOddRow = true;
            this.gvInsumos.OptionsView.ShowGroupPanel = false;
            // 
            // colid_insumo
            // 
            this.colid_insumo.Caption = "ID";
            this.colid_insumo.FieldName = "id_insumo";
            this.colid_insumo.Name = "colid_insumo";
            this.colid_insumo.Visible = true;
            this.colid_insumo.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // colrendimiento
            // 
            this.colrendimiento.Caption = "Rendimiento";
            this.colrendimiento.FieldName = "rendimiento";
            this.colrendimiento.Name = "colrendimiento";
            this.colrendimiento.Visible = true;
            this.colrendimiento.VisibleIndex = 2;
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 3;
            // 
            // gridProductos
            // 
            this.gridProductos.Location = new System.Drawing.Point(8, 59);
            this.gridProductos.MainView = this.gvProductos;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(333, 139);
            this.gridProductos.TabIndex = 2;
            this.gridProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductos});
            this.gridProductos.Visible = false;
            // 
            // gvProductos
            // 
            this.gvProductos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvProductos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvProductos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvProductos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvProductos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvProductos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvProductos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvProductos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvProductos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvProductos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvProductos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvProductos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvProductos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvProductos.Appearance.Empty.Options.UseBackColor = true;
            this.gvProductos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProductos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvProductos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvProductos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvProductos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvProductos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvProductos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvProductos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvProductos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvProductos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvProductos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvProductos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvProductos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvProductos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvProductos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvProductos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvProductos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvProductos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvProductos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvProductos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvProductos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvProductos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvProductos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvProductos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvProductos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvProductos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvProductos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvProductos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvProductos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvProductos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvProductos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvProductos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvProductos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvProductos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvProductos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvProductos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvProductos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvProductos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvProductos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvProductos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvProductos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvProductos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvProductos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvProductos.Appearance.GroupRow.Options.UseFont = true;
            this.gvProductos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvProductos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvProductos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvProductos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvProductos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvProductos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvProductos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvProductos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvProductos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvProductos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvProductos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvProductos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvProductos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvProductos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvProductos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvProductos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvProductos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvProductos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvProductos.Appearance.Preview.Options.UseBackColor = true;
            this.gvProductos.Appearance.Preview.Options.UseForeColor = true;
            this.gvProductos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvProductos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvProductos.Appearance.Row.Options.UseBackColor = true;
            this.gvProductos.Appearance.Row.Options.UseForeColor = true;
            this.gvProductos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvProductos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvProductos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvProductos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvProductos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvProductos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvProductos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvProductos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_producto,
            this.colproducto});
            this.gvProductos.GridControl = this.gridProductos;
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.OptionsBehavior.Editable = false;
            this.gvProductos.OptionsCustomization.AllowGroup = false;
            this.gvProductos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProductos.OptionsView.EnableAppearanceOddRow = true;
            this.gvProductos.OptionsView.ShowGroupPanel = false;
            // 
            // colid_producto
            // 
            this.colid_producto.FieldName = "id_producto";
            this.colid_producto.Name = "colid_producto";
            this.colid_producto.Visible = true;
            this.colid_producto.VisibleIndex = 0;
            // 
            // colproducto
            // 
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.cbObjetos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 50);
            this.panel1.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.Location = new System.Drawing.Point(487, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 27);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbObjetos
            // 
            this.cbObjetos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbObjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjetos.FormattingEnabled = true;
            this.cbObjetos.Location = new System.Drawing.Point(238, 12);
            this.cbObjetos.Name = "cbObjetos";
            this.cbObjetos.Size = new System.Drawing.Size(243, 27);
            this.cbObjetos.TabIndex = 0;
            this.cbObjetos.SelectedIndexChanged += new System.EventHandler(this.cbObjetos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tipo de Consulta:";
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.groupBox2);
            this.tabConfig.Controls.Add(this.groupBox1);
            this.tabConfig.Location = new System.Drawing.Point(4, 28);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(690, 480);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Configurar";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txbMSSQLPuerto);
            this.groupBox2.Controls.Add(this.lblAccionMSSQL);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnGuardarMSSQL);
            this.groupBox2.Controls.Add(this.txbMSSQLServidor);
            this.groupBox2.Controls.Add(this.btnProbarMSSQL);
            this.groupBox2.Controls.Add(this.lblMSSQLDatabase);
            this.groupBox2.Controls.Add(this.txbMSSQLPassword);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbMSSQLBaseDeDatos);
            this.groupBox2.Controls.Add(this.txbMSSQLUsuario);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(8, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 232);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MSSQL Server";
            // 
            // txbMSSQLPuerto
            // 
            this.txbMSSQLPuerto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMSSQLPuerto.Location = new System.Drawing.Point(471, 51);
            this.txbMSSQLPuerto.Name = "txbMSSQLPuerto";
            this.txbMSSQLPuerto.Size = new System.Drawing.Size(137, 27);
            this.txbMSSQLPuerto.TabIndex = 18;
            this.txbMSSQLPuerto.Text = "1433";
            this.txbMSSQLPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccionMSSQL
            // 
            this.lblAccionMSSQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccionMSSQL.AutoSize = true;
            this.lblAccionMSSQL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionMSSQL.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAccionMSSQL.Location = new System.Drawing.Point(151, 191);
            this.lblAccionMSSQL.Name = "lblAccionMSSQL";
            this.lblAccionMSSQL.Size = new System.Drawing.Size(372, 19);
            this.lblAccionMSSQL.TabIndex = 17;
            this.lblAccionMSSQL.Text = "La configuración ha sido guardada con exito.";
            this.lblAccionMSSQL.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Servidor:";
            // 
            // btnGuardarMSSQL
            // 
            this.btnGuardarMSSQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarMSSQL.Location = new System.Drawing.Point(225, 150);
            this.btnGuardarMSSQL.Name = "btnGuardarMSSQL";
            this.btnGuardarMSSQL.Size = new System.Drawing.Size(220, 35);
            this.btnGuardarMSSQL.TabIndex = 16;
            this.btnGuardarMSSQL.Text = "Guardar Configuración";
            this.btnGuardarMSSQL.UseVisualStyleBackColor = true;
            this.btnGuardarMSSQL.Visible = false;
            this.btnGuardarMSSQL.Click += new System.EventHandler(this.btnGuardarMSSQL_Click);
            // 
            // txbMSSQLServidor
            // 
            this.txbMSSQLServidor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMSSQLServidor.Location = new System.Drawing.Point(191, 18);
            this.txbMSSQLServidor.Name = "txbMSSQLServidor";
            this.txbMSSQLServidor.Size = new System.Drawing.Size(417, 27);
            this.txbMSSQLServidor.TabIndex = 1;
            this.txbMSSQLServidor.Text = "servidor";
            // 
            // btnProbarMSSQL
            // 
            this.btnProbarMSSQL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProbarMSSQL.Location = new System.Drawing.Point(471, 85);
            this.btnProbarMSSQL.Name = "btnProbarMSSQL";
            this.btnProbarMSSQL.Size = new System.Drawing.Size(137, 59);
            this.btnProbarMSSQL.TabIndex = 14;
            this.btnProbarMSSQL.Text = "Prueba de Conexión";
            this.btnProbarMSSQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProbarMSSQL.UseVisualStyleBackColor = true;
            this.btnProbarMSSQL.Click += new System.EventHandler(this.btnProbarMSSQL_Click);
            // 
            // lblMSSQLDatabase
            // 
            this.lblMSSQLDatabase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMSSQLDatabase.AutoSize = true;
            this.lblMSSQLDatabase.Location = new System.Drawing.Point(71, 120);
            this.lblMSSQLDatabase.Name = "lblMSSQLDatabase";
            this.lblMSSQLDatabase.Size = new System.Drawing.Size(114, 19);
            this.lblMSSQLDatabase.TabIndex = 2;
            this.lblMSSQLDatabase.Text = "Base de Datos:";
            this.lblMSSQLDatabase.Visible = false;
            // 
            // txbMSSQLPassword
            // 
            this.txbMSSQLPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMSSQLPassword.Location = new System.Drawing.Point(191, 84);
            this.txbMSSQLPassword.Name = "txbMSSQLPassword";
            this.txbMSSQLPassword.PasswordChar = '*';
            this.txbMSSQLPassword.Size = new System.Drawing.Size(274, 27);
            this.txbMSSQLPassword.TabIndex = 3;
            this.txbMSSQLPassword.Text = "contraseña";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Puerto:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Usuario:";
            // 
            // cbMSSQLBaseDeDatos
            // 
            this.cbMSSQLBaseDeDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMSSQLBaseDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMSSQLBaseDeDatos.FormattingEnabled = true;
            this.cbMSSQLBaseDeDatos.Location = new System.Drawing.Point(191, 117);
            this.cbMSSQLBaseDeDatos.Name = "cbMSSQLBaseDeDatos";
            this.cbMSSQLBaseDeDatos.Size = new System.Drawing.Size(274, 27);
            this.cbMSSQLBaseDeDatos.TabIndex = 7;
            this.cbMSSQLBaseDeDatos.Visible = false;
            // 
            // txbMSSQLUsuario
            // 
            this.txbMSSQLUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMSSQLUsuario.Location = new System.Drawing.Point(191, 51);
            this.txbMSSQLUsuario.Name = "txbMSSQLUsuario";
            this.txbMSSQLUsuario.Size = new System.Drawing.Size(200, 27);
            this.txbMSSQLUsuario.TabIndex = 2;
            this.txbMSSQLUsuario.Text = "usuario";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblAccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txbServidor);
            this.groupBox1.Controls.Add(this.btnProbarConexion);
            this.groupBox1.Controls.Add(this.lblDatabase);
            this.groupBox1.Controls.Add(this.nudPuerto);
            this.groupBox1.Controls.Add(this.txbContraseña);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDatabase);
            this.groupBox1.Controls.Add(this.txbUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 228);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySQL";
            // 
            // lblAccion
            // 
            this.lblAccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAccion.Location = new System.Drawing.Point(151, 191);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(372, 19);
            this.lblAccion.TabIndex = 17;
            this.lblAccion.Text = "La configuración ha sido guardada con exito.";
            this.lblAccion.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor Mysql:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Location = new System.Drawing.Point(225, 150);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 35);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar Configuración";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbServidor
            // 
            this.txbServidor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbServidor.Location = new System.Drawing.Point(191, 18);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(417, 27);
            this.txbServidor.TabIndex = 1;
            this.txbServidor.Text = "servidor";
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProbarConexion.Location = new System.Drawing.Point(471, 85);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(137, 59);
            this.btnProbarConexion.TabIndex = 14;
            this.btnProbarConexion.Text = "Prueba de Conexión";
            this.btnProbarConexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(71, 120);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(114, 19);
            this.lblDatabase.TabIndex = 2;
            this.lblDatabase.Text = "Base de Datos:";
            this.lblDatabase.Visible = false;
            // 
            // nudPuerto
            // 
            this.nudPuerto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudPuerto.Location = new System.Drawing.Point(471, 52);
            this.nudPuerto.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.nudPuerto.Name = "nudPuerto";
            this.nudPuerto.Size = new System.Drawing.Size(137, 27);
            this.nudPuerto.TabIndex = 10;
            this.nudPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPuerto.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // txbContraseña
            // 
            this.txbContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbContraseña.Location = new System.Drawing.Point(191, 84);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(274, 27);
            this.txbContraseña.TabIndex = 3;
            this.txbContraseña.Text = "contraseña";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puerto:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // cbDatabase
            // 
            this.cbDatabase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(191, 117);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(274, 27);
            this.cbDatabase.TabIndex = 7;
            this.cbDatabase.Visible = false;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbUsuario.Location = new System.Drawing.Point(191, 51);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(200, 27);
            this.txbUsuario.TabIndex = 2;
            this.txbUsuario.Text = "usuario";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña:";
            // 
            // tabExportar
            // 
            this.tabExportar.Controls.Add(this.barProgreso);
            this.tabExportar.Controls.Add(this.lblAccionExportar);
            this.tabExportar.Controls.Add(this.btnExportarRecetas);
            this.tabExportar.Controls.Add(this.btnExportarInsumos);
            this.tabExportar.Controls.Add(this.btnExportarProductos);
            this.tabExportar.Location = new System.Drawing.Point(4, 28);
            this.tabExportar.Name = "tabExportar";
            this.tabExportar.Size = new System.Drawing.Size(690, 480);
            this.tabExportar.TabIndex = 3;
            this.tabExportar.Text = "Exportar";
            this.tabExportar.UseVisualStyleBackColor = true;
            // 
            // barProgreso
            // 
            this.barProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barProgreso.Location = new System.Drawing.Point(34, 125);
            this.barProgreso.Name = "barProgreso";
            this.barProgreso.Size = new System.Drawing.Size(622, 23);
            this.barProgreso.TabIndex = 4;
            // 
            // lblAccionExportar
            // 
            this.lblAccionExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccionExportar.Location = new System.Drawing.Point(8, 154);
            this.lblAccionExportar.Multiline = true;
            this.lblAccionExportar.Name = "lblAccionExportar";
            this.lblAccionExportar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblAccionExportar.Size = new System.Drawing.Size(674, 318);
            this.lblAccionExportar.TabIndex = 3;
            // 
            // btnExportarRecetas
            // 
            this.btnExportarRecetas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportarRecetas.Location = new System.Drawing.Point(220, 89);
            this.btnExportarRecetas.Name = "btnExportarRecetas";
            this.btnExportarRecetas.Size = new System.Drawing.Size(250, 30);
            this.btnExportarRecetas.TabIndex = 2;
            this.btnExportarRecetas.Text = "Exportar Recetas";
            this.btnExportarRecetas.UseVisualStyleBackColor = true;
            this.btnExportarRecetas.Click += new System.EventHandler(this.btnExportarRecetas_Click);
            // 
            // btnExportarInsumos
            // 
            this.btnExportarInsumos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportarInsumos.Location = new System.Drawing.Point(220, 53);
            this.btnExportarInsumos.Name = "btnExportarInsumos";
            this.btnExportarInsumos.Size = new System.Drawing.Size(250, 30);
            this.btnExportarInsumos.TabIndex = 1;
            this.btnExportarInsumos.Text = "Exportar Insumos";
            this.btnExportarInsumos.UseVisualStyleBackColor = true;
            this.btnExportarInsumos.Click += new System.EventHandler(this.btnExportarInsumos_Click);
            // 
            // btnExportarProductos
            // 
            this.btnExportarProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportarProductos.Location = new System.Drawing.Point(220, 17);
            this.btnExportarProductos.Name = "btnExportarProductos";
            this.btnExportarProductos.Size = new System.Drawing.Size(250, 30);
            this.btnExportarProductos.TabIndex = 0;
            this.btnExportarProductos.Text = "Exportar Productos";
            this.btnExportarProductos.UseVisualStyleBackColor = true;
            this.btnExportarProductos.Click += new System.EventHandler(this.btnExportarProductos_Click);
            // 
            // tabCorreo
            // 
            this.tabCorreo.Controls.Add(this.btnGuardarCorreos);
            this.tabCorreo.Controls.Add(this.groupBox4);
            this.tabCorreo.Controls.Add(this.groupBox3);
            this.tabCorreo.Location = new System.Drawing.Point(4, 28);
            this.tabCorreo.Name = "tabCorreo";
            this.tabCorreo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCorreo.Size = new System.Drawing.Size(690, 480);
            this.tabCorreo.TabIndex = 4;
            this.tabCorreo.Text = "Correos";
            this.tabCorreo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCorreos
            // 
            this.btnGuardarCorreos.Location = new System.Drawing.Point(295, 442);
            this.btnGuardarCorreos.Name = "btnGuardarCorreos";
            this.btnGuardarCorreos.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarCorreos.TabIndex = 4;
            this.btnGuardarCorreos.Text = "Guardar";
            this.btnGuardarCorreos.UseVisualStyleBackColor = true;
            this.btnGuardarCorreos.Click += new System.EventHandler(this.btnGuardarCorreos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbListCorreos);
            this.groupBox4.Location = new System.Drawing.Point(8, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 287);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Correos a enviar";
            // 
            // txbListCorreos
            // 
            this.txbListCorreos.Location = new System.Drawing.Point(6, 26);
            this.txbListCorreos.Multiline = true;
            this.txbListCorreos.Name = "txbListCorreos";
            this.txbListCorreos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbListCorreos.Size = new System.Drawing.Size(662, 255);
            this.txbListCorreos.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudCorreoPuerto);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txbCorreoServer);
            this.groupBox3.Controls.Add(this.txbCorreo);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 137);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Correo que envia";
            // 
            // nudCorreoPuerto
            // 
            this.nudCorreoPuerto.BackColor = System.Drawing.Color.White;
            this.nudCorreoPuerto.Enabled = false;
            this.nudCorreoPuerto.Location = new System.Drawing.Point(223, 104);
            this.nudCorreoPuerto.Maximum = new decimal(new int[] {
            35000,
            0,
            0,
            0});
            this.nudCorreoPuerto.Name = "nudCorreoPuerto";
            this.nudCorreoPuerto.Size = new System.Drawing.Size(120, 27);
            this.nudCorreoPuerto.TabIndex = 8;
            this.nudCorreoPuerto.Value = new decimal(new int[] {
            2525,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(156, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 7;
            this.label15.Text = "Puerto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Servidor de correo:";
            // 
            // txbCorreoServer
            // 
            this.txbCorreoServer.BackColor = System.Drawing.Color.White;
            this.txbCorreoServer.Enabled = false;
            this.txbCorreoServer.Location = new System.Drawing.Point(223, 70);
            this.txbCorreoServer.Name = "txbCorreoServer";
            this.txbCorreoServer.Size = new System.Drawing.Size(380, 27);
            this.txbCorreoServer.TabIndex = 3;
            // 
            // txbCorreo
            // 
            this.txbCorreo.BackColor = System.Drawing.Color.White;
            this.txbCorreo.Enabled = false;
            this.txbCorreo.Location = new System.Drawing.Point(223, 37);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(380, 27);
            this.txbCorreo.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Correo que envia:";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(TacosControl.Entity.productos);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(698, 40);
            this.pnlTitulo.TabIndex = 2;
            // 
            // niTacosControl
            // 
            this.niTacosControl.Icon = ((System.Drawing.Icon)(resources.GetObject("niTacosControl.Icon")));
            this.niTacosControl.Text = "Tacos Control";
            this.niTacosControl.Visible = true;
            this.niTacosControl.DoubleClick += new System.EventHandler(this.niTacosControl_DoubleClick);
            // 
            // timEjecutar
            // 
            this.timEjecutar.Enabled = true;
            this.timEjecutar.Interval = 60000;
            this.timEjecutar.Tick += new System.EventHandler(this.timEjecutar_Tick);
            // 
            // bgwTemporizador
            // 
            this.bgwTemporizador.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTemporizador_DoWork);
            this.bgwTemporizador.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTemporizador_RunWorkerCompleted);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 552);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Principal";
            this.Text = "Tacos Control";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.Shown += new System.EventHandler(this.Frm_Principal_Shown);
            this.Resize += new System.EventHandler(this.Frm_Principal_Resize);
            this.tbControl.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            this.tabConsultas.ResumeLayout(false);
            this.tabConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).EndInit();
            this.tabExportar.ResumeLayout(false);
            this.tabExportar.PerformLayout();
            this.tabCorreo.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorreoPuerto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.NumericUpDown nudPuerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.TabPage tabConsultas;
        private System.Windows.Forms.ComboBox cbObjetos;
        private System.Windows.Forms.Button btnProbarConexion;
        private DevExpress.XtraGrid.GridControl gridProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridRecetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRecetas;
        private DevExpress.XtraGrid.GridControl gridInsumos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInsumos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private System.Windows.Forms.BindingSource insumosBindingSource;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAccionMSSQL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardarMSSQL;
        private System.Windows.Forms.TextBox txbMSSQLServidor;
        private System.Windows.Forms.Button btnProbarMSSQL;
        private System.Windows.Forms.Label lblMSSQLDatabase;
        private System.Windows.Forms.TextBox txbMSSQLPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMSSQLBaseDeDatos;
        private System.Windows.Forms.TextBox txbMSSQLUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabExportar;
        private System.Windows.Forms.TextBox txbMSSQLPuerto;
        private System.Windows.Forms.Button btnExportarRecetas;
        private System.Windows.Forms.Button btnExportarInsumos;
        private System.Windows.Forms.Button btnExportarProductos;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.BindingSource recetasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colproductos;
        private DevExpress.XtraGrid.Columns.GridColumn colinsumos;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colinsumos1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox lblAccionExportar;
        private System.Windows.Forms.ProgressBar barProgreso;
        private System.Windows.Forms.PictureBox pictLoading;
        private System.Windows.Forms.NotifyIcon niTacosControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbExportarVentas;
        private System.Windows.Forms.TabPage tabCorreo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbCorreoServer;
        private System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudCorreoPuerto;
        private System.Windows.Forms.Button btnGuardarCorreos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txbListCorreos;
        private System.Windows.Forms.Timer timEjecutar;
        private System.ComponentModel.BackgroundWorker bgwTemporizador;
        private DevExpress.XtraGrid.Columns.GridColumn colid_insumo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colrendimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
    }
}