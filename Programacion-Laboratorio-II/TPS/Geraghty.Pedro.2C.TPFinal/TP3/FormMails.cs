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
using Entidades;
namespace TP4
{
    public partial class FormMails : Form
    {
        private CancellationTokenSource ctsSource;
        private CancellationToken ctsToken;
        private Random rnmTiempo;
        //Queue<Alumno> listadoPendientes;
        private List<Alumno> listadoPendientes;
        private List<Alumno> listadoEnviados;
        private Instituto formMailsInstituto;
        private string comunicado;

        public FormMails(Instituto formPrincipalInstituto,string comunicado)
        {
            InitializeComponent();
            this.listadoPendientes = new List<Alumno>();
            this.listadoEnviados = new List<Alumno>();
            this.formMailsInstituto = formPrincipalInstituto;
            //Hago una copia de los valores para evitar tener la misma referencia en memoria
            this.listadoPendientes = formPrincipalInstituto.Alumnos.CopiaFantasmaLista();
            this.rnmTiempo = new Random();
            this.comunicado = comunicado;
        }
        private void btnEnviarMails_Click(object sender, EventArgs e)
        {
            try
            {
                this.IniciarEnvioMails();
                btnEnviarMails.Enabled = false;
                btnCancelarEnvios.Enabled = true;
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }
        public void IniciarEnvioMails()
        {
            ctsSource = new CancellationTokenSource();
            ctsToken = ctsSource.Token;
            Task.Run(() => EnviarMails(ctsToken));
        }
        private void EnviarMails(CancellationToken cts)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Mail enviados el dia {0}", (DateTime.Today.ToShortDateString()));
            sb.AppendLine("Con motivo de anunciar:\n");
            sb.AppendLine(this.lbStatus.Text);
            try
            {
                foreach (Alumno item in formMailsInstituto.Alumnos)
                {                
                    if (cts.IsCancellationRequested)
                    {                 
                        
                        string rutaArchivo = SerializacionArchivo.CrearRuta("MailsEnviados.txt");
                        
                        SerializacionArchivo.AppendearTxt(rutaArchivo, sb.ToString());
                        MessageBox.Show($"Se ha cancelado el envío de mails. Mail enviados registrados en ruta:\n{rutaArchivo}","Envio Mails cancelado");
                        this.listadoEnviados.Clear();
                        return;
                    }
                    this.listadoEnviados.Add(this.listadoPendientes.FirstOrDefault<Alumno>());
                    this.listadoPendientes.Remove(this.listadoPendientes.FirstOrDefault<Alumno>());                    
                    sb.AppendFormat("Dni: {0}\t", ((this.listadoPendientes.FirstOrDefault<Alumno>()).Dni));
                    sb.AppendFormat("Alumno: {0}\t", ((this.listadoPendientes.FirstOrDefault<Alumno>()).Apellido));
                    sb.Append((this.listadoPendientes.FirstOrDefault<Alumno>()).Nombre);
                    sb.AppendFormat("\tID: {0}\n", ((this.listadoPendientes.FirstOrDefault<Alumno>()).Id));
                    if (this.lstbxAlumnos.InvokeRequired)
                    {

                        this.lstbxAlumnos.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.lstbxAlumnos.RefrescarLST<Alumno>(this.listadoPendientes);                    
                        });
                        //Se Simula el tiempo variable de conexion con el servidor externo para el envio del mail
                        Thread.Sleep(this.rnmTiempo.Next(1000,4000));
                    }
                    else
                    {
                        this.lstbxAlumnos.RefrescarLST<Alumno>(this.listadoPendientes);
                        //return; 
                    }
                }   
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }
        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormMails_Load(object sender, EventArgs e)
        {
            this.lstbxAlumnos.RefrescarLST<Alumno>(this.listadoPendientes.ToList<Alumno>());
            this.lbStatus.Text = this.comunicado;
        }

        private void btnCancelarEnvios_Click(object sender, EventArgs e)
        {
            try
            {
                this.ctsSource.Cancel();
                btnEnviarMails.Enabled = true;

            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }

        private void FormMails_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(this.ctsSource is not null)
                {
                    this.ctsSource.Cancel();
                }
            }
            catch (Exception ex)
            {
                ex.MostrarMensajeError();
            }
        }
    }
}
