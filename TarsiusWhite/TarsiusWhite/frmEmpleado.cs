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
    public partial class frmEmpleado : Form
    {
        public string _auxiliar;
        public frmEmpleado()

        {
            InitializeComponent();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado emp = (Empleado)lstEmpleado.SelectedItem;
                if (emp != null)
                {
                    Empleado.EliminarEmplado(emp);
                    actualizarListaddoEmpleado();
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

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                actualizarListaddoEmpleado();
                cboTipoDocumento.DataSource = Enum.GetValues(typeof(Empleado._tipoDocumento));
                cboSexo.DataSource = Enum.GetValues(typeof(Empleado._sexo));
                bloquearFomulario();
                cboSexo.SelectedItem = null;
                cboTipoDocumento.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lstEmpleado.SelectedIndex;
                Empleado emp = obtenerEmpleadoFormulario();
                Empleado.EditarEmpleado(index, emp);

                limpiarFormulario();
                actualizarListaddoEmpleado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_auxiliar == "AGREGAR")
                {
                    Empleado emp = obtenerEmpleadoFormulario();
                    Empleado.AgregarEmpleado(emp);
                }
                else if (_auxiliar == "EDITAR")
                {
                    int index = lstEmpleado.SelectedIndex;

                    Empleado.listaEmpleados[index] = obtenerEmpleadoFormulario();
                }

                actualizarListaddoEmpleado();
                limpiarFormulario();
                bloquearFomulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizarListaddoEmpleado();
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

        private Empleado obtenerEmpleadoFormulario()
        {
            Empleado emp = new Empleado();

            emp.nombre = txtApellido.Text;
            emp.apellido = txtApellido.Text;
            emp.sexo = (Empleado._sexo)cboSexo.SelectedItem;
            emp.tipoDocumento = (Empleado._tipoDocumento)cboTipoDocumento.SelectedItem;
            emp.fechaNacimiento = dtpFechaNacimiento.Value.Date;
            emp.direccion = txtDireccion.Text;
            emp.nroDocumento = txtNroDocumento.Text;
            emp.telefono = txtTelefono.Text;
            emp.email = txtEmail.Text;
            //emp.acceso = txtAcceso.Text;
            //emp.usuario = txtUsuario.Text;
            //emp.password = txtPassword.Text;

            return emp;
        }

        private void lstEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleado emp = (Empleado)lstEmpleado.SelectedItem;

            if (emp != null)
            {
                txtApellido.Text = emp.nombre;
                txtApellido.Text = emp.apellido;
                txtTelefono.Text = emp.telefono;
                //txtAcceso.Text = emp.acceso;
                //txtUsuario.Text = emp.usuario;
                //txtPassword.Text = emp.password;
                txtEmail.Text = emp.email;
                cboSexo.SelectedItem = emp.sexo;
                cboTipoDocumento.SelectedItem = emp.tipoDocumento;
                txtNroDocumento.Text = emp.nroDocumento;
                dtpFechaNacimiento.Value = emp.fechaNacimiento;
            }
        }

        private void actualizarListaddoEmpleado()
        {
            lstEmpleado.DataSource = null;
            lstEmpleado.DataSource = Empleado.ObtenerEmpleado();
        }

        private void desbloquearFormulario()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            cboSexo.Enabled = true;
            cboTipoDocumento.Enabled = true;
            txtNroDocumento.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            //txtAcceso.Enabled = true;
            //txtUsuario.Enabled = true;
            //txtPassword.Enabled = true;
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
            cboTipoDocumento.SelectedItem = null;
            cboSexo.SelectedItem = null;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtNroDocumento.Text = "";
            txtTelefono.Text = "";
            //txtAcceso.Text = "";
            //txtUsuario.Text = "";
            //txtPassword.Text = "";
            txtEmail.Text = "";
        }

        private void bloquearFomulario()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            cboSexo.Enabled = false;
            cboTipoDocumento.Enabled = false;
            txtNroDocumento.Enabled = false;
            txtNroDocumento.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            //txtAcceso.Enabled = false;
            //txtUsuario.Enabled = false;
            //txtPassword.Enabled = false;
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

            if (cboTipoDocumento.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una opcion de tipo de documento", "Error");
                cboTipoDocumento.Focus();
                return false;
            }

            var fechaIncorrecta = new DateTime(2100, 1, 1);
            if (dtpFechaNacimiento.Value < DateTime.Now || dtpFechaNacimiento.Value > DateTime.Parse("01/01/2100") || dtpFechaNacimiento.Value > fechaIncorrecta)
            {
                MessageBox.Show("Por favor ingrese una fecha de valida", "Error");
                dtpFechaNacimiento.Focus();
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

        private void gpbEmpleado_Enter(object sender, EventArgs e)
        {

        }
    }
}


