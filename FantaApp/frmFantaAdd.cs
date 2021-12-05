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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int SacarProveedor()
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

        private int SacarCategoria()
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCategoria.Text == "" || txtExistencia.Text == "" || txtPrecio.Text == "" || txtProveedor.Text == "" || txtTamaño.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string cadenaFanta = "INSERT INTO Producto (Producto_ID, Nombre_Producto, Existencia__Producto, Tamaño_Envase, Precio__Producto, Proveedor_ID, Categoria_ID) VALUES" +
                " (" + (Dgv.Rows.Count + 1).ToString() + ", '" + txtNombre.Text + "', " + txtExistencia.Text + ", " + txtTamaño.Text + ", " + txtPrecio.Text + ", " + SacarProveedor().ToString() + ", " + SacarCategoria().ToString() + ")";
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
            txtCategoria.Text = "";
            txtProveedor.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
