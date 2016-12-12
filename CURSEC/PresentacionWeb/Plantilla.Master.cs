using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class Plantilla : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                menu1.Visible = false;
                menu2.Visible = false;
                menu3.Visible = false;

                if (Session["rol"].Equals("1"))
                {
                    menu1.Visible = true;
                }
                if (Session["rol"].Equals("2"))
                {
                    menu2.Visible = true;
                }
                if (Session["rol"].Equals("3"))
                {
                    menu3.Visible = true;
                }
            }
            
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session["usuario"] = "";
            Session["rol"] = "";
            Response.Redirect("InicioSesion.aspx");
        }
    }
}