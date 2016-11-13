using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"]==null)
            {
                Response.Redirect("Prueba.aspx");
            }
            else
            {
                lblUsuario.Text =Session["usuario"].ToString();
            }

            if (!IsPostBack)
            {
                ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
                cmbSecretario.DataSource = objDatoUsuario.listarSecretarios().Tables[0];
                cmbSecretario.DataTextField = "nombreCompleto";
                cmbSecretario.DataBind();
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Prueba.aspx");
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsEntidad objEntidad = new ClsEntidad();
            objEntidad.NombreSecretaria = txtNombreSecretaria.Text;
            objEntidad.NombreSecretario = cmbSecretario.Text;
            objEntidad.DireccionSe = txtDireccion.Text;
            objEntidad.Telefono = txtTelefono.Text;
            try
            {
                objEntidad.registrarSecretaria();
                lblMensaje.Text = "Registro Exitoso";
            }
            catch (Exception)
            {
                lblMensaje.Text = "Registro no Exitoso";

            }
         
        }
    }
}