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

//HOLA PORFAVOR ACTUALIZATEEEEEE
//AHORA TOCA IMPORTAR, SOS PLAN

namespace FantaApp
{
    public partial class frmMain : Form
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

        public frmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí no hay nada para explorar");
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFanta_Click(object sender, EventArgs e)
        {
            frmFanta Fantas = new frmFanta();
            Fantas.Show();
        }

        private void btnOpenVentas_Click(object sender, EventArgs e)
        {
            frmVentas Ventas = new frmVentas();
            Ventas.Show();
        }

        private void btnOpenCompradores_Click(object sender, EventArgs e)
        {
            frmComprador Compradores = new frmComprador();
            Compradores.Show();
        }
    }
}
