using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class RegistrarSecretaria : System.Web.UI.Page
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
                    ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
                    ddlSecretario.DataSource = objDatoUsuario.listarSecretarios().Tables[0];
                    ddlSecretario.DataTextField = "nombreCompleto";
                    ddlSecretario.DataBind();
                }
            }
        }

        public string buscarNombre()
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.Identificacion = Session["usuario"].ToString();
            return objDatoUsuario.buscarNombre().Tables[0].Rows[0][0].ToString();

        }

        public void limpiarCajas()
        {
            txtNombreSecretaria.Text="";
            txtTelefono.Text="";
            txtDireccion.Text="";
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsEntidad objEntidad = new ClsEntidad();
            objEntidad.NombreSecretaria = txtNombreSecretaria.Text;
            objEntidad.NombreSecretario = ddlSecretario.Text;
            objEntidad.DireccionSe = txtDireccion.Text;
            objEntidad.Telefono = txtTelefono.Text;
            if (objEntidad.NombreSecretaria != "" && objEntidad.NombreSecretario != "" && objEntidad.DireccionSe != "" && objEntidad.Telefono != "")
            {
                objEntidad.registrarSecretaria();
                limpiarCajas();
                ScriptManager.RegisterStartupScript(this, GetType(), "exito", "exito();", true);
            }else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);
            }
        }
    }
}