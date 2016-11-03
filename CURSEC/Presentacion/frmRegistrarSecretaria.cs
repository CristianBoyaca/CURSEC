using Logica;
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
    public partial class frmRegistrarSecretaria : Form
    {
        public frmRegistrarSecretaria()
        {
            InitializeComponent();
        }

        private void frmRegistrarSecretaria_Load(object sender, EventArgs e)
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.listarSecretarios(cmbSecretario);
        }
    }
}
