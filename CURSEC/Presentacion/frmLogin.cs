using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ClsUsuario objUsuario = new ClsUsuario();
            objUsuario.Identificacion = txtIdentificacion.Text;
            objUsuario.Contrasena = txtContrasenia.Text;
            string redireccionar = "";
            redireccionar = objUsuario.iniciarSesion(int.Parse(cmbRol.SelectedValue.ToString()));
            if (redireccionar.Equals("1")) {
                frmAdministrador formAdministrador = new frmAdministrador();
                formAdministrador.Show();
                this.Hide();
            }
            else if (redireccionar.Equals("2"))
            {
                frmSecretaria formSecretaria = new frmSecretaria();
                formSecretaria.Show();
                this.Hide();
            }
            else if (redireccionar.Equals("3"))
            {
                frmUsuario formUsuario = new frmUsuario();
                formUsuario.Show();
                this.Hide();
            }else { MessageBox.Show("Credenciales Incorrectas"); }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ClsRol objRol = new ClsRol();
            cmbRol.DataSource=objRol.listarRoles().Tables[0];
            cmbRol.DisplayMember = "NombreRol";
            cmbRol.ValueMember = "idRol";
            cmbRol.SelectedIndex = 2; 
            
        }
    }
}
