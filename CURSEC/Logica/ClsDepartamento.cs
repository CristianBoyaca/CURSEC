using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class ClsDepartamento
    {
        private int idDepartamento=0;
        private string nombreDepartamento="";

        public int IdDepartamento
        {
            get
            {
                return idDepartamento;
            }

            set
            {
                idDepartamento = value;
            }
        }

        public string NombreDepartamento
        {
            get
            {
                return nombreDepartamento;
            }

            set
            {
                nombreDepartamento = value;
            }
        }



        public DataSet listarDepartamentos()
        {
            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "SELECT * FROM Departamentos";
            ds = objConexion.consultar(sentencia);
            return ds;
        }
    }

}
