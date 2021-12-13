namespace FantaApp
{
    partial class frmProveedoresAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedoresAdd));
            this.lblErrorVacio = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblProveedorDetalles = new System.Windows.Forms.Label();
            this.lblFantaAdd = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblProveedorDireccion = new System.Windows.Forms.Label();
            this.lblProveedorEmail = new System.Windows.Forms.Label();
            this.lblProveedorTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProveedorNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.btnAñadir = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorVacio
            // 
            this.lblErrorVacio.AutoSize = true;
            this.lblErrorVacio.ForeColor = System.Drawing.Color.Yellow;
            this.lblErrorVacio.Location = new System.Drawing.Point(161, 47);
            this.lblErrorVacio.Name = "lblErrorVacio";
            this.lblErrorVacio.Size = new System.Drawing.Size(164, 13);
            this.lblErrorVacio.TabIndex = 42;
            this.lblErrorVacio.Text = "Uno o mas campos estan vacios!";
            this.lblErrorVacio.Visible = false;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(65, 173);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(260, 20);
            this.txtDetalles.TabIndex = 5;
            // 
            // lblProveedorDetalles
            // 
            this.lblProveedorDetalles.AutoSize = true;
            this.lblProveedorDetalles.ForeColor = System.Drawing.Color.White;
            this.lblProveedorDetalles.Location = new System.Drawing.Point(13, 176);
            this.lblProveedorDetalles.Name = "lblProveedorDetalles";
            this.lblProveedorDetalles.Size = new System.Drawing.Size(45, 13);
            this.lblProveedorDetalles.TabIndex = 38;
            this.lblProveedorDetalles.Text = "Detalles";
            // 
            // lblFantaAdd
            // 
            this.lblFantaAdd.AutoSize = true;
            this.lblFantaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantaAdd.ForeColor = System.Drawing.Color.White;
            this.lblFantaAdd.Location = new System.Drawing.Point(13, 14);
            this.lblFantaAdd.Name = "lblFantaAdd";
            this.lblFantaAdd.Size = new System.Drawing.Size(160, 16);
            this.lblFantaAdd.TabIndex = 37;
            this.lblFantaAdd.Text = "Añadir a Proveedores";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(65, 95);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(260, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(66, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(65, 121);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(260, 20);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTamaño_TextChanged);
            // 
            // lblProveedorDireccion
            // 
            this.lblProveedorDireccion.AutoSize = true;
            this.lblProveedorDireccion.ForeColor = System.Drawing.Color.White;
            this.lblProveedorDireccion.Location = new System.Drawing.Point(13, 99);
            this.lblProveedorDireccion.Name = "lblProveedorDireccion";
            this.lblProveedorDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblProveedorDireccion.TabIndex = 35;
            this.lblProveedorDireccion.Text = "Direccion";
            // 
            // lblProveedorEmail
            // 
            this.lblProveedorEmail.AutoSize = true;
            this.lblProveedorEmail.ForeColor = System.Drawing.Color.White;
            this.lblProveedorEmail.Location = new System.Drawing.Point(15, 150);
            this.lblProveedorEmail.Name = "lblProveedorEmail";
            this.lblProveedorEmail.Size = new System.Drawing.Size(32, 13);
            this.lblProveedorEmail.TabIndex = 34;
            this.lblProveedorEmail.Text = "Email";
            // 
            // lblProveedorTelefono
            // 
            this.lblProveedorTelefono.AutoSize = true;
            this.lblProveedorTelefono.ForeColor = System.Drawing.Color.White;
            this.lblProveedorTelefono.Location = new System.Drawing.Point(13, 124);
            this.lblProveedorTelefono.Name = "lblProveedorTelefono";
            this.lblProveedorTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblProveedorTelefono.TabIndex = 33;
            this.lblProveedorTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblProveedorNombre
            // 
            this.lblProveedorNombre.AutoSize = true;
            this.lblProveedorNombre.ForeColor = System.Drawing.Color.White;
            this.lblProveedorNombre.Location = new System.Drawing.Point(14, 72);
            this.lblProveedorNombre.Name = "lblProveedorNombre";
            this.lblProveedorNombre.Size = new System.Drawing.Size(44, 13);
            this.lblProveedorNombre.TabIndex = 32;
            this.lblProveedorNombre.Text = "Nombre";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::FantaApp.Properties.Resources.btnLimpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.InitialImage = null;
            this.btnLimpiar.Location = new System.Drawing.Point(111, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 32);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BackgroundImage = global::FantaApp.Properties.Resources.btnGuardar;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadir.InitialImage = null;
            this.btnAñadir.Location = new System.Drawing.Point(17, 212);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(88, 32);
            this.btnAñadir.TabIndex = 40;
            this.btnAñadir.TabStop = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(261, 214);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 30);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProveedoresAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(338, 258);
            this.Controls.Add(this.lblErrorVacio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.lblProveedorDetalles);
            this.Controls.Add(this.lblFantaAdd);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblProveedorDireccion);
            this.Controls.Add(this.lblProveedorEmail);
            this.Controls.Add(this.lblProveedorTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblProveedorNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedoresAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir: Proveedores";
            this.Load += new System.EventHandler(this.frmProveedoresAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorVacio;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.PictureBox btnAñadir;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label lblProveedorDetalles;
        private System.Windows.Forms.Label lblFantaAdd;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblProveedorDireccion;
        private System.Windows.Forms.Label lblProveedorEmail;
        private System.Windows.Forms.Label lblProveedorTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblProveedorNombre;
    }
}