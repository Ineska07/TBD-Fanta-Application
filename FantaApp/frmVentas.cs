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
using System.Drawing.Printing;

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
        public DataTable table = new DataTable();
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

            SqlCommand a = new SqlCommand(mostrarDetalles, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();

            r.SelectCommand = a;
            table.Clear();
            r.Fill(table);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al Imprimir");
            }
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            string header = "Cotizacion";
            Font font = new Font("Arial", 14, FontStyle.Regular);
            Font fontColumnNames = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 20, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);
            SizeF size;
            float xPadding;
            int columnCount = table.Columns.Count;
            int x, y = 0, width = 200;
            x = 0;
            y += 30;
            e.Graphics.DrawImage(pbxCotizacion.BackgroundImage, 20, 20);
            // Here title is written, sets to top-middle position of the page
            size = e.Graphics.MeasureString(header, fontHeader);
            xPadding = (width - size.Width) / 2;
            e.Graphics.DrawString(header, fontHeader, brush, x + 330, y + 8);
            x = 0;

            //info de la venta
            string orden = "Orden #" + dgvBDVentas.Rows[dgvBDVentas.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string fecha = "Fecha: " + lblFecha.Text;
            fecha = fecha.Replace("12:00:00 AM", "");
            e.Graphics.DrawString(fecha, font, brush, x + 650, y + 10);
            y += 80;
            e.Graphics.DrawString(orden, font, brush, x + 360, y + 5);
            y += 30;
            e.Graphics.DrawString("Cliente: " + lblCliente.Text, font, brush, x + 100, y + 5);
            e.Graphics.DrawString("Tipo de Pago: " + lblTdPago.Text, font, brush, x + 500, y + 5);
            y += 60;
            // Writes out all column names in designated locations, aligned as a table
            foreach (DataColumn column in table.Columns)
            {
                size = e.Graphics.MeasureString(column.ColumnName, fontColumnNames);
                xPadding = (width - size.Width) / 2;
                e.Graphics.DrawString(column.ColumnName, fontColumnNames, brush, x + xPadding, y + 5);
                x += width;
            }
            x = 0;
            y += 30;
            // Process each row and place each item under correct column.
            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    size = e.Graphics.MeasureString(row[i].ToString(), font);
                    xPadding = (width - size.Width) / 2;

                    e.Graphics.DrawString(row[i].ToString(), font, brush, x + xPadding, y + 5);
                    x += width;
                }

                x = 0;
                y += 30;
            }
            y += 50;
            e.Graphics.DrawString("Total: $" + lblTotalActual.Text, font, brush, x + 350, y + 5);
            e.Graphics.DrawString("Todos los cheques se extenderán a nombre del Equipo 3", new Font("Arial", 11, FontStyle.Regular), new SolidBrush(Color.Gray), 250, 1000);
            e.Graphics.DrawString("Gracias por su confianza", new Font("Arial", 13, FontStyle.Regular), brush, 340, 1030);
        }
    }
}
