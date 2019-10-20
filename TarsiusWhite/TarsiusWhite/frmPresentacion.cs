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
    public partial class frmPresentacion : Form
    {
        public string _auxiliar;
        public frmPresentacion()
        {
            InitializeComponent();
        }
        private void desbloquearFormulario()
        {
            txtCodigoPresentacion.Enabled = true;
            txtNombrePresentacion.Enabled = true;
            txtDescripcionPresentacion.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void bloquearFormulario()
        {
            txtCodigoPresentacion.Enabled = true;
            txtNombrePresentacion.Enabled = true;
            txtDescripcionPresentacion.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void limpiarFormulario()
        {
            txtCodigoPresentacion.Text = "";
            txtNombrePresentacion.Text = "";
            txtDescripcionPresentacion.Text = "";


        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _auxiliar = "AGREGAR";
            limpiarFormulario();
            desbloquearFormulario();
            txtCodigoPresentacion.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _auxiliar = "EDITAR";
            desbloquearFormulario();
            txtCodigoPresentacion.Focus();
        }

        private void LstPresentaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPresentaciones.SelectedItems.Count > 0)
            {
                Presentacion pre = (Presentacion)lstPresentaciones.SelectedItem;
                Presentacions.listaPresentacion.Remove(pre);
                actualizarListadoPresentacion();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
        private Presentacion obtenerPresentacionFormulario()
        {
            Presentacion pre = new Presentacion();
            pre.Codigo = txtCodigoPresentacion.Text;
            pre.Nombre = txtNombrePresentacion.Text;
            pre.Descripcion = txtDescripcionPresentacion.Text;


            return pre;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }


        private void lstPresentacion_Click(object sender, EventArgs e)
        {
            Presentacion pre = (Presentacion)lstPresentaciones.SelectedItem;

            if (pre != null)
            {
                txtCodigoPresentacion.Text = pre.Codigo;
                txtNombrePresentacion.Text = pre.Nombre;
                txtDescripcionPresentacion.Text = pre.Descripcion;

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (lstPresentaciones.SelectedItems.Count > 0)
            {
                Presentacion pre = (Presentacion)lstPresentaciones.SelectedItem;
                Presentacions.listaPresentacion.Remove(pre);
                actualizarListadoPresentacion();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
            private void actualizarListadoPresentacion()
            {
                lstPresentaciones.DataSource = null;
                lstPresentaciones.DataSource = Presentacions.ObtenerPresentacion();
            }
        }

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {

        }
    }
}