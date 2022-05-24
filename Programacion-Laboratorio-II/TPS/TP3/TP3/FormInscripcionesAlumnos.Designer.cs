
namespace TP3
{
    partial class FormInscripcionesAlumnos
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
            this.lbCursosInscribir = new System.Windows.Forms.Label();
            this.btnInscribirAlumno = new System.Windows.Forms.Button();
            this.dgvListadoCursos = new System.Windows.Forms.DataGridView();
            this.dgvListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.lbListadoAlumnos = new System.Windows.Forms.Label();
            this.btnBajaAlumnoCurso = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCursosInscribir
            // 
            this.lbCursosInscribir.AutoSize = true;
            this.lbCursosInscribir.Location = new System.Drawing.Point(12, 233);
            this.lbCursosInscribir.Name = "lbCursosInscribir";
            this.lbCursosInscribir.Size = new System.Drawing.Size(205, 15);
            this.lbCursosInscribir.TabIndex = 7;
            this.lbCursosInscribir.Text = "Cursos (Seleccionar cursos a inscribir)";
            // 
            // btnInscribirAlumno
            // 
            this.btnInscribirAlumno.Location = new System.Drawing.Point(109, 171);
            this.btnInscribirAlumno.Name = "btnInscribirAlumno";
            this.btnInscribirAlumno.Size = new System.Drawing.Size(108, 39);
            this.btnInscribirAlumno.TabIndex = 12;
            this.btnInscribirAlumno.Text = "Inscribir en curso";
            this.btnInscribirAlumno.UseVisualStyleBackColor = true;
            this.btnInscribirAlumno.Click += new System.EventHandler(this.btnInscribirAlumno_Click);
            // 
            // dgvListadoCursos
            // 
            this.dgvListadoCursos.AllowUserToAddRows = false;
            this.dgvListadoCursos.AllowUserToDeleteRows = false;
            this.dgvListadoCursos.AllowUserToResizeColumns = false;
            this.dgvListadoCursos.AllowUserToResizeRows = false;
            this.dgvListadoCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoCursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoCursos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListadoCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCursos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvListadoCursos.Location = new System.Drawing.Point(12, 260);
            this.dgvListadoCursos.MultiSelect = false;
            this.dgvListadoCursos.Name = "dgvListadoCursos";
            this.dgvListadoCursos.ReadOnly = true;
            this.dgvListadoCursos.RowTemplate.Height = 25;
            this.dgvListadoCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoCursos.Size = new System.Drawing.Size(638, 126);
            this.dgvListadoCursos.TabIndex = 17;
            // 
            // dgvListadoAlumnos
            // 
            this.dgvListadoAlumnos.AllowUserToAddRows = false;
            this.dgvListadoAlumnos.AllowUserToDeleteRows = false;
            this.dgvListadoAlumnos.AllowUserToResizeColumns = false;
            this.dgvListadoAlumnos.AllowUserToResizeRows = false;
            this.dgvListadoAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoAlumnos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAlumnos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvListadoAlumnos.Location = new System.Drawing.Point(12, 27);
            this.dgvListadoAlumnos.MultiSelect = false;
            this.dgvListadoAlumnos.Name = "dgvListadoAlumnos";
            this.dgvListadoAlumnos.ReadOnly = true;
            this.dgvListadoAlumnos.RowTemplate.Height = 25;
            this.dgvListadoAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoAlumnos.Size = new System.Drawing.Size(440, 117);
            this.dgvListadoAlumnos.TabIndex = 21;
            // 
            // lbListadoAlumnos
            // 
            this.lbListadoAlumnos.AutoSize = true;
            this.lbListadoAlumnos.Location = new System.Drawing.Point(12, 9);
            this.lbListadoAlumnos.Name = "lbListadoAlumnos";
            this.lbListadoAlumnos.Size = new System.Drawing.Size(96, 15);
            this.lbListadoAlumnos.TabIndex = 22;
            this.lbListadoAlumnos.Text = "Listado Alumnos";
            // 
            // btnBajaAlumnoCurso
            // 
            this.btnBajaAlumnoCurso.Location = new System.Drawing.Point(305, 171);
            this.btnBajaAlumnoCurso.Name = "btnBajaAlumnoCurso";
            this.btnBajaAlumnoCurso.Size = new System.Drawing.Size(108, 39);
            this.btnBajaAlumnoCurso.TabIndex = 23;
            this.btnBajaAlumnoCurso.Text = "Dar de baja del curso";
            this.btnBajaAlumnoCurso.UseVisualStyleBackColor = true;
            this.btnBajaAlumnoCurso.Click += new System.EventHandler(this.btnBajaAlumnoCurso_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtResultado.Location = new System.Drawing.Point(458, 27);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(192, 183);
            this.txtResultado.TabIndex = 24;
            // 
            // FormInscripcionesAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 396);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnBajaAlumnoCurso);
            this.Controls.Add(this.lbListadoAlumnos);
            this.Controls.Add(this.dgvListadoAlumnos);
            this.Controls.Add(this.dgvListadoCursos);
            this.Controls.Add(this.btnInscribirAlumno);
            this.Controls.Add(this.lbCursosInscribir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInscripcionesAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion a cursos";
            this.Load += new System.EventHandler(this.InscripcionesAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCursosInscribir;
        private System.Windows.Forms.Button btnInscribirAlumno;
        private System.Windows.Forms.DataGridView dgvListadoCursos;
        private System.Windows.Forms.DataGridView dgvListadoAlumnos;
        internal System.Windows.Forms.Label lbListadoAlumnos;
        private System.Windows.Forms.Button btnBajaAlumnoCurso;
        private System.Windows.Forms.Label txtResultado;
    }
}