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
    public partial class frmConsultarInscripcion : Form
    {
        public frmConsultarInscripcion()
        {
            InitializeComponent();
        }

        int indice;
        private void frmConsultarInscripcion_Load(object sender, EventArgs e)
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            consultar();
            cmbCurso.DataSource = objCursoUsuario.listarCurso().Tables[0];
            cmbCurso.DisplayMember = "Descripcion";
            cmbCurso.ValueMember = "IdCurso";
           
        }

        public void consultar()
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            dgvInscripciones.DataSource = objCursoUsuario.consultarInscripcion().Tables[0];
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            if (!txtCodigo.Text.Equals("")) { 
            objCursoUsuario.IdCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objCursoUsuario.actualizarInscripcion();
            consultar();
            }
            else { MessageBox.Show("Debe seleccionar el codigo de la inscripción del curso"); }
        }

        private void dgvInscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvInscripciones.CurrentRow.Index;
            txtCodigo.Text = dgvInscripciones.Rows[indice].Cells[0].Value.ToString();
            cmbCurso.Text = dgvInscripciones.Rows[indice].Cells[1].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!txtCodigo.Text.Equals(""))
            {
                ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            objCursoUsuario.IdCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objCursoUsuario.eliminarInscripcion();
            consultar();
            }
            else { MessageBox.Show("Debe seleccionar el codigo de la inscripción del curso"); }
        }
    }
}
