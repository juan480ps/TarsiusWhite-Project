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
            this.Presentacions = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // Presentacions
            // 
            this.Presentacions.AutoSize = true;
            this.Presentacions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Presentacions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Presentacions.Location = new System.Drawing.Point(16, 11);
            this.Presentacions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Presentacions.Name = "Presentacions";
            this.Presentacions.Size = new System.Drawing.Size(115, 17);
            this.Presentacions.TabIndex = 0;
            this.Presentacions.Text = "PRESENTACION";
            this.Presentacions.Click += new System.EventHandler(this.Label1_Click);
            // 
            // nombrePresentacion
            // 
            this.nombrePresentacion.AutoSize = true;
            this.nombrePresentacion.Location = new System.Drawing.Point(16, 66);
            this.nombrePresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombrePresentacion.Name = "nombrePresentacion";
            this.nombrePresentacion.Size = new System.Drawing.Size(58, 17);
            this.nombrePresentacion.TabIndex = 2;
            this.nombrePresentacion.Text = "Nombre";
            // 
            // descripcionPresentacion
            // 
            this.descripcionPresentacion.AutoSize = true;
            this.descripcionPresentacion.Location = new System.Drawing.Point(367, 66);
            this.descripcionPresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descripcionPresentacion.Name = "descripcionPresentacion";
            this.descripcionPresentacion.Size = new System.Drawing.Size(82, 17);
            this.descripcionPresentacion.TabIndex = 3;
            this.descripcionPresentacion.Text = "Descripcion";
            // 
            // txtNombrePresentacion
            // 
            this.txtNombrePresentacion.Location = new System.Drawing.Point(77, 63);
            this.txtNombrePresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePresentacion.Name = "txtNombrePresentacion";
            this.txtNombrePresentacion.Size = new System.Drawing.Size(200, 22);
            this.txtNombrePresentacion.TabIndex = 5;
            // 
            // txtDescripcionPresentacion
            // 
            this.txtDescripcionPresentacion.Location = new System.Drawing.Point(457, 64);
            this.txtDescripcionPresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionPresentacion.Name = "txtDescripcionPresentacion";
            this.txtDescripcionPresentacion.Size = new System.Drawing.Size(213, 22);
            this.txtDescripcionPresentacion.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(540, 116);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 37);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(319, 116);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 37);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(83, 116);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 37);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lstPresentaciones
            // 
            this.lstPresentaciones.FormattingEnabled = true;
            this.lstPresentaciones.ItemHeight = 16;
            this.lstPresentaciones.Location = new System.Drawing.Point(83, 160);
            this.lstPresentaciones.Margin = new System.Windows.Forms.Padding(4);
            this.lstPresentaciones.Name = "lstPresentaciones";
            this.lstPresentaciones.Size = new System.Drawing.Size(557, 244);
            this.lstPresentaciones.TabIndex = 19;
            this.lstPresentaciones.SelectedIndexChanged += new System.EventHandler(this.LstPresentaciones_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(540, 414);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 44);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 412);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 46);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(83, 412);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 44);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // frmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 485);
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
            this.Controls.Add(this.Presentacions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Presentacion:::...";
            this.Load += new System.EventHandler(this.FrmPresentacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Presentacions;
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
    }
}