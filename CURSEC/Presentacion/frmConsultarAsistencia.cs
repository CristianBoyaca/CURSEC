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
    public partial class frmConsultarAsistencia : Form
    {
        public frmConsultarAsistencia()
        {
            InitializeComponent();
        }

        int indice;

        private void frmConsultarAsistencia_Load(object sender, EventArgs e)
        {
            ClsCurso objCurso = new ClsCurso();
            cmbCurso.DataSource = objCurso.listarCursos().Tables[0];
            cmbCurso.DisplayMember = "Descripcion";
            cmbCurso.ValueMember = "IdCurso";
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            cmbIdentificacion.DataSource = objCursoUsuario.listarDocumentos(int.Parse(cmbCurso.SelectedValue.ToString())).Tables[0];
            cmbIdentificacion.DisplayMember = "Identificacion";
            ClsTipoHorario objHorario = new ClsTipoHorario();
            cmbHorario.DataSource = objHorario.listarTiposHorarios(int.Parse(cmbCurso.SelectedValue.ToString())).Tables[0];
            cmbHorario.DisplayMember = "Etiqueta";
            cmbHorario.ValueMember = "IdTipoHorario";
            cmbAsistio.SelectedIndex = 0;
            actualizarTabla();
        }

        public void actualizarTabla() {
            ClsAsistencia objAsistencia = new ClsAsistencia();
            dgvAsistencias.DataSource = objAsistencia.listarAsistencias().Tables[0];
        }

        private void dgvAsistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvAsistencias.CurrentCell.RowIndex;
            txtIdAsistencia.Text= dgvAsistencias.Rows[indice].Cells[0].Value.ToString();
            cmbHorario.Text = dgvAsistencias.Rows[indice].Cells[1].Value.ToString();
            cmbIdentificacion.Text = dgvAsistencias.Rows[indice].Cells[2].Value.ToString();
            dtpFecha.Text = dgvAsistencias.Rows[indice].Cells[3].Value.ToString();
            cmbAsistio.Text = dgvAsistencias.Rows[indice].Cells[4].Value.ToString();
            cmbCurso.Text = dgvAsistencias.Rows[indice].Cells[5].Value.ToString();

        }

        private void cmbCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbIdentificacion.ResetText();
            cmbHorario.ResetText();
            ClsCursoUsuario objCursoUsuario = new ClsCursoUsuario();
            cmbIdentificacion.DataSource = objCursoUsuario.listarDocumentos(int.Parse(cmbCurso.SelectedValue.ToString())).Tables[0];
            cmbIdentificacion.DisplayMember = "Identificacion";
            ClsTipoHorario objHorario = new ClsTipoHorario();
            cmbHorario.DataSource = objHorario.listarTiposHorarios(int.Parse(cmbCurso.SelectedValue.ToString())).Tables[0];
            cmbHorario.DisplayMember = "Etiqueta";
            cmbHorario.ValueMember = "IdTipoHorario";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!txtIdAsistencia.Text.Equals(""))
            {
                ClsAsistencia objAsistencia = new ClsAsistencia();
                objAsistencia.IdCurso = int.Parse(cmbCurso.SelectedValue.ToString());
                objAsistencia.IdHorario = int.Parse(cmbHorario.SelectedValue.ToString());
                objAsistencia.Identificacion = cmbIdentificacion.Text;
                DateTime dt = Convert.ToDateTime(dtpFecha.Value.ToString("yyyy/MM/dd"));
                objAsistencia.Fecha = dt;
                objAsistencia.Asistio = cmbAsistio.Text;
                objAsistencia.IdAsistencia = int.Parse(txtIdAsistencia.Text);
                objAsistencia.actualizarAsistencia();
                actualizarTabla();
            }else
            {
                MessageBox.Show("Debe seleccionar el IdAsistencia","Error");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!txtIdAsistencia.Text.Equals(""))
            {
                ClsAsistencia objAsistencia = new ClsAsistencia();
                objAsistencia.IdAsistencia=int.Parse(txtIdAsistencia.Text);
                objAsistencia.eliminarAsistencia();
                actualizarTabla();
            }
            else
            {

                MessageBox.Show("Debe seleccionar el IdAsistencia", "Error");
            }
        }
    }
}
