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
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            ClsCiudad objCiudad = new ClsCiudad();
            objCiudad.listarCiudades(cmbCiudad);
            ClsDepartamento objDepartamento = new ClsDepartamento();
            objDepartamento.listarDepartamentos(cmbDepartamento);
            ClsCargo objCargo = new ClsCargo();
            objCargo.listarCargos(cmbCargo);
            ClsArea objArea = new ClsArea();
            cmbArea.DataSource=objArea.listarAreas().Tables[0];
            cmbArea.DisplayMember="NombreArea";
            cmbArea.ValueMember="IdArea";
            ClsEntidad objEntidad = new ClsEntidad();
            objEntidad.listarEntidades(cmbEntidad);
            cmbSexo.SelectedIndex = 0;
            ClsRol objRol = new ClsRol();
            objRol.listarRoles(cmbRol);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
            objDatoUsuario.Identificacion = txtIdentificacion.Text;
            objDatoUsuario.PrimerNombre = txtPrimerNombre.Text;
            objDatoUsuario.SegundoNombre = txtSegundoNombre.Text;
            objDatoUsuario.PrimerApellido = txtPrimerApellido.Text;
            objDatoUsuario.SegundoApellido = txtSegundoApellido.Text;
            DateTime dt = Convert.ToDateTime(dtpFecha.Value.ToString("MM/dd/yyyy"));
            objDatoUsuario.FechaNacimiento = dt;
            objDatoUsuario.CiudadNacimiento=cmbCiudad.SelectedIndex+1;
            objDatoUsuario.Departamento=cmbDepartamento.SelectedIndex + 1;
            objDatoUsuario.Sexo = cmbSexo.Text;
            objDatoUsuario.Cargo = cmbCargo.SelectedIndex+1;
            objDatoUsuario.Area = int.Parse(cmbArea.SelectedValue.ToString());
            objDatoUsuario.IdEntidad = cmbEntidad.SelectedIndex+1;
            objDatoUsuario.Rol = cmbRol.SelectedIndex + 1;
            objDatoUsuario.registrarUsuario();
        }
    }
}
