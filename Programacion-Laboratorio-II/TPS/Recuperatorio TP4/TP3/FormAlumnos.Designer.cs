
namespace TP4
{
    partial class FormAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnos));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lbDni = new System.Windows.Forms.Label();
            this.rchbResultado = new System.Windows.Forms.RichTextBox();
            this.lbAlumnoSeleccionado = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.cmbSeleccionarAlumno = new System.Windows.Forms.ComboBox();
            this.lbSeleccionarAlumno = new System.Windows.Forms.Label();
            this.btnCancelarCambios = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lbEdad = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lbGenero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Moccasin;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAgregar.Location = new System.Drawing.Point(11, 302);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 51);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Moccasin;
            this.btnQuitar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnQuitar.Location = new System.Drawing.Point(143, 302);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(108, 51);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Moccasin;
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModificar.Location = new System.Drawing.Point(276, 302);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 51);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtApellido.Location = new System.Drawing.Point(15, 110);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(373, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNombre.Location = new System.Drawing.Point(14, 157);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(375, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = " ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNombre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbNombre.Location = new System.Drawing.Point(15, 136);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbApellido.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbApellido.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbApellido.Location = new System.Drawing.Point(15, 80);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(58, 16);
            this.lbApellido.TabIndex = 8;
            this.lbApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDni.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDni.Location = new System.Drawing.Point(13, 210);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(377, 22);
            this.txtDni.TabIndex = 18;
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDni.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbDni.Location = new System.Drawing.Point(13, 192);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(31, 16);
            this.lbDni.TabIndex = 19;
            this.lbDni.Text = "DNI";
            // 
            // rchbResultado
            // 
            this.rchbResultado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rchbResultado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rchbResultado.Location = new System.Drawing.Point(13, 442);
            this.rchbResultado.Name = "rchbResultado";
            this.rchbResultado.ReadOnly = true;
            this.rchbResultado.Size = new System.Drawing.Size(371, 199);
            this.rchbResultado.TabIndex = 21;
            this.rchbResultado.Text = "";
            // 
            // lbAlumnoSeleccionado
            // 
            this.lbAlumnoSeleccionado.AutoSize = true;
            this.lbAlumnoSeleccionado.Location = new System.Drawing.Point(404, 489);
            this.lbAlumnoSeleccionado.Name = "lbAlumnoSeleccionado";
            this.lbAlumnoSeleccionado.Size = new System.Drawing.Size(0, 15);
            this.lbAlumnoSeleccionado.TabIndex = 23;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Moccasin;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnGuardarCambios.Location = new System.Drawing.Point(283, 15);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(109, 49);
            this.btnGuardarCambios.TabIndex = 25;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // cmbSeleccionarAlumno
            // 
            this.cmbSeleccionarAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccionarAlumno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbSeleccionarAlumno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbSeleccionarAlumno.FormattingEnabled = true;
            this.cmbSeleccionarAlumno.Location = new System.Drawing.Point(13, 394);
            this.cmbSeleccionarAlumno.Name = "cmbSeleccionarAlumno";
            this.cmbSeleccionarAlumno.Size = new System.Drawing.Size(371, 22);
            this.cmbSeleccionarAlumno.TabIndex = 26;
            // 
            // lbSeleccionarAlumno
            // 
            this.lbSeleccionarAlumno.AutoSize = true;
            this.lbSeleccionarAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSeleccionarAlumno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSeleccionarAlumno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbSeleccionarAlumno.Location = new System.Drawing.Point(13, 376);
            this.lbSeleccionarAlumno.Name = "lbSeleccionarAlumno";
            this.lbSeleccionarAlumno.Size = new System.Drawing.Size(128, 16);
            this.lbSeleccionarAlumno.TabIndex = 27;
            this.lbSeleccionarAlumno.Text = "Seleccionar Alumno";
            // 
            // btnCancelarCambios
            // 
            this.btnCancelarCambios.BackColor = System.Drawing.Color.Moccasin;
            this.btnCancelarCambios.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCambios.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCancelarCambios.Location = new System.Drawing.Point(147, 15);
            this.btnCancelarCambios.Name = "btnCancelarCambios";
            this.btnCancelarCambios.Size = new System.Drawing.Size(108, 47);
            this.btnCancelarCambios.TabIndex = 28;
            this.btnCancelarCambios.Text = "Cancelar Cambios";
            this.btnCancelarCambios.UseVisualStyleBackColor = false;
            this.btnCancelarCambios.Visible = false;
            this.btnCancelarCambios.Click += new System.EventHandler(this.btnCancelarCambios_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.BackColor = System.Drawing.Color.Moccasin;
            this.btnInscripcion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInscripcion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInscripcion.Location = new System.Drawing.Point(15, 15);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(109, 49);
            this.btnInscripcion.TabIndex = 29;
            this.btnInscripcion.Text = "Inscripcion a Cursos";
            this.btnInscripcion.UseVisualStyleBackColor = false;
            this.btnInscripcion.Visible = false;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // nudEdad
            // 
            this.nudEdad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudEdad.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nudEdad.Location = new System.Drawing.Point(66, 260);
            this.nudEdad.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(53, 22);
            this.nudEdad.TabIndex = 30;
            this.nudEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEdad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEdad.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbEdad.Location = new System.Drawing.Point(13, 260);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(39, 16);
            this.lbEdad.TabIndex = 31;
            this.lbEdad.Text = "Edad";
            // 
            // cmbGenero
            // 
            this.cmbGenero.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbGenero.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(254, 257);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(135, 22);
            this.cmbGenero.TabIndex = 32;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGenero.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGenero.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbGenero.Location = new System.Drawing.Point(203, 260);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(52, 16);
            this.lbGenero.TabIndex = 33;
            this.lbGenero.Text = "Genero";
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(401, 653);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.btnInscripcion);
            this.Controls.Add(this.btnCancelarCambios);
            this.Controls.Add(this.lbSeleccionarAlumno);
            this.Controls.Add(this.cmbSeleccionarAlumno);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lbAlumnoSeleccionado);
            this.Controls.Add(this.rchbResultado);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlumnos";
            this.Text = "Gestion Alumnos";
            this.Load += new System.EventHandler(this.FormAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.RichTextBox rchbResultado;
        private System.Windows.Forms.Label lbAlumnoSeleccionado;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.ComboBox cmbSeleccionarAlumno;
        private System.Windows.Forms.Label lbSeleccionarAlumno;
        private System.Windows.Forms.Button btnCancelarCambios;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lbGenero;
    }
}