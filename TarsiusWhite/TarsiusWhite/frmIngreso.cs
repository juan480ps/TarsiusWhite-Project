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
    public partial class frmIngreso : Form
    {

        public enum _tipocomprobante
        {
            Factura,
            Boleta_de_Venta,
            Recibo,

        }

        Ingreso ingreso; 
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleIngreso di = new  DetalleIngreso();
          
            di.TipoComprobante = cmbTipoComprobante.Text;
            di.Igv = txtIgv.Text;
            di.Estado = txtEstado.Text;
            di.Correlativo = txtCorrelativo.Text;
            ingreso.detalleIngreso.Add(di); 
            ActualizarDataGrid();
            Limpiar();
        }

        private void Limpiar()
        {
            txtCorrelativo.Text = null;
            cmbTipoComprobante.SelectedItem = null;
            txtEstado.Text = null;
            txtIgv.Text = null;
            txtCorrelativo.Text = null; 
        }

        private void ActualizarDataGrid()
        {
            dgtbDetalleIngreso.DataSource = null;
            dgtbDetalleIngreso.DataSource = ingreso.detalleIngreso;
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            dgtbDetalleIngreso.AutoGenerateColumns = true;
            cmbTipoComprobante.SelectedItem = null;
            cmbTipoComprobante.DataSource = Enum.GetValues(typeof(Ingreso._tipocomprobante));
            txtCorrelativo.Text = null; 
            txtEstado.Text = null;
            txtIgv.Text = null;
          
            ingreso = new Ingreso();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DetalleIngreso di = (DetalleIngreso)dgtbDetalleIngreso.CurrentRow.DataBoundItem;
            ingreso.detalleIngreso.Remove(di);
            ActualizarDataGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
            Ingreso.Agregar(ingreso);
            MessageBox.Show("El pedido ha sido guardado con éxito");
            Limpiar();
            dgtbDetalleIngreso.DataSource = null;
            dtpFechaIngreso.Value = System.DateTime.Now;
            cmbTipoComprobante.SelectedItem = null;
            ingreso = new Ingreso();
        }

        private void cmbTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
