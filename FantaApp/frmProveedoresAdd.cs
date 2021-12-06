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
    public partial class frmProveedoresAdd : Form
    {
        public DataGridView Dgv { get; set; }
        public frmProveedoresAdd()
        {
            InitializeComponent();
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
                string cadenaFanta = "INSERT INTO Proveedor (Proveedor_ID, Nombre_Proveedor, Direccion_Proveedor, Telefono_Proveedor, Email_Proveedor, Detalles_Proveedor) VALUES" +
                " (" + (Dgv.Rows.Count + 1).ToString() + ", '" + txtNombre.Text + "', '" + txtDireccion.Text + "', " + txtTelefono.Text + ", '" + txtEmail.Text + "', '" + txtDetalles.Text + "')";
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
