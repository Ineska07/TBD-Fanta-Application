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
    public partial class frmCompradorAdd: Form
    {
        public DataGridView Dgv { get; set; }

        public frmCompradorAdd()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (txtNombre.Text == "" || txtEmail.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                //Falla el Insert
                string cadenaCliente = "INSERT INTO Cliente (Cliente_ID, Nombre_Cliente, Dirección, Telefono, Email, Empledos_ID) VALUES" +
                " (" + (Dgv.Rows.Count + 1).ToString() + ", '" + txtNombre.Text + "', '" + txtDireccion.Text + "', " + txtTelefono.Text + ", '" + txtEmail.Text + "', " + "1)";
                try
                {
                    SqlCommand insertCliente = new SqlCommand(cadenaCliente, BD.conectar());
                    insertCliente.ExecuteNonQuery();
                    BD.conectar().Close();
                    BD bd = new BD();
                    string consulta = "SELECT Nombre_Producto AS 'Nombre', Existencia__Producto AS 'Existencia', Tamaño_Envase AS 'Tamaño', " +
                        "Precio__Producto AS 'Precio Unitario' FROM Producto";
                    bd.VerificarConexion(Dgv, consulta);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR, OCURRIO ALGO DURANTE EL INSERT");
                    //limpiar(); 
                }
            }
           
        }

        private void frmCompradorAdd_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
        }
    }
}
