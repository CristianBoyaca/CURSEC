using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class CambiarContraseniaPersonal : System.Web.UI.Page
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
                   

                }
            }
        }

        public string buscarNombre()
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.Identificacion = Session["usuario"].ToString();
            return objDatoUsuario.buscarNombre().Tables[0].Rows[0][0].ToString();

        }

        protected void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            ClsUsuario objUsuario = new ClsUsuario();

            if (!txtNuevaContrasenia.Text.Equals("") && !txtConfirmarContrasenia.Text.Equals("") && txtNuevaContrasenia.Text.Equals(txtConfirmarContrasenia.Text))
            {
                objUsuario.Identificacion = ClsSesion.documento;
                objUsuario.Contrasena = txtNuevaContrasenia.Text;
                objUsuario.cambiarContrasena();
                limpiar();
                ScriptManager.RegisterStartupScript(this, GetType(), "exito", "exito();", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);
                
            }
        }

        public void limpiar()
        {
            txtNuevaContrasenia.Text="";
            txtConfirmarContrasenia.Text="";
        }
    }
}