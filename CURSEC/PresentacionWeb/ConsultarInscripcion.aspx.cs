using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class ConsultarInscripcion : System.Web.UI.Page
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
                    ddlCurso.DataSource = objCursoUsuario.listarCurso().Tables[0];
                    ddlCurso.DataTextField = "Descripcion";
                    ddlCurso.DataBind();
                    consultar();
                }
            }
        }

        public string buscarNombre()
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.Identificacion = Session["usuario"].ToString();
            return objDatoUsuario.buscarNombre().Tables[0].Rows[0][0].ToString();

        }

        public void consultar()
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            gvCurso.DataSource = objCursoUsuario.consultarInscripcion().Tables[0];
            gvCurso.DataBind();
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            if (!txtCodigo.Text.Equals(""))
            {
                objCursoUsuario.IdCursosUsuarios = int.Parse(txtCodigo.Text);
                objCursoUsuario.Descripcion = ddlCurso.Text;
                objCursoUsuario.Identificacion = Session["usuario"].ToString();
                if (objCursoUsuario.actualizarInscripcion1())
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "exito", "exito();", true);
                }else {
                    ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);
                }
                consultar();
            }
            else {
                ScriptManager.RegisterStartupScript(this, GetType(), "fallo1", "fallo1();", true);
            }
        }

        protected void gvCurso_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCurso.PageIndex = e.NewPageIndex;
            consultar();
        }

        protected void gvCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = gvCurso.SelectedRow.Cells[1].Text;
            ddlCurso.Text = gvCurso.SelectedRow.Cells[2].Text;
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!txtCodigo.Text.Equals(""))
            {
                ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
                objCursoUsuario.IdCursosUsuarios = int.Parse(txtCodigo.Text);
                objCursoUsuario.Identificacion = Session["usuario"].ToString();
                objCursoUsuario.eliminarInscripcion();
                ScriptManager.RegisterStartupScript(this, GetType(), "exito1", "exito1();", true);
                consultar();
            }
            else { ScriptManager.RegisterStartupScript(this, GetType(), "fallo1", "fallo1();", true); }
        }
    }
}