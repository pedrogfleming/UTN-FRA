
namespace TP4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformes));
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
            this.btnInformesGenerales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosTomados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalInscriptos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Moccasin;
            this.btnMostrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnMostrar.Location = new System.Drawing.Point(13, 237);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(699, 58);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
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
            this.dgvInformes.Size = new System.Drawing.Size(699, 168);
            this.dgvInformes.TabIndex = 3;
            this.dgvInformes.Visible = false;
            this.dgvInformes.SelectionChanged += new System.EventHandler(this.dgvInformes_SelectionChanged);
            this.dgvInformes.Click += new System.EventHandler(this.dgvInformes_Click);
            // 
            // chbNombre
            // 
            this.chbNombre.AutoSize = true;
            this.chbNombre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbNombre.Location = new System.Drawing.Point(150, 104);
            this.chbNombre.Name = "chbNombre";
            this.chbNombre.Size = new System.Drawing.Size(73, 18);
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
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.lbTipoInforme.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTipoInforme.ForeColor = System.Drawing.SystemColors.InfoText;
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
            this.dgvCursosTomados.Location = new System.Drawing.Point(13, 542);
            this.dgvCursosTomados.MultiSelect = false;
            this.dgvCursosTomados.Name = "dgvCursosTomados";
            this.dgvCursosTomados.ReadOnly = true;
            this.dgvCursosTomados.RowTemplate.Height = 25;
            this.dgvCursosTomados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursosTomados.Size = new System.Drawing.Size(699, 168);
            this.dgvCursosTomados.TabIndex = 21;
            this.dgvCursosTomados.Visible = false;
            // 
            // lbCursosInscripto
            // 
            this.lbCursosInscripto.AutoSize = true;
            this.lbCursosInscripto.Enabled = false;
            this.lbCursosInscripto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCursosInscripto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbCursosInscripto.Location = new System.Drawing.Point(220, 726);
            this.lbCursosInscripto.Name = "lbCursosInscripto";
            this.lbCursosInscripto.Size = new System.Drawing.Size(265, 14);
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
            this.chbTotalInscriptos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbTotalInscriptos.Location = new System.Drawing.Point(66, 49);
            this.chbTotalInscriptos.Name = "chbTotalInscriptos";
            this.chbTotalInscriptos.Size = new System.Drawing.Size(139, 18);
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
            this.lbFiltrarPorElearning.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFiltrarPorElearning.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbFiltrarPorElearning.Location = new System.Drawing.Point(150, 158);
            this.lbFiltrarPorElearning.Name = "lbFiltrarPorElearning";
            this.lbFiltrarPorElearning.Size = new System.Drawing.Size(136, 14);
            this.lbFiltrarPorElearning.TabIndex = 33;
            this.lbFiltrarPorElearning.Text = "Filtrar por E-Learning";
            this.lbFiltrarPorElearning.Visible = false;
            // 
            // btnExportarCursos
            // 
            this.btnExportarCursos.BackColor = System.Drawing.Color.Moccasin;
            this.btnExportarCursos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportarCursos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnExportarCursos.Location = new System.Drawing.Point(13, 488);
            this.btnExportarCursos.Name = "btnExportarCursos";
            this.btnExportarCursos.Size = new System.Drawing.Size(336, 48);
            this.btnExportarCursos.TabIndex = 34;
            this.btnExportarCursos.Text = "Exportar Cursos";
            this.btnExportarCursos.UseVisualStyleBackColor = false;
            this.btnExportarCursos.Visible = false;
            this.btnExportarCursos.Click += new System.EventHandler(this.btnExportarCursos_Click);
            // 
            // btnExportarAlumnos
            // 
            this.btnExportarAlumnos.BackColor = System.Drawing.Color.Moccasin;
            this.btnExportarAlumnos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportarAlumnos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnExportarAlumnos.Location = new System.Drawing.Point(13, 488);
            this.btnExportarAlumnos.Name = "btnExportarAlumnos";
            this.btnExportarAlumnos.Size = new System.Drawing.Size(336, 46);
            this.btnExportarAlumnos.TabIndex = 35;
            this.btnExportarAlumnos.Text = "Exportar Alumnos";
            this.btnExportarAlumnos.UseVisualStyleBackColor = false;
            this.btnExportarAlumnos.Visible = false;
            this.btnExportarAlumnos.Click += new System.EventHandler(this.btnExportarAlumnos_Click);
            // 
            // btnInformeAlumnoMasCursos
            // 
            this.btnInformeAlumnoMasCursos.BackColor = System.Drawing.Color.Moccasin;
            this.btnInformeAlumnoMasCursos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformeAlumnoMasCursos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInformeAlumnoMasCursos.Location = new System.Drawing.Point(234, 46);
            this.btnInformeAlumnoMasCursos.Name = "btnInformeAlumnoMasCursos";
            this.btnInformeAlumnoMasCursos.Size = new System.Drawing.Size(189, 58);
            this.btnInformeAlumnoMasCursos.TabIndex = 37;
            this.btnInformeAlumnoMasCursos.Text = "Alumno con más cursos";
            this.btnInformeAlumnoMasCursos.UseVisualStyleBackColor = false;
            this.btnInformeAlumnoMasCursos.Visible = false;
            this.btnInformeAlumnoMasCursos.Click += new System.EventHandler(this.btnInformeAlumnoMasCursos_Click);
            // 
            // btnInformeAlumnoConMenosCursos
            // 
            this.btnInformeAlumnoConMenosCursos.BackColor = System.Drawing.Color.Moccasin;
            this.btnInformeAlumnoConMenosCursos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformeAlumnoConMenosCursos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInformeAlumnoConMenosCursos.Location = new System.Drawing.Point(234, 155);
            this.btnInformeAlumnoConMenosCursos.Name = "btnInformeAlumnoConMenosCursos";
            this.btnInformeAlumnoConMenosCursos.Size = new System.Drawing.Size(189, 58);
            this.btnInformeAlumnoConMenosCursos.TabIndex = 38;
            this.btnInformeAlumnoConMenosCursos.Text = "Alumno con menos cursos";
            this.btnInformeAlumnoConMenosCursos.UseVisualStyleBackColor = false;
            this.btnInformeAlumnoConMenosCursos.Visible = false;
            this.btnInformeAlumnoConMenosCursos.Click += new System.EventHandler(this.btnAlumnoConMenosCursos_Click);
            // 
            // btnInformeAlumnoMasViejo
            // 
            this.btnInformeAlumnoMasViejo.BackColor = System.Drawing.Color.Moccasin;
            this.btnInformeAlumnoMasViejo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformeAlumnoMasViejo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInformeAlumnoMasViejo.Location = new System.Drawing.Point(8, 46);
            this.btnInformeAlumnoMasViejo.Name = "btnInformeAlumnoMasViejo";
            this.btnInformeAlumnoMasViejo.Size = new System.Drawing.Size(189, 58);
            this.btnInformeAlumnoMasViejo.TabIndex = 39;
            this.btnInformeAlumnoMasViejo.Text = "Alumno más viejo";
            this.btnInformeAlumnoMasViejo.UseVisualStyleBackColor = false;
            this.btnInformeAlumnoMasViejo.Visible = false;
            this.btnInformeAlumnoMasViejo.Click += new System.EventHandler(this.btnAlumnoMasViejo_Click);
            // 
            // btnInformeMasJoven
            // 
            this.btnInformeMasJoven.BackColor = System.Drawing.Color.Moccasin;
            this.btnInformeMasJoven.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformeMasJoven.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInformeMasJoven.Location = new System.Drawing.Point(8, 155);
            this.btnInformeMasJoven.Name = "btnInformeMasJoven";
            this.btnInformeMasJoven.Size = new System.Drawing.Size(189, 58);
            this.btnInformeMasJoven.TabIndex = 40;
            this.btnInformeMasJoven.Text = "Alumno más joven";
            this.btnInformeMasJoven.UseVisualStyleBackColor = false;
            this.btnInformeMasJoven.Visible = false;
            this.btnInformeMasJoven.Click += new System.EventHandler(this.btnInformeMasJoven_Click);
            // 
            // btnInformesGenerales
            // 
            this.btnInformesGenerales.BackColor = System.Drawing.Color.Moccasin;
            this.btnInformesGenerales.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformesGenerales.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInformesGenerales.Location = new System.Drawing.Point(355, 488);
            this.btnInformesGenerales.Name = "btnInformesGenerales";
            this.btnInformesGenerales.Size = new System.Drawing.Size(357, 48);
            this.btnInformesGenerales.TabIndex = 41;
            this.btnInformesGenerales.Text = "Exportar Informes";
            this.btnInformesGenerales.UseVisualStyleBackColor = false;
            this.btnInformesGenerales.Visible = false;
            this.btnInformesGenerales.Click += new System.EventHandler(this.btnInformesGenerales_Click);
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(731, 749);
            this.Controls.Add(this.btnInformesGenerales);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInformes";
            this.Text = "Informes Instituto";
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
        private System.Windows.Forms.Button btnInformesGenerales;
    }
}