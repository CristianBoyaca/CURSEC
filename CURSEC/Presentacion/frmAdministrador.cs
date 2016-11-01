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
    }
}
