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
using System.Runtime.InteropServices;
using FANTA;

namespace FantaApp
{
    public partial class frmVentas : Form
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

        string consulta;
        string consulta2;

        public frmVentas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            consulta = "SELECT Orden.Orden_ID AS 'No. Orden', Nombre_Cliente AS 'Cliente', Fecha_Orden AS 'Fecha' FROM Cliente, Orden WHERE Orden.Cliente_ID = Cliente.Cliente_ID";
            consulta2 = "SELECT Detalles_de_Orden.Cantidad, Detalles_de_Orden.Tipo_Pago, Detalles_de_Orden.Descuento, Detalles_de_Orden.Total FROM Detalles_de_Orden"; 
        }

         /* private void botonBorrar()
        {
            if (dgvBDVentas.CurrentCell.RowIndex == 0)
            {
                //nada o error
            }
            else
            {
                //nose si el comando pa borrar es el siguiente
                string consulta "DELETE FROM PRODUCTOS WHERE ID =" + dgvBDVentas.Rows[dgvBDVentas.CurrentCell.RowIndex].Cells[0].Value.ToString();
                // y luego todo el codigo necesario para mandar la consulta
            }
        } */

        private void frmVentas_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.VerificarConexion(dgvBDVentas, consulta);
            mostrarDetalles();
        }

        private void mostrarDetalles()
        {
            BD bd = new BD();
            string mostrarDetalles = "SELECT Cantidad, Nombre_Producto AS 'Nombre', Precio__Producto AS 'Precio', " +
                "Total FROM Detalles_de_Orden, Producto WHERE Detalles_de_Orden.Producto_ID = Producto.Producto_ID AND Orden_ID = " + dgvBDVentas.Rows[dgvBDVentas.CurrentCell.RowIndex].Cells[0].Value.ToString();
            bd.VerificarConexion(dgvVentasDetalles, mostrarDetalles);
            double acum = 0;
            for (int i = 0; i < dgvVentasDetalles.Rows.Count; i++)
            {
                acum += Convert.ToDouble(dgvVentasDetalles.Rows[i].Cells[3].Value); 
            }
            lblTotalActual.Text = acum.ToString();
            lblOrdenID.Text = dgvBDVentas.Rows[dgvBDVentas.CurrentCell.RowIndex].Cells[0].Value.ToString();
            lblCliente.Text = dgvBDVentas.Rows[dgvBDVentas.CurrentCell.RowIndex].Cells[1].Value.ToString();
            lblFecha.Text = dgvBDVentas.Rows[dgvBDVentas.CurrentCell.RowIndex].Cells[2].Value.ToString();
            lblTdPago.Text = getTipodePago();
        }
        private string getTipodePago()
        {
            string consulta = "SELECT Tipo_Pago FROM Detalles_de_Orden WHERE Orden_ID = " + dgvBDVentas.Rows[dgvBDVentas.CurrentCell.RowIndex].Cells[0].Value.ToString() + " GROUP BY Tipo_Pago";
            SqlCommand consultaPago = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaPago;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            return datostabla.Rows[0][0].ToString();
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //Algo como el de Fanta pero sin ser las celdas diréctamente xd
            frmVentasAdd VentasAdd = new frmVentasAdd();
            VentasAdd.Dgv = dgvBDVentas;
            VentasAdd.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string numOrden = dgvBDVentas.Rows[dgvBDVentas.CurrentCell.RowIndex].Cells[0].Value.ToString();
            frmVentasMod VentasMod = new frmVentasMod(numOrden);
            VentasMod.Dgv = dgvBDVentas;
            VentasMod.Show();
        }

        private void dgvBDVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBDVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDetalles();
        }

        private void pbxBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea borrar la Orden seleccionada?", "Borrar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dgvBDVentas.CurrentCell.RowIndex;

                //Delete DdO
                string consulta2 = "DELETE FROM Detalles_de_Orden Where Orden_ID = " + dgvBDVentas.Rows[index].Cells[0].Value.ToString();
                SqlCommand deletAll2 = new SqlCommand(consulta2, BD.conectar());
                deletAll2.ExecuteNonQuery();
                BD.conectar().Close();

                //Delete ordenes
                string consulta1 = "DELETE FROM Orden Where Orden_ID = " + dgvBDVentas.Rows[index].Cells[0].Value.ToString();
                SqlCommand deletAll1 = new SqlCommand(consulta1, BD.conectar());
                deletAll1.ExecuteNonQuery();
                BD.conectar().Close();

                //Refresh
                BD bd = new BD();
                bd.VerificarConexion(dgvBDVentas, consulta);
                mostrarDetalles();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Nada
            }
        }
    }
}
