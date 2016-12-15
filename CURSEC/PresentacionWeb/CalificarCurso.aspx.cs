using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class CalificarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"].Equals(""))
                {
                    Response.Redirect("InicioSesion.aspx");
                }
                else
                {
                    lblNombre.Text = buscarNombre();
                    ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
                    ddlCurso.DataSource = objCursoUsuario.listarInscripcion().Tables[0];
                    ddlCurso.DataTextField = "Descripcion";
                    ddlCurso.DataValueField = "IdCurso";
                    ddlCurso.DataBind();

                }
            }
        }

        public string buscarNombre()
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.Identificacion = Session["usuario"].ToString();
            return objDatoUsuario.buscarNombre().Tables[0].Rows[0][0].ToString();

        }
        protected void btnCalificarCurso_Click(object sender, EventArgs e)
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            objCursoUsuario.IdCurso = int.Parse(ddlCurso.SelectedValue.ToString());
            objCursoUsuario.Calificacion = int.Parse(ddlCalificacion.Text);

            if (objCursoUsuario.calificarCurso())
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "exito", "exito();", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);
            }

        }
    }
}