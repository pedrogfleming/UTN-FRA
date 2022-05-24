
namespace TP4
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnRestaurarInstituto = new System.Windows.Forms.Button();
            this.btnMails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackColor = System.Drawing.Color.Moccasin;
            this.btnAlumnos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlumnos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAlumnos.Location = new System.Drawing.Point(12, 12);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(94, 47);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "Menu Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = false;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.Moccasin;
            this.btnCursos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCursos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCursos.Location = new System.Drawing.Point(12, 65);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(94, 47);
            this.btnCursos.TabIndex = 1;
            this.btnCursos.Text = "Menu Cursos";
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.Moccasin;
            this.btnInformes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnInformes.Location = new System.Drawing.Point(12, 118);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(94, 47);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Menu Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.Color.Moccasin;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarDatos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(12, 224);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(94, 47);
            this.btnLimpiarDatos.TabIndex = 3;
            this.btnLimpiarDatos.Text = "Eliminar Datos Intituto";
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnRestaurarInstituto
            // 
            this.btnRestaurarInstituto.BackColor = System.Drawing.Color.Moccasin;
            this.btnRestaurarInstituto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestaurarInstituto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnRestaurarInstituto.Location = new System.Drawing.Point(12, 277);
            this.btnRestaurarInstituto.Name = "btnRestaurarInstituto";
            this.btnRestaurarInstituto.Size = new System.Drawing.Size(94, 133);
            this.btnRestaurarInstituto.TabIndex = 4;
            this.btnRestaurarInstituto.Text = "Restaurar Copia Seguridad";
            this.btnRestaurarInstituto.UseVisualStyleBackColor = false;
            this.btnRestaurarInstituto.Click += new System.EventHandler(this.btnRestaurarInstituto_Click);
            // 
            // btnMails
            // 
            this.btnMails.BackColor = System.Drawing.Color.Moccasin;
            this.btnMails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMails.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnMails.Location = new System.Drawing.Point(12, 171);
            this.btnMails.Name = "btnMails";
            this.btnMails.Size = new System.Drawing.Size(94, 47);
            this.btnMails.TabIndex = 5;
            this.btnMails.Text = "Enviar Mails";
            this.btnMails.UseVisualStyleBackColor = false;
            this.btnMails.Click += new System.EventHandler(this.btnMails_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(738, 422);
            this.Controls.Add(this.btnMails);
            this.Controls.Add(this.btnRestaurarInstituto);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnCursos);
            this.Controls.Add(this.btnAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instituto Derek Zoolander";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnRestaurarInstituto;
        private System.Windows.Forms.Button btnMails;
    }
}

