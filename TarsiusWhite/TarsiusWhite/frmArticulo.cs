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
    public partial class frmArticulo : Form
    {
        public string _auxiliar;
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _auxiliar = "AGREGAR";
            limpiarFormulario();
            desbloquearFormulario();
            txtCodigo.Focus();
        }

        private void desbloquearFormulario()
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            cboCategoria.Enabled = true;
            cboPresentacion.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void bloquearFormulario()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            cboCategoria.Enabled = false;
            cboPresentacion.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;



        }

        private void limpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cboCategoria.SelectedItem = null;
            cboPresentacion.SelectedItem = null;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _auxiliar = "EDITAR";
            desbloquearFormulario();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstArticulos.SelectedItems.Count > 0)
            {
                Articulo art = (Articulo)lstArticulos.SelectedItem;
                Articulo.listaArticulos.Remove(art);
                actualizarListadoArticullo();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
        }

        private void actualizarListadoArticullo()
        {
            lstArticulos.DataSource = null;
            lstArticulos.DataSource = Articulo.ObtenerArticulos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_auxiliar == "AGREGAR")
            {
                Articulo art = obtenerArticuloFormulario();
                Articulo.agregarArticulo(art);
            }
            else if (_auxiliar == "EDITAR")
            {
                int index = lstArticulos.SelectedIndex;

                Articulo.listaArticulos[index] = obtenerArticuloFormulario();
            }

            actualizarListadoArticullo();
            limpiarFormulario();
            bloquearFormulario();
        }

        private Articulo obtenerArticuloFormulario()
        {
            Articulo art = new Articulo();
            art.Codigo = txtCodigo.Text;
            art.Nombre = txtNombre.Text;
            art.Descripcion = txtDescripcion.Text;
            art.categoria = (Articulo._categoria)cboCategoria.SelectedItem;
            art.presentacion = (Articulo._presentacion)cboPresentacion.SelectedItem;

            return art;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            actualizarListadoArticullo();
            cboCategoria.DataSource = Enum.GetValues(typeof(Articulo._categoria));
            cboPresentacion.DataSource = Enum.GetValues(typeof(Articulo._presentacion));
            cboCategoria.SelectedItem = null;
            cboPresentacion.SelectedItem = null;
            bloquearFormulario();
        }

        private void lstArticulos_Click(object sender, EventArgs e)
        {
            Articulo art = (Articulo)lstArticulos.SelectedItem;

            if (art != null)
            {
                txtCodigo.Text = art.Codigo;
                txtNombre.Text = art.Nombre;
                txtDescripcion.Text = art.Descripcion;
                cboCategoria.SelectedItem = art.categoria;
                cboPresentacion.SelectedItem = art.presentacion;
            }
        }
    }
}
