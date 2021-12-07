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
    public partial class frmCompradorAdd: Form
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

        public frmCompradorAdd()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (txtNombre.Text == "" || txtEmail.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string EncontrarID = "SELECT MAX(Cliente_ID) FROM Cliente";
                SqlCommand buscarID = new SqlCommand(EncontrarID, BD.conectar());
                Int32 idActual = (Int32)buscarID.ExecuteScalar();

                string cadenaCliente = "INSERT INTO Cliente (Cliente_ID, Nombre_Cliente, Direccion, Telefono, Email, Empledos_ID) VALUES" +
                " (" + (idActual + 1).ToString() + ", '" + txtNombre.Text + "', '" + txtDireccion.Text + "', " + txtTelefono.Text + ", '" + txtEmail.Text + "', " + "1)";
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
                        MessageBox.Show("Se ha producido un error. Datos no validados.");
                        limpiar(); 
                    }
                }
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void frmCompradorAdd_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
