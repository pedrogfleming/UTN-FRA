using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadistica
    {
        private int empatados;
        private int ganados;
        private int golesEnContra;
        private int golesFavor;
        private int partJugados;
        private int perdidos;
        private int puntos;

        public Estadistica()
        {
            this.empatados = 0;
            this.ganados = 0;
            this.golesEnContra = 0;
            this.golesFavor = 0;
            this.PartJugados = 0;
            this.perdidos = 0;
            this.puntos = 0;
        }
        #region Propiedades
        public int Empatados 
        {
            get
            {
                return this.empatados;
            }
        }
        public int Ganados
        {
            get
            {
                return this.ganados;
            }
        }
        public int GolesFavor
        {
            get
            {
                return this.golesFavor;
            }
        }
        public int GolesNegativos
        {
            get
            {
                return this.golesEnContra;
            }
        }
        public int PartJugados
        {
            get
            {
                return this.partJugados;
            }
            set
            {
                if(value >= 0)
                {
                    this.partJugados = value;
                }
            }
        }
        public int Perdidos
        {
            get
            {
                return this.perdidos;
            }
        }
        public int Puntos
        {
            get
            {
                return this.puntos;
            }
        }
        #endregion
        public void Actualizar(EResultado resu,int golFav,int golNeg)
        {
            this.PartJugados++;
            this.golesFavor += golFav;
            this.golesEnContra += golNeg;
            switch (resu)
            {
                case EResultado.Victoria:
                    this.ganados++;
                    this.puntos += 3;
                    break;
                case EResultado.Empate:
                    this.empatados++;
                    this.puntos ++;
                    break;
                case EResultado.Derrota:
                    this.perdidos++;
                    break;
            }
        }
    }
}
