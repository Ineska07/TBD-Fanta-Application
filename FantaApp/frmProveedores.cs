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

        string consulta;

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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[] encontrarFila(int index)
        {
            string encontrar = "Select * FROM Proveedor WHERE Proveedor_ID = " + ((int)index + 1);
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
    }
}
