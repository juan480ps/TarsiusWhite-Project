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
            try
            {
                if (ValidarCampos())
                {
                    _auxiliar = "AGREGAR";
                    limpiarFormulario();
                    desbloquearFormulario();
                    txtNombrePresentacion.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
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
            try
            {
                lstPresentaciones.DataSource = null;
                lstPresentaciones.DataSource = Presentacion.obtenerPresentacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
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
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {
            actualizarListadoPresentacion();
            bloquearFormulario();
        }
        private void completarObjetos()
        {
            try
            {
                Presentacion pre = (Presentacion)lstPresentaciones.SelectedItem;

                if (pre != null)
                {
                    txtNombrePresentacion.Text = pre.nombrePresentacion;
                    txtDescripcionPresentacion.Text = pre.descripcionPresentacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNombrePresentacion.Text))
            {
                MessageBox.Show("El codigo no puede estar vacío", "Error");
                txtNombrePresentacion.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtDescripcionPresentacion.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error");
                txtDescripcionPresentacion.Focus();
                return false;
            }

            return true;
        }
    }
}