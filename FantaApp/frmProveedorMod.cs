using FANTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantaApp
{
    public partial class frmProveedorMod : Form
    {
        string[] data;
        public DataGridView Dgv { get; set; }
        public frmProveedorMod(string[] datatxt)
        {
            InitializeComponent();
            data = datatxt;
            rellenar(data);
        }

        private void rellenar(string[] contenido)
        {
            txtID.Text = contenido[0];
            txtNombre.Text = contenido[1];
            txtDireccion.Text = contenido[2];
            txtTelefono.Text = contenido[3];
            txtEmail.Text = contenido[4];
            txtDetalles.Text = contenido[5];
        }

        private void frmProveedorMod_Load(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtDetalles.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string cadenaFanta = "UPDATE Proveedor SET Nombre_Proveedor = '" + txtNombre.Text + "', " +
                    "Direccion_Proveedor = '" + txtDireccion.Text + "', Telefono_Proveedor = " + txtTelefono.Text + ", " +
                    "Email_Proveedor = '" + txtEmail.Text + "', " + "Detalles_Proveedor = '" + txtDetalles.Text +
                    "' WHERE Proveedor_ID = " + txtID.Text;
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
                    MessageBox.Show("ERROR, OCURRIO ALGO DURANTE EL UPDATE");
                }
            }
        }
    }
}
