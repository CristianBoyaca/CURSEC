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
    public partial class frmInscripcionCurso : Form
    {
        public frmInscripcionCurso()
        {
            InitializeComponent();
        }

        private void frmInscripcionCurso_Load(object sender, EventArgs e)
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            cmbCurso.DataSource = objCursoUsuario.listarCurso().Tables[0];
            cmbCurso.DisplayMember = "Descripcion";
            cmbCurso.ValueMember = "IdCurso";
            cmbCurso.SelectedIndex = 0;
            txtIdentificacion.Text = ClsSesion.documento;
          
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            objCursoUsuario.IdCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objCursoUsuario.Identificacion = txtIdentificacion.Text;
            objCursoUsuario.inscribirCurso();
        }
    }
}
