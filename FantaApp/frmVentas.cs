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
    public partial class frmVentas : Form
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
        string consulta2;

        public frmVentas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
<<<<<<< HEAD
            consulta = "SELECT COMPRADOR.NOMBREC AS 'COMPRADOR', FANTA.SABOR, COMPRADOR.TELEFONO AS " +
                "'TELÉFONO DE COMPRADOR' FROM COMPRADOR, FANTA, VENTA WHERE VENTA.IDCOMPRADOR = COMPRADOR.IDCOMPRADOR " +
                "AND VENTA.IDFANTA = FANTA.IDFANTA";
=======
            consulta = "SELECT Cliente.Nombre_Cliente AS 'CLIENTE', Producto.Nombre_Producto AS 'PRODUCTO', Detalles_de_Orden.Total AS 'TOTAL' FROM Detalles_de_Orden, Producto, Cliente WHERE Detalles_de_Orden.Detalles_de_Orden_ID = Cliente.Cliente_ID AND Detalles_de_Orden.Producto_ID = Producto.Producto_ID";
            consulta2 = "SELECT Detalles_de_Orden.Cantidad, Detalles_de_Orden.Tipo_Pago, Detalles_de_Orden.Descuento, Detalles_de_Orden.Total FROM Detalles_de_Orden"; 
>>>>>>> 12494a492ebcfc2ebe19829e1205989e753e8159
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.VerificarConexion(dgvBDVentas, consulta);
            bd.VerificarConexion(dgvVentasDetalles, consulta2);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //Algo como el de Fanta pero sin ser las celdas diréctamente xd
            frmVentasAdd VentasAdd = new frmVentasAdd();
            VentasAdd.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
