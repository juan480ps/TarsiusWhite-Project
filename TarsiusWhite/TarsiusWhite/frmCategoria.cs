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
    public partial class frmCategoria : Form
    {
        public string _auxiliar;
        public frmCategoria()
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
                txtDescripcionCategoria.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void desbloquearFormulario()
        {
            txtDescripcionCategoria.Enabled = true;
            txtNombreCategoria.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void bloquearFormulario()
        {
            txtDescripcionCategoria.Enabled = false;
            txtNombreCategoria.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void limpiarFormulario()
        {
            txtDescripcionCategoria.Text = "";
            txtNombreCategoria.Text = "";
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                _auxiliar = "EDITAR";
                desbloquearFormulario();
                txtNombreCategoria.Focus();
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
                Categoria cat = (Categoria)lstCategoria.SelectedItem;
                if (cat != null)
                {
                    Categoria.eliminarCategoria(cat);
                   actualizarlstCategoria();
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
                        Categoria cat = obtenerCategoria();
                        Categoria.agregarCategoria(cat);
                    }
                    else if (_auxiliar == "EDITAR")
                    {
                      int index = lstCategoria.SelectedIndex;
                      Categoria cat = obtenerCategoria();
                      Categoria.editarCategoria(cat, index);
                    }

                    actualizarlstCategoria();
                    limpiarFormulario();
                    bloquearFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private Categoria obtenerCategoria()
        {
            Categoria cat = new Categoria();
           // cat.IDCategoria = Convert.ToInt32(txtCodigoCategoria.Text); 
            cat.NombreCategoria = txtNombreCategoria.Text;
            cat.DescripcionCategoria = txtDescripcionCategoria.Text;
            return cat;
        }

        private void actualizarlstCategoria()
        {
            lstCategoria.DataSource = null;
            lstCategoria.DataSource = Categoria.ObtenerCategoria(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizarlstCategoria();
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

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            actualizarlstCategoria();
            bloquearFormulario(); 
        }

        private void lstCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           Categoria cat = (Categoria)lstCategoria.SelectedItem;

            if (cat != null)
            {
                txtDescripcionCategoria.Text = cat.DescripcionCategoria;
                txtNombreCategoria.Text = cat.NombreCategoria; 
            }
        }

        private Categoria obtenerCategoriaFormulario()
        {
            Categoria cat = new Categoria();

            cat.NombreCategoria = txtNombreCategoria.Text;
            cat.DescripcionCategoria = txtDescripcionCategoria.Text;

            return cat;
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtDescripcionCategoria.Text))
            {
                MessageBox.Show("La descripción no puede estar vacío", "Error");
                txtDescripcionCategoria.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error");
                txtNombreCategoria.Focus();
                return false;
            }
            
            return true;
        }

        private void completarObjetos()
        {
            try
            {
               Categoria cat = (Categoria)lstCategoria.SelectedItem;

                if (cat != null)
                {
                    txtDescripcionCategoria.Text = cat.DescripcionCategoria;
                    txtNombreCategoria.Text = cat.NombreCategoria;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
