using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private Entrenador entrenador;
        private Estadistica estadistica;
        private List<Jugador> listaJugadores;
        private string nombreEquipo;

        public Equipo(string nombreEquipo,Entrenador ent, List<Jugador> listJug)
        {
            this.nombreEquipo = nombreEquipo;
            this.Entrenador = ent;
            this.Estadistica = new Estadistica();
            this.ListaJugadores = listJug;
        }
        #region Propiedades
        public Entrenador Entrenador 
        {
            get
            {
                return this.entrenador;
            }
            set
            {
                if(value is not null)
                {
                    this.entrenador = value;
                }
            }
        }
        public Estadistica Estadistica
        {
            get
            {
                return this.estadistica;
            }
            set
            {
                if (value is not null)
                {
                    this.estadistica = value;
                }
            }
        }
        public List<Jugador> ListaJugadores
        {
            get
            {
                return this.listaJugadores;
            }
            set
            {
                if (value is not null)
                {
                    this.listaJugadores = value;
                }
            }
        }
        public string NombreEquipo
        {
            get
            {
                return this.nombreEquipo;
            }
        }

    
        #endregion
    }
}
