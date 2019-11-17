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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frmarticulo = new frmArticulo();
            frmarticulo.Show();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoria frmcartegoria = new frmCategoria();
            frmcartegoria.Show();
        }

        private void presentacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPresentacion frmpresentacion = new frmPresentacion();
            frmpresentacion.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado frmempleado = new frmEmpleado();
            frmempleado.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.Show();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta frmventa = new frmVenta();
            frmventa.Show();
        }
    }
}
