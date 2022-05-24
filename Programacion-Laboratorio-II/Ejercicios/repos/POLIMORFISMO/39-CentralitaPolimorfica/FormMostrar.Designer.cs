
namespace _41_CentralitaExcepciones
{
    partial class FormMostrar
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
            this.rtxtbFacturacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtbFacturacion
            // 
            this.rtxtbFacturacion.Location = new System.Drawing.Point(12, 12);
            this.rtxtbFacturacion.Name = "rtxtbFacturacion";
            this.rtxtbFacturacion.Size = new System.Drawing.Size(342, 426);
            this.rtxtbFacturacion.TabIndex = 0;
            this.rtxtbFacturacion.Text = "";
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.rtxtbFacturacion);
            this.Name = "FormFacturacion";
            this.Text = "FormFacturacion";
            this.Load += new System.EventHandler(this.FormFacturacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtbFacturacion;
    }
}