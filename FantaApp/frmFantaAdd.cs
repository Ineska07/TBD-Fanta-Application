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
    public partial class frmFantaAdd : Form
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

        public frmFantaAdd()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmFantaAdd_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
            buscarProveedor();
            buscarCategoria();
        }

        public void buscarProveedor()
        {
            string consultaC = "SELECT Nombre_Proveedor FROM Proveedor";
            SqlCommand consultaClientes = new SqlCommand(consultaC, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaClientes;

            DataTable datostabla = new DataTable();

            r.Fill(datostabla);

            for (int i = 0; i < datostabla.Rows.Count; i++)
            {
                cbxProveedor.Items.Add(datostabla.Rows[i][0].ToString());
            }
        }
        public void buscarCategoria()
        {
            string consultaC = "SELECT Nombre_Categoria FROM Categoria";
            SqlCommand consultaClientes = new SqlCommand(consultaC, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaClientes;

            DataTable datostabla = new DataTable();

            r.Fill(datostabla);

            for (int i = 0; i < datostabla.Rows.Count; i++)
            {
                cbxCategoria.Items.Add(datostabla.Rows[i][0].ToString());
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int sacarProveedor()
        {
            try
            {
                string select = "SELECT Proveedor_ID FROM Proveedor WHERE Nombre_Proveedor = '" + cbxProveedor.SelectedItem.ToString() + "'";
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

        private int sacarCategoria()
        {
            try
            {
                string select = "SELECT Categoria_ID FROM Categoria WHERE Nombre_Categoria = '" + cbxCategoria.SelectedItem.ToString() + "'";
                SqlCommand consultaCategoria = new SqlCommand(select, BD.conectar());
                SqlDataAdapter r = new SqlDataAdapter();

                r.SelectCommand = consultaCategoria;

                DataTable datostabla = new DataTable();

                r.Fill(datostabla);
                int CategoriaID = (int)datostabla.Rows[0][0];
                return CategoriaID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, NOMBRE DE CATEGORIA INCORRECTO");
            }
            return 0;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || cbxCategoria.SelectedIndex == -1 || txtExistencia.Text == "" || txtPrecio.Text == "" || cbxProveedor.SelectedIndex == -1 || txtTamaño.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string EncontrarID = "SELECT MAX(Producto_ID) FROM Producto";
                SqlCommand buscarID = new SqlCommand(EncontrarID, BD.conectar());
                Int32 idActual = (Int32)buscarID.ExecuteScalar();

                string cadenaFanta = "INSERT INTO Producto (Producto_ID, Nombre_Producto, Existencia__Producto, Tamaño_Envase, Precio__Producto, Proveedor_ID, Categoria_ID) VALUES" +
                " (" + (idActual + 1).ToString() + ", '" + txtNombre.Text + "', " + txtExistencia.Text + ", " + txtTamaño.Text + ", " + txtPrecio.Text + ", " + sacarProveedor() + ", " + sacarCategoria() + ")";
                try
                {
                    SqlCommand insertFanta = new SqlCommand(cadenaFanta, BD.conectar());
                    insertFanta.ExecuteNonQuery();
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
                }
            }
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtTamaño.Text = "";
            txtExistencia.Text = "";
            cbxCategoria.SelectedIndex = -1;
            cbxProveedor.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
