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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _auxiliar = "AGREGAR";
            limpiarFormulario();
            desbloquearFormulario();
            txtDescripcionCategoria.Focus();
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
            _auxiliar = "EDITAR";
            desbloquearFormulario();
            txtNombreCategoria.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)lstCategoria.SelectedItem;
            if (categoria != null)
            {
                Categoria.eliminarCategoria(categoria);
                actualizarlstCategoria();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar una fila de la lista");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_auxiliar == "AGREGAR")
            {
                Categoria cat = obtenerCategoria();
                Categoria.agregarCategoria(cat);
            }
            else if (_auxiliar == "EDITAR")
            {
                int index = lstCategoria.SelectedIndex;
                //Categoria.lstCategoria[index] = obtenerCategoria();
                Categoria cat = obtenerCategoriaFormulario();
                Categoria.editarCategoria(cat, index);
            }

            actualizarlstCategoria();
            limpiarFormulario();
            bloquearFormulario();
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
            Application.Exit();
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
    }
}
