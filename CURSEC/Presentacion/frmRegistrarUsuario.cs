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
            cmbCiudad.DataSource=objCiudad.listarCiudades().Tables[0];
            cmbCiudad.DisplayMember = "NombreCiudad";
            cmbCiudad.ValueMember="IdCiudad";
            ClsDepartamento objDepartamento = new ClsDepartamento();
            cmbDepartamento.DataSource=objDepartamento.listarDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "NombreDepartamento";
            cmbDepartamento.ValueMember = "IdDepartamento";
            ClsCargo objCargo = new ClsCargo();
            //objCargo.listarCargos(cmbCargo);
            cmbCargo.DataSource = objCargo.listarCargos().Tables[0];
            cmbCargo.DisplayMember = "NombreCargo";
            cmbCargo.ValueMember = "IdCargo";
            ClsArea objArea = new ClsArea();
            cmbArea.DataSource=objArea.listarAreas().Tables[0];
            cmbArea.DisplayMember="NombreArea";
            cmbArea.ValueMember="IdArea";
            ClsEntidad objEntidad = new ClsEntidad();
            cmbEntidad.DataSource=objEntidad.listarEntidades().Tables[0];
            cmbEntidad.DisplayMember = "NombreSecretaria";
            cmbEntidad.ValueMember = "IdEntidad";
            cmbSexo.SelectedIndex = 0;
           
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
            objDatoUsuario.CiudadNacimiento=int.Parse(cmbCiudad.SelectedValue.ToString());
            objDatoUsuario.Departamento=int.Parse(cmbDepartamento.SelectedValue.ToString());
            objDatoUsuario.Sexo = cmbSexo.Text;
            //objDatoUsuario.Cargo = cmbCargo.SelectedIndex+1;
            objDatoUsuario.Cargo = int.Parse(cmbArea.SelectedValue.ToString());
            objDatoUsuario.Area = int.Parse(cmbArea.SelectedValue.ToString());
            objDatoUsuario.IdEntidad = int.Parse(cmbEntidad.SelectedValue.ToString());
            //objDatoUsuario.Rol = int.Parse(cmbRol.SelectedValue.ToString()) ;
            int[] roles = new int[3];
            int i = 0;
            if (chbAdministrador.Checked)
            {
                roles[i] = 1;
                i++;
            }
            if (chbSecretario.Checked)
            {
                roles[i] = 2;
                i++;
            }
            if (chbUsuario.Checked)
            {
                roles[i] = 3;
                i++;
            }
            if (roles[0]==0) {
                MessageBox.Show("Debe seleccionar minimo un rol", "Rol");
                
            }
            else if(objDatoUsuario.validarUsuario())
            {
                MessageBox.Show("Usuario ya se encuentra registrado", "Usuario");
            }else {
                objDatoUsuario.registrarUsuario(roles);
            }
        }

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
