
namespace FantaApp
{
    partial class frmEmpleadosMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadosMod));
            this.lblFantaMod = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblErrorVacio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDRol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProveedorEmail = new System.Windows.Forms.Label();
            this.lblProveedorTelefono = new System.Windows.Forms.Label();
            this.lblProveedorDireccion = new System.Windows.Forms.Label();
            this.lblProveedorNombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFantaMod
            // 
            this.lblFantaMod.AutoSize = true;
            this.lblFantaMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantaMod.ForeColor = System.Drawing.Color.White;
            this.lblFantaMod.Location = new System.Drawing.Point(13, 42);
            this.lblFantaMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFantaMod.Name = "lblFantaMod";
            this.lblFantaMod.Size = new System.Drawing.Size(87, 20);
            this.lblFantaMod.TabIndex = 39;
            this.lblFantaMod.Text = "Modificar";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(36, 82);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 64;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(65, 82);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(131, 22);
            this.txtID.TabIndex = 65;
            // 
            // lblErrorVacio
            // 
            this.lblErrorVacio.AutoSize = true;
            this.lblErrorVacio.ForeColor = System.Drawing.Color.Yellow;
            this.lblErrorVacio.Location = new System.Drawing.Point(176, 115);
            this.lblErrorVacio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorVacio.Name = "lblErrorVacio";
            this.lblErrorVacio.Size = new System.Drawing.Size(215, 17);
            this.lblErrorVacio.TabIndex = 85;
            this.lblErrorVacio.Text = "Uno o mas campos estan vacios!";
            this.lblErrorVacio.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "ID Rol";
            // 
            // txtIDRol
            // 
            this.txtIDRol.Location = new System.Drawing.Point(139, 331);
            this.txtIDRol.Name = "txtIDRol";
            this.txtIDRol.Size = new System.Drawing.Size(252, 22);
            this.txtIDRol.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "Apellido";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(139, 303);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(252, 22);
            this.txtContraseña.TabIndex = 76;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(139, 275);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(252, 22);
            this.txtUsuario.TabIndex = 75;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 22);
            this.txtEmail.TabIndex = 74;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(139, 219);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(252, 22);
            this.txtTelefono.TabIndex = 73;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(139, 191);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(252, 22);
            this.txtDireccion.TabIndex = 72;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(139, 163);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(252, 22);
            this.txtApellido.TabIndex = 71;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 22);
            this.txtNombre.TabIndex = 70;
            // 
            // lblProveedorEmail
            // 
            this.lblProveedorEmail.AutoSize = true;
            this.lblProveedorEmail.ForeColor = System.Drawing.Color.White;
            this.lblProveedorEmail.Location = new System.Drawing.Point(36, 250);
            this.lblProveedorEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedorEmail.Name = "lblProveedorEmail";
            this.lblProveedorEmail.Size = new System.Drawing.Size(42, 17);
            this.lblProveedorEmail.TabIndex = 69;
            this.lblProveedorEmail.Text = "Email";
            // 
            // lblProveedorTelefono
            // 
            this.lblProveedorTelefono.AutoSize = true;
            this.lblProveedorTelefono.ForeColor = System.Drawing.Color.White;
            this.lblProveedorTelefono.Location = new System.Drawing.Point(36, 222);
            this.lblProveedorTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedorTelefono.Name = "lblProveedorTelefono";
            this.lblProveedorTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblProveedorTelefono.TabIndex = 68;
            this.lblProveedorTelefono.Text = "Telefono";
            // 
            // lblProveedorDireccion
            // 
            this.lblProveedorDireccion.AutoSize = true;
            this.lblProveedorDireccion.ForeColor = System.Drawing.Color.White;
            this.lblProveedorDireccion.Location = new System.Drawing.Point(36, 194);
            this.lblProveedorDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedorDireccion.Name = "lblProveedorDireccion";
            this.lblProveedorDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblProveedorDireccion.TabIndex = 67;
            this.lblProveedorDireccion.Text = "Direccion";
            // 
            // lblProveedorNombre
            // 
            this.lblProveedorNombre.AutoSize = true;
            this.lblProveedorNombre.ForeColor = System.Drawing.Color.White;
            this.lblProveedorNombre.Location = new System.Drawing.Point(36, 135);
            this.lblProveedorNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedorNombre.Name = "lblProveedorNombre";
            this.lblProveedorNombre.Size = new System.Drawing.Size(58, 17);
            this.lblProveedorNombre.TabIndex = 66;
            this.lblProveedorNombre.Text = "Nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(306, 393);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 37);
            this.btnSalir.TabIndex = 84;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::FantaApp.Properties.Resources.btnLimpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.InitialImage = null;
            this.btnLimpiar.Location = new System.Drawing.Point(164, 393);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 39);
            this.btnLimpiar.TabIndex = 83;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = global::FantaApp.Properties.Resources.btnGuardar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.InitialImage = null;
            this.btnModificar.Location = new System.Drawing.Point(39, 391);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 39);
            this.btnModificar.TabIndex = 82;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmEmpleadosMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.lblErrorVacio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblProveedorEmail);
            this.Controls.Add(this.lblProveedorTelefono);
            this.Controls.Add(this.lblProveedorDireccion);
            this.Controls.Add(this.lblProveedorNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFantaMod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmpleadosMod";
            this.Text = "frmEmpleadosMod";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFantaMod;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblErrorVacio;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblProveedorEmail;
        private System.Windows.Forms.Label lblProveedorTelefono;
        private System.Windows.Forms.Label lblProveedorDireccion;
        private System.Windows.Forms.Label lblProveedorNombre;
    }
}