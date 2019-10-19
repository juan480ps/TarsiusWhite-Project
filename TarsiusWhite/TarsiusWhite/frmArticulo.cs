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
            ptbImagen.Enabled = true;
            cboCategoria.Enabled = true;
            cboPresentacion.Enabled = true;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void limpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            ptbImagen.Image.Dispose();
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
            //art.Imagen = byte[](ptbImagen);
            art.Categoria = (_categoria)
            carne.fecha_vencimiento = dtpFechaVencimiento.Value.Date;
            carne.precio = (double)nudPrecio.Value;

            carne.categoria = (Categoria)cboCategoria.SelectedItem;
            carne.proveedor = (Proveedor)cboProveedor.SelectedItem;

            if (rbuVacuna.Checked)
            {
                carne.tipo_carne = TipoCarne.Vacuna;
            }
            else if (rbuPorcina.Checked)
            {
                carne.tipo_carne = TipoCarne.Porcina;
            }

            return carne;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            ActualizarListaCarnes();
            cboCategoria.DataSource = Enum.GetValues(typeof(Categoria));
            cboProveedor.DataSource = Proveedor.ObtenerProveedores();
            cboCategoria.SelectedItem = null;
            cboProveedor.SelectedItem = null;
            BloquearFormulario();
        }

        private void lstArticulos_Click(object sender, EventArgs e)
        {
            Carne carne = (Carne)lstCarnes.SelectedItem;

            if (carne != null)
            {
                txtNombre.Text = carne.nombre;

                nudPeso.Value = (decimal)carne.peso;
                dtpFechaVencimiento.Value = carne.fecha_vencimiento;
                nudPrecio.Value = (decimal)carne.precio;

                cboCategoria.SelectedItem = carne.categoria;
                cboProveedor.SelectedItem = carne.proveedor;

                if (carne.tipo_carne == TipoCarne.Porcina)
                {
                    rbuPorcina.Checked = true;
                }
                else if (carne.tipo_carne == TipoCarne.Vacuna)
                {
                    rbuVacuna.Checked = true;
                }

            }

        }
    }
}
