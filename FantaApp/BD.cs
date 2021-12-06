using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace FANTA
{
    class BD
    {
        public string PC { get; set; }
        public static SqlConnection conectar()
        {
            //Deivid = DEIVID-PC
            //Ines creo = DESKTOP-3HAD2EJ
            SqlConnection bdconectar = new SqlConnection(@"Data Source=DESKTOP-3HAD2EJ;Initial Catalog=FANTA_BD;Integrated Security=True");
            //CAMBIAR LAS CREDENCIALES DE CONEXION POR LAS SUYAS

            try
            {
                bdconectar.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la Conexión /nConexión no Establecida.");
            }
            return bdconectar;
        }

        public void VerificarConexion(DataGridView tabla, string consulta)
        {
            try
            {
                SqlCommand consultatabla = new SqlCommand(consulta, BD.conectar());
                SqlDataAdapter r = new SqlDataAdapter(); //adaptador1

                //asignamos los datos de la consulta a los adaptadores
                r.SelectCommand = consultatabla;

                //creamos objetos datatable para llenar las tablas con la info
                DataTable datostabla = new DataTable();

                //llenamos el objeto tablabotes con la info de la consulta
                r.Fill(datostabla);
                tabla.DataSource = datostabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Conexión /nError durante la consulta.");
            }
        }
    }
}


