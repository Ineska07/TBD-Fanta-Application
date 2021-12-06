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
    public partial class frmEmpleadosAdd : Form
    {
        public DataGridView Dgv { get; set; }
        public frmEmpleadosAdd()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtIDRol.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frmEmpleadosAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtUsuario.Text == ""
                || txtContraseña.Text == "" || txtIDRol.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string cadenaFanta = "INSERT INTO Empleados (Empleados_ID, Nombre_Empleado, Apellido_Empleado, Direccion_Empleado, Telefono_Empleado, Email_Empleado, Nombre_de_Usuario, Contraseña, Rol_ID) VALUES" +
                " (" + (Dgv.Rows.Count + 1).ToString() + ", '" + txtNombre.Text + "', '" +  txtApellido.Text + 
                "', '" + txtDireccion.Text + "', " + txtTelefono.Text + ", '" + txtEmail.Text + "', '" + txtUsuario.Text + "', '" + 
                txtContraseña.Text + "', " +  txtIDRol.Text + ")";
                try
                {
                    SqlCommand insertFanta = new SqlCommand(cadenaFanta, BD.conectar());
                    insertFanta.ExecuteNonQuery();
                    BD.conectar().Close();
                    BD bd = new BD();
                    string consulta = "SELECT Nombre_Empleado AS 'NOMBRE', Apellido_Empleado AS 'APELLIDO', Direccion_Empleado AS 'DIRECCIÓN', " +
                    "Telefono_Empleado AS 'TELEFONO', Email_Empleado AS 'EMAIL', Nombre_de_Usuario AS 'USUARIO', Contraseña AS 'CONTRASEÑA', " +
                    "Rol_ID AS 'IDROL' FROM Empleados";
                    bd.VerificarConexion(Dgv, consulta);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR, OCURRIO ALGO DURANTE EL INSERT");
                }
            }
        }
    }
}
