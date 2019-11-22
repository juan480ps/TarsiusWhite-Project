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
            dtgDetalleVenta.AutoGenerateColumns = true;
            cmbCategoria.DataSource = Categoria.ObtenerCategoria();
            cmbCliente.DataSource = Cliente.ObtenerCliente();
            cmbCliente.SelectedItem = null;
            cmbCategoria.SelectedItem = null;
            venta = new Venta();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleVenta dv = new DetalleVenta();
            dv.cantidad = Convert.ToInt32(txtCantidad.Text);
            dv.PrecioVenta = Convert.ToInt32(txtPrecio.Text);
            dv.categoria = (Categoria)cmbCategoria.SelectedItem;
            venta.detalleVenta.Add(dv);
            ActualizarDataGrid();

            txtCantidad.Text = "0";
            cmbCategoria.SelectedItem = null;
        }

        private void ActualizarDataGrid()
        {
            dtgDetalleVenta.DataSource = null;
            dtgDetalleVenta.DataSource = venta.detalleVenta;
        }

        private void Limpiar()
        {
            txtCantidad.Text = "0";
            cmbCategoria.SelectedItem = null;
            cmbCliente.SelectedItem = null;
            txtPrecio.Text = "0";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DetalleVenta dv = (DetalleVenta)dtgDetalleVenta.CurrentRow.DataBoundItem;
            venta.detalleVenta.Remove(dv);
            ActualizarDataGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            venta.fechaVenta = dtpFechaVenta.Value.Date;
            venta.cliente = (Cliente)cmbCliente.SelectedItem;

            Venta.Agregar(venta);
            MessageBox.Show("El pedido ha sido guardado con éxito");
            Limpiar();
            dtgDetalleVenta.DataSource = null;
            dtpFechaVenta.Value = System.DateTime.Now;
            cmbCliente.SelectedItem = null;
            venta = new Venta();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
