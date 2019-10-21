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
    public partial class frmCliente : Form
    {
        public string _auxiliar;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void gpbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _auxiliar = "AGREGAR";
            limpiarFormulario();
            desbloquearFormulario();
            txtNombre.Focus();
        }

        private void desbloquearFormulario()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            cboSexo.Enabled = true;
            cboTipoDocumento.Enabled = true;
            txtNroDocumento.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtEmail.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;


            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void limpiarFormulario()
        {
            txtApellido.Text = "";
            txtApellido.Text = "";
            cboSexo.SelectedItem = null;
            dtpFechaNacimiento.Value = DateTime.Now;
            cboTipoDocumento.SelectedItem = null;
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            _auxiliar = "EDITAR";
            desbloquearFormulario();
            txtApellido.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCliente.SelectedItems.Count > 0)
            {
                Cliente cli = (Cliente)lstCliente.SelectedItem;
                Cliente.listaClientes.Remove(cli);
                actualizarListadoCliente();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar para eliminar");
            }
        }

        private void actualizarListadoCliente()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerClientes();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_auxiliar == "AGREGAR")
            {
                Cliente cli = obtenerClienteFormulario();
                Cliente.agregarCliente(cli);
            }
            else if (_auxiliar == "EDITAR")
            {
                int index = lstCliente.SelectedIndex;

                Cliente.listaClientes[index] = obtenerClienteFormulario();
            }

            actualizarListadoCliente();
            limpiarFormulario();
            bloquearFomulario();
        }

        private void bloquearFomulario()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            cboSexo.Enabled = false;
            cboTipoDocumento.Enabled = false;
            txtNroDocumento.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;


            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void lstCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = (Cliente)lstCliente.SelectedItem;

            if (cli != null)
            {
                txtApellido.Text = cli.nombre;
                txtApellido.Text = cli.apellido;
                txtTelefono.Text = cli.telefono;
                txtEmail.Text = cli.email;
                cboSexo.SelectedItem = cli.sexo;
                cboTipoDocumento.SelectedItem = cli.tipoDocumento;
                dtpFechaNacimiento.Value = cli.fechaNacimiento;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            actualizarListadoCliente ();
            cboSexo.DataSource = Enum.GetValues(typeof(Cliente._sexo));
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(Cliente._tipoDocumento));
            bloquearFomulario();
            cboSexo.SelectedItem = null;
            cboTipoDocumento.SelectedItem = null;
        }

        private Cliente obtenerClienteFormulario()
        {
            Cliente cli = new Cliente();
            cli.nombre = txtApellido.Text;
            cli.apellido = txtApellido.Text;
            cli.sexo = (Cliente._sexo)cboSexo.SelectedItem;
            cli.fechaNacimiento = dtpFechaNacimiento.Value.Date;
            cli.tipoDocumento = (Cliente._tipoDocumento)cboTipoDocumento.SelectedItem;
            cli.telefono = txtTelefono.Text;
            cli.email = txtEmail.Text;


            return cli;
        }
    }
}
