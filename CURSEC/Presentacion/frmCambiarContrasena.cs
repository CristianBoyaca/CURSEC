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
    public partial class frmCambiarContrasena : Form
    {
        public frmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void frmCambiarContrasena_Load(object sender, EventArgs e)
        {
            consultar();
        }
        int indice;
        ClsUsuario objUsuario = new ClsUsuario();
        public void consultar()
        {
            dgvUsuarios.DataSource = objUsuario.consultarTodos().Tables[0];
        }

        public void limpiar()
        {
            txtIdentificacion.ResetText();
            txtContrasena.ResetText();
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvUsuarios.CurrentCell.RowIndex;
            txtIdentificacion.Text = dgvUsuarios.Rows[indice].Cells[0].Value.ToString();
            txtContrasena.Text = dgvUsuarios.Rows[indice].Cells[1].Value.ToString();
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            objUsuario.Identificacion = txtIdentificacion.Text;
            objUsuario.Contrasena = txtContrasena.Text;
            if (objUsuario.Identificacion!="" && objUsuario.Contrasena != "") { 
            objUsuario.cambiarContrasena();
            consultar();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un usuario y escribir una contraseña","Cambio Contraseña");
            }
            limpiar();
        }
    }
}
