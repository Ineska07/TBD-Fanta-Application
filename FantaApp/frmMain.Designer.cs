﻿
namespace FantaApp
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblWIP = new System.Windows.Forms.Label();
            this.gbxConsultas = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenVentas = new System.Windows.Forms.PictureBox();
            this.btnOpenCompradores = new System.Windows.Forms.PictureBox();
            this.btnOpenFanta = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pbxLogotipo = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.gbxConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenCompradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWIP
            // 
            this.lblWIP.AutoSize = true;
            this.lblWIP.BackColor = System.Drawing.Color.Transparent;
            this.lblWIP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWIP.Location = new System.Drawing.Point(12, 317);
            this.lblWIP.Name = "lblWIP";
            this.lblWIP.Size = new System.Drawing.Size(92, 13);
            this.lblWIP.TabIndex = 5;
            this.lblWIP.Text = "*Work in Progress";
            // 
            // gbxConsultas
            // 
            this.gbxConsultas.BackColor = System.Drawing.Color.Transparent;
            this.gbxConsultas.Controls.Add(this.pictureBox3);
            this.gbxConsultas.Controls.Add(this.pictureBox2);
            this.gbxConsultas.Controls.Add(this.pictureBox1);
            this.gbxConsultas.Controls.Add(this.btnOpenVentas);
            this.gbxConsultas.Controls.Add(this.btnOpenCompradores);
            this.gbxConsultas.Controls.Add(this.btnOpenFanta);
            this.gbxConsultas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxConsultas.Location = new System.Drawing.Point(12, 118);
            this.gbxConsultas.Name = "gbxConsultas";
            this.gbxConsultas.Size = new System.Drawing.Size(474, 193);
            this.gbxConsultas.TabIndex = 7;
            this.gbxConsultas.TabStop = false;
            this.gbxConsultas.Text = "Consultas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(341, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FantaApp.Properties.Resources.btnOrdenes;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(154, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 35);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FantaApp.Properties.Resources.btnEmpleados;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 35);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenVentas
            // 
            this.btnOpenVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenVentas.BackgroundImage = global::FantaApp.Properties.Resources.btnVentas;
            this.btnOpenVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenVentas.InitialImage = null;
            this.btnOpenVentas.Location = new System.Drawing.Point(277, 42);
            this.btnOpenVentas.Name = "btnOpenVentas";
            this.btnOpenVentas.Size = new System.Drawing.Size(93, 35);
            this.btnOpenVentas.TabIndex = 11;
            this.btnOpenVentas.TabStop = false;
            this.btnOpenVentas.Click += new System.EventHandler(this.btnOpenVentas_Click);
            // 
            // btnOpenCompradores
            // 
            this.btnOpenCompradores.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenCompradores.BackgroundImage = global::FantaApp.Properties.Resources.btnCompradores;
            this.btnOpenCompradores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenCompradores.InitialImage = null;
            this.btnOpenCompradores.Location = new System.Drawing.Point(121, 42);
            this.btnOpenCompradores.Name = "btnOpenCompradores";
            this.btnOpenCompradores.Size = new System.Drawing.Size(133, 35);
            this.btnOpenCompradores.TabIndex = 10;
            this.btnOpenCompradores.TabStop = false;
            this.btnOpenCompradores.Click += new System.EventHandler(this.btnOpenCompradores_Click);
            // 
            // btnOpenFanta
            // 
            this.btnOpenFanta.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFanta.BackgroundImage = global::FantaApp.Properties.Resources.BtnFanta;
            this.btnOpenFanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFanta.InitialImage = null;
            this.btnOpenFanta.Location = new System.Drawing.Point(15, 42);
            this.btnOpenFanta.Name = "btnOpenFanta";
            this.btnOpenFanta.Size = new System.Drawing.Size(85, 35);
            this.btnOpenFanta.TabIndex = 9;
            this.btnOpenFanta.TabStop = false;
            this.btnOpenFanta.Click += new System.EventHandler(this.btnOpenFanta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(409, 324);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbxLogotipo
            // 
            this.pbxLogotipo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogotipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogotipo.BackgroundImage")));
            this.pbxLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogotipo.InitialImage = null;
            this.pbxLogotipo.Location = new System.Drawing.Point(170, 12);
            this.pbxLogotipo.Name = "pbxLogotipo";
            this.pbxLogotipo.Size = new System.Drawing.Size(160, 100);
            this.pbxLogotipo.TabIndex = 4;
            this.pbxLogotipo.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = global::FantaApp.Properties.Resources.btnHelp;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelp.InitialImage = null;
            this.btnHelp.Location = new System.Drawing.Point(380, 327);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(20, 20);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 369);
            this.Controls.Add(this.gbxConsultas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblWIP);
            this.Controls.Add(this.pbxLogotipo);
            this.Controls.Add(this.btnHelp);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fanta";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenCompradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox pbxLogotipo;
        private System.Windows.Forms.Label lblWIP;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.GroupBox gbxConsultas;
        private System.Windows.Forms.PictureBox btnOpenVentas;
        private System.Windows.Forms.PictureBox btnOpenCompradores;
        private System.Windows.Forms.PictureBox btnOpenFanta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
