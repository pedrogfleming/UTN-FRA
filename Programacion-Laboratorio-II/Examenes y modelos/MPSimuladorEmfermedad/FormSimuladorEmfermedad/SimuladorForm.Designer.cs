
namespace FormSimuladorEmfermedad
{
    partial class SimuladorForm
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
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.rtbEvolucion = new System.Windows.Forms.RichTextBox();
            this.cmbMicroOrganismo = new System.Windows.Forms.ComboBox();
            this.lbPoblacion = new System.Windows.Forms.Label();
            this.lbMicroOrganismo = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(141, 23);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(192, 23);
            this.txtPoblacion.TabIndex = 0;
            this.txtPoblacion.Text = "100000";
            // 
            // rtbEvolucion
            // 
            this.rtbEvolucion.Location = new System.Drawing.Point(12, 140);
            this.rtbEvolucion.Name = "rtbEvolucion";
            this.rtbEvolucion.Size = new System.Drawing.Size(765, 298);
            this.rtbEvolucion.TabIndex = 1;
            this.rtbEvolucion.Text = "";
            // 
            // cmbMicroOrganismo
            // 
            this.cmbMicroOrganismo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMicroOrganismo.FormattingEnabled = true;
            this.cmbMicroOrganismo.Items.AddRange(new object[] {
            "Covid-19",
            "Gripe"});
            this.cmbMicroOrganismo.Location = new System.Drawing.Point(141, 53);
            this.cmbMicroOrganismo.Name = "cmbMicroOrganismo";
            this.cmbMicroOrganismo.Size = new System.Drawing.Size(192, 23);
            this.cmbMicroOrganismo.TabIndex = 2;
            // 
            // lbPoblacion
            // 
            this.lbPoblacion.AutoSize = true;
            this.lbPoblacion.Location = new System.Drawing.Point(12, 26);
            this.lbPoblacion.Name = "lbPoblacion";
            this.lbPoblacion.Size = new System.Drawing.Size(110, 15);
            this.lbPoblacion.TabIndex = 3;
            this.lbPoblacion.Text = "Poblacion a Evaluar";
            // 
            // lbMicroOrganismo
            // 
            this.lbMicroOrganismo.AutoSize = true;
            this.lbMicroOrganismo.Location = new System.Drawing.Point(13, 53);
            this.lbMicroOrganismo.Name = "lbMicroOrganismo";
            this.lbMicroOrganismo.Size = new System.Drawing.Size(95, 15);
            this.lbMicroOrganismo.TabIndex = 4;
            this.lbMicroOrganismo.Text = "Microorganismo";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(620, 98);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(157, 36);
            this.btnEjecutar.TabIndex = 5;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // SimuladorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.lbMicroOrganismo);
            this.Controls.Add(this.lbPoblacion);
            this.Controls.Add(this.cmbMicroOrganismo);
            this.Controls.Add(this.rtbEvolucion);
            this.Controls.Add(this.txtPoblacion);
            this.Name = "SimuladorForm";
            this.Text = "Simulador de Pandemia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimuladorForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimuladorForm_FormClosed);
            this.Load += new System.EventHandler(this.SimuladorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.RichTextBox rtbEvolucion;
        private System.Windows.Forms.ComboBox cmbMicroOrganismo;
        private System.Windows.Forms.Label lbPoblacion;
        private System.Windows.Forms.Label lbMicroOrganismo;
        private System.Windows.Forms.Button btnEjecutar;
    }
}

