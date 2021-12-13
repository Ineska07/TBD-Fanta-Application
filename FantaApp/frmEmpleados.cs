using FANTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FantaApp
{
    
    public partial class frmEmpleados : Form
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

        public frmEmpleados()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            consulta = "SELECT Nombre_Empleado AS 'NOMBRE', Apellido_Empleado AS 'Apellido', " +
                "Direccion_Empleado AS 'DIRECCIÓN', Telefono_Empleado AS 'TELEFONO', Email_Empleado AS 'EMAIL' " +
                "FROM Empleados";

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.VerificarConexion(dgvBDEmpleados, consulta);
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
            string encontrar = "Select * FROM Empleados WHERE Empleados_ID = " + ((int)index + 1);
            SqlCommand Fila = new SqlCommand(encontrar, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();

            r.SelectCommand = Fila;

            DataTable datostabla = new DataTable();
            string[] datos = new string[9];

            r.Fill(datostabla);

            for (int i = 0; i < datostabla.Columns.Count; i++)
            {
                datos[i] = datostabla.Rows[0][i].ToString();
            }
            return datos;
        }

        
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvBDEmpleados.SelectedRows == null)
            {
                MessageBox.Show("Selecciona una Fila");
            }
            else
            {
                int index = dgvBDEmpleados.CurrentCell.RowIndex;
                frmEmpleadosMod EmpleadosMod = new frmEmpleadosMod(encontrarFila(index));
                EmpleadosMod.Dgv = dgvBDEmpleados;
                EmpleadosMod.Show();
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmEmpleadosAdd EmpleadosAdd = new frmEmpleadosAdd();
            EmpleadosAdd.Dgv = dgvBDEmpleados;
            EmpleadosAdd.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere borrar esta fila?", "Confirmación de borrado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dgvBDEmpleados.CurrentCell.RowIndex;
                consultaBorrar = "DELETE FROM Empleados Where Nombre_Empleado=" + "'" + dgvBDEmpleados.Rows[dgvBDEmpleados.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";

                if (dgvBDEmpleados.SelectedRows == null)
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
                        bd.VerificarConexion(dgvBDEmpleados, consulta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se ha producido un error. Datos no validados.");
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
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
            string header = "Lista de Empleados";
            Font font = new Font("Arial", 11, FontStyle.Regular);
            Font fontColumnNames = new Font("Arial", 12, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 15, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);
            SizeF size;
            float xPadding;
            int columnCount = table.Columns.Count;
            int x, y = 0, width = 160;
            x = 0;
            y += 30;
            // Here title is written, sets to top-middle position of the page
            size = e.Graphics.MeasureString(header, fontHeader);
            xPadding = (width - size.Width) / 2;
            e.Graphics.DrawString(header, fontHeader, brush, x + 300, y + 5);
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
