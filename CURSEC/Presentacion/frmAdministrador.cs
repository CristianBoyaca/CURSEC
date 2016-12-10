using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void registrarSecretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarSecretaria formRegistrar = new frmRegistrarSecretaria();
            formRegistrar.MdiParent = this;
            formRegistrar.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            this.Hide();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario formRegistrar = new frmRegistrarUsuario();
            formRegistrar.MdiParent = this;
            formRegistrar.Show();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarUsuario formConsultar = new frmConsultarUsuario();
            formConsultar.MdiParent = this;
            formConsultar.Show();
        }

        private void consultarSecretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarSecretaria formConsultar = new frmConsultarSecretaria();
            formConsultar.MdiParent = this;
            formConsultar.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarContrasena formCambiar = new frmCambiarContrasena();
            formCambiar.MdiParent = this;
            formCambiar.Show();

        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes formReportes = new frmReportes();
            formReportes.MdiParent = this;
            formReportes.Show();
        }
    }
}
