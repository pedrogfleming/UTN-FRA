using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.Threading.Tasks;
using System.Threading;

namespace View
{
    public partial class FrmView : Form
    {
        private const string archivoPath = "carrusel.json";
        private List<Juego> juegos;
        private bool ejecutando;
        private JsonFiler<List<Juego>> json;
        private CancellationTokenSource source;
        private CancellationToken token;
        private List<Task> hilos;

        public FrmView()
        {
            InitializeComponent();
            this.json = new JsonFiler<List<Juego>>();
            this.juegos = new List<Juego>();
            hilos = new List<Task>();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            // Leo mis juegos del archivo            
            this.Name = "Geraghty Fleming Pedro";
            if (this.json.ExisteArchivo(archivoPath))
            {
                this.json.Leer(archivoPath, out this.juegos);
            }
            this.InitializeJuegos();
            foreach (Juego p in this.juegos)
            {
                // Asociar Evento
                p.InformarAvance += AvanceJuegos;             
                PictureBox pic = (PictureBox)p.ControlVisual;
                pic.Location = this.CalcularUbicacion(pic.Location, p.Ubicacion);
                this.Controls.Add(pic);
            }
            this.nudVelocidad.Value = Juego.Velocidad;
        }

        private void FrmView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarTasks();

            // Guardo mis juegos del archivo
            json.Guardar(archivoPath, this.juegos);
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (!this.ejecutando)
            {
                this.source = new CancellationTokenSource();
                this.token = source.Token;
                // Iniciar hilos
                foreach (Juego item in this.juegos)
                {
                    //InformacionDeAvance delInformeAvance = AvanceJuegos;

                    Task.Run(() => item.IniciarCarrusel(this.source.Token));
                    //Task tsk = new Task(() => item.IniciarCarrusel(this.token));
                    //this.hilos.Add(tsk);
                    //tsk.Start();
                }
                this.btnSimular.Text = "Detener";
                this.ejecutando = true;
            }
            else
            {
                this.FinalizarTasks();
                this.btnSimular.Text = "Iniciar";
                hilos.Clear();
            }
        }

        private void InitializeJuegos()
        {
            // Creo mis juegos
            if (this.juegos.Count == 0)
            {
                Juego.Velocidad = 10;

                Juego juego = new Juego(0, this.picHorse1);
                this.juegos.Add(juego);
                juego = new Juego(45, this.picHorse2);
                this.juegos.Add(juego);
                juego = new Juego(90, this.picHorse3);
                this.juegos.Add(juego);
                juego = new Juego(135, this.picHorse4);
                this.juegos.Add(juego);
                juego = new Juego(180, this.picHorse5);
                this.juegos.Add(juego);
                juego = new Juego(225, this.picHorse6);
                this.juegos.Add(juego);
                juego = new Juego(270, this.picHorse7);
                this.juegos.Add(juego);
                juego = new Juego(315, this.picHorse8);
                this.juegos.Add(juego);
            }
            else
            {
                this.juegos[0].ControlVisual = this.picHorse1;
                this.juegos[1].ControlVisual = this.picHorse2;
                this.juegos[2].ControlVisual = this.picHorse3;
                this.juegos[3].ControlVisual = this.picHorse4;
                this.juegos[4].ControlVisual = this.picHorse5;
                this.juegos[5].ControlVisual = this.picHorse6;
                this.juegos[6].ControlVisual = this.picHorse7;
                this.juegos[7].ControlVisual = this.picHorse8;
            }
        }

        /// <summary>
        /// necesario para pasar de grados a radianes, para poder operar con las funciones de seno y coseno
        /// </summary>
        /// <param name="grados"></param>
        /// <returns></returns>
        public static double GradosARadianes(short grados)
        {
            return grados * (Math.PI / 180);
        }

        private Point CalcularUbicacion(Point posicion, short avance)
        {
            int x = 0;
            int y = avance;
            int radio = 200;

            x = picCarrousel.Location.X + (int)Math.Round(Math.Cos(GradosARadianes(avance)) * radio);
            y = picCarrousel.Location.Y + (int)Math.Round(Math.Sin(GradosARadianes(avance)) * radio);

            return new Point(x, y);
        }

        private void FinalizarTasks()
        {
            if (this.ejecutando)
            {
                // Cancelar hilos
                this.ejecutando = false;
                this.source.Cancel();
            }
        }

        private void AvanceJuegos(object sender, short movimiento)
        {

            PictureBox pic = (PictureBox)((Juego)sender).ControlVisual;
            // Invocación del hilo principal
            if(pic.InvokeRequired)
            {
                //pic.BeginInvoke((MethodInvoker)delegate ()
                //{
                //    pic.Location = this.CalcularUbicacion(pic.Location, movimiento);
                //}
                //);

                //InformacionDeAvance ac = new InformacionDeAvance(AvanceJuegos);
                ////Action<object, short> ac = AvanceJuegos;
                //object[] arrayObjs = new object[] {sender,movimiento };
                //pic.Invoke(ac, arrayObjs);

                InformacionDeAvance del = new InformacionDeAvance(this.AvanceJuegos);
                object[] arrayObjs = new object[] { sender, movimiento };
                pic.Invoke(del, arrayObjs);
            }
            else
            {
                pic.Location = this.CalcularUbicacion(pic.Location, movimiento);
            }
            
        }

        private void nudVelocidad_ValueChanged(object sender, EventArgs e)
        {
            Juego.Velocidad = (short)nudVelocidad.Value;
        }
    }
}
