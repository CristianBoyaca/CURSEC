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
    public partial class frmConsultarUsuario : Form
    {
        public frmConsultarUsuario()
        {
            InitializeComponent();
        }

        int indice;
        private void frmConsultarUsuario_Load(object sender, EventArgs e)
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            dgvUsuarios.DataSource = objDatoUsuario.listarUsuarios().Tables[0];
            ClsCiudad objCiudad = new ClsCiudad();
            cmbCiudad.DataSource = objCiudad.listarCiudades().Tables[0];
            cmbCiudad.DisplayMember = "NombreCiudad";
            cmbCiudad.ValueMember = "IdCiudad";
            ClsDepartamento objDepartamento = new ClsDepartamento();
            cmbDepartamento.DataSource = objDepartamento.listarDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "NombreDepartamento";
            cmbDepartamento.ValueMember = "IdDepartamento";
            ClsCargo objCargo = new ClsCargo();
            cmbCargo.DataSource = objCargo.listarCargos().Tables[0];
            cmbCargo.DisplayMember = "NombreCargo";
            cmbCargo.ValueMember = "IdCargo";
            ClsArea objArea = new ClsArea();
            cmbArea.DataSource = objArea.listarAreas().Tables[0];
            cmbArea.DisplayMember = "NombreArea";
            cmbArea.ValueMember = "IdArea";
            ClsEntidad objEntidad = new ClsEntidad();
            cmbEntidad.DataSource = objEntidad.listarEntidades().Tables[0];
            cmbEntidad.DisplayMember = "NombreSecretaria";
            cmbEntidad.ValueMember = "IdEntidad";
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvUsuarios.CurrentRow.Index;
            txtPrimerNombre.Text = dgvUsuarios.Rows[indice].Cells[1].Value.ToString();
            txtSegundoNombre.Text = dgvUsuarios.Rows[indice].Cells[2].Value.ToString();
            txtPrimerApellido.Text = dgvUsuarios.Rows[indice].Cells[3].Value.ToString();
            txtSegundoApellido.Text = dgvUsuarios.Rows[indice].Cells[4].Value.ToString();
            dtpFecha.Text = dgvUsuarios.Rows[indice].Cells[5].Value.ToString();
            cmbCiudad.Text = dgvUsuarios.Rows[indice].Cells[6].Value.ToString();
            cmbDepartamento.Text = dgvUsuarios.Rows[indice].Cells[7].Value.ToString();
            cmbSexo.Text= dgvUsuarios.Rows[indice].Cells[8].Value.ToString();
            cmbCargo.Text = dgvUsuarios.Rows[indice].Cells[9].Value.ToString();
            cmbArea.Text = dgvUsuarios.Rows[indice].Cells[10].Value.ToString();
            cmbEntidad.Text = dgvUsuarios.Rows[indice].Cells[11].Value.ToString();
        }
    }
}
