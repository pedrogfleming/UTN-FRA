using System;

namespace _29_Equipos
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre)
        {
            if (!String.IsNullOrEmpty(nombre))
            {
                this.dni = dni;
                this.nombre = nombre;
            }
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public string MostrarDatos()
        {
            string stringAux = this.dni.ToString() + this.nombre + this.partidosJugados.ToString() +
                                this.promedioGoles.ToString() + this.totalGoles.ToString();
            return stringAux;
        }
        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)partidosJugados / totalGoles;
            return this.promedioGoles;
        }
        #region Sobrecarga == & !=
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            if(j1.dni == j2.dni)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }
        #endregion
    }
}
