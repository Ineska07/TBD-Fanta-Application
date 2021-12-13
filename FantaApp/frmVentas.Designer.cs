
namespace FantaApp
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.dgvBDVentas = new System.Windows.Forms.DataGridView();
            this.dgvVentasDetalles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalActual = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTdPago = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblOrdenID = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pbxCotizacion = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.PictureBox();
            this.pbxBorrar = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.pbxLogotipo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.btnAñadir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasDetalles)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBDVentas
            // 
            this.dgvBDVentas.AllowUserToAddRows = false;
            this.dgvBDVentas.AllowUserToDeleteRows = false;
            this.dgvBDVentas.AllowUserToResizeColumns = false;
            this.dgvBDVentas.AllowUserToResizeRows = false;
            this.dgvBDVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBDVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.dgvBDVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(126)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBDVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBDVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBDVentas.EnableHeadersVisualStyles = false;
            this.dgvBDVentas.GridColor = System.Drawing.Color.SlateGray;
            this.dgvBDVentas.Location = new System.Drawing.Point(17, 132);
            this.dgvBDVentas.Name = "dgvBDVentas";
            this.dgvBDVentas.ReadOnly = true;
            this.dgvBDVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBDVentas.RowHeadersVisible = false;
            this.dgvBDVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvBDVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBDVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBDVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBDVentas.ShowEditingIcon = false;
            this.dgvBDVentas.Size = new System.Drawing.Size(300, 246);
            this.dgvBDVentas.TabIndex = 18;
            this.dgvBDVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBDVentas_CellClick);
            this.dgvBDVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBDVentas_CellContentClick);
            // 
            // dgvVentasDetalles
            // 
            this.dgvVentasDetalles.AllowUserToAddRows = false;
            this.dgvVentasDetalles.AllowUserToDeleteRows = false;
            this.dgvVentasDetalles.AllowUserToResizeColumns = false;
            this.dgvVentasDetalles.AllowUserToResizeRows = false;
            this.dgvVentasDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentasDetalles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.dgvVentasDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(126)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentasDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentasDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentasDetalles.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentasDetalles.EnableHeadersVisualStyles = false;
            this.dgvVentasDetalles.GridColor = System.Drawing.Color.SlateGray;
            this.dgvVentasDetalles.Location = new System.Drawing.Point(0, 68);
            this.dgvVentasDetalles.Name = "dgvVentasDetalles";
            this.dgvVentasDetalles.ReadOnly = true;
            this.dgvVentasDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentasDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVentasDetalles.RowHeadersVisible = false;
            this.dgvVentasDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvVentasDetalles.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVentasDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVentasDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasDetalles.ShowEditingIcon = false;
            this.dgvVentasDetalles.Size = new System.Drawing.Size(447, 177);
            this.dgvVentasDetalles.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total:";
            // 
            // lblTotalActual
            // 
            this.lblTotalActual.AutoSize = true;
            this.lblTotalActual.ForeColor = System.Drawing.Color.White;
            this.lblTotalActual.Location = new System.Drawing.Point(44, 253);
            this.lblTotalActual.Name = "lblTotalActual";
            this.lblTotalActual.Size = new System.Drawing.Size(23, 13);
            this.lblTotalActual.TabIndex = 23;
            this.lblTotalActual.Text = "****";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTdPago);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lblOrdenID);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvVentasDetalles);
            this.panel1.Controls.Add(this.lblTotalActual);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(341, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 272);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(363, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 20);
            this.panel2.TabIndex = 32;
            // 
            // lblTdPago
            // 
            this.lblTdPago.AutoSize = true;
            this.lblTdPago.ForeColor = System.Drawing.Color.White;
            this.lblTdPago.Location = new System.Drawing.Point(306, 41);
            this.lblTdPago.Name = "lblTdPago";
            this.lblTdPago.Size = new System.Drawing.Size(23, 13);
            this.lblTdPago.TabIndex = 31;
            this.lblTdPago.Text = "****";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(68, 41);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(23, 13);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "****";
            // 
            // lblOrdenID
            // 
            this.lblOrdenID.AutoSize = true;
            this.lblOrdenID.ForeColor = System.Drawing.Color.White;
            this.lblOrdenID.Location = new System.Drawing.Point(70, 11);
            this.lblOrdenID.Name = "lblOrdenID";
            this.lblOrdenID.Size = new System.Drawing.Size(23, 13);
            this.lblOrdenID.TabIndex = 29;
            this.lblOrdenID.Text = "****";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(306, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(23, 13);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "****";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(226, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tipo de Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(260, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "No. Orden:";
            // 
            // pbxCotizacion
            // 
            this.pbxCotizacion.BackgroundImage = global::FantaApp.Properties.Resources.Cotizacion_IMG;
            this.pbxCotizacion.Location = new System.Drawing.Point(17, 480);
            this.pbxCotizacion.Name = "pbxCotizacion";
            this.pbxCotizacion.Size = new System.Drawing.Size(268, 88);
            this.pbxCotizacion.TabIndex = 27;
            this.pbxCotizacion.TabStop = false;
            this.pbxCotizacion.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::FantaApp.Properties.Resources.btnPrint;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.InitialImage = null;
            this.btnImprimir.Location = new System.Drawing.Point(521, 19);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(78, 69);
            this.btnImprimir.TabIndex = 26;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pbxBorrar
            // 
            this.pbxBorrar.BackColor = System.Drawing.Color.Transparent;
            this.pbxBorrar.BackgroundImage = global::FantaApp.Properties.Resources.btnEliminar;
            this.pbxBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBorrar.InitialImage = null;
            this.pbxBorrar.Location = new System.Drawing.Point(426, 19);
            this.pbxBorrar.Name = "pbxBorrar";
            this.pbxBorrar.Size = new System.Drawing.Size(78, 69);
            this.pbxBorrar.TabIndex = 25;
            this.pbxBorrar.TabStop = false;
            this.pbxBorrar.Click += new System.EventHandler(this.pbxBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = global::FantaApp.Properties.Resources.btnModificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.InitialImage = null;
            this.btnModificar.Location = new System.Drawing.Point(200, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(204, 69);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pbxLogotipo
            // 
            this.pbxLogotipo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogotipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogotipo.BackgroundImage")));
            this.pbxLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogotipo.InitialImage = null;
            this.pbxLogotipo.Location = new System.Drawing.Point(615, 19);
            this.pbxLogotipo.Name = "pbxLogotipo";
            this.pbxLogotipo.Size = new System.Drawing.Size(157, 95);
            this.pbxLogotipo.TabIndex = 17;
            this.pbxLogotipo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(711, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 40);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = global::FantaApp.Properties.Resources.btnHelp;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelp.InitialImage = null;
            this.btnHelp.Location = new System.Drawing.Point(682, 408);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(20, 20);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.TabStop = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BackgroundImage = global::FantaApp.Properties.Resources.btnAñadir;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadir.InitialImage = null;
            this.btnAñadir.Location = new System.Drawing.Point(17, 19);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(160, 69);
            this.btnAñadir.TabIndex = 13;
            this.btnAñadir.TabStop = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxCotizacion);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pbxBorrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvBDVentas);
            this.Controls.Add(this.pbxLogotipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAñadir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasDetalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnAñadir;
        private System.Windows.Forms.DataGridView dgvBDVentas;
        private System.Windows.Forms.PictureBox pbxLogotipo;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.DataGridView dgvVentasDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalActual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTdPago;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblOrdenID;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxBorrar;
        private System.Windows.Forms.PictureBox btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pbxCotizacion;
    }
}