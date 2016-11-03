using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Logica
{
    public class ClsCiudad
    {
        private int idCiudad;
        private string nombreCiudad;
        private int idDepartamento;

        public int IdCiudad
        {
            get
            {
                return idCiudad;
            }

            set
            {
                idCiudad = value;
            }
        }

        public string NombreCiudad
        {
            get
            {
                return nombreCiudad;
            }

            set
            {
                nombreCiudad = value;
            }
        }

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

        public void listarCiudades(ComboBox cmb)
        {
            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "SELECT NombreCiudad FROM Ciudades";
            ds = objConexion.consultar(sentencia);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb.Items.Add(ds.Tables[0].Rows[i]["NombreCiudad"]);
            }
            cmb.SelectedIndex=0;
        }
    }
}
