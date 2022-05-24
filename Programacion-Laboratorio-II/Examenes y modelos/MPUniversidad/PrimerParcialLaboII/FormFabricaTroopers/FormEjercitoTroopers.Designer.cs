
namespace FormFabricaTroopers
{
    partial class frmPpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPpal));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lstEjercito = new System.Windows.Forms.ListBox();
            this.picStormtrooperHelmet = new System.Windows.Forms.PictureBox();
            this.cmbBlaster = new System.Windows.Forms.ComboBox();
            this.lblBlaster = new System.Windows.Forms.Label();
            this.chkEsClon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStormtrooperHelmet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 346);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(177, 47);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(28, 400);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(177, 39);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "",
            "Tropper Arena",
            "Tropper Asalto",
            "Tropper Explorador"});
            this.cmbTipo.Location = new System.Drawing.Point(28, 30);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(177, 23);
            this.cmbTipo.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 12);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // lstEjercito
            // 
            this.lstEjercito.FormattingEnabled = true;
            this.lstEjercito.ItemHeight = 15;
            this.lstEjercito.Location = new System.Drawing.Point(220, 30);
            this.lstEjercito.Name = "lstEjercito";
            this.lstEjercito.Size = new System.Drawing.Size(593, 409);
            this.lstEjercito.TabIndex = 4;
            // 
            // picStormtrooperHelmet
            // 
            this.picStormtrooperHelmet.Image = global::FormFabricaTroopers.Properties.Resources.stormtrooper;
            this.picStormtrooperHelmet.Location = new System.Drawing.Point(48, 158);
            this.picStormtrooperHelmet.Name = "picStormtrooperHelmet";
            this.picStormtrooperHelmet.Size = new System.Drawing.Size(131, 133);
            this.picStormtrooperHelmet.TabIndex = 5;
            this.picStormtrooperHelmet.TabStop = false;
            // 
            // cmbBlaster
            // 
            this.cmbBlaster.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "E11",
            "EC17",
            "DLT19"});
            this.cmbBlaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlaster.FormattingEnabled = true;
            this.cmbBlaster.Items.AddRange(new object[] {
            "",
            "BR1",
            "LALA",
            "Arma Temeroza"});
            this.cmbBlaster.Location = new System.Drawing.Point(28, 74);
            this.cmbBlaster.Name = "cmbBlaster";
            this.cmbBlaster.Size = new System.Drawing.Size(177, 23);
            this.cmbBlaster.TabIndex = 6;
            // 
            // lblBlaster
            // 
            this.lblBlaster.AutoSize = true;
            this.lblBlaster.Location = new System.Drawing.Point(28, 56);
            this.lblBlaster.Name = "lblBlaster";
            this.lblBlaster.Size = new System.Drawing.Size(42, 15);
            this.lblBlaster.TabIndex = 7;
            this.lblBlaster.Text = "Blaster";
            // 
            // chkEsClon
            // 
            this.chkEsClon.AutoSize = true;
            this.chkEsClon.Location = new System.Drawing.Point(83, 114);
            this.chkEsClon.Name = "chkEsClon";
            this.chkEsClon.Size = new System.Drawing.Size(65, 19);
            this.chkEsClon.TabIndex = 8;
            this.chkEsClon.Text = "Es Clon";
            this.chkEsClon.UseVisualStyleBackColor = true;
            // 
            // frmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 454);
            this.Controls.Add(this.chkEsClon);
            this.Controls.Add(this.lblBlaster);
            this.Controls.Add(this.cmbBlaster);
            this.Controls.Add(this.picStormtrooperHelmet);
            this.Controls.Add(this.lstEjercito);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos a la fábrica de troopers del Lado Oscuro";
            this.Load += new System.EventHandler(this.FormEjercitoTroopers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStormtrooperHelmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ListBox lstEjercito;
        private System.Windows.Forms.PictureBox picStormtrooperHelmet;
        private System.Windows.Forms.ComboBox cmbBlaster;
        private System.Windows.Forms.Label lblBlaster;
        private System.Windows.Forms.CheckBox chkEsClon;
    }
}

