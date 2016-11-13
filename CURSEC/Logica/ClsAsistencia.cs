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
    public class ClsAsistencia
    {
        private int idAsistencia;
        private int idHorario;
        private string identificacion;
        private DateTime fecha;
        private string asistio;
        private int idCurso;


        public int IdAsistencia
        {
            get
            {
                return idAsistencia;
            }

            set
            {
                idAsistencia = value;
            }
        }

        public int IdHorario
        {
            get
            {
                return idHorario;
            }

            set
            {
                idHorario = value;
            }
        }

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

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Asistio
        {
            get
            {
                return asistio;
            }

            set
            {
                asistio = value;
            }
        }

        public int IdCurso
        {
            get
            {
                return idCurso;
            }

            set
            {
                idCurso = value;
            }
        }

        public void registrarAsistencia() {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "INSERT INTO Asistencias(IdHorario,Identificacion,Fecha,asistio,idCurso)VALUES('"+idHorario+"','"+identificacion+"','"+fecha+"','"+asistio+"','"+idCurso+"')";
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se registro correctamente la asistencia", "Asistencia");
            }
            else {
                MessageBox.Show("No se registro correctamente la asistencia", "Asistencia");
            }
        }

        public DataSet listarAsistencias()
        {
            DataSet ds = new DataSet();
            string sentencia = "SELECT a.IdAsistencia,th.Etiqueta AS Horario,a.Identificacion,a.Fecha,a.asistio AS Asistio,ce.Descripcion AS Curso FROM Asistencias a JOIN TiposDeHorarios th ON a.IdHorario=th.IdTipoHorario JOIN CursosEntidades ce ON a.idCurso=ce.IdCurso";
            ClsConexion objConexion = new ClsConexion();
            ds = objConexion.consultar(sentencia);

            return ds;
        }

        public void actualizarAsistencia()
        {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "UPDATE Asistencias SET IdHorario='"+idHorario+"',Identificacion='"+identificacion+"',Fecha='"+fecha+"',asistio='"+asistio+"',idCurso='"+idCurso+ "'WHERE IdAsistencia="+idAsistencia;
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se actualizo correctamente la asistencia", "Asistencia");
            }
            else
            {
                MessageBox.Show("No se actualizo correctamente la asistencia", "Asistencia");
            }
        }

        public void eliminarAsistencia()
        {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "DELETE FROM Asistencias WHERE IdAsistencia=" + idAsistencia;
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se elimino exitosamente la asistencia", "Asistencia");
            }
            else
            {
                MessageBox.Show("No se elimino exitosamente la asistencia", "Asistencia");
            }
        }
    }
}
