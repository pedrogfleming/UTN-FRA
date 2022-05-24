using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Deportista
    {
        private EPuesto puesto;
        public Jugador(string nombreApe, int edad, int cantPart,EPuesto puesto) 
            : base(nombreApe, edad, cantPart)
        {
            this.puesto = puesto;
        }
        public EPuesto Puesto
        {
            get
            {
                return this.puesto;
            }
        }
    }
}
