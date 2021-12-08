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
    public partial class frmFanta : Form
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
        string consultaBorrar;

        public frmFanta()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            consulta = "SELECT Nombre_Producto AS 'Nombre', Existencia__Producto AS 'Existencia', Tamaño_Envase AS 'Tamaño', " +
                "Precio__Producto AS 'Precio Unitario' FROM Producto";
        }

        private void frmFanta_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.VerificarConexion(dgvBDFanta, consulta);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmFantaAdd FantasAdd = new frmFantaAdd();
            FantasAdd.Dgv = dgvBDFanta;
            FantasAdd.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvBDFanta.SelectedRows == null)
            {
                MessageBox.Show("Selecciona una Fila");
            }
            else
            {
                int index = dgvBDFanta.CurrentCell.RowIndex;
                frmFantaMod FantasMod = new frmFantaMod(encontrarFila(index));
                FantasMod.Dgv = dgvBDFanta;
                FantasMod.Show();
            }
        }

        private string[] encontrarFila(int index)
        {
            string encontrar = "Select * FROM Producto WHERE Producto_ID = " + ((int)index+1);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere borrar esta fila?", "Confirmación de borrado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dgvBDFanta.CurrentCell.RowIndex;
                consultaBorrar = "DELETE FROM Producto Where Nombre_Producto=" + "'" + dgvBDFanta.Rows[dgvBDFanta.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";

                if (dgvBDFanta.SelectedRows == null)
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
                        bd.VerificarConexion(dgvBDFanta, consulta);
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
    }
}
