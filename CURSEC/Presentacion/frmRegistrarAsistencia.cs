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
    public partial class frmRegistrarAsistencia : Form
    {
        public frmRegistrarAsistencia()
        {
            InitializeComponent();
        }

        private void frmRegistrarAsistencia_Load(object sender, EventArgs e)
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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!cmbIdentificacion.Text.Equals(""))
            {
                ClsAsistencia objAsistencia = new ClsAsistencia();
                objAsistencia.IdCurso = int.Parse(cmbCurso.SelectedValue.ToString());
                objAsistencia.IdHorario = int.Parse(cmbHorario.SelectedValue.ToString());
                objAsistencia.Identificacion = cmbIdentificacion.Text;
                DateTime dt = Convert.ToDateTime(dtpFecha.Value.ToString("yyyy/MM/dd"));
                objAsistencia.Fecha = dt;
                objAsistencia.Asistio = cmbAsistio.Text;
                objAsistencia.registrarAsistencia();
            }
            else
            {
                MessageBox.Show("No se encuentra ningun alumno registrado en este curso","Error");
            }
            
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
    }
}
