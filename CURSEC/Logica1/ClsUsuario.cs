using System.Windows.Forms;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsUsuario
    {
        private string identificacion;
        private string contrasena;
        private int estado;

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Contrasena
        {
            get
            {
                return contrasena;
            }

            set
            {
                contrasena = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

       
       
    public string iniciarSesion(int idRol)
        {
            string rol="";
            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia= "SELECT IdRol FROM Usuarios u JOIN RolesUsuarios ru ON u.Identificacion=ru.Identificacion WHERE u.Identificacion='" + identificacion + "'AND u.contrasena='" + contrasena + "'AND ru.IdRol='" +idRol+"'";

            ds = objConexion.consultar(sentencia);
            if (ds.Tables[0].Rows.Count==0) {
                rol="0";
            }
            else { rol =ds.Tables[0].Rows[0][0].ToString();
            }
            return rol;

        }

        /*public void registrarCiudad()
        {

            ClsConexion objConexion = new ClsConexion();
          
            string sentencia = "INSERT INTO ciudades(nombreCiudad) VALUES('" + nombreCiudad + "')";

            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Registro Exitoso");
            }
            else
            {
                MessageBox.Show("No se registro la ciudad ");
            }
        }

        public void actualizarCiudad()
        {

            ClsConexion objConexion = new ClsConexion();
            string sentencia = "UPDATE ciudaddes SET nombreCiudad='" + nombreCiudad + "' WHERE codigoCiudad=" + codigo;

            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Registro Exitoso");
            }
            else
            {
                MessageBox.Show("No se actualizo la ciudad ");
            }
        }


        public void eliminarCiudad()
        {

            ClsConexion objConexion = new ClsConexion();
            string sentencia = "DELETE FROM WHERE codigo=" + codigo;

            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Eliminación Exitosa");
            }
            else
            {
                MessageBox.Show("No se eliminó la ciudad ");
            }
        }*/

        public DataSet consultarTodos()
        {
            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "SELECT * FROM Usuarios";
            ds = objConexion.consultar(sentencia);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios");
            }
            return ds;
        }


    }
}