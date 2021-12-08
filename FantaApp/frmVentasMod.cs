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
    public partial class frmVentasMod : Form
    {
        public DataGridView Dgv { get; set; }
        public string numOrden;
        public frmVentasMod(string num)
        {
            InitializeComponent();
            numOrden = num;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getCliente()
        {
            string consulta = "SELECT Nombre_Cliente FROM Cliente, Orden WHERE Cliente.Cliente_ID = Orden.Cliente_ID AND Orden_ID = " + numOrden;
            SqlCommand consultaOrden = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaOrden;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            return datostabla.Rows[0][0].ToString();
        }
        public string getTdP()
        {
            string consulta = "SELECT Tipo_Pago FROM Detalles_de_Orden, Orden WHERE Detalles_de_Orden.Orden_ID = Orden.Orden_ID AND Orden.Orden_ID = " + numOrden + " GROUP BY Tipo_Pago";
            SqlCommand consultaOrden = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaOrden;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            return datostabla.Rows[0][0].ToString();
        }
        public string getFecha()
        {
            string consulta = "SELECT Fecha_Orden FROM Orden WHERE Orden_ID = " + numOrden;
            SqlCommand consultaOrden = new SqlCommand(consulta, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter();
            r.SelectCommand = consultaOrden;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            return datostabla.Rows[0][0].ToString();
        }
        private void frmVentasMod_Load(object sender, EventArgs e)
        {
            //Productos
            string consultaP = "SELECT Nombre_Producto AS 'Nombre', Tamaño_Envase AS 'Tamaño (ml)', Precio__Producto AS 'Precio', Existencia__Producto AS 'Existencia' FROM Producto";
            SqlCommand consultaProductos = new SqlCommand(consultaP, BD.conectar());
            SqlDataAdapter f = new SqlDataAdapter();
            f.SelectCommand = consultaProductos;
            DataTable datostabla1 = new DataTable();
            f.Fill(datostabla1);
            dgvBDProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBDProductos.DataSource = datostabla1;

            //Detalles de Orden
            dgvOrdenNueva.Columns.Add("Cant.", "Cant.");
            dgvOrdenNueva.Columns.Add("Nombre", "Nombre");
            dgvOrdenNueva.Columns.Add("Precio", "Precio");
            dgvOrdenNueva.Columns.Add("Total", "Total");
            string mostrarDetalles = "SELECT Cantidad, Nombre_Producto AS 'Nombre', Precio__Producto AS 'Precio', " +
                "Total FROM Detalles_de_Orden, Producto WHERE Detalles_de_Orden.Producto_ID = Producto.Producto_ID AND Orden_ID = " + numOrden;
            SqlCommand consultatabla = new SqlCommand(mostrarDetalles, BD.conectar());
            SqlDataAdapter r = new SqlDataAdapter(); 
            r.SelectCommand = consultatabla;
            DataTable datostabla = new DataTable();
            r.Fill(datostabla);
            for (int i = 0; i < datostabla.Rows.Count; i++)
            {
                dgvOrdenNueva.Rows.Add(datostabla.Rows[i][0].ToString(), datostabla.Rows[i][1].ToString(), datostabla.Rows[i][2].ToString(), datostabla.Rows[i][3].ToString());
            }

            //Cliente
            cbxClientes.Items.Add(getCliente());
            cbxClientes.SelectedIndex = 0;

            //Tipo de Pago
            cbxTdPago.Items.Add(getTdP());
            cbxTdPago.SelectedIndex = 0;

            //Labels
            lblNumeroOrden.Text = numOrden;
            lblClienteActual.Text = getCliente();
            lblTipodePago.Text = getTdP();
            lblFechaActual.Text = getFecha();
            actualizarTotal();
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
        private int indexProducto(string nombreProducto)
        {
            for (int i = 0; i < dgvBDProductos.Rows.Count; i++)
            {
                if (dgvBDProductos.Rows[i].Cells[0].Value.ToString() == nombreProducto)
                {
                    return i;
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
        private void actualizarInventario(bool masMenos, int cantidad, string nombreProducto)
        {
            int nuevoInv = 0;
            if (masMenos == true)
            {
                nuevoInv = int.Parse(dgvBDProductos.Rows[dgvBDProductos.CurrentCell.RowIndex].Cells[3].Value.ToString()) - (int)numCantidad.Value;
            }
            else if (masMenos == false)
            {
                nuevoInv = int.Parse(dgvBDProductos.Rows[dgvBDProductos.CurrentCell.RowIndex].Cells[3].Value.ToString()) + (int)numCantidad.Value;
            }
            dgvBDProductos.Rows[dgvBDProductos.CurrentCell.RowIndex].Cells[3].Value = nuevoInv;
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
                actualizarInventario(false, nuevaCantidad, nombreProducto);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string nomProducto = "";
            for (int i = 0; i < dgvOrdenNueva.Rows.Count; i++)
            {
                nomProducto = dgvOrdenNueva.Rows[i].Cells[1].Value.ToString();
                dgvBDProductos.Rows[indexProducto(nomProducto)].Cells[3].Value = int.Parse(dgvBDProductos.Rows[indexProducto(nomProducto)].Cells[3].Value.ToString()) + int.Parse(dgvOrdenNueva.Rows[i].Cells[0].Value.ToString());
            }
            dgvOrdenNueva.Rows.Clear();
            lblTotalActual.Text = "0";
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (dgvOrdenNueva.Rows.Count == 0)
            {
                lblErrorVacio.Visible = true;
            }
            else
            {
                //Actualizar Orden
                string insertO = "UPDATE Orden SET Fecha_Orden = '" + DateTime.Now.Date.ToString() + "' WHERE Orden_ID = " + numOrden;
                SqlCommand insertOrden = new SqlCommand(insertO, BD.conectar());
                insertOrden.ExecuteNonQuery();
                BD.conectar().Close();



                //Subir subs detalles
                string deleto = "DELETE FROM Detalles_de_Orden WHERE Orden_ID = " + numOrden;
                SqlCommand deletAll = new SqlCommand(deleto, BD.conectar());
                deletAll.ExecuteNonQuery();
                BD.conectar().Close();
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
    }
}
