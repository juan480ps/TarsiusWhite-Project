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
            //Empleado empleado = new Empleado();
            //empleado.nombre = txtNombre.Text;
            //empleado.apellido = txtApellido.Text;
            ////empleado.sexo = (Empleado._sexo)cboSexo.SelectedItem;
            //empleado.fechaNacimiento = dtpFechaNacimiento.Value.Date;
            ////empleado.tipoDocumento = (Empleado._tipoDocumento)cboTipoDocumento.SelectedItem;
            //empleado.nroDocumento = txtNroDocumento.Text;
            //empleado.direccion = txtDireccion.Text;
            //empleado.telefono = txtTelefono.Text;
            //empleado.email = txtEmail.Text;
            //empleado.acceso = txtAcceso.Text;
            //empleado.usuario = txtUsuario.Text;
            //empleado.password = txtPassword.Text;

            //Empleado.agregarEmpleado(empleado);
            //limpiarFormulario();
            //actualizarListaddoEmpleado();

            _auxiliar = "AGREGAR";
            limpiarFormulario();
            desbloquearFormulario();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEmpleado.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccionar para eliminar");
            }
            else
            {
                Empleado emp = (Empleado)lstEmpleado.SelectedItem;
                Empleado.listaEmpleados.Remove(emp);
                actualizarListaddoEmpleado();
                limpiarFormulario();
            }
        }

        private void actualizarListaddoEmpleado()
        {
            lstEmpleado.DataSource = null;
            lstEmpleado.DataSource = Empleado.ObtenerEmpleados();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            actualizarListaddoEmpleado();
            cboSexo.DataSource = Enum.GetValues(typeof(Empleado._sexo));
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(Empleado._tipoDocumento));
            bloquearFomulario();
            cboSexo.SelectedItem = null;
            cboTipoDocumento.SelectedItem = null;
        }

        //_auxiliar = "AGREGAR";
        //limpiarFormulario();
        //desbloquearFormulario();
        //txtNombre.Focus();


        private void desbloquearFormulario()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            cboSexo.Enabled = true;
            cboTipoDocumento.Enabled = true;
            txtNroDocumento.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtAcceso.Enabled = true;
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
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
            txtAcceso.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //_auxiliar = "EDITAR";
            //desbloquearFormulario();
            //txtApellido.Focus();

            int index = lstEmpleado.SelectedIndex;
            Empleado emp = obtenerEmpleadoFormulario();
            Empleado.editarEmpleado(index, emp);


            limpiarFormulario();
            actualizarListaddoEmpleado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_auxiliar == "AGREGAR")
            {
                Empleado emp = obtenerEmpleadoFormulario();
                Empleado.agregarEmpleado(emp);
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

        private void bloquearFomulario()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            cboSexo.Enabled = false;
            cboTipoDocumento.Enabled = false;
            txtNroDocumento.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtAcceso.Enabled = false;
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
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


        private Empleado obtenerEmpleadoFormulario()
        {
            Empleado emp = new Empleado();
            emp.nombre = txtApellido.Text;
            emp.apellido = txtApellido.Text;
            emp.sexo = (Empleado._sexo)cboSexo.SelectedIndex;
            emp.fechaNacimiento = dtpFechaNacimiento.Value.Date;
            emp.tipoDocumento = (Empleado._tipoDocumento)cboTipoDocumento.SelectedIndex;
            emp.nroDocumento = txtNroDocumento.Text;
            emp.telefono = txtTelefono.Text;
            emp.acceso = txtAcceso.Text;
            emp.usuario = txtUsuario.Text;
            emp.password = txtPassword.Text;
            emp.email = txtEmail.Text;

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
                txtAcceso.Text = emp.acceso;
                txtUsuario.Text = emp.usuario;
                txtPassword.Text = emp.password;
                txtEmail.Text = emp.email;
                cboSexo.SelectedItem = emp.sexo;
                cboTipoDocumento.SelectedItem = emp.tipoDocumento;
                dtpFechaNacimiento.Value = emp.fechaNacimiento;
            }
        }
    }
}


