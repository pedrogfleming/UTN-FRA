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

namespace Relojero
{
    public partial class FormRelojero : Form
    {
        Task tarea;
        public FormRelojero()
        {
            InitializeComponent();
            tarea = new Task(TiempoReal);
        }
        public void AsignarHora(DateTime auxHora)
        {
            //this.lblHora.Text = auxHora.ToString();
            if(lblHora.InvokeRequired)
            {
                //por default action recibe un metodo void sin parametros, caso contrario tengo q especificarlo
                Action<DateTime> delegado = AsignarHora;
                this.Invoke(delegado);
            }
            else
            {
                this.lblHora.Text = auxHora.ToString("dd/MM/yyyy HH:mm:ss");
            }           
        }
        public void TiempoReal()
        {
            while (true)
            {
                AsignarHora(DateTime.Now);
                Thread.Sleep(1000);
            }
        }

        private void FormRelojero_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }              

        private void timer1_Tick(object sender, EventArgs e)
        {
            AsignarHora(DateTime.Now);
        }
    }
}
