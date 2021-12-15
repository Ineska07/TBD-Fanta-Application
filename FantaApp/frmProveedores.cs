using FANTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//SOLO ESTE COMENTARIO

namespace FantaApp
{
    public partial class frmProveedores : Form
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
        string consultaBorrar;

        public frmProveedores()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            consulta = "SELECT Nombre_Proveedor AS 'NOMBRE', Direccion_Proveedor AS 'DIRECCIÓN', " +
                "Telefono_Proveedor AS 'TELEFONO', Email_Proveedor AS 'EMAIL', Detalles_Proveedor AS 'DETALLES' FROM PROVEEDOR";
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.VerificarConexion(dgvBDProveedores, consulta);
            SqlCommand a = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();

            r.SelectCommand = a;

            r.Fill(table);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[] encontrarFila(int index)
        {
            string encontrar = "Select * FROM Proveedor WHERE Nombre_Proveedor = '" + dgvBDProveedores.Rows[dgvBDProveedores.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
            SqlCommand Fila = new SqlCommand(encontrar, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();

            r.SelectCommand = Fila;

            DataTable datostabla = new DataTable();
            string[] datos = new string[6];

            r.Fill(datostabla);

            for (int i = 0; i < datostabla.Columns.Count; i++)
            {
                datos[i] = datostabla.Rows[0][i].ToString();
            }
            return datos;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvBDProveedores.SelectedRows == null)
            {
                MessageBox.Show("Selecciona una Fila");
            }
            else
            {
                int index = dgvBDProveedores.CurrentCell.RowIndex;
                frmProveedorMod ProveedorMod = new frmProveedorMod(encontrarFila(index));
                ProveedorMod.Dgv = dgvBDProveedores;
                ProveedorMod.Show();
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmProveedoresAdd ProveedoresAdd = new frmProveedoresAdd();
            ProveedoresAdd.Dgv = dgvBDProveedores;
            ProveedoresAdd.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere borrar esta fila?", "Confirmación de borrado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dgvBDProveedores.CurrentCell.RowIndex;
                consultaBorrar = "DELETE FROM Proveedor Where Nombre_Proveedor=" + "'" + dgvBDProveedores.Rows[dgvBDProveedores.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";

                if (dgvBDProveedores.SelectedRows == null)
                {
                    MessageBox.Show("Selecciona una Fila");
                }
                else
                {
                    try
                    {
                        SqlCommand BorrarCliente = new SqlCommand(consultaBorrar, BD.conectar());
                        BorrarCliente.ExecuteNonQuery();
                        BD.conectar().Close();
                        BD bd = new BD();
                        bd.VerificarConexion(dgvBDProveedores, consulta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede borrar porque el elemento esta siendo utilizado en otra tabla.");
                    }
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            try
            {
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al Imprimir");
            }
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            string header = "Lista de Proveedores";
            Font font = new Font("Arial", 9, FontStyle.Regular);
            Font fontColumnNames = new Font("Arial", 10, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 12, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);
            SizeF size;
            float xPadding;
            int columnCount = table.Columns.Count;
            int x, y = 0, width = 168;
            x = 0;
            y += 30;
            // Here title is written, sets to top-middle position of the page
            size = e.Graphics.MeasureString(header, fontHeader);
            xPadding = (width - size.Width) / 2;
            e.Graphics.DrawString(header, fontHeader, brush, x + 330, y + 5);
            x = 0;
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
        }
    }
}
