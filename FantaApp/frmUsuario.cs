using FANTA;
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

namespace FantaApp
{
    public partial class frmUsuario : Form
    {
        public DataTable datostabla = new DataTable();
        public frmUsuario()
        {
            InitializeComponent();
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
