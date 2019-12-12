namespace TarsiusWhite
{
    partial class frmPresentacion
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
            this.nombrePresentacion = new System.Windows.Forms.Label();
            this.descripcionPresentacion = new System.Windows.Forms.Label();
            this.txtNombrePresentacion = new System.Windows.Forms.TextBox();
            this.txtDescripcionPresentacion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstPresentaciones = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombrePresentacion
            // 
            this.nombrePresentacion.AutoSize = true;
            this.nombrePresentacion.Location = new System.Drawing.Point(23, 58);
            this.nombrePresentacion.Name = "nombrePresentacion";
            this.nombrePresentacion.Size = new System.Drawing.Size(44, 13);
            this.nombrePresentacion.TabIndex = 2;
            this.nombrePresentacion.Text = "Nombre";
            // 
            // descripcionPresentacion
            // 
            this.descripcionPresentacion.AutoSize = true;
            this.descripcionPresentacion.Location = new System.Drawing.Point(5, 90);
            this.descripcionPresentacion.Name = "descripcionPresentacion";
            this.descripcionPresentacion.Size = new System.Drawing.Size(63, 13);
            this.descripcionPresentacion.TabIndex = 3;
            this.descripcionPresentacion.Text = "Descripcion";
            // 
            // txtNombrePresentacion
            // 
            this.txtNombrePresentacion.Location = new System.Drawing.Point(69, 55);
            this.txtNombrePresentacion.Name = "txtNombrePresentacion";
            this.txtNombrePresentacion.Size = new System.Drawing.Size(161, 20);
            this.txtNombrePresentacion.TabIndex = 5;
            // 
            // txtDescripcionPresentacion
            // 
            this.txtDescripcionPresentacion.Location = new System.Drawing.Point(69, 90);
            this.txtDescripcionPresentacion.Name = "txtDescripcionPresentacion";
            this.txtDescripcionPresentacion.Size = new System.Drawing.Size(161, 20);
            this.txtDescripcionPresentacion.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(206, 126);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 19);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(121, 126);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 19);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(41, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 19);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lstPresentaciones
            // 
            this.lstPresentaciones.FormattingEnabled = true;
            this.lstPresentaciones.Location = new System.Drawing.Point(14, 151);
            this.lstPresentaciones.Name = "lstPresentaciones";
            this.lstPresentaciones.Size = new System.Drawing.Size(284, 199);
            this.lstPresentaciones.TabIndex = 19;
            this.lstPresentaciones.SelectedIndexChanged += new System.EventHandler(this.LstPresentaciones_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(206, 356);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(121, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 19);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(41, 356);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 19);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(10, 7);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(189, 36);
            this.lblPresentacion.TabIndex = 118;
            this.lblPresentacion.Text = "Presentación";
            // 
            // frmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 389);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstPresentaciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDescripcionPresentacion);
            this.Controls.Add(this.txtNombrePresentacion);
            this.Controls.Add(this.descripcionPresentacion);
            this.Controls.Add(this.nombrePresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Presentacion:::...";
            this.Load += new System.EventHandler(this.FrmPresentacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nombrePresentacion;
        private System.Windows.Forms.Label descripcionPresentacion;
        private System.Windows.Forms.TextBox txtNombrePresentacion;
        private System.Windows.Forms.TextBox txtDescripcionPresentacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstPresentaciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPresentacion;
    }
}