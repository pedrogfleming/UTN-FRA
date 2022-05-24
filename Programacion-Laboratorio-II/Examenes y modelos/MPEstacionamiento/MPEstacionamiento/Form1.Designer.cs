
namespace MPEstacionamiento
{
    partial class FrmEstacionamiento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.cmbTipoMoto = new System.Windows.Forms.ComboBox();
            this.txtNombreEstacionamiento = new System.Windows.Forms.TextBox();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(60, 52);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(78, 15);
            this.lblTipoVehiculo.TabIndex = 0;
            this.lblTipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(60, 85);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(47, 15);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(60, 122);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(62, 15);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo Moto";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(148, 52);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoVehiculo.TabIndex = 3;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(148, 81);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(121, 23);
            this.txtPatente.TabIndex = 4;
            // 
            // cmbTipoMoto
            // 
            this.cmbTipoMoto.FormattingEnabled = true;
            this.cmbTipoMoto.Location = new System.Drawing.Point(148, 119);
            this.cmbTipoMoto.Name = "cmbTipoMoto";
            this.cmbTipoMoto.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoMoto.TabIndex = 5;
            // 
            // txtNombreEstacionamiento
            // 
            this.txtNombreEstacionamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtNombreEstacionamiento.Location = new System.Drawing.Point(400, 24);
            this.txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            this.txtNombreEstacionamiento.Size = new System.Drawing.Size(354, 23);
            this.txtNombreEstacionamiento.TabIndex = 6;
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 15;
            this.lstVehiculos.Location = new System.Drawing.Point(398, 71);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(355, 334);
            this.lstVehiculos.TabIndex = 7;
            this.lstVehiculos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVehiculos_MouseDoubleClick);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(276, 118);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(80, 346);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(175, 78);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar Vehiculo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.txtNombreEstacionamiento);
            this.Controls.Add(this.cmbTipoMoto);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblTipoVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.ComboBox cmbTipoMoto;
        private System.Windows.Forms.TextBox txtNombreEstacionamiento;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAgregar;
    }
}

