namespace FantaApp
{
    partial class frmProveedorMod
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.lblErrorVacio = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.lblFantaAdd = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblProveedorDetalles = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblProveedorDireccion = new System.Windows.Forms.Label();
            this.lblProveedorEmail = new System.Windows.Forms.Label();
            this.lblProveedorTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProveedorNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(38, 53);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(99, 20);
            this.txtID.TabIndex = 62;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(14, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 63;
            this.lblID.Text = "ID";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = global::FantaApp.Properties.Resources.btnGuardar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.InitialImage = null;
            this.btnModificar.Location = new System.Drawing.Point(17, 268);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 40);
            this.btnModificar.TabIndex = 61;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(222, 279);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 29);
            this.btnSalir.TabIndex = 60;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblErrorVacio
            // 
            this.lblErrorVacio.AutoSize = true;
            this.lblErrorVacio.ForeColor = System.Drawing.Color.Yellow;
            this.lblErrorVacio.Location = new System.Drawing.Point(137, 86);
            this.lblErrorVacio.Name = "lblErrorVacio";
            this.lblErrorVacio.Size = new System.Drawing.Size(164, 13);
            this.lblErrorVacio.TabIndex = 59;
            this.lblErrorVacio.Text = "Uno o mas campos estan vacios!";
            this.lblErrorVacio.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::FantaApp.Properties.Resources.btnLimpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.InitialImage = null;
            this.btnLimpiar.Location = new System.Drawing.Point(138, 268);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 40);
            this.btnLimpiar.TabIndex = 58;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblFantaAdd
            // 
            this.lblFantaAdd.AutoSize = true;
            this.lblFantaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantaAdd.ForeColor = System.Drawing.Color.White;
            this.lblFantaAdd.Location = new System.Drawing.Point(14, 16);
            this.lblFantaAdd.Name = "lblFantaAdd";
            this.lblFantaAdd.Size = new System.Drawing.Size(102, 16);
            this.lblFantaAdd.TabIndex = 55;
            this.lblFantaAdd.Text = "Modificar Fila";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(57, 206);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(243, 20);
            this.txtDetalles.TabIndex = 68;
            // 
            // lblProveedorDetalles
            // 
            this.lblProveedorDetalles.AutoSize = true;
            this.lblProveedorDetalles.ForeColor = System.Drawing.Color.White;
            this.lblProveedorDetalles.Location = new System.Drawing.Point(5, 209);
            this.lblProveedorDetalles.Name = "lblProveedorDetalles";
            this.lblProveedorDetalles.Size = new System.Drawing.Size(45, 13);
            this.lblProveedorDetalles.TabIndex = 73;
            this.lblProveedorDetalles.Text = "Detalles";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(57, 128);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 20);
            this.txtDireccion.TabIndex = 65;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 20);
            this.txtEmail.TabIndex = 67;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(57, 154);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(243, 20);
            this.txtTelefono.TabIndex = 66;
            // 
            // lblProveedorDireccion
            // 
            this.lblProveedorDireccion.AutoSize = true;
            this.lblProveedorDireccion.ForeColor = System.Drawing.Color.White;
            this.lblProveedorDireccion.Location = new System.Drawing.Point(5, 132);
            this.lblProveedorDireccion.Name = "lblProveedorDireccion";
            this.lblProveedorDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblProveedorDireccion.TabIndex = 72;
            this.lblProveedorDireccion.Text = "Direccion";
            // 
            // lblProveedorEmail
            // 
            this.lblProveedorEmail.AutoSize = true;
            this.lblProveedorEmail.ForeColor = System.Drawing.Color.White;
            this.lblProveedorEmail.Location = new System.Drawing.Point(7, 183);
            this.lblProveedorEmail.Name = "lblProveedorEmail";
            this.lblProveedorEmail.Size = new System.Drawing.Size(32, 13);
            this.lblProveedorEmail.TabIndex = 71;
            this.lblProveedorEmail.Text = "Email";
            // 
            // lblProveedorTelefono
            // 
            this.lblProveedorTelefono.AutoSize = true;
            this.lblProveedorTelefono.ForeColor = System.Drawing.Color.White;
            this.lblProveedorTelefono.Location = new System.Drawing.Point(5, 157);
            this.lblProveedorTelefono.Name = "lblProveedorTelefono";
            this.lblProveedorTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblProveedorTelefono.TabIndex = 70;
            this.lblProveedorTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(58, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 20);
            this.txtNombre.TabIndex = 64;
            // 
            // lblProveedorNombre
            // 
            this.lblProveedorNombre.AutoSize = true;
            this.lblProveedorNombre.ForeColor = System.Drawing.Color.White;
            this.lblProveedorNombre.Location = new System.Drawing.Point(6, 105);
            this.lblProveedorNombre.Name = "lblProveedorNombre";
            this.lblProveedorNombre.Size = new System.Drawing.Size(44, 13);
            this.lblProveedorNombre.TabIndex = 69;
            this.lblProveedorNombre.Text = "Nombre";
            // 
            // frmProveedorMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(313, 325);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.lblProveedorDetalles);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblProveedorDireccion);
            this.Controls.Add(this.lblProveedorEmail);
            this.Controls.Add(this.lblProveedorTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblProveedorNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblErrorVacio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblFantaAdd);
            this.Name = "frmProveedorMod";
            this.Text = "Modificar: Proveedor";
            this.Load += new System.EventHandler(this.frmProveedorMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblErrorVacio;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.Label lblFantaAdd;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label lblProveedorDetalles;
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