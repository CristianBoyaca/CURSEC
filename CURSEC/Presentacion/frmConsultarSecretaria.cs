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
    public partial class frmConsultarSecretaria : Form
    {
        public frmConsultarSecretaria()
        {
            InitializeComponent();
        }

        int indice;

        private void frmConsultarSecretaria_Load(object sender, EventArgs e)
        {
            actualizarDataGridView();
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.listarSecretarios(cmbSecretario);
        }

        public void actualizarDataGridView()
        {
            ClsEntidad objEntidad = new ClsEntidad();
            dgvSecretarias.DataSource = objEntidad.listarEntidades().Tables[0];
        }

        public void limpiarCajas()
        {
            txtIdentidad.ResetText();
            txtNombreSecretaria.ResetText();
            txtTelefono.ResetText();
            txtDireccion.ResetText();
        }
        private void dgvSecretarias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvSecretarias.CurrentCell.RowIndex;
            txtIdentidad.Text = dgvSecretarias.Rows[indice].Cells[0].Value.ToString();
            txtNombreSecretaria.Text = dgvSecretarias.Rows[indice].Cells[1].Value.ToString();
            cmbSecretario.Text = dgvSecretarias.Rows[indice].Cells[2].Value.ToString();
            txtDireccion.Text = dgvSecretarias.Rows[indice].Cells[3].Value.ToString();
            txtTelefono.Text = dgvSecretarias.Rows[indice].Cells[4].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsEntidad objEntidad = new ClsEntidad();
            objEntidad.NombreSecretaria = txtNombreSecretaria.Text;
            objEntidad.NombreSecretario = cmbSecretario.Text;
            objEntidad.DireccionSe = txtDireccion.Text;
            objEntidad.Telefono = txtTelefono.Text;
            if (!txtIdentidad.Text.Equals("")) { 
            objEntidad.IdEntidad = int.Parse(txtIdentidad.Text);
            }
            if (objEntidad.NombreSecretaria != "" && objEntidad.NombreSecretario != "" && objEntidad.DireccionSe != "" && objEntidad.Telefono != "")
            {
                objEntidad.actualizarEntidad();
                actualizarDataGridView();
                limpiarCajas();
            }
            else { MessageBox.Show("Se debe diligenciar todos los campos del formulario", "Actualización Secretaria"); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsEntidad objEntidad = new ClsEntidad();
            if (!txtIdentidad.Text.Equals("")) { 
            objEntidad.IdEntidad = int.Parse(txtIdentidad.Text);
            objEntidad.eliminarEntidad();
            actualizarDataGridView();
            limpiarCajas();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una secretaria","Eliminar Secretaria");
            }
        }
    }
}
