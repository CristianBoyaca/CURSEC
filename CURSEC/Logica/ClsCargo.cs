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
    public class ClsCargo
    {
        private int idCargo;
        private string nombreCargo;

        public int IdCargo
        {
            get
            {
                return idCargo;
            }

            set
            {
                idCargo = value;
            }
        }

        public string NombreCargo
        {
            get
            {
                return nombreCargo;
            }

            set
            {
                nombreCargo = value;
            }
        }

        public void listarCargos(ComboBox cmb)
        {
            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "SELECT NombreCargo FROM Cargos";
            ds = objConexion.consultar(sentencia);
            for (int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                cmb.Items.Add(ds.Tables[0].Rows[i]["NombreCargo"]);
            }
            cmb.SelectedIndex = 0;
        }
    }
}
