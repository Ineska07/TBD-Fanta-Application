namespace FantaApp
{
    partial class frmAdmins
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
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnDeivid = new System.Windows.Forms.Button();
            this.btnValdez = new System.Windows.Forms.Button();
            this.btnInes = new System.Windows.Forms.Button();
            this.btnDany = new System.Windows.Forms.Button();
            this.btnErick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FantaApp.Properties.Resources.btnExit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.InitialImage = null;
            this.btnSalir.Location = new System.Drawing.Point(125, 94);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeivid
            // 
            this.btnDeivid.Location = new System.Drawing.Point(12, 102);
            this.btnDeivid.Name = "btnDeivid";
            this.btnDeivid.Size = new System.Drawing.Size(75, 23);
            this.btnDeivid.TabIndex = 10;
            this.btnDeivid.Text = "Deivid";
            this.btnDeivid.UseVisualStyleBackColor = true;
            this.btnDeivid.Click += new System.EventHandler(this.btnDeivid_Click);
            // 
            // btnValdez
            // 
            this.btnValdez.Location = new System.Drawing.Point(12, 12);
            this.btnValdez.Name = "btnValdez";
            this.btnValdez.Size = new System.Drawing.Size(75, 23);
            this.btnValdez.TabIndex = 11;
            this.btnValdez.Text = "Valdez";
            this.btnValdez.UseVisualStyleBackColor = true;
            this.btnValdez.Click += new System.EventHandler(this.btnValdez_Click);
            // 
            // btnInes
            // 
            this.btnInes.Location = new System.Drawing.Point(12, 53);
            this.btnInes.Name = "btnInes";
            this.btnInes.Size = new System.Drawing.Size(75, 23);
            this.btnInes.TabIndex = 12;
            this.btnInes.Text = "Ines";
            this.btnInes.UseVisualStyleBackColor = true;
            this.btnInes.Click += new System.EventHandler(this.btnInes_Click);
            // 
            // btnDany
            // 
            this.btnDany.Location = new System.Drawing.Point(125, 12);
            this.btnDany.Name = "btnDany";
            this.btnDany.Size = new System.Drawing.Size(75, 23);
            this.btnDany.TabIndex = 13;
            this.btnDany.Text = "Dany";
            this.btnDany.UseVisualStyleBackColor = true;
            this.btnDany.Click += new System.EventHandler(this.btnDany_Click);
            // 
            // btnErick
            // 
            this.btnErick.Location = new System.Drawing.Point(125, 53);
            this.btnErick.Name = "btnErick";
            this.btnErick.Size = new System.Drawing.Size(75, 23);
            this.btnErick.TabIndex = 14;
            this.btnErick.Text = "Erick";
            this.btnErick.UseVisualStyleBackColor = true;
            this.btnErick.Click += new System.EventHandler(this.btnErick_Click);
            // 
            // frmAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(222, 137);
            this.Controls.Add(this.btnErick);
            this.Controls.Add(this.btnDany);
            this.Controls.Add(this.btnInes);
            this.Controls.Add(this.btnValdez);
            this.Controls.Add(this.btnDeivid);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmAdmins";
            this.Text = "Admins";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Button btnDeivid;
        private System.Windows.Forms.Button btnValdez;
        private System.Windows.Forms.Button btnInes;
        private System.Windows.Forms.Button btnDany;
        private System.Windows.Forms.Button btnErick;
    }
}