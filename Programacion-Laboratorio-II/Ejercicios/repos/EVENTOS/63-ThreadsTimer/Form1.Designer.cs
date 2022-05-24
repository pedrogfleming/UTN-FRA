
namespace _63_ThreadsTimer
{
    partial class Form1
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
            this.lbHora = new System.Windows.Forms.Label();
            this.rch = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(13, 28);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(0, 15);
            this.lbHora.TabIndex = 0;
            // 
            // rch
            // 
            this.rch.Location = new System.Drawing.Point(13, 46);
            this.rch.Name = "rch";
            this.rch.Size = new System.Drawing.Size(755, 392);
            this.rch.TabIndex = 1;
            this.rch.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.rch);
            this.Controls.Add(this.lbHora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.RichTextBox rch;
    }
}

