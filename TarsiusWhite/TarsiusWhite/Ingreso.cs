using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesTarsius; 

namespace TarsiusWhite
{
    public partial class Ingreso : Form
    {
        Ingreso ingreso; 
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleIngreso di = new  DetalleIngreso();
          
            di.TipoComprobante = cmbTipoComprobante.Text;
            di.Igv = txtIgv.Text;

            di.Estado = txtEstado.Text; 
            ActualizarDataGrid();

            Limpiar();
        }

        private void Limpiar()
        {
            throw new NotImplementedException();
        }

        private void ActualizarDataGrid()
        {
            dgtbDetalleIngreso.DataSource = null;
            dgtbDetalleIngreso.DataSource = Ingreso.detalle_ingreso;
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            dgtbDetalleIngreso.AutoGenerateColumns = true;
            cmbTipoComprobante.DataSource = Categoria.ObtenerCategoria();
           
            
            ingreso = new Ingreso();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           DetalleIngreso di = (DetalleIngreso)dgtbDetalleIngreso.CurrentRow.DataBoundItem;
            Ingreso.detalleIngreso.Remove(di);
            ActualizarDataGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            dgtbDetalleIngreso.cliente = (Cliente)cmbCliente.SelectedItem;

            Ingreso.Agregar(ingreso);
            MessageBox.Show("El pedido ha sido guardado con éxito");
            Limpiar();
            dgtbDetalleIngreso.DataSource = null;
            
           ingreso = new Ingreso();
        }
    }
}
