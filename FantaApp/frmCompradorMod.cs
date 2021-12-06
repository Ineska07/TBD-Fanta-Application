using FANTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantaApp
{
    public partial class frmCompradorMod : Form
    {
        public DataGridView Dgv { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );

        string[] data;

        public frmCompradorMod(string[] datatxt)
        {
            data = datatxt;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            rellenar(data);
        }

        private void rellenar(string[] contenido)
        {
            txtID.Text = contenido[0];
            txtNombre.Text = contenido[1];
            txtDireccion.Text = contenido[2];
            txtTelefono.Text = contenido[3];
            txtEmail.Text = contenido[4];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtEmail.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
               string cadenaCliente = "UPDATE CLIENTE SET Nombre_Cliente = '" + txtNombre.Text + "', Direccion = '" + txtDireccion.Text + "', " +
                    "Telefono = " + txtTelefono.Text + ", " + "Email = '" + txtEmail.Text + "' WHERE Cliente_ID = " + txtID.Text;
                try
                {
                    SqlCommand insertCliente = new SqlCommand(cadenaCliente, BD.conectar());
                    insertCliente.ExecuteNonQuery();
                    BD.conectar().Close();
                    BD bd = new BD();
                    string consulta = "SELECT NOMBRE_CLIENTE AS 'NOMBRE', DIRECCION, TELEFONO, EMAIL FROM CLIENTE";
                    bd.VerificarConexion(Dgv, consulta);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR, OCURRIO ALGO DURANTE EL UPDATE");
                    limpiar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

