using System;
using System.Threading;

namespace Entidades
{
    public class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public bool Activo { get; set; }
        public int Intervalo { get; set; }

        //private void Corriendo();
        

    }
}
