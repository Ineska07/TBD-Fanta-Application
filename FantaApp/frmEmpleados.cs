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

        string consulta;


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
    }
}
