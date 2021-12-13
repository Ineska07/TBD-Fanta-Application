
namespace FantaApp
{
    partial class frmEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.dgvBDEmpleados = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.btnAñadir = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.pbxLogotipo = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBDEmpleados
            // 
            this.dgvBDEmpleados.AllowUserToAddRows = false;
            this.dgvBDEmpleados.AllowUserToDeleteRows = false;
            this.dgvBDEmpleados.AllowUserToResizeColumns = false;
            this.dgvBDEmpleados.AllowUserToResizeRows = false;
            this.dgvBDEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBDEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.dgvBDEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(126)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBDEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBDEmpleados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBDEmpleados.EnableHeadersVisualStyles = false;
            this.dgvBDEmpleados.GridColor = System.Drawing.Color.SlateGray;
            this.dgvBDEmpleados.Location = new System.Drawing.Point(10, 67);
            this.dgvBDEmpleados.Name = "dgvBDEmpleados";
            this.dgvBDEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBDEmpleados.RowHeadersVisible = false;
            this.dgvBDEmpleados.RowHeadersWidth = 51;
            this.dgvBDEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvBDEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBDEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBDEmpleados.ShowEditingIcon = false;
            this.dgvBDEmpleados.Size = new System.Drawing.Size(591, 277);
            this.dgvBDEmpleados.TabIndex = 31;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::FantaApp.Properties.Resources.btnPrint;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.Location = new System.Drawing.Point(289, 350);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(44, 40);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.BackgroundImage = global::FantaApp.Properties.Resources.btnEliminar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.InitialImage = null;
            this.btnBorrar.Location = new System.Drawing.Point(230, 349);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(44, 40);
            this.btnBorrar.TabIndex = 32;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(536, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 30);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = global::FantaApp.Properties.Resources.btnHelp;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelp.InitialImage = null;
            this.btnHelp.Location = new System.Drawing.Point(500, 360);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(29, 30);
            this.btnHelp.TabIndex = 29;
            this.btnHelp.TabStop = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BackgroundImage = global::FantaApp.Properties.Resources.btnAñadir;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadir.InitialImage = null;
            this.btnAñadir.Location = new System.Drawing.Point(121, 350);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(99, 40);
            this.btnAñadir.TabIndex = 28;
            this.btnAñadir.TabStop = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = global::FantaApp.Properties.Resources.btnModificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.InitialImage = null;
            this.btnModificar.Location = new System.Drawing.Point(10, 350);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 40);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // pbxLogotipo
            // 
            this.pbxLogotipo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogotipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogotipo.BackgroundImage")));
            this.pbxLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogotipo.InitialImage = null;
            this.pbxLogotipo.Location = new System.Drawing.Point(10, 11);
            this.pbxLogotipo.Name = "pbxLogotipo";
            this.pbxLogotipo.Size = new System.Drawing.Size(67, 43);
            this.pbxLogotipo.TabIndex = 10;
            this.pbxLogotipo.TabStop = false;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(615, 401);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvBDEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pbxLogotipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogotipo;
        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.PictureBox btnAñadir;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.DataGridView dgvBDEmpleados;
        private System.Windows.Forms.PictureBox btnBorrar;
        private System.Windows.Forms.PictureBox btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}