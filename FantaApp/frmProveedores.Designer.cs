﻿
namespace FantaApp
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.dgvBDProveedores = new System.Windows.Forms.DataGridView();
            this.pbxLogotipo = new System.Windows.Forms.PictureBox();
            this.btnAñadir = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBDProveedores
            // 
            this.dgvBDProveedores.AllowUserToAddRows = false;
            this.dgvBDProveedores.AllowUserToDeleteRows = false;
            this.dgvBDProveedores.AllowUserToResizeColumns = false;
            this.dgvBDProveedores.AllowUserToResizeRows = false;
            this.dgvBDProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBDProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.dgvBDProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(126)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBDProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBDProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBDProveedores.EnableHeadersVisualStyles = false;
            this.dgvBDProveedores.GridColor = System.Drawing.Color.SlateGray;
            this.dgvBDProveedores.Location = new System.Drawing.Point(16, 100);
            this.dgvBDProveedores.Name = "dgvBDProveedores";
            this.dgvBDProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBDProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBDProveedores.RowHeadersVisible = false;
            this.dgvBDProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvBDProveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBDProveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBDProveedores.ShowEditingIcon = false;
            this.dgvBDProveedores.Size = new System.Drawing.Size(844, 277);
            this.dgvBDProveedores.TabIndex = 25;
            // 
            // pbxLogotipo
            // 
            this.pbxLogotipo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogotipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogotipo.BackgroundImage")));
            this.pbxLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogotipo.InitialImage = null;
            this.pbxLogotipo.Location = new System.Drawing.Point(377, 18);
            this.pbxLogotipo.Name = "pbxLogotipo";
            this.pbxLogotipo.Size = new System.Drawing.Size(121, 69);
            this.pbxLogotipo.TabIndex = 24;
            this.pbxLogotipo.TabStop = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BackgroundImage = global::FantaApp.Properties.Resources.btnAñadir;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadir.InitialImage = null;
            this.btnAñadir.Location = new System.Drawing.Point(127, 383);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(99, 40);
            this.btnAñadir.TabIndex = 21;
            this.btnAñadir.TabStop = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = global::FantaApp.Properties.Resources.btnModificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.InitialImage = null;
            this.btnModificar.Location = new System.Drawing.Point(16, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 40);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(795, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 30);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = global::FantaApp.Properties.Resources.btnHelp;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelp.InitialImage = null;
            this.btnHelp.Location = new System.Drawing.Point(760, 383);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(29, 30);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.BackgroundImage = global::FantaApp.Properties.Resources.btnEliminar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.InitialImage = null;
            this.btnBorrar.Location = new System.Drawing.Point(237, 383);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(44, 40);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::FantaApp.Properties.Resources.btnPrint;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.InitialImage = null;
            this.btnImprimir.Location = new System.Drawing.Point(297, 383);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(44, 40);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(872, 435);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pbxLogotipo);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvBDProveedores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogotipo;
        private System.Windows.Forms.PictureBox btnAñadir;
        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.DataGridView dgvBDProveedores;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnBorrar;
        private System.Windows.Forms.PictureBox btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}