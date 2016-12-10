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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            chart1.DataSource = objCursoUsuario.listarCursosUsuarios().Tables[0];
            chart1.Series[0].XValueMember = "Curso";
            chart1.Series[0].YValueMembers = "Cantidad";
        }
    }
}
