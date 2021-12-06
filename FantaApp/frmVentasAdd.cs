using FANTA;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace FantaApp
{
    public partial class frmVentasAdd : Form
    {
        public frmVentasAdd()
        {
            InitializeComponent();
        }

        private void frmVentasAdd_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
        }

        /*private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtOrdenCantidad.Text == "" || txtOrdenDescuento.Text == "" || txtOrdenOrden.Text == "" || txtOrdenProducto.Text == "" || txtOrdenTipoPago.Text == "" || txtOrdenTotal.Text == "")
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                string cadenaFanta = "INSERT INTO Orden (Producto_ID, Nombre_Producto, Existencia__Producto, Tamaño_Envase, Precio__Producto, Proveedor_ID, Categoria_ID) VALUES" +
                " (" + (Dgv.Rows.Count + 1).ToString() + ", '" + txtOrdenCantidad.Text + "', " + txtExistencia.Text + ", " + txtTamaño.Text + ", " + txtPrecio.Text + ", " + SacarProveedor().ToString() + ", " + SacarCategoria().ToString() + ")";
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
        }*/

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar();
        }
        /*private void limpiar()
        {
            txtOrdenCantidad.Text = "";
            txtOrdenDescuento.Text = "";
            txtOrdenOrden.Text = "";
            txtOrdenProducto.Text = "";
            txtOrdenTipoPago.Text = "";
            txtOrdenTotal.Text = "";
        }*/

        public void ExportarDatos(DataGridView dataListado)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();

            exportarExcel.Application.Workbooks.Add(true);

            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in dataListado.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
        }



        private void btnAñadir_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //oops
        }

        private void frmVentasAdd_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fANTA_BDDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.fANTA_BDDataSet.Producto);

        }
    }
}
