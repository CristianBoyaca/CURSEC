using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class ConsultarUsuario : System.Web.UI.Page
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
                    //calFechaNacimiento.Visible = false;
                    ClsCiudad objCiudad = new ClsCiudad();
                    ddlCiudad.DataSource = objCiudad.listarCiudades().Tables[0];
                    ddlCiudad.DataTextField = "NombreCiudad";
                    ddlCiudad.DataBind();
                    ClsDepartamento objDepartamento = new ClsDepartamento();
                    ddlDepartamento.DataSource = objDepartamento.listarDepartamentos().Tables[0];
                    ddlDepartamento.DataTextField = "NombreDepartamento";
                    ddlDepartamento.DataBind();
                    ClsCargo objCargo = new ClsCargo();
                    ddlCargo.DataSource = objCargo.listarCargos().Tables[0];
                    ddlCargo.DataTextField = "NombreCargo";
                    ddlCargo.DataBind();
                    ClsArea objArea = new ClsArea();
                    ddlArea.DataSource = objArea.listarAreas().Tables[0];
                    ddlArea.DataTextField = "NombreArea";
                    ddlArea.DataBind();
                    ClsEntidad objEntidad = new ClsEntidad();
                    ddlEntidad.DataSource = objEntidad.listarEntidades().Tables[0];
                    ddlEntidad.DataTextField = "NombreSecretaria";
                    ddlEntidad.DataBind();
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
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            gvUsuarios.DataSource = objDatoUsuario.listarUsuarios().Tables[0];
            gvUsuarios.DataBind();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.Identificacion = txtIdentificacion.Text;
            objDatoUsuario.PrimerNombre = txtPrimerNombre.Text;
            objDatoUsuario.SegundoNombre = txtSegundoNombre.Text;
            objDatoUsuario.PrimerApellido = txtPrimerApellido.Text;
            objDatoUsuario.SegundoApellido = txtSegundoApellido.Text;
          
            if (!txtFechaNacimiento.Text.Equals(""))
            {
                
                DateTime dt = Convert.ToDateTime(txtFechaNacimiento.Text);
                objDatoUsuario.FechaNacimiento = dt;
                
            }
            
            objDatoUsuario.CiudadNacimiento = ddlCiudad.SelectedIndex+1;
            objDatoUsuario.Departamento = ddlDepartamento.SelectedIndex + 1;
            objDatoUsuario.Sexo = ddlSexo.Text;
            objDatoUsuario.Cargo = ddlCargo.SelectedIndex + 1;
            objDatoUsuario.Area = ddlArea.SelectedIndex + 1; 
            objDatoUsuario.IdEntidad = ddlEntidad.SelectedIndex + 1;
            if (objDatoUsuario.Identificacion.Equals("") || objDatoUsuario.PrimerNombre.Equals("") || objDatoUsuario.PrimerApellido.Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);
            }
            else
            {
                objDatoUsuario.actualizarUsuario();
                ScriptManager.RegisterStartupScript(this, GetType(), "exito", "exito();", true);
                consultar();
                limpiarCajas();
            }
        }

        public void limpiarCajas()
        {
            txtIdentificacion.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtFechaNacimiento.Text = "";
            
        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtIdentificacion.Text = gvUsuarios.SelectedRow.Cells[1].Text;
            txtPrimerNombre.Text = Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[2].Text);
            txtSegundoNombre.Text = Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[3].Text);
            txtPrimerApellido.Text = Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[4].Text);
            txtSegundoApellido.Text = Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[5].Text);
            txtFechaNacimiento.Text = gvUsuarios.SelectedRow.Cells[6].Text;
            ddlCiudad.Text = Server.HtmlDecode(Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[7].Text));
            ddlDepartamento.Text= Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[8].Text);
            ddlSexo.Text = Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[9].Text);
            ddlCargo.Text= Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[10].Text);
            ddlArea.Text = Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[11].Text);
            ddlEntidad.Text = Server.HtmlDecode(gvUsuarios.SelectedRow.Cells[12].Text);
            


        }

        protected void gvUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUsuarios.PageIndex = e.NewPageIndex;
            consultar();
        }
    }
}