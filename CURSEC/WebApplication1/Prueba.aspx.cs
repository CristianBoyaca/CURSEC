using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace WebApplication1
{
    public partial class Prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsRol objRol = new ClsRol();
                cmbRol.DataSource = objRol.listarRoles().Tables[0];
                cmbRol.DataTextField = "NombreRol";
                cmbRol.DataValueField = "idRol";
                cmbRol.DataBind();
            }
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            ClsUsuario objUsuario = new ClsUsuario();
            objUsuario.Identificacion = Login1.UserName;
            objUsuario.Contrasena = Login1.Password;
            switch(objUsuario.iniciarSesion(int.Parse(cmbRol.SelectedValue.ToString())))
            {
                case "1":
                    Session["usuario"] = Login1.UserName;
                    Response.Redirect("Administrador.aspx");
                    break;
                case "2":
                    Session["usuario"] = Login1.UserName;
                    Response.Redirect("Secretario.aspx");
                    break;
                case "3":
                    Session["usuario"] = Login1.UserName;
                    Response.Redirect("Usuario.aspx");
                    break;

            }
                }
    }
}