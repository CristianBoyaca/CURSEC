﻿using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class CrearCurso : System.Web.UI.Page
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
    }
}