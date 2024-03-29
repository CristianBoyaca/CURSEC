﻿using Logica;
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
                    //calFechaNacimiento.Visible = false;
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
            /*if (calFechaNacimiento.Visible==false) {
                calFechaNacimiento.Visible = true;
            }else
            {
                calFechaNacimiento.Visible = false;
            }*/
            
        }

        protected void calFechaNacimiento_SelectionChanged(object sender, EventArgs e)
        {
            /*txtFechaNacimiento.Text = calFechaNacimiento.SelectedDate.ToShortDateString();*/
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string[] array = new string[1];
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.Identificacion = txtIdentificacion.Text;
            objDatoUsuario.PrimerNombre = txtPrimerNombre.Text;
            objDatoUsuario.SegundoNombre = txtSegundoNombre.Text;
            objDatoUsuario.PrimerApellido = txtPrimerApellido.Text;
            objDatoUsuario.SegundoApellido = txtSegundoApellido.Text;
            if (!txtFechaNacimiento.Text.Equals(""))
            {
                array = txtFechaNacimiento.Text.Split('/');
                string year = array[2];
                string moth = array[1];
                string day = array[0];
                string fecha = year + "/" + moth + "/" + day;
                DateTime dt = Convert.ToDateTime(fecha);
                objDatoUsuario.FechaNacimiento = dt;
            }
            
            objDatoUsuario.CiudadNacimiento = int.Parse(ddlCiudad.SelectedValue.ToString());
            objDatoUsuario.Departamento = int.Parse(ddlDepartamento.SelectedValue.ToString());
            objDatoUsuario.Sexo = ddlSexo.Text;
            objDatoUsuario.Cargo = int.Parse(ddlCargo.SelectedValue.ToString());
            objDatoUsuario.Area = int.Parse(ddlArea.SelectedValue.ToString());
            objDatoUsuario.IdEntidad = int.Parse(ddlEntidad.SelectedValue.ToString());
            if (objDatoUsuario.Identificacion.Equals("") || objDatoUsuario.PrimerNombre.Equals("") || objDatoUsuario.PrimerApellido.Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);
            }
            else
            {
                int[] roles = new int[3];
                int i = 0;
                if (chbAdministrador.Checked)
                {
                    roles[i] = 1;
                    i++;
                }
                if (chbSecretario.Checked)
                {
                    roles[i] = 2;
                    i++;
                }
                if (chbUsuario.Checked)
                {
                    roles[i] = 3;
                    i++;
                }
                if (roles[0] == 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "fallo", "fallo();", true);

                }
                else if (objDatoUsuario.validarUsuario())
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "fallo1", "fallo1();", true);
                }
                else
                {
                    objDatoUsuario.registrarUsuario(roles);
                    ScriptManager.RegisterStartupScript(this, GetType(), "exito", "exito();", true);
                    limpiarCajas();
                }

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
            chbUsuario.Checked = false;
            chbSecretario.Checked = false;
            chbAdministrador.Checked = false;
        }
    }
}