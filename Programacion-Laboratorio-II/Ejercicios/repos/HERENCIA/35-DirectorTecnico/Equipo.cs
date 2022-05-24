using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_DirectorTecnico
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> Jugadores;
        private string nombre;
        private Equipo()
        {
            this.Jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad,string nombre):this()
        {
            if (!String.IsNullOrEmpty(nombre) && cantidad>-1)
            {
                this.cantidadDeJugadores = cantidad;
                this.nombre = nombre;
            }
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            if(e.Jugadores.Count() < e.cantidadDeJugadores && e!=j)    
            {
                e.Jugadores.Add(j);
                return true;
            }
            return false;
        }
        public static bool operator ==(Equipo e,Jugador j)
        {
            foreach (Jugador item in e.Jugadores)
            {
                if(item == j)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e==j);
        }
    }
}
