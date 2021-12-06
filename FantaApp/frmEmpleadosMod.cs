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
    public partial class frmEmpleadosMod : Form
    {
        string[] data;
        public DataGridView Dgv { get; set; }
        public frmEmpleadosMod(string[] datatxt)
        {
            InitializeComponent();
            data = datatxt;
            rellenar(data);
        }

        private void rellenar(string[] contenido)
        {
            txtID.Text = contenido[0];
            txtNombre.Text = contenido[1];
            txtApellido.Text = contenido[2];
            txtDireccion.Text = contenido[3];
            txtTelefono.Text = contenido[4];
            txtEmail.Text = contenido[5];
            txtUsuario.Text = contenido[6];
            txtContraseña.Text = contenido[7];
            txtIDRol.Text = contenido[8];
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtUsuario.Text == ""
                || txtContraseña.Text == "" || txtIDRol.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string cadenaFanta = "UPDATE Empleados SET Nombre_Empleado = '" + txtNombre.Text + "', " +
                    "Apellido_Empleado = '" + txtApellido.Text + "', Direccion_Empleado = '" + txtDireccion.Text + "', " +
                    "Telefono_Empleado = " + txtTelefono.Text + ", Email_Empleado = '" + txtEmail.Text + "'," +
                    "Nombre_de_Usuario = '" + txtUsuario.Text + "', Contraseña = '" + txtContraseña.Text + "',"+
                    "Rol_ID = " + txtIDRol.Text +
                    " WHERE Empleados_ID = " + txtID.Text;
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
                    MessageBox.Show("ERROR, OCURRIO ALGO DURANTE EL UPDATE");
                }
            }
        }
    }
}
