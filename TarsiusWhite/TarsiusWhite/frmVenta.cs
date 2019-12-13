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
    public partial class frmVenta : Form
    {
        Venta venta;

        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDetalleVenta.AutoGenerateColumns = true;
                cboArticulo.DataSource = Articulo.ObtenerArticulo();
                cmbCliente.DataSource = Cliente.ObtenerCliente();
                cmbCliente.SelectedItem = null;
                cboArticulo.SelectedItem = null;
                venta = new Venta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    DetalleVenta dv = new DetalleVenta();
                    dv.cantidad = Convert.ToInt32(txtCantidad.Text);
                    dv.PrecioVenta = Convert.ToInt32(txtPrecio.Text);
                    dv.articulo = (Articulo)cboArticulo.SelectedItem;
                    venta.detalleVenta.Add(dv);
                    ActualizarDataGrid();

                    txtCantidad.Text = "0";
                    cboArticulo.SelectedItem = null;
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
                DetalleVenta dv = (DetalleVenta)dgvDetalleVenta.CurrentRow.DataBoundItem;
                venta.detalleVenta.Remove(dv);
                ActualizarDataGrid();
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
                venta.fechaVenta = dtpFechaVenta.Value.Date;
                venta.cliente = (Cliente)cmbCliente.SelectedItem;

                Venta.Agregar(venta);
                MessageBox.Show("El pedido ha sido guardado con éxito");
                Limpiar();
                dgvDetalleVenta.DataSource = null;
                dtpFechaVenta.Value = System.DateTime.Now;
                cmbCliente.SelectedItem = null;
                venta = new Venta();
                ActualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DetalleVenta dv = (DetalleVenta)dgvDetalleVenta.CurrentRow.DataBoundItem;
                venta.detalleVenta.Remove(dv);
                ActualizarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void ActualizarDataGrid()
        {
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = venta.detalleVenta;
        }

        private void Limpiar()
        {
            txtCantidad.Text = "0";
            cboArticulo.SelectedItem = null;
            cmbCliente.SelectedItem = null;
            txtPrecio.Text = "0";
        }

        private bool ValidarCampos()
        {
            

            if (cboArticulo.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una Categoria", "Error");
                cboArticulo.Focus();
                return false;
            }

            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un Cliente", "Error");
                cmbCliente.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("La cantidad no puede estar vacía", "Error");
                txtCantidad.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("El precio no puede estar vacíp", "Error");
                txtPrecio.Focus();
                return false;
            }            
            return true;
        }
    }
}
