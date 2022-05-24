using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FormSimuladorEmfermedad
{
    public partial class SimuladorForm : Form
    {

        Microrganismo miMicrorganismo;
        CancellationTokenSource source;
        CancellationToken token;
        private Task HiloSimulacion;
        public SimuladorForm()
        {
            InitializeComponent();            
        }

        private void SimuladorForm_Load(object sender, EventArgs e)
        {
            cmbMicroOrganismo.SelectedIndex = 0;
            this.source = new CancellationTokenSource();
            this.token = source.Token;            
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {

            if (cmbMicroOrganismo.SelectedIndex == 0)
            {
                miMicrorganismo = new Covid19("Covid-19");
            }
            else
            {
                miMicrorganismo = new Gripe("Gripe", Microrganismo.ETipo.Virus, Microrganismo.EContagiosidad.Moderada);
            }
            #region Codigo con Thread
            //Object obj = miMicrorganismo;
            //ParameterizedThreadStart pTstar = GrupoDePrueba<Microrganismo>.InfectarPoblacion;
            //this.TSimulacion = new Thread(pTstar);
            //this.TSimulacion.Start(obj);
            //while(TSimulacion.IsAlive)
            //{
            //    rtbEvolucion.Text += miMicrorganismo.Informe()+"\n";
            //    Thread.Sleep(750);
            //}
            #endregion
            rtbEvolucion.Text += miMicrorganismo.Informe();
            //Guardo en un delegado de la clase el metodo del formulario imprimir avance
            GrupoDePrueba<Microrganismo>.delAvanceInfectados = imprimirInformeAvance;
            //Guardo el delegado anterior en un evento de la clase
            GrupoDePrueba<Microrganismo>.InformeDeAvance += GrupoDePrueba<Microrganismo>.delAvanceInfectados;
            //Guardo en un delegado de la clase el metodo del formulario informar fin infeccion
            GrupoDePrueba<Microrganismo>.delFinInfectacion = informarFinInfectacion;
            //Guardo el delegado anterior en un evento de la clase
            GrupoDePrueba<Microrganismo>.FinalizaSimulacion += GrupoDePrueba<Microrganismo>.delFinInfectacion;
            //Corro en un hilo secundario el metodo para iniciar la simulacion
            Task t1 = Task.Run(() => GrupoDePrueba<Microrganismo>.InfectarPoblacion(miMicrorganismo));
        }
        private void imprimirInformeAvance(int dias,long infectados)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dia {dias}: {infectados} de la poblacion total");
            if (rtbEvolucion.InvokeRequired)
            {
                this.rtbEvolucion.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.rtbEvolucion.Text += sb.ToString();
                }
                );
            }
            else
            {
                rtbEvolucion.Text += sb.ToString();
            }
            if (this.HiloSimulacion != null && !this.HiloSimulacion.IsCompleted)
            {
                this.source.Cancel();
            }
        }
        private void informarFinInfectacion()
        {
            if(rtbEvolucion.InvokeRequired)
            {
                this.rtbEvolucion.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.rtbEvolucion.Text += "Toda la poblacion fue infectada!";
                }
                );
            }
            else
            {
                rtbEvolucion.Text += "Toda la poblacion fue infectada!";
            }
            if (this.HiloSimulacion != null && !this.HiloSimulacion.IsCompleted)
            {
                this.source.Cancel();
            }
        }
        private void SimuladorForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void SimuladorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.HiloSimulacion != null && !this.HiloSimulacion.IsCompleted)
            {
                this.source.Cancel();
            }

        }
    }
}
    

