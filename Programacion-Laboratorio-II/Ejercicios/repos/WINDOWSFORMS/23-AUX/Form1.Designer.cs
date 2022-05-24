
namespace _23_AUX
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPesoConvertir = new System.Windows.Forms.Button();
            this.btnDolarConvertir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesoIngresado = new System.Windows.Forms.TextBox();
            this.txtDolarIngresado = new System.Windows.Forms.TextBox();
            this.txtEuroIngresado = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.btnEuroConvertir = new System.Windows.Forms.Button();
            this.txtDisplayEuro1 = new System.Windows.Forms.TextBox();
            this.txtDisplayDolar1 = new System.Windows.Forms.TextBox();
            this.txtDisplayPeso1 = new System.Windows.Forms.TextBox();
            this.txtDisplayEuro2 = new System.Windows.Forms.TextBox();
            this.txtDisplayEuro3 = new System.Windows.Forms.TextBox();
            this.txtDisplayDolar2 = new System.Windows.Forms.TextBox();
            this.txtDisplayDolar3 = new System.Windows.Forms.TextBox();
            this.txtDisplayPeso2 = new System.Windows.Forms.TextBox();
            this.txtDisplayPeso3 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCandado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPesoConvertir
            // 
            this.btnPesoConvertir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPesoConvertir.Location = new System.Drawing.Point(293, 289);
            this.btnPesoConvertir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesoConvertir.Name = "btnPesoConvertir";
            this.btnPesoConvertir.Size = new System.Drawing.Size(76, 23);
            this.btnPesoConvertir.TabIndex = 59;
            this.btnPesoConvertir.Text = "->";
            this.btnPesoConvertir.UseVisualStyleBackColor = true;
            this.btnPesoConvertir.UseWaitCursor = true;
            this.btnPesoConvertir.Click += new System.EventHandler(this.btnPesoConvertir_Click);
            // 
            // btnDolarConvertir
            // 
            this.btnDolarConvertir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDolarConvertir.Location = new System.Drawing.Point(293, 257);
            this.btnDolarConvertir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDolarConvertir.Name = "btnDolarConvertir";
            this.btnDolarConvertir.Size = new System.Drawing.Size(76, 23);
            this.btnDolarConvertir.TabIndex = 58;
            this.btnDolarConvertir.Text = "->";
            this.btnDolarConvertir.UseVisualStyleBackColor = true;
            this.btnDolarConvertir.UseWaitCursor = true;
            this.btnDolarConvertir.Click += new System.EventHandler(this.btnDolar_click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(187, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Cotización";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Peso";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "Dólar";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Euro";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Peso";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Dólar";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Euro";
            this.label1.UseWaitCursor = true;
            // 
            // txtPesoIngresado
            // 
            this.txtPesoIngresado.Location = new System.Drawing.Point(171, 287);
            this.txtPesoIngresado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesoIngresado.Name = "txtPesoIngresado";
            this.txtPesoIngresado.Size = new System.Drawing.Size(101, 23);
            this.txtPesoIngresado.TabIndex = 50;
            this.txtPesoIngresado.UseWaitCursor = true;
            // 
            // txtDolarIngresado
            // 
            this.txtDolarIngresado.Location = new System.Drawing.Point(171, 257);
            this.txtDolarIngresado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDolarIngresado.Name = "txtDolarIngresado";
            this.txtDolarIngresado.Size = new System.Drawing.Size(101, 23);
            this.txtDolarIngresado.TabIndex = 49;
            this.txtDolarIngresado.UseWaitCursor = true;
            // 
            // txtEuroIngresado
            // 
            this.txtEuroIngresado.Location = new System.Drawing.Point(171, 229);
            this.txtEuroIngresado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEuroIngresado.Name = "txtEuroIngresado";
            this.txtEuroIngresado.Size = new System.Drawing.Size(101, 23);
            this.txtEuroIngresado.TabIndex = 48;
            this.txtEuroIngresado.UseWaitCursor = true;
            this.txtEuroIngresado.TextChanged += new System.EventHandler(this.txtEuroIngresado_TextChanged);
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(610, 137);
            this.txtCotizacionPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(101, 23);
            this.txtCotizacionPeso.TabIndex = 47;
            this.txtCotizacionPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionPeso.UseWaitCursor = true;
            this.txtCotizacionPeso.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Enabled = false;
            this.txtCotizacionDolar.Location = new System.Drawing.Point(493, 137);
            this.txtCotizacionDolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(101, 23);
            this.txtCotizacionDolar.TabIndex = 46;
            this.txtCotizacionDolar.Text = "1";
            this.txtCotizacionDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionDolar.UseWaitCursor = true;
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(375, 137);
            this.txtCotizacionEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(101, 23);
            this.txtCotizacionEuro.TabIndex = 45;
            this.txtCotizacionEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionEuro.UseWaitCursor = true;
            // 
            // btnEuroConvertir
            // 
            this.btnEuroConvertir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEuroConvertir.Location = new System.Drawing.Point(293, 229);
            this.btnEuroConvertir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEuroConvertir.Name = "btnEuroConvertir";
            this.btnEuroConvertir.Size = new System.Drawing.Size(76, 23);
            this.btnEuroConvertir.TabIndex = 36;
            this.btnEuroConvertir.Text = "->";
            this.btnEuroConvertir.UseVisualStyleBackColor = true;
            this.btnEuroConvertir.UseWaitCursor = true;
            this.btnEuroConvertir.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // txtDisplayEuro1
            // 
            this.txtDisplayEuro1.Enabled = false;
            this.txtDisplayEuro1.Location = new System.Drawing.Point(375, 229);
            this.txtDisplayEuro1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayEuro1.Name = "txtDisplayEuro1";
            this.txtDisplayEuro1.ReadOnly = true;
            this.txtDisplayEuro1.Size = new System.Drawing.Size(101, 23);
            this.txtDisplayEuro1.TabIndex = 60;
            this.txtDisplayEuro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayEuro1.UseWaitCursor = true;
            // 
            // txtDisplayDolar1
            // 
            this.txtDisplayDolar1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDisplayDolar1.Enabled = false;
            this.txtDisplayDolar1.Location = new System.Drawing.Point(493, 230);
            this.txtDisplayDolar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayDolar1.Name = "txtDisplayDolar1";
            this.txtDisplayDolar1.ReadOnly = true;
            this.txtDisplayDolar1.Size = new System.Drawing.Size(101, 23);
            this.txtDisplayDolar1.TabIndex = 61;
            this.txtDisplayDolar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayDolar1.UseWaitCursor = true;
            this.txtDisplayDolar1.TextChanged += new System.EventHandler(this.txtDisplayDolar1_TextChanged);
            // 
            // txtDisplayPeso1
            // 
            this.txtDisplayPeso1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDisplayPeso1.Enabled = false;
            this.txtDisplayPeso1.Location = new System.Drawing.Point(610, 229);
            this.txtDisplayPeso1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayPeso1.Name = "txtDisplayPeso1";
            this.txtDisplayPeso1.ReadOnly = true;
            this.txtDisplayPeso1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDisplayPeso1.Size = new System.Drawing.Size(101, 23);
            this.txtDisplayPeso1.TabIndex = 62;
            this.txtDisplayPeso1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayPeso1.UseWaitCursor = true;
            // 
            // txtDisplayEuro2
            // 
            this.txtDisplayEuro2.Enabled = false;
            this.txtDisplayEuro2.Location = new System.Drawing.Point(375, 259);
            this.txtDisplayEuro2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayEuro2.Name = "txtDisplayEuro2";
            this.txtDisplayEuro2.ReadOnly = true;
            this.txtDisplayEuro2.Size = new System.Drawing.Size(101, 23);
            this.txtDisplayEuro2.TabIndex = 63;
            this.txtDisplayEuro2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayEuro2.UseWaitCursor = true;
            // 
            // txtDisplayEuro3
            // 
            this.txtDisplayEuro3.Enabled = false;
            this.txtDisplayEuro3.Location = new System.Drawing.Point(375, 291);
            this.txtDisplayEuro3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayEuro3.Name = "txtDisplayEuro3";
            this.txtDisplayEuro3.ReadOnly = true;
            this.txtDisplayEuro3.Size = new System.Drawing.Size(101, 23);
            this.txtDisplayEuro3.TabIndex = 64;
            this.txtDisplayEuro3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayEuro3.UseWaitCursor = true;
            // 
            // txtDisplayDolar2
            // 
            this.txtDisplayDolar2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDisplayDolar2.Enabled = false;
            this.txtDisplayDolar2.Location = new System.Drawing.Point(493, 262);
            this.txtDisplayDolar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayDolar2.Name = "txtDisplayDolar2";
            this.txtDisplayDolar2.ReadOnly = true;
            this.txtDisplayDolar2.Size = new System.Drawing.Size(101, 23);
            this.txtDisplayDolar2.TabIndex = 65;
            this.txtDisplayDolar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayDolar2.UseWaitCursor = true;
            // 
            // txtDisplayDolar3
            // 
            this.txtDisplayDolar3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDisplayDolar3.Enabled = false;
            this.txtDisplayDolar3.Location = new System.Drawing.Point(493, 291);
            this.txtDisplayDolar3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayDolar3.Name = "txtDisplayDolar3";
            this.txtDisplayDolar3.ReadOnly = true;
            this.txtDisplayDolar3.Size = new System.Drawing.Size(101, 23);
            this.txtDisplayDolar3.TabIndex = 66;
            this.txtDisplayDolar3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayDolar3.UseWaitCursor = true;
            // 
            // txtDisplayPeso2
            // 
            this.txtDisplayPeso2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDisplayPeso2.Enabled = false;
            this.txtDisplayPeso2.Location = new System.Drawing.Point(610, 257);
            this.txtDisplayPeso2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayPeso2.Name = "txtDisplayPeso2";
            this.txtDisplayPeso2.ReadOnly = true;
            this.txtDisplayPeso2.Size = new System.Drawing.Size(101, 23);
            this.txtDisplayPeso2.TabIndex = 67;
            this.txtDisplayPeso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayPeso2.UseWaitCursor = true;
            // 
            // txtDisplayPeso3
            // 
            this.txtDisplayPeso3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDisplayPeso3.Enabled = false;
            this.txtDisplayPeso3.Location = new System.Drawing.Point(610, 287);
            this.txtDisplayPeso3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplayPeso3.Name = "txtDisplayPeso3";
            this.txtDisplayPeso3.ReadOnly = true;
            this.txtDisplayPeso3.Size = new System.Drawing.Size(101, 23);
            this.txtDisplayPeso3.TabIndex = 68;
            this.txtDisplayPeso3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayPeso3.UseWaitCursor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.jpg");
            this.imageList1.Images.SetKeyName(1, "1.jpg");
            // 
            // btnCandado
            // 
            this.btnCandado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCandado.ImageIndex = 1;
            this.btnCandado.ImageList = this.imageList1;
            this.btnCandado.Location = new System.Drawing.Point(304, 124);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(53, 56);
            this.btnCandado.TabIndex = 70;
            this.btnCandado.UseWaitCursor = true;
            this.btnCandado.Click += new System.EventHandler(this.btnCandado_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(780, 357);
            this.Controls.Add(this.btnCandado);
            this.Controls.Add(this.txtDisplayPeso3);
            this.Controls.Add(this.txtDisplayPeso2);
            this.Controls.Add(this.txtDisplayDolar3);
            this.Controls.Add(this.txtDisplayDolar2);
            this.Controls.Add(this.txtDisplayEuro3);
            this.Controls.Add(this.txtDisplayEuro2);
            this.Controls.Add(this.txtDisplayPeso1);
            this.Controls.Add(this.txtDisplayDolar1);
            this.Controls.Add(this.txtDisplayEuro1);
            this.Controls.Add(this.btnPesoConvertir);
            this.Controls.Add(this.btnDolarConvertir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesoIngresado);
            this.Controls.Add(this.txtDolarIngresado);
            this.Controls.Add(this.txtEuroIngresado);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.btnEuroConvertir);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesoConvertir;
        private System.Windows.Forms.Button btnDolarConvertir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesoIngresado;
        private System.Windows.Forms.TextBox txtDolarIngresado;
        private System.Windows.Forms.TextBox txtEuroIngresado;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.Button btnEuroConvertir;
        private System.Windows.Forms.TextBox txtDisplayEuro1;
        private System.Windows.Forms.TextBox txtDisplayDolar1;
        private System.Windows.Forms.TextBox txtDisplayPeso1;
        private System.Windows.Forms.TextBox txtDisplayEuro2;
        private System.Windows.Forms.TextBox txtDisplayEuro3;
        private System.Windows.Forms.TextBox txtDisplayDolar2;
        private System.Windows.Forms.TextBox txtDisplayDolar3;
        private System.Windows.Forms.TextBox txtDisplayPeso2;
        private System.Windows.Forms.TextBox txtDisplayPeso3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label btnCandado;
    }
}

