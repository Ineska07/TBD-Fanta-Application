namespace FantaApp
{
    partial class frmVentasAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasAdd));
            this.lblFantaAdd = new System.Windows.Forms.Label();
            this.lblErrorVacio = new System.Windows.Forms.Label();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fANTA_BDDataSet = new FantaApp.FANTA_BDDataSet();
            this.productoTableAdapter = new FantaApp.FANTA_BDDataSetTableAdapters.ProductoTableAdapter();
            this.fANTABDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.dgvBDProductos = new System.Windows.Forms.DataGridView();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipodePago = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalActual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOrdenNueva = new System.Windows.Forms.DataGridView();
            this.lblClienteActual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTdPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbxPlus = new System.Windows.Forms.PictureBox();
            this.pbxMinus = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.btnAñadir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fANTA_BDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fANTABDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenNueva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFantaAdd
            // 
            this.lblFantaAdd.AutoSize = true;
            this.lblFantaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantaAdd.ForeColor = System.Drawing.Color.White;
            this.lblFantaAdd.Location = new System.Drawing.Point(12, 9);
            this.lblFantaAdd.Name = "lblFantaAdd";
            this.lblFantaAdd.Size = new System.Drawing.Size(99, 16);
            this.lblFantaAdd.TabIndex = 19;
            this.lblFantaAdd.Text = "Añadir Orden";
            // 
            // lblErrorVacio
            // 
            this.lblErrorVacio.AutoSize = true;
            this.lblErrorVacio.ForeColor = System.Drawing.Color.Yellow;
            this.lblErrorVacio.Location = new System.Drawing.Point(595, 11);
            this.lblErrorVacio.Name = "lblErrorVacio";
            this.lblErrorVacio.Size = new System.Drawing.Size(104, 13);
            this.lblErrorVacio.TabIndex = 36;
            this.lblErrorVacio.Text = "La orden esta vacia!";
            this.lblErrorVacio.Visible = false;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.fANTA_BDDataSet;
            // 
            // fANTA_BDDataSet
            // 
            this.fANTA_BDDataSet.DataSetName = "FANTA_BDDataSet";
            this.fANTA_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // fANTABDDataSetBindingSource
            // 
            this.fANTABDDataSetBindingSource.DataSource = this.fANTA_BDDataSet;
            this.fANTABDDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cliente:";
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(60, 44);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(121, 21);
            this.cbxClientes.TabIndex = 39;
            this.cbxClientes.SelectedIndexChanged += new System.EventHandler(this.cbxClientes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fecha:";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.ForeColor = System.Drawing.Color.White;
            this.lblFechaActual.Location = new System.Drawing.Point(207, 19);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(76, 13);
            this.lblFechaActual.TabIndex = 41;
            this.lblFechaActual.Text = "[Fecha Actual]";
            // 
            // dgvBDProductos
            // 
            this.dgvBDProductos.AllowUserToAddRows = false;
            this.dgvBDProductos.AllowUserToDeleteRows = false;
            this.dgvBDProductos.AllowUserToResizeColumns = false;
            this.dgvBDProductos.AllowUserToResizeRows = false;
            this.dgvBDProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBDProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.dgvBDProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(126)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBDProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBDProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBDProductos.Enabled = false;
            this.dgvBDProductos.EnableHeadersVisualStyles = false;
            this.dgvBDProductos.GridColor = System.Drawing.Color.SlateGray;
            this.dgvBDProductos.Location = new System.Drawing.Point(12, 91);
            this.dgvBDProductos.Name = "dgvBDProductos";
            this.dgvBDProductos.ReadOnly = true;
            this.dgvBDProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBDProductos.RowHeadersVisible = false;
            this.dgvBDProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvBDProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBDProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBDProductos.ShowEditingIcon = false;
            this.dgvBDProductos.Size = new System.Drawing.Size(383, 172);
            this.dgvBDProductos.TabIndex = 42;
            this.dgvBDProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBDProductos_CellClick);
            // 
            // numCantidad
            // 
            this.numCantidad.Enabled = false;
            this.numCantidad.Location = new System.Drawing.Point(117, 283);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(50, 20);
            this.numCantidad.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTipodePago);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblTotalActual);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvOrdenNueva);
            this.panel1.Controls.Add(this.lblClienteActual);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblNumeroOrden);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblFechaActual);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(401, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 347);
            this.panel1.TabIndex = 46;
            // 
            // lblTipodePago
            // 
            this.lblTipodePago.AutoSize = true;
            this.lblTipodePago.ForeColor = System.Drawing.Color.White;
            this.lblTipodePago.Location = new System.Drawing.Point(207, 43);
            this.lblTipodePago.Name = "lblTipodePago";
            this.lblTipodePago.Size = new System.Drawing.Size(23, 13);
            this.lblTipodePago.TabIndex = 50;
            this.lblTipodePago.Text = "****";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(130, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tipo de Pago:";
            // 
            // lblTotalActual
            // 
            this.lblTotalActual.AutoSize = true;
            this.lblTotalActual.ForeColor = System.Drawing.Color.White;
            this.lblTotalActual.Location = new System.Drawing.Point(44, 326);
            this.lblTotalActual.Name = "lblTotalActual";
            this.lblTotalActual.Size = new System.Drawing.Size(13, 13);
            this.lblTotalActual.TabIndex = 49;
            this.lblTotalActual.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Total: $";
            // 
            // dgvOrdenNueva
            // 
            this.dgvOrdenNueva.AllowUserToAddRows = false;
            this.dgvOrdenNueva.AllowUserToDeleteRows = false;
            this.dgvOrdenNueva.AllowUserToResizeColumns = false;
            this.dgvOrdenNueva.AllowUserToResizeRows = false;
            this.dgvOrdenNueva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenNueva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.dgvOrdenNueva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(126)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenNueva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrdenNueva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenNueva.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrdenNueva.Enabled = false;
            this.dgvOrdenNueva.EnableHeadersVisualStyles = false;
            this.dgvOrdenNueva.GridColor = System.Drawing.Color.SlateGray;
            this.dgvOrdenNueva.Location = new System.Drawing.Point(3, 63);
            this.dgvOrdenNueva.Name = "dgvOrdenNueva";
            this.dgvOrdenNueva.ReadOnly = true;
            this.dgvOrdenNueva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenNueva.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrdenNueva.RowHeadersVisible = false;
            this.dgvOrdenNueva.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvOrdenNueva.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrdenNueva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrdenNueva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrdenNueva.ShowEditingIcon = false;
            this.dgvOrdenNueva.Size = new System.Drawing.Size(290, 250);
            this.dgvOrdenNueva.TabIndex = 47;
            // 
            // lblClienteActual
            // 
            this.lblClienteActual.AutoSize = true;
            this.lblClienteActual.ForeColor = System.Drawing.Color.White;
            this.lblClienteActual.Location = new System.Drawing.Point(64, 43);
            this.lblClienteActual.Name = "lblClienteActual";
            this.lblClienteActual.Size = new System.Drawing.Size(23, 13);
            this.lblClienteActual.TabIndex = 48;
            this.lblClienteActual.Text = "****";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cliente:";
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.ForeColor = System.Drawing.Color.White;
            this.lblNumeroOrden.Location = new System.Drawing.Point(82, 19);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(14, 13);
            this.lblNumeroOrden.TabIndex = 1;
            this.lblNumeroOrden.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "No. Orden:";
            // 
            // cbxTdPago
            // 
            this.cbxTdPago.FormattingEnabled = true;
            this.cbxTdPago.Location = new System.Drawing.Point(273, 44);
            this.cbxTdPago.Name = "cbxTdPago";
            this.cbxTdPago.Size = new System.Drawing.Size(121, 21);
            this.cbxTdPago.TabIndex = 48;
            this.cbxTdPago.SelectedIndexChanged += new System.EventHandler(this.cbxTdPago_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(193, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tipo de Pago:";
            // 
            // pbxPlus
            // 
            this.pbxPlus.BackgroundImage = global::FantaApp.Properties.Resources.btnPlus;
            this.pbxPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxPlus.Enabled = false;
            this.pbxPlus.Location = new System.Drawing.Point(173, 281);
            this.pbxPlus.Name = "pbxPlus";
            this.pbxPlus.Size = new System.Drawing.Size(24, 24);
            this.pbxPlus.TabIndex = 45;
            this.pbxPlus.TabStop = false;
            this.pbxPlus.Click += new System.EventHandler(this.pbxPlus_Click);
            // 
            // pbxMinus
            // 
            this.pbxMinus.BackgroundImage = global::FantaApp.Properties.Resources.btnMinus;
            this.pbxMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxMinus.Enabled = false;
            this.pbxMinus.Location = new System.Drawing.Point(87, 281);
            this.pbxMinus.Name = "pbxMinus";
            this.pbxMinus.Size = new System.Drawing.Size(24, 24);
            this.pbxMinus.TabIndex = 44;
            this.pbxMinus.TabStop = false;
            this.pbxMinus.Click += new System.EventHandler(this.pbxMinus_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(15, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 30);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::FantaApp.Properties.Resources.btnLimpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.InitialImage = null;
            this.btnLimpiar.Location = new System.Drawing.Point(218, 335);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 32);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BackgroundImage = global::FantaApp.Properties.Resources.btnGuardar;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadir.Enabled = false;
            this.btnAñadir.InitialImage = null;
            this.btnAñadir.Location = new System.Drawing.Point(99, 335);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(88, 32);
            this.btnAñadir.TabIndex = 27;
            this.btnAñadir.TabStop = false;
            this.btnAñadir.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.btnAñadir_LoadCompleted);
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // frmVentasAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(711, 386);
            this.Controls.Add(this.cbxTdPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxPlus);
            this.Controls.Add(this.pbxMinus);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.dgvBDProductos);
            this.Controls.Add(this.cbxClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorVacio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblFantaAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentasAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Orden";
            this.Load += new System.EventHandler(this.frmVentasAdd_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fANTA_BDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fANTABDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenNueva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFantaAdd;
        private System.Windows.Forms.PictureBox btnAñadir;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblErrorVacio;
        private FANTA_BDDataSet fANTA_BDDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private FANTA_BDDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource fANTABDDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.DataGridView dgvBDProductos;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.PictureBox pbxMinus;
        private System.Windows.Forms.PictureBox pbxPlus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumeroOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClienteActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvOrdenNueva;
        private System.Windows.Forms.ComboBox cbxTdPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTipodePago;
        private System.Windows.Forms.Label label7;
    }
}