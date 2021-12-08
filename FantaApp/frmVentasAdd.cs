using FANTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace FantaApp
{
    public partial class frmVentasAdd : Form
    {
        public DataGridView Dgv { get; set; }
        public DataTable contenidoOriginal = new DataTable();
        public frmVentasAdd()
        {
            InitializeComponent();
        }

        private void frmVentasAdd_Load(object sender, EventArgs e)
        {
            BD bd = new BD();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string consultaP = "SELECT Nombre_Producto AS 'Nombre', Tamaño_Envase AS 'Tamaño (ml)', Precio__Producto AS 'Precio', Existencia__Producto AS 'Existencia' FROM Producto";
            SqlCommand consultaProductos = new SqlCommand(consultaP, BD.conectar());
            SqlDataAdapter f = new SqlDataAdapter();
            f.SelectCommand = consultaProductos;
            DataTable datostabla1 = new DataTable();
            f.Fill(datostabla1);
            dgvBDProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBDProductos.DataSource = datostabla1;

            dgvOrdenNueva.Rows.Clear();

            lblTotalActual.Text = "0";
            numCantidad.Value = 0;
            cbxClientes.SelectedIndex = -1;
            lblClienteActual.Text = "****";

            cbxTdPago.SelectedIndex = -1;
            lblTipodePago.Text = "****";

            dgvBDProductos.Enabled = false;
            pbxMinus.Enabled = false;
            pbxPlus.Enabled = false;
            numCantidad.Enabled = false;
        }


        public void ExportarDatos(DataGridView dataListado)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();

            exportarExcel.Application.Workbooks.Add(true);

            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in dataListado.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
        }



        private void btnAñadir_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //oops
        }

        private string sacarNumeroOrden()
        {
            string consulta = "SELECT MAX(Orden_ID) FROM Orden";
            SqlCommand consultaClientes = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaClientes;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            string numeroOrden = ((int.Parse(datostabla.Rows[0][0].ToString())) + 1).ToString();
            return numeroOrden;
        }
        private void frmVentasAdd_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fANTA_BDDataSet.Producto' Puede moverla o quitarla según sea necesario.
            // this.productoTableAdapter.Fill(this.fANTA_BDDataSet.Producto);
            string consultaC = "SELECT Nombre_Cliente AS 'Nombre' FROM Cliente";

            //Clientes
            SqlCommand consultaClientes = new SqlCommand(consultaC, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaClientes;

            DataTable datostabla = new DataTable();

            r.Fill(datostabla);

            for (int i = 0; i < datostabla.Rows.Count; i++)
            {
                cbxClientes.Items.Add(datostabla.Rows[i][0].ToString());
            }

            //Fecha
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Productos
            string consultaP = "SELECT Nombre_Producto AS 'Nombre', Tamaño_Envase AS 'Tamaño (ml)', Precio__Producto AS 'Precio', Existencia__Producto AS 'Existencia' FROM Producto";
            SqlCommand consultaProductos = new SqlCommand(consultaP, BD.conectar());
            SqlDataAdapter f = new SqlDataAdapter();
            f.SelectCommand = consultaProductos;
            DataTable datostabla1 = new DataTable();
            f.Fill(datostabla1);
            dgvBDProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBDProductos.DataSource = datostabla1;

            //Misc
            lblNumeroOrden.Text = sacarNumeroOrden();
            dgvOrdenNueva.Columns.Add("Cant.", "Cant.");
            dgvOrdenNueva.Columns.Add("Nombre", "Nombre");
            dgvOrdenNueva.Columns.Add("Precio", "Precio");
            dgvOrdenNueva.Columns.Add("Total", "Total");

            cbxTdPago.Items.Add("Contado");
            cbxTdPago.Items.Add("Tarjeta");
            cbxTdPago.Items.Add("Transferencia Bancaria");
            cbxTdPago.Items.Add("Paypal");
        }

        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClientes.SelectedItem != null)
            {
                lblClienteActual.Text = cbxClientes.SelectedItem.ToString();
            }

            if (cbxClientes.SelectedItem != null && cbxTdPago.SelectedItem != null)
            {
                dgvBDProductos.Enabled = true;
                pbxMinus.Enabled = true;
                pbxPlus.Enabled = true;
                numCantidad.Enabled = true;
            }
        }

        private bool yaExiste(string nombreProducto)
        {
            for (int i = 0; i < dgvOrdenNueva.Rows.Count; i++)
            {
                if (dgvOrdenNueva.Rows[i].Cells[1].Value.ToString() == nombreProducto)
                {
                    return true;
                }
            }
            return false;
        }
        private int indexOrden(string nombreProducto)
        {
            for (int i = 0; i < dgvOrdenNueva.Rows.Count; i++)
            {
                if (dgvOrdenNueva.Rows[i].Cells[1].Value.ToString() == nombreProducto)
                {
                    return i;
                }
            }
            return 0;
        }
        private int cantOrden(string nombreProducto)
        {
            for (int i = 0; i < dgvOrdenNueva.Rows.Count; i++)
            {
                if (dgvOrdenNueva.Rows[i].Cells[1].Value.ToString() == nombreProducto)
                {
                    return int.Parse(dgvOrdenNueva.Rows[i].Cells[0].Value.ToString());
                }
            }
            return 0;
        }
        private int cantInventario(string nombreProducto)
        {
            string consulta = "SELECT Existencia__Producto AS 'Cantidad en Inventario' FROM Producto WHERE Nombre_Producto = '" + nombreProducto + "'";
            SqlCommand consultaInventario = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaInventario;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            return (int)datostabla.Rows[0][0];
        }
        private bool checarInventario(int cantRequerida, bool masMenos, string nombreProducto)
        {
            if (masMenos == false && cantRequerida > cantOrden(nombreProducto))
            {
                return false;
            }
            else if (masMenos == true && cantRequerida > int.Parse(dgvBDProductos.Rows[dgvBDProductos.CurrentCell.RowIndex].Cells[3].Value.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void actualizarTotal()
        {
            double acum = 0;
            for (int i = 0; i < dgvOrdenNueva.Rows.Count; i++)
            {
                acum += Convert.ToDouble(dgvOrdenNueva.Rows[i].Cells[3].Value);
            }
            lblTotalActual.Text = acum.ToString();
        }
        private void pbxMinus_Click(object sender, EventArgs e)
        {
            int nuevaCantidad;
            int cantidadRequerida = (int)numCantidad.Value;
            string nombreProducto = dgvBDProductos.Rows[dgvBDProductos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (cantidadRequerida == cantOrden(nombreProducto) && cantidadRequerida != 0)
            {
                dgvOrdenNueva.Rows.RemoveAt(indexOrden(nombreProducto));
                actualizarInventario(false, 0, nombreProducto);
            }
            else if (checarInventario(cantidadRequerida, false, nombreProducto))
            {
                nuevaCantidad = (int.Parse(dgvOrdenNueva.Rows[indexOrden(nombreProducto)].Cells[0].Value.ToString())) - ((int)numCantidad.Value);
                dgvOrdenNueva.Rows[indexOrden(nombreProducto)].Cells[0].Value = nuevaCantidad;
                double nuevoTotal = nuevaCantidad * (Convert.ToDouble(dgvOrdenNueva.Rows[indexOrden(nombreProducto)].Cells[2].Value.ToString()));
                dgvOrdenNueva.Rows[indexOrden(nombreProducto)].Cells[3].Value = nuevoTotal;
                actualizarInventario(true, nuevaCantidad, nombreProducto);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la accion");
            }
            actualizarTotal();
            activarAdd();
        }

        private void pbxPlus_Click(object sender, EventArgs e)
        {
            int nuevaCantidad;
            int catidadRequerida = (int)numCantidad.Value;
            string nombreProducto = dgvBDProductos.Rows[dgvBDProductos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (!yaExiste(nombreProducto) && checarInventario(catidadRequerida, true, nombreProducto))
            {
                int cantidad = (int)numCantidad.Value;
                double precio = (double)dgvBDProductos.Rows[dgvBDProductos.CurrentCell.RowIndex].Cells[2].Value;
                double total = precio * cantidad;
                dgvOrdenNueva.Rows.Add(cantidad.ToString(), dgvBDProductos.Rows[dgvBDProductos.CurrentCell.RowIndex].Cells[0].Value.ToString(), precio.ToString(), total.ToString());
                actualizarInventario(true, cantidad, nombreProducto);
            }
            else if (checarInventario(catidadRequerida, true, nombreProducto))
            {
                string test = dgvOrdenNueva.Rows[indexOrden(nombreProducto)].Cells[0].Value.ToString();
                nuevaCantidad = (int.Parse(dgvOrdenNueva.Rows[indexOrden(nombreProducto)].Cells[0].Value.ToString())) + ((int)numCantidad.Value);
                dgvOrdenNueva.Rows[indexOrden(nombreProducto)].Cells[0].Value = nuevaCantidad;
                double nuevoTotal = nuevaCantidad * (Convert.ToDouble(dgvOrdenNueva.Rows[indexOrden(nombreProducto)].Cells[2].Value.ToString()));
                dgvOrdenNueva.Rows[indexOrden(nombreProducto)].Cells[3].Value = nuevoTotal;
                actualizarInventario(true, nuevaCantidad, nombreProducto);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la accion");
            }
            actualizarTotal();
            activarAdd();
        }

        private void actualizarInventario(bool masMenos, int cantidad, string nombreProducto)
        {
            int nuevoInv = 0;
            if (masMenos == true)
            {
                nuevoInv = cantInventario(nombreProducto) - cantidad;
            }
            else if (masMenos == false)
            {
                nuevoInv = cantInventario(nombreProducto) + cantidad;
            }
            dgvBDProductos.Rows[dgvBDProductos.CurrentCell.RowIndex].Cells[3].Value = nuevoInv;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (dgvOrdenNueva.Rows.Count == 0)
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                //Subir Orden
                string insertO = "INSERT INTO Orden VALUES (" + sacarNumeroOrden() + ", '" + lblFechaActual.Text + "', " + sacarClienteID() + ")";
                SqlCommand insertOrden = new SqlCommand(insertO, BD.conectar());
                insertOrden.ExecuteNonQuery();
                BD.conectar().Close();



                //Subir subs detalles
                for (int i = 0; i < dgvOrdenNueva.Rows.Count; i++)
                {
                    string insertDdO = "INSERT INTO Detalles_de_Orden VALUES (" +
                        sacarNumeroDdO() + ", " +
                        dgvOrdenNueva.Rows[i].Cells[0].Value.ToString() + ", '" +
                        lblTipodePago.Text + "', " +
                        "0" + ", " +
                        dgvOrdenNueva.Rows[i].Cells[3].Value.ToString() + ", " +
                        sacarProductoID(dgvOrdenNueva.Rows[i].Cells[1].Value.ToString()) + ", " +
                        lblNumeroOrden.Text + ")";
                    SqlCommand insertDetallesdeOrden = new SqlCommand(insertDdO, BD.conectar());
                    insertDetallesdeOrden.ExecuteNonQuery();
                    BD.conectar().Close();

                    string cadenaInventario = "UPDATE Producto SET Existencia__Producto = " + dgvBDProductos.Rows[getProductosIndexFromValue(dgvOrdenNueva.Rows[i].Cells[1].Value.ToString())].Cells[3].Value.ToString() + " WHERE Nombre_Producto = '" + dgvOrdenNueva.Rows[i].Cells[1].Value.ToString() + "'";
                   SqlCommand updateInventario = new SqlCommand(cadenaInventario, BD.conectar());
                    updateInventario.ExecuteNonQuery();
                    BD.conectar().Close();
                }
                // Modificar esto de abajo para al momento que se cierra la ventana se muestre la tabla actualizada

                BD bd = new BD();
                string consulta = "SELECT Orden.Orden_ID AS 'No. Orden', Nombre_Cliente AS 'Cliente', Fecha_Orden AS 'Fecha' FROM Cliente, Orden WHERE Orden.Cliente_ID = Cliente.Cliente_ID";
                bd.VerificarConexion(Dgv, consulta);

                this.Close();
            }
        }

        private int getProductosIndexFromValue(string nombre)
        {
            for (int i = 0; i < dgvBDProductos.Rows.Count; i++)
            {
                if (dgvBDProductos.Rows[i].Cells[0].Value.ToString() == nombre)
                {
                    return i;
                }
            }
            return 0;
        }
        private void activarAdd()
        {
            if (dgvOrdenNueva.Rows.Count == 0)
            {
                lblErrorVacio.Visible = true;
                btnAñadir.Enabled = false;
            }
            else
            {
                lblErrorVacio.Visible = false;
                btnAñadir.Enabled = true;
            }
        }
        private string sacarClienteID()
        {
            string consulta = "SELECT Cliente_ID AS 'ID' FROM Cliente WHERE Nombre_Cliente = '" + cbxClientes.SelectedItem.ToString() + "'";
            SqlCommand consultaOrden = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaOrden;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            return datostabla.Rows[0][0].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxTdPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTdPago.SelectedItem != null)
            {
                lblTipodePago.Text = cbxTdPago.SelectedItem.ToString();
            }

            if (cbxClientes.SelectedItem != null && cbxTdPago.SelectedItem != null)
            {
                dgvBDProductos.Enabled = true;
                pbxMinus.Enabled = true;
                pbxPlus.Enabled = true;
                numCantidad.Enabled = true;
            }
        }
        private string sacarNumeroDdO()
        {
            string consulta = "SELECT MAX(Detalles_de_Orden_ID) FROM Detalles_de_Orden";
            SqlCommand consultaClientes = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaClientes;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            string numeroDdO = ((int.Parse(datostabla.Rows[0][0].ToString())) + 1).ToString();
            return numeroDdO;
        }

        private string sacarProductoID(string nombre)
        {
            string consulta = "SELECT Producto_ID AS 'ID' FROM Producto WHERE Nombre_Producto = '" + nombre + "'";
            SqlCommand consultaOrden = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaOrden;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            return datostabla.Rows[0][0].ToString();
        }

        private void dgvBDProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}