using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClsTipoHorario
    {
        private string etiqueta;

        public string Etiqueta
        {
            get
            {
                return etiqueta;
            }

            set
            {
                etiqueta = value;
            }
        }


        public DataSet listarTiposHorarios()
        {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia = "SELECT * FROM TiposDeHorarios";
            ds = objConexion.consultar(sentencia);

            return ds;
        }

        public DataSet listarTiposHorarios(int idCurso)
        {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia = "SELECT DISTINCT th.IdTipoHorario,th.Etiqueta FROM TiposDeHorarios th JOIN Horarios h ON th.IdTipoHorario=h.IdTipoHorario WHERE h.IdCurso='"+idCurso+"'";
            ds=objConexion.consultar(sentencia);

            return ds;
        }
    }
}
