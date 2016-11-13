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
    public partial class frmRegistrarCurso : Form
    {
        public frmRegistrarCurso()
        {
            InitializeComponent();
        }

        private void frmRegistrarCurso_Load(object sender, EventArgs e)
        {
            ClsEntidad objEntidad = new ClsEntidad();
            cmbEntidad.DataSource=objEntidad.listarEntidades().Tables[0];
            cmbEntidad.DisplayMember = "NombreSecretaria";
            cmbEntidad.ValueMember = "IdEntidad";
            ClsTipoHorario objTipoHorario = new ClsTipoHorario();
            cmbTipoHorario.DataSource = objTipoHorario.listarTiposHorarios().Tables[0];
            cmbTipoHorario.DisplayMember = "Etiqueta";
            cmbTipoHorario.ValueMember = "IdTipoHorario";
        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            if (!txtDescripcion.Text.Equals("") && !txtValor.Text.Equals("") && !txtMaxAsistentes.Text.Equals("") && !txtCantidad.Text.Equals(""))
            {
                ClsCurso objCurso = new ClsCurso();
                objCurso.IdEntidad = int.Parse(cmbEntidad.SelectedValue.ToString());
                objCurso.Descripcion = txtDescripcion.Text;
                objCurso.Valor = int.Parse(txtValor.Text);
                objCurso.MaxAsistentes = int.Parse(txtMaxAsistentes.Text);
                DateTime fechaInicial = Convert.ToDateTime(dtpFechaInicial.Value.ToString("yyyy/MM/dd"));
                DateTime fechaFinal = Convert.ToDateTime(dtpFechaFinal.Value.ToString("yyyy/MM/dd"));
                DateTime horaInicial = DateTime.ParseExact(dtpHoraInicio.Text, "HH:mm:ss", null);
                DateTime horaFinal = DateTime.ParseExact(dtpHoraFinal.Text, "HH:mm:ss", null);
                objCurso.FechaInicial = fechaInicial;
                objCurso.FechaFinal = fechaFinal;
                objCurso.IdTipoHorario = int.Parse(cmbTipoHorario.SelectedValue.ToString());
                objCurso.HoraInicial = horaInicial;
                objCurso.HoraFinal = horaFinal;
                objCurso.CantidadHoras = int.Parse(txtCantidad.Text);
                objCurso.registrarCurso();
                limpiarCajas();
            }
            else { MessageBox.Show("Se deben diligenciar todos los campos","Error"); }
            

        }

        public void limpiarCajas() {
            txtDescripcion.ResetText();
            txtMaxAsistentes.ResetText();
            txtValor.ResetText();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsCurso objCurso = new ClsCurso();
            objCurso.soloNumeros(e);    
        }

        private void txtMaxAsistentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsCurso objCurso = new ClsCurso();
            objCurso.soloNumeros(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsCurso objCurso = new ClsCurso();
            objCurso.soloNumeros(e);
        }
        
    }
}
