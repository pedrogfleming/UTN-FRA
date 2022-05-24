
namespace TP3
{
    partial class FormCursos
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.chkElearning = new System.Windows.Forms.CheckBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbListadoCursos = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.dgvListadoCursos = new System.Windows.Forms.DataGridView();
            this.lbEliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(678, 63);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(222, 23);
            this.txtDescripcion.TabIndex = 0;
            // 
            // chkElearning
            // 
            this.chkElearning.AutoSize = true;
            this.chkElearning.Location = new System.Drawing.Point(817, 41);
            this.chkElearning.Name = "chkElearning";
            this.chkElearning.Size = new System.Drawing.Size(83, 19);
            this.chkElearning.TabIndex = 1;
            this.chkElearning.Text = "E-Learning";
            this.chkElearning.UseVisualStyleBackColor = true;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(678, 120);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(222, 23);
            this.dtpFechaInicio.TabIndex = 4;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(940, 120);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(222, 23);
            this.dtpFechaFin.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(940, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(222, 37);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(817, 429);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(219, 37);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del Curso";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(678, 102);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(121, 15);
            this.lbFechaInicio.TabIndex = 9;
            this.lbFechaInicio.Text = "Fecha inicio del curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(940, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha fin del curso";
            // 
            // lbListadoCursos
            // 
            this.lbListadoCursos.AutoSize = true;
            this.lbListadoCursos.Location = new System.Drawing.Point(39, 9);
            this.lbListadoCursos.Name = "lbListadoCursos";
            this.lbListadoCursos.Size = new System.Drawing.Size(98, 15);
            this.lbListadoCursos.TabIndex = 12;
            this.lbListadoCursos.Text = "Listado de cursos";
            // 
            // lbResultado
            // 
            this.lbResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResultado.Location = new System.Drawing.Point(678, 157);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(484, 216);
            this.lbResultado.TabIndex = 16;
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
            this.dgvListadoCursos.Location = new System.Drawing.Point(12, 39);
            this.dgvListadoCursos.MultiSelect = false;
            this.dgvListadoCursos.Name = "dgvListadoCursos";
            this.dgvListadoCursos.ReadOnly = true;
            this.dgvListadoCursos.RowTemplate.Height = 25;
            this.dgvListadoCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoCursos.Size = new System.Drawing.Size(646, 427);
            this.dgvListadoCursos.TabIndex = 15;
            // 
            // lbEliminar
            // 
            this.lbEliminar.AutoSize = true;
            this.lbEliminar.Location = new System.Drawing.Point(817, 398);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(219, 15);
            this.lbEliminar.TabIndex = 17;
            this.lbEliminar.Text = "Seleccione curso en la lista para eliminar";
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 481);
            this.Controls.Add(this.lbEliminar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.dgvListadoCursos);
            this.Controls.Add(this.lbListadoCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.chkElearning);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chkElearning;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbListadoCursos;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.DataGridView dgvListadoCursos;
        private System.Windows.Forms.Label lbEliminar;
    }
}