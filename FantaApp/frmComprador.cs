﻿using System;
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
    public partial class frmComprador : Form
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

        public frmComprador()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            consulta = "SELECT NOMBRE_CLIENTE AS 'NOMBRE', DIRECCION, TELEFONO, EMAIL FROM CLIENTE";
        }
        private void frmComprador_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.VerificarConexion(dgvBDComprador, consulta);
            SqlCommand a = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();

            r.SelectCommand = a;

            r.Fill(table);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmCompradorAdd CompradorAdd = new frmCompradorAdd();
            CompradorAdd.Dgv = dgvBDComprador;
            CompradorAdd.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvBDComprador.SelectedRows == null)
            {
                MessageBox.Show("Selecciona una Fila");
            }
            else
            {
                int index = dgvBDComprador.CurrentCell.RowIndex;

                frmCompradorMod CompradorMod = new frmCompradorMod(encontrarFila(index));
                CompradorMod.Dgv = dgvBDComprador;
                CompradorMod.Show();
            }
        }

        private string[] encontrarFila(int index)
        {
            string encontrar = "Select * FROM CLIENTE WHERE Nombre_Cliente = '" + dgvBDComprador.Rows[dgvBDComprador.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
            SqlCommand Fila = new SqlCommand(encontrar, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();

            r.SelectCommand = Fila;

            DataTable datostabla = new DataTable();
            string[] datos = new string[7];

            r.Fill(datostabla);

            for (int i = 0; i < datostabla.Columns.Count; i++)
            {
                datos[i] = datostabla.Rows[0][i].ToString();
            }
            return datos;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere borrar esta fila?", "Confirmación de borrado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dgvBDComprador.CurrentCell.RowIndex;
                consultaBorrar = "DELETE FROM Cliente Where Nombre_Cliente="+ "'"+ dgvBDComprador.Rows[dgvBDComprador.CurrentCell.RowIndex].Cells[0].Value.ToString()+"'";

                if (dgvBDComprador.SelectedRows == null)
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
                        consulta = "SELECT NOMBRE_CLIENTE AS 'NOMBRE', DIRECCION, TELEFONO, EMAIL FROM CLIENTE";
                        bd.VerificarConexion(dgvBDComprador, consulta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede borrar porque el elemento esta siendo utilizado en otra tabla.");
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
            string header = "Lista de Compradores";
            Font font = new Font("Arial", 14, FontStyle.Regular);
            Font fontColumnNames = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 18, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);
            SizeF size;
            float xPadding;
            int columnCount = table.Columns.Count;
            int x, y = 0, width = 200;
            x = 0;
            y += 30;
            // Here title is written, sets to top-middle position of the page
            size = e.Graphics.MeasureString(header, fontHeader);
            xPadding = (width - size.Width) / 2;
            e.Graphics.DrawString(header, fontHeader, brush, x + 290, y + 5);
            x = 2;
            y += 60;
            // Writes out all column names in designated locations, aligned as a table
            foreach (DataColumn column in table.Columns)
            {
                size = e.Graphics.MeasureString(column.ColumnName, fontColumnNames);
                xPadding = (width - size.Width) / 2;
                e.Graphics.DrawString(column.ColumnName, fontColumnNames, brush, x + xPadding, y + 5);
                x += width;
            }
            x = 2;
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

                x = 2;
                y += 30;
            }
        }
    }
}
