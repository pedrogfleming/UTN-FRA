using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, short movimiento);
    
    public class Juego
    {
        public event InformacionDeAvance InformarAvance;
        private static short velocidad;
        private short ubicacion;
        private object controlVisual;
        static Juego()
        {
            Juego.velocidad = 8;
        }
        public Juego()
        {
        }
        public Juego(short ubicacion, object objetoVisual)
        {
            this.ubicacion = ubicacion;
            this.controlVisual = objetoVisual;            
        }
        public static short Velocidad 
        {
            get
            {
                return Juego.velocidad;
            }
            set
            {
                if(value >= 0)
                {
                    Juego.velocidad = value;
                }
            }
        }
        public short Ubicacion
        {
            get
            {
                return this.ubicacion;
            }
            set
            {
                if(value >= 0)
                {
                    this.ubicacion = value;
                }
            }
        }
        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual
        {
            get
            {
                return this.controlVisual;
            }
            set
            {
                this.controlVisual = value;
            }
        }
        /// <summary>
        /// Simula mover el item en el espacio del form alterando sus atributos
        /// </summary>
        /// <returns></returns>
        public short Avanzar()
        {
            this.ubicacion += velocidad;
            return this.ubicacion;
        }

        /// <summary>
        /// Simular la animación del Carrusel
        /// </summary>
        public void IniciarCarrusel(CancellationToken cancelToken)
        {
                do
                {                   
                    if(InformarAvance is not null)
                    {
                        InformarAvance.Invoke(this, this.Avanzar());
                    }
                    System.Threading.Thread.Sleep(60 + Juego.velocidad);      
                } while (!cancelToken.IsCancellationRequested);
        }
    }
}
