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
    public partial class frmEmpleadosMod : Form
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
        string[] data;
        public DataGridView Dgv { get; set; }
        public frmEmpleadosMod(string[] datatxt)
        {
            InitializeComponent();
            data = datatxt;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            cbxRol.SelectedItem = SacarNombreRol();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtUsuario.Text == ""
                || txtContraseña.Text == "" || cbxRol.SelectedIndex == -1)
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string cadenaFanta = "UPDATE Empleados SET Nombre_Empleado = '" + txtNombre.Text + "', " +
                    "Apellido_Empleado = '" + txtApellido.Text + "', Direccion_Empleado = '" + txtDireccion.Text + "', " +
                    "Telefono_Empleado = " + txtTelefono.Text + ", Email_Empleado = '" + txtEmail.Text + "'," +
                    "Nombre_de_Usuario = '" + txtUsuario.Text + "', Contraseña = '" + txtContraseña.Text + "',"+
                    "Rol_ID = " + SacarIDRol() +
                    " WHERE Empleados_ID = " + txtID.Text;
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
                    MessageBox.Show("ERROR, OCURRIO ALGO DURANTE EL UPDATE");
                }
            }
        }

        private void frmEmpleadosMod_Load(object sender, EventArgs e)
        {
            buscarRol();
            rellenar(data);
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
        private string SacarNombreRol()
        {
            try
            {
                string select = "SELECT Nombre_Rol FROM Rol WHERE Rol_ID = " + data[8];
                SqlCommand consultaProveedor = new SqlCommand(select, BD.conectar());
                SqlDataAdapter r = new SqlDataAdapter();

                r.SelectCommand = consultaProveedor;

                DataTable datostabla = new DataTable();

                r.Fill(datostabla);
                string ProveedorNombre = datostabla.Rows[0][0].ToString();
                return ProveedorNombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, NOMBRE DE PROVEEDOR INCORRECTO");
            }
            return "";
        }
    }
}
