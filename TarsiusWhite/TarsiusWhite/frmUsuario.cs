using ClasesTarsius;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarsiusWhite
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuario.CrearUsuario(txtUsuario.Text, txtPassword.Text);
            MessageBox.Show("Usuario creado exitosamente");
            limpiar();
        }

        private void limpiar()
        {
            txtPassword.Text = "";
            txtUsuario.Text = "";
        }
    }
}
