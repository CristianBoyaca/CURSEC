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
    public class ClsEntidad
    {
        private int idEntidad;
        private string nombreSecretaria;
        private string nombreSecretario;
        private string direccionSe;
        private string telefono;

        public int IdEntidad
        {
            get
            {
                return idEntidad;
            }

            set
            {
                idEntidad = value;
            }
        }

        public string NombreSecretaria
        {
            get
            {
                return nombreSecretaria;
            }

            set
            {
                nombreSecretaria = value;
            }
        }

        public string NombreSecretario
        {
            get
            {
                return nombreSecretario;
            }

            set
            {
                nombreSecretario = value;
            }
        }

        public string DireccionSe
        {
            get
            {
                return direccionSe;
            }

            set
            {
                direccionSe = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public DataSet listarEntidades() {
            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia="SELECT * FROM Entidades";
            ds = objConexion.consultar(sentencia);
            return ds;
        }
    }

}
