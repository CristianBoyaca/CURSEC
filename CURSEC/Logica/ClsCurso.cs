using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;
using System.Data;

namespace Logica
{
   public class ClsCurso
    {
        private int idEntidad;
        private string descripcion;
        private int valor;
        private int maxAsistentes;
        private DateTime fechaInicial;
        private DateTime fechaFinal;
        private int idCurso;
        private int idTipoHorario;
        private DateTime horaInicial;
        private DateTime horaFinal;
        private int cantidadHoras;
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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public int MaxAsistentes
        {
            get
            {
                return maxAsistentes;
            }

            set
            {
                maxAsistentes = value;
            }
        }

        public DateTime FechaInicial
        {
            get
            {
                return fechaInicial;
            }

            set
            {
                fechaInicial = value;
            }
        }

        public DateTime FechaFinal
        {
            get
            {
                return fechaFinal;
            }

            set
            {
                fechaFinal = value;
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

        public int IdTipoHorario
        {
            get
            {
                return idTipoHorario;
            }

            set
            {
                idTipoHorario = value;
            }
        }

        public DateTime HoraInicial
        {
            get
            {
                return horaInicial;
            }

            set
            {
                horaInicial = value;
            }
        }

        public DateTime HoraFinal
        {
            get
            {
                return horaFinal;
            }

            set
            {
                horaFinal = value;
            }
        }

        public int CantidadHoras
        {
            get
            {
                return cantidadHoras;
            }

            set
            {
                cantidadHoras = value;
            }
        }

        public void registrarCurso()
        {
           ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia;
           

           sentencia = "INSERT INTO CursosEntidades(IdEntidad,Descripcion,Valor,MaxAsistentes,FechaInicialInscripcion,FechaFinalInscripcion,cantidadHoras) VALUES('"+idEntidad+"','"+ descripcion+"','"+valor+"','"+maxAsistentes+"','"+fechaInicial+"','"+fechaFinal+"','"+cantidadHoras+"')";
            if (objConexion.ejecutar(sentencia))
            {
                sentencia = "SELECT MAX(IdCurso)FROM CursosEntidades";
                ds = objConexion.consultar(sentencia);
                idCurso = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                sentencia = "INSERT INTO Horarios(IdCurso,IdTipoHorario,HoraInicial,HoraFinal)VALUES('" + idCurso + "','" + idTipoHorario + "','" + horaInicial + "','" + horaFinal + "')";
                if (objConexion.ejecutar(sentencia))
                {
                    MessageBox.Show("Se registro el curso exitosamente", "Creación Curso");
                }
                else { MessageBox.Show("No se registro el curso exitosamente", "Creación Curso"); }

               
            }
            else {
                MessageBox.Show("No se registro el curso exitosamente", "Creación Curso");
            }


        }

        public void actualizarCurso()
        {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "UPDATE CursosEntidades SET IdEntidad='"+idEntidad+ "',Descripcion='"+descripcion+ "',Valor='"+valor+ "',MaxAsistentes='"+maxAsistentes+ "',FechaInicialInscripcion='"+fechaInicial+ "',FechaFinalInscripcion='"+fechaFinal+ "',cantidadHoras='"+cantidadHoras+"'WHERE IdCurso="+idCurso;
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se actualizo el curso exitosamente", "Actualización Curso");
            }
            else
            {
                MessageBox.Show("No se actualizo el curso exitosamente", "Actualización Curso");

            }
        }
        
        public DataSet  listarCurso() {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia = "SELECT  IdCurso,e.NombreSecretaria,Descripcion,Valor,MaxAsistentes,FechaInicialInscripcion,FechaFinalInscripcion,cantidadHoras FROM CursosEntidades ce JOIN Entidades e ON ce.IdEntidad=e.IdEntidad";
            ds = objConexion.consultar(sentencia);
            return ds;
        }

        public DataSet listarCursos()
        {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia = "SELECT  * FROM CursosEntidades";
            ds = objConexion.consultar(sentencia);
            return ds;
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

    }
}
