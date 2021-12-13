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
    public partial class frmEmpleadosAdd : Form
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
        public frmEmpleadosAdd()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            cbxRol.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frmEmpleadosAdd_Load(object sender, EventArgs e)
        {
            buscarRol();
        }
        public void buscarRol()
        {
            string consultaC = "SELECT Nombre_Rol FROM Rol";
            SqlCommand consultaClientes = new SqlCommand(consultaC, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaClientes;

            DataTable datostabla = new DataTable();

            r.Fill(datostabla);

            for (int i = 0; i < datostabla.Rows.Count; i++)
            {
                cbxRol.Items.Add(datostabla.Rows[i][0].ToString());
            }
        }
        private int SacarIDRol()
        {
            try
            {
                string select = "SELECT Rol_ID FROM Rol WHERE Nombre_Rol = '" + cbxRol.SelectedItem.ToString() + "'";
                SqlCommand consultaProveedor = new SqlCommand(select, BD.conectar());
                SqlDataAdapter r = new SqlDataAdapter();

                r.SelectCommand = consultaProveedor;

                DataTable datostabla = new DataTable();

                r.Fill(datostabla);
                int ProveedorID = (int)datostabla.Rows[0][0];
                return ProveedorID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, NOMBRE DE PROVEEDOR INCORRECTO");
            }
            return 0;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtUsuario.Text == ""
                || txtContraseña.Text == "" || cbxRol.SelectedIndex == -1)
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string EncontrarID = "SELECT MAX(Empleados_ID) FROM Empleados";
                SqlCommand buscarID = new SqlCommand(EncontrarID, BD.conectar());
                Int32 idActual = (Int32)buscarID.ExecuteScalar();

                string cadenaFanta = "INSERT INTO Empleados (Empleados_ID, Nombre_Empleado, Apellido_Empleado, Direccion_Empleado, Telefono_Empleado, Email_Empleado, Nombre_de_Usuario, Contraseña, Rol_ID) VALUES" +
                " (" + (idActual + 1).ToString() + ", '" + txtNombre.Text + "', '" +  txtApellido.Text + 
                "', '" + txtDireccion.Text + "', " + txtTelefono.Text + ", '" + txtEmail.Text + "', '" + txtUsuario.Text + "', '" + 
                txtContraseña.Text + "', " + SacarIDRol() + ")";
                try
                {
                    SqlCommand insertFanta = new SqlCommand(cadenaFanta, BD.conectar());
                    insertFanta.ExecuteNonQuery();
                    BD.conectar().Close();
                    BD bd = new BD();
                    string consulta = "SELECT Nombre_Empleado AS 'NOMBRE', Apellido_Empleado AS 'Apellido', " +
                "Direccion_Empleado AS 'DIRECCIÓN', Telefono_Empleado AS 'TELEFONO', Email_Empleado AS 'EMAIL' " +
                "FROM Empleados";
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
