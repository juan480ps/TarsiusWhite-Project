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
    public partial class frmPresentaciones : Form
    {
        string tarsius;
        public frmPresentaciones()
        {
            InitializeComponent();
        }

        private void btnNuevoMantPresen_Click(object sender, EventArgs e)
        {
            tarsius = "NUEVO";
            limpiarFormulario();
            desbloquearFormulario();
            txtCodigoMantPresen.Focus();
        }

        private void limpiarFormulario()
        {
            txtCodigoMantPresen.Text = "";
            txtNombreMantPresen.Text = "";
            txtDescripcionMantPresen.Text = ""; 
        }

        private void bloquearFormulario()
        {
            txtCodigoMantPresen.Enabled = false;
            txtNombreMantPresen.Enabled = false;
            txtDescripcionMantPresen.Enabled = false;
            btnGuardarMantPresen.Enabled = false;
            btnEditarMantPresen.Enabled = false;
            btnEliminarPresenList.Enabled = false;

            btnNuevoMantPresen.Enabled = true;
        }

        private void desbloquearFormulario()
        {
            txtCodigoMantPresen.Enabled = true;
            txtNombreMantPresen.Enabled = true;
            txtDescripcionMantPresen.Enabled = true;
            btnGuardarMantPresen.Enabled = true;
            btnEditarMantPresen.Enabled = true;
            btnEliminarPresenList.Enabled = true;

            btnNuevoMantPresen.Enabled = false;
        }

        private void frmPresentaciones_Load(object sender, EventArgs e)
        {
            actualizarListaPresentaciones();
            //cboCategoria.DataSource = Enum.GetValues(typeof(Categoria));
            //cboProveedor.DataSource = Proveedor.ObtenerProveedores();
            //cboCategoria.SelectedItem = null;
            //cboProveedor.SelectedItem = null;
            //BloquearFormulario();
        }

        private void actualizarListaPresentaciones()
        {
            dgvPresentacionesList.DataSource = null;
            dgvPresentacionesList.DataSource = Presentacion.ObtenerCarnes();
        }
    }
}
