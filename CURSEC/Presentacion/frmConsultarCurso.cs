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
    public partial class frmConsultarCurso : Form
    {
        public frmConsultarCurso()
        {
            InitializeComponent();
        }

        int indice;
        private void ConsultarCurso_Load(object sender, EventArgs e)
        {
            ClsEntidad objEntidad = new ClsEntidad();
            cmbEntidad.DataSource = objEntidad.listarEntidades().Tables[0];
            cmbEntidad.DisplayMember = "NombreSecretaria";
            cmbEntidad.ValueMember = "IdEntidad";
            consultarCurso();
        }

        public void consultarCurso() {

            ClsCurso objCurso = new ClsCurso();
            dgvCursos.DataSource = objCurso.listarCurso().Tables[0];
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvCursos.CurrentCell.RowIndex;
            txtIdCurso.Text= dgvCursos.Rows[indice].Cells[0].Value.ToString();
            cmbEntidad.Text = dgvCursos.Rows[indice].Cells[1].Value.ToString();
            txtDescripcion.Text= dgvCursos.Rows[indice].Cells[2].Value.ToString();
            txtValor.Text= dgvCursos.Rows[indice].Cells[3].Value.ToString();
            txtMaxAsistentes.Text= dgvCursos.Rows[indice].Cells[4].Value.ToString();
            dtpFechaInicial.Text= dgvCursos.Rows[indice].Cells[5].Value.ToString();
            dtpFechaFinal.Text= dgvCursos.Rows[indice].Cells[6].Value.ToString();
            txtCantidad.Text= dgvCursos.Rows[indice].Cells[7].Value.ToString();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!txtDescripcion.Text.Equals("") && !txtValor.Text.Equals("") && !txtMaxAsistentes.Text.Equals("") && !txtCantidad.Text.Equals("") && !txtIdCurso.Text.Equals("")) { 
                ClsCurso objCurso = new ClsCurso();
            objCurso.IdCurso = int.Parse(txtIdCurso.Text);
            objCurso.IdEntidad = int.Parse(cmbEntidad.SelectedValue.ToString());
            objCurso.Descripcion = txtDescripcion.Text;
            objCurso.Valor = int.Parse(txtValor.Text);
            objCurso.MaxAsistentes = int.Parse(txtMaxAsistentes.Text);
            DateTime fechaInicial = Convert.ToDateTime(dtpFechaInicial.Value.ToString("yyyy/MM/dd"));
            DateTime fechaFinal = Convert.ToDateTime(dtpFechaFinal.Value.ToString("yyyy/MM/dd"));
            objCurso.FechaInicial = fechaInicial;
            objCurso.FechaFinal = fechaFinal;
            objCurso.CantidadHoras = int.Parse(txtCantidad.Text);
            objCurso.actualizarCurso();
            limpiarCajas();
            consultarCurso();
            }
            else {
                MessageBox.Show("Se debe seleccionar el IdCurso y todos los campos deben estar llenos","Error");
            }


        }

        public void limpiarCajas()
        {
            txtDescripcion.ResetText();
            txtMaxAsistentes.ResetText();
            txtValor.ResetText();
        }
    }
}
