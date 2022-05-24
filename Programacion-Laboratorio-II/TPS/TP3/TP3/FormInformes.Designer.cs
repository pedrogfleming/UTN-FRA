
namespace TP3
{
    partial class FormInformes
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvInformes = new System.Windows.Forms.DataGridView();
            this.chbNombre = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTipoInforme = new System.Windows.Forms.Label();
            this.dgvCursosTomados = new System.Windows.Forms.DataGridView();
            this.lbCursosInscripto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudTotalInscriptos = new System.Windows.Forms.NumericUpDown();
            this.chbTotalInscriptos = new System.Windows.Forms.CheckBox();
            this.cmbFiltroElearning = new System.Windows.Forms.ComboBox();
            this.lbFiltrarPorElearning = new System.Windows.Forms.Label();
            this.btnExportarCursos = new System.Windows.Forms.Button();
            this.btnExportarAlumnos = new System.Windows.Forms.Button();
            this.btnInformeAlumnoMasCursos = new System.Windows.Forms.Button();
            this.btnInformeAlumnoConMenosCursos = new System.Windows.Forms.Button();
            this.btnInformeAlumnoMasViejo = new System.Windows.Forms.Button();
            this.btnInformeMasJoven = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosTomados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalInscriptos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(13, 237);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(96, 58);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Visible = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvInformes
            // 
            this.dgvInformes.AllowUserToAddRows = false;
            this.dgvInformes.AllowUserToDeleteRows = false;
            this.dgvInformes.AllowUserToResizeColumns = false;
            this.dgvInformes.AllowUserToResizeRows = false;
            this.dgvInformes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInformes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInformes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformes.Location = new System.Drawing.Point(13, 312);
            this.dgvInformes.MultiSelect = false;
            this.dgvInformes.Name = "dgvInformes";
            this.dgvInformes.ReadOnly = true;
            this.dgvInformes.RowTemplate.Height = 25;
            this.dgvInformes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInformes.Size = new System.Drawing.Size(684, 168);
            this.dgvInformes.TabIndex = 3;
            this.dgvInformes.Visible = false;
            this.dgvInformes.SelectionChanged += new System.EventHandler(this.dgvInformes_SelectionChanged);
            this.dgvInformes.Click += new System.EventHandler(this.dgvInformes_Click);
            // 
            // chbNombre
            // 
            this.chbNombre.AutoSize = true;
            this.chbNombre.Location = new System.Drawing.Point(150, 104);
            this.chbNombre.Name = "chbNombre";
            this.chbNombre.Size = new System.Drawing.Size(70, 19);
            this.chbNombre.TabIndex = 8;
            this.chbNombre.Text = "Nombre";
            this.chbNombre.UseVisualStyleBackColor = true;
            this.chbNombre.Visible = false;
            this.chbNombre.CheckedChanged += new System.EventHandler(this.chbNombre_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.cursosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // lbTipoInforme
            // 
            this.lbTipoInforme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTipoInforme.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTipoInforme.Location = new System.Drawing.Point(454, 37);
            this.lbTipoInforme.Name = "lbTipoInforme";
            this.lbTipoInforme.Size = new System.Drawing.Size(258, 176);
            this.lbTipoInforme.TabIndex = 20;
            this.lbTipoInforme.Text = "SELECCIONE TIPO DE INFORME";
            this.lbTipoInforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCursosTomados
            // 
            this.dgvCursosTomados.AllowUserToAddRows = false;
            this.dgvCursosTomados.AllowUserToDeleteRows = false;
            this.dgvCursosTomados.AllowUserToResizeColumns = false;
            this.dgvCursosTomados.AllowUserToResizeRows = false;
            this.dgvCursosTomados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursosTomados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCursosTomados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCursosTomados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosTomados.Enabled = false;
            this.dgvCursosTomados.Location = new System.Drawing.Point(102, 524);
            this.dgvCursosTomados.MultiSelect = false;
            this.dgvCursosTomados.Name = "dgvCursosTomados";
            this.dgvCursosTomados.ReadOnly = true;
            this.dgvCursosTomados.RowTemplate.Height = 25;
            this.dgvCursosTomados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursosTomados.Size = new System.Drawing.Size(505, 168);
            this.dgvCursosTomados.TabIndex = 21;
            this.dgvCursosTomados.Visible = false;
            // 
            // lbCursosInscripto
            // 
            this.lbCursosInscripto.AutoSize = true;
            this.lbCursosInscripto.Enabled = false;
            this.lbCursosInscripto.Location = new System.Drawing.Point(222, 494);
            this.lbCursosInscripto.Name = "lbCursosInscripto";
            this.lbCursosInscripto.Size = new System.Drawing.Size(229, 15);
            this.lbCursosInscripto.TabIndex = 22;
            this.lbCursosInscripto.Text = "Cursos en los que esta inscripto el alumno";
            this.lbCursosInscripto.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(13, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 23);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.Visible = false;
            // 
            // nudTotalInscriptos
            // 
            this.nudTotalInscriptos.Enabled = false;
            this.nudTotalInscriptos.Location = new System.Drawing.Point(13, 49);
            this.nudTotalInscriptos.Name = "nudTotalInscriptos";
            this.nudTotalInscriptos.Size = new System.Drawing.Size(47, 23);
            this.nudTotalInscriptos.TabIndex = 28;
            this.nudTotalInscriptos.Visible = false;
            // 
            // chbTotalInscriptos
            // 
            this.chbTotalInscriptos.AutoSize = true;
            this.chbTotalInscriptos.Location = new System.Drawing.Point(66, 49);
            this.chbTotalInscriptos.Name = "chbTotalInscriptos";
            this.chbTotalInscriptos.Size = new System.Drawing.Size(121, 19);
            this.chbTotalInscriptos.TabIndex = 29;
            this.chbTotalInscriptos.Text = "Total de inscriptos";
            this.chbTotalInscriptos.UseVisualStyleBackColor = true;
            this.chbTotalInscriptos.Visible = false;
            this.chbTotalInscriptos.CheckedChanged += new System.EventHandler(this.chbTotalInscriptos_CheckedChanged);
            // 
            // cmbFiltroElearning
            // 
            this.cmbFiltroElearning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroElearning.FormattingEnabled = true;
            this.cmbFiltroElearning.Items.AddRange(new object[] {
            "Omitir Filtro",
            "Es E-Learning",
            "No es E-Learning"});
            this.cmbFiltroElearning.Location = new System.Drawing.Point(12, 155);
            this.cmbFiltroElearning.Name = "cmbFiltroElearning";
            this.cmbFiltroElearning.Size = new System.Drawing.Size(131, 23);
            this.cmbFiltroElearning.TabIndex = 32;
            this.cmbFiltroElearning.Visible = false;
            // 
            // lbFiltrarPorElearning
            // 
            this.lbFiltrarPorElearning.AutoSize = true;
            this.lbFiltrarPorElearning.Location = new System.Drawing.Point(150, 158);
            this.lbFiltrarPorElearning.Name = "lbFiltrarPorElearning";
            this.lbFiltrarPorElearning.Size = new System.Drawing.Size(118, 15);
            this.lbFiltrarPorElearning.TabIndex = 33;
            this.lbFiltrarPorElearning.Text = "Filtrar por E-Learning";
            this.lbFiltrarPorElearning.Visible = false;
            // 
            // btnExportarCursos
            // 
            this.btnExportarCursos.Location = new System.Drawing.Point(628, 634);
            this.btnExportarCursos.Name = "btnExportarCursos";
            this.btnExportarCursos.Size = new System.Drawing.Size(101, 58);
            this.btnExportarCursos.TabIndex = 34;
            this.btnExportarCursos.Text = "Exportar Cursos";
            this.btnExportarCursos.UseVisualStyleBackColor = true;
            this.btnExportarCursos.Visible = false;
            this.btnExportarCursos.Click += new System.EventHandler(this.btnExportarCursos_Click);
            // 
            // btnExportarAlumnos
            // 
            this.btnExportarAlumnos.Location = new System.Drawing.Point(628, 524);
            this.btnExportarAlumnos.Name = "btnExportarAlumnos";
            this.btnExportarAlumnos.Size = new System.Drawing.Size(101, 58);
            this.btnExportarAlumnos.TabIndex = 35;
            this.btnExportarAlumnos.Text = "Exportar Alumnos";
            this.btnExportarAlumnos.UseVisualStyleBackColor = true;
            this.btnExportarAlumnos.Visible = false;
            this.btnExportarAlumnos.Click += new System.EventHandler(this.btnExportarAlumnos_Click);
            // 
            // btnInformeAlumnoMasCursos
            // 
            this.btnInformeAlumnoMasCursos.Location = new System.Drawing.Point(238, 29);
            this.btnInformeAlumnoMasCursos.Name = "btnInformeAlumnoMasCursos";
            this.btnInformeAlumnoMasCursos.Size = new System.Drawing.Size(189, 58);
            this.btnInformeAlumnoMasCursos.TabIndex = 37;
            this.btnInformeAlumnoMasCursos.Text = "Alumno con más cursos";
            this.btnInformeAlumnoMasCursos.UseVisualStyleBackColor = true;
            this.btnInformeAlumnoMasCursos.Visible = false;
            this.btnInformeAlumnoMasCursos.Click += new System.EventHandler(this.btnInformeAlumnoMasCursos_Click);
            // 
            // btnInformeAlumnoConMenosCursos
            // 
            this.btnInformeAlumnoConMenosCursos.Location = new System.Drawing.Point(238, 129);
            this.btnInformeAlumnoConMenosCursos.Name = "btnInformeAlumnoConMenosCursos";
            this.btnInformeAlumnoConMenosCursos.Size = new System.Drawing.Size(189, 58);
            this.btnInformeAlumnoConMenosCursos.TabIndex = 38;
            this.btnInformeAlumnoConMenosCursos.Text = "Alumno con menos cursos";
            this.btnInformeAlumnoConMenosCursos.UseVisualStyleBackColor = true;
            this.btnInformeAlumnoConMenosCursos.Visible = false;
            this.btnInformeAlumnoConMenosCursos.Click += new System.EventHandler(this.btnAlumnoConMenosCursos_Click);
            // 
            // btnInformeAlumnoMasViejo
            // 
            this.btnInformeAlumnoMasViejo.Location = new System.Drawing.Point(13, 29);
            this.btnInformeAlumnoMasViejo.Name = "btnInformeAlumnoMasViejo";
            this.btnInformeAlumnoMasViejo.Size = new System.Drawing.Size(189, 58);
            this.btnInformeAlumnoMasViejo.TabIndex = 39;
            this.btnInformeAlumnoMasViejo.Text = "Alumno más viejo";
            this.btnInformeAlumnoMasViejo.UseVisualStyleBackColor = true;
            this.btnInformeAlumnoMasViejo.Visible = false;
            this.btnInformeAlumnoMasViejo.Click += new System.EventHandler(this.btnAlumnoMasViejo_Click);
            // 
            // btnInformeMasJoven
            // 
            this.btnInformeMasJoven.Location = new System.Drawing.Point(13, 129);
            this.btnInformeMasJoven.Name = "btnInformeMasJoven";
            this.btnInformeMasJoven.Size = new System.Drawing.Size(189, 58);
            this.btnInformeMasJoven.TabIndex = 40;
            this.btnInformeMasJoven.Text = "Alumno más joven";
            this.btnInformeMasJoven.UseVisualStyleBackColor = true;
            this.btnInformeMasJoven.Visible = false;
            this.btnInformeMasJoven.Click += new System.EventHandler(this.btnInformeMasJoven_Click);
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 710);
            this.Controls.Add(this.btnInformeMasJoven);
            this.Controls.Add(this.btnInformeAlumnoMasViejo);
            this.Controls.Add(this.btnInformeAlumnoConMenosCursos);
            this.Controls.Add(this.btnInformeAlumnoMasCursos);
            this.Controls.Add(this.btnExportarAlumnos);
            this.Controls.Add(this.btnExportarCursos);
            this.Controls.Add(this.lbFiltrarPorElearning);
            this.Controls.Add(this.cmbFiltroElearning);
            this.Controls.Add(this.chbTotalInscriptos);
            this.Controls.Add(this.nudTotalInscriptos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbCursosInscripto);
            this.Controls.Add(this.dgvCursosTomados);
            this.Controls.Add(this.lbTipoInforme);
            this.Controls.Add(this.chbNombre);
            this.Controls.Add(this.dgvInformes);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormInformes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosTomados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalInscriptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvInformes;
        private System.Windows.Forms.CheckBox chbNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.Label lbTipoInforme;
        private System.Windows.Forms.DataGridView dgvCursosTomados;
        private System.Windows.Forms.Label lbCursosInscripto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudTotalInscriptos;
        private System.Windows.Forms.CheckBox chbTotalInscriptos;
        private System.Windows.Forms.ComboBox cmbFiltroElearning;
        private System.Windows.Forms.Label lbFiltrarPorElearning;
        private System.Windows.Forms.Button btnExportarCursos;
        private System.Windows.Forms.Button btnExportarAlumnos;
        private System.Windows.Forms.Button btnInformeAlumnoMasCursos;
        private System.Windows.Forms.Button btnInformeAlumnoConMenosCursos;
        private System.Windows.Forms.Button btnInformeAlumnoMasViejo;
        private System.Windows.Forms.Button btnInformeMasJoven;
    }
}