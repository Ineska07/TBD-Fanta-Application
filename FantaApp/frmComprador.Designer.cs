
namespace FantaApp
{
    partial class frmComprador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprador));
            this.gbxCompradorAñadir = new System.Windows.Forms.GroupBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNombreComprador = new System.Windows.Forms.TextBox();
            this.lblNombreComprador = new System.Windows.Forms.Label();
            this.dgvBDComprador = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.btnAñadir = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.pbxLogotipo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.gbxCompradorAñadir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDComprador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCompradorAñadir
            // 
            this.gbxCompradorAñadir.BackColor = System.Drawing.Color.Transparent;
            this.gbxCompradorAñadir.Controls.Add(this.btnAñadir);
            this.gbxCompradorAñadir.Controls.Add(this.btnLimpiar);
            this.gbxCompradorAñadir.Controls.Add(this.tbxDireccion);
            this.gbxCompradorAñadir.Controls.Add(this.pbxLogotipo);
            this.gbxCompradorAñadir.Controls.Add(this.tbxTelefono);
            this.gbxCompradorAñadir.Controls.Add(this.label3);
            this.gbxCompradorAñadir.Controls.Add(this.label1);
            this.gbxCompradorAñadir.Controls.Add(this.tbxNombreComprador);
            this.gbxCompradorAñadir.Controls.Add(this.lblNombreComprador);
            this.gbxCompradorAñadir.ForeColor = System.Drawing.Color.White;
            this.gbxCompradorAñadir.Location = new System.Drawing.Point(14, 12);
            this.gbxCompradorAñadir.Name = "gbxCompradorAñadir";
            this.gbxCompradorAñadir.Size = new System.Drawing.Size(573, 104);
            this.gbxCompradorAñadir.TabIndex = 19;
            this.gbxCompradorAñadir.TabStop = false;
            this.gbxCompradorAñadir.Text = "Añadir Comprador";
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(69, 70);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(138, 20);
            this.tbxDireccion.TabIndex = 7;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(268, 26);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(141, 20);
            this.tbxTelefono.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teléfono";
            // 
            // tbxNombreComprador
            // 
            this.tbxNombreComprador.Location = new System.Drawing.Point(58, 26);
            this.tbxNombreComprador.Name = "tbxNombreComprador";
            this.tbxNombreComprador.Size = new System.Drawing.Size(149, 20);
            this.tbxNombreComprador.TabIndex = 1;
            // 
            // lblNombreComprador
            // 
            this.lblNombreComprador.AutoSize = true;
            this.lblNombreComprador.Location = new System.Drawing.Point(8, 29);
            this.lblNombreComprador.Name = "lblNombreComprador";
            this.lblNombreComprador.Size = new System.Drawing.Size(44, 13);
            this.lblNombreComprador.TabIndex = 0;
            this.lblNombreComprador.Text = "Nombre";
            // 
            // dgvBDComprador
            // 
            this.dgvBDComprador.AllowUserToAddRows = false;
            this.dgvBDComprador.AllowUserToDeleteRows = false;
            this.dgvBDComprador.AllowUserToResizeColumns = false;
            this.dgvBDComprador.AllowUserToResizeRows = false;
            this.dgvBDComprador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBDComprador.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.dgvBDComprador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(126)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDComprador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBDComprador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBDComprador.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBDComprador.EnableHeadersVisualStyles = false;
            this.dgvBDComprador.GridColor = System.Drawing.Color.SlateGray;
            this.dgvBDComprador.Location = new System.Drawing.Point(15, 132);
            this.dgvBDComprador.Name = "dgvBDComprador";
            this.dgvBDComprador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDComprador.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBDComprador.RowHeadersVisible = false;
            this.dgvBDComprador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvBDComprador.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBDComprador.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBDComprador.ShowEditingIcon = false;
            this.dgvBDComprador.Size = new System.Drawing.Size(572, 246);
            this.dgvBDComprador.TabIndex = 18;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = global::FantaApp.Properties.Resources.btnModificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.InitialImage = null;
            this.btnModificar.Location = new System.Drawing.Point(14, 384);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 40);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.TabStop = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BackgroundImage = global::FantaApp.Properties.Resources.btnAñadir;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadir.InitialImage = null;
            this.btnAñadir.Location = new System.Drawing.Point(331, 70);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(78, 20);
            this.btnAñadir.TabIndex = 13;
            this.btnAñadir.TabStop = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::FantaApp.Properties.Resources.btnLimpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.InitialImage = null;
            this.btnLimpiar.Location = new System.Drawing.Point(231, 70);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(66, 20);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pbxLogotipo
            // 
            this.pbxLogotipo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogotipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogotipo.BackgroundImage")));
            this.pbxLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogotipo.InitialImage = null;
            this.pbxLogotipo.Location = new System.Drawing.Point(445, 17);
            this.pbxLogotipo.Name = "pbxLogotipo";
            this.pbxLogotipo.Size = new System.Drawing.Size(109, 73);
            this.pbxLogotipo.TabIndex = 17;
            this.pbxLogotipo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(510, 398);
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
            this.btnHelp.Location = new System.Drawing.Point(481, 408);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(20, 20);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.TabStop = false;
            // 
            // frmComprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbxCompradorAñadir);
            this.Controls.Add(this.dgvBDComprador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHelp);
            this.Name = "frmComprador";
            this.Text = "frmComprador";
            this.Load += new System.EventHandler(this.frmComprador_Load);
            this.gbxCompradorAñadir.ResumeLayout(false);
            this.gbxCompradorAñadir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDComprador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.GroupBox gbxCompradorAñadir;
        private System.Windows.Forms.PictureBox btnAñadir;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNombreComprador;
        private System.Windows.Forms.Label lblNombreComprador;
        private System.Windows.Forms.DataGridView dgvBDComprador;
        private System.Windows.Forms.PictureBox pbxLogotipo;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnHelp;
    }
}