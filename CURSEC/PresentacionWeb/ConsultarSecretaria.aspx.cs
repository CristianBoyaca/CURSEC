using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class ConsultarSecretaria : System.Web.UI.Page
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
            ClsEntidad objEntidad = new ClsEntidad();
            gvSecretarias.DataSource = objEntidad.listarEntidades().Tables[0];
            gvSecretarias.DataBind();
        }
        protected void gvSecretarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtIdEntidad.Text = gvSecretarias.SelectedRow.Cells[1].Text;
            txtNombreSecretaria.Text =Server.HtmlDecode(gvSecretarias.SelectedRow.Cells[2].Text);
            ddlSecretario.Text = Server.HtmlDecode(gvSecretarias.SelectedRow.Cells[3].Text);
            txtDireccion.Text = Server.HtmlDecode(gvSecretarias.SelectedRow.Cells[4].Text);
            txtTelefono.Text = gvSecretarias.SelectedRow.Cells[5].Text;

        }

        protected void gvSecretarias_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            gvSecretarias.PageIndex = e.NewPageIndex;
            consultar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsEntidad objEntidad = new ClsEntidad();
           
            objEntidad.NombreSecretaria = txtNombreSecretaria.Text;
            objEntidad.NombreSecretario = ddlSecretario.Text;
            objEntidad.DireccionSe = txtDireccion.Text;
            objEntidad.Telefono = txtTelefono.Text;
           
            if (!txtIdEntidad.Text.Equals("") && objEntidad.NombreSecretaria != "" && objEntidad.NombreSecretario != "" && objEntidad.DireccionSe != "" && objEntidad.Telefono != "")
            {
                objEntidad.IdEntidad = int.Parse(txtIdEntidad.Text);
                objEntidad.actualizarEntidad();
                consultar();
                limpiarCajas();
                ScriptManager.RegisterStartupScript(this, GetType(), "exito", "exito();", true);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);
            }
        }

        public void limpiarCajas()
        {
            txtIdEntidad.Text = "";
            txtNombreSecretaria.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsEntidad objEntidad = new ClsEntidad();
            if (!txtIdEntidad.Text.Equals(""))
            {
                objEntidad.IdEntidad = int.Parse(txtIdEntidad.Text);
                objEntidad.eliminarEntidad();
                consultar();
                limpiarCajas();
                ScriptManager.RegisterStartupScript(this, GetType(), "exito1", "exito1();", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "fallo1", "fallo1();", true);
            }
        }
    }
}