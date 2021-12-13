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
    public partial class frmProveedoresAdd : Form
    {
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
        public DataGridView Dgv { get; set; }
        public frmProveedoresAdd()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDetalles.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtDetalles.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string EncontrarID = "SELECT MAX(Proveedor_ID) FROM Proveedor";
                SqlCommand buscarID = new SqlCommand(EncontrarID, BD.conectar());
                Int32 idActual = (Int32)buscarID.ExecuteScalar();

                string cadenaFanta = "INSERT INTO Proveedor (Proveedor_ID, Nombre_Proveedor, Direccion_Proveedor, Telefono_Proveedor, Email_Proveedor, Detalles_Proveedor) VALUES" +
                " (" + (idActual + 1).ToString() + ", '" + txtNombre.Text + "', '" + txtDireccion.Text + "', " + txtTelefono.Text + ", '" + txtEmail.Text + "', '" + txtDetalles.Text + "')";
                try
                {
                    SqlCommand insertFanta = new SqlCommand(cadenaFanta, BD.conectar());
                    insertFanta.ExecuteNonQuery();
                    BD.conectar().Close();
                    BD bd = new BD();
                    string consulta = "SELECT Nombre_Proveedor AS 'NOMBRE', Direccion_Proveedor AS 'DIRECCIÓN', " +
                    "Telefono_Proveedor AS 'TELEFONO', Email_Proveedor AS 'EMAIL', Detalles_Proveedor AS 'DETALLES' FROM PROVEEDOR";
                    bd.VerificarConexion(Dgv, consulta);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR, OCURRIO ALGO DURANTE EL INSERT");
                }
            }
        }

        private void frmProveedoresAdd_Load(object sender, EventArgs e)
        {
            txtDetalles.Text = "N/A";
        }
    }
}
