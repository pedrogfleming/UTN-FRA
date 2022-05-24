
namespace AtrapameSiPuedes
{
    partial class formCalculador
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
            this.lbKilometros = new System.Windows.Forms.Label();
            this.lbLitros = new System.Windows.Forms.Label();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.rcTxtMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbKilometros
            // 
            this.lbKilometros.AutoSize = true;
            this.lbKilometros.Location = new System.Drawing.Point(91, 30);
            this.lbKilometros.Name = "lbKilometros";
            this.lbKilometros.Size = new System.Drawing.Size(64, 15);
            this.lbKilometros.TabIndex = 0;
            this.lbKilometros.Text = "Kilometros";
            // 
            // lbLitros
            // 
            this.lbLitros.AutoSize = true;
            this.lbLitros.Location = new System.Drawing.Point(104, 122);
            this.lbLitros.Name = "lbLitros";
            this.lbLitros.Size = new System.Drawing.Size(36, 15);
            this.lbLitros.TabIndex = 1;
            this.lbLitros.Text = "Litros";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(75, 77);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(100, 23);
            this.txtKilometros.TabIndex = 2;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(75, 162);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(100, 23);
            this.txtLitros.TabIndex = 3;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(26, 200);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(198, 51);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // rcTxtMostrar
            // 
            this.rcTxtMostrar.Location = new System.Drawing.Point(259, 30);
            this.rcTxtMostrar.Name = "rcTxtMostrar";
            this.rcTxtMostrar.ReadOnly = true;
            this.rcTxtMostrar.Size = new System.Drawing.Size(283, 221);
            this.rcTxtMostrar.TabIndex = 5;
            this.rcTxtMostrar.Text = "";
            // 
            // formCalculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 277);
            this.Controls.Add(this.rcTxtMostrar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtKilometros);
            this.Controls.Add(this.lbLitros);
            this.Controls.Add(this.lbKilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCalculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKilometros;
        private System.Windows.Forms.Label lbLitros;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.RichTextBox rcTxtMostrar;
    }
}

