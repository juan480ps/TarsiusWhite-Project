namespace TarsiusWhite
{
    partial class frmEmpleado
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstEmpleado = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpbEmpleado = new System.Windows.Forms.GroupBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.gpbEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(300, 227);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 107;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(219, 227);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 106;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 227);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 105;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstEmpleado
            // 
            this.lstEmpleado.FormattingEnabled = true;
            this.lstEmpleado.Location = new System.Drawing.Point(6, 256);
            this.lstEmpleado.Name = "lstEmpleado";
            this.lstEmpleado.Size = new System.Drawing.Size(535, 108);
            this.lstEmpleado.TabIndex = 104;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(300, 370);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 103;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(219, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(137, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 101;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(294, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 20);
            this.txtEmail.TabIndex = 100;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(256, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 99;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(81, 184);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(163, 20);
            this.txtTelefono.TabIndex = 98;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(11, 192);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 97;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(11, 152);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 96;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(81, 149);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(252, 20);
            this.txtDireccion.TabIndex = 95;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(300, 69);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(123, 20);
            this.dtpFechaNacimiento.TabIndex = 94;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(11, 80);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 91;
            this.lblSexo.Text = "Sexo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(197, 73);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNacimiento.TabIndex = 89;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(179, 114);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(163, 20);
            this.txtNroDocumento.TabIndex = 88;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(248, 38);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 87;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(298, 35);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 20);
            this.txtApellido.TabIndex = 86;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 85;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 84;
            // 
            // gpbEmpleado
            // 
            this.gpbEmpleado.Controls.Add(this.cboTipoDocumento);
            this.gpbEmpleado.Controls.Add(this.cboSexo);
            this.gpbEmpleado.Controls.Add(this.lblNroDoc);
            this.gpbEmpleado.Controls.Add(this.txtNombre);
            this.gpbEmpleado.Controls.Add(this.lblNombre);
            this.gpbEmpleado.Controls.Add(this.txtApellido);
            this.gpbEmpleado.Controls.Add(this.lblApellido);
            this.gpbEmpleado.Controls.Add(this.txtNroDocumento);
            this.gpbEmpleado.Controls.Add(this.lblFechaNacimiento);
            this.gpbEmpleado.Controls.Add(this.btnEliminar);
            this.gpbEmpleado.Controls.Add(this.lblSexo);
            this.gpbEmpleado.Controls.Add(this.btnEditar);
            this.gpbEmpleado.Controls.Add(this.btnAgregar);
            this.gpbEmpleado.Controls.Add(this.lstEmpleado);
            this.gpbEmpleado.Controls.Add(this.dtpFechaNacimiento);
            this.gpbEmpleado.Controls.Add(this.btnLimpiar);
            this.gpbEmpleado.Controls.Add(this.txtDireccion);
            this.gpbEmpleado.Controls.Add(this.btnCancelar);
            this.gpbEmpleado.Controls.Add(this.lblDireccion);
            this.gpbEmpleado.Controls.Add(this.btnGuardar);
            this.gpbEmpleado.Controls.Add(this.lblTelefono);
            this.gpbEmpleado.Controls.Add(this.txtEmail);
            this.gpbEmpleado.Controls.Add(this.txtTelefono);
            this.gpbEmpleado.Controls.Add(this.lblEmail);
            this.gpbEmpleado.Location = new System.Drawing.Point(12, 56);
            this.gpbEmpleado.Name = "gpbEmpleado";
            this.gpbEmpleado.Size = new System.Drawing.Size(553, 404);
            this.gpbEmpleado.TabIndex = 114;
            this.gpbEmpleado.TabStop = false;
            this.gpbEmpleado.Text = "Empleado";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(103, 114);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(61, 21);
            this.cboTipoDocumento.TabIndex = 117;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(62, 77);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(102, 21);
            this.cboSexo.TabIndex = 116;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(11, 118);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(85, 13);
            this.lblNroDoc.TabIndex = 115;
            this.lblNroDoc.Text = "Nro. Documento";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 472);
            this.Controls.Add(this.gpbEmpleado);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.gpbEmpleado.ResumeLayout(false);
            this.gpbEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstEmpleado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpbEmpleado;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
    }
}