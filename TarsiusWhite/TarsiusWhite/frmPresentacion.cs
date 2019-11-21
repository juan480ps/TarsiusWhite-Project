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
            txtNombrePresentacion.Enabled = false;
            txtDescripcionPresentacion.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void limpiarFormulario()
        {
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
            txtNombrePresentacion.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Presentacion pre = (Presentacion)lstPresentaciones.SelectedItem;
            if (pre != null)
            {
                _auxiliar = "EDITAR";
                desbloquearFormulario();
            }
            else
            {
                MessageBox.Show("Ojo, Selecciona un Item");
            }
        }

        private void LstPresentaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                Presentacion pre = (Presentacion)lstPresentaciones.SelectedItem;

                if (pre != null)
                {
                    txtDescripcionPresentacion.Text = pre.descripcionPresentacion;
                    txtNombrePresentacion.Text = pre.nombrePresentacion;
                }
            }
        }

        private void actualizarListadoPresentacion()
        {
            lstPresentaciones.DataSource = null;
            lstPresentaciones.DataSource = Presentacion.obtenerPresentacion();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (_auxiliar == "AGREGAR")
            {
                Presentacion pre = obtenerPresentacionFormulario();
                Presentacion.agregarPresentacion(pre);
            }
            else if (_auxiliar == "EDITAR")
            {
                int index = lstPresentaciones.SelectedIndex;
                //Articulo.listaArticulos[index] = obtenerArticuloFormulario();
                Presentacion pre = obtenerPresentacionFormulario();
                Presentacion.editarPresentacion(pre, index);
            }

            actualizarListadoPresentacion();
            limpiarFormulario();
            bloquearFormulario();
        }

        private Presentacion obtenerPresentacionFormulario()
        {
            Presentacion pre = new Presentacion();
            pre.nombrePresentacion = txtNombrePresentacion.Text;
            pre.descripcionPresentacion = txtDescripcionPresentacion.Text;


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
                txtNombrePresentacion.Text = pre.nombrePresentacion;
                txtDescripcionPresentacion.Text = pre.descripcionPresentacion;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (lstPresentaciones.SelectedItems.Count > 0)
            {
                Presentacion pre = (Presentacion)lstPresentaciones.SelectedItem;
                Presentacion.listaPresentacion.Remove(pre);
                actualizarListadoPresentacion();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
        }

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {
            actualizarListadoPresentacion();
            bloquearFormulario();
        }
    }
}