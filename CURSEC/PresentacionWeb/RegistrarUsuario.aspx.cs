using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class RegistrarUsuario : System.Web.UI.Page
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
                    calFechaNacimiento.Visible = false;
                    ClsCiudad objCiudad = new ClsCiudad();
                    ddlCiudad.DataSource = objCiudad.listarCiudades().Tables[0];
                    ddlCiudad.DataTextField = "NombreCiudad";
                    ddlCiudad.DataValueField = "IdCiudad";
                    ddlCiudad.DataBind();
                    ClsDepartamento objDepartamento = new ClsDepartamento();
                    ddlDepartamento.DataSource = objDepartamento.listarDepartamentos().Tables[0];
                    ddlDepartamento.DataTextField = "NombreDepartamento";
                    ddlDepartamento.DataValueField = "IdDepartamento";
                    ddlDepartamento.DataBind();
                    ClsCargo objCargo = new ClsCargo();
                    ddlCargo.DataSource = objCargo.listarCargos().Tables[0];
                    ddlCargo.DataTextField = "NombreCargo";
                    ddlCargo.DataValueField = "IdCargo";
                    ddlCargo.DataBind();
                    ClsArea objArea = new ClsArea();
                    ddlArea.DataSource = objArea.listarAreas().Tables[0];
                    ddlArea.DataTextField = "NombreArea";
                    ddlArea.DataValueField= "IdArea";
                    ddlArea.DataBind();
                    ClsEntidad objEntidad = new ClsEntidad();
                    ddlEntidad.DataSource = objEntidad.listarEntidades().Tables[0];
                    ddlEntidad.DataTextField = "NombreSecretaria";
                    ddlEntidad.DataValueField = "IdEntidad";
                    ddlEntidad.DataBind();
                }
            }
        }

        public string buscarNombre()
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.Identificacion = Session["usuario"].ToString();
            return objDatoUsuario.buscarNombre().Tables[0].Rows[0][0].ToString();

        }

        protected void imgCalendario_Click(object sender, ImageClickEventArgs e)
        {
            if (calFechaNacimiento.Visible==false) {
                calFechaNacimiento.Visible = true;
            }else
            {
                calFechaNacimiento.Visible = false;
            }
            
        }

        protected void calFechaNacimiento_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaNacimiento.Text = calFechaNacimiento.SelectedDate.ToShortDateString();
        }
    }
}