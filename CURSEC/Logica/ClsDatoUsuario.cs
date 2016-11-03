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
    public class ClsDatoUsuario
    {
        private string identificacion="";
        private string primerNombre="";
        private string segundoNombre="";
        private string primerApellido="";
        private string segundoApellido="";
        private DateTime fechaNacimiento = new DateTime();
        private int ciudadNacimiento=0;
        private int departamento=0;
        private string sexo="";
        private int cargo=0;
        private int area=0;
        private int idEntidad=0;
        private int rol = 0;

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

        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }

            set
            {
                primerNombre = value;
            }
        }

        public string SegundoNombre
        {
            get
            {
                return segundoNombre;
            }

            set
            {
                segundoNombre = value;
            }
        }

        public string PrimerApellido
        {
            get
            {
                return primerApellido;
            }

            set
            {
                primerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get
            {
                return segundoApellido;
            }

            set
            {
                segundoApellido = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public int CiudadNacimiento
        {
            get
            {
                return ciudadNacimiento;
            }

            set
            {
                ciudadNacimiento = value;
            }
        }

        public int Departamento
        {
            get
            {
                return departamento;
            }

            set
            {
                departamento = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public int Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public int Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

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

        public int Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }

        public void registrarUsuario() {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "INSERT INTO DatosUsuarios(Identificacion,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,FechaNacimiento,CiudadNacimiento,Departamento,Sexo,Cargo,Area,idEntidad) VALUES('" + identificacion +"','"+ primerNombre +"','"+ segundoNombre +"','"+ PrimerApellido +"','"+ SegundoApellido +"','"+ fechaNacimiento +"','"+ ciudadNacimiento +"','"+ departamento +"','"+ sexo +"','"+ cargo +"','"+ area +"','"+ idEntidad +"')";
            if (objConexion.ejecutar(sentencia)) {
                sentencia = "INSERT INTO Usuarios(Identificacion,contrasena,Estado) VALUES('"+ identificacion +"','"+"12345678"+"','"+"1"+"')";
                if (objConexion.ejecutar(sentencia)) {
                    sentencia = "INSERT INTO RolesUsuarios(IdRol,Identificacion) VALUES('" + rol +"','"+ identificacion + "')";
                    if (objConexion.ejecutar(sentencia))
                    {
                        MessageBox.Show("Se registro exitosamente el usuario");
                    }
                    else
                    {
                        MessageBox.Show("No se registro exitosamente el usuario");
                    }
                }
                else
                {
                    MessageBox.Show("No se registro exitosamente el usuario");
                }

            }
            else {
                MessageBox.Show("No se registro exitosamente el usuario");
            }
        }


        public void listarSecretarios(ComboBox cmb)
        {
            DataSet ds = new DataSet();
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "SELECT CONCAT(PrimerNombre,' ',PrimerApellido) FROM DatosUsuarios WHERE Cargo=3";
            ds = objConexion.consultar(sentencia);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb.Items.Add(ds.Tables[0].Rows[i][0]);
            }
            cmb.SelectedIndex = 0;
        }
    }
}
