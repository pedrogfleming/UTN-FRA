
namespace TP4
{
    partial class FormEliminarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarDatos));
            this.prbEliminando = new System.Windows.Forms.ProgressBar();
            this.lbEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prbEliminando
            // 
            this.prbEliminando.Location = new System.Drawing.Point(23, 69);
            this.prbEliminando.Name = "prbEliminando";
            this.prbEliminando.Size = new System.Drawing.Size(303, 23);
            this.prbEliminando.TabIndex = 0;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEstado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbEstado.Location = new System.Drawing.Point(23, 18);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(276, 33);
            this.lbEstado.TabIndex = 1;
            this.lbEstado.Text = "Eliminando Datos...";
            // 
            // FormEliminarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(359, 117);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.prbEliminando);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEliminarDatos";
            this.Text = "Eliminando Datos";
            this.Load += new System.EventHandler(this.FormEliminarDatos_Load);
            this.Shown += new System.EventHandler(this.FormEliminarDatos_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbEliminando;
        private System.Windows.Forms.Label lbEstado;
    }
}