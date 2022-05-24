using System;

namespace _35_DirectorTecnico
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;
        #region Constructores
        public Jugador(int dni, string nombre) : base(dni, nombre)
        {        
            
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion
        #region Propiedades        
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public float PromedioGoles
        {
            get
            {
                return (float)partidosJugados / totalGoles;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        #endregion

        public string MostrarDatos()
        {
            string stringAux = base.MostrarDatos() + this.PartidosJugados.ToString() +
                                this.PromedioGoles.ToString() + this.TotalGoles.ToString();
            return stringAux;
        }
        #region Sobrecarga == & !=
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            if(j1.Dni == j2.Dni)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);
        }
        #endregion
    }
}
