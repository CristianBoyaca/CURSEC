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
    public partial class frmCambiarContraseniaPersonal : Form
    {
        public frmCambiarContraseniaPersonal()
        {
            InitializeComponent();
        }

        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            ClsUsuario objUsuario = new ClsUsuario();

            if (!txtNuevaContrasenia.Text.Equals("") && !txtConfirmarContrasenia.Text.Equals("") && txtNuevaContrasenia.Text.Equals(txtConfirmarContrasenia.Text))
            {
                objUsuario.Identificacion = ClsSesion.documento;
                objUsuario.Contrasena = txtNuevaContrasenia.Text;
                objUsuario.cambiarContrasena();
                limpiar();
            }
            else
            {
                MessageBox.Show("La nueva contraseña debe coincidir con la confirmación de contraseña y no puede estar vacio","Error");
            }
        }
        public void limpiar()
        {
            txtNuevaContrasenia.ResetText();
            txtConfirmarContrasenia.ResetText();
        }
    }
}
