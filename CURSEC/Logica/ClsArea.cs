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
    public class ClsArea
    {
        private int idArea=0;
        private string nombreArea="";

        public int IdArea
        {
            get
            {
                return idArea;
            }

            set
            {
                idArea = value;
            }
        }

        public string NombreArea
        {
            get
            {
                return nombreArea;
            }

            set
            {
                nombreArea = value;
            }
        }

        public DataSet listarAreas() {
            DataSet ds = new DataSet();
            string sentencia = "SELECT * FROM Areas";
            ClsConexion objConexion = new ClsConexion();
            ds=objConexion.consultar(sentencia);

            return ds;
        }
    }
}
