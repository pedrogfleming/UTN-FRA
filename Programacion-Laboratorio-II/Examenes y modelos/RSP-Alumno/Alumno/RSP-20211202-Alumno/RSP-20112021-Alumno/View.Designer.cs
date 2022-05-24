namespace Final_20112021_Alumno
{
    partial class View
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
            this.lstPrioMax = new System.Windows.Forms.ListBox();
            this.lstPrioEsp = new System.Windows.Forms.ListBox();
            this.lstNoPrio = new System.Windows.Forms.ListBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnAtenderPrioMax = new System.Windows.Forms.Button();
            this.btnAtenderPrioEsp = new System.Windows.Forms.Button();
            this.btnAtenderClasica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPrioMax
            // 
            this.lstPrioMax.FormattingEnabled = true;
            this.lstPrioMax.ItemHeight = 15;
            this.lstPrioMax.Location = new System.Drawing.Point(192, 71);
            this.lstPrioMax.Name = "lstPrioMax";
            this.lstPrioMax.Size = new System.Drawing.Size(120, 394);
            this.lstPrioMax.TabIndex = 0;
            // 
            // lstPrioEsp
            // 
            this.lstPrioEsp.FormattingEnabled = true;
            this.lstPrioEsp.ItemHeight = 15;
            this.lstPrioEsp.Location = new System.Drawing.Point(336, 71);
            this.lstPrioEsp.Name = "lstPrioEsp";
            this.lstPrioEsp.Size = new System.Drawing.Size(120, 394);
            this.lstPrioEsp.TabIndex = 1;
            // 
            // lstNoPrio
            // 
            this.lstNoPrio.FormattingEnabled = true;
            this.lstNoPrio.ItemHeight = 15;
            this.lstNoPrio.Location = new System.Drawing.Point(475, 71);
            this.lstNoPrio.Name = "lstNoPrio";
            this.lstNoPrio.Size = new System.Drawing.Size(120, 394);
            this.lstNoPrio.TabIndex = 2;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(23, 202);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(136, 74);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir Negocio";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnAtenderPrioMax
            // 
            this.btnAtenderPrioMax.Location = new System.Drawing.Point(192, 17);
            this.btnAtenderPrioMax.Name = "btnAtenderPrioMax";
            this.btnAtenderPrioMax.Size = new System.Drawing.Size(120, 48);
            this.btnAtenderPrioMax.TabIndex = 4;
            this.btnAtenderPrioMax.Text = "Atender Caja Max Unidades";
            this.btnAtenderPrioMax.UseVisualStyleBackColor = true;
            this.btnAtenderPrioMax.Click += new System.EventHandler(this.btnAtenderPrioMax_Click);
            // 
            // btnAtenderPrioEsp
            // 
            this.btnAtenderPrioEsp.Location = new System.Drawing.Point(336, 17);
            this.btnAtenderPrioEsp.Name = "btnAtenderPrioEsp";
            this.btnAtenderPrioEsp.Size = new System.Drawing.Size(120, 48);
            this.btnAtenderPrioEsp.TabIndex = 5;
            this.btnAtenderPrioEsp.Text = "Atender Caja Especial";
            this.btnAtenderPrioEsp.UseVisualStyleBackColor = true;
            // 
            // btnAtenderClasica
            // 
            this.btnAtenderClasica.Location = new System.Drawing.Point(475, 17);
            this.btnAtenderClasica.Name = "btnAtenderClasica";
            this.btnAtenderClasica.Size = new System.Drawing.Size(120, 48);
            this.btnAtenderClasica.TabIndex = 6;
            this.btnAtenderClasica.Text = "Atender Caja Clasica";
            this.btnAtenderClasica.UseVisualStyleBackColor = true;
            this.btnAtenderClasica.Click += new System.EventHandler(this.btnAtenderClasica_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 477);
            this.Controls.Add(this.btnAtenderClasica);
            this.Controls.Add(this.btnAtenderPrioEsp);
            this.Controls.Add(this.btnAtenderPrioMax);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lstNoPrio);
            this.Controls.Add(this.lstPrioEsp);
            this.Controls.Add(this.lstPrioMax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiFormulario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPrioMax;
        private System.Windows.Forms.ListBox lstPrioEsp;
        private System.Windows.Forms.ListBox lstNoPrio;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnAtenderPrioMax;
        private System.Windows.Forms.Button btnAtenderPrioEsp;
        private System.Windows.Forms.Button btnAtenderClasica;
    }
}
