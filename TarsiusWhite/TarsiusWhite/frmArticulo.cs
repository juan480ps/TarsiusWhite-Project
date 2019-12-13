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
            try
            {
                _auxiliar = "AGREGAR";
                limpiarFormulario();
                desbloquearFormulario();
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo art = (Articulo)lstArticulos.SelectedItem;
                if (art != null)
                {
                    _auxiliar = "EDITAR";
                    desbloquearFormulario();
                    completarObjetos();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo art = (Articulo)lstArticulos.SelectedItem;
                if (art != null)
                {
                    Articulo.eliminarArticulo(art);
                    actualizarListadoArticullo();
                    limpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Favor seleccionar una fila de la lista");
                }
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
                if (ValidarCampos())
                {
                    if (_auxiliar == "AGREGAR")
                    {
                        Articulo art = obtenerArticuloFormularioAgregar();
                        Articulo.agregarArticulo(art);
                    }
                    else if (_auxiliar == "EDITAR")
                    {
                        int index = lstArticulos.SelectedIndex;
                        Articulo art = obtenerArticuloFormularioEditar();
                        

                        //Articulo art = (Articulo)lstArticulos.SelectedItem;
                        if (art != null)
                        {
                            Articulo.editarArticulo(art);
                            actualizarListadoArticullo();
                            limpiarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("Favor seleccionar una fila de la lista");
                        }
                    }

                    actualizarListadoArticullo();
                    limpiarFormulario();
                    bloquearFormulario();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizarListadoArticullo();
                limpiarFormulario();
                bloquearFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                actualizarListadoArticullo();
                //cboCategoria.DataSource = Enum.GetValues(typeof(Articulo._categoria));
                //cboPresentacion.DataSource = Enum.GetValues(typeof(Articulo._presentacion));
                cboCategoria.DataSource = Categoria.ObtenerCategoria();
                cboPresentacion.DataSource = Presentacion.obtenerPresentacion();
                cboCategoria.SelectedItem = null;
                cboPresentacion.SelectedItem = null;
                bloquearFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void lstArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            completarObjetos();
        }

        private void desbloquearFormulario()
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            cboCategoria.Enabled = true;
            cboPresentacion.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void bloquearFormulario()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            cboCategoria.Enabled = false;
            cboPresentacion.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void limpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cboCategoria.SelectedItem = null;
            cboPresentacion.SelectedItem = null;
        }

        private void actualizarListadoArticullo()
        {
            lstArticulos.DataSource = null;
            lstArticulos.DataSource = Articulo.ObtenerArticulos();
        }

        private Articulo obtenerArticuloFormularioEditar()
        {
            Articulo art = new Articulo();
            art.idArticulo = Convert.ToInt32(txtID.Text);
            art.codigo = txtCodigo.Text;
            art.nombre = txtNombre.Text;
            art.descripcion = txtDescripcion.Text;
            //art.categoria = (Articulo._categoria)cboCategoria.SelectedItem;
            //art.presentacion = (Articulo._presentacion)cboCategoria.SelectedItem;
            art.categoria = (Categoria)cboCategoria.SelectedItem;
            art.presentacion = (Presentacion)cboPresentacion.SelectedItem;

            return art;
        }

        private Articulo obtenerArticuloFormularioAgregar()
        {
            Articulo art = new Articulo();
            //art.idArticulo = Convert.ToInt32(txtID.Text);
            art.codigo = txtCodigo.Text;
            art.nombre = txtNombre.Text;
            art.descripcion = txtDescripcion.Text;
            //art.categoria = (Articulo._categoria)cboCategoria.SelectedItem;
            //art.presentacion = (Articulo._presentacion)cboCategoria.SelectedItem;
            art.categoria = (Categoria)cboCategoria.SelectedItem;
            art.presentacion = (Presentacion)cboPresentacion.SelectedItem;

            return art;
        }

        private void completarObjetos()
        {
            try
            {
                Articulo art = (Articulo)lstArticulos.SelectedItem;

                if (art != null)
                {
                    txtID.Text = Convert.ToString(art.idArticulo);
                    txtCodigo.Text = art.codigo;
                    txtNombre.Text = art.nombre;
                    txtDescripcion.Text = art.descripcion;
                    cboCategoria.SelectedItem = art.categoria;
                    cboPresentacion.SelectedItem = art.presentacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }


        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El codigo no puede estar vacío", "Error");
                txtCodigo.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error");
                txtNombre.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripcion no puede estar vacío", "Error");
                txtDescripcion.Focus();
                return false;
            }

            if (cboCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una Categoria", "Error");
                cboCategoria.Focus();
                return false;
            }

            if (cboPresentacion.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una Presentacion", "Error");
                cboPresentacion.Focus();
                return false;
            }
            return true;
        }

        private void btnCodigoBarra_Click(object sender, EventArgs e)
        {
            frmCodigo_de_Barras frmcodigo = new frmCodigo_de_Barras();
            frmcodigo.Show();
        }
    }
}