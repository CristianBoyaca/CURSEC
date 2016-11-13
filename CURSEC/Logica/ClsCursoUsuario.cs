﻿using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Logica
{
    public class ClsCursoUsuario
    {
        private int idCurso;
        private string identificacion;
        private int calificacion;

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

        public int Calificacion
        {
            get
            {
                return calificacion;
            }

            set
            {
                calificacion = value;
            }
        }

        public DataSet listarCurso()
        {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia = "SELECT ce.IdCurso,ce.Descripcion,ce.Valor,ce.MaxAsistentes,ce.FechaInicialInscripcion,ce.FechaFinalInscripcion FROM CursosEntidades ce JOIN Entidades e ON ce.IdEntidad=e.IdEntidad JOIN DatosUsuarios d ON e.IdEntidad=d.idEntidad WHERE d.Identificacion='" + ClsSesion.documento+"'";
            ds=objConexion.consultar(sentencia);
            return ds;
        }

        public void inscribirCurso()
        {
            ClsConexion objConexion = new ClsConexion();
            if (validarInscripcion() == false) { 
            string sentencia = "INSERT INTO CursosUsuarios(IdCurso,Identificacion)VALUES('"+idCurso+"','"+Identificacion+"')";
            

            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se inscribio exitosamente al curso","Inscripción");
            }
            else
            {
                MessageBox.Show("No se inscribio exitosamente al curso", "Inscripción");
            }
            }
            else { MessageBox.Show("Usuario ya se encuentra inscrito en este curso","Inscripción"); }
        }

        public bool validarInscripcion() {

            bool verificador;
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia = "SELECT cu.IdCursosUsuarios AS Codigo,ce.Descripcion AS Curso,cu.Identificacion  FROM CURSOSUSUARIOS cu JOIN CursosEntidades ce ON cu.IdCurso=ce.IdCurso WHERE cu.Identificacion='" + ClsSesion.documento + "'AND ce.IdCurso='" + idCurso+"'";
            ds = objConexion.consultar(sentencia);
            if (ds.Tables[0].Rows.Count == 0)
            {
                verificador = false;
            }
            else
            {
                verificador = true;
            }

            return verificador;
        }

        public DataSet consultarInscripcion()
        {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia= "SELECT cu.IdCursosUsuarios AS Codigo,ce.Descripcion AS Curso,cu.Identificacion  FROM CURSOSUSUARIOS cu JOIN CursosEntidades ce ON cu.IdCurso=ce.IdCurso WHERE Identificacion='" + ClsSesion.documento+"'";
            ds=objConexion.consultar(sentencia);
            return ds;

        }

        public DataSet listarInscripcion()
        {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia = "SELECT cu.IdCurso,ce.Descripcion FROM CURSOSUSUARIOS cu JOIN CursosEntidades ce ON cu.IdCurso=ce.IdCurso WHERE Identificacion='" + ClsSesion.documento + "'";
            ds = objConexion.consultar(sentencia);
            return ds;

        }

        public DataSet listarDocumentos(int idCurso)
        {
            ClsConexion objConexion = new ClsConexion();
            DataSet ds = new DataSet();
            string sentencia = "SELECT Identificacion FROM CursosUsuarios WHERE IdCurso='"+idCurso+"'";
            ds = objConexion.consultar(sentencia);
            return ds;
        }

        public  void actualizarInscripcion()
        {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "UPDATE CursosUsuarios SET IdCurso='"+idCurso+"'WHERE Identificacion="+ClsSesion.documento;
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se actualizo exitosamente su inscripción al curso","Actualización Inscripción");
            }else
            {
                MessageBox.Show("No se actualizo exitosamente su inscripción al curso", "Actualización Inscripción");
            }

        }

        public void calificarCurso()
        {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "UPDATE CursosUsuarios SET Calificacion='" + calificacion + "'WHERE Identificacion=" + ClsSesion.documento + "AND IdCurso="+idCurso;
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se registro exitosamente la calificación del curso", "Calificación Curso");
            }
            else
            {
                MessageBox.Show("No se registro exitosamente la calificación del curso", "Calificación Curso");
            }

        }

        public void eliminarInscripcion()
        {
            ClsConexion objConexion = new ClsConexion();
            string sentencia = "DELETE FROM CursosUsuarios WHERE IdCurso="+idCurso+"AND Identificacion="+ClsSesion.documento;
            if (objConexion.ejecutar(sentencia))
            {
                MessageBox.Show("Se elimino exitosamente su inscripción al curso", "Eliminación De Inscripción");
            }
            else
            {
                MessageBox.Show("No se elimino exitosamente su inscripción al curso", "Eliminación De Inscripción");
            }
        }
    }
}