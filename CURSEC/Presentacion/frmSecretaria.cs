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
    public partial class frmSecretaria : Form
    {
        public frmSecretaria()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            this.Hide();
        }

        private void crearCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarCurso formRegistrar = new frmRegistrarCurso();
            formRegistrar.MdiParent = this;
            formRegistrar.Show();
        }

        private void consultarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCurso formConsultar = new frmConsultarCurso();
            formConsultar.MdiParent = this;
            formConsultar.Show();

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarContraseniaPersonal formCambiar = new frmCambiarContraseniaPersonal();
            formCambiar.MdiParent = this;
            formCambiar.Show();
        }

        private void registrarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarAsistencia formRegistrar = new frmRegistrarAsistencia();
            formRegistrar.MdiParent = this;
            formRegistrar.Show();

        }

        private void registrarAsistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrarAsistencia formRegistrar = new frmRegistrarAsistencia();
            formRegistrar.MdiParent = this;
            formRegistrar.Show();
        }

        private void consultarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAsistencia formConsultar = new frmConsultarAsistencia();
            formConsultar.MdiParent = this;
            formConsultar.Show();
        }
    }
}
