using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class CambiarContrasenia : System.Web.UI.Page
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
            ClsUsuario objUsuario = new ClsUsuario();
            gvUsuarios.DataSource = objUsuario.consultarTodos().Tables[0];
            gvUsuarios.DataBind();
        }

        protected void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            ClsUsuario objUsuario = new ClsUsuario();
            objUsuario.Identificacion = txtIdentificacion.Text;
            objUsuario.Contrasena = txtContrasenia.Text;
            if (objUsuario.Identificacion != "" && objUsuario.Contrasena != "")
            {
                objUsuario.cambiarContrasena();
                ScriptManager.RegisterStartupScript(this, GetType(), "exito", "exito();", true);
                consultar();
                limpiar();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);
            }
        }

        protected void gvUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUsuarios.PageIndex = e.NewPageIndex;
            consultar();
        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdentificacion.Text = gvUsuarios.SelectedRow.Cells[1].Text;
            
        }

        public void limpiar()
        {
            txtIdentificacion.Text="";
            txtContrasenia.Text="";
        }
    }
}