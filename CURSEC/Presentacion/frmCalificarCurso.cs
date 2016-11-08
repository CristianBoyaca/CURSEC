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
    public partial class frmCalificarCurso : Form
    {
        public frmCalificarCurso()
        {
            InitializeComponent();
        }

        private void frmCalificarCurso_Load(object sender, EventArgs e)
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            cmbCurso.DataSource = objCursoUsuario.listarInscripcion().Tables[0];
            cmbCurso.DisplayMember = "Descripcion";
            cmbCurso.ValueMember = "IdCurso";
            cmbCalificacion.SelectedIndex = 0;
            
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            objCursoUsuario.IdCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objCursoUsuario.Calificacion = int.Parse(cmbCalificacion.Text);
            objCursoUsuario.calificarCurso();
        }
    }
}
