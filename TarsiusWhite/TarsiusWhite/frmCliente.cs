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
            try
            {
                _auxiliar = "AGREGAR";
                limpiarFormulario();
                desbloquearFormulario();
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

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
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboSexo.SelectedItem = null;
            dtpFechaNacimiento.Value = DateTime.Now;
            cboTipoDocumento.SelectedItem = null;
            txtNroDocumento.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)lstCliente.SelectedItem;
                if (cliente != null)
                {
                    _auxiliar = "EDITAR";
                    desbloquearFormulario();
                }
                else
                {
                    MessageBox.Show("Ojo, Selecciona un Item");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)lstCliente.SelectedItem;
                if (cliente != null)
                {
                    Cliente.EliminarCliente(cliente);
                    actualizarListadoCliente();
                    limpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Favor seleccionar una fila de la lista");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }

        private void actualizarListadoCliente()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerCliente();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    if (_auxiliar == "AGREGAR")
                    {
                        Cliente cli = obtenerClienteFormulario();
                        Cliente.AgregarCliente(cli);
                    }
                    else if (_auxiliar == "EDITAR")
                    {
                        int index = lstCliente.SelectedIndex;
                        Cliente cliente = obtenerClienteFormulario();
                        Cliente.EditarCliente(index, cliente);
                    }

                    actualizarListadoCliente();
                    limpiarFormulario();
                    bloquearFomulario();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }
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
            try
            {
                actualizarListadoCliente();
                limpiarFormulario();
                bloquearFomulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

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
            try
            {
                actualizarListadoCliente();
                cboSexo.DataSource = Enum.GetValues(typeof(Cliente._sexo));
                cboTipoDocumento.DataSource = Enum.GetValues(typeof(Cliente._tipoDocumento));
                cboSexo.SelectedItem = null;
                cboTipoDocumento.SelectedItem = null;
                bloquearFomulario();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }

        private Cliente obtenerClienteFormulario()
        {


            Cliente cli = new Cliente();
            cli.nombre = txtNombre.Text;
            cli.apellido = txtApellido.Text;
            cli.sexo = (Cliente._sexo)cboSexo.SelectedItem;
            cli.fechaNacimiento = dtpFechaNacimiento.Value.Date;
            cli.tipoDocumento = (Cliente._tipoDocumento)cboTipoDocumento.SelectedItem;
            cli.telefono = txtTelefono.Text;
            cli.email = txtEmail.Text;
            cli.nroDocumento = txtNroDocumento.Text;
            cli.direccion = txtDireccion.Text;


            return cli;
        }

        private void lstCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)lstCliente.SelectedItem;

            if (c != null)
            {
                txtNombre.Text = c.nombre;
                txtApellido.Text = c.apellido;
                cboSexo.SelectedItem = c.sexo;
                cboTipoDocumento.SelectedItem = c.tipoDocumento;
                txtNroDocumento.Text = c.nroDocumento;
                txtDireccion.Text = c.direccion;
                txtTelefono.Text = c.telefono;
                txtEmail.Text = c.email;

            }
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error");
                txtNombre.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido no puede estar vacío", "Error");
                txtApellido.Focus();
                return false;
            }

            if (cboSexo.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una opcion de sexo", "Error");
                cboSexo.Focus();
                return false;
            }

            if (dtpFechaNacimiento.Value >= DateTime.Now)
            {
                MessageBox.Show("Por favor ingrese una fecha de valida", "Error");
                dtpFechaNacimiento.Focus();
                return false;
            }

            if (cboTipoDocumento.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una opcion de tipo de documento", "Error");
                cboTipoDocumento.Focus();
                return false;
            }


            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La direccion no puede estar vacío", "Error");
                txtDireccion.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El telefono no puede estar vacío", "Error");
                txtTelefono.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El email no puede estar vacío", "Error");
                txtEmail.Focus();
                return false;
            }

            return true;
        }
    }
}