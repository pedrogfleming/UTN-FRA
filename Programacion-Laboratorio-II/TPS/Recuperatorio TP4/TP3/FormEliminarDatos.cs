using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class FormEliminarDatos : Form
    {
        Action delEliminarDatos;
        public FormEliminarDatos(Action delPrincipalForm)
        {
            InitializeComponent();
            this.delEliminarDatos = delPrincipalForm;
        }

        private void FormEliminarDatos_Load(object sender, EventArgs e)
        {
            Action ac = new Action(this.delEliminarDatos);
            Task.Run(ac);
        }

        private void FormEliminarDatos_Shown(object sender, EventArgs e)
        {            
            Task.Run(() => ActualizarLabelEstado());
        }
        private void ActualizarLabelEstado()
        {
            if (this.lbEstado.InvokeRequired)
            {
                this.lbEstado.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.ActualizarLabelEstado();
                }
                );
            }
            else
            {
                this.prbEliminando.Value = 0;
                Thread.Sleep(2000);
                this.prbEliminando.Value = 25;
                Thread.Sleep(2000);
                this.prbEliminando.Value = 50;
                Thread.Sleep(2000);
                this.prbEliminando.Value = 75;
                Thread.Sleep(2000);
                this.prbEliminando.Value = 100;
                Thread.Sleep(2000);
                this.Close();
            }            
        }
    }
}
