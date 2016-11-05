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
        ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
        private void frmConsultarUsuario_Load(object sender, EventArgs e)
        {
            
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
            cmbSexo.SelectedIndex = 0;
        }

        public void limpiarCajas()
        {
            txtIdentificacion.ResetText();
            txtPrimerNombre.ResetText();
            txtSegundoNombre.ResetText();
            txtPrimerApellido.ResetText();
            txtSegundoApellido.ResetText();
            dtpFecha.ResetText();
            
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvUsuarios.CurrentRow.Index;
            txtIdentificacion.Text= dgvUsuarios.Rows[indice].Cells[0].Value.ToString();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.Identificacion = txtIdentificacion.Text;
            objDatoUsuario.PrimerNombre = txtPrimerNombre.Text;
            objDatoUsuario.SegundoNombre = txtSegundoNombre.Text;
            objDatoUsuario.PrimerApellido = txtPrimerApellido.Text;
            objDatoUsuario.SegundoApellido = txtSegundoApellido.Text;
            DateTime dt = Convert.ToDateTime(dtpFecha.Value.ToString("MM/dd/yyyy"));
            objDatoUsuario.FechaNacimiento = dt;
            objDatoUsuario.CiudadNacimiento = int.Parse(cmbCiudad.SelectedValue.ToString());
            objDatoUsuario.Departamento = int.Parse(cmbDepartamento.SelectedValue.ToString());
            objDatoUsuario.Sexo = cmbSexo.Text;
            objDatoUsuario.Cargo = int.Parse(cmbCargo.SelectedValue.ToString());
            objDatoUsuario.Area = int.Parse(cmbArea.SelectedValue.ToString());
            objDatoUsuario.IdEntidad = int.Parse(cmbEntidad.SelectedValue.ToString());
            if (objDatoUsuario.Identificacion.Equals("") || objDatoUsuario.PrimerNombre.Equals("") || objDatoUsuario.PrimerApellido.Equals(""))
            {
                MessageBox.Show("Se debe seleccionar la identificación y se debe ingresar el primer nombre y el primer apellido", "Actualización Usuario");
            }else { 
            objDatoUsuario.actualizarUsuario();
            dgvUsuarios.DataSource = objDatoUsuario.listarUsuarios().Tables[0];
            limpiarCajas();
            }
        }
    }
}
