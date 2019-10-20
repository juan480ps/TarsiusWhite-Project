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
            _auxiliar = "AGREGAR";
            limpiarFormulario();
            desbloquearFormulario();
            txtApellido.Focus();
        }

        private void desbloquearFormulario()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            cboSexo.Enabled = true;
            cboTipoDocumento.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtAcceso.Enabled = true;
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            txtEmail.Enabled = true;

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
            _auxiliar = "EDITAR";
            desbloquearFormulario();
            txtApellido.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEmpleado.SelectedItems.Count < 0)
            {
                Empleado emp = (Empleado)lstEmpleado.SelectedItem;
                Empleado.listaEmpleados.Remove(emp);
                actualizarListaddoEmpleado();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar para eliminar");
            }
        }
        private void actualizarListaddoEmpleado()
        {
            lstEmpleado.DataSource = null;
            lstEmpleado.DataSource = Empleado.ObtenerEmpleados();
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
            dtpFechaNacimiento.Enabled = false;
            txtAcceso.Enabled = false;
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;

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

        private void lstEmpleado_Click(object sender, EventArgs e)
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

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            actualizarListaddoEmpleado();
            cboSexo.DataSource = Enum.GetValues(typeof(Empleado._sexo));
            bloquearFomulario();
        }

        private Empleado obtenerEmpleadoFormulario()
        {
            Empleado emp = new Empleado();
            emp.nombre = txtApellido.Text;
            emp.apellido = txtApellido.Text;
            emp.sexo = (Empleado._sexo) cboSexo.SelectedItem;
            emp.fechaNacimiento = dtpFechaNacimiento.Value.Date;
            emp.tipoDocumento = (Empleado._tipoDocumento)cboTipoDocumento.SelectedItem;
            emp.telefono = txtTelefono.Text;
            emp.acceso = txtAcceso.Text;
            emp.usuario = txtUsuario.Text;
            emp.password = txtPassword.Text;
            emp.email = txtEmail.Text;


            return emp;
        }
    }
}

      
