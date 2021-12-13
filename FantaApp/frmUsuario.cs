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
    public partial class frmUsuario : Form
    {
        public DataTable datostabla = new DataTable();
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
        public frmUsuario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT Nombre_de_Usuario AS 'Username', Contraseña FROM Empleados";
            SqlCommand consultaPago = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaPago;
            r.Fill(datostabla);
        }

        public bool checarLogin()
        {
            for (int i = 0; i < datostabla.Rows.Count; i++)
            {
                if (txtUsername.Text == datostabla.Rows[i][0].ToString() && txtPassword.Text == datostabla.Rows[i][1].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void pbxLogin_Click(object sender, EventArgs e)
        {
            if (checarLogin())
            {
                frmMain Main = new frmMain();
                Main.Show();
                this.Visible = false;
            }
            else
            {
                lblErrorVacio.Visible = true;
            }
        }
    }
}
