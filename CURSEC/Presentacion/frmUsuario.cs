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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void registrarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcionCurso formInscribir = new frmInscripcionCurso();
            formInscribir.MdiParent = this;
            formInscribir.Show();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            this.Hide();
        }

        private void consultarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarInscripcion formConsultar = new frmConsultarInscripcion();
            formConsultar.MdiParent = this;
            formConsultar.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarContraseniaPersonal formCambiar = new frmCambiarContraseniaPersonal();
            formCambiar.MdiParent = this;
            formCambiar.Show();
        }

        private void calificarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalificarCurso formCalificar = new frmCalificarCurso();
            formCalificar.MdiParent = this;
            formCalificar.Show();
        }
    }
}
