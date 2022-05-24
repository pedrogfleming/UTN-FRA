
namespace TP4
{
    partial class FormMails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMails));
            this.lstbxAlumnos = new System.Windows.Forms.ListBox();
            this.btnEnviarMails = new System.Windows.Forms.Button();
            this.btnCancelarEnvios = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxAlumnos
            // 
            this.lstbxAlumnos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstbxAlumnos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lstbxAlumnos.FormattingEnabled = true;
            this.lstbxAlumnos.ItemHeight = 14;
            this.lstbxAlumnos.Location = new System.Drawing.Point(12, 255);
            this.lstbxAlumnos.Name = "lstbxAlumnos";
            this.lstbxAlumnos.Size = new System.Drawing.Size(378, 396);
            this.lstbxAlumnos.TabIndex = 0;
            this.lstbxAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstAlumnos_SelectedIndexChanged);
            // 
            // btnEnviarMails
            // 
            this.btnEnviarMails.BackColor = System.Drawing.Color.Moccasin;
            this.btnEnviarMails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviarMails.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEnviarMails.Location = new System.Drawing.Point(12, 183);
            this.btnEnviarMails.Name = "btnEnviarMails";
            this.btnEnviarMails.Size = new System.Drawing.Size(186, 57);
            this.btnEnviarMails.TabIndex = 1;
            this.btnEnviarMails.Text = "Enviar Mails";
            this.btnEnviarMails.UseVisualStyleBackColor = false;
            this.btnEnviarMails.Click += new System.EventHandler(this.btnEnviarMails_Click);
            // 
            // btnCancelarEnvios
            // 
            this.btnCancelarEnvios.BackColor = System.Drawing.Color.Moccasin;
            this.btnCancelarEnvios.Enabled = false;
            this.btnCancelarEnvios.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarEnvios.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCancelarEnvios.Location = new System.Drawing.Point(204, 183);
            this.btnCancelarEnvios.Name = "btnCancelarEnvios";
            this.btnCancelarEnvios.Size = new System.Drawing.Size(186, 57);
            this.btnCancelarEnvios.TabIndex = 2;
            this.btnCancelarEnvios.Text = "Detener envio mails";
            this.btnCancelarEnvios.UseVisualStyleBackColor = false;
            this.btnCancelarEnvios.Click += new System.EventHandler(this.btnCancelarEnvios_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStatus.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbStatus.Location = new System.Drawing.Point(12, 27);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(378, 153);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Haga click en \"Enviar Mails\" para mandarle mails a los alumnos listados";
            // 
            // FormMails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(407, 665);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCancelarEnvios);
            this.Controls.Add(this.btnEnviarMails);
            this.Controls.Add(this.lstbxAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMails";
            this.Text = "Mails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMails_FormClosing);
            this.Load += new System.EventHandler(this.FormMails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxAlumnos;
        private System.Windows.Forms.Button btnEnviarMails;
        private System.Windows.Forms.Button btnCancelarEnvios;
        private System.Windows.Forms.Label lbStatus;
    }
}