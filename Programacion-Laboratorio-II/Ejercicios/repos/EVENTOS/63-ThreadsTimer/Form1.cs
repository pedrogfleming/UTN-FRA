using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace _63_ThreadsTimer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task t1 = new Task(ActualizarHora);
            t1.Start();
            

        }
        private void AsignarHora()
        {
            if(this.InvokeRequired)
            {
                Action ac = AsignarHora;
                this.Invoke(ac);
            }
            else
            {
                lbHora.Text = DateTime.Now.ToString();
            }
            
        }
        private void ActualizarHora()
        {
            for (; ; )
            {
                AsignarHora();
                Thread.Sleep(1000);
            }
        }
    }
}
