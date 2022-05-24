
namespace TP3
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
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 256);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 51);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(147, 256);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(108, 51);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(280, 256);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 51);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(15, 110);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(375, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(14, 157);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(375, 23);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = " ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(15, 136);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(51, 15);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(15, 80);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(51, 15);
            this.lbApellido.TabIndex = 8;
            this.lbApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(13, 210);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(377, 23);
            this.txtDni.TabIndex = 18;
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(13, 192);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(27, 15);
            this.lbDni.TabIndex = 19;
            this.lbDni.Text = "DNI";
            // 
            // rchbResultado
            // 
            this.rchbResultado.Location = new System.Drawing.Point(17, 396);
            this.rchbResultado.Name = "rchbResultado";
            this.rchbResultado.ReadOnly = true;
            this.rchbResultado.Size = new System.Drawing.Size(373, 135);
            this.rchbResultado.TabIndex = 21;
            this.rchbResultado.Text = "";
            // 
            // lbAlumnoSeleccionado
            // 
            this.lbAlumnoSeleccionado.AutoSize = true;
            this.lbAlumnoSeleccionado.Location = new System.Drawing.Point(408, 443);
            this.lbAlumnoSeleccionado.Name = "lbAlumnoSeleccionado";
            this.lbAlumnoSeleccionado.Size = new System.Drawing.Size(0, 15);
            this.lbAlumnoSeleccionado.TabIndex = 23;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(283, 15);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(109, 49);
            this.btnGuardarCambios.TabIndex = 25;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // cmbSeleccionarAlumno
            // 
            this.cmbSeleccionarAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccionarAlumno.FormattingEnabled = true;
            this.cmbSeleccionarAlumno.Location = new System.Drawing.Point(17, 348);
            this.cmbSeleccionarAlumno.Name = "cmbSeleccionarAlumno";
            this.cmbSeleccionarAlumno.Size = new System.Drawing.Size(375, 23);
            this.cmbSeleccionarAlumno.TabIndex = 26;
            // 
            // lbSeleccionarAlumno
            // 
            this.lbSeleccionarAlumno.AutoSize = true;
            this.lbSeleccionarAlumno.Location = new System.Drawing.Point(17, 330);
            this.lbSeleccionarAlumno.Name = "lbSeleccionarAlumno";
            this.lbSeleccionarAlumno.Size = new System.Drawing.Size(113, 15);
            this.lbSeleccionarAlumno.TabIndex = 27;
            this.lbSeleccionarAlumno.Text = "Seleccionar Alumno";
            // 
            // btnCancelarCambios
            // 
            this.btnCancelarCambios.Location = new System.Drawing.Point(147, 15);
            this.btnCancelarCambios.Name = "btnCancelarCambios";
            this.btnCancelarCambios.Size = new System.Drawing.Size(108, 47);
            this.btnCancelarCambios.TabIndex = 28;
            this.btnCancelarCambios.Text = "Cancelar Cambios";
            this.btnCancelarCambios.UseVisualStyleBackColor = true;
            this.btnCancelarCambios.Visible = false;
            this.btnCancelarCambios.Click += new System.EventHandler(this.btnCancelarCambios_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.Location = new System.Drawing.Point(15, 15);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(109, 49);
            this.btnInscripcion.TabIndex = 29;
            this.btnInscripcion.Text = "Inscripcion a Cursos";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Visible = false;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 546);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.FormAlumnos_Load);
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
    }
}