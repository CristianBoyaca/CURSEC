using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace PresentacionWeb
{
    public partial class InicioSesion : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsRol objRol = new ClsRol();
                ddlRoles.DataSource = objRol.listarRoles().Tables[0];
                ddlRoles.DataTextField = "NombreRol";
                ddlRoles.DataValueField = "idRol";
                ddlRoles.DataBind();
            }

        }
        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            ClsUsuario objUsuario = new ClsUsuario();
            objUsuario.Identificacion = txtIdentificacion.Text;
            objUsuario.Contrasena = txtContrasenia.Text;
            if (validarCampos())
            {
                if (!objUsuario.iniciarSesion(int.Parse(ddlRoles.SelectedValue.ToString())).Equals("0"))
                {
                    Session["usuario"] = txtIdentificacion.Text;
                    Session["rol"] = ddlRoles.SelectedValue.ToString();
                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "validar", "validar();", true);
            }
            
        }

        public bool validarCampos()
        {
            bool validador = false;
            if (!txtIdentificacion.Text.Equals("") && !txtContrasenia.Text.Equals(""))
            {
                validador = true;
            }
            return validador;
        }

    }
}