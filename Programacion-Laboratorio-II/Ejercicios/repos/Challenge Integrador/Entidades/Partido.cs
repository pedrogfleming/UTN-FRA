using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partido
    {
        private Equipo equipoLocal;
        private Equipo equipoVisitante;
        private int golesLocal;
        private int golesVisitante;
        private bool partidoJugado;
        private Random random;
        private EResultado resultadoEquipoLocal;

        private Partido()
        {
            this.partidoJugado = false;
            this.random = new Random();
        }
        public Partido(Equipo Local,Equipo visitante):this()
        {
            this.equipoLocal = Local;
            this.equipoVisitante = visitante;
        }
        public void SimularPartido()
        {            
            this.golesLocal = random.Next(0, 11);
            this.golesVisitante = random.Next(0, 11);
            this.partidoJugado = true;
            if (this.golesLocal == this.golesVisitante)
            {
                //Empate
                this.resultadoEquipoLocal = EResultado.Empate;
                this.equipoVisitante.Estadistica.Actualizar(EResultado.Empate, this.golesVisitante, this.golesLocal);
            }
            else if(this.golesLocal > this.golesVisitante)
            {
                //Gana Equipo Local
                this.resultadoEquipoLocal = EResultado.Victoria;
                this.equipoVisitante.Estadistica.Actualizar(EResultado.Derrota, this.golesVisitante, this.golesLocal);
            }
            else
            {
                //Gana Equipo Visitante
                this.resultadoEquipoLocal = EResultado.Derrota;
                this.equipoVisitante.Estadistica.Actualizar(EResultado.Victoria, this.golesVisitante, this.golesLocal);
            }
            this.equipoLocal.Estadistica.Actualizar(this.resultadoEquipoLocal,this.golesLocal,this.golesVisitante);
        }
    }
}
