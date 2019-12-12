namespace TarsiusWhite
{
    partial class frmProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblSector = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lstProveedor = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.txtnrodocumento = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Location = new System.Drawing.Point(523, 69);
            this.txtrazonsocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(216, 22);
            this.txtrazonsocial.TabIndex = 110;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(424, 72);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(91, 17);
            this.lblRazonSocial.TabIndex = 111;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(16, 117);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(112, 17);
            this.lblTipoDocumento.TabIndex = 114;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(447, 239);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 131;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(15, 77);
            this.lblSector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(115, 17);
            this.lblSector.TabIndex = 115;
            this.lblSector.Text = "Sector Comercial";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(328, 239);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 130;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(152, 67);
            this.cboSector.Margin = new System.Windows.Forms.Padding(4);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(216, 24);
            this.cboSector.TabIndex = 116;
            this.cboSector.SelectedIndexChanged += new System.EventHandler(this.cboSector_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(192, 239);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 129;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(152, 113);
            this.cboTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(216, 24);
            this.cboTipoDocumento.TabIndex = 117;
            // 
            // lstProveedor
            // 
            this.lstProveedor.FormattingEnabled = true;
            this.lstProveedor.ItemHeight = 16;
            this.lstProveedor.Location = new System.Drawing.Point(3, 275);
            this.lstProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.lstProveedor.Name = "lstProveedor";
            this.lstProveedor.Size = new System.Drawing.Size(756, 180);
            this.lstProveedor.TabIndex = 128;
            this.lstProveedor.SelectedIndexChanged += new System.EventHandler(this.lstProveedor_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(447, 463);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 127;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(152, 156);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(216, 22);
            this.txtDireccion.TabIndex = 119;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(328, 463);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 126;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(61, 161);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 120;
            this.lblDireccion.Text = "Dirección";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(198, 463);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 125;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(64, 200);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 121;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(523, 161);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 124;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(152, 200);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(216, 22);
            this.txtTelefono.TabIndex = 122;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(473, 164);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 123;
            this.lblEmail.Text = "Email";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(408, 113);
            this.lblNroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(107, 17);
            this.lblNroDocumento.TabIndex = 132;
            this.lblNroDocumento.Text = "Nro Documento";
            // 
            // txtnrodocumento
            // 
            this.txtnrodocumento.Location = new System.Drawing.Point(523, 113);
            this.txtnrodocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtnrodocumento.Name = "txtnrodocumento";
            this.txtnrodocumento.Size = new System.Drawing.Size(216, 22);
            this.txtnrodocumento.TabIndex = 133;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(13, 9);
            this.lblPresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(191, 42);
            this.lblPresentacion.TabIndex = 134;
            this.lblPresentacion.Text = "Proveedor";
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 504);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.txtnrodocumento);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.txtrazonsocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cboSector);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.lstProveedor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Proveedor:::...";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.ListBox lstProveedor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.TextBox txtnrodocumento;
        private System.Windows.Forms.Label lblPresentacion;
    }
}