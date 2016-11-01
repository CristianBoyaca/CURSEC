using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class ClsConexion
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataSet ds;


        public void conectar()
        {
            try
            {
                conexion = new SqlConnection("Data Source=localhost;Initial Catalog=CURSEC;User Id=admin;Password=123456");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void desconectar()
        {
            conexion.Close();
        }

        public bool ejecutar(string sentencia)
        {
            bool verificar;
            conectar();
            comando = new SqlCommand();
            try
            {
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
                verificar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                verificar = false;
            }
            desconectar();
            return verificar;
        }

        public DataSet consultar(string sentencia)
        {
            conectar();
            ds = new DataSet();
            try
            {
                adaptador = new SqlDataAdapter(sentencia, conexion);
                adaptador.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            desconectar();
            return ds;
        }
    }
}
