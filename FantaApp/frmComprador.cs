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
        string consulta;

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

                frmFantaMod CompradorMod = new frmFantaMod(encontrarFila(index));
                CompradorMod.Dgv = dgvBDComprador;
                CompradorMod.Show();
            }
        }

        private string[] encontrarFila(int index)
        {
            string encontrar = "Select * FROM Producto WHERE Cliente_ID = " + ((int)index + 1);
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
    }
}
