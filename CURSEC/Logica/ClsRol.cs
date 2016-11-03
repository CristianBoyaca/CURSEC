using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using System.Windows.Forms;

namespace Logica
{
    public class ClsRol
    {
        private int idRol;
        private string nombreRol;

        public int IdRol
        {
            get
            {
                return idRol;
            }

            set
            {
                idRol = value;
            }
        }

        public string NombreRol
        {
            get
            {
                return nombreRol;
            }

            set
            {
                nombreRol = value;
            }
        }

        public DataSet listarRoles()
        {

            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "SELECT * FROM Roles";
            ds = objConexion.consultar(sentencia);
            return ds;
        }
    }
}
