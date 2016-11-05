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
        private int idEntidad=0;
        private string nombreSecretaria="";
        private string nombreSecretario="";
        private string direccionSe="";
        private string telefono="";

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

        public void registrarSecretaria()
        {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "INSERT INTO Entidades(NombreSecretaria,NombreSecretario,DireccionSe,Telefono)VALUES ('"+nombreSecretaria+"','"+nombreSecretario+"','"+direccionSe+"','"+telefono+"')";
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se registro exitosamente la secretaria","Secretaria");
            }
            else {
                MessageBox.Show("No se registro exitosamente la secretaria", "Secretaria");
            }
        }

        public void actualizarEntidad() {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "UPDATE Entidades SET NombreSecretaria='"+nombreSecretaria+ "',NombreSecretario='"+nombreSecretario+ "',DireccionSe='"+direccionSe+ "',Telefono='"+telefono+"'WHERE IdEntidad="+idEntidad;
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se actualizo exitosamente la secretaria", "Secretaria");
            }
            else
            {
                MessageBox.Show("No se actualizo exitosamente la secretaria", "Secretaria");
            }
        }


        public void eliminarEntidad()
        {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "DELETE Entidades WHERE IdEntidad=" + idEntidad;
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se elimino exitosamente la secretaria", "Secretaria");
            }
            else
            {
                MessageBox.Show("No se elimino exitosamente la secretaria", "Secretaria");
            }
        }
        public DataSet listarSecretarias()
        {
            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "SELECT * FROM Entidades";
            ds = objConexion.consultar(sentencia);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron secretarias");
            }
            return ds;
        }
    }
    }


