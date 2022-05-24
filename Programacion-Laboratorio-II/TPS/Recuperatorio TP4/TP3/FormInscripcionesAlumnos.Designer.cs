
namespace TP4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscripcionesAlumnos));
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
            this.lbCursosInscribir.BackColor = System.Drawing.Color.Moccasin;
            this.lbCursosInscribir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCursosInscribir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbCursosInscribir.Location = new System.Drawing.Point(12, 242);
            this.lbCursosInscribir.Name = "lbCursosInscribir";
            this.lbCursosInscribir.Size = new System.Drawing.Size(235, 14);
            this.lbCursosInscribir.TabIndex = 7;
            this.lbCursosInscribir.Text = "Cursos (Seleccionar cursos a inscribir)";
            // 
            // btnInscribirAlumno
            // 
            this.btnInscribirAlumno.BackColor = System.Drawing.Color.Moccasin;
            this.btnInscribirAlumno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInscribirAlumno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInscribirAlumno.Location = new System.Drawing.Point(12, 150);
            this.btnInscribirAlumno.Name = "btnInscribirAlumno";
            this.btnInscribirAlumno.Size = new System.Drawing.Size(205, 80);
            this.btnInscribirAlumno.TabIndex = 12;
            this.btnInscribirAlumno.Text = "Inscribir en curso";
            this.btnInscribirAlumno.UseVisualStyleBackColor = false;
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
            this.dgvListadoCursos.Location = new System.Drawing.Point(12, 269);
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
            this.lbListadoAlumnos.BackColor = System.Drawing.Color.Moccasin;
            this.lbListadoAlumnos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbListadoAlumnos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbListadoAlumnos.Location = new System.Drawing.Point(12, 9);
            this.lbListadoAlumnos.Name = "lbListadoAlumnos";
            this.lbListadoAlumnos.Size = new System.Drawing.Size(109, 14);
            this.lbListadoAlumnos.TabIndex = 22;
            this.lbListadoAlumnos.Text = "Listado Alumnos";
            // 
            // btnBajaAlumnoCurso
            // 
            this.btnBajaAlumnoCurso.BackColor = System.Drawing.Color.Moccasin;
            this.btnBajaAlumnoCurso.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBajaAlumnoCurso.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBajaAlumnoCurso.Location = new System.Drawing.Point(223, 150);
            this.btnBajaAlumnoCurso.Name = "btnBajaAlumnoCurso";
            this.btnBajaAlumnoCurso.Size = new System.Drawing.Size(229, 80);
            this.btnBajaAlumnoCurso.TabIndex = 23;
            this.btnBajaAlumnoCurso.Text = "Dar de baja del curso";
            this.btnBajaAlumnoCurso.UseVisualStyleBackColor = false;
            this.btnBajaAlumnoCurso.Click += new System.EventHandler(this.btnBajaAlumnoCurso_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtResultado.Location = new System.Drawing.Point(458, 27);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(192, 203);
            this.txtResultado.TabIndex = 24;
            // 
            // FormInscripcionesAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(664, 407);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnBajaAlumnoCurso);
            this.Controls.Add(this.lbListadoAlumnos);
            this.Controls.Add(this.dgvListadoAlumnos);
            this.Controls.Add(this.dgvListadoCursos);
            this.Controls.Add(this.btnInscribirAlumno);
            this.Controls.Add(this.lbCursosInscribir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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