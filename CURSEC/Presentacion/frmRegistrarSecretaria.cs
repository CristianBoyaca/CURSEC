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
    public partial class frmRegistrarSecretaria : Form
    {
        public frmRegistrarSecretaria()
        {
            InitializeComponent();
        }

        private void frmRegistrarSecretaria_Load(object sender, EventArgs e)
        {
            ClsDatoUsuario objDatoUsuario = new ClsDatoUsuario();
           cmbSecretario.DataSource= objDatoUsuario.listarSecretarios().Tables[0];
            cmbSecretario.DisplayMember = "nombreCompleto";
        }

        public void limpiarCajas()
        {
            txtNombreSecretaria.ResetText();
            txtTelefono.ResetText();
            txtDireccion.ResetText();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsEntidad objEntidad = new ClsEntidad();
            objEntidad.NombreSecretaria = txtNombreSecretaria.Text;
            objEntidad.NombreSecretario = cmbSecretario.Text;
            objEntidad.DireccionSe = txtDireccion.Text;
            objEntidad.Telefono = txtTelefono.Text;
            if (objEntidad.NombreSecretaria!="" && objEntidad.NombreSecretario!="" && objEntidad.DireccionSe!="" && objEntidad.Telefono!="") { 
            objEntidad.registrarSecretaria();
            limpiarCajas();
            }
            else { MessageBox.Show("Se debe diligenciar todos los campos del formulario","Registro Secretaria"); }
        }
    }
}
