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
    public partial class frmFantaMod : Form
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
        string[] data;
        public frmFantaMod(string[] datatxt)
        {
            data = datatxt;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            rellenar(data);
        }
        private void rellenar(string[] contenido)
        {
            txtID.Text = contenido[0];
            txtNombre.Text = contenido[1];
            txtExistencia.Text = contenido[2];
            txtPrecio.Text = contenido[3];
            txtTamaño.Text = contenido[4];
            txtProveedor.Text = SacarNombreProveedor();
            txtCategoria.Text = SacarNombreCategoria();
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtTamaño.Text = "";
            txtExistencia.Text = "";
            txtCategoria.Text = "";
            txtProveedor.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frmFantaMod_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string SacarNombreProveedor()
        {
            try
            {
                string select = "SELECT Nombre_Proveedor FROM Proveedor WHERE Proveedor_ID = " + data[5];
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
        private string SacarNombreCategoria()
        {
            try
            {
                string select = "SELECT Nombre_Categoria FROM Categoria WHERE Categoria_ID = " + data[6];
                SqlCommand consultaCategoria = new SqlCommand(select, BD.conectar());
                SqlDataAdapter r = new SqlDataAdapter();

                r.SelectCommand = consultaCategoria;

                DataTable datostabla = new DataTable();

                r.Fill(datostabla);
                string CategoriaNombre = datostabla.Rows[0][0].ToString();
                return CategoriaNombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, NOMBRE DE CATEGORIA INCORRECTO");
            }
            return "";
        }
        private int SacarIDProveedor()
        {
            try
            {
                string select = "SELECT Proveedor_ID FROM Proveedor WHERE Nombre_Proveedor = '" + txtProveedor.Text + "'";
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

        private int SacarIDCategoria()
        {
            try
            {
                string select = "SELECT Categoria_ID FROM Categoria WHERE Nombre_Categoria = '" + txtCategoria.Text + "'";
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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCategoria.Text == "" || txtExistencia.Text == "" || txtPrecio.Text == "" || txtProveedor.Text == "" || txtTamaño.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string cadenaFanta = "UPDATE Producto SET Nombre_Producto = '" + txtNombre.Text + "', " +
                    "Existencia__Producto = " + txtExistencia.Text + ", Precio__Producto = " + txtPrecio.Text + ", " +
                    "Tamaño_Envase = " + txtTamaño.Text + ", " + "Proveedor_ID = " + SacarIDProveedor() + 
                    ", Categoria_ID = " + SacarIDCategoria() + " WHERE Producto_ID = " + txtID.Text;
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
                    MessageBox.Show("ERROR, OCURRIO ALGO DURANTE EL UPDATE");
                    limpiar();
                }
            }
        }
    }
}
