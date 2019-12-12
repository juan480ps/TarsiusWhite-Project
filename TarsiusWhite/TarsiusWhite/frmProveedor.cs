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
    public partial class frmProveedor : Form
    {
        public string _auxiliar;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                _auxiliar = "AGREGAR";
                limpiarFormulario();
                desbloquearFormulario();
                txtrazonsocial.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void desbloquearFormulario()
        {
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            
            txtnrodocumento.Enabled = true;
            txtrazonsocial.Enabled = true;
            txtTelefono.Enabled = true;
            cboSector.Enabled = true;
            cboTipoDocumento.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void limpiarFormulario()
        {
            txtTelefono.Text = "";
            txtrazonsocial.Text = "";
            txtnrodocumento.Text = "";
            
            txtEmail.Text = "";
            txtDireccion.Text = ""; 
            cboSector.SelectedItem = null;
            cboTipoDocumento.SelectedItem = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                Proveedor pro = (Proveedor)lstProveedor.SelectedItem;
                if (pro != null)
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

        private void completarObjetos()
        {
            try
            {
                Proveedor pro = (Proveedor)lstProveedor.SelectedItem;

                if (pro != null)
                {
                    txtDireccion.Text = pro.Direccion;
                    txtEmail.Text = pro.Email;
                    txtnrodocumento.Text = pro.NroDocumento;
                    txtrazonsocial.Text = pro.RazonSocial;
                    txtTelefono.Text = pro.Telefono;
                    cboSector.SelectedItem = pro.sectorcomercial;
                    cboTipoDocumento.SelectedItem = pro.tipodocumento;
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
                Proveedor pro = (Proveedor)lstProveedor.SelectedItem;
                if (pro != null)
                {
                    Proveedor.eliminarproveedor(pro);
                    actualizarListadoProveedor();
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

        private void actualizarListadoProveedor()
        {
            lstProveedor.DataSource = null;
            lstProveedor.DataSource = Proveedor.ObtenerProveedor();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (_auxiliar == "AGREGAR")
                    {
                        Proveedor pro = obtenerProveedorFormulario();
                        Proveedor.agregarproveedor(pro);
                    }
                    else if (_auxiliar == "EDITAR")
                    {
                        int index = lstProveedor.SelectedIndex;
                        Proveedor pro = obtenerProveedorFormulario();
                        Proveedor.editarproveedor(pro, index);
                    }

                    actualizarListadoProveedor();
                    limpiarFormulario();
                    bloquearFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La direccion no puede estar vacío", "Error");
                txtDireccion.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El Email no puede estar vacío", "Error");
                txtEmail.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtnrodocumento.Text))
            {
                MessageBox.Show("El numero de documento no puede estar vacío", "Error");
                txtnrodocumento.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtrazonsocial.Text))
            {
                MessageBox.Show("La razon social no puede estar vacío", "Error");
                txtrazonsocial.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El numero de telefono no puede estar vacío", "Error");
                txtTelefono.Focus();
                return false;
            }




            if (cboSector.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un Sector", "Error");
                cboSector.Focus();
                return false;
            }



            if (cboTipoDocumento.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un Tipo de Documento", "Error");
                cboTipoDocumento.Focus();
                return false;
            }
            return true;
        }

        private Proveedor obtenerProveedorFormulario()
        {
            Proveedor pro = new Proveedor();

            pro.Direccion = txtDireccion.Text;
            pro.Email = txtEmail.Text;
            pro.RazonSocial = txtrazonsocial.Text;
            pro.Telefono = txtTelefono.Text;
            pro.NroDocumento = txtTelefono.Text; 
            
        
            pro.sectorcomercial = (Proveedor._sector)cboSector.SelectedItem;
            pro.tipodocumento = (Proveedor._tipodocumento)cboTipoDocumento.SelectedItem;

            return pro;
        }

        private void bloquearFormulario()
        {

            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
           
            txtnrodocumento.Enabled = false;
            txtrazonsocial.Enabled = false;
            txtTelefono.Enabled = false;
            cboSector.Enabled = false;
            cboTipoDocumento.Enabled = false;

           

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }






        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizarListadoProveedor();
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

        private void lstProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            completarObjetos();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {

            try
            {
                actualizarListadoProveedor();
                cboSector.DataSource = Enum.GetValues(typeof(Proveedor._sector));
                cboTipoDocumento.DataSource = Enum.GetValues(typeof(Proveedor._tipodocumento));
                cboTipoDocumento.SelectedItem = null;
                cboSector.SelectedItem = null;
                bloquearFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
