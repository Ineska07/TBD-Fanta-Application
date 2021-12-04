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
            consulta = "SELECT NOMBREC AS 'NOMBRE', TELEFONO, DIRECCION FROM COMPRADOR";
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
            string cadenaFanta = "INSERT INTO COMPRADOR (IDCOMPRADOR, NOMBREC, TELEFONO, DIRECCION) VALUES " +
                "(" + dgvBDComprador.Rows.Count.ToString() + ", '" + tbxNombreComprador.Text + "', '" + tbxTelefono.Text + "', '" + tbxDireccion.Text + "')";
            try
            {
                SqlCommand insertFanta = new SqlCommand(cadenaFanta, BD.conectar());
                insertFanta.ExecuteNonQuery();
                BD.conectar().Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR, OCURRIO ALGO DURANTE EL INSERT ");
            }

            BD bd = new BD();
            bd.VerificarConexion(dgvBDComprador, consulta);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
