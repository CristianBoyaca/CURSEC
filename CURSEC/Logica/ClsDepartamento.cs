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
        private int idDepartamento;
        private string nombreDepartamento;

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



        public void listarDepartamentos(ComboBox cmb)
        {
            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "SELECT NombreDepartamento FROM Departamentos";
            ds = objConexion.consultar(sentencia);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb.Items.Add(ds.Tables[0].Rows[i]["NombreDepartamento"]);
            }
            cmb.SelectedIndex = 0;
        }
    }

}
